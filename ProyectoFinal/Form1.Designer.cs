namespace ProyectoFinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConectar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.labelAño = new System.Windows.Forms.Label();
            this.labelFinalista1 = new System.Windows.Forms.Label();
            this.labelFinalista2 = new System.Windows.Forms.Label();
            this.labelCampeon = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelCede = new System.Windows.Forms.Label();
            this.labelGoleador = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxPrimerEquipo = new System.Windows.Forms.TextBox();
            this.textBoxSegundoEquipo = new System.Windows.Forms.TextBox();
            this.textBoxCampeon = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxCede = new System.Windows.Forms.TextBox();
            this.textBoxGoleador = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.numericUpDownAño = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonBuscarPorAño = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConectar.BackgroundImage")));
            this.buttonConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConectar.CausesValidation = false;
            this.buttonConectar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConectar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConectar.Location = new System.Drawing.Point(54, 12);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(118, 52);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCargar.BackgroundImage")));
            this.buttonCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCargar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCargar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCargar.Location = new System.Drawing.Point(216, 13);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(118, 52);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Mostrar Datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.BackColor = System.Drawing.Color.Transparent;
            this.labelAño.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAño.Location = new System.Drawing.Point(22, 43);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(68, 31);
            this.labelAño.TabIndex = 3;
            this.labelAño.Text = "Año:";
            // 
            // labelFinalista1
            // 
            this.labelFinalista1.AutoSize = true;
            this.labelFinalista1.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalista1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalista1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFinalista1.Location = new System.Drawing.Point(22, 107);
            this.labelFinalista1.Name = "labelFinalista1";
            this.labelFinalista1.Size = new System.Drawing.Size(168, 31);
            this.labelFinalista1.TabIndex = 4;
            this.labelFinalista1.Text = "Equipo Local:";
            // 
            // labelFinalista2
            // 
            this.labelFinalista2.AutoSize = true;
            this.labelFinalista2.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalista2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalista2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFinalista2.Location = new System.Drawing.Point(548, 107);
            this.labelFinalista2.Name = "labelFinalista2";
            this.labelFinalista2.Size = new System.Drawing.Size(210, 31);
            this.labelFinalista2.TabIndex = 5;
            this.labelFinalista2.Text = "Equipo Visitante:";
            // 
            // labelCampeon
            // 
            this.labelCampeon.AutoSize = true;
            this.labelCampeon.BackColor = System.Drawing.Color.Transparent;
            this.labelCampeon.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampeon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCampeon.Location = new System.Drawing.Point(22, 176);
            this.labelCampeon.Name = "labelCampeon";
            this.labelCampeon.Size = new System.Drawing.Size(130, 31);
            this.labelCampeon.TabIndex = 6;
            this.labelCampeon.Text = "Campeon:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.Color.Transparent;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelResultado.Location = new System.Drawing.Point(548, 176);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(136, 31);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Resultado:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFecha.Location = new System.Drawing.Point(33, 237);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(87, 31);
            this.labelFecha.TabIndex = 8;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelCede
            // 
            this.labelCede.AutoSize = true;
            this.labelCede.BackColor = System.Drawing.Color.Transparent;
            this.labelCede.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCede.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCede.Location = new System.Drawing.Point(548, 237);
            this.labelCede.Name = "labelCede";
            this.labelCede.Size = new System.Drawing.Size(77, 31);
            this.labelCede.TabIndex = 9;
            this.labelCede.Text = "Cede:";
            // 
            // labelGoleador
            // 
            this.labelGoleador.AutoSize = true;
            this.labelGoleador.BackColor = System.Drawing.Color.Transparent;
            this.labelGoleador.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoleador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGoleador.Location = new System.Drawing.Point(33, 311);
            this.labelGoleador.Name = "labelGoleador";
            this.labelGoleador.Size = new System.Drawing.Size(127, 31);
            this.labelGoleador.TabIndex = 10;
            this.labelGoleador.Text = "Goleador:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.BackColor = System.Drawing.Color.Transparent;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCantidad.Location = new System.Drawing.Point(548, 311);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(204, 31);
            this.labelCantidad.TabIndex = 11;
            this.labelCantidad.Text = "Goles marcados:";
            // 
            // textBoxPrimerEquipo
            // 
            this.textBoxPrimerEquipo.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrimerEquipo.Location = new System.Drawing.Point(212, 107);
            this.textBoxPrimerEquipo.Name = "textBoxPrimerEquipo";
            this.textBoxPrimerEquipo.Size = new System.Drawing.Size(219, 31);
            this.textBoxPrimerEquipo.TabIndex = 13;
            this.textBoxPrimerEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSegundoEquipo
            // 
            this.textBoxSegundoEquipo.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSegundoEquipo.Location = new System.Drawing.Point(797, 107);
            this.textBoxSegundoEquipo.Name = "textBoxSegundoEquipo";
            this.textBoxSegundoEquipo.Size = new System.Drawing.Size(199, 31);
            this.textBoxSegundoEquipo.TabIndex = 14;
            this.textBoxSegundoEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCampeon
            // 
            this.textBoxCampeon.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCampeon.Location = new System.Drawing.Point(212, 176);
            this.textBoxCampeon.Name = "textBoxCampeon";
            this.textBoxCampeon.Size = new System.Drawing.Size(219, 31);
            this.textBoxCampeon.TabIndex = 15;
            this.textBoxCampeon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultado.Location = new System.Drawing.Point(797, 176);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(199, 31);
            this.textBoxResultado.TabIndex = 16;
            this.textBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(363, 30);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // textBoxCede
            // 
            this.textBoxCede.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCede.Location = new System.Drawing.Point(797, 237);
            this.textBoxCede.Name = "textBoxCede";
            this.textBoxCede.Size = new System.Drawing.Size(199, 31);
            this.textBoxCede.TabIndex = 18;
            this.textBoxCede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGoleador
            // 
            this.textBoxGoleador.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGoleador.Location = new System.Drawing.Point(212, 311);
            this.textBoxGoleador.Name = "textBoxGoleador";
            this.textBoxGoleador.Size = new System.Drawing.Size(219, 31);
            this.textBoxGoleador.TabIndex = 19;
            this.textBoxGoleador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIngresar.BackgroundImage")));
            this.buttonIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonIngresar.Location = new System.Drawing.Point(385, 12);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(118, 52);
            this.buttonIngresar.TabIndex = 21;
            this.buttonIngresar.Text = "Agregar ";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // numericUpDownAño
            // 
            this.numericUpDownAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAño.Location = new System.Drawing.Point(102, 43);
            this.numericUpDownAño.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDownAño.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownAño.Name = "numericUpDownAño";
            this.numericUpDownAño.Size = new System.Drawing.Size(88, 30);
            this.numericUpDownAño.TabIndex = 22;
            this.numericUpDownAño.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.Location = new System.Drawing.Point(797, 311);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(68, 31);
            this.numericUpDownCantidad.TabIndex = 23;
            this.numericUpDownCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuscarPorAño
            // 
            this.buttonBuscarPorAño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscarPorAño.BackgroundImage")));
            this.buttonBuscarPorAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuscarPorAño.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarPorAño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscarPorAño.Location = new System.Drawing.Point(547, 12);
            this.buttonBuscarPorAño.Name = "buttonBuscarPorAño";
            this.buttonBuscarPorAño.Size = new System.Drawing.Size(118, 52);
            this.buttonBuscarPorAño.TabIndex = 24;
            this.buttonBuscarPorAño.Text = "Buscar por Año";
            this.buttonBuscarPorAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBuscarPorAño.UseVisualStyleBackColor = true;
            this.buttonBuscarPorAño.Click += new System.EventHandler(this.buttonBuscarPorAño_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonActualizar.BackgroundImage")));
            this.buttonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.Location = new System.Drawing.Point(714, 13);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(118, 51);
            this.buttonActualizar.TabIndex = 25;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(869, 13);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(118, 52);
            this.buttonEliminar.TabIndex = 26;
            this.buttonEliminar.Text = "Eliminar Registro";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.labelAño);
            this.groupBox1.Controls.Add(this.labelFinalista1);
            this.groupBox1.Controls.Add(this.labelFinalista2);
            this.groupBox1.Controls.Add(this.labelCampeon);
            this.groupBox1.Controls.Add(this.numericUpDownCantidad);
            this.groupBox1.Controls.Add(this.labelResultado);
            this.groupBox1.Controls.Add(this.numericUpDownAño);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.labelCede);
            this.groupBox1.Controls.Add(this.textBoxGoleador);
            this.groupBox1.Controls.Add(this.labelGoleador);
            this.groupBox1.Controls.Add(this.textBoxCede);
            this.groupBox1.Controls.Add(this.labelCantidad);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxPrimerEquipo);
            this.groupBox1.Controls.Add(this.textBoxResultado);
            this.groupBox1.Controls.Add(this.textBoxSegundoEquipo);
            this.groupBox1.Controls.Add(this.textBoxCampeon);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 363);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonBuscarPorAño);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Proyecto Final";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.Label labelFinalista1;
        private System.Windows.Forms.Label labelFinalista2;
        private System.Windows.Forms.Label labelCampeon;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelCede;
        private System.Windows.Forms.Label labelGoleador;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxPrimerEquipo;
        private System.Windows.Forms.TextBox textBoxSegundoEquipo;
        private System.Windows.Forms.TextBox textBoxCampeon;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxCede;
        private System.Windows.Forms.TextBox textBoxGoleador;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.NumericUpDown numericUpDownAño;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button buttonBuscarPorAño;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

