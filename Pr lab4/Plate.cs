using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab4
{
    class Plate : Kitchen_appliance
    {
        private string _w;

        public string w
        {
            get { return _w; }
            set
            {
                if (value == "так")
                    _w = value;
                else if (value == "ні")
                    _w = value;
                else _w = "ні";
            }
        }

        public void wash()
        {
            Console.WriteLine("Бажаєте помити тарілку");
            w = Console.ReadLine();
            if (w == "так")
            {
                Console.WriteLine("Тарілку помито");
            }
        }

        public Plate()
        {
            mas = 0.5;
            loc = "стіл";
        }

        public Plate(double mas)
        {
            this.mas = mas;
            this.loc = loc;
        }
    }
}
