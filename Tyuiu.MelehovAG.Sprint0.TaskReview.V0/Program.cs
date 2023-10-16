using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.MelehovAG.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт-ревью #0 | Выполнил: Мелехов А.Г. | ПКТб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая запрашивает числа у        *");
            Console.WriteLine("* пользователя и вычисляет итоговый результат по формуле:                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* (x + y + z) * 5.                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
                Console.Write("* Введите первое число и нажмите клавишу Enter:                          ");
            string firstString = Console.ReadLine();
            int firstArg = Convert.ToInt32(firstString);
            Console.WriteLine("***************************************************************************");
                Console.Write("* Введите второе число и нажмите клавишу Enter:                          ");
            string secondString = Console.ReadLine();
            int secondArg = Convert.ToInt32(secondString);
            Console.WriteLine("***************************************************************************");
                Console.Write("* Введите третье число и нажмите клавишу Enter:                          ");
            string thirdString = Console.ReadLine();
            int thirdArg = Convert.ToInt32(thirdString);
            Console.WriteLine("***************************************************************************");
            int result = DataService.Calc(firstArg, secondArg, thirdArg);
            Console.WriteLine("* Результат выполнения программы: " + result.ToString() + "");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
