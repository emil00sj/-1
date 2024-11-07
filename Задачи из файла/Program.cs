using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_из_файла
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            /* 1) Вывести на экран число e(основание натурального логарифма) с точностью до десятых */
            Console.WriteLine("номер 1");
            Console.WriteLine("e = 2.7");

            /* 2) Вывести на экран числа 50 и 10 одно под другим */
            Console.WriteLine("номер 2");
            Console.WriteLine(50);
            Console.WriteLine(10);

            /* 3) Составить программу вывода на экран «столбиком» четырех любых чисел */
            Console.WriteLine("номер 3");
            Console.WriteLine(11);
            Console.WriteLine(22);
            Console.WriteLine(454);
            Console.WriteLine(1001);

            /* 4) Пользователь вводит число. Выведите на экран число, которое больше введенного на 10 */
            Console.WriteLine("номер 4");
            Console.WriteLine("Введите любое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + 10);

            /* 5) Дана сторона квадрата. Найти его периметр */
            Console.WriteLine("номер 5");
            Console.WriteLine("Введите сторону квадрата");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Периметр равен: {side*4}");

            /* 6) Дан радиус окружности. Найти длину окружности и площадь круга */
            Console.WriteLine("номер 6");
            Console.WriteLine("Укажите радиус окружности: ");
            int rad = Convert.ToInt32(Console.ReadLine());
            double lenn = 2*Math.PI*rad;
            double circle = Math.PI*rad*rad;
            Console.WriteLine($"Длинна окружности = {lenn}, площадь круг = {circle}");
            Console.ReadKey();


        }
    }
}
