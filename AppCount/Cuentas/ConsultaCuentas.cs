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
using AppCount.Classes;

namespace AppCount.Cuentas
{
    public partial class ConsultaCuentas : Base_Library_Design.Forms.Base
    {
        public ConsultaCuentas()
        {
            InitializeComponent();
        }

        private void ConsultaCuentas_Load(object sender, EventArgs e)
        {
            foreach(AppCount.Classes.Cuentas cuenta in AppCount.Properties.Settings.Default.CuentasAL)
            {
                dgvData.Rows.Add(new object[] {cuenta.CuentaPK, cuenta.Nivel1, cuenta.Nivel2, cuenta.Nivel3});
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Excel.exportToExcel(dgvData);
        }
    }
}
