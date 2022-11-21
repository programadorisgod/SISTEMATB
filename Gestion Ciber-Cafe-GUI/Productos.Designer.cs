namespace Gestion_Ciber_Cafe_GUI
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.grillaListaProductos = new System.Windows.Forms.DataGridView();
            this.labelListaProductos = new System.Windows.Forms.Label();
            this.panelLateralDetalleProducto = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.mostraretiqueta = new System.Windows.Forms.CheckBox();
            this.btnGenerarCodigoBarras = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBoxValorVenta = new System.Windows.Forms.TextBox();
            this.labelValorVenta = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDetalleProducto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPrincipal.SuspendLayout();
            this.tabPageProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaListaProductos)).BeginInit();
            this.panelLateralDetalleProducto.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Controls.Add(this.tabPageProductos);
            this.tabPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.Location = new System.Drawing.Point(-5, 37);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Drawing.Point(0, 0);
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(961, 464);
            this.tabPrincipal.TabIndex = 13;
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPageProductos.Controls.Add(this.panel1);
            this.tabPageProductos.Controls.Add(this.panelLateralDetalleProducto);
            this.tabPageProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProductos.Location = new System.Drawing.Point(4, 4);
            this.tabPageProductos.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Size = new System.Drawing.Size(953, 438);
            this.tabPageProductos.TabIndex = 0;
            this.tabPageProductos.Text = "Productos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.labelBuscar);
            this.panel1.Controls.Add(this.grillaListaProductos);
            this.panel1.Controls.Add(this.labelListaProductos);
            this.panel1.Location = new System.Drawing.Point(239, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 438);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources._64673;
            this.pictureBox6.Location = new System.Drawing.Point(679, 24);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            this.pictureBox6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseMove);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Location = new System.Drawing.Point(484, 24);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(190, 20);
            this.textBoxBuscar.TabIndex = 4;
            // 
            // labelBuscar
            // 
            this.labelBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(426, 25);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(52, 16);
            this.labelBuscar.TabIndex = 3;
            this.labelBuscar.Text = "Buscar:";
            // 
            // grillaListaProductos
            // 
            this.grillaListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaListaProductos.BackgroundColor = System.Drawing.Color.Azure;
            this.grillaListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaListaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grillaListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaListaProductos.Location = new System.Drawing.Point(11, 54);
            this.grillaListaProductos.MultiSelect = false;
            this.grillaListaProductos.Name = "grillaListaProductos";
            this.grillaListaProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaListaProductos.RowHeadersVisible = false;
            this.grillaListaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grillaListaProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaListaProductos.Size = new System.Drawing.Size(690, 372);
            this.grillaListaProductos.TabIndex = 2;
            this.grillaListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaListaProductos_CellClick);
            this.grillaListaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaListaProductos_CellDoubleClick);
            // 
            // labelListaProductos
            // 
            this.labelListaProductos.AutoSize = true;
            this.labelListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaProductos.ForeColor = System.Drawing.Color.Indigo;
            this.labelListaProductos.Location = new System.Drawing.Point(7, 23);
            this.labelListaProductos.Name = "labelListaProductos";
            this.labelListaProductos.Size = new System.Drawing.Size(182, 24);
            this.labelListaProductos.TabIndex = 1;
            this.labelListaProductos.Text = "Lista de Productos";
            // 
            // panelLateralDetalleProducto
            // 
            this.panelLateralDetalleProducto.AutoScroll = true;
            this.panelLateralDetalleProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelLateralDetalleProducto.Controls.Add(this.labelError);
            this.panelLateralDetalleProducto.Controls.Add(this.mostraretiqueta);
            this.panelLateralDetalleProducto.Controls.Add(this.btnGenerarCodigoBarras);
            this.panelLateralDetalleProducto.Controls.Add(this.panelSubMenu);
            this.panelLateralDetalleProducto.Controls.Add(this.textBoxValorVenta);
            this.panelLateralDetalleProducto.Controls.Add(this.labelValorVenta);
            this.panelLateralDetalleProducto.Controls.Add(this.textBoxDescripcion);
            this.panelLateralDetalleProducto.Controls.Add(this.labelDescripcion);
            this.panelLateralDetalleProducto.Controls.Add(this.textBoxNombre);
            this.panelLateralDetalleProducto.Controls.Add(this.labelNombre);
            this.panelLateralDetalleProducto.Controls.Add(this.textBoxCodigo);
            this.panelLateralDetalleProducto.Controls.Add(this.labelCodigo);
            this.panelLateralDetalleProducto.Controls.Add(this.labelDetalleProducto);
            this.panelLateralDetalleProducto.Controls.Add(this.pictureBox1);
            this.panelLateralDetalleProducto.Controls.Add(this.pictureBox2);
            this.panelLateralDetalleProducto.Controls.Add(this.pictureBox3);
            this.panelLateralDetalleProducto.Controls.Add(this.pictureBox7);
            this.panelLateralDetalleProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralDetalleProducto.Location = new System.Drawing.Point(0, 0);
            this.panelLateralDetalleProducto.Name = "panelLateralDetalleProducto";
            this.panelLateralDetalleProducto.Size = new System.Drawing.Size(239, 438);
            this.panelLateralDetalleProducto.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelError.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.importante__1_;
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelError.Location = new System.Drawing.Point(40, 271);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(72, 13);
            this.labelError.TabIndex = 135;
            this.labelError.Text = "ErrorMessage";
            this.labelError.Visible = false;
            // 
            // mostraretiqueta
            // 
            this.mostraretiqueta.AutoSize = true;
            this.mostraretiqueta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mostraretiqueta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mostraretiqueta.Location = new System.Drawing.Point(33, 333);
            this.mostraretiqueta.Name = "mostraretiqueta";
            this.mostraretiqueta.Size = new System.Drawing.Size(154, 17);
            this.mostraretiqueta.TabIndex = 133;
            this.mostraretiqueta.Text = "Mostrar Codigo en Etiqueta";
            this.mostraretiqueta.UseVisualStyleBackColor = false;
            // 
            // btnGenerarCodigoBarras
            // 
            this.btnGenerarCodigoBarras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerarCodigoBarras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCodigoBarras.Location = new System.Drawing.Point(13, 287);
            this.btnGenerarCodigoBarras.Name = "btnGenerarCodigoBarras";
            this.btnGenerarCodigoBarras.Size = new System.Drawing.Size(212, 40);
            this.btnGenerarCodigoBarras.TabIndex = 11;
            this.btnGenerarCodigoBarras.Text = "Generar Codigo";
            this.btnGenerarCodigoBarras.UseVisualStyleBackColor = false;
            this.btnGenerarCodigoBarras.Click += new System.EventHandler(this.btnGenerarCodigoBarras_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSubMenu.Controls.Add(this.btnEliminar);
            this.panelSubMenu.Controls.Add(this.btnGuardar);
            this.panelSubMenu.Location = new System.Drawing.Point(0, 357);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(239, 78);
            this.panelSubMenu.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(239, 39);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(239, 39);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBoxValorVenta
            // 
            this.textBoxValorVenta.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxValorVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorVenta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorVenta.Location = new System.Drawing.Point(13, 187);
            this.textBoxValorVenta.Name = "textBoxValorVenta";
            this.textBoxValorVenta.Size = new System.Drawing.Size(212, 16);
            this.textBoxValorVenta.TabIndex = 8;
            this.textBoxValorVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxValorVenta_KeyDown);
            this.textBoxValorVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorVenta_KeyPress);
            // 
            // labelValorVenta
            // 
            this.labelValorVenta.AutoSize = true;
            this.labelValorVenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVenta.Location = new System.Drawing.Point(13, 165);
            this.labelValorVenta.Name = "labelValorVenta";
            this.labelValorVenta.Size = new System.Drawing.Size(107, 19);
            this.labelValorVenta.TabIndex = 7;
            this.labelValorVenta.Text = "Valor de Venta:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(13, 235);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescripcion.Size = new System.Drawing.Size(212, 16);
            this.textBoxDescripcion.TabIndex = 6;
            this.textBoxDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDescripcion_KeyDown);
            this.textBoxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescripcion_KeyPress);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(13, 213);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(89, 19);
            this.labelDescripcion.TabIndex = 5;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(13, 139);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(212, 16);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombre_KeyDown);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(13, 117);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 19);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(13, 91);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(212, 16);
            this.textBoxCodigo.TabIndex = 2;
            this.textBoxCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigo_KeyDown);
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(13, 69);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(58, 19);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Codigo:";
            // 
            // labelDetalleProducto
            // 
            this.labelDetalleProducto.AutoSize = true;
            this.labelDetalleProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleProducto.ForeColor = System.Drawing.Color.Indigo;
            this.labelDetalleProducto.Location = new System.Drawing.Point(13, 23);
            this.labelDetalleProducto.Name = "labelDetalleProducto";
            this.labelDetalleProducto.Size = new System.Drawing.Size(194, 24);
            this.labelDetalleProducto.TabIndex = 0;
            this.labelDetalleProducto.Text = "Detalle de Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.linea;
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 4);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.linea;
            this.pictureBox2.Location = new System.Drawing.Point(12, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 4);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.linea;
            this.pictureBox3.Location = new System.Drawing.Point(12, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 4);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.linea;
            this.pictureBox7.Location = new System.Drawing.Point(12, 252);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(214, 4);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.equis_salir;
            this.pictureBox4.Location = new System.Drawing.Point(917, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox5.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources.minimizar1;
            this.pictureBox5.Location = new System.Drawing.Point(889, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(951, 500);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tabPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(951, 500);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Productos_MouseDown);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaListaProductos)).EndInit();
            this.panelLateralDetalleProducto.ResumeLayout(false);
            this.panelLateralDetalleProducto.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.Panel panelLateralDetalleProducto;
        private System.Windows.Forms.Label labelDetalleProducto;
        private System.Windows.Forms.TextBox textBoxValorVenta;
        private System.Windows.Forms.Label labelValorVenta;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button btnGenerarCodigoBarras;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView grillaListaProductos;
        private System.Windows.Forms.Label labelListaProductos;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.CheckBox mostraretiqueta;
        private System.Windows.Forms.Label labelError;
    }
}