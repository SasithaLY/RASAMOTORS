using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.Inventory
{
    public partial class ItemsReport : Form
    {
        public ItemsReport()
        {
            InitializeComponent();
        }

        private void ItemsReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            // TODO: This line of code loads data into the 'ItemsData.inventory' table. You can move, or remove it, as needed.

            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("fromDate", dtpFrom.Value.Date.ToShortDateString()),
                new Microsoft.Reporting.WinForms.ReportParameter("toDate", dtpTo.Value.Date.ToShortDateString())
            };

            DateTime fromDate = DateTime.Parse(this.dtpFrom.Text);
            DateTime toDate = DateTime.Parse(this.dtpTo.Text);
            // TODO: This line of code loads data into the 'InventoryData.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.InventoryData.inventory, dtpFrom.Value, dtpTo.Value);

            reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
