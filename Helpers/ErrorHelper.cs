using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp.Helpers
{
    public static class ErrorHelper
    {
        public static List<string> GetAllErrors(Control.ControlCollection controls, ErrorProvider errorProvider)
        {
            List<string> errors = new List<string>();

            foreach (Control control in controls)
            {
                // Get the error for the control
                string errorMessage = errorProvider.GetError(control);

                // If there's an error, add it to the list
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    errors.Add($"Control: {control.Name}, Error: {errorMessage}");
                }
            }

            return errors;
        }
    }
}
