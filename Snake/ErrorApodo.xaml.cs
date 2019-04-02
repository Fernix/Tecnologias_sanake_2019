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

namespace Snake
{
    /// <summary>
    /// Controlador para la vista ErrorApodo,
    /// </summary>
    public partial class ErrorApodo : Window
    {
        public ErrorApodo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este método controla el evento del boton bttnAceptar.
        /// </summary>
        private void onClick(object sender, RoutedEventArgs e)
        {
            errorApodo.Close();
        }
    }
}
