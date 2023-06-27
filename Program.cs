using DashboardTurismoReal.FormProducto;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace DashboardTurismoReal
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear una instancia de IConfiguration para leer la configuración
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // Pasar la configuración al crear una instancia de MainForm
            //Application.Run(new FormLogin());
            Application.Run(new MainForm(configuration));
        }
    }
}
