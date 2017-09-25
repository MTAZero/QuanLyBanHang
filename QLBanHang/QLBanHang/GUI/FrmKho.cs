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
    public partial class FrmKho : Form
    {
        private QLBanHangDbContext db = Service.DBService.db;

        #region constructor
        public FrmKho()
        {
            InitializeComponent();
            Service.DBService.Reload();
        }

        #endregion

        #region LoadForm
        private void LoadDgvMatHang()
        {
        }
        private void FrmKho_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
