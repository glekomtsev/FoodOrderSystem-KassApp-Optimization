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
    public partial class AddWaitersFrom : Form
    {
        public AddWaitersFrom()
        {
            InitializeComponent();
            cmbBoxPost.Items.Clear();
            cmbBoxPost.Items.Add("Администратор");
            cmbBoxPost.Items.Add("Официант");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddWaiter_Click(object sender, EventArgs e)
        {

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {

                Waiter newWaiter = new Waiter
                {
                    WaiterName = txtWaiterName.Text,
                    WaiterLastname = txtWaiterLastname.Text,
                    WaiterPatronymic = txtWaiterPatronymic.Text,
                    Login = txtLogin.Text,
                    Password = txtPassword.Text,
                    Post = (cmbBoxPost.SelectedItem.ToString() == "Администратор")
                };

                context.Waiters.Add(newWaiter);
                context.SaveChanges();

                MessageBox.Show("Сотрудник успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
