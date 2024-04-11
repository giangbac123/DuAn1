
using DAL.Repository;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.Forms
{
    public partial class Phieumuon : Form
    {
        string username, pass;
        public Phieumuon(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            pass = mk;
        }
    }
}
