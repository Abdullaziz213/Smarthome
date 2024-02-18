



namespace Smarthome
{
    class Programm
    {
        public static void Main(string[] args)
        {
            
            Wettersensor wettersensor = new Wettersensor();

            
            Zimmer küche = new Zimmer { Name = "Küche", PersonenImZimmer = false, TemperaturVorgabe = 20 };
            Zimmer wohnzimmer = new Zimmer { Name = "Wohnzimmer", PersonenImZimmer = true, TemperaturVorgabe = 22 };
            Zimmer wintergarten = new Zimmer { Name = "Wintergarten", PersonenImZimmer = false, TemperaturVorgabe = 25 };

            
            for (int i = 0; i < 60; i++)
            {
                Wetterdaten wetterdaten = wettersensor.GetWetterdaten();
                Console.WriteLine($"Aktuelle Wetterdaten: Temperatur = {wetterdaten.Aussentemperatur}°C, Windgeschwindigkeit = {wetterdaten.Windgeschwindikeit}km/h, Regen = {(wetterdaten.Regen ? "ja" : "nein")}");

                
                if (wetterdaten.Aussentemperatur < küche.TemperaturVorgabe)
                {
                    Console.WriteLine($"{küche.Name}: Heizungsventil wird geöffnet und geheizt.");
                    
                }
                else
                {
                    Console.WriteLine($"{küche.Name}: Heizungsventil wird geschlossen.");
                    
                }

                if (wetterdaten.Aussentemperatur > wohnzimmer.TemperaturVorgabe && !wohnzimmer.PersonenImZimmer)
                {
                    Console.WriteLine($"{wohnzimmer.Name}: Jalousie wird heruntergefahren.");
                    
                }

                if (wintergarten.Name == "Wintergarten" && wetterdaten.Aussentemperatur > wintergarten.TemperaturVorgabe && !wetterdaten.Regen && wetterdaten.Windgeschwindikeit < 30)
                {
                    Console.WriteLine($"{wintergarten.Name}: Markise wird ausgefahren.");
                    
                }

                Console.WriteLine();
                
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
    

}