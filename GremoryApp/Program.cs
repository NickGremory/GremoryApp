using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using LibraryGrem1;


namespace GremoryApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Class1.PrintInfo();
            int TaskNumber = int.Parse(Console.ReadLine());


            switch (TaskNumber)
            {
                case 1:
                     Class1.Task1();
                     break;

                case 2:
                    Class1.Task2();
                    break;

                case 3:
                    Class1.Task3();
                    break;

                case 4:
                    Class1.Task4();
                    break;

                    
                    
            }
            Console.ReadKey();

        }
     
    }
}
