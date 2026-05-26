using System;
using System.Windows.Forms;
using PuntoDeVenta.Vista;

namespace MarketSoft
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Abrir el menú principal
            Application.Run(new FormMenu());
        }
    }
}