using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grandmothersLine;
            int onePersonTimeMinute = 10;
            int hourLine;
            int minuteLine;
            int minute = 60;

            Console.Write(" Введите кол-во людей ");
            grandmothersLine = Convert.ToInt32(Console.ReadLine());
            hourLine = grandmothersLine * onePersonTimeMinute / minute;
            minuteLine = grandmothersLine * onePersonTimeMinute % minute;
            Console.WriteLine(" Время ожидания " + (hourLine) + " часов " + (minuteLine) + " минут ");
        }
    }
}
