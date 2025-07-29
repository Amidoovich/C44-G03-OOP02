namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P01; // declare variable from point data type
            // CLR will Allocate 8 Unintialized Bytes in Stack
            //== int X;

            //P01 = new Point();
            //// new => just for constructor selection that will used to initialize P01 Attributes

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            P01 = new Point(10);
            // new => just for constructor selection that will used to initialize P01 Attributes

            Console.WriteLine(P01.X);
            Console.WriteLine(P01.Y);

            Console.WriteLine(P01);
            Console.WriteLine(P01.ToString());

            int X = 5;
            Console.WriteLine(X);


        }
    }
}
