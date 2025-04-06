using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Segment : Line
    {
        public Segment() : base() { 
        
        }

        public Segment(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2) { 
        }

        public Segment(Segment other) : base(other) {
        }

        public double GetAngleDegrees() {
            double dx = X2 - X1;
            double dy = Y2 - Y1;
            return Math.Atan2(dy, dx) * 180 / Math.PI;
        }
    }
}
