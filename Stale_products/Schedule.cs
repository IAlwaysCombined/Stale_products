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
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TV.mdb;"; //Строка подключения к бд
        public static string queryAdapter = "SELECT Quantity_Of_Goods_Sold, Quantity_Of_Purchased_Goods, Quantity_Of_Goods  FROM Product_Sale WHERE Name_Product = '{0}'"; //Строка запроса
        public static string queryCommand = "SELECT * FROM Product_Sale WHERE Name_Product = '{0}'"; //Строка запроса

        // Объявление объектов
        private OleDbDataAdapter dataAdapter;
        private DataSet dataSet;
        private DataTable table;
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader dataReader;
        private ChangeYear changeYear;
        private LineSeries line;

        /// <summary>
        /// Инициализация всех компонентов
        /// </summary>
        public Schedule()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionString);
            command = connection.CreateCommand();
            dataAdapter = new OleDbDataAdapter(command.CommandText = String.Format(queryAdapter, Data.modelProduct), connectionString);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Product_Sale");
            table = dataSet.Tables["Product_Sale"];
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            Output(command, connection);
        }

        /// <summary>
        /// Метод формирование вывода
        /// </summary>
        /// <param name="сommand"></param>
        /// <param name="myOleDbConnection"></param>
        private void Output(OleDbCommand сommand, OleDbConnection сonnection)
        {
            command.CommandText = String.Format(queryCommand, Data.modelProduct);
            сonnection.Open();
            dataReader = сommand.ExecuteReader();
            dataReader.Read();
            int sale = Convert.ToInt32(dataReader["Quantity_Of_Goods_Sold"]); // Преобразование количества проданных товаров в int
            int purchase = Convert.ToInt32(dataReader["Quantity_Of_Purchased_Goods"]); // Преобразование количества закупленных товаров в int
            int stock = Convert.ToInt32(dataReader["Quantity_Of_Goods"]); // Преобразование количества товаров на складе в int

            // Условная конструкция, определяющая спрос
            if (sale*2 <= stock)
            {
                labelOutputText.Text = "Данная модель склонна к устареванию";
            }
            else if (sale >= stock)
            {
                labelOutputText.Text = "Данная модель не склонна к устареванию";
            }
            else if(sale < stock && stock < purchase)
            {
                labelOutputText.Text = "Данная модель имеет непостоянный характер спроса";
            }
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
            foreach (DataRow row in table.Rows)
            {
                foreach(DataColumn column in table.Columns)
                {
                    var field1 = row[column].ToString();
                    product.Add(Convert.ToInt32(field1));
                }
            }
            cartesianChart1.AxisX.Clear();
            line = new LineSeries();
            line.Title = "Количество единиц";
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
            changeYear = new ChangeYear();
            changeYear.Show();
            this.Hide();
        }
    }
}