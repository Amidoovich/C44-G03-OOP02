namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            #region Example 01
            //Point P01; // declare variable from point data type
            //// CLR will Allocate 8 Unintialized Bytes in Stack
            ////== int X;

            ////P01 = new Point();
            ////// new => just for constructor selection that will used to initialize P01 Attributes

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            //P01 = new Point(10);
            //// new => just for constructor selection that will used to initialize P01 Attributes

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Console.WriteLine(P01);
            //Console.WriteLine(P01.ToString());

            //int X = 5;
            //Console.WriteLine(X);  
            #endregion
            #region Example 02
            //Point P01 = new Point(10,20);

            //Console.WriteLine(P01);



            //Point P02 = new Point(100,200);
            //Console.WriteLine(P02);

            //P02 = P01;

            //Console.WriteLine(P01);
            //Console.WriteLine(P02);

            //P02.X = 300;

            //Console.WriteLine(P01);
            //Console.WriteLine(P02);


            #endregion
            #endregion

            Employee employee = new Employee(salary:5000,name: "Mostafa Hany Mohamed", id: 10);

            //employee.EmpId = 20; // Set Id Direct by Attribute
            //employee.Salary = 20000;
            //Console.WriteLine(employee.EmpId); // Get Id Direct by Attribute

            //employee.SetName("Mostafa Hany Mohamed");
            Console.WriteLine(employee.GetName());

        }

    }
}
