using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        List<DNA> dnaList = new List<DNA>();
        dnaList.Add(new DNA("ACGT"));
        dnaList.Add(new DNA("GCTTAC"));
        dnaList.Add(new DNA("CGTTAGCTT"));
        dnaList.Add(new DNA("TACA"));
        
        Console.WriteLine("What is the minimum sequence length?");
        var minSequenceLength = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("The filtered list:");
        for (int i = 0; i < dnaList.Count; i++)
        {
            var dna = dnaList.ToArray()[i];
            if (dna.Seq.Length >= minSequenceLength)
            {
                Console.WriteLine(dna.Seq);
            }
        }
    }
}