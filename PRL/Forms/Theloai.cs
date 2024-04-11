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

namespace PRL.Forms
{
    public partial class Theloai : Form
    {
        TheLoaiRepos _repos = new TheLoaiRepos();
        
        string username, pass;
        public Theloai(string tk, string mk)
        {
            InitializeComponent();
            LoadData(_repos.GetAllTheloai());
            username = tk;
            pass = mk;
        }
        public void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã ID";
            dataGridView1.Columns[2].Name = "Thể loại";
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "",
                Text = "Xóa",
                UseColumnTextForButtonValue = true
            });
            foreach (var x in data)
            {
                var index = dataGridView1.Rows.Add(stt++, x.Matl, x.Tentl);

            }
        }

        public void ClearData()
        {
            textBox1.Text = textBox2.Text = ""; textBox3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var a = _repos.Add(textBox1.Text, new DAL.Models.Theloai
            {
                Matl = textBox1.Text,
                Tentl = textBox2.Text
            });
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (a)
                {
                    LoadData(_repos.GetAllTheloai());
                    ClearData();
                    MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã ID đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = dataGridView1.Rows[index];
            textBox1.Text = selected.Cells[1].Value.ToString();
            textBox2.Text = selected.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = _repos.Update(textBox1.Text, new DAL.Models.Theloai
            {
                Tentl = textBox2.Text
            });
            DialogResult result = MessageBox.Show($"Bạn có muốn sửa thông tin tác giả này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    if (a)
                    {
                        LoadData(_repos.GetAllTheloai());
                        ClearData();
                        MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var a = _repos.GetSearch(textBox3.Text);
            LoadData(a);
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
                        LoadData(_repos.GetAllTheloai());
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

        private void button4_Click(object sender, EventArgs e)
        {
            NguoidungRepos _ng = new NguoidungRepos();
            var a = _ng.GetAll().FirstOrDefault(x => x.Mand == username && x.Chucdanh == false);
            if(a! == null)
            {
                GiaodienAdmin ad = new GiaodienAdmin(username,pass);
                ad.Show();
                this.Hide();
            }
            else
            {
                GiaodienNV ad = new GiaodienNV(username,pass);
                ad.Show();
                this.Hide();
            }
        }
    }
}
