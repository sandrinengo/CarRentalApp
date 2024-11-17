using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Properties
        #endregion

        #region Methods
        #endregion

        #region Events
        private void addRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRental frmRental = new frmRental();
            frmRental.MdiParent = this;
            frmRental.Show();
        }
        #endregion

        private void tsmManageVehicle_Click(object sender, EventArgs e)
        {
            frmManageVehicle frmManageVehicle = new frmManageVehicle();
            frmManageVehicle.MdiParent = this;
            frmManageVehicle.Show();
        }
    }
}
