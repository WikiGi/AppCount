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
    public partial class EsquemasMayor : Base_Library_Design.Forms.Base
    {
        public decimal[] CuentasActivas { get; set; }
        Hashtable Cuentas { get; set; }
        public EsquemasMayor()
        {
            InitializeComponent();
            CuentasActivas = AppCount.Properties.Settings.Default.Proyecto.cuentasActivas();
            Cuentas = AppCount.Properties.Settings.Default.CuentasHT;
            lblProyecto.Text += AppCount.Properties.Settings.Default.Proyecto.Nombre;
            lblBalance.Text += AppCount.Properties.Settings.Default.Proyecto.FechaInicial.ToString("dd-MM-yyyy") + " al " + AppCount.Properties.Settings.Default.Proyecto.FechaFinal.ToString("dd-MM-yyyy");
        }

        private void EsquemasMayor_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < CuentasActivas.Length; i++)
            {
                #region Crear esquema
                Panel Panel = new Panel();
                Label lblCuenta = new Label();
                DataGridView dgvData = new DataGridView();
                DataGridViewTextBoxColumn colCargo = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn colAbono = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn colCOp = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn colAOp = new DataGridViewTextBoxColumn();
                DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
                DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
                
                // 
                // Panel
                // 
                Panel.Controls.Add(lblCuenta);
                Panel.Controls.Add(dgvData);
                Panel.Location = new System.Drawing.Point(3, 3);
                Panel.Name = "Panel";
                Panel.Size = new System.Drawing.Size(250, 334);
                Panel.TabIndex = 0;
                Panel.BorderStyle = BorderStyle.Fixed3D;
                // 
                // dgvData
                // 
                dgvData.AllowUserToAddRows = false;
                dgvData.AllowUserToDeleteRows = false;
                dgvData.AllowUserToResizeColumns = false;
                dgvData.AllowUserToResizeRows = false;
                dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvData.ColumnHeadersVisible = false;
                dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colCOp,
                colCargo,
                colAbono,
                colAOp});
                dgvData.Location = new System.Drawing.Point(3, 29);
                dgvData.Name = "dgvData";
                dgvData.ReadOnly = true;
                dgvData.RowHeadersVisible = false;
                dgvData.RowTemplate.Height = 28;
                dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvData.Size = new System.Drawing.Size(244, 302);
                dgvData.TabIndex = 0;
                // 
                // lblCuenta
                // 
                lblCuenta.AutoSize = true;
                lblCuenta.BackColor = Color.Navy;
                lblCuenta.ForeColor = Color.White;
                lblCuenta.Location = new System.Drawing.Point(3, 0);
                lblCuenta.Name = "lblCuenta";
                lblCuenta.Size = new System.Drawing.Size(70, 26);
                lblCuenta.TabIndex = 1;
                // 
                // colCargo
                // 
                colCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
                dataGridViewCellStyle1.Format = "C2";
                colCargo.DefaultCellStyle = dataGridViewCellStyle1;
                colCargo.HeaderText = "";
                colCargo.Name = "colCargo";
                colCargo.ReadOnly = true;
                // 
                // colAbono
                // 
                colAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
                dataGridViewCellStyle2.Format = "C2";
                colAbono.DefaultCellStyle = dataGridViewCellStyle2;
                colAbono.HeaderText = "";
                colAbono.Name = "colAbono";
                colAbono.ReadOnly = true;
                //
                // colCOp
                //
                colCOp.HeaderText = "";
                colCOp.Name = "colCOp";
                colCOp.ReadOnly = true;
                colCOp.Width = 25;
                //
                // colAOp
                //
                colAOp.HeaderText = "";
                colAOp.Name = "colAOp";
                colAOp.ReadOnly = true;
                colAOp.Width = 25;

                #endregion

                #region Cargar esquema

                lblCuenta.Text = Cuentas[CuentasActivas[i]].ToString();
                flpEsquemas.Controls.Add(Panel);

                decimal[,] cargos = AppCount.Properties.Settings.Default.Proyecto.cargosCuenta(CuentasActivas[i]);
                decimal[,] abonos = AppCount.Properties.Settings.Default.Proyecto.abonosCuenta(CuentasActivas[i]);
                int rows = cargos.GetLength(0) >= abonos.GetLength(0) ? cargos.GetLength(0) : abonos.GetLength(0);
                decimal[,] esquema = new decimal[rows, 4];

                for(int j = 0; j < rows; j++)
                {
                    if(cargos.GetLength(0) > j)
                    {
                        esquema[j, 0] = cargos[j, 0];
                        esquema[j, 1] = cargos[j, 1];
                    }
                    if(abonos.GetLength(0) > j)
                    {
                        esquema[j, 3] = abonos[j, 0];
                        esquema[j, 2] = abonos[j, 1];
                    }
                    object[] row = new object[] { esquema[j, 0], esquema[j, 1], esquema[j, 2], esquema[j, 3] };
                    if (esquema[j, 0] == 0)
                        row[0] = null;
                    if (esquema[j, 1] == 0)
                        row[1] = null;
                    if (esquema[j, 2] == 0)
                        row[2] = null;
                    if (esquema[j, 3] == 0)
                        row[3] = null;

                    dgvData.Rows.Add(row);
                }

                dgvData.Rows.Add(new object[]{
                    null,
                    AppCount.Properties.Settings.Default.Proyecto.sumaCargo(CuentasActivas[i]),
                    AppCount.Properties.Settings.Default.Proyecto.sumaAbono(CuentasActivas[i]),
                    null
                    });

                if(CuentasActivas[i] >= 1 && CuentasActivas[i] <= 30)//Cuenta de activo
                    dgvData.Rows.Add(new object[]{
                    "S)",
                    AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(CuentasActivas[i]),
                    null,
                    null
                    });
                else if (CuentasActivas[i] >= 31 && CuentasActivas[i] <= 45)//Cuenta de pasivo
                    dgvData.Rows.Add(new object[]{
                    null,
                    null,
                    AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(CuentasActivas[i]),
                    "(S"
                    });
                else if (CuentasActivas[i] > 45)//Cuenta del estado de resultados
                {
                    //Si el cargo es mayor
                    if (AppCount.Properties.Settings.Default.Proyecto.sumaCargo(CuentasActivas[i]) > AppCount.Properties.Settings.Default.Proyecto.sumaAbono(CuentasActivas[i]))
                        dgvData.Rows.Add(new object[]{
                        "S)",
                        AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(CuentasActivas[i]),
                        null,
                        null
                        });
                    //Si el abono es mayor
                    else
                        dgvData.Rows.Add(new object[]{
                        null,
                        null,
                        AppCount.Properties.Settings.Default.Proyecto.saldoCuenta(CuentasActivas[i]),
                        "(S"
                        });
                }
                #endregion
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
