using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal interface IZimmer
    {
        /// <summary>
        /// IZimmer wird erstellt
        /// </summary>
        public string Name { get; set; }

        public bool PersonenImZimmer { get; set; }

        public double TemperaturVorgabe { get; set; }

        public void VerarbeiteWetterdaten(Wetterdaten Wetterdaten)
        {

        }
    }
}
