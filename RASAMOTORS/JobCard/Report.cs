using RASAMOTORS.JobCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.JobCard
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobCardDS.jobPred' table. You can move, or remove it, as needed.
            this.jobPredTableAdapter.Fill(this.jobCardDS.jobPred, Convert.ToDateTime(dtFrm.Text), Convert.ToDateTime(dtTo.Text));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
