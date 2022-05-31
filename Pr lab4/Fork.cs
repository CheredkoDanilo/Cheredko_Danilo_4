using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab4
{
    class Fork : Kitchen_appliance
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
            Console.WriteLine("Бажаєте помити виделку");
            w = Console.ReadLine();
            if (w == "так")
            {
                Console.WriteLine("Виделку помито");
            }
        }

        public Fork()
        {
            mas = 0.1;
            loc = "стіл";
        }

        public Fork(double mas, string loc)
        {
            this.mas = mas;
            this.loc = loc;
        }
    }
}
