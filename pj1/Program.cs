using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CVS_Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "read.csv";
                string[] lines = File.ReadAllLines(s);

                int rowCount = lines.Length;
                int colCount = lines[0].Split(';').Length;
                string[,] array = new string[rowCount, colCount];
                for (int i = 0; i < rowCount; i++)
                {
                    string[] line = lines[i].Split(';');
                    for (int j = 0; j < colCount; j++)
                    {
                        array[i, j] = line[j];
                    }
                }

                Console.WriteLine("Row: " + rowCount + " Col: " + colCount);
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        Console.Write("{0}\t", array[i, j]);
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            
            Console.ReadKey();
        }
    }
}
