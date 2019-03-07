using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCount.Operaciones
{
    public partial class Operaciones : Base_Library_Design.Forms.Base
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void loadDGV()
        {
            foreach(Classes.Operaciones operacion in AppCount.Properties.Settings.Default.Proyecto.Operaciones)
            {
                dgvData.Rows.Add(new object[] { 0, "OPERACIÓN NUMERO " + operacion.Folio, null, null});
                foreach (Classes.OperacionDet operacionDet in operacion.OperacionDet)
                {
                    dgvData.Rows.Add(new object[] 
                    { 
                        operacionDet.CuentaPK, 
                        AppCount.Properties.Settings.Default.CuentasHT[operacionDet.CuentaPK],
                        operacionDet.Cargo,
                        operacionDet.Abono
                    }
                    );
                }
            }
        }

    }
}
