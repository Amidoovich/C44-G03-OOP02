using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal struct Point
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion

        #region Constructors
        // is a special function
        //      1. Named As Struct
        //      2. Has No Return Type
        //      3. Intialize Attributes

        // Paramter Less Constructor
        // Access After .Net 5.0
        public Point()
        {
            X = default;
            Y = default;
        }

        public Point(int _x ,int _y)
        {
            //this.X = X;
            //this.Y = Y;
            X= _x;
            Y= _y;
        }

        public Point(int Number)
        {
            X = Y = Number;
        }



        #endregion

        #region Methods

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        #endregion
    }
}
