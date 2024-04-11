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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.Forms
{
    public partial class Nhaxuatban : Form
    {
        string username, pass;
        NhaxuatbanRepos _repos = new NhaxuatbanRepos();
        public Nhaxuatban(string username, string mk)
        {
            InitializeComponent();
            LoadData(_repos.GetAll());
            this.username = username;
            pass = mk;
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã ID";
            dataGridView1.Columns[2].Name = "Nhà xuất bản";
            dataGridView1.Columns[3].Name = "Địa chỉ";
            dataGridView1.Columns[4].Name = "Số điện thoại";
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "",
                Text = "Xóa",
                UseColumnTextForButtonValue = true
            });
            foreach (var x in data)
            {
                var index = dataGridView1.Rows.Add(stt++, x.Manxb, x.Tennxb, x.Diachi, x.Sdt);

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            txtid.Text = selected.Cells[1].Value.ToString();
            txtname.Text = selected.Cells[2].Value.ToString();
            txtdc.Text = selected.Cells[3].Value.ToString();
            txtsdt.Text = selected.Cells[4].Value.ToString();
        }
        public void ClearData()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >= 0)
            {
                string maID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var result = MessageBox.Show("Bạn có chắc muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var deleted = _repos.Delete(maID);
                    if (deleted)
                    {
                        LoadData(_repos.GetAll());
                        ClearData();
                        MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thêm thông tin này?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var deleted = _repos.Add(txtid.Text, new DAL.Models.Nhaxuatban
                {
                    Manxb = txtid.Text,
                    Tennxb = txtname.Text,
                    Diachi = txtdc.Text,
                    Sdt = txtsdt.Text
                });
                if (deleted)
                {
                    LoadData(_repos.GetAll());
                    ClearData();
                    MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ID bị trùng! Vui lòng nhập ID khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn sửa thông tin này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var deleted = _repos.Update(txtid.Text, new DAL.Models.Nhaxuatban
                {
                    Tennxb = txtname.Text,
                    Diachi = txtdc.Text,
                    Sdt = txtsdt.Text
                });
                if (deleted)
                {
                    LoadData(_repos.GetAll());
                    ClearData();
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
var a = _repos.GetSearch(textBox5.Text);
            LoadData(a);
            }
            else
            {
                LoadData(_repos.GetAll());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NguoidungRepos _ng = new NguoidungRepos();
            var a = _ng.GetAll().FirstOrDefault(x => x.Mand == username && x.Chucdanh == false);
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
