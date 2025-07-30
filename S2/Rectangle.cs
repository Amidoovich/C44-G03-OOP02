using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal struct Rectangle
    {
        #region Attributes

        private double width;

        private double height;

        #endregion

        #region Constructors

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }



        #endregion

        #region Full Property

        public double Width
        {
            get { return width; }
            set 
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Width can not be Negative");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine("Width can not be Negative");
            }
        }

        #endregion

        public double Area { get { return width * height; } }

        #region Methods

        public string DisplayInfo()
        {
            return $"Rectanglr Info:\nWidth : {width}\nHeight : {height}\nArea : {Area},";
        }

        #endregion
    }
}
