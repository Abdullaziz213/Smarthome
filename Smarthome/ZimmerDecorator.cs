using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome
{
    internal class ZimmerDecorator 
    {
        /// <summary>
        /// ZimmerDecorator wird erstellt
        /// </summary>
        protected IZimmer Zimmer { get; set; }

        public string Name { get; set; }

        public bool PersonenImZimmer { get; set; }

        public double Temperatur { get; set; }

        public void VerarbeiteWetterdaten(Wetterdaten Wetterdaten) 
        {

        }



    }
}
