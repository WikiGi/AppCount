using System;
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
    public partial class EstadoResultados : Base_Library_Design.Forms.Base
    {
        public EstadoResultados()
        {
            InitializeComponent();
            loadDGV();
            lblProyecto.Text += AppCount.Properties.Settings.Default.Proyecto.Nombre;
            lblBalance.Text += DateTime.Now.ToString("dd \\de MMMM \\de yyyy");
        }

        public void loadDGV()
        {
            dgvData.Rows.Add(new object[] { "Ventas totales", null, null, 825000, null});
            dgvData.Rows.Add(new object[] { "Descuentos sobre ventas", null, null, 1800, null});
            dgvData.Rows.Add(new object[] { "Ventas netas",null,null,null,823200});
            dgvData.Rows.Add(new object[] { "Compras totales", null, null,null, null});
            dgvData.Rows.Add(new object[] { "Compras netas", null, null, 650000,null});
            dgvData.Rows.Add(new object[] { "Inventario inicial", null,null,750000,null});
            dgvData.Rows.Add(new object[] { "Total mercancía",null,null,1400000,null});
            dgvData.Rows.Add(new object[] { "Inventario final",null,null,535000,null});
            dgvData.Rows.Add(new object[] { "Costo de lo vendido",null,null,null,865000});
            dgvData.Rows.Add(new object[] { "Pérdida en venta",null,null,null,41800});
            dgvData.Rows.Add(new object[] { "GASTOS DE OPERACIÓN",null,null,null,null});
            dgvData.Rows.Add(new object[] { "GASTOS DE VENTA",null,null,null,null});
            dgvData.Rows.Add(new object[] { "Renta de la tienda",20000,null,null,null});
            dgvData.Rows.Add(new object[] { "Fletes y acarreo",4000,null,null,null});
            dgvData.Rows.Add(new object[] { "Luz del almacén",3000,null,null,null});
            dgvData.Rows.Add(new object[] { "Sueldos de dependientes y agentes",18000,null,null,null});
            dgvData.Rows.Add(new object[] { "Mantenimiento de equipo de reparto",8000,53000,null,null});
            dgvData.Rows.Add(new object[] { "GASTOS DE ADMINISTRACIÓN",null,null,null,null});
            dgvData.Rows.Add(new object[] { "Sueldo del gerente",18000,null,null,null});
            dgvData.Rows.Add(new object[] { "Sueldo del contador",15000,null,null,null});
            dgvData.Rows.Add(new object[] { "Papelería y útiles de oficina",5000,null,null,null});
            dgvData.Rows.Add(new object[] { "Teléfonos de las oficinas",3200,null,null,null});
            dgvData.Rows.Add(new object[] { "Sueldos del personal de oficina",30000,null,null,null});
            dgvData.Rows.Add(new object[] { "Renta de las oficinas",12000,83200,136200,null});
            dgvData.Rows.Add(new object[] { "PRODUCTOS FINANCIEROS",null,null,null,null});
            dgvData.Rows.Add(new object[] { "Intereses cobrados",null,9000,null,null});
            dgvData.Rows.Add(new object[] { "GASTOS FINANCIEROS",null,null,null,null});
            dgvData.Rows.Add(new object[] { "Gastos de situación",1200,null,null,null});
            dgvData.Rows.Add(new object[] { "Intereses pagados",6000,7200,1800,134400});
            dgvData.Rows.Add(new object[] { "Pérdida de operación", null,null,null,176400});
            dgvData.Rows.Add(new object[] { "OTROS PRODUCTOS",null,null,null,null});
            dgvData.Rows.Add(new object[] { "Utilidad en venta de valores de activo fijo",null,null,13000,null});
            dgvData.Rows.Add(new object[] { "OTROS GASTOS",null,null,null,null});
            dgvData.Rows.Add(new object[] { "Pérdida en ventas",null,null,12000,1000});
            dgvData.Rows.Add(new object[] { "Pérdida neta del ejercicio",null,null,null,175200});
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
