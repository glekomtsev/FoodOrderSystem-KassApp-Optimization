namespace CafeAppSql
{
    partial class EditOrderForm
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
            dataGridOrders = new DataGridView();
            dataGridItemsOrder = new DataGridView();
            cmbWaiters = new ComboBox();
            label1 = new Label();
            btnClearWaiter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItemsOrder).BeginInit();
            SuspendLayout();
            // 
            // dataGridOrders
            // 
            dataGridOrders.AllowUserToAddRows = false;
            dataGridOrders.AllowUserToDeleteRows = false;
            dataGridOrders.AllowUserToResizeColumns = false;
            dataGridOrders.AllowUserToResizeRows = false;
            dataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrders.Location = new Point(12, 73);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.ReadOnly = true;
            dataGridOrders.RowHeadersVisible = false;
            dataGridOrders.RowHeadersWidth = 51;
            dataGridOrders.RowTemplate.Height = 29;
            dataGridOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOrders.Size = new Size(678, 350);
            dataGridOrders.TabIndex = 0;
            dataGridOrders.Click += dataGridOrders_Click;
            // 
            // dataGridItemsOrder
            // 
            dataGridItemsOrder.AllowUserToAddRows = false;
            dataGridItemsOrder.AllowUserToDeleteRows = false;
            dataGridItemsOrder.AllowUserToResizeColumns = false;
            dataGridItemsOrder.AllowUserToResizeRows = false;
            dataGridItemsOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItemsOrder.Location = new Point(708, 73);
            dataGridItemsOrder.Name = "dataGridItemsOrder";
            dataGridItemsOrder.ReadOnly = true;
            dataGridItemsOrder.RowHeadersVisible = false;
            dataGridItemsOrder.RowHeadersWidth = 51;
            dataGridItemsOrder.RowTemplate.Height = 29;
            dataGridItemsOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridItemsOrder.Size = new Size(522, 350);
            dataGridItemsOrder.TabIndex = 0;
            // 
            // cmbWaiters
            // 
            cmbWaiters.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWaiters.FormattingEnabled = true;
            cmbWaiters.Location = new Point(123, 27);
            cmbWaiters.Name = "cmbWaiters";
            cmbWaiters.Size = new Size(172, 28);
            cmbWaiters.TabIndex = 1;
            cmbWaiters.SelectedIndexChanged += cmbWaiters_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "Официант";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnClearWaiter
            // 
            btnClearWaiter.Location = new Point(301, 27);
            btnClearWaiter.Name = "btnClearWaiter";
            btnClearWaiter.Size = new Size(94, 29);
            btnClearWaiter.TabIndex = 3;
            btnClearWaiter.Text = "Очистить";
            btnClearWaiter.UseVisualStyleBackColor = true;
            btnClearWaiter.Click += btnClearWaiter_Click;
            // 
            // EditOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 453);
            Controls.Add(btnClearWaiter);
            Controls.Add(label1);
            Controls.Add(cmbWaiters);
            Controls.Add(dataGridItemsOrder);
            Controls.Add(dataGridOrders);
            Name = "EditOrderForm";
            Text = "EditOrderForm";
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItemsOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridOrders;
        private DataGridView dataGridItemsOrder;
        private ComboBox cmbWaiters;
        private Label label1;
        private Button btnClearWaiter;
    }
}