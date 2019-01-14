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
            computeMatrix(args[0], args[1]);
            Console.ReadLine();
        }
        private static void computeMatrix(string input_filename, string output_filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(input_filename))
                {
                    string line = sr.ReadLine();
                    int N = int.Parse(line);
                    int[,] arr = new int[N, N];
                    int rowIndex, colIndex;
                    int sIndex = 0;
                    line = sr.ReadToEnd().Replace("\r\n", " ");
                    string[] s = line.Split(' ');
                    while (sIndex < N * 2)
                    {
                        for (rowIndex = 0; rowIndex < N; rowIndex++)
                            for (colIndex = 0; colIndex < N; colIndex++)
                            {
                                arr[rowIndex, colIndex] = int.Parse(s[sIndex]);
                                sIndex++;
                            }
                    }
                    sr.Close();
                    using (StreamWriter writer = new StreamWriter(output_filename))
                    {
                        writer.WriteLine(N);
                        for (colIndex = 0; colIndex < N; colIndex++)
                        {
                            for (rowIndex = 0; rowIndex < N; rowIndex++)
                                writer.Write(arr[rowIndex, colIndex] + " ");
                            writer.WriteLine();
                        }
                        for (colIndex = 0; colIndex < N; colIndex++)
                        {
                            for (rowIndex = 0; rowIndex < N; rowIndex++)
                                if (colIndex == rowIndex)
                                    writer.Write(arr[rowIndex, colIndex] + " ");
                        }
                        writer.WriteLine();
                        writer.WriteLine("This is an Asymmetric matrix");
                        //Because we add a new line after a Symmetric matrix,
                        //so we always have a new Asymmetric matrix 
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
