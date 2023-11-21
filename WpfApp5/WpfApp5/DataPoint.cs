using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp5
{
    public class DataPoint
    {
        public DataPoint() { }
        public DataPoint(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point Location
        {
            get { return new Point((int)X, (int)Y); }
        }

        public new string ToString()
        {
            return string.Format("X {0:0.00}, Y {1:0.00}, Z {2:0.00}", X, Y, Z);
        }
    }
}
