using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal class Wettersensor
    {
        private double aktuelleTemperatur;
        private Random zufaellig;
        private const int MAXTEMP = 35; // Maximaltemperatur
        private const int MINTEMP = -10; // Minimaltemperatur

        public Wettersensor()
        {
            zufaellig = new Random();
            aktuelleTemperatur = zufaellig.Next(MINTEMP, MAXTEMP);
        }

        public Wetterdaten GetWetterdaten()
        {
            
            Wetterdaten daten = new Wetterdaten
            {
                Aussentemperatur = aktuelleTemperatur,
                Windgeschwindikeit = zufaellig.Next(0, 50), 
                Regen = zufaellig.NextDouble() < 0.5 
            };

            return daten;
        }

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten, Zimmer zimmer)
        {
            
            if (wetterdaten.Aussentemperatur < zimmer.TemperaturVorgabe)
            {
                Console.WriteLine($"{zimmer.Name}: Heizungsventil wird geöffnet und geheizt.");
                
            }
            else
            {
                Console.WriteLine($"{zimmer.Name}: Heizungsventil wird geschlossen.");
                
            }

            
            if (wetterdaten.Aussentemperatur > zimmer.TemperaturVorgabe && !zimmer.PersonenImZimmer)
            {
                Console.WriteLine($"{zimmer.Name}: Jalousie wird heruntergefahren.");
                
            }

            
            if (zimmer.Name == "Wintergarten" && wetterdaten.Aussentemperatur > zimmer.TemperaturVorgabe && !wetterdaten.Regen && wetterdaten.Windgeschwindikeit < 30)
            {
                Console.WriteLine($"{zimmer.Name}: Markise wird ausgefahren.");
                
            }
        }
    }
}

