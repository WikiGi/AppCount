using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCount.Classes;

namespace AppCount
{
    public partial class Principal : Base_Library_Design.Forms.Base
    {
        public Principal()
        {
            InitializeComponent();
        }

        #region CloseButton

        private void pbCerrar_MouseHover(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Navy;
            pbClose.BackgroundImage = AppCount.Properties.Resources.XWhite;
        }

        private void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Transparent;
            pbClose.BackgroundImage = AppCount.Properties.Resources.XBlack;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            cerrarToolStripMenuItem_Click(sender, e);
        }

        #endregion

        #region Minimize Button

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMinimize_MouseHover(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.Navy;
            pbMinimize.BackgroundImage = AppCount.Properties.Resources.MinimizeWhite;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.Transparent;
            pbMinimize.BackgroundImage = AppCount.Properties.Resources.MinimizeBlack;
        }

        #endregion

        private void loadDatosProyectoActivo()
        {
            Proyectos pa = AppCount.Properties.Settings.Default.Proyecto;
            if(pa == null)
            {
                operacionesToolStripMenuItem.Enabled = false;
                documentosToolStripMenuItem.Enabled = false;
                lblInformacionProyectoActivo.Text = "-----Ningún proyecto abierto-----";
                return;
            }
            lblInformacionProyectoActivo.Text = "Proyecto: " + pa.Nombre +
                                                " | Periodo del " + pa.FechaInicial.ToString("dd/MM/yyyy") + " al " + pa.FechaFinal.ToString("dd/MM/yyyy") + 
                                                " | Operaciones: " + pa.CantOperaciones() + 
                                                " | Cargo: " + string.Format("{0:$#,0.00}", pa.TotalCargo()) +
                                                " | Abono: " + string.Format("{0:$#,0.00}", pa.TotalAbono());
            operacionesToolStripMenuItem.Enabled = true;
            documentosToolStripMenuItem.Enabled = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            loadDatosProyectoActivo();
        }

        private void Principal_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
        }
        
        #region Archivo

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proyecto.ProyectoEditor pe = new Proyecto.ProyectoEditor(Proyecto.ProyectoEditor.EditMode.NEW);
            if(pe.ShowDialog() == DialogResult.OK)
            {
                saveFile(SaveMode.NEW);
                loadDatosProyectoActivo();
            }
        }

        private void editarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AppCount.Properties.Settings.Default.Proyecto == null)
            {
                MessageBox.Show("Ningún proyecto abierto. Favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Proyecto.ProyectoEditor pe = new Proyecto.ProyectoEditor(Proyecto.ProyectoEditor.EditMode.EDIT);
            if (pe.ShowDialog() == DialogResult.OK)
            {
                loadDatosProyectoActivo();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppCount.Properties.Settings.Default.Proyecto == null)
            {
                MessageBox.Show("Ningún proyecto abierto. Favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFile(SaveMode.EDIT);
            loadDatosProyectoActivo();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppCount.Properties.Settings.Default.Proyecto == null)
            {
                MessageBox.Show("Ningún proyecto abierto. Favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFile(SaveMode.NEW);
            loadDatosProyectoActivo();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppCount.Properties.Settings.Default.Proyecto == null || MessageBox.Show("Si sale ahora se perderán todo los cambios que no haya guardado, ¿Está seguro de que desea salir?", "Salir...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        #endregion

        #region Operaciones

        private void agregarOperacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones.OperacionesEditor oe = new Operaciones.OperacionesEditor();
            oe.ShowDialog();
            loadDatosProyectoActivo();
        }

        private void editarOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones.Operaciones op = new Operaciones.Operaciones();
            op.Show();
        }

        #endregion

        #region Documentos

        private void esquemasDeMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentos.EsquemasMayor em = new Documentos.EsquemasMayor();
            em.Show();
        }

        private void balanzaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentos.BalanceGeneral bg = new Documentos.BalanceGeneral();
            bg.Show();
        }

        private void estadoDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentos.EstadoResultados er = new Documentos.EstadoResultados();
            er.Show();
        }

        #endregion

        #region Cuentas

        private void cuentasGuardadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuentas.ConsultaCuentas cc = new Cuentas.ConsultaCuentas();
            cc.Show();
        }

        #endregion

        #region Files
        public enum SaveMode { NEW, EDIT };
        public void openFile()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "AppCount Project Files(*.ap)|*.ap";
                ofd.RestoreDirectory = true;
                ofd.Title = "Abrir archivo...";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AppCount.Properties.Settings.Default.ProyectoActivo = ofd.FileName;
                    FileManager fm = new FileManager(AppCount.Properties.Settings.Default.ProyectoActivo);
                    AppCount.Properties.Settings.Default.Proyecto = (Proyectos)fm.readObject();
                    if (AppCount.Properties.Settings.Default.Proyecto == null)
                        throw new Exception();
                    loadDatosProyectoActivo();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ocurrió un error al abrir el archivo. Favor de verificar", "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                openFile();
            }
        }

        public bool saveFile(SaveMode saveMode)
        {
            try
            {
                if (saveMode == SaveMode.NEW)
                {
                    string suggestName = AppCount.Properties.Settings.Default.Proyecto.Nombre;
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.AddExtension = true;
                    sfd.DefaultExt = "ap";
                    sfd.Filter = "AppCount Project Files(*.ap)|*.ap";
                    sfd.RestoreDirectory = true;
                    sfd.Title = "Guardar archivo...";
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        FileManager fm = new FileManager(sfd.FileName);
                        AppCount.Properties.Settings.Default.ProyectoActivo = sfd.FileName;
                        if (!fm.writeObject(AppCount.Properties.Settings.Default.Proyecto))
                            throw new Exception();
                    }
                }
                else if (saveMode == SaveMode.EDIT)
                {
                    FileManager fm = new FileManager(AppCount.Properties.Settings.Default.ProyectoActivo);
                    if (!fm.writeObject(AppCount.Properties.Settings.Default.Proyecto))
                        throw new Exception();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Ocurrió un error al abrir el archivo. Favor de verificar", "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveFile(saveMode);
            }

            return true;
        }

        #endregion

    }
}
