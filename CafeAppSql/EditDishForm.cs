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
    public partial class EditDishForm : Form
    {
        public EditDishForm()
        {
            InitializeComponent();
            LoadMineMenu();
        }
        void LoadMineMenu()
        {
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                ClearFieldsAndLists();

                listBoxCategories.Items.AddRange(context.Categories.Select(c => c.CategoriesName).ToArray());

                dataGridMenu.Columns.AddRange(
                    new DataGridViewTextBoxColumn { Name = "DishId", HeaderText = "ID", Visible = false },
                    new DataGridViewTextBoxColumn { Name = "DishName", HeaderText = "Название блюда", Width = 285 },
                    new DataGridViewTextBoxColumn { Name = "DishPrice", HeaderText = "Цена блюда" }
                );

                cmbCategories.Items.AddRange(context.Categories.Select(c => c.CategoriesName).ToArray());
            }
        }

        void ClearFieldsAndLists()
        {
            txtDishName.Clear();
            txtDishPrice.Clear();
            cmbCategories.Items.Clear();
            listBoxCategories.Items.Clear();
        }


        private void listBoxCategories_Click(object sender, EventArgs e)
        {
            LoadDataGridDihs();
        }

        private void LoadDataGridDihs()
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
            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                dataGridMenu.Rows.Clear();

                var dishes = context.Dishes
                    .Where(d => d.CategoriesId == categoryId)
                    .ToList();

                foreach (var dish in dishes)
                {
                    dataGridMenu.Rows.Add(dish.DishId, dish.DishName, dish.DishPrice);
                }
            }
        }

        private void dataGridMenu_Click(object sender, EventArgs e)
        {
            if (dataGridMenu.SelectedRows.Count == 0)
                return;

            int selectDishId = (int)dataGridMenu.SelectedRows[0].Cells["DishId"].Value;

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                var selectedDish = context.Dishes
                    .FirstOrDefault(d => d.DishId == selectDishId);

                if (selectedDish != null)
                {
                    txtDishName.Text = selectedDish.DishName;
                    txtDishPrice.Text = selectedDish.DishPrice.ToString();
                    cmbCategories.SelectedItem = listBoxCategories.SelectedItem.ToString();
                }
            }
        }

        private void btnChangeDish_Click(object sender, EventArgs e)
        {
            if (dataGridMenu.SelectedRows.Count == 0)
                return;

            int selectDishId = (int)dataGridMenu.SelectedRows[0].Cells["DishId"].Value;

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                var selectedDish = context.Dishes.FirstOrDefault(d => d.DishId == selectDishId);

                if (selectedDish == null)
                    return;

                selectedDish.DishName = txtDishName.Text;

                if (decimal.TryParse(txtDishPrice.Text, out decimal dishPrice))
                {
                    selectedDish.DishPrice = dishPrice;
                }
                else
                {
                    MessageBox.Show("Введите корректное значение для цены.");
                    return;
                }

                if (cmbCategories.SelectedItem != null)
                {
                    var categoriesName = cmbCategories.SelectedItem.ToString();
                    var categoriesId = context.Categories
                        .Where(c => c.CategoriesName == categoriesName)
                        .Select(c => c.CategoriesId)
                        .FirstOrDefault();

                    if (categoriesId != 0)
                    {
                        selectedDish.CategoriesId = categoriesId;
                    }
                    else
                    {
                        MessageBox.Show("Выбранная категория не найдена.");
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.SaveChanges();
                    dataGridMenu.Rows.Clear();
                    LoadDataGridDihs();
                }
            }
        }

    }
}
