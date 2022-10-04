using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGrem1
{
    public class Class1
    {
        public static void PrintInfo()
        {
            Console.WriteLine("################################################\n");
            Console.WriteLine("Мельников Никита Александрович\n");
            Console.WriteLine("################################################\n");
            Console.WriteLine("Задача №1----->1\n");
            Console.WriteLine("Задача №2----->2\n");
            Console.WriteLine("Задача №3----->3\n");
            Console.WriteLine("Задача №4----->4\n");
            Console.WriteLine("Выйти--------->1\n");


            Console.WriteLine("################################################\n");
            Console.WriteLine("Введите номер задачи");

        }
        public static void Task1()
        {
            Console.Clear();
            Console.WriteLine("################################################\n");
            Console.WriteLine("Задача 1");
            Console.WriteLine("################################################\n");
            
            Console.WriteLine("Введите чсисло номер 1");
            int Number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите чсисло номер 2");
            int Number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите чсисло номер 3");
            int Number3 = int.Parse(Console.ReadLine());

            int NumberMin = 0;
            if (Number1 < Number2 & Number1 < Number3)
            {
                NumberMin = Number1;
            } else if (Number2 < Number1 & Number2 < Number3)
            {
                NumberMin = Number2;
            } else  {
                NumberMin = Number3;
            };


            Console.Write("минимальное число равно   ", NumberMin);
            Console.WriteLine(NumberMin);
            Console.ReadLine();
        }
        public static void Task2()
        {
            Console.Clear();
            Console.WriteLine("################################################\n");
            Console.WriteLine("Задача 2");
            Console.WriteLine("################################################\n");

            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);
            Console.ReadKey();
           
        }
        public static void Task3()
        {
            Console.Clear();
            Console.WriteLine("################################################\n");
            Console.WriteLine("Задача 3");
            Console.WriteLine("################################################\n");

            int b = 0;
            while (true)
            {
                int a = Convert.ToInt16(Console.ReadLine());

                if (a != 0)
                {
                    if (a % 2 == 0)
                    {
                    
                    }
                    else
                        b += a;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
        public static void Task4()
        {
            Console.Clear();
            Console.WriteLine("################################################\n");
            Console.WriteLine("Задача 1");
            Console.WriteLine("################################################\n");

            string login = "root";
            string password = "GeekBrains";

            int count = 0;
            do
            {
                Console.WriteLine("\nВведите логин: ");
                string checkLogin = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string checkPassword = Console.ReadLine();

                if (login == checkLogin && password == checkPassword)
                {

                    Console.WriteLine("Добро пожаловать");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Неверно введен логин или пароль");
                Console.ReadLine();
                ++count;
            } while (count < 3);
            
            Console.ReadKey();
        }
        public static void TaskExit()
        {
            Console.Clear();
        }
    } 
}
