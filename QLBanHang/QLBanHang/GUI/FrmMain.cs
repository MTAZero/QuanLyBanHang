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
        private QLBanHangDbContext db = DBService.db;

        #region Constructor
        public FrmLogin()
        {
            InitializeComponent();
            DBService.Reload();
        }
        #endregion

    }
}
