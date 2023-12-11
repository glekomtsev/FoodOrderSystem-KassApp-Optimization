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
                listBoxCategories.Items.Clear();
                listBoxCategories.Items.AddRange(context.Categories.Select(c => c.CategoriesName).ToArray());

                dataGridMenu.Columns.AddRange(
                    new DataGridViewTextBoxColumn { Name = "DishId", HeaderText = "ID", Visible = false },
                    new DataGridViewTextBoxColumn { Name = "DishName", HeaderText = "Название блюда", Width = 285 },
                    new DataGridViewTextBoxColumn { Name = "DishPrice", HeaderText = "Цена блюда" }
                );
                dataGridMenu.Rows.Clear();
            }
        }

        void ClearFieldsAndLists()
        {
            txtDishName.Clear();
            txtDishPrice.Clear();
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

                DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.SaveChanges();
                    dataGridMenu.Rows.Clear();
                    LoadDataGridDihs();
                    MessageBox.Show($"Сохранения успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddCatagories_Click(object sender, EventArgs e)
        {
            new AddCategories().ShowDialog();
            LoadMineMenu();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            new AddDishForm().ShowDialog();
            LoadDataGridDihs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCategoryName = listBoxCategories.SelectedItem?.ToString();

            using (CafeDataBaseContext context = new CafeDataBaseContext())
            {
                if (string.IsNullOrEmpty(selectedCategoryName))
                {
                    MessageBox.Show("Выберите категорию для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int categoryId = context.Categories
                    .Where(c => c.CategoriesName == selectedCategoryName)
                    .Select(c => c.CategoriesId)
                    .FirstOrDefault();

                if (categoryId != 0)
                {
                    var result = MessageBox.Show("При удалении категории будут удалены все блюда в этой категории и связанные заказы. Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var deletedDishIds = context.Dishes
                            .Where(d => d.CategoriesId == categoryId)
                            .Select(d => d.DishId)
                            .ToList();

                        var orderItemsToDelete = context.OrderItems
                            .Where(oi => deletedDishIds.Contains(oi.DishId))
                            .ToList();

                        context.OrderItems.RemoveRange(orderItemsToDelete);

                        context.Dishes.RemoveRange(context.Dishes.Where(d => d.CategoriesId == categoryId));

                        context.Categories.Remove(context.Categories.Find(categoryId));

                        context.SaveChanges();

                        MessageBox.Show("Удаление успешно произведено.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMineMenu();


                    }
                }
            }
        }


    }
}
