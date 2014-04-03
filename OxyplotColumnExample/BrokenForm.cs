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
    public partial class BrokenForm : Form
    {
        public BrokenForm()
        {
            InitializeComponent();
        }

        private void BrokenForm_Load(object sender, EventArgs e)
        {
            plot1.Model = Simplestackedmodel();
        }


        public PlotModel Simplestackedmodel()
        {
            var plotModel1 = new PlotModel();
            plotModel1.LegendBorderThickness = 0;
            plotModel1.LegendOrientation = LegendOrientation.Horizontal;
            plotModel1.LegendPlacement = LegendPlacement.Outside;
            plotModel1.LegendPosition = LegendPosition.BottomCenter;
            plotModel1.Title = "Simple stacked model";
            var categoryAxis1 = new CategoryAxis();
            categoryAxis1.MinorStep = 1;
            categoryAxis1.Labels.Add("Category A");
            categoryAxis1.Labels.Add("Category B");
            categoryAxis1.Labels.Add("Category C");
            categoryAxis1.Labels.Add("Category D");
            plotModel1.Axes.Add(categoryAxis1);
            var linearAxis1 = new LinearAxis();
            linearAxis1.AbsoluteMinimum = 0;
            linearAxis1.MaximumPadding = 0.06;
            linearAxis1.MinimumPadding = 0;
            plotModel1.Axes.Add(linearAxis1);
            var columnSeries1 = new ColumnSeries();
            columnSeries1.IsStacked = true;
            columnSeries1.StrokeThickness = 1;
            columnSeries1.Title = "Series 1";
            columnSeries1.Items.Add(new ColumnItem(25, -1));
            columnSeries1.Items.Add(new ColumnItem(137, -1));
            columnSeries1.Items.Add(new ColumnItem(18, -1));
            columnSeries1.Items.Add(new ColumnItem(40, -1));
            plotModel1.Series.Add(columnSeries1);
            var columnSeries2 = new ColumnSeries();
            columnSeries2.IsStacked = true;
            columnSeries2.StrokeThickness = 1;
            columnSeries2.Title = "Series 2";
            columnSeries2.Items.Add(new ColumnItem(12, -1));
            columnSeries2.Items.Add(new ColumnItem(14, -1));
            columnSeries2.Items.Add(new ColumnItem(120, -1));
            columnSeries2.Items.Add(new ColumnItem(26, -1));
            plotModel1.Series.Add(columnSeries2);
            return plotModel1;
        }

    }
}
