﻿namespace CafeAppSql
{
    partial class EditDishForm
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
            lblMenu = new Label();
            lblCategoriesName = new Label();
            dataGridMenu = new DataGridView();
            listBoxCategories = new ListBox();
            txtDishName = new TextBox();
            cmbCategories = new ComboBox();
            txtDishPrice = new TextBox();
            btnChangeDish = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).BeginInit();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(249, 21);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(95, 31);
            lblMenu.TabIndex = 6;
            lblMenu.Text = "Блюда";
            // 
            // lblCategoriesName
            // 
            lblCategoriesName.AutoSize = true;
            lblCategoriesName.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoriesName.Location = new Point(13, 21);
            lblCategoriesName.Name = "lblCategoriesName";
            lblCategoriesName.Size = new Size(137, 31);
            lblCategoriesName.TabIndex = 7;
            lblCategoriesName.Text = "Категории";
            // 
            // dataGridMenu
            // 
            dataGridMenu.AllowUserToAddRows = false;
            dataGridMenu.AllowUserToDeleteRows = false;
            dataGridMenu.AllowUserToResizeColumns = false;
            dataGridMenu.AllowUserToResizeRows = false;
            dataGridMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMenu.Location = new Point(249, 73);
            dataGridMenu.Name = "dataGridMenu";
            dataGridMenu.ReadOnly = true;
            dataGridMenu.RowHeadersVisible = false;
            dataGridMenu.RowHeadersWidth = 51;
            dataGridMenu.RowTemplate.Height = 29;
            dataGridMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMenu.Size = new Size(413, 365);
            dataGridMenu.TabIndex = 5;
            dataGridMenu.Click += dataGridMenu_Click;
            // 
            // listBoxCategories
            // 
            listBoxCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 28;
            listBoxCategories.Location = new Point(13, 70);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(204, 368);
            listBoxCategories.TabIndex = 4;
            listBoxCategories.Click += listBoxCategories_Click;
            // 
            // txtDishName
            // 
            txtDishName.Location = new Point(849, 73);
            txtDishName.Name = "txtDishName";
            txtDishName.Size = new Size(214, 27);
            txtDishName.TabIndex = 8;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(849, 124);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(214, 28);
            cmbCategories.TabIndex = 9;
            // 
            // txtDishPrice
            // 
            txtDishPrice.Location = new Point(849, 177);
            txtDishPrice.Name = "txtDishPrice";
            txtDishPrice.Size = new Size(214, 27);
            txtDishPrice.TabIndex = 10;
            // 
            // btnChangeDish
            // 
            btnChangeDish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeDish.Location = new Point(711, 227);
            btnChangeDish.Name = "btnChangeDish";
            btnChangeDish.Size = new Size(352, 65);
            btnChangeDish.TabIndex = 11;
            btnChangeDish.Text = "Сохранить изменения";
            btnChangeDish.UseVisualStyleBackColor = true;
            btnChangeDish.Click += btnChangeDish_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(711, 69);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 12;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(711, 120);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 12;
            label2.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(711, 173);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 12;
            label3.Text = "Цена";
            // 
            // EditDishForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 544);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChangeDish);
            Controls.Add(txtDishPrice);
            Controls.Add(cmbCategories);
            Controls.Add(txtDishName);
            Controls.Add(lblMenu);
            Controls.Add(lblCategoriesName);
            Controls.Add(dataGridMenu);
            Controls.Add(listBoxCategories);
            Name = "EditDishForm";
            Text = "EditDishForm";
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Label lblCategoriesName;
        private DataGridView dataGridMenu;
        private ListBox listBoxCategories;
        private TextBox txtDishName;
        private ComboBox cmbCategories;
        private TextBox txtDishPrice;
        private Button btnChangeDish;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}