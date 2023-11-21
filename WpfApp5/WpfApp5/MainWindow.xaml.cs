using Infragistics.Controls.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var surfaceChart = new XamScatterSurface3D();
            surfaceChart.ItemsSource = new ViewModel().DataCollection;

            surfaceChart.XMemberPath = "X";
            surfaceChart.YMemberPath = "Y";
            surfaceChart.ZMemberPath = "Z";

            var xLinearAxis = new LinearAxis();
            var yLinearAxis = new LinearAxis();
            var zLinearAxis = new LinearAxis();

            xLinearAxis.Title = "X Axis";
            yLinearAxis.Title = "Y Axis";
            zLinearAxis.Title = "Z Axis";

            surfaceChart.XAxis = xLinearAxis;
            surfaceChart.YAxis = yLinearAxis;
            surfaceChart.ZAxis = zLinearAxis;
        }
    }
}
