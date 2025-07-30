namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            Person[] Persons = new Person[3];

            Persons[0] = new Person("Ahmed",21);
            Persons[1] = new Person("Mohamed",50);
            Persons[2] = new Person("Samy",79);
            

            for (int i = 0;i<Persons.Length;i++)
                Console.WriteLine($"Person Number {i+1}\nName : {Persons[i].Name}\nAge : {Persons[i].Age}");


            #endregion
        }

    }
}
