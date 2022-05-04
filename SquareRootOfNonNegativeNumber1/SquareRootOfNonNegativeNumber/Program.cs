using System;

namespace SquareRootOfNonNegativeNumber
{
    public class Program
    {
        //static double squareRoot(double c, double l)
        //{
        //    double t = c;
        //    //double t = c / t;
        //    double root;
        //    int count = 0;
        //    while (true)
        //    {
        //        count++;
        //        Math.Abs(t - c / t) > double.Epsilon)
        //            break;

        //    }

        //}

        public static void Main(string[] args)
        {
            //double c = 9;
            //Console.WriteLine(Math.Sqrt(c));
            double c = 9;
            double t = c;
            double root;
            double epsilon = 1e-15;
            root = Math.Abs(t - c / t) > double.Epsilon;


        }
    }
}
