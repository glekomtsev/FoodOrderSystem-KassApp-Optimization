using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeAppSql
{
    public partial class EditOrderForm : Form
    {


        public EditOrderForm()
        {
            InitializeComponent();
            LoadForms();
        }

        private void LoadForms()
        {
            dataGridOrders.Rows.Clear();
            dataGridOrders.Columns.Clear();
            dataGridItemsOrder.Rows.Clear();
            dataGridItemsOrder.Columns.Clear();
            cmbWaiters.Items.Clear();

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                dataGridOrders.Columns.Add("OrderId", "Номер заказа");
                dataGridOrders.Columns.Add("WaiterId", "Официант");
                dataGridOrders.Columns.Add("OrderTime", "Дата и время");
                dataGridOrders.Columns.Add("TotalPrice", "Сумма");
                dataGridOrders.Columns[1].Width = 230;
                dataGridOrders.Columns[2].Width = 160;

                dataGridItemsOrder.Columns.Add("DishName", "Название блюда");
                dataGridItemsOrder.Columns.Add("DishPrice", "Цена одной позиции");
                dataGridItemsOrder.Columns.Add("DishQuantity", "Кол-во");
                dataGridItemsOrder.Columns[0].Width = 230;

                var waiters = context.Waiters.ToList();
                foreach (var waiter in waiters)
                {
                    cmbWaiters.Items.Add(waiter.WaiterName + " " + waiter.WaiterLastname);
                }


                var orders = context.Orders.OrderByDescending(e => e.OrderTime).ToList();

                foreach (var order in orders)
                {
                    string waitersName = context.Waiters
                        .Where(e => e.WaiterId == order.WaiterId)
                        .Select(e => e.WaiterName + " " + e.WaiterLastname)
                        .FirstOrDefault();

                    decimal totalPrice = context.OrderItems
                        .Where(e => e.OrderId == order.OrderId)
                        .Select(e => e.Quantity * context.Dishes
                            .Where(x => x.DishId == e.DishId)
                            .Select(p => p.DishPrice)
                            .FirstOrDefault())
                        .Sum();

                    totalPrice = Math.Round(totalPrice, 2);

                    dataGridOrders.Rows.Add(order.OrderId, waitersName, order.OrderTime, totalPrice);
                }
            }
        }

        private void dataGridOrders_Click(object sender, EventArgs e)
        {
            dataGridItemsOrder.Rows.Clear();

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                if (dataGridOrders.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridOrders.SelectedRows[0].Index;

                    int orderId = Convert.ToInt32(dataGridOrders.Rows[selectedRowIndex].Cells["OrderId"].Value);

                    var itemsOrders = context.OrderItems
                        .Where(e => e.OrderId == orderId)
                        .ToList();

                    foreach (var item in itemsOrders)
                    {
                        var dish = context.Dishes
                            .Where(d => d.DishId == item.DishId)
                            .FirstOrDefault();

                        if (dish != null)
                        {
                            string dishName = dish.DishName;
                            decimal dishPrice = Math.Round(dish.DishPrice, 2);
                            dataGridItemsOrder.Rows.Add(dishName, dishPrice, item.Quantity);
                        }
                    }
                }
            }
        }
        //Фильтрация заказов по сотрудникам
        private void cmbWaiters_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridOrders.Rows.Clear();
            dataGridItemsOrder.Rows.Clear();

            string selectedValue = cmbWaiters.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedValue))
                return;

            string[] parts = selectedValue.Split(' ');
            if (parts.Length < 2)
                return;

            string firstName = parts[0];
            string lastName = parts[1];

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                var waiterId = context.Waiters
                    .Where(w => w.WaiterName == firstName && w.WaiterLastname == lastName)
                    .Select(w => w.WaiterId)
                    .FirstOrDefault();

                if (waiterId == 0)
                    return;

                var orders = context.Orders
                    .Where(o => o.WaiterId == waiterId)
                    .OrderByDescending(o => o.OrderTime)
                    .ToList();

                foreach (var order in orders)
                {
                    string waitersName = context.Waiters
                        .Where(w => w.WaiterId == order.WaiterId)
                        .Select(w => $"{w.WaiterName} {w.WaiterLastname}")
                        .FirstOrDefault();

                    decimal totalPrice = context.OrderItems
                        .Where(oi => oi.OrderId == order.OrderId)
                        .Sum(oi => oi.Quantity * context.Dishes
                            .Where(d => d.DishId == oi.DishId)
                            .Select(d => d.DishPrice)
                            .FirstOrDefault());

                    totalPrice = Math.Round(totalPrice, 2);

                    dataGridOrders.Rows.Add(order.OrderId, waitersName, order.OrderTime, totalPrice);
                }
            }
        }


        private void btnClearWaiter_Click(object sender, EventArgs e)
        {
            LoadForms();
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                if (dataGridOrders.CurrentRow != null)
                {
                    int orderId = Convert.ToInt32(dataGridOrders.CurrentRow.Cells["OrderId"].Value);
                    DialogResult result = MessageBox.Show($"Удалить заказ №{orderId}? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {                        
                        var orderItemsToRemove = context.OrderItems.Where(oi => oi.OrderId == orderId);

                        context.OrderItems.RemoveRange(orderItemsToRemove);

                        var orderToRemove = context.Orders.Where(o => o.OrderId == orderId);
                        context.Orders.RemoveRange(orderToRemove);
                        context.SaveChanges();
                        LoadForms();
                    }
                }
                else {
                    MessageBox.Show($"Выберете заказ ", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
