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
            LoadPhieuNhap();
            LoadChiTietNhap();
        }
        #endregion


    }
}
