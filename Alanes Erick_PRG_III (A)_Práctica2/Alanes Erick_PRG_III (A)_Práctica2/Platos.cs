using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alanes_Erick_PRG_III__A__Práctica2
{
    class Platos
    {
        public string NombrePlato { get; set; }
        public int PrecioPlato { get; set; }

        List<Ingredientes> ingredientes;
        public List<Ingredientes> Ingredientes { get { return ingredientes; } }

        public Platos(string name, int price)
        {
            NombrePlato = name;
            PrecioPlato = price;
            ingredientes = new List<Ingredientes>();
        }
        public Platos(string name, int price, List<Ingredientes> ingredientes)
        {
            NombrePlato = name;
            PrecioPlato = price;
            this.ingredientes = ingredientes;
        }

        public void newIngredientes(List<Ingredientes> ingredientesList)
        {
            ingredientes = ingredientesList;
        }
    }
}
