using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlphabetically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> users = new List<string> {"Абдулхаким", "Магомед", "Виктор", "Разият", "Екатерина", "Антон"};
            var orderedUser = from name in users orderby name select name;
            foreach (var name in orderedUser)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
        
    }
}
