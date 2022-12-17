using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VittePro1
{
    public partial class AllListForm : Form
    {
        public AllListForm()
        {
            InitializeComponent();
            this.Text = "Поиск по датам";
        }

        private void buttonFindId_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DateTime start = dateTimePicker1.Value;
            DateTime finish = dateTimePicker2.Value;

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT name, surname, age, division, date_start, date_finish FROM employees WHERE (date_finish >= @datastart OR date_finish IS NULL) AND date_start <= @datafinish ORDER BY division_number", db.getConnection());
            command.Parameters.Add("@datastart", SqlDbType.Date).Value = start;
            command.Parameters.Add("@datafinish", SqlDbType.Date).Value = finish;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = table;
            }
            else
                MessageBox.Show("Сотрудники не найдены", "Уведомление");
        }
    }
}
