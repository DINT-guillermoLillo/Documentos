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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Configuracion conf = new Configuracion();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void documentoButton_Click (object sender, RoutedEventArgs e)
        {
            Documento doc = new Documento();

            //Establecemos la nueva ventana como un ventana hija
            doc.Owner = this;
                doc.Width = conf.Anchura;
                doc.Height = conf.Altura;
                

            doc.Show();
        }

        private void configuracionButton_Click(object sender, RoutedEventArgs e)
        {
            //Establecemos la nueva ventana como un ventana hija
            conf.Owner = this;
                //Asignamos sus propiedades
                conf.SizeToContent = SizeToContent.WidthAndHeight;
                conf.ResizeMode = ResizeMode.NoResize;
                conf.ShowInTaskbar = false; 

            conf.ShowDialog();
        }
    }
}
