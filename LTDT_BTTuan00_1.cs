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
            string input_filename = args[0];
            readArray(input_filename);
        }
        private static void readArray(string input_filename)
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
                    Console.WriteLine(N);
                    for (i = N - 1; i >= 0; i--)
                        Console.Write(arr[i] + " ");
                    Console.WriteLine();
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
