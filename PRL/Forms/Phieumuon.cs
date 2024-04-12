
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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

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
            btnTK.Text = textBox1.Text = txtid.Text = txttenkh.Text = txtcccd.Text = txttrangthai.Text = "";
            txtsl.Text = txttien.Text = "0";
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
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

                                DialogResult canhbao = MessageBox.Show("Khách hàng khi mượn sách sẽ bị cửa hàng giữ lại thẻ CCCD công dân!\n Nếu đồng ý thì ấn 'OK' và tiếp tục thủ tục. Nếu không đồng ý thì ấn 'Cancel' thủ tục sẽ bị hủy ngay lập tức", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                if (canhbao == DialogResult.OK)
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
            ViewCT.Columns[1].Name = "ID"; ViewCT.Columns[1].Visible = false;
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
                    MessageBox.Show("Xoá thông tin thành công!", "Thônng báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;
            TimeSpan difference = endDate - startDate;
            int numberOfDays = (int)difference.TotalDays;
            if(numberOfDays > 0)
            {
                if(numberOfDays <= 30)
                {
                    if (int.TryParse(txtsl.Text, out int sl) && int.TryParse(txttien.Text, out int tien))
                    {
                        if (sl > 0)
                        {
                            if (_ct.GetByPhieumuonCT(txtid.Text) == null && _ct.GetByPhieumuonCT(txtid.Text).Count() == 0)
                            {
                                if (sl <= 5)
                                {
                                    if (MessageBox.Show("Khách hàng muốn mượn sách thì sẽ phải giao nộp căn cước công dân cho thu quầy và cửa hàng sẽ giữ đến khi khách hàng hoàn toàn tất cả đủ số lượng sách đã mượn!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                    {
                                        var a = _ct.AddHoaDonCT(new Phieumuonct
                                        {
                                            Mamuon = txtid.Text,
                                            Masach = txtsach.Text,
                                            Soluong = int.Parse(txtsl.Text),
                                            Ngaymuon = dateTimePicker1.Value.Date,
                                            Ngaytra = dateTimePicker2.Value.Date,
                                            Tienphi = tien
                                        });
                                        if (a)
                                        {
                                            var sach = _sach.GetAll().FirstOrDefault(x => x.Masach == txtsach.Text);
                                            var editsach = _sach.Update(txtsach.Text, new DAL.Models.Sach
                                            {
                                                Tensach = sach.Tensach,
                                                Soluong = sach.Soluong - sl,
                                                Ngayxb = sach.Ngayxb,
                                                Sotrang = sach.Sotrang,
                                                Giaban = sach.Giaban,
                                                Trangthai = sach.Trangthai
                                            });
                                            if (editsach)
                                            {
                                                LoadSach(_sach.GetAll());
                                                LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
                                                txtsach.Text = "";
                                                txtsl.Text = txttien.Text = "0";
                                                dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
                                                MessageBox.Show("Thêm thông tin thành công1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            }
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Bạn chỉ được mượn tổng tất cả tối đa 5 quyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                var tongmuon = _ct.GetByPhieumuonCT(txtid.Text).Sum(x => x.Soluong);
                                if (tongmuon <= 5 && sl <= 5 - tongmuon)
                                {
                                    var check = _ct.GetAll().FirstOrDefault(x => x.Mamuon == txtid.Text && x.Masach == txtsach.Text);
                                    if (check == null)
                                    {
                                        var a = _ct.AddHoaDonCT(new Phieumuonct
                                        {
                                            Mamuon = txtid.Text,
                                            Masach = txtsach.Text,
                                            Soluong = int.Parse(txtsl.Text),
                                            Ngaymuon = dateTimePicker1.Value.Date,
                                            Ngaytra = dateTimePicker2.Value.Date,
                                            Tienphi = tien
                                        });
                                        if (a)
                                        {
                                            var sach = _sach.GetAll().FirstOrDefault(x => x.Masach == txtsach.Text);
                                            var editsach = _sach.Update(txtsach.Text, new DAL.Models.Sach
                                            {
                                                Tensach = sach.Tensach,
                                                Soluong = sach.Soluong - sl,
                                                Ngayxb = sach.Ngayxb,
                                                Sotrang = sach.Sotrang,
                                                Giaban = sach.Giaban,
                                                Trangthai = sach.Trangthai
                                            });
                                            if (editsach)
                                            {
                                                LoadSach(_sach.GetAll());
                                                LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
                                                txtsach.Text = "";
                                                txtsl.Text = txttien.Text = "0";
                                                dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
                                                MessageBox.Show("Thêm thông tin thành công2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        var a = _ct.UpdateCT(check.Mamuonct, new Phieumuonct
                                        {
                                            Mamuon = txtid.Text,
                                            Masach = txtsach.Text,
                                            Soluong = check.Soluong + sl,
                                            Tienphi = check.Tienphi + tien,
                                            Ngaymuon = dateTimePicker1.Value.Date,
                                            Ngaytra = dateTimePicker2.Value.Date
                                        });
                                        if (a)
                                        {
                                            var sach = _sach.GetAll().FirstOrDefault(x => x.Masach == txtsach.Text);
                                            var editsach = _sach.Update(txtsach.Text, new DAL.Models.Sach
                                            {
                                                Tensach = sach.Tensach,
                                                Soluong = sach.Soluong - int.Parse(txtsl.Text),
                                                Ngayxb = sach.Ngayxb,
                                                Sotrang = sach.Sotrang,
                                                Giaban = sach.Giaban,
                                                Trangthai = sach.Trangthai
                                            });
                                            if (editsach)
                                            {
                                                LoadSach(_sach.GetAll());
                                                LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
                                                txtsach.Text = "";
                                                txtsl.Text = txttien.Text = "0";
                                                dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
                                                MessageBox.Show("Thêm thông tin thành công3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Bạn chỉ được mượn tổng tất cả tối đa 5 quyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số lượng là nguyên lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số lượng là dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Khách hàng chỉ được phép mượn không quá 30 ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ngày mượn nhỏ hơn hoặc bằng ngày trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtsl.Text);
            var idct = _ct.GetAll().FirstOrDefault(x => x.Mamuonct == id);
            if(idct!=null)
            {
                if(txtsach.Text == idct.Masach)
                {
                    var check = _ct.GetAll().FirstOrDefault(x => x.Mamuon == txtid.Text && x.Masach == txtsach.Text);
                    if(check!=null)
                    {
                        var update = _ct.UpdateCT(check.Mamuonct, new Phieumuonct
                        {
                            Masach = check.Masach,
                            Soluong = check.Soluong+sl,
                            Ngaymuon = check.Ngaymuon,
                            Ngaytra = check.Ngaytra,
                            Tienphi = check.Tienphi +int.Parse(txttien.Text)
                        });
                        if (update)
                        {
                            var sach1  = _sach.GetAll().FirstOrDefault(x=>x.Masach == check.Masach);
                            if(sach1!=null)
                            {
                                var updatesach1 = _sach.Update(sach1.Masach, new DAL.Models.Sach
                                {
                                    Tensach = sach1.Tensach,
                                    Soluong = sach1.Soluong - int.Parse(txtsl.Text),
                                    Ngayxb = sach1.Ngayxb,
                                    Sotrang = sach1.Sotrang,
                                    Giaban = sach1.Giaban,
                                    Trangthai = sach1.Trangthai
                                });
                                if (updatesach1)
                                {
                                    var sach2 = _sach.GetAll().FirstOrDefault(x => x.Masach == txtsach.Text);
                                    var updatesach2 = _sach.Update(sach1.Masach, new DAL.Models.Sach
                                    {
                                        Tensach = sach2.Tensach,
                                        Soluong = sach2.Soluong + check.Soluong,
                                        Ngayxb = sach2.Ngayxb,
                                        Sotrang = sach2.Sotrang,
                                        Giaban = sach2.Giaban,
                                        Trangthai = sach2.Trangthai
                                    });
                                    if(updatesach2)
                                    {
                                        LoadSach(_sach.GetAll());
                                        LoadHDCT(_ct.GetByPhieumuonCT(txtid.Text));
                                        txtsach.Text = "";
                                        txtsl.Text = txttien.Text = "0";
                                        _ct.DeleteCT(id);
                                        id -= id;
                                        dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
                                        MessageBox.Show("Sửa thông tin thành công3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu hóa đơn!","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if ((int.TryParse(txtsl.Text,out int sl)))
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
            else
            {
                txtsl.Text = "0";
                txttien.Text = "0";
            }
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            string text = txtsl.Text.Insert(txtsl.SelectionStart, e.KeyChar.ToString());
            int value;
            if (!int.TryParse(text, out value) || value < 0)
            {
                txtsl.Text = "0";
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                // Nếu không phải là chữ cái hoặc dấu cách, hủy bỏ ký tự nhập vào
                e.Handled = true;
            }
        }

        private void txtcccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtid.Text != "")
                {
                    HoaDonCho hoaDonCho = new HoaDonCho(username, pass, txtid.Text);
                    hoaDonCho.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieutra phieutra = new Phieutra(username, pass);
            phieutra.Show();
            this.Hide();
        }
    }
}
