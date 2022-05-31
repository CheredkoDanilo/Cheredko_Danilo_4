using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_lab4
{
    class Microwave : Kitchen_appliance
    {
        private string _v;

        public string v 
        {
            get { return _v; }
            set { if (value == "вкл")
                    _v = value;
                else if (value == "викл")
                    _v = value;
                else _v = "викл";
            } 
        }

        public Microwave()
        {
            mas = 2.7;
            loc = "стільниця";
            _v = "викл";
        }

        public Microwave(double mas, string loc, string v)
        {
            this.mas = mas;
            this.loc = loc;
            this.v = v;
        }

        public void turn_on()
        {
            Console.WriteLine($"Прилад {v}");
            v = Console.ReadLine();
            Console.WriteLine($"Прилад {v}");
        }
    }
}
