namespace parcial3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgVehiculos = new System.Windows.Forms.DataGridView();
            this.btnRegistrarOrdenServicio = new System.Windows.Forms.Button();
            this.txtMontoCancelado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaServicio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgOrdenesServicio = new System.Windows.Forms.DataGridView();
            this.dgFiltros = new System.Windows.Forms.DataGridView();
            this.btnMayorNumOrdenes = new System.Windows.Forms.Button();
            this.btnNumPlaca = new System.Windows.Forms.Button();
            this.btnMontoTotal = new System.Windows.Forms.Button();
            this.btnMenorMantenimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenesServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(222, 67);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(222, 121);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N tarjeta Propiedad";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(222, 187);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(505, 183);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha ultimo ingreso";
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(482, 117);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(100, 20);
            this.txtMotor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero motor";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(482, 63);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Color";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(109, 268);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgVehiculos
            // 
            this.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculos.Location = new System.Drawing.Point(31, 346);
            this.dgVehiculos.Name = "dgVehiculos";
            this.dgVehiculos.Size = new System.Drawing.Size(586, 336);
            this.dgVehiculos.TabIndex = 13;
            this.dgVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehiculos_CellContentClick);
            this.dgVehiculos.SelectionChanged += new System.EventHandler(this.dgVehiculos_SelectionChanged);
            // 
            // btnRegistrarOrdenServicio
            // 
            this.btnRegistrarOrdenServicio.Location = new System.Drawing.Point(263, 268);
            this.btnRegistrarOrdenServicio.Name = "btnRegistrarOrdenServicio";
            this.btnRegistrarOrdenServicio.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarOrdenServicio.TabIndex = 14;
            this.btnRegistrarOrdenServicio.Text = "button1";
            this.btnRegistrarOrdenServicio.UseVisualStyleBackColor = true;
            this.btnRegistrarOrdenServicio.Click += new System.EventHandler(this.btnRegistrarOrdenServicio_Click);
            // 
            // txtMontoCancelado
            // 
            this.txtMontoCancelado.Location = new System.Drawing.Point(923, 198);
            this.txtMontoCancelado.Name = "txtMontoCancelado";
            this.txtMontoCancelado.Size = new System.Drawing.Size(100, 20);
            this.txtMontoCancelado.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Monto Cancelado";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(900, 132);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(802, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombre Cliente";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(900, 78);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreServicio.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(802, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre Servicio";
            // 
            // txtFechaServicio
            // 
            this.txtFechaServicio.Location = new System.Drawing.Point(923, 254);
            this.txtFechaServicio.Name = "txtFechaServicio";
            this.txtFechaServicio.Size = new System.Drawing.Size(100, 20);
            this.txtFechaServicio.TabIndex = 22;
            this.txtFechaServicio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(802, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha Servicio";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dgOrdenesServicio
            // 
            this.dgOrdenesServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenesServicio.Location = new System.Drawing.Point(690, 346);
            this.dgOrdenesServicio.Name = "dgOrdenesServicio";
            this.dgOrdenesServicio.Size = new System.Drawing.Size(566, 336);
            this.dgOrdenesServicio.TabIndex = 23;
            // 
            // dgFiltros
            // 
            this.dgFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltros.Location = new System.Drawing.Point(1364, 346);
            this.dgFiltros.Name = "dgFiltros";
            this.dgFiltros.Size = new System.Drawing.Size(650, 336);
            this.dgFiltros.TabIndex = 24;
            this.dgFiltros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFiltros_CellContentClick);
            // 
            // btnMayorNumOrdenes
            // 
            this.btnMayorNumOrdenes.Location = new System.Drawing.Point(1407, 64);
            this.btnMayorNumOrdenes.Name = "btnMayorNumOrdenes";
            this.btnMayorNumOrdenes.Size = new System.Drawing.Size(268, 23);
            this.btnMayorNumOrdenes.TabIndex = 25;
            this.btnMayorNumOrdenes.Text = "Mayor Numero de ordenes";
            this.btnMayorNumOrdenes.UseVisualStyleBackColor = true;
            this.btnMayorNumOrdenes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNumPlaca
            // 
            this.btnNumPlaca.Location = new System.Drawing.Point(1407, 125);
            this.btnNumPlaca.Name = "btnNumPlaca";
            this.btnNumPlaca.Size = new System.Drawing.Size(268, 23);
            this.btnNumPlaca.TabIndex = 26;
            this.btnNumPlaca.Text = "N de placa";
            this.btnNumPlaca.UseVisualStyleBackColor = true;
            this.btnNumPlaca.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMontoTotal
            // 
            this.btnMontoTotal.Location = new System.Drawing.Point(1407, 201);
            this.btnMontoTotal.Name = "btnMontoTotal";
            this.btnMontoTotal.Size = new System.Drawing.Size(268, 23);
            this.btnMontoTotal.TabIndex = 27;
            this.btnMontoTotal.Text = "Monto Tolal";
            this.btnMontoTotal.UseVisualStyleBackColor = true;
            this.btnMontoTotal.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMenorMantenimiento
            // 
            this.btnMenorMantenimiento.Location = new System.Drawing.Point(1407, 268);
            this.btnMenorMantenimiento.Name = "btnMenorMantenimiento";
            this.btnMenorMantenimiento.Size = new System.Drawing.Size(268, 23);
            this.btnMenorMantenimiento.TabIndex = 28;
            this.btnMenorMantenimiento.Text = "Menor N de mantenimiento";
            this.btnMenorMantenimiento.UseVisualStyleBackColor = true;
            this.btnMenorMantenimiento.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2070, 698);
            this.Controls.Add(this.btnMenorMantenimiento);
            this.Controls.Add(this.btnMontoTotal);
            this.Controls.Add(this.btnNumPlaca);
            this.Controls.Add(this.btnMayorNumOrdenes);
            this.Controls.Add(this.dgFiltros);
            this.Controls.Add(this.dgOrdenesServicio);
            this.Controls.Add(this.txtFechaServicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMontoCancelado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegistrarOrdenServicio);
            this.Controls.Add(this.dgVehiculos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenesServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgVehiculos;
        private System.Windows.Forms.Button btnRegistrarOrdenServicio;
        private System.Windows.Forms.TextBox txtMontoCancelado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaServicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgOrdenesServicio;
        private System.Windows.Forms.DataGridView dgFiltros;
        private System.Windows.Forms.Button btnMayorNumOrdenes;
        private System.Windows.Forms.Button btnNumPlaca;
        private System.Windows.Forms.Button btnMontoTotal;
        private System.Windows.Forms.Button btnMenorMantenimiento;
    }
}

