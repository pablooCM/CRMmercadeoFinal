﻿namespace CRMmercadeoFinal
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
            this.comboBoxEstadoServicio = new System.Windows.Forms.ComboBox();
            this.buttonBorrarServicio = new System.Windows.Forms.Button();
            this.buttonActualizarServicio = new System.Windows.Forms.Button();
            this.buttonConsultarServicio = new System.Windows.Forms.Button();
            this.buttonCrearServicio = new System.Windows.Forms.Button();
            this.textBoxServiciosCliente = new System.Windows.Forms.TextBox();
            this.labelServiciosCliente = new System.Windows.Forms.Label();
            this.tabReportesMkt = new System.Windows.Forms.TabPage();
            this.tabIntegracionVentas = new System.Windows.Forms.TabPage();
            this.labelRedSocial = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelClaveRS = new System.Windows.Forms.Label();
            this.labelRRSS = new System.Windows.Forms.Label();
            this.textBoxRRSScliente = new System.Windows.Forms.TextBox();
            this.comboBoxRRSS = new System.Windows.Forms.ComboBox();
            this.labelRS = new System.Windows.Forms.Label();
            this.buttonAsignarRS = new System.Windows.Forms.Button();
            this.comboBoxRRSSempresa = new System.Windows.Forms.ComboBox();
            this.textBoxNombreUsuarioRS = new System.Windows.Forms.TextBox();
            this.textBoxClaveRS = new System.Windows.Forms.TextBox();
            this.buttonRegistrarRS = new System.Windows.Forms.Button();
            this.labelIdCampanna = new System.Windows.Forms.Label();
            this.labelNombreCampanna = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFinalizacion = new System.Windows.Forms.Label();
            this.labelPaisesCampanna = new System.Windows.Forms.Label();
            this.labelCostoCampanna = new System.Windows.Forms.Label();
            this.textBoxIdCampanna = new System.Windows.Forms.TextBox();
            this.textBoxNombreCampanna = new System.Windows.Forms.TextBox();
            this.textBoxCostoCampanna = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaInicioCampanna = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerfFechaFinalizacionCampanna = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPaisesCobertura = new System.Windows.Forms.DataGridView();
            this.dataGridViewPaisesCampanna = new System.Windows.Forms.DataGridView();
            this.buttonCrearCampanna = new System.Windows.Forms.Button();
            this.CRMmktTab.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabServicios.SuspendLayout();
            this.tabRRSS.SuspendLayout();
            this.tabCampanasMercadeo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaisesCobertura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaisesCampanna)).BeginInit();
            this.SuspendLayout();
            // 
            // CRMmktTab
            // 
            this.CRMmktTab.Controls.Add(this.tabClientes);
            this.CRMmktTab.Controls.Add(this.tabServicios);
            this.CRMmktTab.Controls.Add(this.tabRRSS);
            this.CRMmktTab.Controls.Add(this.tabCampanasMercadeo);
            this.CRMmktTab.Controls.Add(this.tabReportesMkt);
            this.CRMmktTab.Controls.Add(this.tabIntegracionVentas);
            this.CRMmktTab.Location = new System.Drawing.Point(12, 12);
            this.CRMmktTab.Name = "CRMmktTab";
            this.CRMmktTab.SelectedIndex = 0;
            this.CRMmktTab.Size = new System.Drawing.Size(719, 428);
            this.CRMmktTab.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.buttonAsignarRS);
            this.tabClientes.Controls.Add(this.labelRS);
            this.tabClientes.Controls.Add(this.comboBoxRRSS);
            this.tabClientes.Controls.Add(this.textBoxRRSScliente);
            this.tabClientes.Controls.Add(this.labelRRSS);
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
            this.buttonAsignarServicioCliente.Location = new System.Drawing.Point(511, 284);
            this.buttonAsignarServicioCliente.Name = "buttonAsignarServicioCliente";
            this.buttonAsignarServicioCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonAsignarServicioCliente.TabIndex = 20;
            this.buttonAsignarServicioCliente.Text = "Asignar Servicio";
            this.buttonAsignarServicioCliente.UseVisualStyleBackColor = true;
            // 
            // labelAsignarServiciosCliente
            // 
            this.labelAsignarServiciosCliente.AutoSize = true;
            this.labelAsignarServiciosCliente.Location = new System.Drawing.Point(8, 322);
            this.labelAsignarServiciosCliente.Name = "labelAsignarServiciosCliente";
            this.labelAsignarServiciosCliente.Size = new System.Drawing.Size(102, 13);
            this.labelAsignarServiciosCliente.TabIndex = 19;
            this.labelAsignarServiciosCliente.Text = "Seleccione servicio:";
            // 
            // comboBoxServiciosCliente
            // 
            this.comboBoxServiciosCliente.FormattingEnabled = true;
            this.comboBoxServiciosCliente.Location = new System.Drawing.Point(192, 314);
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
            this.tabServicios.Controls.Add(this.dataGridViewPaisesCobertura);
            this.tabServicios.Controls.Add(this.buttonCrearServicio);
            this.tabServicios.Controls.Add(this.buttonConsultarServicio);
            this.tabServicios.Controls.Add(this.buttonActualizarServicio);
            this.tabServicios.Controls.Add(this.buttonBorrarServicio);
            this.tabServicios.Controls.Add(this.comboBoxEstadoServicio);
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
            this.tabRRSS.Controls.Add(this.buttonRegistrarRS);
            this.tabRRSS.Controls.Add(this.textBoxClaveRS);
            this.tabRRSS.Controls.Add(this.textBoxNombreUsuarioRS);
            this.tabRRSS.Controls.Add(this.comboBoxRRSSempresa);
            this.tabRRSS.Controls.Add(this.labelClaveRS);
            this.tabRRSS.Controls.Add(this.labelNombreUsuario);
            this.tabRRSS.Controls.Add(this.labelRedSocial);
            this.tabRRSS.Location = new System.Drawing.Point(4, 22);
            this.tabRRSS.Name = "tabRRSS";
            this.tabRRSS.Size = new System.Drawing.Size(711, 402);
            this.tabRRSS.TabIndex = 2;
            this.tabRRSS.Text = "Redes Sociales";
            this.tabRRSS.UseVisualStyleBackColor = true;
            // 
            // tabCampanasMercadeo
            // 
            this.tabCampanasMercadeo.Controls.Add(this.buttonCrearCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.dataGridViewPaisesCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.dateTimePickerfFechaFinalizacionCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.dateTimePickerFechaInicioCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.textBoxCostoCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.textBoxNombreCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.textBoxIdCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.labelCostoCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.labelPaisesCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.labelFechaFinalizacion);
            this.tabCampanasMercadeo.Controls.Add(this.labelFechaInicio);
            this.tabCampanasMercadeo.Controls.Add(this.labelNombreCampanna);
            this.tabCampanasMercadeo.Controls.Add(this.labelIdCampanna);
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
            this.textBoxServiciosCliente.Location = new System.Drawing.Point(192, 277);
            this.textBoxServiciosCliente.Name = "textBoxServiciosCliente";
            this.textBoxServiciosCliente.Size = new System.Drawing.Size(254, 20);
            this.textBoxServiciosCliente.TabIndex = 21;
            // 
            // labelServiciosCliente
            // 
            this.labelServiciosCliente.AutoSize = true;
            this.labelServiciosCliente.Location = new System.Drawing.Point(8, 284);
            this.labelServiciosCliente.Name = "labelServiciosCliente";
            this.labelServiciosCliente.Size = new System.Drawing.Size(167, 13);
            this.labelServiciosCliente.TabIndex = 22;
            this.labelServiciosCliente.Text = "Servicios adquiridos por el cliente:";
            // 
            // tabReportesMkt
            // 
            this.tabReportesMkt.Location = new System.Drawing.Point(4, 22);
            this.tabReportesMkt.Name = "tabReportesMkt";
            this.tabReportesMkt.Size = new System.Drawing.Size(711, 402);
            this.tabReportesMkt.TabIndex = 4;
            this.tabReportesMkt.Text = "Reportes";
            this.tabReportesMkt.UseVisualStyleBackColor = true;
            // 
            // tabIntegracionVentas
            // 
            this.tabIntegracionVentas.Location = new System.Drawing.Point(4, 22);
            this.tabIntegracionVentas.Name = "tabIntegracionVentas";
            this.tabIntegracionVentas.Size = new System.Drawing.Size(711, 402);
            this.tabIntegracionVentas.TabIndex = 5;
            this.tabIntegracionVentas.Text = "Integración con Ventas";
            this.tabIntegracionVentas.UseVisualStyleBackColor = true;
            // 
            // labelRedSocial
            // 
            this.labelRedSocial.AutoSize = true;
            this.labelRedSocial.Location = new System.Drawing.Point(53, 63);
            this.labelRedSocial.Name = "labelRedSocial";
            this.labelRedSocial.Size = new System.Drawing.Size(60, 13);
            this.labelRedSocial.TabIndex = 1;
            this.labelRedSocial.Text = "Red social:";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(53, 108);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(99, 13);
            this.labelNombreUsuario.TabIndex = 2;
            this.labelNombreUsuario.Text = "Nombre de usuario:";
            // 
            // labelClaveRS
            // 
            this.labelClaveRS.AutoSize = true;
            this.labelClaveRS.Location = new System.Drawing.Point(53, 154);
            this.labelClaveRS.Name = "labelClaveRS";
            this.labelClaveRS.Size = new System.Drawing.Size(100, 13);
            this.labelClaveRS.TabIndex = 3;
            this.labelClaveRS.Text = "Clave de red social:";
            // 
            // labelRRSS
            // 
            this.labelRRSS.AutoSize = true;
            this.labelRRSS.Location = new System.Drawing.Point(8, 354);
            this.labelRRSS.Name = "labelRRSS";
            this.labelRRSS.Size = new System.Drawing.Size(133, 13);
            this.labelRRSS.TabIndex = 23;
            this.labelRRSS.Text = "Redes sociales del cliente:";
            // 
            // textBoxRRSScliente
            // 
            this.textBoxRRSScliente.Location = new System.Drawing.Point(192, 347);
            this.textBoxRRSScliente.Name = "textBoxRRSScliente";
            this.textBoxRRSScliente.Size = new System.Drawing.Size(254, 20);
            this.textBoxRRSScliente.TabIndex = 24;
            // 
            // comboBoxRRSS
            // 
            this.comboBoxRRSS.FormattingEnabled = true;
            this.comboBoxRRSS.Items.AddRange(new object[] {
            "Twitter",
            "Facebook",
            "Google+",
            "LinkedIn",
            "Hi5",
            "Snapchat",
            "Instagram"});
            this.comboBoxRRSS.Location = new System.Drawing.Point(192, 373);
            this.comboBoxRRSS.Name = "comboBoxRRSS";
            this.comboBoxRRSS.Size = new System.Drawing.Size(254, 21);
            this.comboBoxRRSS.TabIndex = 25;
            // 
            // labelRS
            // 
            this.labelRS.AutoSize = true;
            this.labelRS.Location = new System.Drawing.Point(8, 381);
            this.labelRS.Name = "labelRS";
            this.labelRS.Size = new System.Drawing.Size(111, 13);
            this.labelRS.TabIndex = 26;
            this.labelRS.Text = "Seleccione red social:";
            // 
            // buttonAsignarRS
            // 
            this.buttonAsignarRS.Location = new System.Drawing.Point(511, 354);
            this.buttonAsignarRS.Name = "buttonAsignarRS";
            this.buttonAsignarRS.Size = new System.Drawing.Size(153, 23);
            this.buttonAsignarRS.TabIndex = 27;
            this.buttonAsignarRS.Text = "Asignar Red Social";
            this.buttonAsignarRS.UseVisualStyleBackColor = true;
            // 
            // comboBoxRRSSempresa
            // 
            this.comboBoxRRSSempresa.FormattingEnabled = true;
            this.comboBoxRRSSempresa.Items.AddRange(new object[] {
            "Twitter",
            "Facebook",
            "Google+",
            "LinkedIn",
            "Hi5",
            "Snapchat",
            "Instagram"});
            this.comboBoxRRSSempresa.Location = new System.Drawing.Point(220, 55);
            this.comboBoxRRSSempresa.Name = "comboBoxRRSSempresa";
            this.comboBoxRRSSempresa.Size = new System.Drawing.Size(254, 21);
            this.comboBoxRRSSempresa.TabIndex = 26;
            // 
            // textBoxNombreUsuarioRS
            // 
            this.textBoxNombreUsuarioRS.Location = new System.Drawing.Point(220, 101);
            this.textBoxNombreUsuarioRS.Name = "textBoxNombreUsuarioRS";
            this.textBoxNombreUsuarioRS.Size = new System.Drawing.Size(254, 20);
            this.textBoxNombreUsuarioRS.TabIndex = 27;
            // 
            // textBoxClaveRS
            // 
            this.textBoxClaveRS.Location = new System.Drawing.Point(220, 147);
            this.textBoxClaveRS.Name = "textBoxClaveRS";
            this.textBoxClaveRS.PasswordChar = '*';
            this.textBoxClaveRS.Size = new System.Drawing.Size(254, 20);
            this.textBoxClaveRS.TabIndex = 28;
            // 
            // buttonRegistrarRS
            // 
            this.buttonRegistrarRS.Location = new System.Drawing.Point(377, 234);
            this.buttonRegistrarRS.Name = "buttonRegistrarRS";
            this.buttonRegistrarRS.Size = new System.Drawing.Size(173, 23);
            this.buttonRegistrarRS.TabIndex = 29;
            this.buttonRegistrarRS.Text = "Registrar Red Social";
            this.buttonRegistrarRS.UseVisualStyleBackColor = true;
            // 
            // labelIdCampanna
            // 
            this.labelIdCampanna.AutoSize = true;
            this.labelIdCampanna.Location = new System.Drawing.Point(55, 75);
            this.labelIdCampanna.Name = "labelIdCampanna";
            this.labelIdCampanna.Size = new System.Drawing.Size(130, 13);
            this.labelIdCampanna.TabIndex = 2;
            this.labelIdCampanna.Text = "Identificador de campaña:";
            this.labelIdCampanna.Click += new System.EventHandler(this.labelIdCampanna_Click);
            // 
            // labelNombreCampanna
            // 
            this.labelNombreCampanna.AutoSize = true;
            this.labelNombreCampanna.Location = new System.Drawing.Point(55, 111);
            this.labelNombreCampanna.Name = "labelNombreCampanna";
            this.labelNombreCampanna.Size = new System.Drawing.Size(109, 13);
            this.labelNombreCampanna.TabIndex = 3;
            this.labelNombreCampanna.Text = "Nombre de campaña:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(55, 148);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(82, 13);
            this.labelFechaInicio.TabIndex = 4;
            this.labelFechaInicio.Text = "Fecha de inicio:";
            // 
            // labelFechaFinalizacion
            // 
            this.labelFechaFinalizacion.AutoSize = true;
            this.labelFechaFinalizacion.Location = new System.Drawing.Point(55, 186);
            this.labelFechaFinalizacion.Name = "labelFechaFinalizacion";
            this.labelFechaFinalizacion.Size = new System.Drawing.Size(110, 13);
            this.labelFechaFinalizacion.TabIndex = 5;
            this.labelFechaFinalizacion.Text = "Fecha de finalización:";
            // 
            // labelPaisesCampanna
            // 
            this.labelPaisesCampanna.AutoSize = true;
            this.labelPaisesCampanna.Location = new System.Drawing.Point(55, 226);
            this.labelPaisesCampanna.Name = "labelPaisesCampanna";
            this.labelPaisesCampanna.Size = new System.Drawing.Size(109, 13);
            this.labelPaisesCampanna.TabIndex = 6;
            this.labelPaisesCampanna.Text = "Países de aplicación:";
            // 
            // labelCostoCampanna
            // 
            this.labelCostoCampanna.AutoSize = true;
            this.labelCostoCampanna.Location = new System.Drawing.Point(55, 297);
            this.labelCostoCampanna.Name = "labelCostoCampanna";
            this.labelCostoCampanna.Size = new System.Drawing.Size(99, 13);
            this.labelCostoCampanna.TabIndex = 7;
            this.labelCostoCampanna.Text = "Costo de campaña:";
            // 
            // textBoxIdCampanna
            // 
            this.textBoxIdCampanna.Location = new System.Drawing.Point(207, 68);
            this.textBoxIdCampanna.Name = "textBoxIdCampanna";
            this.textBoxIdCampanna.Size = new System.Drawing.Size(254, 20);
            this.textBoxIdCampanna.TabIndex = 28;
            // 
            // textBoxNombreCampanna
            // 
            this.textBoxNombreCampanna.Location = new System.Drawing.Point(207, 104);
            this.textBoxNombreCampanna.Name = "textBoxNombreCampanna";
            this.textBoxNombreCampanna.Size = new System.Drawing.Size(254, 20);
            this.textBoxNombreCampanna.TabIndex = 29;
            // 
            // textBoxCostoCampanna
            // 
            this.textBoxCostoCampanna.Location = new System.Drawing.Point(207, 290);
            this.textBoxCostoCampanna.Name = "textBoxCostoCampanna";
            this.textBoxCostoCampanna.Size = new System.Drawing.Size(254, 20);
            this.textBoxCostoCampanna.TabIndex = 30;
            // 
            // dateTimePickerFechaInicioCampanna
            // 
            this.dateTimePickerFechaInicioCampanna.Location = new System.Drawing.Point(207, 141);
            this.dateTimePickerFechaInicioCampanna.Name = "dateTimePickerFechaInicioCampanna";
            this.dateTimePickerFechaInicioCampanna.Size = new System.Drawing.Size(254, 20);
            this.dateTimePickerFechaInicioCampanna.TabIndex = 31;
            // 
            // dateTimePickerfFechaFinalizacionCampanna
            // 
            this.dateTimePickerfFechaFinalizacionCampanna.Location = new System.Drawing.Point(207, 179);
            this.dateTimePickerfFechaFinalizacionCampanna.Name = "dateTimePickerfFechaFinalizacionCampanna";
            this.dateTimePickerfFechaFinalizacionCampanna.Size = new System.Drawing.Size(254, 20);
            this.dateTimePickerfFechaFinalizacionCampanna.TabIndex = 32;
            // 
            // dataGridViewPaisesCobertura
            // 
            this.dataGridViewPaisesCobertura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaisesCobertura.Location = new System.Drawing.Point(213, 151);
            this.dataGridViewPaisesCobertura.Name = "dataGridViewPaisesCobertura";
            this.dataGridViewPaisesCobertura.Size = new System.Drawing.Size(254, 53);
            this.dataGridViewPaisesCobertura.TabIndex = 19;
            // 
            // dataGridViewPaisesCampanna
            // 
            this.dataGridViewPaisesCampanna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaisesCampanna.Location = new System.Drawing.Point(207, 226);
            this.dataGridViewPaisesCampanna.Name = "dataGridViewPaisesCampanna";
            this.dataGridViewPaisesCampanna.Size = new System.Drawing.Size(254, 50);
            this.dataGridViewPaisesCampanna.TabIndex = 33;
            // 
            // buttonCrearCampanna
            // 
            this.buttonCrearCampanna.Location = new System.Drawing.Point(511, 101);
            this.buttonCrearCampanna.Name = "buttonCrearCampanna";
            this.buttonCrearCampanna.Size = new System.Drawing.Size(153, 23);
            this.buttonCrearCampanna.TabIndex = 34;
            this.buttonCrearCampanna.Text = "Crear Campaña";
            this.buttonCrearCampanna.UseVisualStyleBackColor = true;
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
            this.tabRRSS.ResumeLayout(false);
            this.tabRRSS.PerformLayout();
            this.tabCampanasMercadeo.ResumeLayout(false);
            this.tabCampanasMercadeo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaisesCobertura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaisesCampanna)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxEstadoServicio;
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
        private System.Windows.Forms.TabPage tabReportesMkt;
        private System.Windows.Forms.TabPage tabIntegracionVentas;
        private System.Windows.Forms.Button buttonAsignarRS;
        private System.Windows.Forms.Label labelRS;
        private System.Windows.Forms.ComboBox comboBoxRRSS;
        private System.Windows.Forms.TextBox textBoxRRSScliente;
        private System.Windows.Forms.Label labelRRSS;
        private System.Windows.Forms.Label labelClaveRS;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelRedSocial;
        private System.Windows.Forms.TextBox textBoxClaveRS;
        private System.Windows.Forms.TextBox textBoxNombreUsuarioRS;
        private System.Windows.Forms.ComboBox comboBoxRRSSempresa;
        private System.Windows.Forms.DataGridView dataGridViewPaisesCobertura;
        private System.Windows.Forms.Button buttonRegistrarRS;
        private System.Windows.Forms.DataGridView dataGridViewPaisesCampanna;
        private System.Windows.Forms.DateTimePicker dateTimePickerfFechaFinalizacionCampanna;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicioCampanna;
        private System.Windows.Forms.TextBox textBoxCostoCampanna;
        private System.Windows.Forms.TextBox textBoxNombreCampanna;
        private System.Windows.Forms.TextBox textBoxIdCampanna;
        private System.Windows.Forms.Label labelCostoCampanna;
        private System.Windows.Forms.Label labelPaisesCampanna;
        private System.Windows.Forms.Label labelFechaFinalizacion;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelNombreCampanna;
        private System.Windows.Forms.Label labelIdCampanna;
        private System.Windows.Forms.Button buttonCrearCampanna;
    }
}
