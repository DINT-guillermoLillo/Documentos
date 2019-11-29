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
        public int Altura { get; set; }
        public int Anchura { get; set; }

        public Configuracion()
        {
            InitializeComponent();

            Altura = 500;
            Anchura = 500;
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Altura = int.Parse(altoTextBox.Text);
            Anchura = int.Parse(anchoTextBox.Text);

            this.Close();
        }

        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
