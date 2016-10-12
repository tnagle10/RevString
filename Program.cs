using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program will take input from the user and enter it into a character array.  
//It will then reverse the order of the character array and output to screen
//Tom Nagle 10/12/2016
//All rights reserved.
namespace RevString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            while (line != "q")
            {
                Console.WriteLine("This program will reverse whatever you enter.  Please enter some input to begin. (Type q to quit)"); // Prompt
                line = Console.ReadLine(); // Get string from user
                if (line == "q") // Check string
                {
                    Console.WriteLine("You pressed q");
                    Console.WriteLine("Are you sure you want to exit? (Type q to confirm)");
                    line = Console.ReadLine(); // Get string from user        
                    if (line == "q")
                    { return; }

                }
                char[] arr = line.ToCharArray();
                Array.Reverse(arr);
                var space = "\n";
                Console.WriteLine(arr);
                Console.WriteLine(space);
            }

        }
     }    
}
