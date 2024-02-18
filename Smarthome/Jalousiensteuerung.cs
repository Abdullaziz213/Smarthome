using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal class Jalousiensteuerung
    {
        private bool jalousieRunter;

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            // Logik für die Jalousiensteuerung basierend auf Wetterdaten
            if (wetterdaten.Aussentemperatur > 25 && !wetterdaten.Regen)
            {
                jalousieRunter = true;
                Console.WriteLine("Jalousie wird heruntergefahren");
            }
            else
            {
                jalousieRunter = false;
                Console.WriteLine("Jalousie bleibt oben");
            }
        }
    }
}
