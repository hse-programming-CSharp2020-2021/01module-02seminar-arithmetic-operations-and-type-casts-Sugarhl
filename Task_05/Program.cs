/*
 * Задача : 
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
 * Если оно выполняется, то вычислить площадь этого треугольника. 
 * !!! Оператор if не применять. !!!
 * Точность вывода три знака после запятой.
 * 
 * Если неравенство треугольника не выполняется, то вывести сообщение : "not a triangle"
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5,3
 * 13
 * 6,123
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * not a triangle
 * -------test_2-------
 * 2,905
 * --------------------
 *	
 */

using System;
using System.Globalization;

namespace Task_05 {
    class Program {
        const string notTriangleMessage = "not a triangle";

        static void Main(string[] args) {
            // TODO : Сменить локаль на "ru-RU". 
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

            double a, b, c;
            // TODO : Считать 3 стороны треугольника.
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);

            // TODO : Проверить неравенство треугольника и поместить в 
            // результирующую строку notTriangleMessage 
            // или площадь треугольника.
            var mx = Math.Max(a, Math.Max(b, c));
            var perimeter = a + b + c;
            string result = (perimeter - 2 * mx > 0) ? $"{Square(a, b, c):f3}" : notTriangleMessage;


            Console.WriteLine(result);
        }

        static double Square(double a, double b, double c) {
            // TODO : Реализоать вычисление площади по формуле Герона. Ну или что-нибудь более извращённое 🙃.
            var perimeter = a + b + c;
            return Math.Sqrt(perimeter / 2 * (perimeter / 2 - a) * (perimeter / 2 - b)
                   * (perimeter / 2 - c));
        }
    }
}
