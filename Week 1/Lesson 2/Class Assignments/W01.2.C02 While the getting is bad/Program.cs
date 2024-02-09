using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        var fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);

        string confirm = "";

        do
        {
            if (confirm.Equals("n"))
            {
                break;
            }

            if (!confirm.Equals("y"))
            {
                Console.WriteLine("Really delete this file? (y/n)");
            }

            confirm = Console.ReadLine() ?? "n";
        } while (confirm != "y");

        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
    }
}