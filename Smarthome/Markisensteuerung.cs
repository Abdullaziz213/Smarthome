﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal class Markisensteuerung
    {
        /// <summary>
        /// Markisensteuerung wird erstellt
        /// </summary>
        private bool markiseAusgefahren;

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            
            if (wetterdaten.Aussentemperatur > 25 && !wetterdaten.Regen && wetterdaten.Windgeschwindikeit < 30)
            {
                markiseAusgefahren = true;
                Console.WriteLine("Markise wird ausgefahren");
            }
            else
            {
                markiseAusgefahren = false;
                Console.WriteLine("Markise bleibt eingefahren");
            }
        }
    }
}
