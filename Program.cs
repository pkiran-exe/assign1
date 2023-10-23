using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    string path = @"D:\KP\Practiceproject1\Retrieve\Private_School.txt";
                    string[] lines2 =File.ReadAllLines(path);
                    Console.WriteLine("The Students Data are \n");
                    int index = 1;
                    foreach (string line in lines2)
                        Console.WriteLine($"  {index++} : " + line);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("All the Students data in the files are Displayed.");

                }
            }
            Console.ReadLine();
        }
    }
}
