using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace app2
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\app2\app2\mdb.mdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загружаем данные в таблицу "Выдача"
            this.выдачаTableAdapter.Fill(this.mdbDataSet.Выдача);
        }
    }
}