using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_all_divisions_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number = Console.ReadLine();
            string[] array = Number.Split();
            int[] numbers = new int[array.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
                { 
                    for (int j = 1; j <= numbers[0]; j++)
                    {
                        if (numbers[i] % j == 0)
                        {
 
                            Console.WriteLine(j);
                        }
                        

                    }
                }
            } Console.ReadKey();
        }
    }
}

