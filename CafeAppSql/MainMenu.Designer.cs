namespace CafeAppSql
{
    partial class MainMenu
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
            listBoxCategories = new ListBox();
            dataGridMenu = new DataGridView();
            dataGridOrder = new DataGridView();
            lblCategoriesName = new Label();
            lblMenu = new Label();
            lblOrder = new Label();
            btnAddOrder = new Button();
            btnDelOrder = new Button();
            lblTotal = new Label();
            lblTotalPrice = new Label();
            labelTime = new Label();
            btnOpenOrderForm = new Button();
            btnCreateOrder = new Button();
            btnDishMenu = new Button();
            lblWaiterPost = new Label();
            lblWaiterName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).BeginInit();
            SuspendLayout();
            // 
            // listBoxCategories
            // 
            listBoxCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 28;
            listBoxCategories.Location = new Point(12, 242);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(204, 368);
            listBoxCategories.TabIndex = 0;
            listBoxCategories.Click += listBoxCategories_Click;
            // 
            // dataGridMenu
            // 
            dataGridMenu.AllowUserToAddRows = false;
            dataGridMenu.AllowUserToDeleteRows = false;
            dataGridMenu.AllowUserToResizeColumns = false;
            dataGridMenu.AllowUserToResizeRows = false;
            dataGridMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMenu.Location = new Point(248, 245);
            dataGridMenu.Name = "dataGridMenu";
            dataGridMenu.ReadOnly = true;
            dataGridMenu.RowHeadersVisible = false;
            dataGridMenu.RowHeadersWidth = 51;
            dataGridMenu.RowTemplate.Height = 29;
            dataGridMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMenu.Size = new Size(413, 365);
            dataGridMenu.TabIndex = 1;
            dataGridMenu.DoubleClick += dataGridMenu_DoubleClick;
            // 
            // dataGridOrder
            // 
            dataGridOrder.AllowUserToAddRows = false;
            dataGridOrder.AllowUserToDeleteRows = false;
            dataGridOrder.AllowUserToResizeColumns = false;
            dataGridOrder.AllowUserToResizeRows = false;
            dataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrder.Location = new Point(894, 245);
            dataGridOrder.Name = "dataGridOrder";
            dataGridOrder.ReadOnly = true;
            dataGridOrder.RowHeadersVisible = false;
            dataGridOrder.RowHeadersWidth = 51;
            dataGridOrder.RowTemplate.Height = 29;
            dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOrder.Size = new Size(540, 368);
            dataGridOrder.TabIndex = 2;
            dataGridOrder.DoubleClick += dataGridOrder_DoubleClick;
            // 
            // lblCategoriesName
            // 
            lblCategoriesName.AutoSize = true;
            lblCategoriesName.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoriesName.Location = new Point(12, 193);
            lblCategoriesName.Name = "lblCategoriesName";
            lblCategoriesName.Size = new Size(137, 31);
            lblCategoriesName.TabIndex = 3;
            lblCategoriesName.Text = "Категории";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(248, 193);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(95, 31);
            lblMenu.TabIndex = 3;
            lblMenu.Text = "Блюда";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrder.Location = new Point(894, 193);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(79, 31);
            lblOrder.TabIndex = 3;
            lblOrder.Text = "Заказ";
            // 
            // btnAddOrder
            // 
            btnAddOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddOrder.Location = new Point(701, 277);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(163, 66);
            btnAddOrder.TabIndex = 4;
            btnAddOrder.Text = "Добавить >>>";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += dataGridMenu_DoubleClick;
            // 
            // btnDelOrder
            // 
            btnDelOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelOrder.Location = new Point(701, 349);
            btnDelOrder.Name = "btnDelOrder";
            btnDelOrder.Size = new Size(163, 66);
            btnDelOrder.TabIndex = 4;
            btnDelOrder.Text = "<<< Удалить";
            btnDelOrder.UseVisualStyleBackColor = true;
            btnDelOrder.Click += dataGridOrder_DoubleClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(904, 638);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(91, 31);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Итого:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(1035, 638);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(28, 31);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "0";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.Location = new Point(12, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(112, 31);
            labelTime.TabIndex = 3;
            labelTime.Text = "00:00:00";
            // 
            // btnOpenOrderForm
            // 
            btnOpenOrderForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenOrderForm.Location = new Point(894, 34);
            btnOpenOrderForm.Name = "btnOpenOrderForm";
            btnOpenOrderForm.Size = new Size(163, 67);
            btnOpenOrderForm.TabIndex = 5;
            btnOpenOrderForm.Text = "Меню заказов";
            btnOpenOrderForm.UseVisualStyleBackColor = true;
            btnOpenOrderForm.Click += btnOpenOrderForm_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrder.Location = new Point(1221, 629);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(213, 50);
            btnCreateOrder.TabIndex = 4;
            btnCreateOrder.Text = "Создать заказ";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnDishMenu
            // 
            btnDishMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDishMenu.Location = new Point(492, 34);
            btnDishMenu.Name = "btnDishMenu";
            btnDishMenu.Size = new Size(169, 67);
            btnDishMenu.TabIndex = 6;
            btnDishMenu.Text = "Меню блюд";
            btnDishMenu.UseVisualStyleBackColor = true;
            btnDishMenu.Click += btnDishMenu_Click;
            // 
            // lblWaiterPost
            // 
            lblWaiterPost.AutoSize = true;
            lblWaiterPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaiterPost.Location = new Point(12, 40);
            lblWaiterPost.Name = "lblWaiterPost";
            lblWaiterPost.Size = new Size(65, 28);
            lblWaiterPost.TabIndex = 7;
            lblWaiterPost.Text = "label1";
            // 
            // lblWaiterName
            // 
            lblWaiterName.AutoSize = true;
            lblWaiterName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaiterName.Location = new Point(12, 68);
            lblWaiterName.Name = "lblWaiterName";
            lblWaiterName.Size = new Size(65, 28);
            lblWaiterName.TabIndex = 8;
            lblWaiterName.Text = "label2";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 718);
            Controls.Add(lblWaiterName);
            Controls.Add(lblWaiterPost);
            Controls.Add(btnDishMenu);
            Controls.Add(btnOpenOrderForm);
            Controls.Add(btnDelOrder);
            Controls.Add(btnCreateOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotal);
            Controls.Add(labelTime);
            Controls.Add(lblOrder);
            Controls.Add(lblMenu);
            Controls.Add(lblCategoriesName);
            Controls.Add(dataGridOrder);
            Controls.Add(dataGridMenu);
            Controls.Add(listBoxCategories);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCategories;
        private DataGridView dataGridMenu;
        private DataGridView dataGridOrder;
        private Label lblCategoriesName;
        private Label lblMenu;
        private Label lblOrder;
        private Button btnAddOrder;
        private Button btnDelOrder;
        private Label lblTotal;
        private Label lblTotalPrice;
        private Label labelTime;
        private Button btnOpenOrderForm;
        private Button btnCreateOrder;
        private Button btnDishMenu;
        private Label lblWaiterPost;
        private Label lblWaiterName;
    }
}