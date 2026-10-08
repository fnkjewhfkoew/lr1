using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           box box = new box();
            box.ширина = 2;
            box.длина = 5;
            box.высота = 3;
            box.show();
            float z = box.per();
            Console.WriteLine($" Объем {z}"); 
        }
    }
   

    class box
    {
        public float ширина;
        public float длина;
        public float высота;
        public void show() 
        {
           Console.WriteLine($"Ширина {ширина}, длина {длина},высотв {высота}");
        }
        public float per()
        {
            return ширина * длина * высота;
        }
    }
}

