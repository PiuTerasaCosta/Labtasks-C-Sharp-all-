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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            User user = new User();
            user. Fname = textBoxFirstName.Text;
            user. Lname = textBoxLastName.Text;
            user.DofB = dateofBirth.Text;
            user.grnd = gender.SelectedItem.ToString();
            user.email = textBoxEmail.Text;
            user.remail = textBoxRemail.Text;
            user.pass = textBoxPassword.Text;
            user.rpass = textBoxREPassword.Text;
            user.squs = comboBoxSecQus.SelectedItem.ToString();
            user.sans = textBoxSecAns.Text;
            user.address = textBoxAddress.Text;
            user.city = textBoxCity.Text;
            user.state = textBoxCity.Text;
            user.zcode = textBoxZipCode.Text;
            user.phone = textBoxPhone.Text;


           

            new Dashbord2(user).Show();
        }
    }
}
