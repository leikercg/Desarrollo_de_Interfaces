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

namespace Wpf_binding_nombre
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // declaro el atributo
        private string nombre;

        //Declaro la propiedad
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public MainWindow()
        {
            InitializeComponent();

            Nombre = "Leiker";
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nombre = "Nombre modificad";
        }

        
    }
}
