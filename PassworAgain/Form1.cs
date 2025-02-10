using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace PassworAgain
{
    public partial class Form1 : Form
    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json"); // Changed path
        private readonly string keyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key.bin"); // Key File Path
        private readonly string ivPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "iv.bin"); // IV File Path

        public Form1()
        {
            InitializeComponent();
            this.Hide();
            Login loginForm = new();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                LoadData(); // Load and decrypt data
            }
            else
            {
                Application.Exit();
            }
        }

        private void SaveData()
        {
            List<SaveMe> dataList = new List<SaveMe>();
            foreach (ListViewItem item in listView.Items)
            {
                dataList.Add(new SaveMe
                {
                    Email = item.SubItems[0].Text,
                    App_Web = item.SubItems[1].Text,
                    Password = item.SubItems[2].Text
                });
            }

            try
            {
                // Generate a new Key and IV for each save operation to enhance security.
                GenerateKeyAndIV(out byte[] key, out byte[] iv);

                // Serialize the data to JSON
                string jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);

                // Encrypt the JSON data
                byte[] encryptedData = EncryptString(jsonData, key, iv);

                // Write the encrypted data to the file
                File.WriteAllBytes(filePath, encryptedData);

                // Save the Key and IV to files
                SaveKeyAndIV(keyPath, ivPath, key, iv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            if (!File.Exists(filePath) || !File.Exists(keyPath) || !File.Exists(ivPath))
            {
                MessageBox.Show("Encryption key or data file not found. Starting with an empty list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if files are missing.
            }

            try
            {
                byte[] key = File.ReadAllBytes(keyPath);
                byte[] iv = File.ReadAllBytes(ivPath);
                byte[] encryptedData = File.ReadAllBytes(filePath);

                string jsonData = DecryptString(encryptedData, key, iv);

                List<SaveMe> dataList = JsonConvert.DeserializeObject<List<SaveMe>>(jsonData);

                listView.Items.Clear();
                if (dataList != null) // Check for null after deserialization
                {
                    foreach (var item in dataList)
                    {
                        ListViewItem lvItem = new ListViewItem(item.Email);
                        lvItem.SubItems.Add(item.App_Web);
                        lvItem.SubItems.Add(item.Password);
                        listView.Items.Add(lvItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveMe data = new SaveMe
            {
                Email = txtEmail.Text,
                App_Web = txtApp.Text,
                Password = txtPass.Text
            };

            ListViewItem item = new(data.Email);
            item.SubItems.Add(data.App_Web);
            item.SubItems.Add(data.Password);

            listView.Items.Add(item);

            txtEmail.Clear();
            txtApp.Clear();
            txtPass.Clear();

            SaveData(); // Save and encrypt data after adding
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to remove.");
                return;
            }

            foreach (ListViewItem lv in listView.SelectedItems)
            {
                listView.Items.Remove(lv);
            }
            SaveData(); // Save and encrypt after removing.
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            string searchText = txtSrc.Text.ToLower();
            listView.SelectedItems.Clear();

            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems[1].Text.ToLower().Contains(searchText))
                {
                    listView.Items.Remove(item);
                    listView.Items.Insert(0, item);
                    item.Selected = true;
                    listView.EnsureVisible(item.Index);
                    break;
                }
            }

            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No matching item found.");
            }
        }

        private static byte[] EncryptString(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return ms.ToArray();
                }
            }
        }

        private static string DecryptString(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }

        private static void SaveKeyAndIV(string keyPath, string ivPath, byte[] key, byte[] iv)
        {
            
            try
            {
                File.WriteAllBytes(keyPath, key);
                File.WriteAllBytes(ivPath, iv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving key/IV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void GenerateKeyAndIV(out byte[] key, out byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey(); // Generate a new key
                aes.GenerateIV();  // Generate a new IV

                key = aes.Key;
                iv = aes.IV;
            }
        }
    }

    public class SaveMe
    {
        public string? Email { get; set; }
        public string? App_Web { get; set; }
        public string? Password { get; set; }
    }
}
