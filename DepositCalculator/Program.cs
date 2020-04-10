using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите суммы вклада.");
            var str = Console.ReadLine();
            var AmountOfMoney = double.Parse(str);

            Console.WriteLine("Введите годовой процент по вкладу.");
            str = Console.ReadLine();
            var AnnumInterest = double.Parse(str);

            Console.WriteLine("Введите количество времени для вклада в месяцах.");
            str = Console.ReadLine();
            var NumberOfMonths = int.Parse(str);
        }
    }
}
