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
    public partial class EditWaitersForm : Form
    {
        private int waiterEnterId;

        public EditWaitersForm()
        {
            InitializeComponent();
        }

        public EditWaitersForm(int waiterEnterId)
        {
            InitializeComponent();
            LoadWaitersMenu();
            this.waiterEnterId = waiterEnterId;
        }
        void LoadWaitersMenu()
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                dataGridWaiters.Rows.Clear();
                dataGridWaiters.Columns.Clear();
                cmbBoxPost.Items.Clear();
                cmbBoxPost.Items.Add("Администратор");
                cmbBoxPost.Items.Add("Официант");
                dataGridWaiters.Columns.Add("WaiterId", "ID");
                dataGridWaiters.Columns.Add("WaiterName", "Фамилия");
                dataGridWaiters.Columns.Add("WaiterLastname", "Имя");
                dataGridWaiters.Columns.Add("WaiterPatronymic", "Отчество");
                dataGridWaiters.Columns.Add("Post", "Должность");
                dataGridWaiters.Columns[0].Visible = false;
                dataGridWaiters.Rows.Clear();


                var waiters = context.Waiters.ToList();

                foreach (var waiter in waiters)
                {
                    string waiterPost = "Официант";
                    if (waiter.Post == true)
                        waiterPost = "Администратор";
                    dataGridWaiters.Rows.Add(waiter.WaiterId, waiter.WaiterLastname, waiter.WaiterName, waiter.WaiterPatronymic, waiterPost);
                }
            }
        }

        private void dataGridWaiters_Click(object sender, EventArgs e)
        {

            if (dataGridWaiters.SelectedRows.Count == 0)
                return;

            int selectWaiterId = (int)dataGridWaiters.SelectedRows[0].Cells["WaiterId"].Value;

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                var selectedWaiter = context.Waiters
                    .FirstOrDefault(d => d.WaiterId == selectWaiterId);

                if (selectedWaiter != null)
                {
                    txtWaiterName.Text = selectedWaiter.WaiterName;
                    txtWaiterLastname.Text = selectedWaiter.WaiterLastname;
                    txtWaiterPatronymic.Text = selectedWaiter.WaiterPatronymic;
                    txtLogin.Text = selectedWaiter.Login;
                    txtPassword.Text = selectedWaiter.Password;
                    if (selectedWaiter.Post == true)
                    {
                        int index = cmbBoxPost.FindStringExact("Администратор");
                        cmbBoxPost.SelectedIndex = index;
                    }
                    else
                    {
                        int index = cmbBoxPost.FindStringExact("Официант");
                        cmbBoxPost.SelectedIndex = index;
                    }
                }
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {

            if (dataGridWaiters.SelectedRows.Count == 0)
                return;

            int selectWaiterId = (int)dataGridWaiters.SelectedRows[0].Cells["WaiterId"].Value;

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                var selectedWaiter = context.Waiters
                    .FirstOrDefault(d => d.WaiterId == selectWaiterId);

                if (selectedWaiter != null)
                {
                    selectedWaiter.WaiterName = txtWaiterName.Text;
                    selectedWaiter.WaiterLastname = txtWaiterLastname.Text;
                    selectedWaiter.WaiterPatronymic = txtWaiterPatronymic.Text;
                    selectedWaiter.Login = txtLogin.Text;
                    selectedWaiter.Password = txtPassword.Text;

                    selectedWaiter.Post = (cmbBoxPost.SelectedItem.ToString() == "Администратор");

                    context.SaveChanges();

                    LoadWaitersMenu();

                    MessageBox.Show("Изменения успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddWaitersFrom().ShowDialog();
            LoadWaitersMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridWaiters.SelectedRows.Count == 0)
                return;

            int selectWaiterId = (int)dataGridWaiters.SelectedRows[0].Cells["WaiterId"].Value;

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                var selectedWaiter = context.Waiters.FirstOrDefault(d => d.WaiterId == selectWaiterId);

                if (selectedWaiter != null)
                {
                    var ordersToDelete = context.Orders.Where(o => o.WaiterId == selectWaiterId).ToList();

                    var dishIdsToDelete = context.OrderItems
                        .Where(oi => ordersToDelete.Select(o => o.OrderId).Contains(oi.OrderId))
                        .Select(oi => oi.DishId)
                        .ToList();

                    context.OrderItems.RemoveRange(context.OrderItems.Where(oi => dishIdsToDelete.Contains(oi.DishId)));

                    context.Orders.RemoveRange(ordersToDelete);

                    context.Waiters.Remove(selectedWaiter);

                    context.SaveChanges();
                    
                    LoadWaitersMenu();

                    MessageBox.Show("Сотрудник успешно удален вместе со связанными заказами.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
