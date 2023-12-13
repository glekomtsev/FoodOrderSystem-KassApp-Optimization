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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new CafeDataBaseContext())
            {
                var waiter = context.Waiters
                    .FirstOrDefault(item => item.Login == txtLogin.Text && item.Password == txtPassword.Text);

                if (waiter != null)
                {
                    this.Hide();
                    new MainMenu(waiter.WaiterId).ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
