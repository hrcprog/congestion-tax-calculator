using congestion.calculator;
using Services;
using System;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            

            CongestionTaxCalculator calculator = new CongestionTaxCalculator();
            Vehicle vehicle = new Motorbike();
            DateTime[] dates = { DateTime.Parse("2013-01-14 21:00:00") };
           
            var res =calculator.GetTax(vehicle, dates);

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
