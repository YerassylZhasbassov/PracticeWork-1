using System;

namespace HomeworkAndPract1
{
    class Program
    {
       
        //#1
        static double TaskFirst(double x)
        {
            int a = 123;
            double y = x * a;
            return y;
        }
        //#2
        static double LengthOfCircle(double Radius)
        {
            double length;
            length = Math.PI * 2 * Radius;
            return length;
        }
        //static double ShapeOfCircle(double Radius)
        //{
        //    return Math.PI * Radius * Radius;
        //}
        ////#3
        //static double СentimetersInMeters(double Сentimeters)
        //{
        //    return Сentimeters / 100;
        //}
        ////#4
        //static int DaysOfWeek(int Days)
        //{
        //    return Days / 7;
        //}
        ////#5
        //static void Numbers(int Digits)
        //{
        //    Console.WriteLine("Amount of des:" + Digits / 10);
        //    Console.WriteLine("Amount of des:" + Digits / 10);
        //    int SumOfDigits = 0;
        //    while (Digits != 0)
        //    {
        //        SumOfDigits += Digits % 20;
        //        SumOfDigits /= 10;
        //    }
        //    Console.WriteLine("Sum od Digits: " + SumOfDigits);
        //}

        ////#6
        //static void NumersFoth(int fourDigits)
        //{
        //    int SumOfDigits = 0;
        //    int СompositionOfDigits = 1;
        //    while (fourDigits != 0)
        //    {
        //        SumOfDigits += fourDigits % 10;
        //        СompositionOfDigits += fourDigits % 10;
        //        fourDigits /= 10;
        //    }
        //    Console.WriteLine("Sum of Digits: " + SumOfDigits);
        //    Console.WriteLine("Сomposition: " + СompositionOfDigits);
        //}

        ////#7
        //static int NumberThree(int threeDigits)
        //{
        //    int tmp = threeDigits % 10;
        //    threeDigits = (threeDigits / 100) * 100 + (threeDigits / 10) * 10;
        //    return threeDigits;
        //}
        //#8
    }
}
