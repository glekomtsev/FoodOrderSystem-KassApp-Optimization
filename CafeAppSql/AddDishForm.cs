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
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                cmbCategories.Items.Clear();

                var categories = context.Categories.Select(c => c.CategoriesName).ToList();

                cmbCategories.Items.AddRange(categories.ToArray());
            }
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                string dishName = txtDishName.Text.Trim();
                decimal dishPrice;
                
                if (!decimal.TryParse(txtDishPrice.Text, out dishPrice))
                {
                    MessageBox.Show("Введите корректную цену блюда.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string categoryName = cmbCategories.SelectedItem as string;

                if (!string.IsNullOrEmpty(dishName) && dishPrice > 0 && !string.IsNullOrEmpty(categoryName))
                {                    
                    int categoryId = context.Categories
                        .Where(c => c.CategoriesName == categoryName)
                        .Select(c => c.CategoriesId)
                        .FirstOrDefault();
                                        
                    Dish newDish = new Dish
                    {
                        DishName = dishName,
                        DishPrice = dishPrice,
                        CategoriesId = categoryId
                    };

                    context.Dishes.Add(newDish);
                    context.SaveChanges();

                    MessageBox.Show($"Блюдо {dishName} успешно добавлено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните все поля для добавления блюда.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
