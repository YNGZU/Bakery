using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Bakery
{
    public partial class inputBakeryProducts : Form
    {

        public void gridUpdate(string SQL)
        {
            bakeryDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 13, FontStyle.Regular);
            bakeryDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 13, FontStyle.Regular);
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Data.connection);
            System.Data.DataTable tb = new System.Data.DataTable();
            adapter.Fill(tb);
            bakeryDataGridView.Refresh();
            bakeryDataGridView.DataSource = tb;
            bakeryDataGridView.Columns[0].HeaderText = "Номер";
            bakeryDataGridView.Columns[1].HeaderText = "Рецепт";
            bakeryDataGridView.Columns[2].HeaderText = "Тип";
            bakeryDataGridView.Columns[3].HeaderText = "Код";
            bakeryDataGridView.Columns[4].HeaderText = "Стоимость (руб.)";
            bakeryDataGridView.Columns[5].HeaderText = "Срок годности (суток)";
            bakeryDataGridView.Columns[6].HeaderText = "Дата приготовления";
            bakeryDataGridView.Columns[7].HeaderText = "Статус";
            bakeryDataGridView.Columns[8].HeaderText = "Дата реализации";
            bakeryDataGridView.Columns[9].HeaderText = "Причина списания";

            bakeryDataGridView.Columns[0].Visible = false;

            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
            bakeryDataGridView.RowPrePaint += bakeryDataGridView_RowPrePaint;
        }

        private void bakeryDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = bakeryDataGridView.Rows[e.RowIndex];

                    // Проверяем, существуют ли нужные столбцы
                    if (row.Cells["dateOfPreparation"].Value != null &&
                        row.Cells["expirationDate"].Value != null)
                    {
                        // Преобразуем дату приготовления
                        if (DateTime.TryParse(row.Cells["dateOfPreparation"].Value.ToString(), out DateTime dateOfPreparation) &&
                            int.TryParse(row.Cells["expirationDate"].Value.ToString(), out int expirationDays))
                        {
                            // Дата истечения срока годности
                            DateTime expirationDate = dateOfPreparation.AddDays(expirationDays);

                            // Проверяем дату реализации
                            string implementationDate = row.Cells["dateOfImplementation"].Value?.ToString();

                            // Если срок годности не истек и дата реализации пустая — выделяем строку красным
                            if (expirationDate <= DateTime.Now.Date && string.IsNullOrWhiteSpace(implementationDate))
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if ((expirationDate == DateTime.Today.AddDays(1) || expirationDate == DateTime.Today.AddDays(2)) && string.IsNullOrWhiteSpace(implementationDate))
                            {
                                row.DefaultCellStyle.BackColor = Color.Orange;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.White; // Сбрасываем цвет
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке строк: " + ex.Message);
            }
        }

        public inputBakeryProducts()
        {
            InitializeComponent();
            changeBakeryButton.Enabled = false;
            printButton.Enabled = false;
        }

        private void inputBakeryProducts_Load(object sender, EventArgs e)
        {
            string selectSQL = "SELECT recipe.name, recipe.nRecipe FROM recipe left join technologicalCard on recipe.nRecipe = technologicalCard.nRecipe where  technologicalCard.nRecipe is not null ORDER BY name";
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(selectSQL, Data.connection);
            System.Data.DataTable tb = new System.Data.DataTable();
            adapter.Fill(tb);
            recipeNameComboBox.DataSource = tb;
            recipeNameComboBox.DisplayMember = "name";
            recipeNameComboBox.ValueMember = "nRecipe";
            recipeNameComboBox.Text = "";
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();

            selectSQL = "SELECT distinct recipe.name, recipe.nRecipe FROM recipe right join bakeryProducts on recipe.nRecipe = bakeryProducts.nRecipe ORDER BY name";
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            adapter = new SqlDataAdapter(selectSQL, Data.connection);
            tb = new System.Data.DataTable();
            adapter.Fill(tb);
            recipeNameImplementationComboBox.DataSource = tb;
            recipeNameImplementationComboBox.DisplayMember = "name";
            recipeNameImplementationComboBox.ValueMember = "nRecipe";
            recipeNameImplementationComboBox.Text = "";
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        private void inputBakeryProducts_Activated(object sender, EventArgs e)
        {
            string selectSQL = "select bakeryProducts.nBakeryProducts, recipe.name, bakeryProducts.type, bakeryProducts.code, bakeryProducts.cost, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation, bakeryProducts.status, bakeryProducts.dateOfImplementation, bakeryProducts.reason from bakeryProducts, recipe where bakeryProducts.nRecipe = recipe.nRecipe";
            gridUpdate(selectSQL);
        }

        string nBakeryProducts = "";
        string status = "";
        private void bakeryDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                nBakeryProducts = bakeryDataGridView[0, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                recipeNameComboBox.Text = bakeryDataGridView[1, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                typeComboBox.Text = bakeryDataGridView[2, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                codeTextBox.Text = bakeryDataGridView[3, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                costTextBox.Text = bakeryDataGridView[4, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                expirationDateTextBox.Text = bakeryDataGridView[5, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                dateOfPreparationDateTimePicker.Text = bakeryDataGridView[6, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                dateOfImplementationDateTimePicker.Text = bakeryDataGridView[8, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                reasonTextBox.Text = bakeryDataGridView[9, bakeryDataGridView.CurrentRow.Index].Value.ToString();
                status = bakeryDataGridView[7, bakeryDataGridView.CurrentRow.Index].Value.ToString();

                addBakeryButton.Enabled = false;
                changeBakeryButton.Enabled = true;
                printButton.Enabled = true;
                recipeNameComboBox.Enabled = false;

                quantityTextBox.Enabled = false;
                recipeNameImplementationComboBox.Enabled = false;
                reasonTextBox.Enabled = true;
            }
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }
        }

        private void changeBakeryButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                if (String.IsNullOrWhiteSpace(expirationDateTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Введите срок годности!");
                }
                if (String.IsNullOrWhiteSpace(codeTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите код!");
                }
                if (recipeNameComboBox.ValueMember == null) //пустой комбобокс
                    errors.AppendLine("Выберите рецепт!");
                if (typeComboBox.ValueMember == null) //пустой комбобокс
                    errors.AppendLine("Укажите тип!");
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    string changeSQL = "update bakeryProducts set type=N'" + typeComboBox.SelectedItem + "', dateOfPreparation=N'" + dateOfPreparationDateTimePicker.Value.ToString("MM/dd/yyyy") + "', expirationDate=" + expirationDateTextBox.Text + " where nBakeryProducts=" + nBakeryProducts;
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    SqlCommand command = new SqlCommand(changeSQL, Data.connection);
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Close();
                    if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                    MessageBox.Show("Данные изменены");
                    this.Activate();
                }
            }
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 50));
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            recipeNameComboBox.Text = "";
            costTextBox.Text = "";
            codeTextBox.Text = "";
            recipeSearchTextBox.Text = "";
            reasonTextBox.Text = "";
            quantityTextBox.Text = "";
            typeComboBox.Text = "";
            expirationDateTextBox.Text = "";
            dateOfPreparationDateTimePicker.Text = "";
            dateOfImplementationDateTimePicker.Text = "";
            addBakeryButton.Enabled = true;
            changeBakeryButton.Enabled = false;
            recipeNameImplementationComboBox.Visible = false;
            applyImplementationButton.Visible = false;
            changeBakeryButton.Visible = true;
            applyTrashButton.Visible = false;
            finalCostTextBox.Text = "";

            dateOfImplementationDateTimePicker.Visible = false;
            dateOfImplementationLabel.Visible = false;
            reasonTextBox.Visible = false;
            reasonLabel.Visible = false;
            reasonTextBox.Enabled = false;
            quantityTextBox.Visible = false;
            quantityLabel.Visible = false;

            recipeNameComboBox.Visible = true;
            recipeNameComboBox.Enabled = true;
            recipeNameLabel.Visible = true;
            expirationDateLabel.Visible = true;
            expirationDateTextBox.Visible = true;
            dateOfPreparationDateTimePicker.Visible = true;
            dateOfPreparationLabel.Visible = true;
            codeLabel.Visible = true;
            codeTextBox.Visible = true;
            costLabel.Visible = true;
            costTextBox.Visible = true;
            typeComboBox.Visible = true;
            typeLabel.Visible = true;
            hourLabel.Visible = true;
            rubLabel.Visible = true;
            finalCostLabel.Visible = false;
            finalCostTextBox.Visible = false;
            allRubLabel.Visible = false;

            printButton.Enabled = false;

            recipeNameLabel.Visible = true;

            quantityTextBox.Enabled = true;
            quantityLabel.Enabled = true;
            reasonTextBox.Enabled = false;
            recipeNameImplementationComboBox.Enabled = true;

            string cancelSQL = "select bakeryProducts.nBakeryProducts, recipe.name, bakeryProducts.type, bakeryProducts.code, bakeryProducts.cost, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation, bakeryProducts.status, bakeryProducts.dateOfImplementation, bakeryProducts.reason from bakeryProducts, recipe where bakeryProducts.nRecipe = recipe.nRecipe";
            gridUpdate(cancelSQL);
        }

        private void addBakeryButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                if (String.IsNullOrWhiteSpace(expirationDateTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Введите срок годности!");
                }
                if (recipeNameComboBox.ValueMember == null) //пустой комбобокс
                    errors.AppendLine("Выберите рецепт!");
                if (typeComboBox.ValueMember == null) //пустой комбобокс
                    errors.AppendLine("Укажите тип!");
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    // 1. Проверяем, хватает ли ингредиентов
                    string checkIngredientsSQL = @"
                        SELECT i.nIngredient, i.quantity, t.quantity
                        FROM technologicalCard c
                        JOIN contentOfTechnologicalCard t ON c.nCard = t.nCard
                        JOIN ingredient i ON t.nIngredient = i.nIngredient
                        WHERE c.nRecipe = @nRecipe";

                    SqlCommand checkCommand = new SqlCommand(checkIngredientsSQL, Data.connection);
                    checkCommand.Parameters.AddWithValue("@nRecipe", recipeNameComboBox.SelectedValue);

                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();

                    // Читаем данные о необходимых ингредиентах
                    SqlDataReader reader = checkCommand.ExecuteReader();
                    Dictionary<int, decimal> ingredientUsage = new Dictionary<int, decimal>();
                    bool isEnough = true;

                    while (reader.Read())
                    {
                        int ingredientId = reader.GetInt32(0);
                        decimal availableQuantity = reader.GetDecimal(1);
                        decimal requiredQuantity = reader.GetDecimal(2);

                        if (availableQuantity < requiredQuantity)
                        {
                            isEnough = false;
                            break;
                        }
                        ingredientUsage[ingredientId] = requiredQuantity;
                    }

                    reader.Close();

                    // Если ингредиентов не хватает, прерываем выполнение
                    if (!isEnough)
                    {
                        MessageBox.Show("Недостаточно ингредиентов");
                        Data.connection.Close();
                        return;
                    }

                    // 2. Отнимаем использованные ингредиенты из таблицы ingredient
                    foreach (var entry in ingredientUsage)
                    {
                        string updateIngredientSQL = "UPDATE ingredient SET quantity = quantity - @usedQuantity WHERE nIngredient = @ingredientId";
                        SqlCommand updateCommand = new SqlCommand(updateIngredientSQL, Data.connection);
                        updateCommand.Parameters.AddWithValue("@usedQuantity", entry.Value);
                        updateCommand.Parameters.AddWithValue("@ingredientId", entry.Key);
                        updateCommand.ExecuteNonQuery();
                    }

                    // 3. Добавление записи в таблицу bakeryProducts
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    string recipeSQL = "select nRecipe, servingsQuantity from recipe where nRecipe=" + recipeNameComboBox.SelectedValue;
                    SqlCommand recipeCommand = new SqlCommand(recipeSQL, Data.connection);
                    SqlDataReader recipeReader = recipeCommand.ExecuteReader();
                    int i = 0;
            int quantityRecipe = 1;
            while (recipeReader.Read())
            {
                quantityRecipe = Convert.ToInt32(recipeReader["servingsQuantity"]);
            }       recipeReader.Close();
                    if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
            while (i < quantityRecipe)
            {
                string codeSQL = "select top 1 code from bakeryProducts order by code desc";
                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                SqlCommand command = new SqlCommand(codeSQL, Data.connection);
                SqlDataReader dr = command.ExecuteReader();
                int code = 1;
                while (dr.Read())
                {
                    code = Convert.ToInt32(dr["code"]) + 1;
                }
                dr.Close();
                string addSQL = "INSERT INTO bakeryProducts(nRecipe, type, dateOfPreparation, code, status, expirationDate) " +
                            "VALUES (@nRecipe, @type, @dateOfPreparation, @code, N'Реализуется', @expirationDate)";
                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                SqlCommand addCommand = new SqlCommand(addSQL, Data.connection);
                addCommand.Parameters.AddWithValue("@nRecipe", recipeNameComboBox.SelectedValue);
                addCommand.Parameters.AddWithValue("@type", typeComboBox.SelectedItem.ToString());
                addCommand.Parameters.AddWithValue("@code", code);
                addCommand.Parameters.AddWithValue("@dateOfPreparation", dateOfPreparationDateTimePicker.Value);
                addCommand.Parameters.AddWithValue("@expirationDate", int.Parse(expirationDateTextBox.Text));
                addCommand.ExecuteNonQuery();
                i++;
            }

            // 4. Вычисление стоимости с учетом количества порций
            string selectSQL = @"
                        SELECT SUM((i.cost * t.quantity) / r.servingsQuantity) * 1.2 AS total_cost 
                        FROM bakeryProducts b
                        JOIN recipe r ON b.nRecipe = r.nRecipe
                        JOIN technologicalCard c ON r.nRecipe = c.nRecipe
                        JOIN contentOfTechnologicalCard t ON c.nCard = t.nCard
                        JOIN ingredient i ON t.nIngredient = i.nIngredient
                        WHERE b.nBakeryProducts = (SELECT TOP 1 nBakeryProducts FROM bakeryProducts ORDER BY nBakeryProducts DESC)";

                    SqlCommand selectCommand = new SqlCommand(selectSQL, Data.connection);
                    object result = selectCommand.ExecuteScalar();
                    decimal cost = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

            // 5. Обновление стоимости в bakeryProducts
                string changeSQL = "UPDATE bakeryProducts SET cost = @cost WHERE nBakeryProducts in (SELECT TOP " + quantityRecipe + " nBakeryProducts FROM bakeryProducts ORDER BY nBakeryProducts DESC)";
                SqlCommand changeCommand = new SqlCommand(changeSQL, Data.connection);
                changeCommand.Parameters.AddWithValue("@cost", cost);
                changeCommand.ExecuteNonQuery();

                // Закрытие соединения
                if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                // Вывод сообщения
                MessageBox.Show("Данные добавлены");
                this.Activate();
        }
    }
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 80));
            }
        }

        private void enterNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; //перехват символа нажатой клавиши 
            //8 – код клавиши backspace
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void recipeSearchButton_Click(object sender, EventArgs e)
        {
            string searchSQL = "select bakeryProducts.nBakeryProducts, recipe.name, bakeryProducts.type, bakeryProducts.code, bakeryProducts.cost, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation, bakeryProducts.status, bakeryProducts.dateOfImplementation, bakeryProducts.reason from bakeryProducts, recipe where bakeryProducts.nRecipe = recipe.nRecipe and recipe.name like N'" + recipeSearchTextBox.Text + "%'";
            gridUpdate(searchSQL);
        }

        private void implementationButton_Click(object sender, EventArgs e)
        {
            dateOfImplementationDateTimePicker.Visible = true;
            dateOfImplementationLabel.Visible = true;
            quantityTextBox.Visible = true;
            quantityLabel.Visible = true;
            reasonTextBox.Visible = false;
            reasonLabel.Visible = false;
            recipeNameImplementationComboBox.Visible = true;
            applyImplementationButton.Visible = true;
            changeBakeryButton.Visible = false;
            applyTrashButton.Visible = false;
            finalCostLabel.Visible = true;
            finalCostTextBox.Visible = true;
            allRubLabel.Visible = true;
            recipeNameLabel.Visible = true;

            recipeNameComboBox.Visible = false;
            expirationDateLabel.Visible = false;
            expirationDateTextBox.Visible = false;
            dateOfPreparationDateTimePicker.Visible = false;
            dateOfPreparationLabel.Visible = false;
            codeLabel.Visible = false;
            codeTextBox.Visible = false;
            costLabel.Visible = false;
            costTextBox.Visible = false;
            typeComboBox.Visible = false;
            typeLabel.Visible = false;
            hourLabel.Visible = false;
            rubLabel.Visible = false;
        }

        private void addAndChangeButton_Click(object sender, EventArgs e)
        {
            dateOfImplementationDateTimePicker.Visible = false;
            dateOfImplementationLabel.Visible = false;
            quantityTextBox.Visible = false;
            quantityLabel.Visible = false;
            reasonTextBox.Visible = false;
            reasonLabel.Visible = false;
            recipeNameImplementationComboBox.Visible = false;
            changeBakeryButton.Text = "Изменить";
            applyImplementationButton.Visible = false;
            changeBakeryButton.Visible = true;
            applyTrashButton.Visible = false;
            finalCostLabel.Visible = false;
            finalCostTextBox.Visible = false;
            allRubLabel.Visible = false;
            recipeNameLabel.Visible = true;

            recipeNameComboBox.Visible = true;
            expirationDateLabel.Visible = true;
            expirationDateTextBox.Visible = true;
            dateOfPreparationDateTimePicker.Visible = true;
            dateOfPreparationLabel.Visible = true;
            codeLabel.Visible = true;
            codeTextBox.Visible = true;
            costLabel.Visible = true;
            costTextBox.Visible = true;
            typeComboBox.Visible = true;
            typeLabel.Visible = true;
            hourLabel.Visible = true;
            rubLabel.Visible = true;
        }

        private void trashButton_Click(object sender, EventArgs e)
        {
            dateOfImplementationDateTimePicker.Visible = true;
            dateOfImplementationLabel.Visible = true;
            quantityTextBox.Visible = false;
            quantityLabel.Visible = false;
            reasonTextBox.Visible = true;
            reasonLabel.Visible = true;
            recipeNameImplementationComboBox.Visible = false;
            applyImplementationButton.Visible = false;
            changeBakeryButton.Visible = false;
            applyTrashButton.Visible = true;
            finalCostLabel.Visible = false;
            finalCostTextBox.Visible = false;
            allRubLabel.Visible = false;

            recipeNameLabel.Visible = false;
            recipeNameComboBox.Visible = false;
            expirationDateLabel.Visible = false;
            expirationDateTextBox.Visible = false;
            dateOfPreparationDateTimePicker.Visible = false;
            dateOfPreparationLabel.Visible = false;
            codeLabel.Visible = false;
            codeTextBox.Visible = false;
            costLabel.Visible = false;
            costTextBox.Visible = false;
            typeComboBox.Visible = false;
            typeLabel.Visible = false;
            hourLabel.Visible = false;
            rubLabel.Visible = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT r.name AS RecipeName, bp.expirationDate, bp.type, r.cookingTime, 
                   i.name AS IngredientName, ct.quantity, i.unit, tc.typeOfProcessing, 
                   tc.cookingTechnology
            FROM bakeryProducts bp
            JOIN recipe r ON bp.nRecipe = r.nRecipe
            JOIN technologicalCard tc ON r.nRecipe = tc.nRecipe
            JOIN contentOfTechnologicalCard ct ON tc.nCard = ct.nCard
            JOIN ingredient i ON ct.nIngredient = i.nIngredient where nBakeryProducts =" + nBakeryProducts +
            "ORDER BY r.name";
                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                SqlCommand cmd = new SqlCommand(query, Data.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("Нет данных.");
                    return;
                }

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();
                wordApp.Visible = true;

                string currentRecipe = "";
                Microsoft.Office.Interop.Word.Paragraph paragraph;
                Microsoft.Office.Interop.Word.Table table = null;
                int t = 0;
                while (reader.Read())
                {
                    string recipeName = reader["RecipeName"].ToString();

                    // Новый рецепт — создаем заголовок и таблицы
                    if (recipeName != currentRecipe)
                    {
                        currentRecipe = recipeName;

                        // Заголовок
                        paragraph = doc.Content.Paragraphs.Add();
                        paragraph.Range.Text = "Технологическая карта для \"" + recipeName +"\"";
                        paragraph.Range.Font.Size = 15;
                        paragraph.Range.Bold = 1;
                        paragraph.Range.Font.Name = "Times New Roman";
                        paragraph.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        paragraph.Range.InsertParagraphAfter();

                        // Таблица с описанием выпечки
                        table = doc.Tables.Add(paragraph.Range, 2, 4);
                        table.Borders.Enable = 1;
                        table.Cell(1, 1).Range.Text = "Срок годности (сут.)";
                        table.Cell(1, 2).Range.Text = "Тип";
                        table.Cell(1, 3).Range.Text = "Время приготовления (мин.)";
                        table.Cell(1, 4).Range.Text = "Вид обработки";
                        table.Cell(2, 1).Range.Text = reader["expirationDate"].ToString();
                        table.Cell(2, 2).Range.Text = reader["type"].ToString();
                        table.Cell(2, 3).Range.Text = reader["cookingTime"].ToString();
                        table.Cell(2, 4).Range.Text = reader["typeOfProcessing"].ToString();
                        paragraph.Range.InsertParagraphAfter();

                        // Заголовок таблицы ингредиентов
                        paragraph = doc.Content.Paragraphs.Add();
                        paragraph.Range.Text = "Ингредиенты:";
                        paragraph.Range.Font.Size = 14;
                        paragraph.Range.Bold = 1;
                        paragraph.Range.InsertParagraphAfter();

                        // Создаем таблицу ингредиентов
                        table = doc.Tables.Add(paragraph.Range, 1, 3);
                        table.Borders.Enable = 1;
                        table.Cell(1, 1).Range.Text = "Наименование";
                        table.Cell(1, 2).Range.Text = "Количество";
                        table.Cell(1, 3).Range.Text = "Ед. измерения";
                    }

                    // Добавляем новую строку в таблицу ингредиентов
                    int row = table.Rows.Count;
                    table.Rows.Add();
                    table.Cell(row + 1, 1).Range.Text = reader["IngredientName"].ToString();
                    table.Cell(row + 1, 2).Range.Text = reader["quantity"].ToString();
                    table.Cell(row + 1, 3).Range.Text = reader["unit"].ToString();
                    
                    if (t == 1)
                    { // Добавляем описание технологии приготовления
                        paragraph = doc.Content.Paragraphs.Add();
                        paragraph.Range.Text = "\nТехнология приготовления:\n" + reader["cookingTechnology"].ToString();
                        paragraph.Range.Font.Size = 15;
                        paragraph.Range.InsertParagraphAfter();
                    }
                    t++;
                }
                if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                this.Activate();
                // Сохраняем и закрываем
                //doc.SaveAs2("Technological_Card.docx");
                //doc.Close();
                //wordApp.Quit();
        }
        private void SellBakeryProducts()
        {
            // Получаем выбранный рецепт из комбобокса
            string selectedRecipe = recipeNameImplementationComboBox.SelectedValue.ToString();

            // Получаем количество, которое хотим продать
            if (!int.TryParse(quantityTextBox.Text, out int sellQuantity) || sellQuantity <= 0)
            {
                MessageBox.Show("Введите корректное количество!");
                return;
            }

            // Получаем дату реализации
            DateTime implementationDate = dateOfImplementationDateTimePicker.Value;

            //SQL - запрос для получения доступной выпечки с учетом срока годности
                string selectSQL = @"
            SELECT TOP (@sellQuantity) nBakeryProducts, dateOfPreparation, expirationDate 
            FROM bakeryProducts 
            WHERE status = N'Реализуется' 
              AND nRecipe = (SELECT nRecipe FROM recipe WHERE nRecipe = @nRecipe)
              AND DATEADD(day, expirationDate, dateOfPreparation) >= @today
            ORDER BY dateOfPreparation ASC"; // Берем самые старые
                                             //string selectSQL = " SELECT TOP " + quantityTextBox.Text + " nBakeryProducts, dateOfPreparation, expirationDate FROM bakeryProducts WHERE status = N'Реализуется' AND nRecipe = (SELECT nRecipe FROM recipe WHERE nRecipe = " + recipeNameImplementationComboBox.SelectedValue + ") AND DATEADD(day, expirationDate, dateOfPreparation) >= N'" + dateOfImplementationDateTimePicker.Value.ToString("MM/dd/yyyy") + "' ORDER BY dateOfPreparation ASC";

            List<int> bakeryToSell = new List<int>();

            using (SqlCommand command = new SqlCommand(selectSQL, Data.connection))
            {
                command.Parameters.AddWithValue("@sellQuantity", sellQuantity);
                command.Parameters.AddWithValue("@nRecipe", selectedRecipe);
                command.Parameters.AddWithValue("@today", DateTime.Today.Date);

                if (Data.connection.State != ConnectionState.Open)
                    Data.connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bakeryToSell.Add(reader.GetInt32(0)); // nBakeryProducts
                    }
                }
            }

            // Проверяем, достаточно ли выпечки
            if (bakeryToSell.Count < sellQuantity)
            {
                MessageBox.Show("Недостаточно выпечки для реализации!");
                return;
            }

            // Обновляем статус у выбранных партий
            string updateSQL = @"
        UPDATE bakeryProducts 
        SET status = N'Продано', dateOfImplementation = @implementationDate 
        WHERE nBakeryProducts IN (" + string.Join(",", bakeryToSell) + ")";

            using (SqlCommand updateCommand = new SqlCommand(updateSQL, Data.connection))
            {
                updateCommand.Parameters.AddWithValue("@implementationDate", implementationDate);
                updateCommand.ExecuteNonQuery();
            }

            MessageBox.Show($"Успешно продано {sellQuantity} шт. выпечки!");

            // Обновляем грид
            gridUpdate("select bakeryProducts.nBakeryProducts, recipe.name, bakeryProducts.type, bakeryProducts.code, bakeryProducts.cost, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation, bakeryProducts.status, bakeryProducts.dateOfImplementation, bakeryProducts.reason from bakeryProducts, recipe where bakeryProducts.nRecipe = recipe.nRecipe");
        }

        private void applyImplementationButton_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Enabled) SellBakeryProducts();
            else
            {
                if (status == "Списано")
                {
                    MessageBox.Show("Нельзя продать списанную выпечку!");
                }
                else if (status == "Продано")
                {
                    MessageBox.Show("Эта выпечка уже продана!");
                }
                else
                {
                    string changeSQL = "update bakeryProducts set status=N'Продано', dateOfImplementation=N'" + dateOfImplementationDateTimePicker.Value.ToString("MM/dd/yyyy") + "' where nBakeryProducts=" + nBakeryProducts;
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    SqlCommand command = new SqlCommand(changeSQL, Data.connection);
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Close();
                    if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                    MessageBox.Show("Выпечка продана");
                    this.Activate();
                }
            }
        }

        private void quantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (quantityTextBox.Text != "") {
                string selectSQL = "SELECT cost FROM bakeryProducts where nRecipe =" + recipeNameImplementationComboBox.SelectedValue;
                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                SqlCommand command = new SqlCommand(selectSQL, Data.connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    decimal cost = Convert.ToDecimal(reader["cost"]);
                    decimal quantity = Convert.ToDecimal(quantityTextBox.Text);
                    finalCostTextBox.Text = Convert.ToString(cost * quantity);
                }
                reader.Close();
                if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
            }
            if (quantityTextBox.Text == "") finalCostTextBox.Text = "";
        }

        private void applyTrashButton_Click(object sender, EventArgs e)
        {
            string changeSQL = "";
            if (status == "Списано")
            {
                MessageBox.Show("Эта выпечка уже списана!");
            }
            else if (status == "Продано")
            {
                MessageBox.Show("Нельзя списать проданную выпечку!");
            }
            else
            {
                if (reasonTextBox.Enabled)
                {
                    changeSQL = "update bakeryProducts set status=N'Списано', dateOfImplementation=N'" + dateOfImplementationDateTimePicker.Value.ToString("MM/dd/yyyy") + "', reason = N'" + reasonTextBox.Text + "' where nBakeryProducts =" + nBakeryProducts;
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    SqlCommand command = new SqlCommand(changeSQL, Data.connection);
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Close();
                    if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                    MessageBox.Show("Выпечка списана");
                    this.Activate();
                }
                else
                {
                    changeSQL = "update bakeryProducts set status=N'Списано', dateOfImplementation=N'" + dateOfImplementationDateTimePicker.Value.ToString("MM/dd/yyyy") + "', reason = N'Истек срок годности' where nBakeryProducts in (select nBakeryProducts from bakeryProducts where DATEADD(day, expirationDate, dateOfPreparation) < N'" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "')";
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    SqlCommand command = new SqlCommand(changeSQL, Data.connection);
                    SqlDataReader dr = command.ExecuteReader();
                    int u = 0;
                    if (dr.HasRows)
                    {
                        u++;
                    }
                    if (u > 0)
                    {
                        dr.Close();
                        MessageBox.Show("Выпечка списана");
                        if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                        this.Activate();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Нету выпечки с истекшим сроком годности");
                        if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                        this.Activate();
                    }
                }
            }
        }
    }
}
