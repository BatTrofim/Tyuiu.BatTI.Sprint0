using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BatTI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BatTI.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов из библиотеки DataService и метода GetMessage
            //из библиотеки Tyuiu.BatTI.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Трофим"));
            Console.ReadKey();

        }
    }
}
