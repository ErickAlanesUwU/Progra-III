using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alanes_Erick_PRG_III__A__Práctica2
{
    /// <summary>
    /// Crear un programa para la venta de comida, en la que muestre los platos mediante la seleccion de ingredientes
    /// 1. Lista (menú) de platos, cada uno con sus principales ingredientes.
    /// 2. El cliente puede visualizar los ingredientes que maneja la empresa.
    /// 3. El cliente puede elegir ingredientes para que la aplicación muestre los platos que contienen esos elementos.
    /// 4. El cliente puede elegir ingredientes para que la aplicación muestre los platos que no contienen esos elementos.
    /// 5. El cliente puede elegir una combinación de ingredientes presentes y ausentes en los platos y la aplicación debe sugerir platos que cumplan ambas restricciones.
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Platos> platosList = new List<Platos>();
        public MainWindow()
        {
            InitializeComponent(); 
            platosList.Add(new Platos("Milanesa", 15));
            List<Ingredientes> ingredientesList1 = new List<Ingredientes>();
            ingredientesList1.Add(new Ingredientes("carne"));
            ingredientesList1.Add(new Ingredientes("papa"));
            ingredientesList1.Add(new Ingredientes("verdura"));
            platosList[0].newIngredientes(ingredientesList1);

            platosList.Add(new Platos("Ensalda", 20));
            List<Ingredientes> ingredientesList2 = new List<Ingredientes>();
            ingredientesList2.Add(new Ingredientes("verdura"));
            platosList[1].newIngredientes(ingredientesList2);

            platosList.Add(new Platos("Arroz Chino", 10));
            List<Ingredientes> ingredientesList3 = new List<Ingredientes>();
            ingredientesList3.Add(new Ingredientes("carne"));
            ingredientesList3.Add(new Ingredientes("verdura"));
            ingredientesList3.Add(new Ingredientes("arroz"));
            platosList[2].newIngredientes(ingredientesList3);

            platosList.Add(new Platos("Pollo Broaster", 25));
            List<Ingredientes> ingredientesList4 = new List<Ingredientes>();
            ingredientesList4.Add(new Ingredientes("carne"));
            ingredientesList4.Add(new Ingredientes("papa"));
            ingredientesList4.Add(new Ingredientes("arroz"));
            platosList[3].newIngredientes(ingredientesList4);

            platosList.Add(new Platos("Asado", 20));
            List<Ingredientes> ingredientesList5 = new List<Ingredientes>();
            ingredientesList5.Add(new Ingredientes("carne"));
            ingredientesList5.Add(new Ingredientes("verdura"));
            platosList[4].newIngredientes(ingredientesList5);

            platosList.Add(new Platos("Brocheta", 20));
            List<Ingredientes> ingredientesList6 = new List<Ingredientes>();
            ingredientesList6.Add(new Ingredientes("carne"));
            ingredientesList6.Add(new Ingredientes("verdura"));
            platosList[5].newIngredientes(ingredientesList6);
            ShowPlatosList();
        }
        public void ShowPlatosList()
        {
            foreach (Platos platos in platosList)
            {
                lstMenu.Items.Add(platos.NombrePlato + "\t" + platos.PrecioPlato);

                foreach (Ingredientes ingrediente in platos.Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");
            }
        }
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            lstMenu.Items.Clear();
            if (cbxCarne.IsChecked == true)
            {
                lstMenu.Items.Clear();
                lstMenu.Items.Add(platosList[0].NombrePlato + "\t" + platosList[0].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[0].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[2].NombrePlato + "\t" + platosList[2].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[2].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[3].NombrePlato + "\t" + platosList[3].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[3].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[4].NombrePlato + "\t" + platosList[4].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[4].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[5].NombrePlato + "\t" + platosList[5].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[5].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");
            }
            if (cbxPapa.IsChecked == true)
            {
                lstMenu.Items.Clear();
                lstMenu.Items.Add(platosList[0].NombrePlato + "\t" + platosList[0].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[0].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[3].NombrePlato + "\t" + platosList[3].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[3].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[4].NombrePlato + "\t" + platosList[4].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[4].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[5].NombrePlato + "\t" + platosList[5].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[5].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");
            }
            if (cbxVerdura.IsChecked == true)
            {
                lstMenu.Items.Clear();
                lstMenu.Items.Add(platosList[0].NombrePlato + "\t" + platosList[0].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[0].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[1].NombrePlato + "\t" + platosList[1].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[1].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[2].NombrePlato + "\t" + platosList[2].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[2].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[5].NombrePlato + "\t" + platosList[5].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[5].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");
            }
            if (cbxArroz.IsChecked == true)
            {
                lstMenu.Items.Clear();
                lstMenu.Items.Add(platosList[2].NombrePlato + "\t" + platosList[2].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[2].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[3].NombrePlato + "\t" + platosList[3].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[3].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");
            }
            if (cbxCarne.IsChecked == true && cbxPapa.IsChecked == true)
            {
                lstMenu.Items.Clear();
                lstMenu.Items.Add(platosList[0].NombrePlato + "\t" + platosList[0].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[0].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[2].NombrePlato + "\t" + platosList[2].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[3].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[3].NombrePlato + "\t" + platosList[3].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[3].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[4].NombrePlato + "\t" + platosList[4].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[4].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[5].NombrePlato + "\t" + platosList[5].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[5].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");
            }
            if (cbxCarne.IsChecked == true && cbxPapa.IsChecked == true && cbxVerdura.IsChecked == true && cbxArroz.IsChecked == true)
            {
                lstMenu.Items.Clear();
                lstMenu.Items.Add(platosList[0].NombrePlato + "\t" + platosList[0].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[0].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[1].NombrePlato + "\t" + platosList[1].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[1].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[2].NombrePlato + "\t" + platosList[2].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[2].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[3].NombrePlato + "\t" + platosList[3].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[3].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[4].NombrePlato + "\t" + platosList[4].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[4].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");

                lstMenu.Items.Add(platosList[5].NombrePlato + "\t" + platosList[5].PrecioPlato);
                foreach (Ingredientes ingrediente in platosList[5].Ingredientes)
                {
                    lstMenu.Items.Add(ingrediente.Ingrediente);
                }
                lstMenu.Items.Add("---------------------------------------");
            }
        }
    }
}
