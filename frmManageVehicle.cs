using CarRentalApp.Models;
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
    public partial class frmManageVehicle : Form
    {
        #region Properties
        private readonly CarRentalEntities context;
        #endregion

        #region Methods
        public frmManageVehicle()
        {
            InitializeComponent();
            context = new CarRentalEntities();
        }
        #endregion

        #region Events    
        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            var cars = context.CarTypes.ToList();
            dgvVehicle.DataSource = cars;
            dgvVehicle.Columns[0].Visible = false;
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
