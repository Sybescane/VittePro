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
    public partial class UpdateForm : Form
    {
        int id;
        public UpdateForm()
        {
            InitializeComponent();
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

            if(table.Rows.Count > 0)
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Уверены, что хотите изменить данные сотрудника?", "Проверка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DB db = new DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT name, surname,age, division FROM employees WHERE id = @id", db.getConnection());

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if ((table.Rows[0][0].ToString() == textBoxName.Text) && (table.Rows[0][1].ToString() == textBoxSurname.Text) && (table.Rows[0][2].ToString() == textBoxAge.Text) && (table.Rows[0][3].ToString() == comboBoxDivision.Text))
                {
                    MessageBox.Show("Изменений не произошло", "Предупреждение");
                }
                else
                {
                    command = new SqlCommand("UPDATE employees SET name = @name, surname = @surname, age = @age, division = @division, division_number = dbo.getDivisionNumber(@division) WHERE id = @id", db.getConnection());
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBoxName.Text;
                    command.Parameters.Add("@surname", SqlDbType.VarChar).Value = textBoxSurname.Text;
                    command.Parameters.Add("@age", SqlDbType.Int).Value = textBoxAge.Text;
                    command.Parameters.Add("@division", SqlDbType.VarChar).Value = comboBoxDivision.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;


                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Данные о сотруднике обновлены", "Уведомление");
                    else
                        MessageBox.Show("Не удалось обновить данные сотрудника!", "Ошибка");

                    db.closedConnection();

                }
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
