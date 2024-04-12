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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void LoadThongKeSach()
        {
            SachRepos sachRepos = new SachRepos();
            PhieuMuonCTRepos phieuMuonRepos = new PhieuMuonCTRepos();
            var danhSachSach = sachRepos.GetAll();
            var danhSachPhieuMuon = phieuMuonRepos.GetAll() ;
            var thongKe = from sach in danhSachSach
                          join ctMuon in danhSachPhieuMuon on sach.Masach equals ctMuon.Mamuon into g
                          select new
                          {
                              Masach = sach.Masach,
                              Tensach = sach.Tensach,
                              TongSoLuong = sach.Soluong,
                              SoLuongChoMuon = g.Sum(ct => ct.Soluong),
                              SoLuongConLai = sach.Soluong - g.Sum(ct => ct.Soluong)
                          };
            int stt = 1;
            dataGridView1.Rows.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "STT";
            dataGridView1.Columns[2].Name = "STT";
            dataGridView1.Columns[3].Name = "STT";
            dataGridView1.Columns[4].Name = "STT";
            dataGridView1.Columns[5].Name = "STT";
            foreach (var x in thongKe)
            {
                dataGridView1.Rows.Add(stt++,x.Masach,x.TongSoLuong,x.SoLuongChoMuon,x.SoLuongConLai);
            }
        }
        private void thốngKêQuáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
