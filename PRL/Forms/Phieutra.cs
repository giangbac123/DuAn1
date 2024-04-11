
using DAL.Models;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace PRL.Forms
{
    public partial class Phieutra : Form
    {
        string username, pass;
        PhieuTraRepos _repos = new PhieuTraRepos();
        PhieuTraCTRepos _ct = new PhieuTraCTRepos();
        SachRepos _sach = new SachRepos();
        PhieuMuonRepos _muon = new PhieuMuonRepos();
        PhieuMuonCTRepos _muonct = new PhieuMuonCTRepos();
        int stt = 1;
        int idCT = 0;
        public Phieutra(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            pass = mk;
        }

        private void Phieutra_Load(object sender, EventArgs e)
        {
            LoadSach(_sach.GetAll());
            LoadData(_repos.GetAllPhieutra());
        }
        private void LoadSach(dynamic data)
        {
            SachView.Rows.Clear();
            SachView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SachView.ColumnCount = 5;
            SachView.Columns[0].Name = "STT";
            SachView.Columns[1].Name = "ID";
            SachView.Columns[2].Name = "Tên sách";
            SachView.Columns[3].Name = "Số lượng";
            SachView.Columns[4].Name = "Trạng thái";
            int stt = 1;
            foreach (var x in data)
            {
                SachView.Rows.Add(stt++, x.Masach, x.Tensach, x.Soluong, x.Trangthai);
            }
        }

        private void btnTK_TextChanged(object sender, EventArgs e)
        {
            LoadSach(_sach.GetBy(btnTK.Text));
        }

        private void SachView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = SachView.Rows[e.RowIndex];
            txtsach.Text = selected.Cells[1].Value.ToString();
        }
        private void LoadData(dynamic data)
        {
            HDtraView.Rows.Clear();
            HDtraView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HDtraView.ColumnCount = 4;
            HDtraView.Columns[0].Name = "STT";
            HDtraView.Columns[1].Name = "Số phiếu";
            HDtraView.Columns[2].Name = "Họ tên khách hàng";
            HDtraView.Columns[3].Name = "Số thẻ CCCD";
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Xóa";
            deleteButtonColumn.Text = "Xóa";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            HDtraView.Columns.Add(deleteButtonColumn);
            int stt = 1;
            foreach (var x in data)
            {
                HDtraView.Rows.Add(stt++, x.Matra, x.Tenkh, x.Cccd);
            }
        }

        private void HDtraView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = HDtraView.Rows[e.RowIndex];
            txtid.Text = selected.Cells[1].Value.ToString();
            txttenkh.Text = selected.Cells[2].Value.ToString();
            txtcccd.Text = selected.Cells[3].Value.ToString();
            LoadDataCT(_ct.GetByPhieutraCT(txtid.Text));
        }

        private void HDtraView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == HDtraView.Columns[5].Index)
            {
                DataGridViewRow selectedRow = HDtraView.Rows[e.RowIndex];
                string soPhieu = selectedRow.Cells[1].Value.ToString();
                var xoa = _repos.DeleteHoaDon(soPhieu);
                if (xoa)
                {
                    LoadData(_repos.GetAllPhieutra());
                    HDtraCTview.Rows.Clear();
                    MessageBox.Show("Xoá thông tin thành công!", "Thoong báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    return;
                }
            }
        }
        private void LoadDataCT(dynamic data)
        {
            HDtraCTview.Rows.Clear();
            HDtraCTview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HDtraCTview.ColumnCount = 7;
            HDtraCTview.Columns[0].Name = "STT";
            HDtraCTview.Columns[1].Name = "Số phiếu"; HDtraCTview.Columns[1].Visible = false;
            HDtraCTview.Columns[2].Name = "Mã sách";
            HDtraCTview.Columns[3].Name = "Số lượng";
            HDtraCTview.Columns[4].Name = "Ngày mượn";
            HDtraCTview.Columns[5].Name = "Ngày trả";
            HDtraCTview.Columns[6].Name = "Trạng thái";
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Xóa";
            deleteButtonColumn.Text = "Xóa";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            HDtraCTview.Columns.Add(deleteButtonColumn);
            int stt = 1;
            foreach (var x in data)
            {
                HDtraCTview.Rows.Add(stt++,x.Matract, x.Masach, x.Soluong, x.Ngaymuon, x.Ngaytra, x.Trangthai);
            }
        }
        private void HDtraCTview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = HDtraCTview.Rows[e.RowIndex];
            idCT += int.Parse(selected.Cells[1].Value.ToString());
            txtsach.Text = selected.Cells[2].Value.ToString();
            txtsl.Text = selected.Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)selected.Cells[4].Value;
            dateTimePicker2.Value = (DateTime)selected.Cells[5].Value;
            txttrangthai.Text = selected.Cells[6].Value.ToString();
        }

        private void HDtraCTview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == HDtraCTview.Columns[7].Index)
            {
                DataGridViewRow selectedRow = HDtraCTview.Rows[e.RowIndex];
                int soPhieu = int.Parse(selectedRow.Cells[1].Value.ToString());
                var xoa = _ct.DeleteCT(soPhieu);
                if (xoa)
                {
                    LoadData(_ct.GetByPhieutraCT(txtid.Text));
                    LoadData(_repos.GetAllPhieutra());
                    HDtraCTview.Rows.Clear();
                    idCT = 0;
                    MessageBox.Show("Xoá thông tin thành công!", "Thoong báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    idCT = 0;
                    return;
                }
            }
        }

        private string RandomID()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            DAL.Models.Phieutra a;
            do
            {
                stringBuilder.Clear();
                for (int i = 0; i < 6; i++)
                {
                    int randomNumber = random.Next(0, 10);
                    stringBuilder.Append(randomNumber);
                }
                a = _repos.GetAllPhieutra().FirstOrDefault(x => x.Matra == stringBuilder.ToString());
            } while (a != null);
            return "PT" + stringBuilder.ToString();

        }
        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
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

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtcccd.Text == "" && txttenkh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txttenkh.Text != "")
                {
                    if (txtcccd.Text != "")
                    {
                        if (txtcccd.Text.Length == 12)
                        {
                            var thongtin = _muon.GetAllPhieumuon().Where(x => x.Tenkh == txttenkh.Text && x.Cccd == txtcccd.Text);
                            if (thongtin != null)
                            {
                                var a = _repos.AddHoaDon(new DAL.Models.Phieutra
                                {
                                    Matra = RandomID(),
                                    Tenkh = txttenkh.Text,
                                    Cccd = txtcccd.Text
                                });
                                if (a)
                                {
                                    MessageBox.Show("Tạo thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin của khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập số thẻ CCCD không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số thẻ CCCD của khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtcccd.Text == "" && txttenkh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txttenkh.Text != "")
                {
                    if (txtcccd.Text != "")
                    {
                        var thongtin = _muon.GetAllPhieumuon().Where(x => x.Tenkh == txttenkh.Text && x.Cccd == txtcccd.Text);
                        if (thongtin != null)
                        {
                            var a = _repos.UpdateHoaDon(txtid.Text, new DAL.Models.Phieutra
                            {
                                Tenkh = txttenkh.Text,
                                Cccd = txtcccd.Text
                            });
                            if (a)
                            {
                                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng chọn hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin của khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtid.Text == "" && txtsach.Text == "" && txtsl.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtid.Text != "")
                {
                    if (txtsach.Text != "")
                    {
                        if (txtsl.Text != "")
                        {
                            if (dateTimePicker1.Value.Date <= dateTimePicker2.Value.Date)
                            {
                                if (int.TryParse(txtsl.Text, out int soluong))
                                {
                                    if (soluong > 0)
                                    {
                                        var phieutract = new Phieutract
                                        {
                                            Matra = txtid.Text,
                                            Masach = txtsach.Text,
                                            Soluong = soluong,
                                            Trangthai = txttrangthai.Text,
                                            Ngaymuon = dateTimePicker1.Value.Date,
                                            Ngaytra = dateTimePicker2.Value.Date
                                        };
                                        var phieumuon = _muon.GetAllPhieumuon().Where(x => x.Cccd == txtcccd.Text && x.Tenkh == txttenkh.Text);
                                        if (phieumuon != null)
                                        {
                                            foreach (var x in phieumuon)
                                            {
                                                var phieumuonct = _muonct.GetAll().FirstOrDefault(a => a.Mamuon == x.Mamuon);
                                                int soluongsachmuon = _muonct.GetAll().Where(a => a.Mamuon == x.Mamuon).Sum(x => x.Soluong);
                                                if (phieumuonct != null)
                                                {
                                                    if (phieutract.Masach == phieumuonct.Masach && phieutract.Ngaymuon == phieumuonct.Ngaymuon)
                                                    {
                                                        if (soluong <= phieumuonct.Soluong)
                                                        {
                                                            var add = _ct.AddHoaDonCT(phieutract);
                                                            if (add)
                                                            {
                                                                LoadDataCT(txtid.Text);
                                                                txtsach.Text = txtsl.Text = txttrangthai.Text = "";
                                                                dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
                                                                var sach = _sach.GetBy(phieutract.Masach);
                                                                if (sach != null)
                                                                {
                                                                    if (_sach.Update(phieutract.Masach, new DAL.Models.Sach
                                                                    {
                                                                        Soluong = sach.Sum(p => p.Soluong) + soluong
                                                                    }))
                                                                    {
                                                                        MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    }
                                                                }
                                                                int soluongsachtra = _ct.GetByPhieutraCT(txtid.Text).Sum(p => p.Soluong);
                                                                if (soluongsachtra == soluongsachmuon)
                                                                {
                                                                    MessageBox.Show("Khách hàng đã trả hết số lượng sách đã mượn! \nVui lòng trả lại thẻ CCCD cho khác hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    var up = _muon.UpdateHoaDon(x.Mamuon, new DAL.Models.Phieumuon
                                                                    {
                                                                        Trangthai = "Đã trả"
                                                                    });
                                                                    if (up)
                                                                    {
                                                                        return;
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                return;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Bạn mượn " + phieumuonct.Soluong + "quyển! Vui lòng nhập nhỏ hơn hoặc bằng " + phieumuonct.Soluong + "!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        }
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Không có bất kì thông tin nào về người dùng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng số lượng lớn hơn không!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng nhập số lượng bằng số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập ngày mượn nhỏ hưn hoặc bằng ngày trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
