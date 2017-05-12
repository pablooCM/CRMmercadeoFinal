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
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabRRSS = new System.Windows.Forms.TabPage();
            this.tabCampanasMercadeo = new System.Windows.Forms.TabPage();
            this.labelCedulaCliente = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelPrimerApellidoCliente = new System.Windows.Forms.Label();
            this.labelSegundoApellidoCliente = new System.Windows.Forms.Label();
            this.labelCiudadCliente = new System.Windows.Forms.Label();
            this.labelPaisCliente = new System.Windows.Forms.Label();
            this.labelMailCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonCrearCliente = new System.Windows.Forms.Button();
            this.buttonConsultaCliente = new System.Windows.Forms.Button();
            this.buttonActualizarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxServiciosCliente = new System.Windows.Forms.ComboBox();
            this.labelAsignarServiciosCliente = new System.Windows.Forms.Label();
            this.buttonAsignarServicioCliente = new System.Windows.Forms.Button();
            this.CRMmktTab.SuspendLayout();
            this.tabClientes.SuspendLayout();
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
            this.tabClientes.Controls.Add(this.buttonAsignarServicioCliente);
            this.tabClientes.Controls.Add(this.labelAsignarServiciosCliente);
            this.tabClientes.Controls.Add(this.comboBoxServiciosCliente);
            this.tabClientes.Controls.Add(this.button1);
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
            // tabServicios
            // 
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
            // labelCedulaCliente
            // 
            this.labelCedulaCliente.AutoSize = true;
            this.labelCedulaCliente.Location = new System.Drawing.Point(8, 36);
            this.labelCedulaCliente.Name = "labelCedulaCliente";
            this.labelCedulaCliente.Size = new System.Drawing.Size(94, 13);
            this.labelCedulaCliente.TabIndex = 0;
            this.labelCedulaCliente.Text = "Cédula del cliente:";
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
            // labelSegundoApellidoCliente
            // 
            this.labelSegundoApellidoCliente.AutoSize = true;
            this.labelSegundoApellidoCliente.Location = new System.Drawing.Point(8, 142);
            this.labelSegundoApellidoCliente.Name = "labelSegundoApellidoCliente";
            this.labelSegundoApellidoCliente.Size = new System.Drawing.Size(143, 13);
            this.labelSegundoApellidoCliente.TabIndex = 3;
            this.labelSegundoApellidoCliente.Text = "Segundo apellido del cliente:";
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
            // labelPaisCliente
            // 
            this.labelPaisCliente.AutoSize = true;
            this.labelPaisCliente.Location = new System.Drawing.Point(8, 213);
            this.labelPaisCliente.Name = "labelPaisCliente";
            this.labelPaisCliente.Size = new System.Drawing.Size(32, 13);
            this.labelPaisCliente.TabIndex = 5;
            this.labelPaisCliente.Text = "País:";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(192, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(254, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(192, 63);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(254, 20);
            this.textBox7.TabIndex = 13;
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
            // buttonConsultaCliente
            // 
            this.buttonConsultaCliente.Location = new System.Drawing.Point(511, 95);
            this.buttonConsultaCliente.Name = "buttonConsultaCliente";
            this.buttonConsultaCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonConsultaCliente.TabIndex = 15;
            this.buttonConsultaCliente.Text = "Consultar Cliente";
            this.buttonConsultaCliente.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Crear Cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxServiciosCliente
            // 
            this.comboBoxServiciosCliente.FormattingEnabled = true;
            this.comboBoxServiciosCliente.Location = new System.Drawing.Point(192, 331);
            this.comboBoxServiciosCliente.Name = "comboBoxServiciosCliente";
            this.comboBoxServiciosCliente.Size = new System.Drawing.Size(254, 21);
            this.comboBoxServiciosCliente.TabIndex = 18;
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
            // buttonAsignarServicioCliente
            // 
            this.buttonAsignarServicioCliente.Location = new System.Drawing.Point(511, 329);
            this.buttonAsignarServicioCliente.Name = "buttonAsignarServicioCliente";
            this.buttonAsignarServicioCliente.Size = new System.Drawing.Size(153, 23);
            this.buttonAsignarServicioCliente.TabIndex = 20;
            this.buttonAsignarServicioCliente.Text = "Asignar Servicio";
            this.buttonAsignarServicioCliente.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonActualizarCliente;
        private System.Windows.Forms.Button buttonConsultaCliente;
        private System.Windows.Forms.Button buttonCrearCliente;
    }
}

