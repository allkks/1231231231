using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace app1
{
    public partial class Form1 : Form
    {
        // Строка подключения к базе данных
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\app1\\app1\\mdb.mdb";

        public Form1()
        {
            InitializeComponent();

            // Привязываем события кнопок
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
        }

        private void OpenTable(string tableName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Открываем соединение
                    OleDbCommand command = new OleDbCommand($"SELECT * FROM {tableName}", connection); // SQL-запрос
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); // Заполняем DataTable данными
                    dataGridView1.DataSource = dataTable; // Устанавливаем источник данных для DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message); // Обработка ошибок
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenTable("Выдача");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenTable("Книги");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenTable("Читатели");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenTable("1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenTable("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenTable("3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenTable("4");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ваш код обработки события здесь
        }
    }
}