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
    public partial class HoaDonCho : Form
    {
        string username; string password; string maphieu;
        PhieuMuonRepos _repos = new PhieuMuonRepos();
        PhieuMuonCTRepos _ct = new PhieuMuonCTRepos();
        NguoidungRepos ng = new NguoidungRepos();
        public HoaDonCho(string username, string password, string maphieu)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.maphieu = maphieu;
            lbltime.Text = (DateTime.Now).ToString();
            var a = _repos.GetAllPhieumuon().FirstOrDefault(x => x.Mamuon == maphieu);
            if (a != null)
            {
                lblid.Text = a.Mamuon.ToString();
                lblkh.Text = a.Tenkh.ToString();
            }
            else
            {
                lblid.Text = lblkh.Text = "";
            }
            var b = ng.GetAll().FirstOrDefault(x => x.Mand == username || x.Email == username);
            if (b != null)
            {
                lblnv.Text = b.Hoten.ToString();
            }
            else
            {
                lblnv.Text = "";
            }
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 6;
            int stt = 1;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã sách";
            dataGridView1.Columns[2].Name = "Số lượng";
            dataGridView1.Columns[3].Name = "Tiền phí";
            dataGridView1.Columns[4].Name = "Ngày mượn";
            dataGridView1.Columns[5].Name = "Ngày trả";
            foreach (var x in _ct.GetByPhieumuonCT(maphieu))
            {
                dataGridView1.Rows.Add(stt++, x.Masach, x.Soluong, x.Tienphi, x.Ngaymuon, x.Ngaytra);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaQR ma = new MaQR(username, password,maphieu);
            ma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phieumuon phieumuon = new Phieumuon(username, password);
            phieumuon.Show();
            this.Hide();
        }
    }
}
