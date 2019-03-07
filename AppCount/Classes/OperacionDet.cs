using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCount.Classes
{
    [Serializable]
    class OperacionDet
    {
        #region Propiedades

        public decimal Folio { get; set; }
        public decimal FolioOperacion { get; set; }
        public decimal CuentaPK { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }

        #endregion

        #region Funciones

        public OperacionDet(decimal Folio, decimal FolioOperacion, decimal CuentaPK, decimal Cargo, decimal Abono)
        {
            this.Folio = Folio;
            this.FolioOperacion = FolioOperacion;
            this.CuentaPK = CuentaPK;
            this.Cargo = Cargo;
            this.Abono = Abono;
        }

        #endregion
    }
}
