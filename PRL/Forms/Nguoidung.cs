using DAL.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PRL.Forms
{
    public partial class Nguoidung : Form
    {
        NguoidungRepos _repos = new NguoidungRepos();
        string username, password;
        public Nguoidung(string tk, string mk)
        {
            password = mk;
            username = tk;
            InitializeComponent();
            LoadData(_repos.GetAll());
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 11;
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "ID";
            dataGridView1.Columns[2].Name = "Họ và tên";
            dataGridView1.Columns[3].Name = "Giới tính";
            dataGridView1.Columns[4].Name = "Địa chỉ";
            dataGridView1.Columns[5].Name = "Ngày sinh";
            dataGridView1.Columns[6].Name = "Số điện thoại";
            dataGridView1.Columns[7].Name = "Email";
            dataGridView1.Columns[8].Name = "CCCD";
            dataGridView1.Columns[9].Name = "Mật khẩu";
            dataGridView1.Columns[10].Name = "Chức danh";
            foreach (var x in data)
            {
                dataGridView1.Rows.Add(stt++, x.Mand, x.Hoten, x.Gioitinh ? "Nam" : "Nữ", x.Diachi, x.Ngaysinh, x.Sdt, x.Email, x.Cccd, x.Matkhau, x.Chucdanh ? "Admin" : "Nhân viên");
            }
        }
        private void button1_Click(object sender, EventArgs e)
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
            bool chucdanh;
            if (comboBox1.Text == "Admin")
            {
                chucdanh = true;
            }
            else
            {
                chucdanh = false;
            }
            var a = _repos.Add(textBox1.Text, textBox6.Text, new DAL.Models.Nguoidung
            {
                Mand = textBox1.Text,
                Hoten = textBox2.Text,
                Gioitinh = gt,
                Ngaysinh = dateTimePicker1.Value.Date,
                Diachi = textBox5.Text,
                Sdt = textBox6.Text,
                Email = textBox7.Text,
                Cccd = textBox8.Text,
                Matkhau = textBox9.Text,
                Chucdanh = chucdanh
            });
            var checksdt = _repos.GetAll().FirstOrDefault(x => x.Sdt == textBox6.Text);
            var checkCCCD = _repos.GetAll().FirstOrDefault(x => x.Cccd == textBox8.Text);

            if (checksdt != null)
            {
                if (checksdt != null)
                {
                    if (a)
                    {
                        ClearData();
                        LoadData(_repos.GetAll());
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã ID đã tồn tại! Vui lòng nhập lại mã Id", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đã có số điện thoại này! Vui lòng nhập số điện thoại khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã định danh! Vui lòng nhập lại mã định danh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearData()
        {
            textBox1.Text = textBox2.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox11.Text = "";
            radioButton1.Checked = radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            textBox1.Text = selected.Cells[1].Value.ToString();
            textBox2.Text = selected.Cells[2].Value.ToString();
            if (selected.Cells[3].Value.ToString() == "Nam")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            textBox5.Text = selected.Cells[4].Value.ToString();
            dateTimePicker1.Value = (DateTime)selected.Cells[5].Value;
            textBox6.Text = selected.Cells[6].Value.ToString();
            textBox7.Text = selected.Cells[7].Value.ToString();
            textBox8.Text = selected.Cells[8].Value.ToString();
            textBox9.Text = selected.Cells[9].Value.ToString();
            if (selected.Cells[10].Value.ToString() == "Admin")
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            bool chucdanh;
            if (comboBox1.Text == "Admin")
            {
                chucdanh = true;
            }
            else
            {
                chucdanh = false;
            }
            var a = _repos.Update(textBox1.Text, new DAL.Models.Nguoidung
            {
                Hoten = textBox2.Text,
                Gioitinh = gt,
                Ngaysinh = dateTimePicker1.Value.Date,
                Diachi = textBox5.Text,
                Sdt = textBox6.Text,
                Email = textBox7.Text,
                Cccd = textBox8.Text,
                Matkhau = textBox9.Text,
                Chucdanh = chucdanh
            });
            if (a)
            {
                ClearData();
                LoadData(_repos.GetAll());
                MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "1")
            {
                var a = _repos.Delete(textBox1.Text);
                if (a)
                {
                    ClearData();
                    LoadData(_repos.GetAll());
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa tài khoản này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                LoadData(_repos.GetAll());
            }
            else
            {
                var a = _repos.GetById(textBox1.Text);
                LoadData(a);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NguoidungRepos _ng = new NguoidungRepos();
            var a = _ng.GetAll().FirstOrDefault(x => (x.Mand == username || x.Email == username) && x.Matkhau == password && x.Chucdanh == false);
            if (a! == null)
            {
                GiaodienAdmin ad = new GiaodienAdmin(username, password);
                ad.Show();
                this.Hide();
            }
            else
            {
                GiaodienNV ad = new GiaodienNV(username, password);
                ad.Show();
                this.Hide();
            }
        }
    }
}
