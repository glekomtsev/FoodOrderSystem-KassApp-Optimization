using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAppSql
{
    public partial class MainMenu : Form
    {
        private System.Windows.Forms.Timer timer;
        private int waiterEnterId;

        public MainMenu()
        {
            InitializeComponent();
            LoadMineMenu();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => ShowTime();
            timer.Start();
        }

        public MainMenu(int waiterId)
        {
            this.waiterEnterId = waiterId;
            InitializeComponent();
            LoadMineMenu();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => ShowTime();
            timer.Start();
            LoadWaiterPost();
        }

        void LoadMineMenu()
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                listBoxCategories.Items.Clear();
                listBoxCategories.Items.AddRange(context.Categories.Select(c => c.CategoriesName).ToArray());

                dataGridMenu.Columns.Add("DishId", "ID");
                dataGridMenu.Columns.Add("DishName", "Название блюда");
                dataGridMenu.Columns.Add("DishPrice", "Цена блюда");
                dataGridMenu.Columns[0].Visible = false;
                dataGridMenu.Columns[1].Width = 285;

                dataGridOrder.Columns.Add("DishId", "ID");
                dataGridOrder.Columns.Add("DishName", "Название блюда");
                dataGridOrder.Columns.Add("DishPrice", "Цена блюда");
                dataGridOrder.Columns.Add("DishCount", "Кол-во");
                dataGridOrder.Columns[0].Visible = false;
                dataGridOrder.Columns[1].Width = 285;
            }
        }

        private void LoadWaiterPost()
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {




                lblWaiterName.Text = context.Waiters
                    .Where(e => e.WaiterId == waiterEnterId)
                    .Select(e => e.WaiterLastname + " " + e.WaiterName)
                    .FirstOrDefault()
                    .ToString();

                bool isAdmin = context.Waiters
                 .Where(e => e.WaiterId == waiterEnterId)
                 .Select(e => e.Post)
                 .FirstOrDefault() ?? false;

                if (isAdmin)
                {
                    lblWaiterPost.Text = "Администратор:";

                }
                else
                {
                    lblWaiterPost.Text = "Официант:";
                    btnOpenDishMenu.Enabled = false;
                    btnOpenOrderForm.Enabled = false;
                    btnOpenWaiters.Enabled = false;
                }
            }
        }
        //Загрузка блюд из выбраной категории блюд
        private void listBoxCategories_Click(object sender, EventArgs e)
        {
            string selectedCategoryName = listBoxCategories.SelectedItem?.ToString();

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                if (!string.IsNullOrEmpty(selectedCategoryName))
                {
                    int categoryId = context.Categories
                        .Where(c => c.CategoriesName == selectedCategoryName)
                        .Select(c => c.CategoriesId)
                        .FirstOrDefault();

                    LoadDishesByCategoryId(categoryId);
                }
            }
        }
        private void LoadDishesByCategoryId(int categoryId)
        {
            using (CafeDataBaseContext enty = new CafeDataBaseContext())
            {
                dataGridMenu.Rows.Clear();

                var dishes = enty.Dishes
                    .Where(d => d.CategoriesId == categoryId)
                    .ToList();

                foreach (var dish in dishes)
                {
                    dataGridMenu.Rows.Add(dish.DishId, dish.DishName, dish.DishPrice);
                }
            }
        }

        private void dataGridMenu_DoubleClick(object sender, EventArgs e)
        {
            using (CafeDataBaseContext entity = new CafeDataBaseContext())
            {
                foreach (DataGridViewRow row in dataGridMenu.SelectedRows)
                {
                    int dishId = (int)row.Cells["DishId"].Value;
                    string dishName = row.Cells["DishName"].Value.ToString();
                    decimal dishPrice = (decimal)row.Cells["DishPrice"].Value;

                    int existingRowIndex = dataGridOrder.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => (int)r.Cells["DishId"].Value == dishId)?.Index ?? -1;

                    if (existingRowIndex != -1)
                    {
                        int currentCount = (int)dataGridOrder.Rows[existingRowIndex].Cells["DishCount"].Value;
                        dataGridOrder.Rows[existingRowIndex].Cells["DishCount"].Value = currentCount + 1;
                    }
                    else
                    {
                        dataGridOrder.Rows.Add(dishId, dishName, dishPrice, 1);
                    }
                }
            }
            CalculateTotalPrice();
        }

        private void dataGridOrder_DoubleClick(object sender, EventArgs e)
        {
            using (CafeDataBaseContext entity = new CafeDataBaseContext())
            {
                if (dataGridOrder.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridOrder.SelectedRows[0];

                    int currentCount = (int)selectedRow.Cells["DishCount"].Value;

                    if (currentCount > 1)
                    {
                        selectedRow.Cells["DishCount"].Value = currentCount - 1;
                    }
                    else
                    {
                        dataGridOrder.Rows.Remove(selectedRow);
                    }
                }
            }
            CalculateTotalPrice();
        }

        void CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridOrder.Rows)
            {
                int dishCount = (int)row.Cells["DishCount"].Value;
                decimal dishPrice = (decimal)row.Cells["DishPrice"].Value;

                totalPrice += dishCount * dishPrice;
            }

            lblTotalPrice.Text = totalPrice.ToString();
        }

        void ShowTime()
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            labelTime.Text = formattedTime;
        }

        private void btnOpenOrderForm_Click(object sender, EventArgs e)
        {
            new EditOrderForm().Show();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                if (dataGridOrder.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Создать новый заказ? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Order newOrder = new Order
                        {
                            WaiterId = waiterEnterId,
                            OrderTime = DateTime.Now
                        };

                        context.Orders.Add(newOrder);
                        context.SaveChanges();

                        int orderId = newOrder.OrderId;

                        foreach (DataGridViewRow row in dataGridOrder.Rows)
                        {
                            int dishId = (int)row.Cells["DishId"].Value;
                            int quantity = (int)row.Cells["DishCount"].Value;

                            OrderItem orderItem = new OrderItem
                            {
                                OrderId = orderId,
                                DishId = dishId,
                                Quantity = quantity
                            };

                            context.OrderItems.Add(orderItem);
                        }

                        context.SaveChanges();
                        MessageBox.Show("Заказ успешно создан.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно создать заказ. Заказ пустой.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnDishMenu_Click(object sender, EventArgs e)
        {
            new EditDishForm().ShowDialog();
        }

        private void btnOpenWaiters_Click(object sender, EventArgs e)
        {
            new EditWaitersForm(waiterEnterId).ShowDialog();
        }
    }
}
