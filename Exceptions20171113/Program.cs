using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exceptions20171113
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };

            try
            {
                int i = GetValueAtIndex(values, 100);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException)
            {
                WriteLine("Invalid index");
            }
            catch (ArgumentNullException ex)
            {
                WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                WriteLine("Please gimme a valid array");
            }
            catch (Exception ex)
            {
                WriteLine("Not a NullReference or IndexOutOfRangeException." 
                    + ex.Message);
            }

            int x = 6;
            int y = 2;

            try
            {
                int z = 0;
                int a = x / y;
                int b = x / z; // exception
                WriteLine($"a = {a}. b = {b}");
            }
            catch (DivideByZeroException)
            {
                WriteLine("At least one divisor = 0. No can do.");
            }

            ReadKey();
        } // End Main()

        private static int GetValueAtIndex(int[] values, int v)
        {
            if (values == null) throw new ArgumentNullException
                    ("Array cannot be null");
            if (v < 0 || v > values.Length)
            {
                throw new ArgumentOutOfRangeException
                    ("Index must be greater than 0 and less than array length");
            } // else v is within range
                
            return values[v];
        }
    }
}
