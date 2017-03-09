using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommonDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string Number = sr.ReadLine();
            string[] array = Number.Split();
            int[] numbers = new int[array.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
                {
                    for (int j = 1; j <= numbers[i]; j++)
                    {
                        if (numbers[i] % j == 0)
                        {
                        }
                        {
                            for (int z = 1; z <= numbers[i]; z++)
                            {
                                if (numbers[i] % z == 0)
                                {
                                    if (j == z)
                                    {
                                        sw.WriteLine(j);
                                        sw.WriteLine(z);
                                        sw.Close();
                                    }
                                }
                            }


                        }
                        
                    }
                }
            }
        }
    }
}
