using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Snake
{
    /// <summary>
    /// Controlador para la vista MainWindow.
    /// </summary>
    public partial class MainWindow : Window
    {

        private string apodo;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este método controla el evento del boton bttnBuscar.
        /// </summary>
        private void onClick(object sender, RoutedEventArgs e)
        {
            apodo = tfApodo.Text.Trim();
            if (validarNombre(apodo))
            {
                enviarNombreServidor(apodo);
            }
            else
            {
                var win = new ErrorApodo();
                win.ShowDialog();
            }
        }

        /// <summary>
        /// Este método valida, mediante una expresión regular, la entrada del apodo, [a-z] [A-Z] [0-9] {3-12}
        /// regresa true si la expresion se culpe, false de lo contrario.
        /// </summary>
        private bool validarNombre(string apodo)
        {
            if (Regex.IsMatch(apodo, "^([a-z]|[A-Z]|[0-9]){3,12}$"))
            {
                return true;
            } else
            {
                return false;
            }

        }

        /// <summary>
        /// Este método envía el apodo al servidor para su administración en el juego.
        /// </summary>
        private void enviarNombreServidor(string apodo)
        {
            Console.WriteLine("PASO");
            return;
        }

    }
}