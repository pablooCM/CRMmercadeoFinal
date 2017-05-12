namespace CRMmercadeoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CRMmktTab = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.buttonAsignarServicioCliente = new System.Windows.Forms.Button();
            this.labelAsignarServiciosCliente = new System.Windows.Forms.Label();
            this.comboBoxServiciosCliente = new System.Windows.Forms.ComboBox();
            this.buttonBorrarCliente = new System.Windows.Forms.Button();
            this.buttonActualizarCliente = new System.Windows.Forms.Button();
            this.buttonConsultaCliente = new System.Windows.Forms.Button();
            this.buttonCrearCliente = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMailCliente = new System.Windows.Forms.Label();
            this.labelPaisCliente = new System.Windows.Forms.Label();
            this.labelCiudadCliente = new System.Windows.Forms.Label();
            this.labelSegundoApellidoCliente = new System.Windows.Forms.Label();
            this.labelPrimerApellidoCliente = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelCedulaCliente = new System.Windows.Forms.Label();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabRRSS = new System.Windows.Forms.TabPage();
            this.tabCampanasMercadeo = new System.Windows.Forms.TabPage();
            this.labelIdServicio = new System.Windows.Forms.Label();
            this.labelDescripciónServicio = new System.Windows.Forms.Label();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.labelCoberturaServicio = new System.Windows.Forms.Label();
            this.labelEstadoDelServicio = new System.Windows.Forms.Label();
            this.textBoxIdServicio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionServicio = new System.Windows.Forms.TextBox();
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.textBoxCoberturaServicio = new System.Windows.Forms.TextBox();
            this.comboBoxPaises = new System.Windows.Forms.ComboBox();
            this.comboBoxEstadoServicio = new System.Windows.Forms.ComboBox();
            this.buttonAgregarPais = new System.Windows.Forms.Button();
            this.buttonBorrarServicio = new System.Windows.Forms.Button();
            this.buttonActualizarServicio = new System.Windows.Forms.Button();
            this.buttonConsultarServicio = new System.Windows.Forms.Button();
            this.buttonCrearServicio = new System.Windows.Forms.Button();
            this.textBoxServiciosCliente = new System.Windows.Forms.TextBox();
            this.labelServiciosCliente = new System.Windows.Forms.Label();
            this.CRMmktTab.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabServicios.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRMmktTab
            // 
            this.CRMmktTab.Controls.Add(this.tabClientes);
            this.CRMmktTab.Controls.Add(this.tabServicios);
            this.CRMmktTab.Controls.Add(this.tabRRSS);
            this.CRMmktTab.Controls.Add(this.tabCampanasMercadeo);
            this.CRMmktTab.Location = new System.Drawing.Point(12, 12);
            this.CRMmktTab.Name = "CRMmktTab";
            this.CRMmktTab.SelectedIndex = 0;
            this.CRMmktTab.Size = new System.Drawing.Size(719, 428);
            this.CRMmktTab.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.labelServiciosCliente);
            this.tabClientes.Controls.Add(this.textBoxServiciosCliente);
            this.tabClientes.Controls.Add(this.buttonAsignarServicioCliente);
            this.tabClientes.Controls.Add(this.labelAsignarServiciosCliente);
            this.tabClientes.Controls.Add(this.comboBoxServiciosCliente);
            this.tabClientes.Controls.Add(this.buttonBorrarCliente);
            this.tabClientes.Controls.Add(this.buttonActualizarCliente);
            this.tabClientes.Controls.Add(this.buttonConsultaCliente);
            this.tabClientes.Controls.Add(this.buttonCrearCliente);
            this.tabClientes.Controls.Add(this.textBox7);
            this.tabClientes.Controls.Add(this.textBox6);
            this.tabClientes.Controls.Add(this.textBox5);
            this.tabClientes.Controls.Add(this.textBox4);
            this.tabClientes.Controls.Add(this.textBox3);
            this.tabClientes.Controls.Add(this.textBox2);
            this.tabClientes.Controls.Add(this.textBox1);
            this.tabClientes.Controls.Add(this.labelMailCliente);
            this.tabClientes.Controls.Add(this.labelPaisCliente);
            this.tabClientes.Controls.Add(this.labelCiudadCliente);
            this.tabClientes.Controls.Add(this.labelSegundoApellidoCliente);
            this.tabClientes.Controls.Add(this.labelPrimerApellidoCliente);
            this.tabClientes.Controls.Add(this.labelNombreCliente);
            this.tabClientes.Controls.Add(this.labelCedulaCliente);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(711, 402);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // buttonAsignarServicioCliente
            // 
            this.buttonAsignarServicioCliente.Location = new System.Drawing.Point(511, 293);
            this.buttonAsignarServicioCliente.Name = "buttonAsignarServicioCliente";
            this.buttonAsignarServicioCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonAsignarServicioCliente.TabIndex = 20;
            this.buttonAsignarServicioCliente.Text = "Asignar Servicio";
            this.buttonAsignarServicioCliente.UseVisualStyleBackColor = true;
            // 
            // labelAsignarServiciosCliente
            // 
            this.labelAsignarServiciosCliente.AutoSize = true;
            this.labelAsignarServiciosCliente.Location = new System.Drawing.Point(8, 339);
            this.labelAsignarServiciosCliente.Name = "labelAsignarServiciosCliente";
            this.labelAsignarServiciosCliente.Size = new System.Drawing.Size(102, 13);
            this.labelAsignarServiciosCliente.TabIndex = 19;
            this.labelAsignarServiciosCliente.Text = "Seleccione servicio:";
            // 
            // comboBoxServiciosCliente
            // 
            this.comboBoxServiciosCliente.FormattingEnabled = true;
            this.comboBoxServiciosCliente.Location = new System.Drawing.Point(192, 331);
            this.comboBoxServiciosCliente.Name = "comboBoxServiciosCliente";
            this.comboBoxServiciosCliente.Size = new System.Drawing.Size(254, 21);
            this.comboBoxServiciosCliente.TabIndex = 18;
            // 
            // buttonBorrarCliente
            // 
            this.buttonBorrarCliente.Location = new System.Drawing.Point(511, 167);
            this.buttonBorrarCliente.Name = "buttonBorrarCliente";
            this.buttonBorrarCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonBorrarCliente.TabIndex = 17;
            this.buttonBorrarCliente.Text = "Borrar Cliente";
            this.buttonBorrarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonActualizarCliente
            // 
            this.buttonActualizarCliente.Location = new System.Drawing.Point(511, 132);
            this.buttonActualizarCliente.Name = "buttonActualizarCliente";
            this.buttonActualizarCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonActualizarCliente.TabIndex = 16;
            this.buttonActualizarCliente.Text = "Actualizar Cliente";
            this.buttonActualizarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonConsultaCliente
            // 
            this.buttonConsultaCliente.Location = new System.Drawing.Point(511, 95);
            this.buttonConsultaCliente.Name = "buttonConsultaCliente";
            this.buttonConsultaCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonConsultaCliente.TabIndex = 15;
            this.buttonConsultaCliente.Text = "Consultar Cliente";
            this.buttonConsultaCliente.UseVisualStyleBackColor = true;
            // 
            // buttonCrearCliente
            // 
            this.buttonCrearCliente.Location = new System.Drawing.Point(511, 60);
            this.buttonCrearCliente.Name = "buttonCrearCliente";
            this.buttonCrearCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonCrearCliente.TabIndex = 14;
            this.buttonCrearCliente.Text = "Crear Cliente";
            this.buttonCrearCliente.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(192, 63);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(254, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(192, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(254, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 7;
            // 
            // labelMailCliente
            // 
            this.labelMailCliente.AutoSize = true;
            this.labelMailCliente.Location = new System.Drawing.Point(8, 248);
            this.labelMailCliente.Name = "labelMailCliente";
            this.labelMailCliente.Size = new System.Drawing.Size(96, 13);
            this.labelMailCliente.TabIndex = 6;
            this.labelMailCliente.Text = "Correo electrónico:";
            // 
            // labelPaisCliente
            // 
            this.labelPaisCliente.AutoSize = true;
            this.labelPaisCliente.Location = new System.Drawing.Point(8, 213);
            this.labelPaisCliente.Name = "labelPaisCliente";
            this.labelPaisCliente.Size = new System.Drawing.Size(32, 13);
            this.labelPaisCliente.TabIndex = 5;
            this.labelPaisCliente.Text = "País:";
            // 
            // labelCiudadCliente
            // 
            this.labelCiudadCliente.AutoSize = true;
            this.labelCiudadCliente.Location = new System.Drawing.Point(8, 177);
            this.labelCiudadCliente.Name = "labelCiudadCliente";
            this.labelCiudadCliente.Size = new System.Drawing.Size(43, 13);
            this.labelCiudadCliente.TabIndex = 4;
            this.labelCiudadCliente.Text = "Ciudad:";
            // 
            // labelSegundoApellidoCliente
            // 
            this.labelSegundoApellidoCliente.AutoSize = true;
            this.labelSegundoApellidoCliente.Location = new System.Drawing.Point(8, 142);
            this.labelSegundoApellidoCliente.Name = "labelSegundoApellidoCliente";
            this.labelSegundoApellidoCliente.Size = new System.Drawing.Size(143, 13);
            this.labelSegundoApellidoCliente.TabIndex = 3;
            this.labelSegundoApellidoCliente.Text = "Segundo apellido del cliente:";
            // 
            // labelPrimerApellidoCliente
            // 
            this.labelPrimerApellidoCliente.AutoSize = true;
            this.labelPrimerApellidoCliente.Location = new System.Drawing.Point(8, 105);
            this.labelPrimerApellidoCliente.Name = "labelPrimerApellidoCliente";
            this.labelPrimerApellidoCliente.Size = new System.Drawing.Size(129, 13);
            this.labelPrimerApellidoCliente.TabIndex = 2;
            this.labelPrimerApellidoCliente.Text = "Primer apellido del cliente:";
            this.labelPrimerApellidoCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(8, 70);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(98, 13);
            this.labelNombreCliente.TabIndex = 1;
            this.labelNombreCliente.Text = "Nombre del cliente:";
            // 
            // labelCedulaCliente
            // 
            this.labelCedulaCliente.AutoSize = true;
            this.labelCedulaCliente.Location = new System.Drawing.Point(8, 36);
            this.labelCedulaCliente.Name = "labelCedulaCliente";
            this.labelCedulaCliente.Size = new System.Drawing.Size(94, 13);
            this.labelCedulaCliente.TabIndex = 0;
            this.labelCedulaCliente.Text = "Cédula del cliente:";
            // 
            // tabServicios
            // 
            this.tabServicios.Controls.Add(this.buttonCrearServicio);
            this.tabServicios.Controls.Add(this.buttonConsultarServicio);
            this.tabServicios.Controls.Add(this.buttonActualizarServicio);
            this.tabServicios.Controls.Add(this.buttonBorrarServicio);
            this.tabServicios.Controls.Add(this.buttonAgregarPais);
            this.tabServicios.Controls.Add(this.comboBoxEstadoServicio);
            this.tabServicios.Controls.Add(this.comboBoxPaises);
            this.tabServicios.Controls.Add(this.textBoxCoberturaServicio);
            this.tabServicios.Controls.Add(this.comboBoxFormaPago);
            this.tabServicios.Controls.Add(this.textBoxDescripcionServicio);
            this.tabServicios.Controls.Add(this.textBoxIdServicio);
            this.tabServicios.Controls.Add(this.labelEstadoDelServicio);
            this.tabServicios.Controls.Add(this.labelCoberturaServicio);
            this.tabServicios.Controls.Add(this.labelFormaPago);
            this.tabServicios.Controls.Add(this.labelDescripciónServicio);
            this.tabServicios.Controls.Add(this.labelIdServicio);
            this.tabServicios.Location = new System.Drawing.Point(4, 22);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicios.Size = new System.Drawing.Size(711, 402);
            this.tabServicios.TabIndex = 1;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabRRSS
            // 
            this.tabRRSS.Location = new System.Drawing.Point(4, 22);
            this.tabRRSS.Name = "tabRRSS";
            this.tabRRSS.Size = new System.Drawing.Size(711, 402);
            this.tabRRSS.TabIndex = 2;
            this.tabRRSS.Text = "Redes Sociales";
            this.tabRRSS.UseVisualStyleBackColor = true;
            // 
            // tabCampanasMercadeo
            // 
            this.tabCampanasMercadeo.Location = new System.Drawing.Point(4, 22);
            this.tabCampanasMercadeo.Name = "tabCampanasMercadeo";
            this.tabCampanasMercadeo.Size = new System.Drawing.Size(711, 402);
            this.tabCampanasMercadeo.TabIndex = 3;
            this.tabCampanasMercadeo.Text = "Campañas de Mercadeo";
            this.tabCampanasMercadeo.UseVisualStyleBackColor = true;
            // 
            // labelIdServicio
            // 
            this.labelIdServicio.AutoSize = true;
            this.labelIdServicio.Location = new System.Drawing.Point(27, 35);
            this.labelIdServicio.Name = "labelIdServicio";
            this.labelIdServicio.Size = new System.Drawing.Size(77, 13);
            this.labelIdServicio.TabIndex = 0;
            this.labelIdServicio.Text = "ID del servicio:";
            // 
            // labelDescripciónServicio
            // 
            this.labelDescripciónServicio.AutoSize = true;
            this.labelDescripciónServicio.Location = new System.Drawing.Point(27, 74);
            this.labelDescripciónServicio.Name = "labelDescripciónServicio";
            this.labelDescripciónServicio.Size = new System.Drawing.Size(122, 13);
            this.labelDescripciónServicio.TabIndex = 1;
            this.labelDescripciónServicio.Text = "Descripción del servicio:";
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Location = new System.Drawing.Point(27, 114);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(81, 13);
            this.labelFormaPago.TabIndex = 2;
            this.labelFormaPago.Text = "Forma de pago:";
            // 
            // labelCoberturaServicio
            // 
            this.labelCoberturaServicio.AutoSize = true;
            this.labelCoberturaServicio.Location = new System.Drawing.Point(27, 151);
            this.labelCoberturaServicio.Name = "labelCoberturaServicio";
            this.labelCoberturaServicio.Size = new System.Drawing.Size(112, 13);
            this.labelCoberturaServicio.TabIndex = 3;
            this.labelCoberturaServicio.Text = "Cobertura del servicio:";
            // 
            // labelEstadoDelServicio
            // 
            this.labelEstadoDelServicio.AutoSize = true;
            this.labelEstadoDelServicio.Location = new System.Drawing.Point(27, 228);
            this.labelEstadoDelServicio.Name = "labelEstadoDelServicio";
            this.labelEstadoDelServicio.Size = new System.Drawing.Size(99, 13);
            this.labelEstadoDelServicio.TabIndex = 4;
            this.labelEstadoDelServicio.Text = "Estado del servicio:";
            // 
            // textBoxIdServicio
            // 
            this.textBoxIdServicio.Location = new System.Drawing.Point(213, 28);
            this.textBoxIdServicio.Name = "textBoxIdServicio";
            this.textBoxIdServicio.Size = new System.Drawing.Size(254, 20);
            this.textBoxIdServicio.TabIndex = 8;
            // 
            // textBoxDescripcionServicio
            // 
            this.textBoxDescripcionServicio.Location = new System.Drawing.Point(213, 67);
            this.textBoxDescripcionServicio.Name = "textBoxDescripcionServicio";
            this.textBoxDescripcionServicio.Size = new System.Drawing.Size(254, 20);
            this.textBoxDescripcionServicio.TabIndex = 9;
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Items.AddRange(new object[] {
            "mensual",
            "quincenal",
            "anual"});
            this.comboBoxFormaPago.Location = new System.Drawing.Point(213, 106);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(254, 21);
            this.comboBoxFormaPago.TabIndex = 10;
            // 
            // textBoxCoberturaServicio
            // 
            this.textBoxCoberturaServicio.Location = new System.Drawing.Point(213, 144);
            this.textBoxCoberturaServicio.Name = "textBoxCoberturaServicio";
            this.textBoxCoberturaServicio.Size = new System.Drawing.Size(254, 20);
            this.textBoxCoberturaServicio.TabIndex = 11;
            // 
            // comboBoxPaises
            // 
            this.comboBoxPaises.FormattingEnabled = true;
            this.comboBoxPaises.Location = new System.Drawing.Point(213, 181);
            this.comboBoxPaises.Name = "comboBoxPaises";
            this.comboBoxPaises.Size = new System.Drawing.Size(254, 21);
            this.comboBoxPaises.TabIndex = 12;
            // 
            // comboBoxEstadoServicio
            // 
            this.comboBoxEstadoServicio.FormattingEnabled = true;
            this.comboBoxEstadoServicio.Items.AddRange(new object[] {
            "activo",
            "inactivo",
            "por implementar"});
            this.comboBoxEstadoServicio.Location = new System.Drawing.Point(213, 220);
            this.comboBoxEstadoServicio.Name = "comboBoxEstadoServicio";
            this.comboBoxEstadoServicio.Size = new System.Drawing.Size(254, 21);
            this.comboBoxEstadoServicio.TabIndex = 13;
            // 
            // buttonAgregarPais
            // 
            this.buttonAgregarPais.Location = new System.Drawing.Point(30, 181);
            this.buttonAgregarPais.Name = "buttonAgregarPais";
            this.buttonAgregarPais.Size = new System.Drawing.Size(110, 23);
            this.buttonAgregarPais.TabIndex = 14;
            this.buttonAgregarPais.Text = "Agregar País";
            this.buttonAgregarPais.UseVisualStyleBackColor = true;
            // 
            // buttonBorrarServicio
            // 
            this.buttonBorrarServicio.Location = new System.Drawing.Point(532, 181);
            this.buttonBorrarServicio.Name = "buttonBorrarServicio";
            this.buttonBorrarServicio.Size = new System.Drawing.Size(153, 23);
            this.buttonBorrarServicio.TabIndex = 15;
            this.buttonBorrarServicio.Text = "Borrar Servicio";
            this.buttonBorrarServicio.UseVisualStyleBackColor = true;
            // 
            // buttonActualizarServicio
            // 
            this.buttonActualizarServicio.Location = new System.Drawing.Point(532, 141);
            this.buttonActualizarServicio.Name = "buttonActualizarServicio";
            this.buttonActualizarServicio.Size = new System.Drawing.Size(153, 23);
            this.buttonActualizarServicio.TabIndex = 16;
            this.buttonActualizarServicio.Text = "Actualizar Servicio";
            this.buttonActualizarServicio.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarServicio
            // 
            this.buttonConsultarServicio.Location = new System.Drawing.Point(532, 104);
            this.buttonConsultarServicio.Name = "buttonConsultarServicio";
            this.buttonConsultarServicio.Size = new System.Drawing.Size(153, 23);
            this.buttonConsultarServicio.TabIndex = 17;
            this.buttonConsultarServicio.Text = "Consultar Servicio";
            this.buttonConsultarServicio.UseVisualStyleBackColor = true;
            // 
            // buttonCrearServicio
            // 
            this.buttonCrearServicio.Location = new System.Drawing.Point(532, 64);
            this.buttonCrearServicio.Name = "buttonCrearServicio";
            this.buttonCrearServicio.Size = new System.Drawing.Size(153, 23);
            this.buttonCrearServicio.TabIndex = 18;
            this.buttonCrearServicio.Text = "Crear Servicio";
            this.buttonCrearServicio.UseVisualStyleBackColor = true;
            // 
            // textBoxServiciosCliente
            // 
            this.textBoxServiciosCliente.Location = new System.Drawing.Point(192, 295);
            this.textBoxServiciosCliente.Name = "textBoxServiciosCliente";
            this.textBoxServiciosCliente.Size = new System.Drawing.Size(254, 20);
            this.textBoxServiciosCliente.TabIndex = 21;
            // 
            // labelServiciosCliente
            // 
            this.labelServiciosCliente.AutoSize = true;
            this.labelServiciosCliente.Location = new System.Drawing.Point(8, 302);
            this.labelServiciosCliente.Name = "labelServiciosCliente";
            this.labelServiciosCliente.Size = new System.Drawing.Size(167, 13);
            this.labelServiciosCliente.TabIndex = 22;
            this.labelServiciosCliente.Text = "Servicios adquiridos por el cliente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 443);
            this.Controls.Add(this.CRMmktTab);
            this.Name = "Form1";
            this.Text = "CRM Mercadeo";
            this.CRMmktTab.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.tabServicios.ResumeLayout(false);
            this.tabServicios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CRMmktTab;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabRRSS;
        private System.Windows.Forms.TabPage tabCampanasMercadeo;
        private System.Windows.Forms.Label labelSegundoApellidoCliente;
        private System.Windows.Forms.Label labelPrimerApellidoCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labelCedulaCliente;
        private System.Windows.Forms.Label labelMailCliente;
        private System.Windows.Forms.Label labelPaisCliente;
        private System.Windows.Forms.Label labelCiudadCliente;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAsignarServicioCliente;
        private System.Windows.Forms.Label labelAsignarServiciosCliente;
        private System.Windows.Forms.ComboBox comboBoxServiciosCliente;
        private System.Windows.Forms.Button buttonBorrarCliente;
        private System.Windows.Forms.Button buttonActualizarCliente;
        private System.Windows.Forms.Button buttonConsultaCliente;
        private System.Windows.Forms.Button buttonCrearCliente;
        private System.Windows.Forms.Button buttonAgregarPais;
        private System.Windows.Forms.ComboBox comboBoxEstadoServicio;
        private System.Windows.Forms.ComboBox comboBoxPaises;
        private System.Windows.Forms.TextBox textBoxCoberturaServicio;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.TextBox textBoxDescripcionServicio;
        private System.Windows.Forms.TextBox textBoxIdServicio;
        private System.Windows.Forms.Label labelEstadoDelServicio;
        private System.Windows.Forms.Label labelCoberturaServicio;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.Label labelDescripciónServicio;
        private System.Windows.Forms.Label labelIdServicio;
        private System.Windows.Forms.Button buttonCrearServicio;
        private System.Windows.Forms.Button buttonConsultarServicio;
        private System.Windows.Forms.Button buttonActualizarServicio;
        private System.Windows.Forms.Button buttonBorrarServicio;
        private System.Windows.Forms.Label labelServiciosCliente;
        private System.Windows.Forms.TextBox textBoxServiciosCliente;
    }
}

