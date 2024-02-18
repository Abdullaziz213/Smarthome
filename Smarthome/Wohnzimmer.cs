using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    public class Wohnzimmer
    {
        /// <summary>
        /// Wohnzimmer wird erstellt
        /// </summary>
        public string Ambientebeleuchtung { get; set; } 

        public void PrintStatus()
        {
            Console.WriteLine($"Wohnzimmer - Ambientebeleuchtung: {Ambientebeleuchtung}");
        }
    }
}
