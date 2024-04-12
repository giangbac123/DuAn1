using DAL.Repository;
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
        private void LoadPhieuTra()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnCount = 7;
            int stt = 1;
            PhieuTraCTRepos phieuTraCTRepos = new PhieuTraCTRepos();
            var a = phieuTraCTRepos.GetAll();
            foreach(var x in a)
            {
                dataGridView2.Rows.Add(stt++,x.Matra,x.Masach,x.Soluong,x.Ngaytra,x.Ngaymuon);
            }
        }
    }
}
