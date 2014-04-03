using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace OxyplotColumnExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  plot1.Model = Simplestackedmodel();

        }

        private void btnBroken_Click(object sender, EventArgs e)
        {
            BrokenForm bf = new BrokenForm();
            bf.ShowDialog();
        }

        private void btnWorking_Click(object sender, EventArgs e)
        {
            WorkingForm wf = new WorkingForm();
            wf.ShowDialog();
        }


    }
}
