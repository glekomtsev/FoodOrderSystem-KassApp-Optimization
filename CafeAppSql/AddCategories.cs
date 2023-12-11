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
    public partial class AddCategories : Form
    {
        public AddCategories()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                string categoryName = txtCategoriesName.Text.Trim();

                if (!string.IsNullOrEmpty(categoryName))
                {
                    bool categoryExists = context.Categories.Any(c => c.CategoriesName == categoryName);

                    if (!categoryExists)
                    {
                        Category newCategory = new Category
                        {
                            CategoriesName = categoryName
                        };

                        context.Categories.Add(newCategory);
                        context.SaveChanges();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Категория с таким именем уже существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Введите название категории.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
