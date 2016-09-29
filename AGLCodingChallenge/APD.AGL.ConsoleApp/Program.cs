using APD.AGL.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD.AGL.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PeopleServices();
            var cats = service.GetCatByGender("Male");
            Console.WriteLine("Male");
            foreach (var cat in service.GetCatByGender("Male"))
            {
                Console.WriteLine("\t" + cat.Name);
            }
            Console.WriteLine("Female");
            foreach (var cat in service.GetCatByGender("Female"))
            {
                Console.WriteLine("\t" + cat.Name);
            }
            Console.Read();
        }
    }
}
