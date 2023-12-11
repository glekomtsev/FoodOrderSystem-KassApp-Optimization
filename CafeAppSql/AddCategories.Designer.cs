namespace CafeAppSql
{
    partial class AddCategories
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
            txtCategoriesName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCategoriesName
            // 
            txtCategoriesName.Location = new Point(119, 49);
            txtCategoriesName.Name = "txtCategoriesName";
            txtCategoriesName.Size = new Size(248, 27);
            txtCategoriesName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 45);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(216, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 39);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 166);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtCategoriesName);
            Name = "AddCategories";
            Text = "AddCategories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoriesName;
        private Label label1;
        private Button btnAdd;
        private Button btnCancel;
    }
}