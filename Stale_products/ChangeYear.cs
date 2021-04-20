using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Stale_products
{
    public partial class ChangeYear : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TV.mdb;"; //Строка подключения к бд
        public static string query = "SELECT * FROM Product ORDER BY ID_Product"; //Строка запроса

        // Объявление объектов
        private OleDbDataAdapter dataAdapter;
        private DataTable tb1;
        private DataTable tb2;
        private Schedule schedule;
        private OleDbConnection connection;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public ChangeYear()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionString);
        }

        /// <summary>
        /// Инициализация comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangYear_Load(object sender, EventArgs e)
        {
            dataAdapter = new OleDbDataAdapter(query, connectionString);
            tb1 = new DataTable();
            dataAdapter.Fill(tb1);
            //Заполнение comboBox данными из базы данных 
            comboBoxChangeProductYear.DataSource = tb1;
            comboBoxChangeProductYear.DisplayMember = "Name_Product";
            comboBoxChangeProductYear.ValueMember = "ID_Product";

            //Заполнение comboBox данными из базы данных 
            comboBoxChangeProducQuartal.DataSource = tb1;
            comboBoxChangeProducQuartal.DisplayMember = "Name_Product";
            comboBoxChangeProducQuartal.ValueMember = "ID_Product";

            //Заполнение comboBox данными из базы данных 
            comboBoxYear.DataSource = tb1;
            comboBoxYear.DisplayMember = "Date";
            comboBoxYear.ValueMember = "ID_Product";



            comboBoxQuartal.DataSource = tb1;
            comboBoxQuartal.DisplayMember = "Quartal";
            comboBoxQuartal.ValueMember = "ID_Product";

        }

        /// <summary>
        /// Кнопка, по нажатию на которую сменяется форма и создаётся график по году 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateSchedule_Click(object sender, EventArgs e)
        {
            //Условная конструкция, проверяющая заполнение полей
            if(comboBoxChangeProductYear.SelectedItem != null && comboBoxYear.SelectedItem != null)
            {
                Data.modelProduct = comboBoxChangeProductYear.Text;
                schedule = new Schedule();
                schedule.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполните необходимые поля!");
            }
        }

        /// <summary>
        /// Кнопка, по нажатию на которую сменяется форма и создаётся график по кварталу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateScheduleQuartal_Click(object sender, EventArgs e)
        {
            //Условная конструкция, проверяющая заполнение полей
            if (comboBoxChangeProducQuartal.SelectedItem != null && comboBoxYear.SelectedItem != null)
            {
                Data.modelProduct = comboBoxChangeProducQuartal.Text;
                schedule = new Schedule();
                schedule.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполните необходимые поля!");
            }
        }
    }
}
