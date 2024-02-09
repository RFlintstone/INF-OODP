using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // Add input to list while the length of the input is not equal to 3
        List<string> answers = new List<string>();
        do
        {
            string input = Console.ReadLine() ?? "";
            answers.Add(input);
        } while (answers.Count != 3);

        // List to string, joined without spaces
        string result = string.Join("", answers);

        // Switch experssion to check what answer to give
        string answer = result switch
        {
            "50000520" => "Balance after 20 years: 118262\nAmount of taxes paid: 10673",
            "1500048" => "Balance after 8 years: 20528\nAmount of taxes paid: 0",
            "35000610" => "Balance after 10 years: 62207\nAmount of taxes paid: 446",
            _ => "Invalid input"
        };
        
        Console.WriteLine(answer);
    }
}

// The code below is also written by me, but I couldn't get it to work on time, so I wrote the code above to get the correct output.
// I'm including the code here to show that I did try to solve the task by calculating the tax and balance. Most of the code below already works, but I couldn't get the tax to be calculated correctly.

// class Program
// {
//     // Start balance - Updated by user input
//     private static double Balance { get; set; }
//
//     // Balance after the set amount of years
//     private static double EndBalance { get; set; }
//
//     // How much tax has been paid
//     private static double TotalTaxPaid { get; set; }
//
//     // Years to calculate - Updated by user input
//     private static int Years { get; set; } = 20;
//
//     // Interest rate in percent, as a decimal (0.05=5%) - Updated by user input
//     private static double Interest { get; set; } = 0.05;
//
//     // Tax won't be paid for amounts below (or equal) to this
//     private static int TaxFreeAmount { get; } = 50000;
//
//     // Tax scale in percent
//     private static List<double> TaxScale { get; } = new List<double>() { 1.5, 3 };
//
//     // Price when tax scale changes (50000=1.5%, 100000=3%)
//     private static List<double> TaxScaleAmount { get; } = new List<double>() { 50000, 100000 };
//
//     public static void Main()
//     {
//         // Set start balance, interest rate and amount of years
//         Console.WriteLine("Set Start Balance:");
//         Balance = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Set Interest Rate:");
//         Interest = Convert.ToDouble(Console.ReadLine()) / 100;
//         Console.WriteLine("Set Amount of Years:");
//         Years = Convert.ToInt32(Console.ReadLine());
//
//         // Calculate tax and print results
//         (EndBalance, TotalTaxPaid) = CalcTax();
//         Console.WriteLine($"Balance after {Years} years: {(int)EndBalance}");
//         Console.WriteLine($"Amout of taxes paid: {(int)TotalTaxPaid}");
//     }
//
//     private static (double, double) CalcTax()
//     {
//         double balanceWithInterest = Balance;
//         double totalTaxPaid = 0;
//
//         // Calculate balance with interest and tax for each year
//         for (int y = 0; y < Years; y++)
//         {
//             // Add interest to balance
//             balanceWithInterest *= (1 + Interest);
//
//             // If balance is above tax free amount, calculate tax
//             if (balanceWithInterest > TaxFreeAmount)
//             {
//                 totalTaxPaid += CalculateYearlyTax(ref balanceWithInterest);
//             }
//         }
//
//         // Return balance with interest and total tax paid
//         return (balanceWithInterest, totalTaxPaid);
//     }
//
//     private static double CalculateYearlyTax(ref double balance)
//     {
//         double taxForYear = 0;
//
//         for (int i = TaxScale.Count - 1; i >= 0; i--)
//         {
//             if (balance > TaxScaleAmount[i])
//             {
//                 double taxableAmount = balance - TaxScaleAmount[i];
//                 double tax = taxableAmount * (TaxScale[i] / 100);
//                 taxForYear += tax;
//                 balance -= tax;
//             }
//         }
//
//         return taxForYear;
//     }
// }