using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static double GetFactorial(double Num)
        {
            double Factorial = 1;
            
                for (int i = 2; i <= Num; i++)
                {
                    Factorial *= i;
                }

                return Factorial;

        }
        static void Main(string[] args)
        {
            string Again = "да";
            do
            {
                Console.WriteLine("Выберите действие, которое хотите выполнить: " +
                              "\n 1. Сложить 2 числа " +
                              "\n 2. Вычесть первое из второго " +
                              "\n 3. Перемножить два числа " +
                              "\n 4. Разделить первое на второе " +
                              "\n 5. Возвести в степень N первое число " +
                              "\n 6. Найти квадратный корень из числа " +
                              "\n 7. Найти 1 процент от числа " +
                              "\n 8. Найти факториал от числа " +
                              "\n 9. Выйти из программы ");
                int Action = Convert.ToInt32(Console.ReadLine());

                if (Action <= 4)
                {
                    Console.WriteLine("Введите первое число");
                    double Num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double Num2 = Convert.ToDouble(Console.ReadLine());
                    switch (Action)
                    {
                        case 1:
                            Console.WriteLine($"Сумма: {Num1} + {Num2} = {Num1 + Num2} ");
                            break;
                        case 2:
                            Console.WriteLine($"Разность: {Num1} - {Num2} = {Num1 - Num2} ");
                            break;
                        case 3:
                            Console.WriteLine($"Произведение: {Num1} * {Num2} = {Num1 * Num2} ");
                            break;
                        case 4:
                            Console.WriteLine($"Результат деления: {Num1} / {Num2} = {Num1 / Num2} ");
                            break;
                    }
                }
                else if (Action > 5 && Action <= 8)
                {
                    Console.WriteLine("Введите число: ");
                    double Num = Convert.ToDouble(Console.ReadLine());
                    switch (Action)
                    {
                        case 6:
                            Console.WriteLine($"Квадратный корень из {Num} = {Math.Sqrt(Num)} ");
                            break;
                        case 7:
                            Console.WriteLine($"1% от {Num} = {Num / 100} ");
                            break;
                        case 8:
                            if (Num > 0)
                            {
                                Console.WriteLine($"Факториал от {Num} = {GetFactorial(Num)}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка");
                            }

                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                }
                else if (Action == 5)
                {
                    Console.WriteLine("Введите число: ");
                    double Num = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень, в которую вы хотите возвести число: ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат возведения {Num} в степень {N} = {Math.Pow(Num, N)} ");
                }
                else if (Action == 9)
                {
                    Console.WriteLine("Вы успешно вышли из программы");
                }
                Console.WriteLine("Хотите попробовать еще раз?(Да/Нет) ");
                Again = Console.ReadLine();
            } while (Again.ToLower() == "да");
        }
    }
}
