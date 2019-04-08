using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.Employees
{
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            
           

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EmployeeDataSet.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.EmployeeDataSet.emp, dateTimePickerFrom.Text, dateTimePickerTo.Text);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
