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
    public partial class main : Form
    {
        private Excel.Application excelapp;
        private Excel.Window excelWindow;
        private Excel.Worksheet excelsheets;
        private Excel.Workbook excelappworkbooks;
        private int i = 0;
        public main()
        {
            InitializeComponent();
        }

        private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputRecipe Check = new inputRecipe();
            Check.ShowDialog();
        }

        private void ingredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputIngredient Check = new inputIngredient();
            Check.ShowDialog();
        }

        private void bakeryProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputBakeryProducts Check = new inputBakeryProducts();
            Check.ShowDialog();
        }
        private void technologocalCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTechnologicalCard Check = new inputTechnologicalCard();
            Check.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("help.docx");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ingredientsAreAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excelapp = new Excel.Application();
            string sql = "select name, cost, quantity, unit from ingredient";
            if (Data.connection.State != ConnectionState.Open) Data.connection.Open();
            SqlCommand command = new SqlCommand(sql, Data.connection);
            SqlDataReader dr = command.ExecuteReader();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);
            Excel.Range _excelCells = (Excel.Range)excelapp.get_Range("A1", "E1");
            _excelCells.Merge(Type.Missing);


            excelapp.Cells[1, 1].Value = "Ингредиенты в наличии";
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

            excelapp.Cells[3, 3].Value = "Стоимость (руб./ед.)";
            excelapp.Cells[3, 3].Font.Size = 14;
            excelapp.Cells[3, 3].Font.Bold = true;
            excelapp.Cells[3, 3].Borders.LineStyle = 1;
            excelapp.Cells[4, 3].Borders.LineStyle = 1;
            excelapp.Columns[3].columnwidth = 35;
            excelapp.Cells[3, 3].Font.Name = "Times New Roman";
            _excelCells.Merge(Type.Missing);

            excelapp.Cells[3, 4].Value = "Количество";
            excelapp.Cells[3, 4].Font.Size = 14;
            excelapp.Cells[3, 4].Font.Bold = true;
            excelapp.Cells[3, 4].Borders.LineStyle = 1;
            excelapp.Cells[4, 4].Borders.LineStyle = 1;
            excelapp.Columns[4].columnwidth = 35;
            excelapp.Cells[3, 4].Font.Name = "Times New Roman";
            _excelCells.Merge(Type.Missing);

            excelapp.Cells[3, 5].Value = "Ед. Измерения";
            excelapp.Cells[3, 5].Font.Size = 14;
            excelapp.Cells[3, 5].Font.Bold = true;
            excelapp.Cells[3, 5].Borders.LineStyle = 1;
            excelapp.Cells[4, 5].Borders.LineStyle = 1;
            excelapp.Columns[5].columnwidth = 35;
            excelapp.Cells[3, 5].Font.Name = "Times New Roman";
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

                excelapp.Cells[row, 2].Value = (String.Format("{0}", dr["name"]));
                excelapp.Cells[row, 2].Font.Size = 14;
                excelapp.Cells[row, 2].Borders.LineStyle = 1;
                excelapp.Cells[row, 2].Font.Name = "Times New Roman";

                excelapp.Cells[row, 3].Value = (String.Format("{0}", dr["cost"]));
                excelapp.Cells[row, 3].Font.Size = 14;
                excelapp.Cells[row, 3].Borders.LineStyle = 1;
                excelapp.Cells[row, 3].Font.Name = "Times New Roman";

                excelapp.Cells[row, 4].Value = (String.Format("{0}", dr["quantity"]));
                excelapp.Cells[row, 4].Font.Size = 14;
                excelapp.Cells[row, 4].Borders.LineStyle = 1;
                excelapp.Cells[row, 4].Font.Name = "Times New Roman";

                excelapp.Cells[row, 5].Value = (String.Format("{0}", dr["unit"]));
                excelapp.Cells[row, 5].Font.Size = 14;
                excelapp.Cells[row, 5].Borders.LineStyle = 1;
                excelapp.Cells[row, 5].Font.Name = "Times New Roman";

                row++;
                i++;
            }

            row++;
            DateTime currentDateTime = DateTime.Now;
            excelapp.Cells[row, 5].Value = "Дата формирования: " + currentDateTime;
            excelapp.Cells[row, 5].Font.Size = 14;
            excelapp.Cells[row, 5].Font.Name = "Times New Roman";
            excelapp.Cells[row, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            _excelCells.Merge(Type.Missing);
            if (Data.connection.State != ConnectionState.Closed) Data.connection.Close();
        }

        private void bakeryRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bakeryRating Check = new bakeryRating();
            Check.ShowDialog();
        }

        private void bakeryRaportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bakeryRaports Check = new bakeryRaports();
            Check.ShowDialog();
        }

        private void technologicalCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
