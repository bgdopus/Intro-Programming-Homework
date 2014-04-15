using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgrammingHomework
{
    class CurrentDateTime
    {
        static void Main(string[] args)
        {
            string dateString = DateTime.Now.ToString();
            Console.WriteLine(dateString);
            
        }
    }
}
