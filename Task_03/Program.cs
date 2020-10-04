/*
 * Задача : 
 * Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. 
 * Корни выводит с точностью до 2-х знаков после запятой.
 * Учесть (как хотите) возможность появления комплексных корней.
 * !!! Оператор if не применять. !!!
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5
 * 13
 * 6
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -0,60
 * -2,00
 * -------test_2-------
 * complex roots
 * --------------------
 * 
 * Корни выводятся в отдельных строках. Если нет вещественных вывести сообщение "complex roots"
 */

using System;
using System.Globalization;

namespace Task_03 {
    class Program {
        const string complexRootsMessage = "complex roots";
        static void Main(string[] args) {
            // TODO : Сменить локаль на "ru-RU". 
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            double a, b, c;
            // TODO : Считать коэффициенты.
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double discriminant = b * b - 4 * a * c;

            // TODO : Проверить существование вещественных корней, если их нет, 
            // записать в результирующую строку complexRootsMessage.
            // А если корни есть, то записать их.
            string result = (discriminant > 0) ?
                ((-b + Math.Sqrt(discriminant)) / 2 / a).ToString()
                + ((-b + Math.Sqrt(discriminant)) / 2 / a).ToString() : complexRootsMessage;

            Console.WriteLine(result);
        }
    }
}
