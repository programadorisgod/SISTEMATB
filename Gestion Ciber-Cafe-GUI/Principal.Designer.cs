namespace Gestion_Ciber_Cafe_GUI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.SubMenuSalidas = new System.Windows.Forms.Panel();
            this.btnDetalleVentas = new System.Windows.Forms.Button();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelMarca = new System.Windows.Forms.Label();
            this.linkLabelPrincipal = new System.Windows.Forms.LinkLabel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelTitulo2 = new System.Windows.Forms.Label();
            this.labelTitulo1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral.SuspendLayout();
            this.SubMenuSalidas.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelMenuLateral.Controls.Add(this.SubMenuSalidas);
            this.panelMenuLateral.Controls.Add(this.btnSalidas);
            this.panelMenuLateral.Controls.Add(this.panelInfo);
            this.panelMenuLateral.Controls.Add(this.btnProveedores);
            this.panelMenuLateral.Controls.Add(this.btnClientes);
            this.panelMenuLateral.Controls.Add(this.btnProductos);
            this.panelMenuLateral.Controls.Add(this.btnEntradas);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 500);
            this.panelMenuLateral.TabIndex = 11;
            // 
            // SubMenuSalidas
            // 
            this.SubMenuSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SubMenuSalidas.Controls.Add(this.btnDetalleVentas);
            this.SubMenuSalidas.Controls.Add(this.btnReporteVentas);
            this.SubMenuSalidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuSalidas.Location = new System.Drawing.Point(0, 325);
            this.SubMenuSalidas.Name = "SubMenuSalidas";
            this.SubMenuSalidas.Size = new System.Drawing.Size(233, 94);
            this.SubMenuSalidas.TabIndex = 10;
            // 
            // btnDetalleVentas
            // 
            this.btnDetalleVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetalleVentas.FlatAppearance.BorderSize = 0;
            this.btnDetalleVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDetalleVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetalleVentas.Location = new System.Drawing.Point(0, 45);
            this.btnDetalleVentas.Name = "btnDetalleVentas";
            this.btnDetalleVentas.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnDetalleVentas.Size = new System.Drawing.Size(233, 45);
            this.btnDetalleVentas.TabIndex = 11;
            this.btnDetalleVentas.Text = "Detalle de ventas";
            this.btnDetalleVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleVentas.UseVisualStyleBackColor = true;
            this.btnDetalleVentas.Click += new System.EventHandler(this.btnDetalleVentas_Click);
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteVentas.FlatAppearance.BorderSize = 0;
            this.btnReporteVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReporteVentas.Location = new System.Drawing.Point(0, 0);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnReporteVentas.Size = new System.Drawing.Size(233, 45);
            this.btnReporteVentas.TabIndex = 10;
            this.btnReporteVentas.Text = "Reporte de ventas";
            this.btnReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalidas.FlatAppearance.BorderSize = 0;
            this.btnSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalidas.Location = new System.Drawing.Point(0, 280);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSalidas.Size = new System.Drawing.Size(233, 45);
            this.btnSalidas.TabIndex = 9;
            this.btnSalidas.Text = "Salidas";
            this.btnSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelMarca);
            this.panelInfo.Controls.Add(this.linkLabelPrincipal);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 419);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(233, 100);
            this.panelInfo.TabIndex = 8;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMarca.Location = new System.Drawing.Point(53, 36);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(129, 14);
            this.labelMarca.TabIndex = 11;
            this.labelMarca.Text = "© Tapias-Bermudez 2022";
            // 
            // linkLabelPrincipal
            // 
            this.linkLabelPrincipal.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkLabelPrincipal.AutoSize = true;
            this.linkLabelPrincipal.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabelPrincipal.Location = new System.Drawing.Point(72, 55);
            this.linkLabelPrincipal.Name = "linkLabelPrincipal";
            this.linkLabelPrincipal.Size = new System.Drawing.Size(85, 13);
            this.linkLabelPrincipal.TabIndex = 10;
            this.linkLabelPrincipal.TabStop = true;
            this.linkLabelPrincipal.Text = "Quienes somos?";
            this.linkLabelPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPrincipal_LinkClicked_1);
            this.linkLabelPrincipal.MouseLeave += new System.EventHandler(this.linkLabelPrincipal_MouseLeave);
            this.linkLabelPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.linkLabelPrincipal_MouseMove);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProveedores.Location = new System.Drawing.Point(0, 235);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(233, 45);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Location = new System.Drawing.Point(0, 190);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(233, 45);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.Location = new System.Drawing.Point(0, 145);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(233, 45);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntradas.Location = new System.Drawing.Point(0, 100);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEntradas.Size = new System.Drawing.Size(233, 45);
            this.btnEntradas.TabIndex = 1;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLogo.Controls.Add(this.labelTitulo2);
            this.panelLogo.Controls.Add(this.labelTitulo1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // labelTitulo2
            // 
            this.labelTitulo2.AutoSize = true;
            this.labelTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelTitulo2.Location = new System.Drawing.Point(72, 47);
            this.labelTitulo2.Name = "labelTitulo2";
            this.labelTitulo2.Size = new System.Drawing.Size(121, 25);
            this.labelTitulo2.TabIndex = 1;
            this.labelTitulo2.Text = "Inventario";
            // 
            // labelTitulo1
            // 
            this.labelTitulo1.AutoSize = true;
            this.labelTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelTitulo1.Location = new System.Drawing.Point(43, 24);
            this.labelTitulo1.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitulo1.Name = "labelTitulo1";
            this.labelTitulo1.Size = new System.Drawing.Size(94, 25);
            this.labelTitulo1.TabIndex = 0;
            this.labelTitulo1.Text = "Sistema";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.iStock_957065332_1024x768;
            this.pictureBoxLogo.Location = new System.Drawing.Point(250, 37);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(702, 463);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox5.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.minimizar1;
            this.pictureBox5.Location = new System.Drawing.Point(887, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.equis_salir;
            this.pictureBox4.Location = new System.Drawing.Point(915, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(951, 500);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(951, 500);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Principal_MouseDown);
            this.panelMenuLateral.ResumeLayout(false);
            this.SubMenuSalidas.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitulo2;
        private System.Windows.Forms.Label labelTitulo1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.LinkLabel linkLabelPrincipal;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Panel SubMenuSalidas;
        private System.Windows.Forms.Button btnDetalleVentas;
        private System.Windows.Forms.Button btnReporteVentas;
    }
}

