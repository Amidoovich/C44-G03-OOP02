using System.Xml;

namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] Persons = new Person[3];

            //Persons[0] = new Person("Ahmed",21);
            //Persons[1] = new Person("Mohamed",50);
            //Persons[2] = new Person("Samy",79);


            //for (int i = 0;i<Persons.Length;i++)
            //    Console.WriteLine($"Person Number {i+1}\nName : {Persons[i].Name}\nAge : {Persons[i].Age}");


            #endregion

            #region Q2-Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //bool IsParse;
            //Point P01 = new Point();
            //Point P02 = new Point();
            //int X, Y;
            //do
            //{
            //    Console.Write("please enter the X-axis for point 1  : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out X);

            //} while (!IsParse);
            //do
            //{
            //    Console.Write("please enter the Y-axis for point 1  : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out Y);

            //} while (!IsParse);

            //P01.X = X;
            //P01.Y = Y;

            //do
            //{
            //    Console.Write("please enter the X-axis for point 2  : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out X);

            //} while (!IsParse);
            //do
            //{
            //    Console.Write("please enter the Y-axis for point 2  : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out Y);

            //} while (!IsParse);

            //P02.X = X;
            //P02.Y = Y;

            //Console.WriteLine($"the distance is {Point.DistanceBetweenTwoPoints(P01,P02)}");
            #endregion

            #region Q3-Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            string? Name;
            int Age;
            bool IsParse;
            Person P01 = new Person();
            Person P02 = new Person();
            Person P03 = new Person();
            do
            {
                Console.Write($"Please Enter the Name of the first person : ");
                P01.Name = Console.ReadLine();
                Console.Write($"Please Enter the Age of the first person : ");
                IsParse = int.TryParse( Console.ReadLine(), out Age );
            } while (!IsParse);
            P01.Age = Age;
            Console.WriteLine("\n");
            do
            {
                Console.Write($"Please Enter the Name of the second person : ");
                P02.Name = Console.ReadLine();
                Console.Write($"Please Enter the Age of the second person : ");
                IsParse = int.TryParse( Console.ReadLine(), out Age );
            } while (!IsParse);
            P02.Age = Age;
            Console.WriteLine("\n");
            do
            {
                Console.Write($"Please Enter the Name of the third person : ");
                P03.Name = Console.ReadLine();
                Console.Write($"Please Enter the Age of the third person : ");
                IsParse = int.TryParse( Console.ReadLine(), out Age );
            } while (!IsParse);
            P03.Age = Age;
            Console.WriteLine("\n");

            Console.WriteLine(Person.OldestPerson(P01, P02, P03));
            #endregion

        }

    }
}
