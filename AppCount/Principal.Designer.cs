namespace AppCount
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarOperacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarOperaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquemasDeMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanzaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasGuardadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpInformacionProyecto = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInformacionProyectoActivo = new System.Windows.Forms.Label();
            this.flpControlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.msPrincipal.SuspendLayout();
            this.flpInformacionProyecto.SuspendLayout();
            this.flpControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msPrincipal.AutoSize = false;
            this.msPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.msPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.msPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(3, 4);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msPrincipal.Size = new System.Drawing.Size(1048, 40);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoToolStripMenuItem,
            this.editarProyectoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cerrarToolStripMenuItem});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.proyectosToolStripMenuItem.Text = "Archivo";
            // 
            // crearNuevoToolStripMenuItem
            // 
            this.crearNuevoToolStripMenuItem.Name = "crearNuevoToolStripMenuItem";
            this.crearNuevoToolStripMenuItem.Size = new System.Drawing.Size(323, 30);
            this.crearNuevoToolStripMenuItem.Text = "Crear nuevo proyecto...";
            this.crearNuevoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoToolStripMenuItem_Click);
            // 
            // editarProyectoToolStripMenuItem
            // 
            this.editarProyectoToolStripMenuItem.Name = "editarProyectoToolStripMenuItem";
            this.editarProyectoToolStripMenuItem.Size = new System.Drawing.Size(323, 30);
            this.editarProyectoToolStripMenuItem.Text = "Editar proyecto";
            this.editarProyectoToolStripMenuItem.Click += new System.EventHandler(this.editarProyectoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(323, 30);
            this.abrirToolStripMenuItem.Text = "Abrir proyecto...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(320, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(323, 30);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(323, 30);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(320, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(323, 30);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOperacionToolStripMenuItem,
            this.editarOperaciónToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // agregarOperacionToolStripMenuItem
            // 
            this.agregarOperacionToolStripMenuItem.Name = "agregarOperacionToolStripMenuItem";
            this.agregarOperacionToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.agregarOperacionToolStripMenuItem.Text = "Agregar operación";
            this.agregarOperacionToolStripMenuItem.Click += new System.EventHandler(this.agregarOperacionToolStripMenuItem_Click);
            // 
            // editarOperaciónToolStripMenuItem
            // 
            this.editarOperaciónToolStripMenuItem.Name = "editarOperaciónToolStripMenuItem";
            this.editarOperaciónToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.editarOperaciónToolStripMenuItem.Text = "Ver operaciones";
            this.editarOperaciónToolStripMenuItem.Click += new System.EventHandler(this.editarOperaciónToolStripMenuItem_Click);
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquemasDeMayorToolStripMenuItem,
            this.balanzaGeneralToolStripMenuItem,
            this.estadoDeResultadosToolStripMenuItem});
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // esquemasDeMayorToolStripMenuItem
            // 
            this.esquemasDeMayorToolStripMenuItem.Name = "esquemasDeMayorToolStripMenuItem";
            this.esquemasDeMayorToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.esquemasDeMayorToolStripMenuItem.Text = "Esquemas de mayor";
            this.esquemasDeMayorToolStripMenuItem.Click += new System.EventHandler(this.esquemasDeMayorToolStripMenuItem_Click);
            // 
            // balanzaGeneralToolStripMenuItem
            // 
            this.balanzaGeneralToolStripMenuItem.Name = "balanzaGeneralToolStripMenuItem";
            this.balanzaGeneralToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.balanzaGeneralToolStripMenuItem.Text = "Balanza general";
            this.balanzaGeneralToolStripMenuItem.Click += new System.EventHandler(this.balanzaGeneralToolStripMenuItem_Click);
            // 
            // estadoDeResultadosToolStripMenuItem
            // 
            this.estadoDeResultadosToolStripMenuItem.Name = "estadoDeResultadosToolStripMenuItem";
            this.estadoDeResultadosToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.estadoDeResultadosToolStripMenuItem.Text = "Estado de resultados";
            this.estadoDeResultadosToolStripMenuItem.Click += new System.EventHandler(this.estadoDeResultadosToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasGuardadasToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // cuentasGuardadasToolStripMenuItem
            // 
            this.cuentasGuardadasToolStripMenuItem.Name = "cuentasGuardadasToolStripMenuItem";
            this.cuentasGuardadasToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.cuentasGuardadasToolStripMenuItem.Text = "Cuentas guardadas";
            this.cuentasGuardadasToolStripMenuItem.Click += new System.EventHandler(this.cuentasGuardadasToolStripMenuItem_Click);
            // 
            // flpInformacionProyecto
            // 
            this.flpInformacionProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInformacionProyecto.BackColor = System.Drawing.Color.Navy;
            this.flpInformacionProyecto.Controls.Add(this.lblInformacionProyectoActivo);
            this.flpInformacionProyecto.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpInformacionProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpInformacionProyecto.Location = new System.Drawing.Point(0, 524);
            this.flpInformacionProyecto.Name = "flpInformacionProyecto";
            this.flpInformacionProyecto.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flpInformacionProyecto.Size = new System.Drawing.Size(1054, 30);
            this.flpInformacionProyecto.TabIndex = 1;
            // 
            // lblInformacionProyectoActivo
            // 
            this.lblInformacionProyectoActivo.AutoSize = true;
            this.lblInformacionProyectoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionProyectoActivo.ForeColor = System.Drawing.Color.White;
            this.lblInformacionProyectoActivo.Location = new System.Drawing.Point(1041, 0);
            this.lblInformacionProyectoActivo.Name = "lblInformacionProyectoActivo";
            this.lblInformacionProyectoActivo.Size = new System.Drawing.Size(0, 26);
            this.lblInformacionProyectoActivo.TabIndex = 0;
            this.lblInformacionProyectoActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpControlBox
            // 
            this.flpControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpControlBox.BackColor = System.Drawing.Color.Transparent;
            this.flpControlBox.Controls.Add(this.pbClose);
            this.flpControlBox.Controls.Add(this.pbMinimize);
            this.flpControlBox.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpControlBox.Location = new System.Drawing.Point(867, 17);
            this.flpControlBox.Margin = new System.Windows.Forms.Padding(4);
            this.flpControlBox.Name = "flpControlBox";
            this.flpControlBox.Size = new System.Drawing.Size(169, 40);
            this.flpControlBox.TabIndex = 4;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = global::AppCount.Properties.Resources.XBlack;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClose.Location = new System.Drawing.Point(129, 4);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(36, 32);
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbCerrar_Click);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbCerrar_MouseLeave);
            this.pbClose.MouseHover += new System.EventHandler(this.pbCerrar_MouseHover);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.BackgroundImage = global::AppCount.Properties.Resources.MinimizeBlack;
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMinimize.Location = new System.Drawing.Point(85, 4);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(36, 32);
            this.pbMinimize.TabIndex = 4;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            this.pbMinimize.MouseHover += new System.EventHandler(this.pbMinimize_MouseHover);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppCount.Properties.Resources.AppCount;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1054, 554);
            this.Controls.Add(this.flpControlBox);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.flpInformacionProyecto);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.SizeChanged += new System.EventHandler(this.Principal_SizeChanged);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.flpInformacionProyecto.ResumeLayout(false);
            this.flpInformacionProyecto.PerformLayout();
            this.flpControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarOperacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarOperaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquemasDeMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanzaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasGuardadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProyectoToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpInformacionProyecto;
        private System.Windows.Forms.Label lblInformacionProyectoActivo;
        private System.Windows.Forms.FlowLayoutPanel flpControlBox;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;


    }
}

