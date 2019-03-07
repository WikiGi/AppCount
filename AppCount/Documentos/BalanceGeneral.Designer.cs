namespace AppCount.Documentos
{
    partial class BalanceGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvActivo = new System.Windows.Forms.DataGridView();
            this.colACuentaPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPasivo = new System.Windows.Forms.DataGridView();
            this.colPCuentaPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActivo
            // 
            this.dgvActivo.AllowUserToAddRows = false;
            this.dgvActivo.AllowUserToDeleteRows = false;
            this.dgvActivo.AllowUserToResizeRows = false;
            this.dgvActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colACuentaPK,
            this.colACuenta,
            this.colA1,
            this.colA2,
            this.colA3,
            this.colA4});
            this.dgvActivo.Location = new System.Drawing.Point(5, 5);
            this.dgvActivo.Margin = new System.Windows.Forms.Padding(5);
            this.dgvActivo.MinimumSize = new System.Drawing.Size(10, 10);
            this.dgvActivo.Name = "dgvActivo";
            this.dgvActivo.ReadOnly = true;
            this.dgvActivo.RowHeadersVisible = false;
            this.dgvActivo.RowTemplate.Height = 28;
            this.dgvActivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivo.Size = new System.Drawing.Size(442, 479);
            this.dgvActivo.TabIndex = 0;
            // 
            // colACuentaPK
            // 
            this.colACuentaPK.HeaderText = "CuentaPK";
            this.colACuentaPK.Name = "colACuentaPK";
            this.colACuentaPK.ReadOnly = true;
            this.colACuentaPK.Visible = false;
            // 
            // colACuenta
            // 
            this.colACuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colACuenta.HeaderText = "Cuenta";
            this.colACuenta.MinimumWidth = 100;
            this.colACuenta.Name = "colACuenta";
            this.colACuenta.ReadOnly = true;
            // 
            // colA1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "C2";
            this.colA1.DefaultCellStyle = dataGridViewCellStyle1;
            this.colA1.HeaderText = "1";
            this.colA1.Name = "colA1";
            this.colA1.ReadOnly = true;
            this.colA1.Width = 25;
            // 
            // colA2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "C2";
            this.colA2.DefaultCellStyle = dataGridViewCellStyle2;
            this.colA2.HeaderText = "2";
            this.colA2.Name = "colA2";
            this.colA2.ReadOnly = true;
            this.colA2.Width = 25;
            // 
            // colA3
            // 
            this.colA3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "C2";
            this.colA3.DefaultCellStyle = dataGridViewCellStyle3;
            this.colA3.HeaderText = "3";
            this.colA3.Name = "colA3";
            this.colA3.ReadOnly = true;
            this.colA3.Width = 5;
            // 
            // colA4
            // 
            this.colA4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "C2";
            this.colA4.DefaultCellStyle = dataGridViewCellStyle4;
            this.colA4.HeaderText = "4";
            this.colA4.Name = "colA4";
            this.colA4.ReadOnly = true;
            this.colA4.Width = 5;
            // 
            // dgvPasivo
            // 
            this.dgvPasivo.AllowUserToAddRows = false;
            this.dgvPasivo.AllowUserToDeleteRows = false;
            this.dgvPasivo.AllowUserToResizeRows = false;
            this.dgvPasivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPCuentaPK,
            this.colPCuenta,
            this.colP1,
            this.colP2,
            this.colP3,
            this.colP4});
            this.dgvPasivo.Location = new System.Drawing.Point(5, 5);
            this.dgvPasivo.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPasivo.MinimumSize = new System.Drawing.Size(10, 10);
            this.dgvPasivo.Name = "dgvPasivo";
            this.dgvPasivo.ReadOnly = true;
            this.dgvPasivo.RowHeadersVisible = false;
            this.dgvPasivo.RowTemplate.Height = 28;
            this.dgvPasivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasivo.Size = new System.Drawing.Size(446, 479);
            this.dgvPasivo.TabIndex = 0;
            // 
            // colPCuentaPK
            // 
            this.colPCuentaPK.HeaderText = "CuentaPK";
            this.colPCuentaPK.Name = "colPCuentaPK";
            this.colPCuentaPK.ReadOnly = true;
            this.colPCuentaPK.Visible = false;
            // 
            // colPCuenta
            // 
            this.colPCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPCuenta.HeaderText = "Cuenta";
            this.colPCuenta.MinimumWidth = 100;
            this.colPCuenta.Name = "colPCuenta";
            this.colPCuenta.ReadOnly = true;
            // 
            // colP1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "C2";
            this.colP1.DefaultCellStyle = dataGridViewCellStyle5;
            this.colP1.HeaderText = "1";
            this.colP1.Name = "colP1";
            this.colP1.ReadOnly = true;
            this.colP1.Width = 25;
            // 
            // colP2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "C2";
            this.colP2.DefaultCellStyle = dataGridViewCellStyle6;
            this.colP2.HeaderText = "2";
            this.colP2.Name = "colP2";
            this.colP2.ReadOnly = true;
            this.colP2.Width = 25;
            // 
            // colP3
            // 
            this.colP3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "C2";
            this.colP3.DefaultCellStyle = dataGridViewCellStyle7;
            this.colP3.HeaderText = "3";
            this.colP3.Name = "colP3";
            this.colP3.ReadOnly = true;
            this.colP3.Width = 5;
            // 
            // colP4
            // 
            this.colP4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Format = "C2";
            this.colP4.DefaultCellStyle = dataGridViewCellStyle8;
            this.colP4.HeaderText = "4";
            this.colP4.Name = "colP4";
            this.colP4.ReadOnly = true;
            this.colP4.Width = 5;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer.Location = new System.Drawing.Point(12, 84);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.dgvActivo);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.dgvPasivo);
            this.SplitContainer.Size = new System.Drawing.Size(920, 493);
            this.SplitContainer.SplitterDistance = 456;
            this.SplitContainer.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Navy;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(810, 584);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 40);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(14, 14);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(5);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(110, 26);
            this.lblProyecto.TabIndex = 13;
            this.lblProyecto.Text = "Proyecto: ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(14, 50);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(5);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(198, 26);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "Balance general al ";
            // 
            // BalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 637);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.SplitContainer);
            this.Name = "BalanceGeneral";
            this.Text = "Balance General";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivo)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivo;
        private System.Windows.Forms.DataGridView dgvPasivo;
        private System.Windows.Forms.SplitContainer SplitContainer;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACuentaPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPCuentaPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP4;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblBalance;

    }
}