using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan
{
    class Money
    {
        
        public int nominal;
        public int Nominal
        {
            get { return nominal; }
            set
            {
                if (value == 1 || value == 2 || value == 5 || value == 10 || value == 50 || value == 100 || value == 200 || value == 500 || value == 1000 || value == 2000 || value == 5000)
                    nominal = value;
            }
        }

        public double Quantity { get; set; }
        public double Sum { get; set; }
    }
}
