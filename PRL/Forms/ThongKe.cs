using DAL.Models;
using DAL.Repository;
using DAL.View;
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

namespace PRL.Forms
{
    public partial class ThongKe : Form
    { 
        string username , password ;
        public ThongKe(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            panel1.Visible = true;
            panel2.Visible = false;
            LoadThongKeSach();
            LoadThongKeQuaHan();
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void LoadThongKeQuaHan()
        {
            //SachRepos sachRepos = new SachRepos();
            //PhieuMuonCTRepos phieuMuonctRepos = new PhieuMuonCTRepos();
            //PhieuMuonRepos phieuMuonRepos = new PhieuMuonRepos();
            //PhieuTraCTRepos phieutract = new PhieuTraCTRepos();
            //PhieuTraRepos phieutra = new PhieuTraRepos();
            //var thongKe = from ptct in phieutract.GetAll()
            //              join pt in phieutra.GetAllPhieutra() on ptct.Matra equals pt.Matra
            //              join pm in phieuMuonRepos.GetAllPhieumuon() on new { pt.Cccd, pt.Tenkh } equals new { pm.Cccd, pm.Tenkh }
            //              join pmct in phieuMuonctRepos.GetAll() on new { ptct.Masach, ptct.Ngaymuon } equals new { pmct.Masach, pmct.Ngaymuon }
            //              from pm in phieuMuonctRepos.GetAll();
            //              select new
            //              {
            //                  Mamuon = pm.Mamuon,
            //                  Masach = pmct.Masach,
            //                  Soluong = pmct.Soluong,
            //                  Ngaymuon = pmct.Ngaymuon,
            //                  Ngaytra = pmct.Ngaytra,
            //              };
            //if (thongKe != null)
            //{

            //}
            //int stt = 1;
            //dataGridView1.Rows.Clear();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.ColumnCount = 6;
            //dataGridView1.Columns[0].Name = "STT";
            //dataGridView1.Columns[1].Name = "Số hóa đơn";
            //dataGridView1.Columns[2].Name = "Tên sách";
            //dataGridView1.Columns[3].Name = "Tổng số lượng";
            //dataGridView1.Columns[4].Name = "Số lượng cho mượn";
            //dataGridView1.Columns[5].Name = "Số lượng còn lại";
            //foreach (var x in thongKe)
            //{
            //    dataGridView1.Rows.Add(stt++, x.Masach, x.Tensach, x.TongSoLuong, x.SoLuongChoMuon, x.SoLuongConLai);
            //}
        }
        private void LoadThongKeSach()
        {
            SachRepos sachRepos = new SachRepos();
            PhieuMuonCTRepos phieuMuonRepos = new PhieuMuonCTRepos();
            var danhSachSach = sachRepos.GetAll();
            var danhSachPhieuMuon = phieuMuonRepos.GetAll() ;
            var thongKe = from sach in danhSachSach
                          join ctMuon in danhSachPhieuMuon on sach.Masach equals ctMuon.Masach into g
                          select new ViewThongKeSach
                          {
                              Masach = sach.Masach,
                              Tensach = sach.Tensach,
                              TongSoLuong = sach.Soluong + g.Sum(ct => ct.Soluong),
                              SoLuongChoMuon = g.Sum(ct => ct.Soluong),
                              SoLuongConLai = sach.Soluong
                          };
            int stt = 1;
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "ID";
            dataGridView1.Columns[2].Name = "Tên sách";
            dataGridView1.Columns[3].Name = "Tổng số lượng";
            dataGridView1.Columns[4].Name = "Số lượng cho mượn";
            dataGridView1.Columns[5].Name = "Số lượng còn lại";
            foreach (var x in thongKe)
            {
                dataGridView1.Rows.Add(stt++,x.Masach,x.Tensach,x.TongSoLuong,x.SoLuongChoMuon,x.SoLuongConLai);
            }
        }
        private void thốngKêQuáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
