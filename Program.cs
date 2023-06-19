using System;
using System.IO;

namespace Project
{
    class Program
    {

        static void Main(string[] args)
        {
            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            void MultipleOfThree(int number, int count = 1)
            {
                if (count > number) return;
                if (count % 3 == 0)
                {
                    Console.Write($"{count}, ");
                }
                count++;
                MultipleOfThree(number, count);
            }
            void Task64()
            {
                //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который
                //выведет все натуральные числа кратные 3-ём в промежутке от M до N.
                //M = 1; N = 9. -> "3, 6, 9"
                //M = 13; N = 20. -> "15, 18"
                int count = Input("Введите значение M: ");
                int number = Input("Введите значение N: ");
                MultipleOfThree(number, count);

            }
            int SumOfNumbers(int count, int number, int sum)
            {
                if (count > number) return sum;
                sum += count;
                count++;

                return SumOfNumbers(count, number, sum);
            }
            void Task66()
            {
                //Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который
                //найдёт сумму натуральных элементов в промежутке от M до N.
                //M = 1; N = 15 -> 120
                //M = 4; N = 8. -> 30
                int count = Input("Введите значение M: ");
                int number = Input("Введите значение N: ");
                int sum = 0;
                int res = 0;
                res = SumOfNumbers(count, number, sum);
                Console.WriteLine($"Сумма цифр в промежутке от {count} до {number} равна {res}");

            }
            int A(int m, int n)
            {
                if (m == 0) return n + 1;
                // else if (n == 0 && m > 0) return funAckerman(m - 1, 1);
                else if (n == 0) return A(m - 1, 1);
                else return A(m - 1, A(m, n - 1));
            }
            void Task68()
            {
                //Задача 68: Напишите программу вычисления функции Аккермана с помощью
                //рекурсии. Даны два неотрицательных числа m и n.
                //m = 3, n = 2 -> A(m,n) = 29
                int m = Input("Введите значение m: ");
                int n = Input("Введите значение n: ");
                int Ackermann = A(m, n);

                Console.Write($"Функция Аккермана = {Ackermann} ");
            }
        }
    }
}
