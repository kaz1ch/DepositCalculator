using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    class Program
    {
        static double ReadDoubleValue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                if (double.TryParse(Console.ReadLine(), out double result))
                    return result;
                Console.WriteLine("Некорректный ввод данных!");
            }
        }

        static int ReadIntValue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;
                Console.WriteLine("Некорректный ввод данных!");
            }
        }

        static double InterestCounter(double Amount, double AnnumInterest, int MonthsCount)
        {
            double ResultAmount = Amount;
            MonthsCount /= 12;
            int i = 0;
            while (i < MonthsCount)
            {
                ResultAmount *= AnnumInterest;
                i++;
            }
            return ResultAmount;
        }

        static void Main(string[] args)
        {
            var AmountOfMoney = ReadDoubleValue("Введите суммы вклада.");

            var AnnumInterest = ReadDoubleValue("Введите годовой процент по вкладу.") / 100 + 1;

            var MonthsCount = ReadIntValue("Введите количество времени для вклада в месяцах.");

            var ResultAmount = InterestCounter(AmountOfMoney, AnnumInterest, MonthsCount);
            var Income = ResultAmount - AmountOfMoney;
            var EffectiveInterst = (ResultAmount / AmountOfMoney - 1) * 100;

            Console.WriteLine("Итогоая сумма денег будет равна {0}, доход равняется {1}, эффективный процент по вкладу - {2}.", ResultAmount, Income, EffectiveInterst);
            Console.ReadLine();
        }
    }
}
