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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fechafinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grillaRVentas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.fechainicial = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBuscar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Fechafinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grillaRVentas);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.fechainicial);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 605);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBuscar
            // 
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Items.AddRange(new object[] {
            "Numero de documento ",
            "Fecha de venta"});
            this.comboBuscar.Location = new System.Drawing.Point(103, 136);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBuscar.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 142;
            this.label3.Text = "Buscar por : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources._64673;
            this.pictureBox1.Location = new System.Drawing.Point(613, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // Fechafinal
            // 
            this.Fechafinal.Location = new System.Drawing.Point(407, 67);
            this.Fechafinal.Name = "Fechafinal";
            this.Fechafinal.Size = new System.Drawing.Size(200, 20);
            this.Fechafinal.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Fecha Final:";
            // 
            // grillaRVentas
            // 
            this.grillaRVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaRVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaRVentas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grillaRVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaRVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grillaRVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaRVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaRVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRVentas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grillaRVentas.Location = new System.Drawing.Point(16, 243);
            this.grillaRVentas.MultiSelect = false;
            this.grillaRVentas.Name = "grillaRVentas";
            this.grillaRVentas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaRVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaRVentas.RowHeadersVisible = false;
            this.grillaRVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grillaRVentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaRVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaRVentas.Size = new System.Drawing.Size(883, 319);
            this.grillaRVentas.TabIndex = 138;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 12);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBuscar.Image = global::Gestion_Ciber_Cafe_GUI.Properties.Resources._64673;
            this.btnBuscar.Location = new System.Drawing.Point(369, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(22, 20);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 125;
            this.btnBuscar.TabStop = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(230, 136);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(133, 20);
            this.txtbuscar.TabIndex = 123;
            // 
            // fechainicial
            // 
            this.fechainicial.Location = new System.Drawing.Point(80, 68);
            this.fechainicial.Name = "fechainicial";
            this.fechainicial.Size = new System.Drawing.Size(200, 20);
            this.fechainicial.TabIndex = 118;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(10, 74);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 13);
            this.label27.TabIndex = 117;
            this.label27.Text = "Fecha inicial:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(-6, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(914, 61);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(902, 12);
            this.groupBox3.TabIndex = 145;
            this.groupBox3.TabStop = false;
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
            this.btnRegresar.Location = new System.Drawing.Point(772, 16);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 1);
            this.btnRegresar.Size = new System.Drawing.Size(127, 33);
            this.btnRegresar.TabIndex = 150;
            this.btnRegresar.Text = "       Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // Reporte_de_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 636);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reporte_de_ventas";
            this.Text = "Reporte_de_ventas";
            this.Load += new System.EventHandler(this.Reporte_de_ventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaRVentas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.DateTimePicker fechainicial;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker Fechafinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
    }
}