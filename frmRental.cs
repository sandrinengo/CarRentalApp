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
    public partial class frmRental : Form
    {
        public frmRental()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        #region Properties
        private ErrorProvider errorProvider = new ErrorProvider();
        private readonly CarRentalEntities carRentalEntities;
        #endregion

        #region Methods
        private void ShowNotification(string text)
        {
            MessageBox.Show(text);
        }

        private void ValidateRequiredFields()
        {
            bool isValid = false;
            string customerName = txtCustomerName.Text.Trim();
            var rentDate = dtpRentDate.Value;
            var returnDate = dtpReturnDate.Value;
            string carType = ddlCarTypes.Text.ToString();


            if (string.IsNullOrEmpty(customerName))
            {
                errorProvider.SetError(txtCustomerName, "Customer Name cannot be empty.");
            }

            if (string.IsNullOrEmpty(carType))
            {
                errorProvider.SetError(ddlCarTypes, "Car type cannot be empty.");
            }
        }

        private void LoadCarTypes()
        {
            try
            {
                var carTypes = carRentalEntities.CarTypes.ToList();
                carTypes.Insert(0, new CarType { ID=0, Name="Select"});
                ddlCarTypes.DisplayMember = "Name";
                ddlCarTypes.ValueMember = "ID";
                
                ddlCarTypes.DataSource = carTypes;
                
            }
            catch (Exception ex)
            {
            }
        }
        #endregion


        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCarTypes();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateRequiredFields();
                // Retrieve all errors
                List<string> errors = Helpers.ErrorHelper.GetAllErrors(this.Controls, errorProvider);

                if (errors.Count > 0)
                {
                    // Display errors or handle them as needed
                    MessageBox.Show(string.Join("\n", errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CarRentalRecord carRentalRecord = new CarRentalRecord()
                    {
                        CustomerName = txtCustomerName.Text.Trim(),
                        RentDate = dtpRentDate.Value,
                        ReturnDate = dtpReturnDate.Value,
                        Cost = Convert.ToDecimal(txtCost.Text.Trim()),
                        CarTypeID = Convert.ToInt32(ddlCarTypes.SelectedValue)
                    };
                    SaveCarRentalInfo(carRentalRecord);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void SaveCarRentalInfo(CarRentalRecord carRentalRecord)
        {
            carRentalEntities.CarRentalRecords.Add(carRentalRecord);
            carRentalEntities.SaveChanges();
        }
        #endregion
    }
}
