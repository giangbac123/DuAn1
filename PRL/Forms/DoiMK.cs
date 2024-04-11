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
    public partial class DoiMK : Form
    {
        NguoidungRepos _repos = new NguoidungRepos();
        string username, pass;
        public DoiMK(string tk, string mk)
        {
            pass = mk;
            username = tk;
            InitializeComponent();
        }
        //aa
        private void btnChnage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đổi mật khẩu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (newpass.Text == nhaplaiPaxx.Text)
                {
                    var a = _repos.ChangePass(username, oldPass.Text, newpass.Text);
                    if (a)
                    {
                        pass = newpass.Text;
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var b = _repos.GetAll().FirstOrDefault(x => x.Mand == username && x.Chucdanh == false);
                        if (b != null)
                        {
                            GiaodienAdmin gd = new GiaodienAdmin(username, pass);
                            gd.Show();
                            this.Hide();
                        }
                        else
                        {
                            GiaodienNV gd = new GiaodienNV(username, pass);
                            gd.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu mới không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
