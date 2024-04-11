
using DAL.Models;
using DAL.Repository;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.Forms
{
    public partial class Phieumuon : Form
    {
        string username, pass;
        SachRepos _sach = new SachRepos();
        PhieuMuonCTRepos _ct = new PhieuMuonCTRepos();
        PhieuMuonRepos _repos = new PhieuMuonRepos();
        int id = 0;
        public Phieumuon(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            pass = mk;
            LoadData(_repos.GetAllPhieumuon());
            LoadSach(_sach.GetAll());
        }
        private void LoadSach(dynamic data)
        {
            ViewSach.Rows.Clear();
            ViewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSach.ColumnCount = 5;
            ViewSach.Columns[0].Name = "STT";
            ViewSach.Columns[1].Name = "ID";
            ViewSach.Columns[2].Name = "Tên sách";
            ViewSach.Columns[3].Name = "Số lượng";
            ViewSach.Columns[4].Name = "Trạng thái";
            int stt = 1;
            foreach (var x in _sach.GetAll())
            {
                ViewSach.Rows.Add(stt++, x.Masach, x.Tensach, x.Soluong, x.Trangthai);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
        private string RandomID()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            DAL.Models.Phieumuon a;
            do
            {
                stringBuilder.Clear();
                for (int i = 0; i < 6; i++)
                {
                    int randomNumber = random.Next(0, 10);
                    stringBuilder.Append(randomNumber);
                }
                a = _repos.GetAllPhieumuon().FirstOrDefault(x => x.Mamuon == stringBuilder.ToString());
            } while (a != null);
            return "PT" + stringBuilder.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muộn tạo thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtcccd.Text == "" && txtid.Text == "" && txttenkh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtcccd.Text != "")
                    {
                        if (txtcccd.Text != "")
                        {
                            if (txtcccd.Text.Length == 12)
                            {
                                var a = _repos.AddHoaDon(new DAL.Models.Phieumuon
                                {
                                    Mamuon = RandomID(),
                                    Tenkh = txttenkh.Text,
                                    Cccd = txtcccd.Text,
                                    Trangthai = "Đang mượn"
                                });
                                if (a)
                                {
                                    LoadData(_repos.GetAllPhieumuon());
                                    MessageBox.Show("Tạo phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhập số thẻ CCCD không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số thẻ CCCD khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muộn tạo thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtcccd.Text == "" && txtid.Text == "" && txttenkh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtcccd.Text != "")
                    {
                        if (txtcccd.Text != "")
                        {
                            if (txtcccd.Text.Length == 12)
                            {
                                var a = _repos.UpdateHoaDon(txtid.Text, new DAL.Models.Phieumuon
                                {
                                    Mamuon = RandomID(),
                                    Tenkh = txttenkh.Text,
                                    Cccd = txtcccd.Text,
                                    Trangthai = txttrangthai.Text
                                });
                                if (a)
                                {
                                    MessageBox.Show("Sửa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng chọn phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhập số thẻ CCCD không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số thẻ CCCD khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LoadData(dynamic data)
        {
            ViewHD.Rows.Clear();
            ViewHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewHD.ColumnCount = 5;
            int stt = 1;
            ViewHD.Columns[0].Name = "STT";
            ViewHD.Columns[1].Name = "ID";
            ViewHD.Columns[2].Name = "Họ tên KH";
            ViewHD.Columns[3].Name = "Số thẻ CCCD";
            ViewHD.Columns[4].Name = "Trạng thái";
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Xóa";
            deleteButtonColumn.Text = "Xóa";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            ViewHD.Columns.Add(deleteButtonColumn);
            foreach (var x in data)
            {
                ViewHD.Rows.Add(stt++, x.Mamuon, x.Tenkh, x.Cccd, x.Trangthai);
            }
        }

        private void ViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = ViewHD.Rows[index];
            txtid.Text = selected.Cells[1].Value.ToString();
            txttenkh.Text = selected.Cells[2].Value.ToString();
            txtcccd.Text = selected.Cells[3].Value.ToString();
            txttrangthai.Text = selected.Cells[4].Value.ToString();
            LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
        }
        private void LoadHDCT(dynamic data)
        {
            ViewCT.Rows.Clear();
            ViewCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewCT.ColumnCount = 7;
            int stt = 1;
            ViewCT.Columns[0].Name = "STT";
            ViewCT.Columns[1].Name = "ID";
            ViewCT.Columns[2].Name = "Mã sách";
            ViewCT.Columns[3].Name = "Số lượng";
            ViewCT.Columns[4].Name = "Tiền phí";
            ViewCT.Columns[5].Name = "Ngày mượn";
            ViewCT.Columns[6].Name = "Ngày trả";
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Xóa";
            deleteButtonColumn.Text = "Xóa";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            ViewCT.Columns.Add(deleteButtonColumn);
            foreach (Phieumuonct x in data)
            {
                ViewCT.Rows.Add(stt++, x.Mamuonct, x.Masach, x.Soluong, x.Tienphi, x.Ngaymuon, x.Ngaytra);
            }
        }
        private void ViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ViewHD.Columns[5].Index)
            {
                DataGridViewRow selectedRow = ViewHD.Rows[e.RowIndex];
                string soPhieu = selectedRow.Cells[1].Value.ToString();
                var xoa = _repos.DeleteHoaDon(soPhieu);
                if (xoa)
                {
                    LoadData(_repos.GetAllPhieumuon());
                    ViewHD.Rows.Clear();
                    MessageBox.Show("Xoá thông tin thành công!", "Thoong báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    return;
                }
            }
        }

        private void ViewSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = ViewSach.Rows[index];
            txtsach.Text = selected.Cells[1].Value.ToString();
        }

        private void ViewCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selected = ViewCT.Rows[index];
            txtsach.Text = selected.Cells[2].Value.ToString();
            txtsl.Text = selected.Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)selected.Cells[5].Value;
            dateTimePicker1.Value = (DateTime)selected.Cells[6].Value;
            txttien.Text = selected.Cells[4].Value.ToString();
            id += int.Parse(selected.Cells[1].Value.ToString());
        }

        private void ViewCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ViewHD.Columns[7].Index)
            {
                DataGridViewRow selectedRow = ViewCT.Rows[e.RowIndex];
                string soPhieu = selectedRow.Cells[1].Value.ToString();
                var xoa = _repos.DeleteHoaDon(soPhieu);
                if (xoa)
                {
                    LoadData(_repos.GetAllPhieumuon());
                    ViewHD.Rows.Clear();
                    MessageBox.Show("Xoá thông tin thành công!", "Thoong báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    return;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muộn tạo thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtid.Text == "" && txtsach.Text == "" && txtsl.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtid.Text != "")
                    {
                        if (txtsach.Text != "")
                        {
                            if (txtsl.Text != "")
                            {
                                if (int.TryParse(txtsl.Text, out int soluong))
                                {
                                    if (soluong > 0)
                                    {
                                        if (dateTimePicker1.Value.Date <= dateTimePicker2.Value.Date)
                                        {
                                            var check = _ct.GetAll().FirstOrDefault(x => x.Mamuon == txtid.Text && x.Masach == txtsach.Text);
                                            if (check == null)
                                            {
                                                var add = _ct.AddHoaDonCT(new DAL.Models.Phieumuonct
                                                {
                                                    Mamuon = txtid.Text,
                                                    Masach = txtsach.Text,
                                                    Soluong = soluong,
                                                    Ngaymuon = dateTimePicker1.Value.Date,
                                                    Ngaytra = dateTimePicker2.Value.Date,
                                                    Tienphi = int.Parse(txttien.Text)
                                                });
                                                if (add)
                                                {
                                                    var masach = _sach.GetAll().FirstOrDefault(x => x.Masach == txtsach.Text);
                                                    var sach = _sach.Update(txtsach.Text, new DAL.Models.Sach
                                                    {
                                                        Tensach = masach.Tensach,
                                                        Soluong = masach.Soluong - soluong,
                                                        Ngayxb = masach.Ngayxb,
                                                        Sotrang = masach.Sotrang,
                                                        Giaban = masach.Giaban,
                                                        Trangthai = masach.Trangthai,
                                                    });

                                                    if (sach)
                                                    {
                                                        LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
                                                        id -= id;
                                                        MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                var add = _ct.UpdateCT(check.Mamuonct, new DAL.Models.Phieumuonct
                                                {
                                                    Mamuon = txtid.Text,
                                                    Masach = txtsach.Text,
                                                    Soluong = check.Soluong + soluong,
                                                    Ngaymuon = dateTimePicker1.Value.Date,
                                                    Ngaytra = dateTimePicker2.Value.Date,
                                                    Tienphi = int.Parse(txttien.Text)
                                                });
                                                if (add)
                                                {
                                                    var masach = _sach.GetAll().FirstOrDefault(x => x.Masach == txtsach.Text);
                                                    var sach = _sach.Update(txtsach.Text, new DAL.Models.Sach
                                                    {
                                                        Tensach = masach.Tensach,
                                                        Soluong = masach.Soluong - soluong,
                                                        Ngayxb = masach.Ngayxb,
                                                        Sotrang = masach.Sotrang,
                                                        Giaban = masach.Giaban,
                                                        Trangthai = masach.Trangthai,
                                                    });

                                                    if (sach)
                                                    {
                                                        LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
                                                        id -= id;
                                                        MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vui lòng nhập ngày mượn phải nhỏ hơn hoặc bằng ngày trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng nhập số lượng là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muộn tạo thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtid.Text == "" && txtsach.Text == "" && txtsl.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtid.Text != "")
                    {
                        if (txtsach.Text != "")
                        {
                            if (txtsl.Text != "")
                            {
                                if (int.TryParse(txtsl.Text, out int soluong))
                                {
                                    if (soluong > 0)
                                    {
                                        if (dateTimePicker1.Value.Date <= dateTimePicker2.Value.Date)
                                        {
                                            var check = _ct.GetAll().FirstOrDefault(x => x.Mamuon == txtid.Text && x.Masach == txtsach.Text);
                                            if (check == null)
                                            {
                                                var ct = _ct.GetAll().FirstOrDefault(x => x.Mamuonct == id);
                                                var a = _ct.UpdateCT(id, new DAL.Models.Phieumuonct
                                                {
                                                    Masach = txtsach.Text,
                                                    Soluong = soluong,
                                                    Ngaymuon = dateTimePicker1.Value.Date,
                                                    Ngaytra = dateTimePicker2.Value.Date,
                                                    Tienphi = int.Parse(txttien.Text)
                                                });
                                                if (a)
                                                {
                                                    var masach = _sach.GetAll().FirstOrDefault(x => x.Masach == txtsach.Text);
                                                    var sach = _sach.Update(txtsach.Text, new DAL.Models.Sach
                                                    {
                                                        Tensach = masach.Tensach,
                                                        Soluong = masach.Soluong - soluong,
                                                        Ngayxb = masach.Ngayxb,
                                                        Sotrang = masach.Sotrang,
                                                        Giaban = masach.Giaban,
                                                        Trangthai = masach.Trangthai,
                                                    });
                                                    if (sach)
                                                    {
                                                        var sach2 = _sach.Update(masach.Masach, new DAL.Models.Sach
                                                        {
                                                            Tensach = masach.Tensach,
                                                            Soluong = masach.Soluong + masach.Soluong - soluong,
                                                            Ngayxb = masach.Ngayxb,
                                                            Sotrang = masach.Sotrang,
                                                            Giaban = masach.Giaban,
                                                            Trangthai = masach.Trangthai,
                                                        });
                                                        if (sach2)
                                                        {
                                                            LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
                                                            MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vui lòng nhập ngày mượn phải nhỏ hơn hoặc bằng ngày trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng nhập số lượng là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTK_TextChanged(object sender, EventArgs e)
        {
            LoadHDCT(_ct.GetByPhieumuonCT(btnTK.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadSach(_sach.GetBy(textBox1.Text));
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateTimePicker1.Value.Date;
            DateTime ngayKetThuc = dateTimePicker2.Value.Date;
            TimeSpan khoangThoiGian = ngayKetThuc - ngayBatDau;
            int soNgay = khoangThoiGian.Days;
            if (txtsach.Text != "")
            {
                var ma = _sach.GetBy(txtsach.Text);
                foreach (var x in ma)
                {
                    int tiensach = (int)x.Giaban;
                    if (soNgay > 0 && soNgay <= 30)
                    {
                        if (ma != null)
                        {
                            if (tiensach > 0 && tiensach <= 50000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 1000 * soNgay}";
                            }
                            else if (tiensach > 50000 && tiensach <= 100000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 2000 * soNgay}";
                            }
                            else if (tiensach > 100000 && tiensach <= 500000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 5000 * soNgay}";
                            }
                            else if (tiensach > 500000 && tiensach <= 1000000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 10000 * soNgay}";
                            }
                            else if (tiensach > 1000000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 20000 * soNgay}";
                            }
                        }
                        else
                        {
                            txttien.Text = "0";
                        }
                    }
                    else if (soNgay == 0)
                    {
                        if (ma != null)
                        {

                            if (tiensach > 0 && tiensach <= 50000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 1000}";
                            }
                            else if (tiensach > 50000 && tiensach <= 100000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 2000}";
                            }
                            else if (tiensach > 100000 && tiensach <= 500000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 5000}";
                            }
                            else if (tiensach > 500000 && tiensach <= 1000000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 10000}";
                            }
                            else if (tiensach > 1000000)
                            {
                                txttien.Text = $"{int.Parse(txtsl.Text) * 20000}";
                            }
                        }
                        else
                        {
                            txttien.Text = "0";
                        }
                    }
                    else
                    {
                        txttien.Text = "0";
                    }
                }
                
            }
            else
            {
                txtsl.Text = "0";
                txttien.Text = "0";
            }
        }
    }
}
