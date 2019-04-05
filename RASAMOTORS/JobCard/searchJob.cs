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
    public partial class searchJob : Form
    {
        public searchJob()
        {
            InitializeComponent();
        }

        private void btnBHome_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void btnNJob_Click(object sender, EventArgs e)
        {
            new assignJob().Show();
            this.Close();
        }
    }
}
