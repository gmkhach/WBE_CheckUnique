﻿/**
 * Write a function that accepts a string, and returns whether the characters are all unique
 * ie: "hello" will return false, and "plant" will return true
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Enter a string of characters\n\n>>> ");
                    string input = Console.ReadLine();
                    Console.WriteLine("\n" + (IsUnique(input) ? "All characters in the string are unique." : "The String contains doubles."));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static bool IsUnique(string input)
        {
            // using nested loop to compare each character with every other character in the string.
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
