using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfter10Y
{
    class AgeAfter10Y
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your Birthday (date.month.year)=>");
            DateTime YourBirthDay = DateTime.Parse(Console.ReadLine());
            DateTime TimeNow = DateTime.Today;
            int CurrentAge = TimeNow.Year - YourBirthDay.Year;
            Console.WriteLine("You are "+CurrentAge+" years old.");
            Console.WriteLine("After 10 years you are going to be on "+(CurrentAge + 10));
        }
    }
}
