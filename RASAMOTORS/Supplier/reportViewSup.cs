using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.Supplier
{
    public partial class reportViewSup : Form
    {
        public reportViewSup()
        {
            InitializeComponent();
        }

        private void reportViewSup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.supplierDetails' table. You can move, or remove it, as needed.
            this.supplierDetailsTableAdapter.Fill(this.supplierDataSet.supplierDetails, dateFrom.Text, dateTo.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
