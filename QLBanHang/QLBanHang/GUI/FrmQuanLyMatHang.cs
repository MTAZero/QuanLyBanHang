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
    public partial class FrmQuanLyMatHang : Form
    {
        private QLBanHangDbContext db = Service.DBService.db;
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLyMatHang()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm

        private void LoadControl()
        {
            groupThongTin.Enabled = false;
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.MATHANGs.ToList()
                       .Select(p => new
                       {
                           ID = p.ID,
                           STT = ++i,
                           TenMH = p.TEN,
                           DonViTinh = p.DONVITINH,
                           GhiChu = p.GHICHU
                       })
                       .ToList();

            dgvMatHang.DataSource = dbNV
                                    .Where(p => p.TenMH.Contains(keyword) || p.DonViTinh.Contains(keyword))
                                    .ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvMatHang.Rows[index].Cells["STT"].Selected = true;
                dgvMatHang.Select();
            }
            catch { }
        }


        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoadDgvNhanVien();
        }
        #endregion
    }
}
