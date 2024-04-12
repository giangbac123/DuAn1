using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class GiaodienNV
        : Form
    {
        NguoidungRepos _repo = new NguoidungRepos();

        string username;
        string pass;
        public GiaodienNV(string tk, string mk)
        {
            InitializeComponent();
            username = tk;
            pass = mk;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoiMK doimk = new DoiMK(username, pass);
            doimk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sach s = new Sach(username, pass);
            s.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tacgia t = new Tacgia(username, pass);
            t.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Phieumuon a = new Phieumuon(username, pass);
            a.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Theloai t = new Theloai(username, pass);
            t.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Phieutra a = new Phieutra(username, pass);
            a.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Nhaxuatban a = new Nhaxuatban(username, pass);
            a.Show(); this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinCaNha thongTinCaNha = new ThongTinCaNha(username, pass);
            thongTinCaNha.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ThongKe thongke = new ThongKe(username, pass);
            thongke.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }
    }
}

