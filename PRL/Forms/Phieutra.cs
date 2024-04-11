
using DAL.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.Forms
{
    public partial class Phieutra : Form
    {
        string username, pass;
        public Phieutra(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            pass = mk;
        }

        private void Phieutra_Load(object sender, EventArgs e)
        {

        }

    }
}
