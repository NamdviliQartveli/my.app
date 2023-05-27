using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace First_page
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void CompleteBtn_Click(object sender, EventArgs e)
        {
            if (PassBox.Text != RePassBox.Text)
            {
                this.Close();
            }
            else if (VerificationBox.Text == "D2EJFH)")
            {
                this.Close();

            }
            else {

                LogInPage logInPage = new LogInPage();
                logInPage.Show();

                LogInPage.instance.mailBox.Text = $"{MailBox.Text}";
                LogInPage.instance.passBox.Text = $"{PassBox.Text}";
                this.Close();
            }

        }
    }
}
