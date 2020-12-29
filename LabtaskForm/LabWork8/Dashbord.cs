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
    public partial class Dashbord : Form
    {
        private void AppearDashbord2(object sender, EventArgs e)
        {
            new Form1().Show();
        }
        public Dashbord(User user)
        {
            InitializeComponent();
            string Output = String.Format("First Name : {0}" +
              "\nLast User Name : {1}" +
              "\nUser Password : {2}", user.UserName, user.Password);
        }

      
    }
}
