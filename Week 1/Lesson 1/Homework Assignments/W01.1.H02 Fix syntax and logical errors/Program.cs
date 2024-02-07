using System;

namespace W01._1.H02_Fix_syntax_and_logical_errors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double discount = 0.1;
            int price = 55;
            double discountPrice = price * (1 - discount);

            string message = $"The discount price is {discountPrice}";
            Console.WriteLine(message);
        }
    }
}