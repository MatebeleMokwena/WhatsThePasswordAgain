namespace PassworAgain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtApp = new TextBox();
            txtPass = new TextBox();
            btnAdd = new Button();
            btnSrch = new Button();
            btnRmv = new Button();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtSrc = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "App/Web :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 113);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 19);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtApp
            // 
            txtApp.Location = new Point(130, 64);
            txtApp.Name = "txtApp";
            txtApp.Size = new Size(212, 27);
            txtApp.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(130, 113);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(212, 27);
            txtPass.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(674, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSrch
            // 
            btnSrch.Location = new Point(410, 18);
            btnSrch.Name = "btnSrch";
            btnSrch.Size = new Size(94, 29);
            btnSrch.TabIndex = 7;
            btnSrch.Text = "Search";
            btnSrch.UseVisualStyleBackColor = true;
            btnSrch.Click += btnSrch_Click;
            // 
            // btnRmv
            // 
            btnRmv.Location = new Point(674, 281);
            btnRmv.Name = "btnRmv";
            btnRmv.Size = new Size(94, 29);
            btnRmv.TabIndex = 8;
            btnRmv.Text = "Remove";
            btnRmv.UseVisualStyleBackColor = true;
            btnRmv.Click += btnRmv_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView.Location = new Point(190, 179);
            listView.Name = "listView";
            listView.Size = new Size(403, 385);
            listView.TabIndex = 9;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "The App/Web";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Password";
            columnHeader3.Width = 150;
            // 
            // txtSrc
            // 
            txtSrc.Location = new Point(522, 18);
            txtSrc.Name = "txtSrc";
            txtSrc.Size = new Size(212, 27);
            txtSrc.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 587);
            Controls.Add(txtSrc);
            Controls.Add(listView);
            Controls.Add(btnRmv);
            Controls.Add(btnSrch);
            Controls.Add(btnAdd);
            Controls.Add(txtPass);
            Controls.Add(txtApp);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "What is my Password again?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtApp;
        private TextBox txtPass;
        private Button btnAdd;
        private Button btnSrch;
        private Button btnRmv;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtSrc;
    }
}
