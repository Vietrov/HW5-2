using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            {
                Console.WriteLine("Введите начало диапазона:");
                int start = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите конец диапазона:");
                int end = int.Parse(Console.ReadLine());

                int sumEven = 0;  // сумма четных чисел
                int countEven = 0;  // количество четных чисел

                int sumOdd = 0;  // сумма нечетных чисел
                int countOdd = 0;  // количество нечетных чисел

                int sumMultiplesOf9 = 0;  // сумма чисел, кратных 9
                int countMultiplesOf9 = 0;  // количество чисел, кратных 9

                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)  // четное число
                    {
                        sumEven += i;
                        countEven++;
                    }
                    else  // нечетное число
                    {
                        sumOdd += i;
                        countOdd++;
                    }

                    if (i % 9 == 0)  // число, кратное 9
                    {
                        sumMultiplesOf9 += i;
                        countMultiplesOf9++;
                    }
                }

                // Вывод результатов
                Console.WriteLine($"Сумма четных чисел: {sumEven}");
                Console.WriteLine($"Среднее арифметическое четных чисел: {(countEven == 0 ? 0 : (double)sumEven / countEven)}");

                Console.WriteLine($"Сумма нечетных чисел: {sumOdd}");
                Console.WriteLine($"Среднее арифметическое нечетных чисел: {(countOdd == 0 ? 0 : (double)sumOdd / countOdd)}");

                Console.WriteLine($"Сумма чисел, кратных 9: {sumMultiplesOf9}");
                Console.WriteLine($"Среднее арифметическое чисел, кратных 9: {(countMultiplesOf9 == 0 ? 0 : (double)sumMultiplesOf9 / countMultiplesOf9)}");
            }
        }


    }
    
}
