using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planificador_de_Procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FCFS fcfs;

        private void btnFCFS_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtProcess.Text);
            int max = Convert.ToInt32(txtMaxtime.Text);
            fcfs = new FCFS(num);
            txtTet.Text = Convert.ToString(fcfs.Waitedtime(max));
            txtShow.Text = fcfs.show();
            txtRet.Text = Convert.ToString(fcfs.Responetime());
            
        }

        private void btnSjfs_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtProcess.Text);
            int max = Convert.ToInt32(txtMaxtime.Text);
            fcfs = new FCFS(num);
            txtShow.Text = fcfs.show();
            txtTet.Text = Convert.ToString(fcfs.Waitedtime(max));
            fcfs.FillingShortest();
            txtRet.Text = Convert.ToString(fcfs.Responetime());
        }
    }
}
