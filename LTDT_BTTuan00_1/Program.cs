using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LTDT_BTTuan00_1
{
    class Program
    {
        static void Main(string[] args)
        {
            computeArray(args[0],args[1]);
            Console.ReadLine();
        }
        private static void computeArray(string input_filename, string output_filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(input_filename))
                {
                    string line = sr.ReadLine();
                    int N = int.Parse(line);
                    int[] arr = new int[N];
                    int i;
                    line = sr.ReadLine();
                    string[] s = line.Split(' ');
                    for (i = 0; i < N; i++)
                        arr[i] = int.Parse(s[i]);
                    sr.Close();
                    using (StreamWriter writer = new StreamWriter(output_filename))
                    {
                        int sumEvenNumbers = 0;
                        int multiplyOddNumbers = 1;
                        writer.WriteLine(N);
                        for (i = N - 1; i >= 0; i--)
                        {
                            writer.Write(arr[i] + " ");
                            if (arr[i] % 2 == 0)
                                sumEvenNumbers += arr[i];
                            else
                                multiplyOddNumbers *= arr[i];
                        }
                        writer.WriteLine();
                        writer.WriteLine(sumEvenNumbers);
                        writer.WriteLine(multiplyOddNumbers);
                    }                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
