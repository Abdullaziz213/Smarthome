using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal class Heizungsventil
    {

        /// <summary>
        /// Heizungsventil wird erstellt.
        /// </summary>
        /// 

        private bool heizungsventilOffen;

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            /
            if (wetterdaten.Aussentemperatur < 15)
            {
                heizungsventilOffen = true;
                Console.WriteLine("Heizungsventil: Heizen");
            }
            else
            {
                heizungsventilOffen = false;
                Console.WriteLine("Heizungsventil: Stop Heizen");
            }
        }
    }
}
