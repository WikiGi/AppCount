using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCount.Proyecto
{
    public partial class ProyectoEditor : Base_Library_Design.Forms.Base
    {
        #region Propiedades

        public enum EditMode { NEW, EDIT };
        public EditMode editMode { get; set; }
        public string Nombre
        {
            get
            {
                return txtNombre.Text;
            }
            set
            {
                txtNombre.Text = value;
            }
        }
        public DateTime FechaInicial
        {
            get
            {
                return dtpFechaInicial.Value;
            }
            set
            {
                dtpFechaInicial.Value = value;
            }
        }
        public DateTime FechaFinal
        {
            get
            {
                return dtpFechaFinal.Value;
            }
            set
            {
                dtpFechaFinal.Value = value;
            }
        }
        
        #endregion

        public ProyectoEditor()
        {
            InitializeComponent();
        }
        
        public ProyectoEditor(EditMode editMode)
        {
            base.Size = this.Size;
            InitializeComponent();
            this.editMode = editMode;
            if (editMode == EditMode.NEW)
                this.Text = "Nuevo Proyecto";
            else if (editMode == EditMode.EDIT)
            {
                this.Text = "Editar Proyecto";
                this.Nombre = AppCount.Properties.Settings.Default.Proyecto.Nombre;
                this.FechaInicial = AppCount.Properties.Settings.Default.Proyecto.FechaInicial;
                this.FechaFinal = AppCount.Properties.Settings.Default.Proyecto.FechaFinal;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Nombre.Equals(""))
                return;
            if (editMode == EditMode.NEW)
            {
                AppCount.Properties.Settings.Default.Proyecto = new Classes.Proyectos(Nombre, FechaInicial, FechaFinal);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
            else if (editMode == EditMode.EDIT)
            {
                AppCount.Properties.Settings.Default.Proyecto.Nombre = Nombre;
                AppCount.Properties.Settings.Default.Proyecto.FechaInicial = FechaInicial;
                AppCount.Properties.Settings.Default.Proyecto.FechaFinal = FechaFinal;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
        }

    }
}
