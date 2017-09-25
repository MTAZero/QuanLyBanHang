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
    public partial class FrmXuatHang : Form
    {
        private QLBanHangDbContext db = Service.DBService.db;
        private int indexHOADONBAN = 0, indexHOADONBAN1 = 0;
        private int indexCHITIETXUAT = 0, indexCHITIETXUAT1 = 0;
        private NHANVIEN nv = new NHANVIEN();

        #region constructor
        public FrmXuatHang(NHANVIEN _nv)
        {
            InitializeComponent();
            Service.DBService.Reload();
            nv = _nv;
        }
        #endregion

        #region Form chính
        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            LoadHOADONBAN();
            LoadCHITIETXUAT();
        }
        #endregion

    }
}
