using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alanes_Erick_PRG_III__A__Ex_1
{
    class Parque
    {
        public string nombre { get; set; }
        public Queue<Juegos> listJuegos;
        public Queue<Juegos> Juegos { get { return listJuegos; } }


        public Parque (string name)
        {
            nombre = name;
            listJuegos = new Queue<Juegos>();
        }

        public Parque(string name, Queue<Juegos> listJuegos)
        {
            nombre = name;
            listJuegos = new Queue<Juegos>();
            this.listJuegos = listJuegos;
        }

        public void newGame(Queue<Juegos> listGame)
        {
            listJuegos = listGame;
        }
    }
}
