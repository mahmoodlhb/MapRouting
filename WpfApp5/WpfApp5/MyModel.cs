using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class MyModel
    {
        public MyModel() { }

        public MyModel(double x, double y, double depth)
        {
            this.X = x;
            this.Y = y;
            this.Depth = depth;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Depth { get; set; }
    }
}
