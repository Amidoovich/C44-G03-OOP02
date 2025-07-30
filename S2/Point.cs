using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }


        #region constructors

        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Methods

        public static float DistanceBetweenTwoPoints(Point P01 , Point P02)
        {
            return (float) Math.Sqrt(((P01.X - P02.X) * (P01.X - P02.X)) + ((P01.Y - P02.Y) * (P01.Y - P02.Y)));
        }

        #endregion
    }
}
