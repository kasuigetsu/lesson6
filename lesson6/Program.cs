using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] process = Process.GetProcesses();
            Console.WriteLine("ID\t\tName");
            for (int i = 0; i < process.Length; i++)
            {
                Console.WriteLine($"{process[i].Id}\t\t{process[i].ProcessName}");
            }
            try
            {
            Console.Write("\nВведите ID процесса, который желаете завершить: ");
            int processID = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < process.Length; i++)
                {
                    if(processID==process[i].Id)
                    {
                        process[i].Kill();
                    }
                }
            }
            catch(FormatException exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}");
            }
            Console.ReadLine();
        }
    }
}
