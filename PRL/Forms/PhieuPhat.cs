using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class PhieuPhat : Form
    {
        string username, password , matra;

        public PhieuPhat(string username, string password , string matra)
        {
            InitializeComponent();
            this.matra = matra;
            this.username = username;
            this.password = password;
        }

        private void PhieuPhat_Load(object sender, EventArgs e)
        {

        }
    }
}
