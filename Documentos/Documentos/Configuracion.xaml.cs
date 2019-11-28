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
using System.Windows.Shapes;

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Configuracion()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Height = int.Parse(Alto.Text);
            Width = int.Parse(Ancho.Text);

            this.Close();
        }

        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
