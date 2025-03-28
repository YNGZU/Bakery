using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Word;

namespace Bakery
{
    public partial class bakeryRaports : Form
    {
        private Excel.Application excelapp;
        private Excel.Window excelWindow;
        private Excel.Worksheet excelsheets;
        private Excel.Workbook excelappworkbooks;
        private int i = 0;
        public bakeryRaports()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (statusComboBox.Text == "Реализуется")
            {
                excelapp = new Excel.Application();
                string sql = "Select recipe.name as rName, count(recipe.name) as kolvo, bakeryProducts.type, bakeryProducts.cost, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation from bakeryProducts JOIN recipe on bakeryProducts.nRecipe = recipe.nRecipe where bakeryProducts.dateOfImplementation is NULL group by recipe.name, bakeryProducts.dateOfPreparation, bakeryProducts.type, bakeryProducts.cost, bakeryProducts.expirationDate";
                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                SqlCommand command = new SqlCommand(sql, Data.connection);
                SqlDataReader dr = command.ExecuteReader();
                excelapp.Visible = true;
                excelapp.SheetsInNewWorkbook = 1;
                excelapp.Workbooks.Add(Type.Missing);
                Excel.Range _excelCells = (Excel.Range)excelapp.get_Range("A1", "H1");
                _excelCells.Merge(Type.Missing);


                excelapp.Cells[1, 1].Value = "Каталог выпечки";
                excelapp.Cells[1, 1].Font.Size = 15;
                excelapp.Cells[1, 1].Font.Bold = true;
                excelapp.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                excelapp.Cells[1, 1].Font.Name = "Times New Roman";

                excelapp.Cells[3, 1].Value = "№";
                excelapp.Cells[3, 1].Font.Size = 14;
                excelapp.Cells[3, 1].Font.Bold = true;
                excelapp.Cells[3, 1].Borders.LineStyle = 1;
                excelapp.Cells[4, 1].Borders.LineStyle = 1;
                excelapp.Columns[1].columnwidth = 6;
                excelapp.Cells[3, 1].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 2].Value = "Наименование";
                excelapp.Cells[3, 2].Font.Size = 14;
                excelapp.Cells[3, 2].Font.Bold = true;
                excelapp.Cells[3, 2].Borders.LineStyle = 1;
                excelapp.Cells[4, 2].Borders.LineStyle = 1;
                excelapp.Columns[2].columnwidth = 35;
                excelapp.Cells[3, 2].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 3].Value = "Количество";
                excelapp.Cells[3, 3].Font.Size = 14;
                excelapp.Cells[3, 3].Font.Bold = true;
                excelapp.Cells[3, 3].Borders.LineStyle = 1;
                excelapp.Cells[4, 3].Borders.LineStyle = 1;
                excelapp.Columns[3].columnwidth = 20;
                excelapp.Cells[3, 3].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 4].Value = "Тип";
                excelapp.Cells[3, 4].Font.Size = 14;
                excelapp.Cells[3, 4].Font.Bold = true;
                excelapp.Cells[3, 4].Borders.LineStyle = 1;
                excelapp.Cells[4, 4].Borders.LineStyle = 1;
                excelapp.Columns[4].columnwidth = 30;
                excelapp.Cells[3, 4].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 5].Value = "Стоимость (руб./шт.)";
                excelapp.Cells[3, 5].Font.Size = 14;
                excelapp.Cells[3, 5].Font.Bold = true;
                excelapp.Cells[3, 5].Borders.LineStyle = 1;
                excelapp.Cells[4, 5].Borders.LineStyle = 1;
                excelapp.Columns[5].columnwidth = 30;
                excelapp.Cells[3, 5].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 6].Value = "Срок годности (сут.)";
                excelapp.Cells[3, 6].Font.Size = 14;
                excelapp.Cells[3, 6].Font.Bold = true;
                excelapp.Cells[3, 6].Borders.LineStyle = 1;
                excelapp.Cells[4, 6].Borders.LineStyle = 1;
                excelapp.Columns[6].columnwidth = 30;
                excelapp.Cells[3, 6].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 7].Value = "Дата приготовления";
                excelapp.Cells[3, 7].Font.Size = 14;
                excelapp.Cells[3, 7].Font.Bold = true;
                excelapp.Cells[3, 7].Borders.LineStyle = 1;
                excelapp.Cells[4, 7].Borders.LineStyle = 1;
                excelapp.Columns[7].columnwidth = 30;
                excelapp.Cells[3, 7].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);
                int row = 4;
                int i = 1;
                while (dr.Read())
                {
                    excelapp.Cells[row, 1].Value = i;
                    excelapp.Cells[row, 1].Font.Size = 14;
                    excelapp.Cells[row, 1].Borders.LineStyle = 1;
                    excelapp.Columns[1].columnwidth = 6;
                    excelapp.Cells[row, 1].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 2].Value = (String.Format("{0}", dr["rName"]));
                    excelapp.Cells[row, 2].Font.Size = 14;
                    excelapp.Cells[row, 2].Borders.LineStyle = 1;
                    excelapp.Cells[row, 2].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 3].Value = (String.Format("{0}", dr["kolvo"]));
                    excelapp.Cells[row, 3].Font.Size = 14;
                    excelapp.Cells[row, 3].Borders.LineStyle = 1;
                    excelapp.Cells[row, 3].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 4].Value = (String.Format("{0}", dr["type"]));
                    excelapp.Cells[row, 4].Font.Size = 14;
                    excelapp.Cells[row, 4].Borders.LineStyle = 1;
                    excelapp.Cells[row, 4].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 5].Value = (String.Format("{0}", dr["cost"]));
                    excelapp.Cells[row, 5].Font.Size = 14;
                    excelapp.Cells[row, 5].Borders.LineStyle = 1;
                    excelapp.Cells[row, 5].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 6].Value = (String.Format("{0}", dr["expirationDate"]));
                    excelapp.Cells[row, 6].Font.Size = 14;
                    excelapp.Cells[row, 6].Borders.LineStyle = 1;
                    excelapp.Cells[row, 6].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 7].Value = (String.Format("{0:dd.MM.yyyy}", dr["dateOfPreparation"]));
                    excelapp.Cells[row, 7].Font.Size = 14;
                    excelapp.Cells[row, 7].Borders.LineStyle = 1;
                    excelapp.Cells[row, 7].Font.Name = "Times New Roman";

                    row++;
                    i++;
                }

                row++;
                DateTime currentDateTime = DateTime.Now;
                excelapp.Cells[row, 7].Value = "Дата формирования: " + currentDateTime.ToString("dd.MM.yyyy");
                excelapp.Cells[row, 7].Font.Size = 14;
                excelapp.Cells[row, 7].Font.Name = "Times New Roman";
                excelapp.Cells[row, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);
                if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
            }
            else if (statusComboBox.Text == "Списано")
            {
                excelapp = new Excel.Application();
                string sql = "Select recipe.name as rName, count(recipe.name) as kolvo, bakeryProducts.type, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation, bakeryProducts.dateOfImplementation, bakeryProducts.reason, bakeryProducts.cost from bakeryProducts JOIN recipe on bakeryProducts.nRecipe = recipe.nRecipe where status = N'Списано' and dateOfImplementation between N'" + dateStartDateTimePicker.Value.ToString("MM/dd/yyyy") + "' and N'" + dateEndDateTimePicker.Value.ToString("MM/dd/yyyy") + "' group by recipe.name, bakeryProducts.reason, dateOfImplementation, bakeryProducts.type, bakeryProducts.cost, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation";
                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                SqlCommand command = new SqlCommand(sql, Data.connection);
                SqlDataReader dr = command.ExecuteReader();
                excelapp.Visible = true;
                excelapp.SheetsInNewWorkbook = 1;
                excelapp.Workbooks.Add(Type.Missing);
                Excel.Range _excelCells = (Excel.Range)excelapp.get_Range("A1", "H1");
                _excelCells.Merge(Type.Missing);


                excelapp.Cells[1, 1].Value = "Списанная выпечка за период с " + dateStartDateTimePicker.Value.ToString("dd.MM.yyyy") +" по " + dateEndDateTimePicker.Value.ToString("dd.MM.yyyy");
                excelapp.Cells[1, 1].Font.Size = 15;
                excelapp.Cells[1, 1].Font.Bold = true;
                excelapp.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                excelapp.Cells[1, 1].Font.Name = "Times New Roman";

                excelapp.Cells[3, 1].Value = "№";
                excelapp.Cells[3, 1].Font.Size = 14;
                excelapp.Cells[3, 1].Font.Bold = true;
                excelapp.Cells[3, 1].Borders.LineStyle = 1;
                excelapp.Cells[4, 1].Borders.LineStyle = 1;
                excelapp.Columns[1].columnwidth = 6;
                excelapp.Cells[3, 1].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 2].Value = "Наименование";
                excelapp.Cells[3, 2].Font.Size = 14;
                excelapp.Cells[3, 2].Font.Bold = true;
                excelapp.Cells[3, 2].Borders.LineStyle = 1;
                excelapp.Cells[4, 2].Borders.LineStyle = 1;
                excelapp.Columns[2].columnwidth = 35;
                excelapp.Cells[3, 2].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 3].Value = "Количество";
                excelapp.Cells[3, 3].Font.Size = 14;
                excelapp.Cells[3, 3].Font.Bold = true;
                excelapp.Cells[3, 3].Borders.LineStyle = 1;
                excelapp.Cells[4, 3].Borders.LineStyle = 1;
                excelapp.Columns[3].columnwidth = 20;
                excelapp.Cells[3, 3].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 4].Value = "Тип";
                excelapp.Cells[3, 4].Font.Size = 14;
                excelapp.Cells[3, 4].Font.Bold = true;
                excelapp.Cells[3, 4].Borders.LineStyle = 1;
                excelapp.Cells[4, 4].Borders.LineStyle = 1;
                excelapp.Columns[4].columnwidth = 30;
                excelapp.Cells[3, 4].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 5].Value = "Срок годности (сут.)";
                excelapp.Cells[3, 5].Font.Size = 14;
                excelapp.Cells[3, 5].Font.Bold = true;
                excelapp.Cells[3, 5].Borders.LineStyle = 1;
                excelapp.Cells[4, 5].Borders.LineStyle = 1;
                excelapp.Columns[5].columnwidth = 30;
                excelapp.Cells[3, 5].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 6].Value = "Дата приготовления";
                excelapp.Cells[3, 6].Font.Size = 14;
                excelapp.Cells[3, 6].Font.Bold = true;
                excelapp.Cells[3, 6].Borders.LineStyle = 1;
                excelapp.Cells[4, 6].Borders.LineStyle = 1;
                excelapp.Columns[6].columnwidth = 30;
                excelapp.Cells[3, 6].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 7].Value = "Дата списания";
                excelapp.Cells[3, 7].Font.Size = 14;
                excelapp.Cells[3, 7].Font.Bold = true;
                excelapp.Cells[3, 7].Borders.LineStyle = 1;
                excelapp.Cells[4, 7].Borders.LineStyle = 1;
                excelapp.Columns[7].columnwidth = 30;
                excelapp.Cells[3, 7].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 8].Value = "Причина списания";
                excelapp.Cells[3, 8].Font.Size = 14;
                excelapp.Cells[3, 8].Font.Bold = true;
                excelapp.Cells[3, 8].Borders.LineStyle = 1;
                excelapp.Cells[4, 8].Borders.LineStyle = 1;
                excelapp.Columns[8].columnwidth = 30;
                excelapp.Cells[3, 8].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 9].Value = "Стоимость (руб./шт.)";
                excelapp.Cells[3, 9].Font.Size = 14;
                excelapp.Cells[3, 9].Font.Bold = true;
                excelapp.Cells[3, 9].Borders.LineStyle = 1;
                excelapp.Cells[4, 9].Borders.LineStyle = 1;
                excelapp.Columns[9].columnwidth = 30;
                excelapp.Cells[3, 9].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 10].Value = "Сумма итого";
                excelapp.Cells[3, 10].Font.Size = 14;
                excelapp.Cells[3, 10].Font.Bold = true;
                excelapp.Cells[3, 10].Borders.LineStyle = 1;
                excelapp.Cells[4, 10].Borders.LineStyle = 1;
                excelapp.Columns[10].columnwidth = 30;
                excelapp.Cells[3, 10].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);
                int row = 4;
                int i = 1;
                while (dr.Read())
                {
                    excelapp.Cells[row, 1].Value = i;
                    excelapp.Cells[row, 1].Font.Size = 14;
                    excelapp.Cells[row, 1].Borders.LineStyle = 1;
                    excelapp.Columns[1].columnwidth = 6;
                    excelapp.Cells[row, 1].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 2].Value = (String.Format("{0}", dr["rName"]));
                    excelapp.Cells[row, 2].Font.Size = 14;
                    excelapp.Cells[row, 2].Borders.LineStyle = 1;
                    excelapp.Cells[row, 2].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 3].Value = (String.Format("{0}", dr["kolvo"]));
                    excelapp.Cells[row, 3].Font.Size = 14;
                    excelapp.Cells[row, 3].Borders.LineStyle = 1;
                    excelapp.Cells[row, 3].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 4].Value = (String.Format("{0}", dr["type"]));
                    excelapp.Cells[row, 4].Font.Size = 14;
                    excelapp.Cells[row, 4].Borders.LineStyle = 1;
                    excelapp.Cells[row, 4].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 5].Value = (String.Format("{0}", dr["expirationDate"]));
                    excelapp.Cells[row, 5].Font.Size = 14;
                    excelapp.Cells[row, 5].Borders.LineStyle = 1;
                    excelapp.Cells[row, 5].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 6].Value = (String.Format("{0:dd.MM.yyyy}", dr["dateOfPreparation"]));
                    excelapp.Cells[row, 6].Font.Size = 14;
                    excelapp.Cells[row, 6].Borders.LineStyle = 1;
                    excelapp.Cells[row, 6].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 7].Value = (String.Format("{0:dd.MM.yyyy}", dr["dateOfImplementation"]));
                    excelapp.Cells[row, 7].Font.Size = 14;
                    excelapp.Cells[row, 7].Borders.LineStyle = 1;
                    excelapp.Cells[row, 7].Font.Name = "Times New Roman";

                    Excel.Range cell3 = excelapp.Cells[row, 8];  // Приведение к типу Range
                    cell3.Value = dr["reason"];
                    cell3.Font.Size = 14;
                    cell3.Borders.LineStyle = 1;
                    cell3.Font.Name = "Times New Roman";

                    Excel.Range cell = excelapp.Cells[row, 9];  // Приведение к типу Range
                    cell.Value = dr["cost"];
                    cell.NumberFormat = "#,##0.00";  // Устанавливаем числовой формат с 2 знаками после запятой
                    cell.Font.Size = 14;
                    cell.Borders.LineStyle = 1;
                    cell.Font.Name = "Times New Roman";

                    Excel.Range cell4 = excelapp.Cells[row, 10];  // Приведение к типу Range
                    cell4.Formula = "=C"+row+"*I"+row+"";
                    cell4.NumberFormat = "#,##0.00";  // Устанавливаем числовой формат с 2 знаками после запятой
                    cell4.Font.Size = 14;
                    cell4.Borders.LineStyle = 1;
                    cell4.Font.Name = "Times New Roman";

                    row++;
                    i++;
                }

                int sum = row - 1;
                excelapp.Cells[row, 9].Value = "Общие убытки:";
                excelapp.Cells[row, 9].Font.Size = 14;
                excelapp.Cells[row, 9].Borders.LineStyle = 1;
                excelapp.Cells[row, 9].Font.Bold = true;
                excelapp.Cells[row, 9].Font.Name = "Times New Roman";
                excelapp.Cells[row, 9].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);
 
                excelapp.Cells[row, 10].Formula = "=SUM(J4:J"+ sum +")";
                excelapp.Cells[row, 10].Font.Size = 14;
                excelapp.Cells[row, 10].Borders.LineStyle = 1;
                excelapp.Cells[row, 10].Font.Bold = true;
                excelapp.Cells[row, 10].Font.Name = "Times New Roman";
                excelapp.Cells[row, 10].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);

                row += 2;
                DateTime currentDateTime = DateTime.Now;
                excelapp.Cells[row, 10].Value = "Дата формирования: " + currentDateTime.ToString("dd.MM.yyyy");
                excelapp.Cells[row, 10].Font.Size = 14;
                excelapp.Cells[row, 10].Font.Name = "Times New Roman";
                excelapp.Cells[row, 10].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);

                if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
            }
            else if (statusComboBox.Text == "Продано") {
                excelapp = new Excel.Application();
                string sql = "Select recipe.name as rName, count(recipe.name) as kolvo, bakeryProducts.type, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation, bakeryProducts.dateOfImplementation, bakeryProducts.cost from bakeryProducts JOIN recipe on bakeryProducts.nRecipe = recipe.nRecipe where status = N'Продано' and dateOfImplementation between N'" + dateStartDateTimePicker.Value.ToString("MM/dd/yyyy") + "' and N'" + dateEndDateTimePicker.Value.ToString("MM/dd/yyyy") + "' group by recipe.name, dateOfImplementation, bakeryProducts.type, bakeryProducts.cost, bakeryProducts.expirationDate, bakeryProducts.dateOfPreparation";
                if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
                SqlCommand command = new SqlCommand(sql, Data.connection);
                SqlDataReader dr = command.ExecuteReader();
                excelapp.Visible = true;
                excelapp.SheetsInNewWorkbook = 1;
                excelapp.Workbooks.Add(Type.Missing);
                Excel.Range _excelCells = (Excel.Range)excelapp.get_Range("A1", "H1");
                _excelCells.Merge(Type.Missing);


                excelapp.Cells[1, 1].Value = "Реализованная выпечка за период с " + dateStartDateTimePicker.Value.ToString("dd.MM.yyyy") + " по " + dateEndDateTimePicker.Value.ToString("dd.MM.yyyy");
                excelapp.Cells[1, 1].Font.Size = 15;
                excelapp.Cells[1, 1].Font.Bold = true;
                excelapp.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                excelapp.Cells[1, 1].Font.Name = "Times New Roman";

                excelapp.Cells[3, 1].Value = "№";
                excelapp.Cells[3, 1].Font.Size = 14;
                excelapp.Cells[3, 1].Font.Bold = true;
                excelapp.Cells[3, 1].Borders.LineStyle = 1;
                excelapp.Cells[4, 1].Borders.LineStyle = 1;
                excelapp.Columns[1].columnwidth = 6;
                excelapp.Cells[3, 1].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 2].Value = "Наименование";
                excelapp.Cells[3, 2].Font.Size = 14;
                excelapp.Cells[3, 2].Font.Bold = true;
                excelapp.Cells[3, 2].Borders.LineStyle = 1;
                excelapp.Cells[4, 2].Borders.LineStyle = 1;
                excelapp.Columns[2].columnwidth = 35;
                excelapp.Cells[3, 2].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 3].Value = "Количество";
                excelapp.Cells[3, 3].Font.Size = 14;
                excelapp.Cells[3, 3].Font.Bold = true;
                excelapp.Cells[3, 3].Borders.LineStyle = 1;
                excelapp.Cells[4, 3].Borders.LineStyle = 1;
                excelapp.Columns[3].columnwidth = 20;
                excelapp.Cells[3, 3].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 4].Value = "Тип";
                excelapp.Cells[3, 4].Font.Size = 14;
                excelapp.Cells[3, 4].Font.Bold = true;
                excelapp.Cells[3, 4].Borders.LineStyle = 1;
                excelapp.Cells[4, 4].Borders.LineStyle = 1;
                excelapp.Columns[4].columnwidth = 30;
                excelapp.Cells[3, 4].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 5].Value = "Срок годности (сут.)";
                excelapp.Cells[3, 5].Font.Size = 14;
                excelapp.Cells[3, 5].Font.Bold = true;
                excelapp.Cells[3, 5].Borders.LineStyle = 1;
                excelapp.Cells[4, 5].Borders.LineStyle = 1;
                excelapp.Columns[5].columnwidth = 30;
                excelapp.Cells[3, 5].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 6].Value = "Дата приготовления";
                excelapp.Cells[3, 6].Font.Size = 14;
                excelapp.Cells[3, 6].Font.Bold = true;
                excelapp.Cells[3, 6].Borders.LineStyle = 1;
                excelapp.Cells[4, 6].Borders.LineStyle = 1;
                excelapp.Columns[6].columnwidth = 30;
                excelapp.Cells[3, 6].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 7].Value = "Дата реализации";
                excelapp.Cells[3, 7].Font.Size = 14;
                excelapp.Cells[3, 7].Font.Bold = true;
                excelapp.Cells[3, 7].Borders.LineStyle = 1;
                excelapp.Cells[4, 7].Borders.LineStyle = 1;
                excelapp.Columns[7].columnwidth = 30;
                excelapp.Cells[3, 7].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 8].Value = "Стоимость (руб./шт.)";
                excelapp.Cells[3, 8].Font.Size = 14;
                excelapp.Cells[3, 8].Font.Bold = true;
                excelapp.Cells[3, 8].Borders.LineStyle = 1;
                excelapp.Cells[4, 8].Borders.LineStyle = 1;
                excelapp.Columns[8].columnwidth = 30;
                excelapp.Cells[3, 8].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[3, 9].Value = "Сумма итого";
                excelapp.Cells[3, 9].Font.Size = 14;
                excelapp.Cells[3, 9].Font.Bold = true;
                excelapp.Cells[3, 9].Borders.LineStyle = 1;
                excelapp.Cells[4, 9].Borders.LineStyle = 1;
                excelapp.Columns[9].columnwidth = 30;
                excelapp.Cells[3, 9].Font.Name = "Times New Roman";
                _excelCells.Merge(Type.Missing);
                int row = 4;
                int i = 1;
                while (dr.Read())
                {
                    excelapp.Cells[row, 1].Value = i;
                    excelapp.Cells[row, 1].Font.Size = 14;
                    excelapp.Cells[row, 1].Borders.LineStyle = 1;
                    excelapp.Columns[1].columnwidth = 6;
                    excelapp.Cells[row, 1].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 2].Value = (String.Format("{0}", dr["rName"]));
                    excelapp.Cells[row, 2].Font.Size = 14;
                    excelapp.Cells[row, 2].Borders.LineStyle = 1;
                    excelapp.Cells[row, 2].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 3].Value = (String.Format("{0}", dr["kolvo"]));
                    excelapp.Cells[row, 3].Font.Size = 14;
                    excelapp.Cells[row, 3].Borders.LineStyle = 1;
                    excelapp.Cells[row, 3].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 4].Value = (String.Format("{0}", dr["type"]));
                    excelapp.Cells[row, 4].Font.Size = 14;
                    excelapp.Cells[row, 4].Borders.LineStyle = 1;
                    excelapp.Cells[row, 4].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 5].Value = (String.Format("{0}", dr["expirationDate"]));
                    excelapp.Cells[row, 5].Font.Size = 14;
                    excelapp.Cells[row, 5].Borders.LineStyle = 1;
                    excelapp.Cells[row, 5].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 6].Value = (String.Format("{0:dd.MM.yyyy}", dr["dateOfPreparation"]));
                    excelapp.Cells[row, 6].Font.Size = 14;
                    excelapp.Cells[row, 6].Borders.LineStyle = 1;
                    excelapp.Cells[row, 6].Font.Name = "Times New Roman";

                    excelapp.Cells[row, 7].Value = (String.Format("{0:dd.MM.yyyy}", dr["dateOfImplementation"]));
                    excelapp.Cells[row, 7].Font.Size = 14;
                    excelapp.Cells[row, 7].Borders.LineStyle = 1;
                    excelapp.Cells[row, 7].Font.Name = "Times New Roman";

                    Excel.Range cell = excelapp.Cells[row, 8];  // Приведение к типу Range
                    cell.Value = dr["cost"];
                    cell.NumberFormat = "#,##0.00";  // Устанавливаем числовой формат с 2 знаками после запятой
                    cell.Font.Size = 14;
                    cell.Borders.LineStyle = 1;
                    cell.Font.Name = "Times New Roman";

                    Excel.Range cell4 = excelapp.Cells[row, 9];  // Приведение к типу Range
                    cell4.Formula = "=C" + row + "*H" + row + "";
                    cell4.NumberFormat = "#,##0.00";  // Устанавливаем числовой формат с 2 знаками после запятой
                    cell4.Font.Size = 14;
                    cell4.Borders.LineStyle = 1;
                    cell4.Font.Name = "Times New Roman";

                    row++;
                    i++;
                }

                int sum = row - 1;
                excelapp.Cells[row, 8].Value = "Общая выручка:";
                excelapp.Cells[row, 8].Font.Size = 14;
                excelapp.Cells[row, 8].Borders.LineStyle = 1;
                excelapp.Cells[row, 8].Font.Bold = true;
                excelapp.Cells[row, 8].Font.Name = "Times New Roman";
                excelapp.Cells[row, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);

                excelapp.Cells[row, 9].Formula = "=SUM(I4:I" + sum + ")";
                excelapp.Cells[row, 9].Font.Size = 14;
                excelapp.Cells[row, 9].Borders.LineStyle = 1;
                excelapp.Cells[row, 9].Font.Bold = true;
                excelapp.Cells[row, 9].Font.Name = "Times New Roman";
                excelapp.Cells[row, 9].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);

                row++;
                excelapp.Cells[row, 8].Value = "Общая прибыль:";
                excelapp.Cells[row, 8].Font.Size = 14;
                excelapp.Cells[row, 8].Borders.LineStyle = 1;
                excelapp.Cells[row, 8].Font.Bold = true;
                excelapp.Cells[row, 8].Font.Name = "Times New Roman";
                excelapp.Cells[row, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);

                Excel.Range cell2 = excelapp.Cells[row, 9];
                cell2.Formula = "=SUM(I4:I" + sum + ")*0.2";
                cell2.NumberFormat = "#,##0.00";  // Устанавливаем числовой формат с 2 знаками после запятой
                cell2.Font.Size = 14;
                cell2.Borders.LineStyle = 1;
                cell2.Font.Name = "Times New Roman";
                cell2.Font.Bold = true;


                row += 2;
                DateTime currentDateTime = DateTime.Now;
                excelapp.Cells[row, 9].Value = "Дата формирования: " + currentDateTime;
                excelapp.Cells[row, 9].Font.Size = 14;
                excelapp.Cells[row, 9].Font.Name = "Times New Roman";
                excelapp.Cells[row, 9].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                _excelCells.Merge(Type.Missing);

                if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
            }
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.Text == "Реализуется")
            {
                dateEndDateTimePicker.Enabled = false;
                dateStartDateTimePicker.Enabled = false;
            }
            else
            {
                dateEndDateTimePicker.Enabled = true;
                dateStartDateTimePicker.Enabled = true;
            }
        }
    }
}
