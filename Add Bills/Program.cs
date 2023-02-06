using System;
using System.IO;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("1. Add New Bill");
                Console.WriteLine("2. View All Bills");
                Console.WriteLine("3. N/A");
                Console.WriteLine("4. Quit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You selected Option 1");
                        AddNewBill();
                        break;
                    case 2:
                        Console.WriteLine("You selected Option 2");
                        ExtractVariablesFromFile();
                        break;
                    case 3:
                        Console.WriteLine("You selected Option 3");
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        static void ExtractVariablesFromFile()
        {
            string file = @"C:\Users\Eric\Documents\bills.txt";

            // Extract variables from the file
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                string variable = parts[0].Trim();
                string value = parts[1].Trim();

                Console.WriteLine("Variable: " + variable + ", Value: " + value);
            }
        }

        static void AddNewBill()
        {
            string file = @"C:\Users\Eric\Documents\bills.txt";

            Console.Write("Enter Bill: ");
            string newVariable = Console.ReadLine();
            Console.Write("Enter Amount: ");
            string newValue = Console.ReadLine();

            string newLine = newVariable + " = " + newValue;
            File.AppendAllText(file, newLine + Environment.NewLine);
        }
    }
}
