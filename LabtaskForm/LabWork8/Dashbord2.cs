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
    public partial class Dashbord2 : Form
    {
        
        public Dashbord2(User user)
        {
            InitializeComponent();

            string Output = String.Format("First Name : {0}" +
              "\nLast Name : {1}" +
              "\nDate of Birth : {2}" +
              "\nGender : {3}" +
              "\nEmail :{4}" +
              "\nRepete Email : {5}" +
              "\nPassword : {6}" +
              "\nRepet Password : {7}" +
              "\nSecurity Question : {8}" +
              "\nSecurity Answer : {9}" +
              "\nAddress : {10}" +
              "\nCity : {11}" +
              "\nState : {12}" +
              "\nZip Code : {13}" +
              "\nPhone :{14}", user.Fname, user.Lname, user.DofB, user.grnd, user.email, user.remail, user.pass, user.rpass, user.squs, user.sans, user.address, user.city, user.state, user.zcode, user.phone);
            rTOutput.Text = Output;

        }
    }
}
