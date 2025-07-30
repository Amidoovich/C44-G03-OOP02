using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal struct Person
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

        #region Methods

        public static string OldestPerson(Person P01, Person P02, Person P03)
        {
            if (P01.Age > P02.Age && P01.Age > P03.Age)
                return $"Name : {P01.Name}\nAge : {P01.Age}";
            else if (P02.Age > P01.Age && P02.Age > P03.Age)
                return $"Name : {P02.Name}\nAge : {P02.Age}";

            return $"Name : {P03.Name}\nAge : {P03.Age}";
            
        }


        #endregion
    }
}
