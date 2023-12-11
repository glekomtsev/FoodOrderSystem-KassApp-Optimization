namespace CafeAppSql
{
    partial class AddDishForm
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
            txtDishName = new TextBox();
            txtDishPrice = new TextBox();
            cmbCategories = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAddDish = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtDishName
            // 
            txtDishName.Location = new Point(197, 35);
            txtDishName.Name = "txtDishName";
            txtDishName.Size = new Size(198, 27);
            txtDishName.TabIndex = 0;
            // 
            // txtDishPrice
            // 
            txtDishPrice.Location = new Point(197, 95);
            txtDishPrice.Name = "txtDishPrice";
            txtDishPrice.Size = new Size(198, 27);
            txtDishPrice.TabIndex = 1;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(197, 153);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(198, 28);
            cmbCategories.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 31);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 149);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 4;
            label3.Text = "Категория";
            // 
            // btnAddDish
            // 
            btnAddDish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDish.Location = new Point(54, 225);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new Size(142, 74);
            btnAddDish.TabIndex = 5;
            btnAddDish.Text = "Добавить";
            btnAddDish.UseVisualStyleBackColor = true;
            btnAddDish.Click += btnAddDish_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(253, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 74);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddDishForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 340);
            Controls.Add(btnCancel);
            Controls.Add(btnAddDish);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Controls.Add(txtDishPrice);
            Controls.Add(txtDishName);
            Name = "AddDishForm";
            Text = "AddDishForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDishName;
        private TextBox txtDishPrice;
        private ComboBox cmbCategories;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddDish;
        private Button btnCancel;
    }
}