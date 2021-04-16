using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stale_products
{
    public partial class ChangeYear : Form
    {
        // Объявление объектов
        private OleDbConnection myConnection;
        private OleDbDataAdapter dataAdapter;
        private DataSet dataSet;
        private DataTable table;
        private OleDbCommand command;

        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TV.mdb;"; //Строка подключения к бд
        public static string query = "SELECT * FROM Product ORDER BY ID_Product"; //Строка запроса

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public ChangeYear()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
        }
        /// <summary>
        /// Инициализация comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangYear_Load(object sender, EventArgs e)
        {
            dataAdapter = new OleDbDataAdapter(query, connectionString);
            DataTable tb1 = new DataTable();
            dataAdapter.Fill(tb1);
            comboBoxChangeProductYear.DataSource = tb1;
            comboBoxChangeProductYear.DisplayMember = "Name_Product";
            comboBoxChangeProductYear.ValueMember = "ID_Product";

            comboBoxChangeProducQuartal.DataSource = tb1;
            comboBoxChangeProducQuartal.DisplayMember = "Name_Product";
            comboBoxChangeProducQuartal.ValueMember = "ID_Product";

        }
        /// <summary>
        /// Кнопка, по нажатию на которую сменяется форма и создаётся график по году 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateSchedule_Click(object sender, EventArgs e)
        {
            if(comboBoxChangeProductYear.SelectedItem != null && textBoxYaer.Text != "")
            {
                command = new OleDbCommand();
                myConnection.Open();
                command.Connection = myConnection;
                command.CommandText = String.Format("SELECT * FROM Product_Sale WHERE Name = '{0}'", comboBoxChangeProductYear.SelectedItem);
                myConnection.Close();
                MessageBox.Show(command.ToString());





                //dataAdapter = new OleDbDataAdapter("SELECT * FROM Product_Sale WHERE" + comboBoxChangeProductYear.SelectedItem, connectionString);
                //command.Connection = myConnection;
                //command = new OleDbCommand("SELECT * FROM Product_Sale WHERE" + comboBoxChangeProductYear.SelectedItem);
                //DataTable tbs = new DataTable();
                //dataAdapter.Fill(tbs);
                //string s = command.ToString();
                //MessageBox.Show(s);
                Schedule schedule = new Schedule();
                schedule.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }
        }
        /// <summary>
        /// Кнопка, по нажатию на которую сменяется форма и создаётся график по кварталу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateScheduleQuartal_Click(object sender, EventArgs e)
        {

        }
    }
}
