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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Bakery
{
    public partial class inputRecipe : Form
    {
        public inputRecipe()
        {
            InitializeComponent();
            changeRecipeButton.Enabled = false;
        }

        public void gridUpdate(string SQL)
        {
            recipeDataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            recipeDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Data.connection);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            recipeDataGridView.Refresh();
            recipeDataGridView.DataSource = tb;
            recipeDataGridView.Columns[0].HeaderText = "№ Рецепта";
            recipeDataGridView.Columns[1].HeaderText = "Название";
            recipeDataGridView.Columns[2].HeaderText = "Время приготовления (мин.)";
            recipeDataGridView.Columns[3].HeaderText = "Количество порций";

            recipeDataGridView.Columns[0].Visible = false;
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        private void inputRecipe_Load(object sender, EventArgs e)
        {
            addRecipeButton.Enabled = true;
            changeRecipeButton.Enabled = false;
        }

        private void inputRecipe_Activated(object sender, EventArgs e)
        {
            string selectSQL = "select nRecipe, name, cookingTime, servingsQuantity from recipe";
            gridUpdate(selectSQL);
            
        }

        string nRecipe = "";

        private void recipeDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                nRecipe = recipeDataGridView[0, recipeDataGridView.CurrentRow.Index].Value.ToString();
                recipeNameTextBox.Text = recipeDataGridView[1, recipeDataGridView.CurrentRow.Index].Value.ToString();
                cookingTimeTextBox.Text = recipeDataGridView[2, recipeDataGridView.CurrentRow.Index].Value.ToString();
                quantityTextBox.Text = recipeDataGridView[3, recipeDataGridView.CurrentRow.Index].Value.ToString();

                addRecipeButton.Enabled = false;
                changeRecipeButton.Enabled = true;
            }
            catch (Exception my_e)
            {
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }
        }

        private void changeRecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();

                if (String.IsNullOrWhiteSpace(recipeNameTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Название не должно быть пустым!");
                }
                if (String.IsNullOrWhiteSpace(cookingTimeTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите время готовки!");
                }
                if (String.IsNullOrWhiteSpace(quantityTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите количество порций!");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    string changeSQL = "update recipe set name=N'" + recipeNameTextBox.Text + "', cookingTime=N'" + cookingTimeTextBox.Text + "', servingsQuantity=" + quantityTextBox.Text + " where nRecipe=" + nRecipe;
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
                MessageBox.Show("Ошибка ввода! " + my_e.ToString().Substring(0, 70));
            }
}

        private void cancelButton_Click(object sender, EventArgs e)
        {
            recipeNameTextBox.Text = "";
            cookingTimeTextBox.Text = "";
            recipeSearchTextBox.Text = "";
            quantityTextBox.Text = "";
            addRecipeButton.Enabled = true;
            changeRecipeButton.Enabled = false;
            string cancelSQL = "select nRecipe, name, cookingTime, servingsQuantity from recipe";
            gridUpdate(cancelSQL);
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();

                if (String.IsNullOrWhiteSpace(recipeNameTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Название не должно быть пустым!");
                }
                if (String.IsNullOrWhiteSpace(cookingTimeTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите время готовки!");
                }
                if (String.IsNullOrWhiteSpace(quantityTextBox.Text)) //пустое поле или с пробелами
                {
                    errors.AppendLine("Укажите количество порций!");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }
                else
                {
                    string addSQL = "insert into recipe(name, cookingTime, servingsQuantity) values (N'" + recipeNameTextBox.Text + "', N'" + cookingTimeTextBox.Text + "', " + quantityTextBox.Text + ")";
                    if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                    SqlCommand command = new SqlCommand(addSQL, Data.connection);
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Close();
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

        private void recipeSearchButton_Click(object sender, EventArgs e)
        {
            string searchSQL = "select nRecipe, name, cookingTime, servingsQuantity from recipe where name like N'" + recipeSearchTextBox.Text +"%'";
            gridUpdate(searchSQL);
        }

        private void implementingNumberInput(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; //перехват символа нажатой клавиши 
            //8 – код клавиши backspace
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

        }

        private void cookingTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; //перехват символа нажатой клавиши 
            //8 – код клавиши backspace
            //44 – код запятой
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Отклоняем ввод
            }

            if (e.KeyChar == ',' && (sender as System.Windows.Forms.TextBox).Text.Length == 0)
            {
                e.Handled = true; // Отклоняем ввод
            }
        }
    }
}
