using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Stale_products
{
    public partial class Schedule : Form
    {

        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TV.mdb;";


        // Объявление объектов
        private OleDbConnection myConnection;
        private OleDbDataAdapter dataAdapter;
        private DataSet dataSet;
        private DataTable table;


        /// <summary>
        /// Инициализация всех компонентов
        /// </summary>
        public Schedule()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Product_Sale", connectionString);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Product_Sale");
            table = dataSet.Tables["Product_Sale"];
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        /// <summary>
        /// Построение графика при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Schedule_Load(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            ChartValues<int> product = new ChartValues<int>();

            List<string> dates = new List<string>();

            foreach(DataRow row in table.Rows)
            {
                product.Add(Convert.ToInt32(row["Quantity_Of_Goods_Sold"]));

                dates.Add(Convert.ToDateTime(row["Date"]).ToShortDateString());
            }

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis()
            {
                Labels = dates
            });

            LineSeries line = new LineSeries();
            line.Title = "Количество проданных единиц";
            line.Values = product;

            series.Add(line);

            cartesianChart1.Series = series;
        }

        /// <summary>
        /// Кнопка перехода на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            ChangeYear changeYear = new ChangeYear();
            changeYear.Show();
            this.Hide();
        }
    }
}
