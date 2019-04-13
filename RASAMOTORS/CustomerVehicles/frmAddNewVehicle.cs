using RASAMOTORS.CustomerVehicles.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.CustomerVehicles
{
    public partial class frmAddNewVehicle : Form
    {
        VehicleClass v = new VehicleClass();
        private string customerID;


        public frmAddNewVehicle(string customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //getting values from the input fields

            v.Brand = TextBoxBrand.Text;
            v.Model = textBoxModel.Text;
            v.EngineNo = textBoxEngNo.Text;
            v.ChassiNo = textBoxChassiNo.Text;
            v.ProductionYear = Int32.Parse(textBoxProdYear.Text);
            v.Type = comboBoxType.Text;
            v.CustomerID = customerID;

            //check whether insertion is success

            bool success = v.insert(v);

            if (success == true)
            {
                MessageBox.Show("Successfully Inserted!");

                //to clear data on fields

                clear();
            }
            else
            {
                MessageBox.Show("Error Occured!");
            }
        }

        public void clear()
        {
            TextBoxBrand.Text = "";
            textBoxModel.Text = "";
            textBoxEngNo.Text = "";
            textBoxChassiNo.Text = "";
            textBoxProdYear.Text = "";
            comboBoxType.Text = "";
        }

    }
}
    }
}
