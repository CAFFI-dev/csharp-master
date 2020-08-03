using System;
using System.Diagnostics;
namespace CAFFI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дарова поц! как твое ничего?");

            while (true)
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
        }
    }
}
