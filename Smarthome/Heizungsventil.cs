using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal class Heizungsventil
    {
        private bool heizungsventilOffen;

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            // Logik für das Heizungsventil basierend auf Wetterdaten
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
