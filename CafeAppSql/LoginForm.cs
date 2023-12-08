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
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                var waiters = context.Waiters;

                foreach (var item in waiters)
                {
                    if (item.Login != null && item.Login == txtLogin.Text &&
                        item.Password != null && item.Password == txtPassword.Text)
                    {
                        this.Hide();
                        new MainMenu(item.WaiterId).ShowDialog();
                        this.Close();
                        return;
                    }                
                }

                DialogResult result = MessageBox.Show("Неверный логин или пароль!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    txtPassword.Clear();
                    txtLogin.Clear();
                }

            }
        }
    }
}
