using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal class Zimmer
    {
        /// <summary>
        /// Zimmerfunktionen werden erstellt
        /// </summary>
        public string Name { get; set; }
        public bool PersonenImZimmer { get; set; }
        public double TemperaturVorgabe { get; set; }

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            
            if (wetterdaten.Aussentemperatur < TemperaturVorgabe)
            {
                Console.WriteLine($"{Name}: Heizungsventil wird geöffnet und geheizt.");
                
            }
            else
            {
                Console.WriteLine($"{Name}: Heizungsventil wird geschlossen.");
               
            }

            
            if (wetterdaten.Aussentemperatur > TemperaturVorgabe && !PersonenImZimmer)
            {
                Console.WriteLine($"{Name}: Jalousie wird heruntergefahren.");
                
            }

            
            if (Name == "Wintergarten" && wetterdaten.Aussentemperatur > TemperaturVorgabe && !wetterdaten.Regen && wetterdaten.Windgeschwindikeit < 30)
            {
                Console.WriteLine($"{Name}: Markise wird ausgefahren.");
                
            }
        }
    }
}
