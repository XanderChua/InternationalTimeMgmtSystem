using System;

namespace InternationalTimeMgmtSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate time from longtitude");
            Console.WriteLine("1) East");
            Console.WriteLine("2) West");       
            
            int input = Int32.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Enter Degree");
                double degree = Double.Parse(Console.ReadLine());
                Console.WriteLine(EastTime(degree));
            }
            if (input == 2)
            {
                Console.WriteLine("Enter Degree");
                double degree = Double.Parse(Console.ReadLine());
                Console.WriteLine(WestTime(degree));
            }
        }
        static DateTime EastTime(double east)
        {
            DateTime dt = DateTime.UtcNow;
            double output = east * 4;
            return dt.AddMinutes(output);
        }
        static DateTime WestTime(double west)
        {
            DateTime dt = DateTime.UtcNow;
            double output = west * 4;
            return dt.Add(new TimeSpan(0, (int)-output, 0));
        }
    }
}
