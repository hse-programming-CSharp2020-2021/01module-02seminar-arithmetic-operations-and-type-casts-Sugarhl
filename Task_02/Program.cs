/*
 * Задача : 
 * Ввести натуральное трехзначное число Р. 
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 208
 * -------test_2-------
 * 159
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 820
 * -------test_2-------
 * 951
 * --------------------
 */

using System;

namespace Task_02 {
    class Program {
        static void Main(string[] args) {
            int p;
            // TODO : Реализовать ввод целочисленного значения.
            p = ReadInt();

            // TODO : Посчиать и вывести результат.
            Console.WriteLine(MaxPermutation(p));
        }
        public static int ReadInt() {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            return n;
        }

        static int MaxPermutation(int x) {
            // TODO : Получить цифры числа используя арифметические операции.
            int firstDigit = x / 100,
                secondDigit = x / 10,
                thirdDigit = x % 10;
            // TODO : брать новое число и вернуть его. 
            var mx = Math.Max(firstDigit, Math.Max(secondDigit, thirdDigit));
            var mn = Math.Min(firstDigit, Math.Min(secondDigit, thirdDigit));
            var md = firstDigit + secondDigit + thirdDigit - mx - mn;
            int max = mx * 100 + md * 10 + mn;


            return max;
        }
    }
}
