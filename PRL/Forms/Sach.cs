
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRL.Forms
{
    public partial class Sach : Form
    {
        SachRepos _sach = new SachRepos();
        SachCTRepos _sachtc = new SachCTRepos();
        string username, pass;
        string masach;
        public Sach(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            lblid.Text = "";
            LoadCombobox();
            LoadData(_sach.GetAll());
            NgayXuatBan_Date.Format = DateTimePickerFormat.Custom;
            NgayXuatBan_Date.CustomFormat = "dd/MM/yyyy";
        }
        public void LoadData(dynamic data)
        {
            viewSach.Rows.Clear();
            viewSach.ColumnCount = 9;
            int stt = 1;
            viewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewSach.Columns[0].Name = "STT";
            viewSach.Columns[1].Name = "Mã sách";
            viewSach.Columns[2].Name = "Tên sách";
            viewSach.Columns[3].Name = "Số lượng";
            viewSach.Columns[4].Name = "Ngày xuất bản";
            viewSach.Columns[5].Name = "Số trang";
            viewSach.Columns[6].Name = "Giá bán";
            viewSach.Columns[7].Name = "Trạng thái";
            viewSach.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "",
                Text = "Xóa",
                UseColumnTextForButtonValue = true
            });
            foreach (var x in data)
            {
                viewSach.Rows.Add(stt++, x.Masach, x.Tensach, x.Soluong, x.Ngayxb, x.Sotrang, x.Giaban, x.Trangthai);
            }
        }
        public void LoadDataCT(dynamic data)
        {
            viewCT.Rows.Clear();
            viewCT.ColumnCount = 10;
            int stt = 1;
            viewCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewCT.Columns[0].Name = "STT";
            viewCT.Columns[1].Name = "Mã ID";
            viewCT.Columns[2].Name = "Mã sách"; viewCT.Columns[2].Visible = false;
            viewCT.Columns[3].Name = "Tên sách"; viewCT.Columns[3].Visible = false;
            viewCT.Columns[4].Name = "Mã tác giả"; viewCT.Columns[4].Visible = false;
            viewCT.Columns[5].Name = "Tên tác giả";
            viewCT.Columns[6].Name = "Mã thể loại"; viewCT.Columns[6].Visible = false;
            viewCT.Columns[7].Name = "Thể loại";
            viewCT.Columns[8].Name = "Mã nhà xuất bản"; viewCT.Columns[8].Visible = false;
            viewCT.Columns[9].Name = "Tên nhà xuất bản";
            viewCT.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "",
                Text = "Xóa",
                HeaderText = "Xóa",
                UseColumnTextForButtonValue = true
            });
            foreach (var x in data)
            {
                viewCT.Rows.Add(stt++, x.Masachct, x.Masach, x.Tensach, x.Matg, x.Tentg, x.Matl, x.Tentl, x.Manxb, x.Tennxb);
            }
        }
        public void ClearData()
        {
            TenSach_Texbox.Text = lblid.Text = txtid.Text = SoLuong_TexBox.Text = SoTrang_TexBox.Text = Giatxt.Text = TrangThai_Textbox.Text = "";
            NgayXuatBan_Date.Value = DateTime.Today;
            TacGia_ComboBox.SelectedIndex = TheLoai_ComboBox.SelectedIndex = NXB_ComboBox.SelectedIndex = -1;
            viewCT.Rows.Clear();
        }
        private void view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = viewSach.Rows[index];
            txtid.Text = selected.Cells[1].Value.ToString();
            TenSach_Texbox.Text = selected.Cells[2].Value.ToString();
            SoLuong_TexBox.Text = selected.Cells[3].Value.ToString();
            NgayXuatBan_Date.Value = (DateTime)selected.Cells[4].Value;
            SoTrang_TexBox.Text = selected.Cells[5].Value.ToString();
            Giatxt.Text = selected.Cells[6].Value.ToString();
            TrangThai_Textbox.Text = (string)selected.Cells[7].Value;
            LoadDataCT(_sachtc.Get(txtid.Text));

        }

        private void Them_Btn_Click(object sender, EventArgs e)
        {
            var a = _sach.Add(txtid.Text, new DAL.Models.Sach
            {
                Masach = txtid.Text,
                Tensach = TenSach_Texbox.Text,
                Soluong = int.Parse(SoLuong_TexBox.Text),
                Ngayxb = NgayXuatBan_Date.Value.Date,
                Sotrang = int.Parse(SoTrang_TexBox.Text),
                Trangthai = TrangThai_Textbox.Text,
                Giaban = decimal.Parse(Giatxt.Text)
            });
            if (a)
            {
                LoadData(_sach.GetAll());
                ClearData();
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Vui lòng kiểm tra lại mã sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sua_Btn_Click(object sender, EventArgs e)
        {
            var a = _sach.Update(txtid.Text, new DAL.Models.Sach
            {
                Tensach = TenSach_Texbox.Text,
                Soluong = int.Parse(SoLuong_TexBox.Text),
                Ngayxb = NgayXuatBan_Date.Value.Date,
                Sotrang = int.Parse(SoTrang_TexBox.Text),
                Trangthai = TrangThai_Textbox.Text,
                Giaban = decimal.Parse(Giatxt.Text)
            });
            if (a)
            {
                LoadData(_sach.GetAll());
                ClearData();
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Vui lòng kiểm tra lại mã sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (view.Columns[e.ColumnIndex].HeaderText == " Xóa" && e.RowIndex >= 0)
            {
                string maID = viewSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                var result = MessageBox.Show("Bạn có chắc muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var deleted = _sach.Delete(maID);
                    if (deleted)
                    {
                        LoadData(_sach.GetAll());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            var selected = viewCT.Rows[index];
            lblid.Text = selected.Cells[1].Value.ToString();
            TacGia_ComboBox.Text = selected.Cells[5].Value.ToString();
            TheLoai_ComboBox.Text = selected.Cells[7].Value.ToString();
            NXB_ComboBox.Text = selected.Cells[9].Value.ToString();
        }

        private void Sach_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == viewCT.Columns[""].Index && e.RowIndex >= 0)
            {
                int maID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                var result = MessageBox.Show("Bạn có chắc muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var deleted = _sachtc.Delete(maID);
                    if (deleted)
                    {
                        LoadData(_sach.GetAll());
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

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Thoat_Btn_Click(object sender, EventArgs e)
        {
            NguoidungRepos _ng = new NguoidungRepos();
            var a = _ng.GetAll().FirstOrDefault(x => (x.Email == username || x.Mand == username) && x.Matkhau == pass && x.Chucdanh == false);
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

        private void btnthemCT_Click(object sender, EventArgs e)
        {
            var a = _sachtc.Add(new DAL.Models.Sachct
            {
                Masach = txtid.Text,
                Matg = TacGia_ComboBox.SelectedValue.ToString(),
                Matl = TheLoai_ComboBox.SelectedValue.ToString(),
                Manxb = NXB_ComboBox.SelectedValue.ToString()
            });
            if (a)
            {
                LoadData(_sach.GetAll());
                ClearData();
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Mã ID đã bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            var a = _sachtc.Update(int.Parse(lblid.Text), new DAL.Models.Sachct
            {
                Matg = TacGia_ComboBox.SelectedValue.ToString(),
                Matl = TheLoai_ComboBox.SelectedValue.ToString(),
                Manxb = NXB_ComboBox.SelectedValue.ToString()
            });
            if (a)
            {
                LoadData(_sach.GetAll());
                ClearData();
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Sửa thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCombobox()
        {
            TacGiaRepos _tg = new TacGiaRepos();
            TacGia_ComboBox.DataSource = _tg.GetAll();
            TacGia_ComboBox.DisplayMember = "Tentg";
            TacGia_ComboBox.ValueMember = "Matg";
            TacGia_ComboBox.SelectedIndex = -1;
            TheLoaiRepos _tl = new TheLoaiRepos();
            TheLoai_ComboBox.DataSource = _tl.GetAllTheloai();
            TheLoai_ComboBox.DisplayMember = "Tentl";
            TheLoai_ComboBox.ValueMember = "Matl";
            TheLoai_ComboBox.SelectedIndex = -1;
            NhaxuatbanRepos _nxb = new NhaxuatbanRepos();
            NXB_ComboBox.DataSource = _nxb.GetAll();
            NXB_ComboBox.DisplayMember = "Tennxb";
            NXB_ComboBox.ValueMember = "Manxb";
            NXB_ComboBox.SelectedIndex = -1;
        }
        
        private void TimKiemTen_Texbox_TextChanged(object sender, EventArgs e)
        {
            if (TimKiemTen_Texbox.Text != "")
            {
                var a = _sach.GetBy(TimKiemTen_Texbox.Text);
                LoadData(a);
            }
            else
            {
                LoadDataCT(_sach.GetAll());
            }
        }
    }
}
