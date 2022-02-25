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

namespace Practica_Colas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue<Libreria> queueLibrary = new Queue<Libreria>();
        Queue<Libreria> queueAfuera = new Queue<Libreria>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enqueue_Click(object sender, RoutedEventArgs e)
        {
            Libreria person = new Libreria(txtCliente.Text);
            queueLibrary.Enqueue(person);
            Show_Queue(lstQueue, queueLibrary);
        }

        private void Dequeue_Click(object sender, RoutedEventArgs e)
        {
            string ClientRemove = txtCliente.Text;
            Libreria client = FindClient(ClientRemove);
            if (client != null)
                Remove_Q(client);
            Show_Queue(lstOut, queueAfuera);
            Show_Queue(lstQueue, queueLibrary);

            while (queueAfuera.Count > 0)
            {
                queueLibrary.Enqueue(queueAfuera.Dequeue());
            }

            Show_Queue(lstQueue, queueLibrary);
            Show_Queue(lstOut, queueAfuera);
        }


        Libreria FindClient(string idRemove)
        {
            Libreria tmp = null;
            foreach (var item in queueLibrary)
            {
                if (item.Product == idRemove)
                    tmp = item;
            }
            return tmp;
        }

        void Remove_Q(Libreria v1)
        {
            bool encontrado = false;
            do
            {
                if (v1.Equals(queueLibrary.Peek()))
                {
                    queueLibrary.Dequeue();
                    encontrado = true;
                }
                else
                {
                    queueAfuera.Enqueue(queueLibrary.Dequeue());
                }
            } while (!encontrado);
        }

        void Show_Queue(ListBox listBox, Queue<Libreria> library)
        {
            listBox.Items.Clear();
            foreach (var item in library)
                listBox.Items.Add(item.Product);
        }
    }
}
