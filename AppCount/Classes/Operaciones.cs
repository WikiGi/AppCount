using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCount.Classes
{
    [Serializable]
    class Operaciones
    {
        #region Propiedades

        public decimal Folio { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public bool AsientoApertura { get; set; }
        public ArrayList OperacionDet { get; set; }
        
        #endregion

        #region Funciones

        public Operaciones() { }

        /// <summary>
        /// Inicializa el objeto con los parámetros especificados
        /// </summary>
        /// <param name="folio">Numero de operación del proyecto</param>
        /// <param name="cargo">Cargo total de la operación (debería coincidir con el abono)</param>
        /// <param name="abono">Abono total de la operación (deberia coincidir con el cargo)</param>
        /// <param name="asientoApertura">Indica si la operación es el asiento de apertura del proyecto (debe existir solo un asiento de apertura)</param>
        public Operaciones(decimal folio, decimal cargo, decimal abono, bool asientoApertura)
        {
            this.Folio = folio;
            this.Cargo = cargo;
            this.Abono = abono;
            this.AsientoApertura = asientoApertura;
            this.OperacionDet = new ArrayList();
        }

        /// <summary>
        /// Inicializa el objeto con los parámetros especificados
        /// </summary>
        /// <param name="folio">Numero de operación del proyecto</param>
        /// <param name="cargo">Cargo total de la operación (debería coincidir con el abono)</param>
        /// <param name="abono">Abono total de la operación (deberia coincidir con el cargo)</param>
        /// <param name="asientoApertura">Indica si la operación es el asiento de apertura del proyecto (debe existir solo un asiento de apertura)</param>
        /// <param name="OperacionDet">ArrayList que contiene el detalle de la operación</param>
        public Operaciones(decimal folio, decimal cargo, decimal abono, bool asientoApertura, ArrayList OperacionDet)
        {
            this.Folio = folio;
            this.Cargo = cargo;
            this.Abono = abono;
            this.AsientoApertura = asientoApertura;
            this.OperacionDet = OperacionDet;
        }
        
        #endregion
    }
}
