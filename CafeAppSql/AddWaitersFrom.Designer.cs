namespace CafeAppSql
{
    partial class AddWaitersFrom
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
            cmbBoxPost = new ComboBox();
            txtWaiterPatronymic = new TextBox();
            txtWaiterName = new TextBox();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            txtWaiterLastname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddWaiter = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbBoxPost
            // 
            cmbBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxPost.FormattingEnabled = true;
            cmbBoxPost.Location = new Point(142, 199);
            cmbBoxPost.Name = "cmbBoxPost";
            cmbBoxPost.Size = new Size(292, 28);
            cmbBoxPost.TabIndex = 15;
            // 
            // txtWaiterPatronymic
            // 
            txtWaiterPatronymic.Location = new Point(142, 144);
            txtWaiterPatronymic.Name = "txtWaiterPatronymic";
            txtWaiterPatronymic.Size = new Size(292, 27);
            txtWaiterPatronymic.TabIndex = 10;
            // 
            // txtWaiterName
            // 
            txtWaiterName.Location = new Point(142, 85);
            txtWaiterName.Name = "txtWaiterName";
            txtWaiterName.Size = new Size(292, 27);
            txtWaiterName.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(142, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(142, 256);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(292, 27);
            txtLogin.TabIndex = 13;
            // 
            // txtWaiterLastname
            // 
            txtWaiterLastname.Location = new Point(142, 27);
            txtWaiterLastname.Name = "txtWaiterLastname";
            txtWaiterLastname.Size = new Size(292, 27);
            txtWaiterLastname.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 311);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 4;
            label6.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 252);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 5;
            label5.Text = "Логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 6;
            label4.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 7;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 8;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 9;
            label1.Text = "Фамилия";
            // 
            // btnAddWaiter
            // 
            btnAddWaiter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddWaiter.Location = new Point(14, 379);
            btnAddWaiter.Name = "btnAddWaiter";
            btnAddWaiter.Size = new Size(190, 71);
            btnAddWaiter.TabIndex = 16;
            btnAddWaiter.Text = "Добавить";
            btnAddWaiter.UseVisualStyleBackColor = true;
            btnAddWaiter.Click += btnAddWaiter_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(244, 379);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(190, 71);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddWaitersFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 474);
            Controls.Add(btnCancel);
            Controls.Add(btnAddWaiter);
            Controls.Add(cmbBoxPost);
            Controls.Add(txtWaiterPatronymic);
            Controls.Add(txtWaiterName);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtWaiterLastname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddWaitersFrom";
            Text = "AddWaitersFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoxPost;
        private TextBox txtWaiterPatronymic;
        private TextBox txtWaiterName;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private TextBox txtWaiterLastname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddWaiter;
        private Button btnCancel;
    }
}