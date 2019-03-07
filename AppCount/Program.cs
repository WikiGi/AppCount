using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppCount
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Carga del HastTable Cuentas
            AppCount.Properties.Settings.Default.CuentasHT = new Hashtable();
            ArrayList cuentas = AppCount.Properties.Settings.Default.CuentasAL;
            foreach (Classes.Cuentas cuenta in cuentas)
            {
                AppCount.Properties.Settings.Default.CuentasHT.Add(cuenta.CuentaPK, cuenta);
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
