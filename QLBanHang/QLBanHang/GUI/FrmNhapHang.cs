using QLBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.GUI
{
    public partial class FrmNhapHang : Form
    {
        private QLBanHangDbContext db = Service.DBService.db;
        private int indexPhieuNhap = 0, indexPhieuNhap1 = 0;
        private int indexChiTietNhap = 0, indexChiTietNhap1 = 0;
        private NHANVIEN nv = new NHANVIEN();

        #region constructor
        public FrmNhapHang(NHANVIEN _nv)
        {
            InitializeComponent();
            Service.DBService.Reload();
            nv = _nv;
        }
        #endregion

        #region Form chính
        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Phiếu nhập

        #region Load
        private void LoadInitControl()
        {
            

        }

        private void LoadDgvPhieuNhap()
        {
            
        }

        private void LoadPhieuNhap()
        {
            
        }
        #endregion

        

        #region Sự kiện ngầm

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region Sự kiện
        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaPhieuNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #endregion

        #region Chi tiết nhập

        #region Load
        private void LoadInitControlChiTietNhap()
        {
            

        }

        private void LoadDgvChiTietNhap()
        {

            
        }

        private void LoadChiTietNhap()
        {
            
        }
        #endregion

        


        #region Sự kiện
        private void btnThemChiTietNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaChiTietNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaChiTietNhap_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #endregion

    }
}
