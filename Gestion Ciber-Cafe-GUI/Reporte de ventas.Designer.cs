namespace Gestion_Ciber_Cafe_GUI
{
    partial class Reporte_de_ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrillaReportes = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.Fechafinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechainicial = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.GrillaReportes);
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.Fechafinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.fechainicial);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 623);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GrillaReportes
            // 
            this.GrillaReportes.AllowUserToAddRows = false;
            this.GrillaReportes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.DocCliente,
            this.Cliente,
            this.NombreProducto,
            this.CodigoProd,
            this.DescripcionProd,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.MontoTotal});
            this.GrillaReportes.Location = new System.Drawing.Point(16, 148);
            this.GrillaReportes.MultiSelect = false;
            this.GrillaReportes.Name = "GrillaReportes";
            this.GrillaReportes.ReadOnly = true;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.GrillaReportes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaReportes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.GrillaReportes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GrillaReportes.RowTemplate.Height = 24;
            this.GrillaReportes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaReportes.Size = new System.Drawing.Size(1132, 423);
            this.GrillaReportes.TabIndex = 151;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // DocCliente
            // 
            this.DocCliente.HeaderText = "Nº Identificacion";
            this.DocCliente.Name = "DocCliente";
            this.DocCliente.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cliente.Width = 150;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // CodigoProd
            // 
            this.CodigoProd.HeaderText = "Codigo Producto";
            this.CodigoProd.Name = "CodigoProd";
            this.CodigoProd.ReadOnly = true;
            this.CodigoProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodigoProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoProd.Width = 120;
            // 
            // DescripcionProd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripcionProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.DescripcionProd.HeaderText = "Descripcion Producto";
            this.DescripcionProd.Name = "DescripcionProd";
            this.DescripcionProd.ReadOnly = true;
            this.DescripcionProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripcionProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescripcionProd.Width = 130;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.arrow_left_12777;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(1015, 577);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 1);
            this.btnRegresar.Size = new System.Drawing.Size(127, 33);
            this.btnRegresar.TabIndex = 150;
            this.btnRegresar.Text = "       Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 144;
            this.label1.Text = "Reporte de ventas";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(-6, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1172, 61);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBuscar.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources._64673;
            this.btnBuscar.Location = new System.Drawing.Point(632, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 20);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 141;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Fechafinal
            // 
            this.Fechafinal.Location = new System.Drawing.Point(426, 77);
            this.Fechafinal.Name = "Fechafinal";
            this.Fechafinal.Size = new System.Drawing.Size(200, 20);
            this.Fechafinal.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Fecha Final:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(9, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1131, 11);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            // 
            // fechainicial
            // 
            this.fechainicial.Location = new System.Drawing.Point(99, 78);
            this.fechainicial.Name = "fechainicial";
            this.fechainicial.Size = new System.Drawing.Size(200, 20);
            this.fechainicial.TabIndex = 118;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(24, 85);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 13);
            this.label27.TabIndex = 117;
            this.label27.Text = "Fecha inicial:";
            // 
            // Reporte_de_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 627);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_de_ventas";
            this.Text = "Reporte_de_ventas";
            this.Load += new System.EventHandler(this.Reporte_de_ventas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Reporte_de_ventas_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fechainicial;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.DateTimePicker Fechafinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView GrillaReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
    }
}