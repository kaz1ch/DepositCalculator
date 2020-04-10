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
                Console.Write(Message);
                if (double.TryParse(Console.ReadLine(), out double result))
                    return result;
                Console.WriteLine("Некорректнй ввод данных!");
            }
        }

        static double ReadIntValue(string Message)
        {
            while (true)
            {
                Console.Write(Message);
                if (int.TryParse(Console.ReadLine(), out int result))
                    return result;
                Console.WriteLine("Некорректнй ввод данных!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите суммы вклада.");
            var str = Console.ReadLine();
            ReadDoubleValue(str);
            var AmountOfMoney = double.Parse(str);

            Console.WriteLine("Введите годовой процент по вкладу.");
            str = Console.ReadLine();
            ReadDoubleValue(str);
            var AnnumInterest = double.Parse(str);

            Console.WriteLine("Введите количество времени для вклада в месяцах.");
            str = Console.ReadLine();
            ReadIntValue(str);
            var NumberOfMonths = int.Parse(str);
        }
    }
}
