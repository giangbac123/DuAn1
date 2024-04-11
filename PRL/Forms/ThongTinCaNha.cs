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
    public partial class ThongTinCaNha : Form
    {
        string username; string pass;
        NguoidungRepos _repos = new NguoidungRepos();
        public ThongTinCaNha(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
            LoadData();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

        }
        private void LoadData()
        {
            var a = _repos.GetAll().FirstOrDefault(x => (x.Email == username || x.Mand == username) && x.Matkhau == pass);
            txtid.Text = a.Mand;
            txtname.Text = a.Hoten;
            if (a.Gioitinh == true)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            txtDC.Text = a.Diachi;
            dateTimePicker1.Value = a.Ngaysinh;
            txtsdt.Text = a.Sdt;
            txtemail.Text = a.Email;
            txtcccd.Text = a.Cccd;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin cá nhân hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool gt;
                if (radioButton1.Checked)
                {
                    gt = true;
                }
                else
                {
                    gt = false;
                }
                var a = _repos.Update(txtid.Text, new DAL.Models.Nguoidung
                {
                    Hoten = txtname.Text,
                    Gioitinh = gt,
                    Diachi = txtDC.Text,
                    Ngaysinh = dateTimePicker1.Value.Date,
                    Sdt = txtsdt.Text,
                    Email = txtemail.Text,
                    Cccd = txtcccd.Text
                });
                if (a)
                {
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NguoidungRepos _ng = new NguoidungRepos();
            var a = _ng.GetAll().FirstOrDefault(x => (x.Mand == username || x.Email == username) && x.Matkhau == pass && x.Chucdanh == false);
            if (a! == null)
            {
                GiaodienAdmin ad = new GiaodienAdmin(username, pass);
                ad.Show();
                this.Hide();
            }
            else
            {
                GiaodienNV ad = new GiaodienNV(username, pass);
                ad.Show();
                this.Hide();
            }
        }
    }
}
