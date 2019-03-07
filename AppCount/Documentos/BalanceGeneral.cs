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

namespace AppCount.Documentos
{
    public partial class BalanceGeneral : Base_Library_Design.Forms.Base
    {

        #region Propiedades

        Hashtable Cuentas = new Hashtable();
        public decimal[] CuentasPK { get; set; }
        public decimal[] ActivosPK { get; set; }
        public decimal[] PasivosPK { get; set; }
        public ArrayList ActivoCirculante { get; set; }
        public ArrayList ActivoFijo { get; set; }
        public ArrayList ActivoDiferido { get; set; }
        public ArrayList PasivoCirculante { get; set; }
        public ArrayList PasivoFijo { get; set; }
        public ArrayList PasivoDiferido { get; set; }
        public decimal totalActivo { get; set; }
        public decimal totalPasivo { get; set; }

        #endregion

        public BalanceGeneral()
        {
            InitializeComponent();

            lblProyecto.Text += AppCount.Properties.Settings.Default.Proyecto.Nombre;
            lblBalance.Text += DateTime.Now.ToString("dd \\de MMMM \\de yyyy");

            #region Inicialización de propiedades
            Cuentas = AppCount.Properties.Settings.Default.CuentasHT;
            CuentasPK = AppCount.Properties.Settings.Default.Proyecto.cuentasActivas();
            ActivosPK = AppCount.Properties.Settings.Default.Proyecto.getActivos();
            PasivosPK = AppCount.Properties.Settings.Default.Proyecto.getPasivos();

            ActivoCirculante = new ArrayList();
            ActivoFijo = new ArrayList();
            ActivoDiferido = new ArrayList();
            PasivoCirculante = new ArrayList();
            PasivoFijo = new ArrayList(); 
            PasivoDiferido = new ArrayList();
            #endregion

            loadActivo();
            loadPasivo();
        }

        public void loadActivo()
        {
            for(int i = 0; i < ActivosPK.Length; i++)
            {
                if (ActivosPK[i] >= 2 && ActivosPK[i] <= 11)
                    ActivoCirculante.Add(ActivosPK[i]);
                else if (ActivosPK[i] >= 12 && ActivosPK[i] <= 19)
                    ActivoFijo.Add(ActivosPK[i]);
                else if (ActivosPK[i] >= 20 && ActivosPK[i] <= 30)
                    ActivoDiferido.Add(ActivosPK[i]);
            }
            dgvActivo.Rows.Add(new object[] { 0, "ACTIVO", null, null, null, null});
            totalActivo = 0;

            #region Activo Circulante
            if (ActivoCirculante.Count > 0)//¿Hay Activo Circulante?
            {
                dgvActivo.Rows.Add(new object[] { 0, "ACTIVO CIRCULANTE", null, null, null, null });
                int i = 0;
                decimal suma = 0;
                foreach (decimal activo in ActivoCirculante)
                {
                    i++;
                    decimal cantidad = AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(activo);
                    suma += cantidad;
                    if (ActivoCirculante.Count > 1)
                    {
                        if (i == ActivoCirculante.Count)//Si es la última cuenta del nivel
                            dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, cantidad, suma });
                        else
                            dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, cantidad, null });
                    }
                    else
                        dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, null, suma });

                }
                totalActivo += suma;
            }
            #endregion

            #region Activo Fijo
            if (ActivoFijo.Count > 0)//¿Hay Activo Fijo?
            {
                dgvActivo.Rows.Add(new object[] { 0, "ACTIVO FIJO O NO CIRCULANTE", null, null, null, null });
                int i = 0;
                decimal suma = 0;
                foreach (decimal activo in ActivoFijo)
                {
                    i++;
                    decimal cantidad = AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(activo);
                    suma += cantidad;

                    if (ActivoFijo.Count > 1)
                    {
                        if (i == ActivoFijo.Count)//Si es la última cuenta del nivel
                            dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, cantidad, suma });
                        else
                            dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, cantidad, null });
                    }
                    else
                        dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, null, suma });
                }
                totalActivo += suma;
            }
            #endregion

            #region Activo Diferido
            if (ActivoDiferido.Count > 0)//¿Hay Activo Diferido?
            {
                dgvActivo.Rows.Add(new object[] { 0, "ACTIVO DIFERIDO O CARGOS DIFERIDOS", null, null, null, null });
                int i = 0;
                decimal suma = 0;
                foreach (decimal activo in ActivoDiferido)
                {
                    i++;
                    decimal cantidad = AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(activo);
                    suma += cantidad;

                    if (ActivoDiferido.Count > 1)
                    {
                        if (i == ActivoDiferido.Count)//Si es la última cuenta del nivel
                            dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, cantidad, suma });
                        else
                            dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, cantidad, null });
                    }
                    else
                        dgvActivo.Rows.Add(new object[] { activo, Cuentas[activo].ToString(), null, null, null, suma });
                }
                totalActivo += suma;
            }
            #endregion

            dgvActivo.Rows.Add(new object[] { 0, "TOTAL ACTIVO", null, null, null, totalActivo });
        }

        public void loadPasivo()
        {
            for (int i = 0; i < PasivosPK.Length; i++)
            {
                if (PasivosPK[i] >= 32 && PasivosPK[i] <= 38)
                    PasivoCirculante.Add(PasivosPK[i]);
                else if (PasivosPK[i] >= 39 && PasivosPK[i] <= 42)
                    PasivoFijo.Add(PasivosPK[i]);
                else if (PasivosPK[i] >= 43 && PasivosPK[i] <= 45)
                    PasivoDiferido.Add(PasivosPK[i]);
            }
            dgvPasivo.Rows.Add(new object[] { 0, "PASIVO", null, null, null, null });
            totalPasivo = 0;

            #region Pasivo Circulante
            if (PasivoCirculante.Count > 0)//¿Hay Pasivo Circulante?
            {
                dgvPasivo.Rows.Add(new object[] { 0, "PASIVO CIRCULANTE O CORTO PLAZO", null, null, null, null });
                int i = 0;
                decimal suma = 0;
                foreach (decimal pasivo in PasivoCirculante)
                {
                    i++;
                    decimal cantidad = AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(pasivo);
                    suma += cantidad;
                    if (PasivoCirculante.Count > 1)
                    {
                        if (i == PasivoCirculante.Count)//Si es la última cuenta del nivel
                            dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, cantidad, suma });
                        else
                            dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, cantidad, null });
                    }
                    else
                        dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, null, suma });

                }
                totalPasivo += suma;
            }
            #endregion

            #region Pasivo Fijo
            if (PasivoFijo.Count > 0)//¿Hay Pasivo Fijo?
            {
                dgvPasivo.Rows.Add(new object[] { 0, "PASIVO FIJO O LARGO PLAZO", null, null, null, null });
                int i = 0;
                decimal suma = 0;
                foreach (decimal pasivo in PasivoFijo)
                {
                    i++;
                    decimal cantidad = AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(pasivo);
                    suma += cantidad;

                    if (PasivoFijo.Count > 1)
                    {
                        if (i == PasivoFijo.Count)//Si es la última cuenta del nivel
                            dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, cantidad, suma });
                        else
                            dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, cantidad, null });
                    }
                    else
                        dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, null, suma });
                }
                totalPasivo += suma;
            }
            #endregion

            #region Pasivo Diferido
            if (PasivoDiferido.Count > 0)//¿Hay Pasivo Diferido?
            {
                dgvPasivo.Rows.Add(new object[] { 0, "PASIVO DIFERIDO O CRÉDITOS DIFERIDOS", null, null, null, null });
                int i = 0;
                decimal suma = 0;
                foreach (decimal pasivo in PasivoDiferido)
                {
                    i++;
                    decimal cantidad = AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(pasivo);
                    suma += cantidad;

                    if (PasivoDiferido.Count > 1)
                    {
                        if (i == PasivoDiferido.Count)//Si es la última cuenta del nivel
                            dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, cantidad, suma });
                        else
                            dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, cantidad, null });
                    }
                    else
                        dgvPasivo.Rows.Add(new object[] { pasivo, Cuentas[pasivo].ToString(), null, null, null, suma });
                }
                totalPasivo += suma;
            }
            #endregion

            dgvPasivo.Rows.Add(new object[] { 0, "TOTAL PASIVO", null, null, null, totalPasivo });
            decimal capital = totalActivo - totalPasivo;
            dgvPasivo.Rows.Add(new object[] { 0, "CAPITAL CONTABLE", null, null, null, capital });
            dgvPasivo.Rows.Add(new object[] { 0, "", null, null, null, null });
            dgvPasivo.Rows.Add(new object[] { 0, "", null, null, null, null });
            dgvPasivo.Rows.Add(new object[] { 0, "", null, null, null, null });
            dgvPasivo.Rows.Add(new object[] { 0, "PASIVO + CAPITAL", null, null, null, totalPasivo + capital });
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
