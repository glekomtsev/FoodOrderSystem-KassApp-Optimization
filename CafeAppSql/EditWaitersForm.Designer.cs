namespace CafeAppSql
{
    partial class EditWaitersForm
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
            dataGridWaiters = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtWaiterLastname = new TextBox();
            txtWaiterName = new TextBox();
            txtWaiterPatronymic = new TextBox();
            label4 = new Label();
            cmbBoxPost = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnSaveChange = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridWaiters).BeginInit();
            SuspendLayout();
            // 
            // dataGridWaiters
            // 
            dataGridWaiters.AllowUserToAddRows = false;
            dataGridWaiters.AllowUserToDeleteRows = false;
            dataGridWaiters.AllowUserToResizeColumns = false;
            dataGridWaiters.AllowUserToResizeRows = false;
            dataGridWaiters.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridWaiters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWaiters.Location = new Point(12, 12);
            dataGridWaiters.Name = "dataGridWaiters";
            dataGridWaiters.ReadOnly = true;
            dataGridWaiters.RowHeadersVisible = false;
            dataGridWaiters.RowHeadersWidth = 51;
            dataGridWaiters.RowTemplate.Height = 29;
            dataGridWaiters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridWaiters.Size = new Size(604, 341);
            dataGridWaiters.TabIndex = 0;
            dataGridWaiters.Click += dataGridWaiters_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(633, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 1;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(633, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(633, 137);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 1;
            label3.Text = "Отчество";
            // 
            // txtWaiterLastname
            // 
            txtWaiterLastname.Location = new Point(763, 24);
            txtWaiterLastname.Name = "txtWaiterLastname";
            txtWaiterLastname.Size = new Size(292, 27);
            txtWaiterLastname.TabIndex = 2;
            // 
            // txtWaiterName
            // 
            txtWaiterName.Location = new Point(763, 82);
            txtWaiterName.Name = "txtWaiterName";
            txtWaiterName.Size = new Size(292, 27);
            txtWaiterName.TabIndex = 2;
            // 
            // txtWaiterPatronymic
            // 
            txtWaiterPatronymic.Location = new Point(763, 141);
            txtWaiterPatronymic.Name = "txtWaiterPatronymic";
            txtWaiterPatronymic.Size = new Size(292, 27);
            txtWaiterPatronymic.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(633, 192);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 1;
            label4.Text = "Должность";
            // 
            // cmbBoxPost
            // 
            cmbBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxPost.FormattingEnabled = true;
            cmbBoxPost.Location = new Point(763, 196);
            cmbBoxPost.Name = "cmbBoxPost";
            cmbBoxPost.Size = new Size(292, 28);
            cmbBoxPost.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(633, 249);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 1;
            label5.Text = "Логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(633, 308);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 1;
            label6.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(763, 253);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(292, 27);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(763, 312);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 27);
            txtPassword.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 365);
            button1.Name = "button1";
            button1.Size = new Size(201, 77);
            button1.TabIndex = 4;
            button1.Text = "Добавить сотрудника";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(415, 365);
            button2.Name = "button2";
            button2.Size = new Size(201, 77);
            button2.TabIndex = 4;
            button2.Text = "Удалить сотрудника";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSaveChange
            // 
            btnSaveChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveChange.Location = new Point(854, 365);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(201, 77);
            btnSaveChange.TabIndex = 4;
            btnSaveChange.Text = "Сохранить изменения";
            btnSaveChange.UseVisualStyleBackColor = true;
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // EditWaitersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 454);
            Controls.Add(btnSaveChange);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(dataGridWaiters);
            Name = "EditWaitersForm";
            Text = "EditWaitersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridWaiters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridWaiters;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtWaiterLastname;
        private TextBox txtWaiterName;
        private TextBox txtWaiterPatronymic;
        private Label label4;
        private ComboBox cmbBoxPost;
        private Label label5;
        private Label label6;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button button1;
        private Button button2;
        private Button btnSaveChange;
    }
}