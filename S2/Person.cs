using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal class Person
    {
        #region Attributes

        public string? Name { get; set; }

        private int age;

        #endregion

        #region Costructors

        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }


        #endregion

        #region Full Property

        public int Age
        {
            get {  return age; }
            set { age = value < 0 ? 0 : value; }
        }


        #endregion
    }
}
