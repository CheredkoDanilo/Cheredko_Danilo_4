using System;

namespace Pr_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Microwave m = new Microwave();
            m.location();
            m.move();
            m.location();
            m.turn_on();
            m.turn_on();
            Dishes d = new Dishes();
            d.location();
            d.wash();
            Console.ReadKey();
        }
    }
}
