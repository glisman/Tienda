using Proyecto_Tienda.Vista.ventanas;
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

namespace Proyecto_Tienda.Vista
{
    /// <summary>
    /// Lógica de interacción para Registrar.xaml
    /// </summary>
    public partial class Registrar : Page
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void case_Selected(object sender, RoutedEventArgs e)
        {
            Caja abrir = new Caja();
            abrir.Show();
        }

        private void DiscoDuro_Selected(object sender, RoutedEventArgs e)
        {
            Disco abrir = new Disco();
            abrir.Show();
        }
    }
}
