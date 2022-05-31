using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab4
{
    class Dishes : Kitchen_appliance
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

        public Dishes()
        {
            mas = 2.1;
            loc = "шафа";
        }

        public Dishes(double mas, string loc)
        {
            this.mas = mas;
            this.loc = loc;
        }

        public void wash()
        {
            Console.WriteLine("Бажаєте помити посуд");
            w = Console.ReadLine();
            if (w == "так")
            {
                Console.WriteLine("Посуд помито");
            }
        }
    }
}
