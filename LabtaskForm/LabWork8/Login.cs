using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ApperDashbord(object sender, EventArgs e)
        {
            new Dashbord().Show();
        }

        private void Authencate(object sender, EventArgs e)
        {
            string name = "";
            string password = "";
            string errMeg = "";
            bool hasError = false;
            if (textBoxUserName.Text.Equals(""))
            {
                errMeg += "Username Required\n";
                hasError = true;
            }
            else
            {
                name = textBoxUserName.Text;
            }

            if (textBoxPassword.Text.Equals(""))
            {
                errMeg += "Password Required\n";
                hasError = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }

            if (!hasError)
            {
                if (name.Equals("19-39998-1") && password.Equals("Nahid"))
                {
                    User u1 = new User();

                    u1.UserName = name;
                    u1.Password = password;
                    new Dashbord(u1).Show();
                }
                else
                {
                    MessageBox.Show("Invalid User or Password");
                }
            }
            else
            {
                MessageBox.Show(errMeg);
            }
        }
    }
}
