using Microsoft.VisualBasic.Logging;
using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_page
{
    public partial class LogInPage : Form
    {
        public static LogInPage instance;
        public TextBox mailBox;
        public TextBox passBox;

        public LogInPage()
        {
            InitializeComponent();
            instance = this;
            mailBox = MailBox;
            passBox = PassBox;
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();

            this.Close();
        }
    }
}
