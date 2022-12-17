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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            textBoxName.ForeColor = Color.Gray;
            textBoxSurname.ForeColor = Color.Gray;
            textBoxAge.ForeColor = Color.Gray;
            comboBoxDivision.ForeColor = Color.Gray;
            this.Text = "Добавление сотрудника";
            textBoxName.Text = "Введите имя";
            textBoxSurname.Text = "Введите фамилию";
            textBoxAge.Text = "Введите возраст";
            comboBoxDivision.Text = "Введите подразделение";
            
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Введите имя")
                textBoxName.Text = "";
            textBoxName.ForeColor = Color.Black;
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.ForeColor = Color.Gray;
                textBoxName.Text = "Введите имя";
            }
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "Введите фамилию")
                textBoxSurname.Text = "";
            textBoxSurname.ForeColor= Color.Black;
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                textBoxSurname.ForeColor= Color.Gray;
                textBoxSurname.Text = "Введите фамилию";
            }
        }

        private void textBoxAge_Enter(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "Введите возраст")
                textBoxAge.Text = "";
            textBoxAge.ForeColor = Color.Black;
        }

        private void textBoxAge_Leave(object sender, EventArgs e)
        {
            string text = textBoxAge.Text;
            if (textBoxAge.Text == "")
            {
                textBoxAge.ForeColor = Color.Gray;
                textBoxAge.Text = "Введите возраст";
            }
            else
            {
                try
                {
                    int.Parse(text);
                }
                catch
                {
                    MessageBox.Show("Возраст некоректный", "Ошибка!");
                    textBoxAge.Text = "Введите возраст";
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

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {            
            DB db = new DB();
            SqlCommand command = new SqlCommand("insert into employees(name, surname, age, division, division_number, date_start) values(@name, @surname, @age, @division, dbo.getDivisionNumber(@division), GETDATE());", db.getConnection());

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@surname", SqlDbType.VarChar).Value = textBoxSurname.Text;
            command.Parameters.Add("@age", SqlDbType.Int).Value = textBoxAge.Text;
            command.Parameters.Add("@division", SqlDbType.VarChar).Value = comboBoxDivision.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Сотрудник добавлен.", "Уведомление");
            else
                MessageBox.Show("Не удалось добавить сотрудника!", "Ошибка");

            db.closedConnection();
        }
    }
}
