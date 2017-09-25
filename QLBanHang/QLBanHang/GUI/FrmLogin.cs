using QLBanHang.Data;
using QLBanHang.Service;
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
    public partial class FrmLogin : Form
    {
        private QLBanHangDbContext db = DBService.db;
        
        #region Constructor
        public FrmLogin()
        {
            InitializeComponent();
            DBService.Reload();
        }
        #endregion

        #region Sự kiện
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
