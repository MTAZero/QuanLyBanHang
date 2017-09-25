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
    public partial class FrmDoiMatKhau : Form
    {
        private QLBanHangDbContext db = Service.DBService.db;
        private NHANVIEN nv = new NHANVIEN();

        #region Load form
        public FrmDoiMatKhau(NHANVIEN _nv)
        {
        }
        #endregion

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
        }
    }
}
