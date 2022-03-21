using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alanes_Erick_PRG_III__A__Ex_1
{
    class Juegos
    {
        public string juego { get; set; }
        public int capMax { get; set; }

        public Juegos (string j1, int cm)
        {
            juego = j1;
            capMax = cm;
        }
    }
}
