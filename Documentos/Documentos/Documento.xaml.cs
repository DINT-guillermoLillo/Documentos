using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para Documento.xaml
    /// </summary>
    public partial class Documento : Window
    {
        public Documento()
        {
            InitializeComponent();   
        }



        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";


            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, textoTextBox.Text);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("¿Seguro que quieres cerrar?", "Cerrar", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
                e.Cancel = true;
        }
    }
}
