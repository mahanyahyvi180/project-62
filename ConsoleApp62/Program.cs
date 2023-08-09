using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            int shoa = 5;
            const float pi = 3.14f;
            float Mas;
            float Moh;

            Mas = pi * shoa * shoa;
            Moh = 2 * pi * shoa;

            Console.WriteLine("Mohit" + Moh);
            Console.WriteLine("Masahat" + Mas);

            Console.ReadLine();
        }
    }
}
