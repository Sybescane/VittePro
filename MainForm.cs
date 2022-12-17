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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Кадровая система";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void buttonFindDate_Click(object sender, EventArgs e)
        {
            AllListForm allListForm = new AllListForm();
            allListForm.Show();
        }

        private void buttonFindDateAndGroup_Click(object sender, EventArgs e)
        {
            DivisionListForm divisionListForm = new DivisionListForm();
            divisionListForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            selectList();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            selectList();
        }
        void selectList()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT name, surname, age, division, date_start, date_finish FROM employees ORDER BY division_number", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("База данных пуста!", "Уведомление");
            }
        }
    }
}
