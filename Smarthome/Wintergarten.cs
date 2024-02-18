using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class Wintergarten
    {
        /// <summary>
        /// Wintergarten wird erstellt.
        /// </summary>
        public double Sonneneinstrahlung { get; set; }

        public void PrintStatus()
        {
            Console.WriteLine($"Wintergarten - Sonneneinstrahlung: {Sonneneinstrahlung} Lux");
        }
    }
}
