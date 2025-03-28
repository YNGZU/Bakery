using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bakery
{
    public partial class inputIngredient : Form
    {
        public void gridUpdate(string SQL)
        {
            ingredientDataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            ingredientDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Data.connection);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            ingredientDataGridView.Refresh();
            ingredientDataGridView.DataSource = tb;
            ingredientDataGridView.Columns[0].HeaderText = "№ Ингредиента";
            ingredientDataGridView.Columns[1].HeaderText = "Наименование";
            ingredientDataGridView.Columns[2].HeaderText = "Стоимость (руб./ед.)";
            ingredientDataGridView.Columns[3].HeaderText = "Количество";
            ingredientDataGridView.Columns[4].HeaderText = "Ед. измерения";
            ingredientDataGridView.Columns[0].Visible = false;
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }
        public inputIngredient()
        {
            InitializeComponent();
            changeIngredientButton.Enabled = false;
        }

        private void inputIngredient_Activated(object sender, EventArgs e)
        {
            string selectSQL = "SELECT ingredient.nIngredient, ingredient.name, ingredient.cost, ingredient.quantity, ingredient.unit FROM ingredient";
            gridUpdate(selectSQL);
        }

        string nIngredient = "";
        private void ingredientDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                nIngredient = ingredientDataGridView[0, ingredientDataGridView.CurrentRow.Index].Value.ToString();
                ingredientNameTextBox.Text = ingredientDataGridView[1, ingredientDataGridView.CurrentRow.Index].Value.ToString();
                costTextBox.Text = ingredientDataGridView[2, ingredientDataGridView.CurrentRow.Index].Value.ToString();
                quantityTextBox.Text = ingredientDataGridView[3, ingredientDataGridView.CurrentRow.Index].Value.ToString();
                unitComboBox.Text = ingredientDataGridView[4, ingredientDataGridView.CurrentRow.Index].Value.ToString();

                addIngredientButton.Enabled = false;
                changeIngredientButton.Enabled = true;
            }catch (Exception my_e) {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }
}

        private void changeIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();

                if (String.IsNullOrWhiteSpace(ingredientNameTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Название не должно быть пустым!");
                }
                if (String.IsNullOrWhiteSpace(quantityTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Введите количество!");
                }
                if (String.IsNullOrWhiteSpace(costTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите стоимость!");
                }
                if (unitComboBox.ValueMember == null) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите единицу измерения!");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    float cost = float.Parse(costTextBox.Text);
                    float quantity = float.Parse(quantityTextBox.Text);
                    string changeSQL = "update ingredient set name=N'" + ingredientNameTextBox.Text + "', cost=" + cost + ", quantity=" + quantity + ", unit = N'" + unitComboBox.SelectedItem + "' where nIngredient=" + nIngredient;
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    SqlCommand command = new SqlCommand(changeSQL, Data.connection);
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Close();
                    if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                    MessageBox.Show("Данные изменены");
                    this.Activate();
                }
            } catch (Exception my_e) {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            unitComboBox.Text = "";
            ingredientNameTextBox.Text = "";
            costTextBox.Text = "";
            quantityTextBox.Text = "";
            ingredientSearchTextBox.Text = "";
            addIngredientButton.Enabled = true;
            changeIngredientButton.Enabled = false;
            string cancelSQL = "select ingredient.nIngredient, ingredient.name, ingredient.cost, ingredient.quantity, ingredient.unit from ingredient";
            gridUpdate(cancelSQL);
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();

                if (String.IsNullOrWhiteSpace(ingredientNameTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Название не должно быть пустым!");
                }
                if (String.IsNullOrWhiteSpace(quantityTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Введите количество!");
                }
                if (String.IsNullOrWhiteSpace(costTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите стоимость!");
                }
                if (unitComboBox.ValueMember == null) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите единицу измерения!");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    float cost = 0;
                    if (float.Parse(costTextBox.Text) >= 10) cost = float.Parse(costTextBox.Text) / float.Parse(quantityTextBox.Text);
                    else cost = float.Parse(costTextBox.Text);
                    float quantity = float.Parse(quantityTextBox.Text);
                    string SQL = "select * from ingredient where name = N'" + ingredientNameTextBox.Text + "'";
                    SqlCommand commandSQL = new SqlCommand(SQL, Data.connection);
                    SqlDataReader reader = commandSQL.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        SQL = "update ingredient set quantity= quantity + " + quantity + " where name = N'" + ingredientNameTextBox.Text + "'";
                        SqlCommand commandUpdate = new SqlCommand(SQL, Data.connection);
                        SqlDataReader dr = commandUpdate.ExecuteReader();
                        dr.Close();
                        Data.connection.Close();
                    }
                    else
                    {
                        reader.Close();
                        SQL = "INSERT INTO ingredient(name, cost, quantity, unit) VALUES (@name, @cost, @quantity, @unit)";
                        SqlCommand command = new SqlCommand(SQL, Data.connection);

                        // Добавление параметров
                        command.Parameters.AddWithValue("@name", ingredientNameTextBox.Text);
                        command.Parameters.AddWithValue("@cost", cost);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@unit", unitComboBox.SelectedItem);

                        // Выполнение запроса
                        command.ExecuteNonQuery();
                    }
                    if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
                    MessageBox.Show("Данные добавлены");
                    this.Activate();
                }
            }
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 50));
            }
        }

        private void ingredientSearchButton_Click(object sender, EventArgs e)
        {
            string searchSQL = "select ingredient.nIngredient, ingredient.name, ingredient.cost, ingredient.quantity, ingredient.unit from ingredient where ingredient.name like N'" + ingredientSearchTextBox.Text + "%'" ;
            gridUpdate(searchSQL);
        }

        private void implementingNumberInput(object sender, KeyPressEventArgs e)
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

    }
}
