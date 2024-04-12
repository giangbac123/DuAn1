using DAL.Repository;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class MaQR : Form
    {
        string username, passwork, maphieu;
        PhieuMuonCTRepos _ct = new PhieuMuonCTRepos();
        PhieuMuonRepos _repos = new PhieuMuonRepos();
        public MaQR(string username, string passwork, string maphieu)
        {
            InitializeComponent();
            this.username = username;
            this.passwork = passwork;
            this.maphieu = maphieu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(maphieu))
                {
                    PhieuMuonRepos muon = new PhieuMuonRepos();
                    PhieuMuonCTRepos _ct = new PhieuMuonCTRepos();
                    NguoidungRepos ng = new NguoidungRepos();
                    var a = muon.GetByIDPhieumuon(maphieu);

                    if (a != null && a.Count > 0)
                    {
                        Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                        string directoryPath = @"D:\NET104 - Lập Trình  C#4\Bài Tập\DuAn1\PRL\HoaDon\";
                        string fileName = maphieu + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                        string fullPath = Path.Combine(directoryPath, fileName);

                        PdfWriter.GetInstance(document, new FileStream(fullPath, FileMode.Create));

                        document.Open();

                        Paragraph tieude = new Paragraph("THƯ VIỆN SÁCH TRÍ TUỆ", FontFactory.GetFont(FontFactory.HELVETICA, 24f.ToString(), Font.Bold));
                        tieude.Alignment = Element.ALIGN_CENTER;
                        document.Add(tieude);

                        Paragraph diachi = new Paragraph("Địa chỉ: 86 Cầu Diễn, Bắc Từ Liêm, TP. Hà Nội", FontFactory.GetFont(FontFactory.HELVETICA, 14f.ToString(), Font.Bold));
                        diachi.Alignment = Element.ALIGN_LEFT;
                        document.Add(diachi);

                        Paragraph sdt = new Paragraph("Số điện thoại: 0123456789", FontFactory.GetFont(FontFactory.HELVETICA, 14f.ToString(), Font.Bold));
                        sdt.Alignment = Element.ALIGN_LEFT;
                        document.Add(sdt);

                        // Add title
                        Paragraph title = new Paragraph("HÓA ĐƠN BÁN LẺ", FontFactory.GetFont(FontFactory.HELVETICA, 18f.ToString(), Font.Bold));
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(title);
                        document.Add(Chunk.NEWLINE);

                        var nv = ng.GetAll().FirstOrDefault(x => x.Mand == username || x.Email == username);
                        var ma = _repos.GetAllPhieumuon().FirstOrDefault(x => x.Mamuon == maphieu);
                        // Add invoice details
                        PdfPTable table = new PdfPTable(7);
                        table.WidthPercentage = 100;
                        Paragraph p1 = new Paragraph("Số phiếu: " + ma.Mamuon);
                        Paragraph p2 = new Paragraph("Khách hàng: " + ma.Tenkh);
                        Paragraph p3 = new Paragraph("Nhân viên: " + nv.Hoten);
                        document.Add(p1);
                        document.Add(p2);
                        document.Add(p3);
                        table.AddCell("STT");
                        table.AddCell("Mã sách");
                        table.AddCell("Tên sách");
                        table.AddCell("Số lượng");
                        table.AddCell("Tiền cọc");
                        table.AddCell("Ngày mượn");
                        table.AddCell("Ngày trả");
                        int stt = 1;
                        int tongtien = 0;
                        var ctphieu = _ct.GetAll().Where(x=>x.Mamuon==maphieu);
                        foreach (var x in ctphieu)
                        {
                            table.AddCell((stt++).ToString());
                            table.AddCell(x.Masach.ToString());
                            table.AddCell(x.Soluong.ToString());
                            table.AddCell(x.Tienphi.ToString());
                            table.AddCell(x.Ngaymuon.ToString());
                            table.AddCell(x.Ngaytra.ToString());
                            tongtien += x.Tienphi;
                        }

                        document.Add(table);
                        Paragraph p4 = new Paragraph("Tổng phải thanh toán: " + tongtien + "VND");
                        document.Add(p4);
                        DateTime thoigian = DateTime.Now;
                        Paragraph p5 = new Paragraph("Thời gian: " + thoigian.ToString());
                        document.Add(p5);
                        document.Close();


                        MessageBox.Show("Hóa đơn đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Phieumuon qr = new Phieumuon(username, passwork);
                        qr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Phieumuon phieumuon =  new Phieumuon(username, passwork);
                phieumuon.Show();
                this.Hide();
            }
        }
    }
}
