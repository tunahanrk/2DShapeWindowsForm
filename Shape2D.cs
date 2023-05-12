using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Shape2D : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Shape2D() : base()
        {
            X = 0;
            Y = 0;
            Name = "2D Shape";
        }

        public Shape2D(double xx, double yy) : base()
        {
            X = xx;
            Y = yy;
            Name = "2D Shape";
        }

    }
}
