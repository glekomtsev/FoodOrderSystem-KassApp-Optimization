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

    }
}
