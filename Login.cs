namespace VittePro1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Кадровая Система";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}