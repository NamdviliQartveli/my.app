using First_page;

namespace WinFormsApp1
{
    public partial class First : Form
    {
        public static First instance;
        public First()
        {
            InitializeComponent();
            instance = this;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {

        }
    }
}