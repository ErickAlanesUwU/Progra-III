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

namespace Alanes_Erick_PRG_III__A__Ex_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Parque> listPark = new List<Parque>();
        public MainWindow()
        {
            InitializeComponent();
            listPark.Add(new Parque("Galaxy"));
            Queue<Juegos> listGames1 = new Queue<Juegos>();
            listGames1.Enqueue(new Juegos("Noria", 14));
            listPark[0].newGame(listGames1);
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            string parque = listPark[0].nombre;
            string juego;
            //lstShow.Items.Add(listPark[0].nombre);
            foreach (Juegos listJuegos in listPark[0].listJuegos)
            {
                juego = listJuegos.juego + " " + listJuegos.capMax;
                //lstShow.Items.Add(listJuegos.juego + " " + listJuegos.capMax);
                lstShow.Items.Add(parque + " " + juego);

            }
        }

        public void Add_Parque(string nomb)
        {
            listPark.Add(new Parque(nomb));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string a = txtAdd.Text;
            Add_Parque(a);
        }
    }

	
    
}
