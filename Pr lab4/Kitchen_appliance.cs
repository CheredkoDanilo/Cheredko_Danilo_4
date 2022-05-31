using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab4
{
    abstract class Kitchen_appliance
    {
        public double mas { get; set; }
        public string loc { get; set; }
        
        public virtual void location()
        {
            Console.WriteLine($"Прилад знаходиться в {loc}");
        }

        public virtual void move()
        {
            Console.WriteLine($"Вкажіть місце куди ви хочете прекласти прилад з {loc}");
            loc = Console.ReadLine();
            Console.WriteLine($"Прилад переміщено в {loc}");
        }
    }
}
