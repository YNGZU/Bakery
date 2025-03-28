using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Bakery
{
    public partial class inputTechnologicalCard : Form
    {
        public inputTechnologicalCard()
        {
            InitializeComponent();
            ingredientDataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            ingredientDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            ingredientDataGridView.ColumnCount = 4;
            ingredientDataGridView.Columns[0].Name = "Номер";
            ingredientDataGridView.Columns[1].Name = "Ингредиент";
            ingredientDataGridView.Columns[2].Name = "Количество";
            ingredientDataGridView.Columns[3].Name = "Ед. изм.";
            ingredientDataGridView.Columns[0].Visible = false;
            changeCardButton.Enabled = false;
        }

        public void gridUpdate(string SQL)
        {
            cardDataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            cardDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Data.connection);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cardDataGridView.Refresh();
            cardDataGridView.DataSource = tb;
            cardDataGridView.Columns[0].HeaderText = "№ Карты";
            cardDataGridView.Columns[1].HeaderText = "Рецепт";
            cardDataGridView.Columns[2].HeaderText = "Вид обработки";
            cardDataGridView.Columns[3].HeaderText = "Технология приготовления";
            cardDataGridView.Columns[0].Visible = false;
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        public void ingredientGridUpdate(string SQL)
        {
            contentDataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            contentDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Data.connection);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            contentDataGridView.Refresh();
            contentDataGridView.DataSource = tb;
            contentDataGridView.Columns[0].HeaderText = "№ Содержания";
            contentDataGridView.Columns[1].HeaderText = "Ингредиент";
            contentDataGridView.Columns[2].HeaderText = "Количество";
            contentDataGridView.Columns[3].HeaderText = "Ед. измерения";
            contentDataGridView.Columns[0].Visible = false;
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        private void inputTechnologicalCard_Load(object sender, EventArgs e)
        {
            string selectSQL = "SELECT name, nIngredient FROM ingredient ORDER BY name";
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(selectSQL, Data.connection);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            ingredientComboBox.DataSource = tb;
            ingredientComboBox.DisplayMember = "name";
            ingredientComboBox.ValueMember = "nIngredient";
            ingredientComboBox.Text = "";
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        private void inputTechnologicalCard_Activated(object sender, EventArgs e)
        {
            string selectSQL = "select technologicalCard.nCard, recipe.name, technologicalCard.typeOfProcessing, technologicalCard.cookingTechnology from technologicalCard, recipe where technologicalCard.nRecipe = recipe.nRecipe";
            gridUpdate(selectSQL);

            selectSQL = "SELECT contentOfTechnologicalCard.id, ingredient.name, contentOfTechnologicalCard.quantity, contentOfTechnologicalCard.unit FROM contentOfTechnologicalCard LEFT JOIN ingredient ON ingredient.nIngredient = contentOfTechnologicalCard.nIngredient";
            ingredientGridUpdate(selectSQL);

            recipeNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            selectSQL = "SELECT recipe.name, recipe.nRecipe FROM recipe left join technologicalCard on recipe.nRecipe = technologicalCard.nRecipe where  technologicalCard.nRecipe is null ORDER BY name";
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(selectSQL, Data.connection);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            recipeNameComboBox.DataSource = tb;
            recipeNameComboBox.DisplayMember = "name";
            recipeNameComboBox.ValueMember = "nRecipe";
            recipeNameComboBox.Text = "";
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        string nCard = "";

        private void cardDataGridView_Click(object sender, EventArgs e)
        {
            try {
                recipeNameComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                nCard = cardDataGridView[0, cardDataGridView.CurrentRow.Index].Value.ToString();
                recipeNameComboBox.Text = cardDataGridView[1, cardDataGridView.CurrentRow.Index].Value.ToString();
                typeOfProcessingComboBox.Text = cardDataGridView[2, cardDataGridView.CurrentRow.Index].Value.ToString();
                cookingTechnologyTextBox.Text = cardDataGridView[3, cardDataGridView.CurrentRow.Index].Value.ToString();

                saveCardButton.Enabled = false;
                changeCardButton.Enabled = true;

                string selectSQL = "SELECT contentOfTechnologicalCard.id, ingredient.name, contentOfTechnologicalCard.quantity, contentOfTechnologicalCard.unit FROM contentOfTechnologicalCard LEFT JOIN ingredient ON ingredient.nIngredient = contentOfTechnologicalCard.nIngredient where contentOfTechnologicalCard.nCard =" + nCard;
                ingredientGridUpdate(selectSQL);
            }
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }

        }
        private void changeCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();

                if (String.IsNullOrWhiteSpace(cookingTechnologyTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Опишите технологию обработки!");
                }
                if (recipeNameComboBox.ValueMember == null) //пустой комбобокс
                    errors.AppendLine("Выберите рецепт!");
                if (typeOfProcessingComboBox.ValueMember == null) //пустой комбобокс
                    errors.AppendLine("Укажите тип обработки!");
                if (ingredientComboBox.ValueMember == null) //пустой комбобокс
                    errors.AppendLine("Укажите ингредиент для изменения!");
                if (String.IsNullOrWhiteSpace(quantityTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите количество!");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    string SQL = "update technologicalCard set cookingTechnology=N'" + cookingTechnologyTextBox.Text + "', typeOfProcessing=N'" + typeOfProcessingComboBox.SelectedItem + "' where nCard=" + nCard;
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    SqlCommand command = new SqlCommand(SQL, Data.connection);
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Close();
                    if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();

            if (nContent == null) nContent = 0.ToString();
                    SQL = "update contentOfTechnologicalCard set nIngredient=@nIngredient, nCard=@nCard, quantity=@quantity where id=" + nContent;
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            decimal quantity1 = Convert.ToDecimal(quantityTextBox.Text);
                    command = new SqlCommand(SQL, Data.connection);
            command.Parameters.AddWithValue("@nIngredient", ingredientComboBox.SelectedValue);
            command.Parameters.AddWithValue("@nCard", nCard);
            command.Parameters.AddWithValue("@quantity", quantity1);
                    dr = command.ExecuteReader();
                    dr.Close();
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            // Вставка ингредиентов в contentOfTechnologicalCard
            foreach (DataGridViewRow row in ingredientDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string ingredient = row.Cells["Номер"].Value.ToString();
                decimal quantity = Convert.ToDecimal(row.Cells["Количество"].Value);
                string unit = row.Cells["Ед. изм."].Value.ToString();

                string selectSQL = "SELECT id, nIngredient FROM contentOfTechnologicalCard WHERE nCard = @nCard AND nIngredient = @nIngredient";

                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectSQL, Data.connection))
                {
                    selectCommand.Parameters.AddWithValue("@nCard", nCard);
                    selectCommand.Parameters.AddWithValue("@nIngredient", ingredient);

                    object existingId = selectCommand.ExecuteScalar(); // Получаем id, если ингредиент уже есть
                    if (existingId != null)
                    {
                        // Если ингредиент уже есть, обновляем количество
                        string updateSQL = "UPDATE contentOfTechnologicalCard SET quantity = quantity + @quantity WHERE id = @id";

                        using (SqlCommand updateCommand = new SqlCommand(updateSQL, Data.connection))
                        {
                            updateCommand.Parameters.AddWithValue("@quantity", quantity);
                            updateCommand.Parameters.AddWithValue("@id", existingId);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Если ингредиента нет, добавляем новый
                        string insertSQL = "INSERT INTO contentOfTechnologicalCard (nCard, nIngredient, quantity, unit) " +
                                           "VALUES (@nCard, @nIngredient, @quantity, @unit)";

                        using (SqlCommand insertCommand = new SqlCommand(insertSQL, Data.connection))
                        {
                            insertCommand.Parameters.AddWithValue("@nCard", nCard);
                            insertCommand.Parameters.AddWithValue("@nIngredient", ingredient);
                            insertCommand.Parameters.AddWithValue("@quantity", quantity);
                            insertCommand.Parameters.AddWithValue("@unit", unit);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

            // Очищаем DataGridView после вставки
            ingredientDataGridView.Rows.Clear();

            // Закрываем соединение, если оно открыто
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();

            MessageBox.Show("Данные изменены");
                    this.Activate();
                }
            }
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            recipeNameComboBox.Text = "";
            cookingTechnologyTextBox.Text = "";
            typeOfProcessingComboBox.Text = "";
            recipeSearchTextBox.Text = "";
            ingredientComboBox.Text = "";
            quantityTextBox.Text = "";
            ingredientDataGridView.Rows.Clear();
            saveCardButton.Enabled = true;
            changeCardButton.Enabled = false;
            recipeNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string selectSQL = "SELECT contentOfTechnologicalCard.id, ingredient.name, contentOfTechnologicalCard.quantity, contentOfTechnologicalCard.unit FROM contentOfTechnologicalCard LEFT JOIN ingredient ON ingredient.nIngredient = contentOfTechnologicalCard.nIngredient";
            ingredientGridUpdate(selectSQL);
            string cancelSQL = "select technologicalCard.nCard, recipe.name, technologicalCard.typeOfProcessing, technologicalCard.cookingTechnology from technologicalCard, recipe where technologicalCard.nRecipe = recipe.nRecipe";
            gridUpdate(cancelSQL);

        }

        private void recipeSearchButton_Click(object sender, EventArgs e)
        {
            string searchSQL = "select technologicalCard.nCard, recipe.name, technologicalCard.typeOfProcessing, technologicalCard.cookingTechnology from technologicalCard, recipe where technologicalCard.nRecipe = recipe.nRecipe AND recipe.name LIKE N'" + recipeSearchTextBox.Text + "%'";
            gridUpdate(searchSQL);
        }

        private void ingredientComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectSQL = "select unit from ingredient where nIngredient = " + ingredientComboBox.SelectedValue;
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlCommand command = new SqlCommand(selectSQL, Data.connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read()) {
                unitLabel.Text = dr["unit"].ToString();
            }
            dr.Close();
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            string ingredient = ingredientComboBox.Text;
            string quantityText = quantityTextBox.Text;
            string unit = unitLabel.Text;
            string nIngredient = Convert.ToString(ingredientComboBox.SelectedValue);

            if (string.IsNullOrWhiteSpace(ingredient) || string.IsNullOrWhiteSpace(quantityText) || string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            if (!decimal.TryParse(quantityText, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество!");
                return;
            }
            foreach (DataGridViewRow row in ingredientDataGridView.Rows)
            {
                //MessageBox.Show($"Row index: {row.Index}, Cell[0] Value: {row.Cells[1].Value}"); // Вывод значений в консоль

                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == ingredient)
                {
                    row.Cells[2].Value = Convert.ToDecimal(row.Cells[2].Value) + quantity;
                    return;
                }
            }

            // Если не найдено, добавляем новую строку
            ingredientDataGridView.Rows.Add(nIngredient, ingredient, quantity, unit);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (ingredientDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Ингредиенты еще не введены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ingredientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для уменьшения количества", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(quantityTextBox.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = ingredientDataGridView.SelectedRows[0];
            decimal currentQuantity = Convert.ToDecimal(selectedRow.Cells["Количество"].Value);

            if (quantity >= currentQuantity)
            {
                ingredientDataGridView.Rows.Remove(selectedRow); // Удаляем строку, если количество стало 0 или меньше
            }
            else
            {
                selectedRow.Cells["Количество"].Value = currentQuantity - quantity;
            }
        }

        private void saveCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();

                if (String.IsNullOrWhiteSpace(cookingTechnologyTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Введите технологию приготовления");
                }
                if (typeOfProcessingComboBox.ValueMember == null) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите вид обработки!");
                }
                if (recipeNameComboBox.ValueMember == null) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите рецепт!");
                }
                if (ingredientDataGridView.Rows.Count == 1)
                {
                    MessageBox.Show("Нет данных для сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    if (Data.connection.State != ConnectionState.Open)
                        Data.connection.Open();

                    // Вставка в technologicalCard и получение ID новой записи
                    string insertSQL = "INSERT INTO technologicalCard(nRecipe, cookingTechnology, typeOfProcessing) " +
                                       "VALUES (@nRecipe, @cookingTechnology, @typeOfProcessing); " +
                                       "SELECT SCOPE_IDENTITY();";  // Получаем ID вставленной записи

                    using (SqlCommand command = new SqlCommand(insertSQL, Data.connection))
                    {
                        command.Parameters.AddWithValue("@nRecipe", recipeNameComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@cookingTechnology", cookingTechnologyTextBox.Text);
                        command.Parameters.AddWithValue("@typeOfProcessing", typeOfProcessingComboBox.SelectedItem);

                        object result = command.ExecuteScalar(); // Получаем ID
                        if (result == null || !int.TryParse(result.ToString(), out int newId))
                        {
                            MessageBox.Show("Ошибка получения ID технологической карты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Проверяем, есть ли ингредиенты для сохранения
                        if (ingredientDataGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Нет данных для сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Вставка ингредиентов в contentOfTechnologicalCard
                        foreach (DataGridViewRow row in ingredientDataGridView.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string ingredient = row.Cells["Номер"].Value.ToString();
                            decimal quantity = Convert.ToDecimal(row.Cells["Количество"].Value);
                            string unit = row.Cells["Ед. изм."].Value.ToString();

                            string query = "INSERT INTO contentOfTechnologicalCard (nCard, nIngredient, quantity, unit) " +
                                           "VALUES (@nCard, @nIngredient, @quantity, @unit)";

                            using (SqlCommand cmd = new SqlCommand(query, Data.connection))
                            {
                                cmd.Parameters.AddWithValue("@nCard", newId);
                                cmd.Parameters.AddWithValue("@nIngredient", ingredient);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@unit", unit);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        ingredientDataGridView.Rows.Clear();
                        MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Data.connection.State != ConnectionState.Closed)
                    Data.connection.Close();
            }
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; //перехват символа нажатой клавиши 
            //8 – код клавиши backspace
            //44 – код запятой
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Отклоняем ввод
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true; // Отклоняем ввод
            }
        }

        string nContent;
        private void contentDataGridView_Click(object sender, EventArgs e)
        {
            try {
                nContent = contentDataGridView[0, contentDataGridView.CurrentRow.Index].Value.ToString();
                ingredientComboBox.Text = contentDataGridView[1, contentDataGridView.CurrentRow.Index].Value.ToString();
                quantityTextBox.Text = contentDataGridView[2, contentDataGridView.CurrentRow.Index].Value.ToString();
                unitLabel.Text = contentDataGridView[3, contentDataGridView.CurrentRow.Index].Value.ToString();

                saveCardButton.Enabled = false;
                changeCardButton.Enabled = true;
            }
            
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }
        }
    }
    }
