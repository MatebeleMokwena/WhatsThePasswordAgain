namespace PassworAgain
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            btnLog = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 87);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 206);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(158, 199);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(174, 27);
            txtPass.TabIndex = 3;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(505, 202);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(94, 29);
            btnLog.TabIndex = 4;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(505, 82);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close/Exit";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 320);
            Controls.Add(btnClose);
            Controls.Add(btnLog);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPass;
        private Button btnLog;
        private Button btnClose;
    }
}