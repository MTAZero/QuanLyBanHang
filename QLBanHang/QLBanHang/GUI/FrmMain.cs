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
    public partial class FrmMain : Form
    {
        private QLBanHangDbContext db = Service.DBService.db;
        private NHANVIEN nv = new NHANVIEN();

        #region constructor
        public FrmMain(NHANVIEN _nv)
        {
            InitializeComponent();
            Service.DBService.Reload();
            nv = _nv;
        }
        #endregion

        #region LoadForm

        private void LoadPhanQuyen()
        {
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region sự kiện
        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQLMatHang_Click(object sender, EventArgs e)
        {
            
        }
        private void btnQLKho_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            
        }

        

        private void txtDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        #endregion
    }
}
