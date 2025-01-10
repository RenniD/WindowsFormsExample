using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string username = textLogin.Text;
            string password = textPassword.Text;
            string confirmPassword = textPassword2.Text;
            string email = textEmail.Text;
            bool isTermsAccepted = checkBoxStart.Checked;


            string login_user = "dsadas";
            string password_user = "134";

            // перевірка паролів 
            if (password != confirmPassword)
            {
                labelErrorMessage.Text = "Паролі не співпадають";
                labelErrorMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
            // перевірка введення данних
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email))
            {
                labelErrorMessage.Text = "Всі поля повинні бути заповнені!";
                labelErrorMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
            // чи приймають умови
            if (!isTermsAccepted)
            {
                labelErrorMessage.Text = "Умови повинні бути прийняті!";
                labelErrorMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
            // всі перевірки успішні
            labelErrorMessage.Text = "Реєстація успішна!";
            labelErrorMessage.ForeColor = System.Drawing.Color.Green;


            // очищення полів 
            textLogin.Clear();
            textPassword.Clear();
            textPassword2.Clear();
            textEmail.Clear();

            checkBoxStart.Checked = false;

            System.Diagnostics.Process.Start("");

        }


    }
}
