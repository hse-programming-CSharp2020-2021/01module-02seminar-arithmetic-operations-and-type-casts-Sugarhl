/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;

namespace Task_4 {
    class Program {
        static void Main(string[] args) {
            int x;
            // TODO : Считать целочисленное значение.
            int.TryParse(Console.ReadLine(), out x);
            // TODO : Вычислить значение и вывести.
            Console.WriteLine(ReverseNumber(x));
        }

        static int ReverseNumber(int x) {
            // Предлагается 2 решения данной задачи : 
            // 1) Выделить каждую цифру в отдельную переменную и собрать их в обратном порядке.
            // 2) Преобразовать переменную в строку использовать метод Reverse и выполнить обратное преобразование.
            // Выбор метода остаётся за вами.
            int firstDifit = x / 1000;
            int secondDifit = x % 1000 / 100;
            int thirdDifit = x % 100 / 10;
            int fourthDifit = x % 10;
            int answer = fourthDifit * 1000 + thirdDifit * 100 + secondDifit * 10 + firstDifit;
            return answer;
        }
    }
}
