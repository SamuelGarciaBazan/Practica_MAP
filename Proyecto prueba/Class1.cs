using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_prueba
{
    internal class Vector
    {
        int x;
        int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public double Modulo()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double Inclinacion()
        {
            return Math.Tan(y / x);
        }
    }
}
