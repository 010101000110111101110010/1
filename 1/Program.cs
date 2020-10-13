using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib1;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            lib asd = new lib();
            lib.sloj(3,4);
            lib.vichet(4, 56);
            lib.age(35);
            Console.WriteLine("Введите новый логин:");
            Console.WriteLine($"Ваш новый логин - {lib.newlogin()}");
            Console.WriteLine("Нахождение дискриминанта: введите a, b, c");
            Console.WriteLine($"D={lib.D()}");
            Console.ReadLine();
        }
    }
}
