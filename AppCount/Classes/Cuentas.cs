using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AppCount.Classes
{
    [Serializable]
    class Cuentas
    {
        #region Propiedades

        public decimal CuentaPK { get; set; }

        public string Nivel1 { get; set; }

        public string Nivel2 { get; set; }

        public string Nivel3 { get; set; }

        #endregion
        #region Funciones
        
        public Cuentas(decimal CuentaPK, string Nivel1, string Nivel2, string Nivel3)
        {
            this.CuentaPK = CuentaPK;
            this.Nivel1 = Nivel1;
            this.Nivel2 = Nivel2;
            this.Nivel3 = Nivel3;
        }
        public Cuentas() { }
        
        public override string ToString()
        {
            return !Nivel3.Equals("") ? Nivel3 : (!Nivel2.Equals("") ? Nivel2 : (!Nivel1.Equals("") ? Nivel1 : ""));
        }
        
        #endregion
    }
}