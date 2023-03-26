using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_prueba
{
    internal class Vector
    {
        int _x;
        int _y;

        public Vector(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int X { get { return _x; } }
        public int Y { get { return _y; } }

        public double Modulo()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }

        public double Inclinacion()
        {
            return Math.Tan(_y / _x);
        }
        public override string ToString()
        {
            return $"{_x} {_y}";
        }
    }
}
