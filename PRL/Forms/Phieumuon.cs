
using DAL.Models;
using DAL.Repository;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
        PhieuMuonRepos _repos = new PhieuMuonRepos();
        PhieuMuonCTRepos _Ct = new PhieuMuonCTRepos();
        SachRepos _sach = new SachRepos();
        int stt = 1;
        int idCT = 0;
        
        public Phieumuon(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            pass = mk;
        }
        

        private void Phieumuon_Load(object sender, EventArgs e)
        {
            LoadSach(_sach.GetAll());
            LoadData(_repos.GetAllPhieumuon());
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
            
            foreach (var x in data)
            {
                ViewSach.Rows.Add(stt++, x.Masach, x.Tensach, x.Soluong, x.Trangthai);
            }
        }
        private void LoadData(dynamic data)
        {
            ViewHD.Rows.Clear();
            ViewHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewHD.ColumnCount = 4;
            ViewHD.Columns[0].Name = "STT";
            ViewHD.Columns[1].Name = "Số phiếu";
            ViewHD.Columns[2].Name = "Họ tên khách hàng";
            ViewHD.Columns[3].Name = "Số thẻ CCCD";
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Xóa";
            deleteButtonColumn.Text = "Xóa";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            ViewHD.Columns.Add(deleteButtonColumn);
            foreach (var x in data)
            {
                ViewHD.Rows.Add(stt++, x.Matra, x.Tenkh, x.Cccd);
            }
        }

        private void ViewSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = ViewSach.Rows[e.RowIndex];
            txtMasach.Text = selected.Cells[1].Value.ToString();
        }

        private void ViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = ViewHD.Rows[e.RowIndex];
            txtid.Text = selected.Cells[1].Value.ToString();
            txtTenkh.Text = selected.Cells[2].Value.ToString();
            txtCCCD.Text = selected.Cells[3].Value.ToString();
            LoadDataCT(_Ct.GetByPhieumuonCT(txtid.Text));
        }

        private void ViewCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ViewCT.Columns["Xóa"].Index)
            {
                DataGridViewRow selectedRow = ViewCT.Rows[e.RowIndex];
                int soPhieu = int.Parse(selectedRow.Cells[1].Value.ToString());
                var xoa = _Ct.DeleteCT(soPhieu);
                if (xoa)
                {
                    LoadData(_Ct.GetByPhieumuonCT(txtid.Text));
                    ViewCT.Rows.Clear();
                    idCT = 0;
                    MessageBox.Show("Xoá thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    idCT = 0;
                    return;
                }
            }
        }
        private void LoadDataCT(dynamic data)
        {
            ViewCT.Rows.Clear();
            ViewCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewCT.ColumnCount = 7;
            ViewCT.Columns[0].Name = "STT";
            ViewCT.Columns[1].Name = "Số phiếu"; ViewCT.Columns[1].Visible = false;
            ViewCT.Columns[2].Name = "Mã sách";
            ViewCT.Columns[3].Name = "Số lượng";
            ViewCT.Columns[4].Name = "Ngày mượn";
            ViewCT.Columns[5].Name = "Ngày trả";
            ViewCT.Columns[6].Name = "Ngày mượn";
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Xóa";
            deleteButtonColumn.Text = "Xóa";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            ViewCT.Columns.Add(deleteButtonColumn);
            foreach (var x in data)
            {
                ViewCT.Rows.Add(stt++, x.Masach, x.Soluong, x.Ngaymuon, x.Ngaytra, x.Trangthai);
            }
        }

        private void ViewCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = ViewCT.Rows[e.RowIndex];
            idCT += int.Parse(selected.Cells[1].Value.ToString());
            txtMasach.Text = selected.Cells[2].Value.ToString();
            txtSL.Text = selected.Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)selected.Cells[4].Value;
            dateTimePicker2.Value = (DateTime)selected.Cells[5].Value;
            txtTrangthai.Text = selected.Cells[6].Value.ToString();
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
            return "PM" + stringBuilder.ToString();

        }

        private void ViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ViewHD.Columns["Xóa"].Index)
            {
                DataGridViewRow selectedRow = ViewHD.Rows[e.RowIndex];
                string soPhieu = selectedRow.Cells[1].Value.ToString();
                var xoa = _repos.DeleteHoaDon(soPhieu);
                if (xoa)
                {
                    LoadData(_repos.GetAllPhieumuon());
                    ViewCT.Rows.Clear();
                    MessageBox.Show("Xoá thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    return;
                }
            }
        }

        private void txtTenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTK_TextChanged(object sender, EventArgs e)
        {
            PhieuMuonRepos _repos = new PhieuMuonRepos();

            if (btnTK.Text != "")
            {
                LoadData(_repos.GetByIDPhieumuon(btnTK.Text));
            }
            else
            {
                LoadData(_repos.GetAllPhieumuon());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "" && txtTenkh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtTenkh.Text != "")
                {
                    if (txtCCCD.Text != "")
                    {
                        if (txtCCCD.Text.Length != 12)
                        {
                            MessageBox.Show("Số căn cước công dân phải có độ dài là 12 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            int soLuongMuon;
                            if (!int.TryParse(txtSL.Text, out soLuongMuon) || soLuongMuon < 1 || soLuongMuon > 5)
                            {
                                MessageBox.Show("Số lượng mượn phải là một số nguyên từ 1 đến 5!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                DateTime ngayMuon = dateTimePicker1.Value;
                                DateTime ngayTra = dateTimePicker2.Value;
                                if (ngayTra <= ngayMuon || ngayTra > ngayMuon.AddYears(1))
                                {
                                    MessageBox.Show("Ngày trả phải sau ngày mượn và không được cách quá 1 năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    var a = _repos.AddHoaDon(new DAL.Models.Phieumuon
                                    {
                                        Mamuon = RandomID(),
                                        Tenkh = txtTenkh.Text,
                                        Cccd = txtCCCD.Text
                                    });
                                    if (a)
                                    {
                                        MessageBox.Show("Tạo thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số căn cước công dân!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtCCCD.Text == "" && txtTenkh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtTenkh.Text != "")
                    {
                        if (txtCCCD.Text != "")
                        {
                            var thongtin = _repos.GetAllPhieumuon().Where(x => x.Tenkh == txtTenkh.Text && x.Cccd == txtCCCD.Text);
                            if (thongtin != null)
                            {
                                var a = _repos.UpdateHoaDon(txtid.Text, new DAL.Models.Phieumuon
                                {
                                    Tenkh = txtTenkh.Text,
                                    Cccd = txtCCCD.Text
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
        private void ClearData()
        {
            txtid.Text = txtMasach.Text = txtSL.Text = txtTien.Text = txtTrangthai.Text = timSach.Text = txtTenkh.Text = txtCCCD.Text = "";
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Today;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SachRepos _sach = new SachRepos();
            if (timSach.Text != "")
            {
                LoadSach(_repos.GetByIDPhieumuon(btnTK.Text));
            }
            else
            {
                LoadSach(_repos.GetAllPhieumuon());
            }
        }
    }
}
