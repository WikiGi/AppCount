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
    public partial class OperacionesEditor : Base_Library_Design.Forms.Base
    {
        #region Propiedades
        public decimal Cargo
        {
            get
            {
                if (txtCargo.Text.Trim().Length < 1)
                    return 0;
                else
                {
                    string value = txtCargo.Text.Replace("$", "");
                    value = value.Replace(",", "").Trim();
                    return Convert.ToDecimal(value);
                }
            }
            set
            {
                txtCargo.Text = string.Format("{0:$#,0.00}", value);
            }
        }
        public decimal Abono
        {
            get
            {
                if (txtAbono.Text.Trim().Length < 1)
                    return 0;
                else
                {
                    string value = txtAbono.Text.Replace("$", "");
                    value = value.Replace(",", "").Trim();
                    return Convert.ToDecimal(value);
                }
            }
            set
            {
                txtAbono.Text = string.Format("{0:$#,0.00}", value);
            }
        }
        public decimal TotalCargo
        {
            get
            {
                if (txtTotalCargo.Text.Trim().Length < 1)
                    return 0;
                else
                {
                    string value = txtTotalCargo.Text.Replace("$", "");
                    value = value.Replace(",", "").Trim();
                    return Convert.ToDecimal(value);
                }
            }
            set
            {
                txtTotalCargo.Text = string.Format("{0:$#,0.00}", value);
            }
        }
        public decimal TotalAbono
        {
            get
            {
                if (txtTotalAbono.Text.Trim().Length < 1)
                    return 0;
                else
                {
                    string value = txtTotalAbono.Text.Replace("$", "");
                    value = value.Replace(",", "").Trim();
                    return Convert.ToDecimal(value);
                }
            }
            set
            {
                txtTotalAbono.Text = string.Format("{0:$#,0.00}", value);
            }
        }
        #endregion

        public OperacionesEditor()
        {
            InitializeComponent();
            this.Text = "Agregar nueva operación";
        }

        private void OperacionesEditor_Load(object sender, EventArgs e)
        {
            cmbCuentas.ValueMember = "CuentaPK";
            cmbCuentas.DisplayMember = "Cuenta";
            cmbCuentas.DataSource = AppCount.Properties.Settings.Default.CuentasDT;
            cmbCuentas.SelectedIndex = -1;            
            Cargo = Abono = 0; 
        }

        #region Agregar nuevo movimiento

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (Cargo > 0 && Abono > 0)//Si ambos tienen valor
            {
                MessageBox.Show("Solo se puede agregar un cargo o abono. Favor de verificar las cantidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Cargo == 0 && Abono == 0)//Si ambos son iguales a 0
            {
                MessageBox.Show("Cargo y abono no pueden ser igual a 0 ambos. Favor de verificar las cantidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Cargo < 0 || Abono < 0)//Si alguno tiene valor negativo
            {
                MessageBox.Show("Cargo y abono no pueden ser menores a 0. Favor de verificar las cantidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCuentas.SelectedIndex == -1)//Si no se ha seleccionado ninguna cuenta en el ComboBox
            {
                MessageBox.Show("Ninguna cuenta seleccionada, para agregar un nuevo movimiento es necesario que seleccione una cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion
            
            dgvData.Rows.Add(new object[] { cmbCuentas.SelectedValue, cmbCuentas.Text, Cargo, Abono });
            cmbCuentas.SelectedIndex = -1;
            Cargo = Abono = 0;
        }

        private void txtCargo_Enter(object sender, EventArgs e)
        {
            txtCargo.Text = Cargo.ToString();
            txtCargo.SelectAll();
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            Cargo = Cargo;
        }

        private void txtAbono_Enter(object sender, EventArgs e)
        {
            txtAbono.Text = Abono.ToString();
            txtAbono.SelectAll();
        }

        private void txtAbono_Leave(object sender, EventArgs e)
        {
            Abono = Abono;
        }

        #endregion

        private void dgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calcularTotales();
        }

        private void dgvData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularTotales();
        }

        private void calcularTotales()
        {
            decimal totalAbono = 0;
            foreach (DataGridViewRow row in dgvData.Rows)
                totalAbono += Convert.ToDecimal(row.Cells[colAbono.Name].Value);
            TotalAbono = totalAbono;

            decimal totalCargo = 0;
            foreach (DataGridViewRow row in dgvData.Rows)
                totalCargo += Convert.ToDecimal(row.Cells[colCargo.Name].Value);
            TotalCargo = totalCargo;
        }

        private bool operationContainCapital()
        {
            foreach (DataGridViewRow row in dgvData.Rows)
                if (Convert.ToDecimal(row.Cells[colCuentaPK.Name].Value) == 63)
                    return true;
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal FolioOperacion = AppCount.Properties.Settings.Default.Proyecto.CantOperaciones() + 1;
            
            if (TotalCargo == 0 && TotalAbono == 0)//No hay ningún movimiento
            {
                MessageBox.Show("No hay ningún movimiento, no se puede agregar la operación al proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FolioOperacion == 1)//La operación es asiento de apertura
            {
                if (!operationContainCapital())
                {
                    string textoComplementario = "";
                    if (TotalCargo < TotalAbono)
                    {
                        Cargo = TotalAbono - TotalCargo;
                        textoComplementario = "se le agregará un Cargo a Capital de " + string.Format("{0:$#,0.00}", Cargo);
                    }
                    else if (TotalCargo > TotalAbono)
                    {
                        Abono = TotalCargo - TotalAbono;
                        textoComplementario = "se le agregará un Abono a Capital de " + string.Format("{0:$#,0.00}", Abono);
                    }
                    cmbCuentas.SelectedValue = 63;
                    if (MessageBox.Show("La operación es Asiento de apertura " + textoComplementario + "\n¿Desea continuar?", "¿Agregar Capital?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        btnAgregar_Click(sender, e);
                    else
                    {
                        cmbCuentas.SelectedIndex = -1;
                        Cargo = Abono = 0;
                        return;
                    }
                }
            }

            if(TotalCargo != TotalAbono)//No se respeta la partida doble
            {
                MessageBox.Show("El total del cargo y el del abono no coinciden, favor de verificar los movimientos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #region Agregar operación al proyecto
            
            ArrayList operacionDet = new ArrayList();
            foreach (DataGridViewRow row in dgvData.Rows)//Generamos el ArrayList con los detalles de la operación
                operacionDet.Add(
                    new Classes.OperacionDet(
                        row.Index + 1,
                        FolioOperacion,
                        Convert.ToDecimal(row.Cells[colCuentaPK.Name].Value),
                        Convert.ToDecimal(row.Cells[colCargo.Name].Value),
                        Convert.ToDecimal(row.Cells[colAbono.Name].Value)
                    )
                 );
            //Añadimos la operación al ArrayList de operaciones del proyecto
            AppCount.Properties.Settings.Default.Proyecto.Operaciones.Add(
                new Classes.Operaciones(
                    FolioOperacion,
                    TotalCargo,
                    TotalAbono,
                    FolioOperacion == 1 ? true : false,
                    operacionDet //Añadimos el ArrayList del detalle de la operación a la operación
                )
            );
            this.Dispose();
            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
