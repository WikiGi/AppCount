namespace AppCount.Documentos
{
    partial class EsquemasMayor
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
            this.flpEsquemas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpEsquemas
            // 
            this.flpEsquemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpEsquemas.AutoScroll = true;
            this.flpEsquemas.BackColor = System.Drawing.Color.Transparent;
            this.flpEsquemas.Location = new System.Drawing.Point(12, 84);
            this.flpEsquemas.Name = "flpEsquemas";
            this.flpEsquemas.Size = new System.Drawing.Size(1184, 493);
            this.flpEsquemas.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Navy;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1074, 584);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 40);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(14, 50);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(5);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(128, 26);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "Periodo del ";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(14, 14);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(5);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(110, 26);
            this.lblProyecto.TabIndex = 17;
            this.lblProyecto.Text = "Proyecto: ";
            // 
            // EsquemasMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 637);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.flpEsquemas);
            this.Name = "EsquemasMayor";
            this.Text = "EsquemasMayor";
            this.Load += new System.EventHandler(this.EsquemasMayor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEsquemas;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblProyecto;
    }
}