using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class BadWC
    {
        public double Feuchtigkeit { get; set; }

        public void PrintStatus()
        {
            Console.WriteLine($"Bad/WC - Feuchtigkeit: {Feuchtigkeit}%");
        }
    }
}
