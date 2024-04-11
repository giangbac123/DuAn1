using DAL.Models;
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
    public partial class GiaodienAdmin : Form
    {
        NguoidungRepos _repo = new NguoidungRepos();

        string username;
        string pass;
        public GiaodienAdmin(string tk, string mk)
        {
            pass = tk;
            username = mk;
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nguoidung ng = new Nguoidung(username, pass);
            ng.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoiMK mk = new DoiMK(username, pass);
            mk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Theloai tl = new Theloai(username, pass);
            tl.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Nhaxuatban nxb = new Nhaxuatban(username, pass);
            nxb.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tacgia nxb = new Tacgia(username, pass);
            nxb.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Phieumuon nxb = new Phieumuon(username, pass);
            nxb.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Phieutra nxb = new Phieutra(username, pass);
            nxb.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sach nxb = new Sach(username, pass);
            nxb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinCaNha thongTinCaNha = new ThongTinCaNha(username, pass);
            thongTinCaNha.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }
    }
}

