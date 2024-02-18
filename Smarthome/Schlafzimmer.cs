using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class Schlafzimmer
    {
        public DateTime Weckzeit { get; set; }

        public void PrintStatus()
        {
            Console.WriteLine($"Schlafzimmer - Weckzeit: {Weckzeit}");
        }
    }
}
