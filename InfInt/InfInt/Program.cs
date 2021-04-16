using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // array of strings (Infints)      
            string[] lines = System.IO.File.ReadAllLines(@"infint.txt");

            var A = new InfInt(); // first operand
            var B = new InfInt(); // second operand
            string op = " ";      // operator

            for (int i = 0; i < lines.Length; i++)
            {
                // get first operand
                if (i % 3 == 0) 
                {
                    A = new InfInt(lines[i]); 
                }
                // get second operand
                else if (i % 3 == 1) 
                {
                    B = new InfInt(lines[i]);
                }
                // get operator
                else 
                {
                    op = lines[i];
                    if (op == "+")
                    {
                        Console.WriteLine($" A + B --> {A}{op}{B} = {A.Plus(B)}");
                    }
                    else if (op == "-")
                    {
                        Console.WriteLine($" A - B --> {A}{op}{B} = {A.Minus(B)}"); 
                    }
                    else
                    {
                        Console.WriteLine($" A * B --> {A}{op}{B} = {A.Times(B)}"); 
                    }
                }
            }
        }
    }
}
