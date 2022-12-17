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
    public partial class DeleteForm : Form
    {
        int id;
        public DeleteForm()
        {
            InitializeComponent();
            this.Text = "Увольнение сотрудника";
            textBoxId.Text = "Введите ID";
            textBoxName.ForeColor = Color.Gray;
        }

        private void textBoxId_Enter(object sender, EventArgs e)
        {
            if (textBoxId.Text == "Введите ID")
                textBoxId.Text = "";
            textBoxId.ForeColor = Color.Black;
        }

        private void textBoxId_Leave(object sender, EventArgs e)
        {
            string text = textBoxId.Text;
            if (textBoxId.Text == "")
            {
                textBoxId.ForeColor = Color.Gray;
                textBoxId.Text = "Введите ID";
            }
            else
            {
                try
                {
                    int.Parse(text);
                }
                catch
                {
                    MessageBox.Show("ID некоректный", "Ошибка!");
                    textBoxId.Text = "Введите ID";
                }
            }
        }

        private void buttonFindId_Click(object sender, EventArgs e)
        {
            id = int.Parse(textBoxId.Text);
            DB dB = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT name, surname, age, division FROM employees WHERE id = @id", dB.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                textBoxName.Text = table.Rows[0][0].ToString();
                textBoxSurname.Text = table.Rows[0][1].ToString();
                textBoxAge.Text = table.Rows[0][2].ToString();
                comboBoxDivision.Text = table.Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("Такой сотрудник не найден", "Ошибка");

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы уверены что хотите уволить сотрудника {textBoxName.Text}?", "Проверка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = int.Parse(textBoxId.Text);
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("UPDATE employees SET date_finish = GETDATE() WHERE id = @id", db.getConnection());

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Сотрудник уволен", "Уведомление");
                else
                    MessageBox.Show("Упс, что-то пошло не так!", "Ошибка");

                db.closedConnection();
            }
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
