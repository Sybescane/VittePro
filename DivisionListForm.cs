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
    public partial class DivisionListForm : Form
    {
        public DivisionListForm()
        {
            InitializeComponent();
        }

        private void buttonFindId_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DateTime start = dateTimePicker1.Value;
            DateTime finish = dateTimePicker2.Value;

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT name, surname, age, division, date_start, date_finish FROM employees WHERE (date_finish >= @datastart OR date_finish IS NULL) AND date_start <= @datafinish AND division_number >= dbo.getDivisionNumber(@division) ORDER BY division_number", db.getConnection());
            command.Parameters.Add("@datastart", SqlDbType.Date).Value = start;
            command.Parameters.Add("@datafinish", SqlDbType.Date).Value = finish;
            command.Parameters.Add("@division", SqlDbType.VarChar).Value = comboBoxDivision.Text;

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

        private void comboBoxDivision_Enter(object sender, EventArgs e)
        {
            if (comboBoxDivision.Text == "Введите подразделение")
                comboBoxDivision.Text = "";
            comboBoxDivision.ForeColor = Color.Black;
        }

        private void comboBoxDivision_Leave(object sender, EventArgs e)
        {
            if (comboBoxDivision.Text == "")
            {
                comboBoxDivision.ForeColor = Color.Gray;
                comboBoxDivision.Text = "Введите подразделение";
            }
            else
            {
                List<string> list = new List<string>();
                foreach (var i in comboBoxDivision.Items)
                    list.Add(i.ToString());
                if (!comboBoxDivision.Items.Contains(comboBoxDivision.Text))
                    MessageBox.Show("Такого подразделения нет", "Ошибка!");
            }
        }
    }
}
