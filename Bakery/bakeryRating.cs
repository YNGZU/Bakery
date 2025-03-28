using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace Bakery
{
    public partial class bakeryRating : Form
    {
        public bakeryRating()
        {
            InitializeComponent();
        }

        private void createRatingButton_Click(object sender, EventArgs e)
        {
            ratingBar.Series["Выпечка"].Points.Clear();
            ratingBar.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            ratingBar.ChartAreas["ChartArea1"].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
            ratingBar.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font
         = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular);
            string SQL = "SELECT recipe.name, COUNT(*) AS quantity FROM bakeryProducts, recipe WHERE dateOfImplementation BETWEEN '" + startDateTimePicker.Value.ToString("MM/dd/yyyy") + "' AND '" + endDateTimePicker.Value.ToString("MM/dd/yyyy") + "' AND status = N'Продано' and bakeryProducts.nRecipe = recipe.nRecipe GROUP BY name";
            Data.connection.Close();
            Data.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, Data.connection);
            SqlCommand command = new SqlCommand(SQL, Data.connection);
            SqlDataReader dr = command.ExecuteReader();
            string name;

            while (dr.Read())
            {
                name = Convert.ToString(dr["name"]);
                double quantity = Convert.ToDouble(dr["quantity"]);
                ratingBar.Series["Выпечка"].Points.AddXY(name, quantity);
            }
            dr.Close();
            Data.connection.Close();
        }
    }
}
