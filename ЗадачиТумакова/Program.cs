using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗадачиТумакова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Написать программу, которая спрашивает имя
            пользователя, и затем приветствует пользователя по имени*/
            Console.WriteLine("Упражнение 2.1");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);

            /* 2)Написать программу, которой на вход подается два
            целых числа, на выходе – результат деления одного числа на другое.
            Предусмотреть обработку исключительной ситуации, возникающей при
            делении числа на ноль */
            Console.WriteLine("Упражнение 2.2");
            Console.WriteLine("Введите два любых целых числа:");
            float x1 = Convert.ToInt32(Console.ReadLine());
            float x2 = Convert.ToInt32(Console.ReadLine());
            if (x2 == 0)
            { Console.WriteLine("Действие невозможно"); }
            else { Console.WriteLine("Результат деления:" + (x1  / x2)); }

            /* 3) Прочитать букву с экрана и вывести на печать
            следующую за ней букву в алфавитном порядке */
            Console.WriteLine("Домашнее задание 2.1");
            Console.WriteLine("Введите любую прописную букву алфавита:");
            string alfavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяа";
            int letter = alfavit.IndexOf(Console.ReadLine());
            Console.WriteLine(alfavit[letter + 1]);

            /* 4) Написать программу, которая решает квадратное
            уравнение. Входные данные – коэффициенты уравнения, выходные –
            найденные корни */
            Console.WriteLine("Домашнее задание 2.2");
            Console.WriteLine("Введите коэффиценты уравнение:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int discriminant = b * b - 4 * a * c;
            if (discriminant >= 0)
            {
                double z1 = (-1 * b + Math.Sqrt(discriminant)) / (2 * a);
                double z2 = (-1 * b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {z1}, x2 = {z2}");
            }
            else { Console.WriteLine("Нет корней"); }
            Console.ReadKey();  
        }
    }
}
