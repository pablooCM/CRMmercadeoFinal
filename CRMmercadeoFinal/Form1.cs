﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Globalization;


namespace CRMmercadeoFinal
{

    public partial class Form1 : Form
    {
        ConexionBD conexionBD = new ConexionBD();
        SqlConnection conexion = ConexionBD.getConection();
        
        public Form1()
        {
            InitializeComponent();
            jalaDatosComboBoxServClientes();
            jalaDatosComboBoxRRSSclientes();
            jalaPaisesComboBox();
            jalaCiudadesComboBox();

        }

        private void jalaDatosComboBoxServClientes()
        {
            conexion.Open();
            String consulta = "Select descripcionServicio from Servicios";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            while (leerDatos.Read())
            {
                    comboBoxServiciosCliente.Items.Add(leerDatos[0].ToString());
            }
        }
        private void jalaPaisesComboBox()
        {
            //ConexionBD.getInstance();

            String consulta = "Select pais from Clientes";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxPaisReportes.Items.Add(leerDatos[0].ToString());
            }
        }

        private void jalaCiudadesComboBox()
        {
            //ConexionBD.getInstance();

            String consulta = "Select ciudad from Clientes";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxCiudadesReporteClientes.Items.Add(leerDatos[0].ToString());
            }
        }

        private void jalaDatosComboBoxRRSSclientes()
        {
            //ConexionBD.getInstance();

            String consulta = "Select nombreRedSocial from RedesSociales";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            while (leerDatos.Read())
            {
                comboBoxRRSS.Items.Add(leerDatos[0].ToString());
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelIdCampanna_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearCliente_Click(object sender, EventArgs e)
        {
            //ConexionBD.getInstance();
            
            SqlCommand cmd = new SqlCommand("dbo.insertaCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@cedula", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxCedulaCliente.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@nombre", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxNombreCliente.Text;
            param2.Size = 50;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter("@apellido1", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxPrimerApellidoCliente.Text;
            param3.Size = 50;
            cmd.Parameters.Add(param3);

            var param4 = new SqlParameter("@apellido2", SqlDbType.VarChar);
            param4.Direction = ParameterDirection.Input;
            param4.Value = textBoxSegundoApellidoCliente.Text;
            param4.Size = 50;
            cmd.Parameters.Add(param4);

            var param5 = new SqlParameter("@ciudad", SqlDbType.VarChar);
            param5.Direction = ParameterDirection.Input;
            param5.Value = textBoxCiudadCliente.Text;
            param5.Size = 50;
            cmd.Parameters.Add(param5);

            var param6 = new SqlParameter("@pais", SqlDbType.VarChar);
            param6.Direction = ParameterDirection.Input;
            param6.Value = textBoxPaisCliente.Text;
            param6.Size = 50;
            cmd.Parameters.Add(param6);

            var param7 = new SqlParameter("@correoElectronico", SqlDbType.VarChar);
            param7.Direction = ParameterDirection.Input;
            param7.Value = textBoxCorreoElectronicoCliente.Text;
            param7.Size = 50;
            cmd.Parameters.Add(param7);

            var param8 = new SqlParameter("@serviciosCliente", SqlDbType.Int);
            param8.Direction = ParameterDirection.Input;
            param8.Value = textBoxServiciosCliente.Text;
            cmd.Parameters.Add(param8);

            var param9 = new SqlParameter("@redesSociales", SqlDbType.VarChar);
            param9.Direction = ParameterDirection.Input;
            param9.Value = textBoxRRSScliente.Text;
            param9.Size = 220;
            cmd.Parameters.Add(param9);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Cliente creado correctamente");
        }

        private void buttonConsultaCliente_Click(object sender, EventArgs e)
        {
            //ConexionBD.getInstance();

            String consulta = "Select * from Clientes where cedula=" + textBoxCedulaCliente.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxNombreCliente.Text = leerDatos["nombreCliente"].ToString();
                textBoxPrimerApellidoCliente.Text = leerDatos["apellido1Cliente"].ToString();
                textBoxSegundoApellidoCliente.Text = leerDatos["apellido2Cliente"].ToString();
                textBoxCiudadCliente.Text = leerDatos["ciudad"].ToString();
                textBoxPaisCliente.Text = leerDatos["pais"].ToString();
                textBoxCorreoElectronicoCliente.Text = leerDatos["correoElectronico"].ToString();
                textBoxServiciosCliente.Text = leerDatos["serviciosCliente"].ToString();
                textBoxRRSScliente.Text = leerDatos["redesSociales"].ToString();

            }
            else
            {
                MessageBox.Show("No existe el registro");
            }
        }

        private void buttonActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.actualizaCliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@cedula", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxCedulaCliente.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@nombre", SqlDbType.VarChar);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxNombreCliente.Text;
                param2.Size = 50;
                cmd.Parameters.Add(param2);

                var param3 = new SqlParameter("@apellido1", SqlDbType.VarChar);
                param3.Direction = ParameterDirection.Input;
                param3.Value = textBoxPrimerApellidoCliente.Text;
                param3.Size = 50;
                cmd.Parameters.Add(param3);

                var param4 = new SqlParameter("@apellido2", SqlDbType.VarChar);
                param4.Direction = ParameterDirection.Input;
                param4.Value = textBoxSegundoApellidoCliente.Text;
                param4.Size = 50;
                cmd.Parameters.Add(param4);

                var param5 = new SqlParameter("@ciudad", SqlDbType.VarChar);
                param5.Direction = ParameterDirection.Input;
                param5.Value = textBoxCiudadCliente.Text;
                param5.Size = 50;
                cmd.Parameters.Add(param5);

                var param6 = new SqlParameter("@pais", SqlDbType.VarChar);
                param6.Direction = ParameterDirection.Input;
                param6.Value = textBoxPaisCliente.Text;
                param6.Size = 50;
                cmd.Parameters.Add(param6);

                var param7 = new SqlParameter("@correoElectronico", SqlDbType.VarChar);
                param7.Direction = ParameterDirection.Input;
                param7.Value = textBoxCorreoElectronicoCliente.Text;
                param7.Size = 50;
                cmd.Parameters.Add(param7);

                var param8 = new SqlParameter("@serviciosCliente", SqlDbType.Int);
                param8.Direction = ParameterDirection.Input;
                param8.Value = textBoxServiciosCliente.Text;
                cmd.Parameters.Add(param8);

                var param9 = new SqlParameter("@redesSociales", SqlDbType.VarChar);
                param9.Direction = ParameterDirection.Input;
                param9.Value = textBoxRRSScliente.Text;
                param9.Size = 220;
                cmd.Parameters.Add(param9);

                cmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Cliente actualizado correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.eliminaCliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@cedula", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxCedulaCliente.Text;
                cmd.Parameters.Add(param1);

                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Se ha borrado el cliente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void comboBoxServiciosCliente_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void buttonRegistrarRS_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.registrarRS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@nombreRS", SqlDbType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxRRSSempresa.Text;
            param1.Size = 20;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@nombreUsuarioRS", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxNombreUsuarioRS.Text;
            param2.Size = 20;
            cmd.Parameters.Add(param2);


            var param3 = new SqlParameter("@claveRS", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxClaveRS.Text;
            param3.Size = 120;
            cmd.Parameters.Add(param3);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Red social creada correctamente");
        }

        private void buttonAsignarServicioCliente_Click(object sender, EventArgs e)
        {
            textBoxServiciosCliente.Text = comboBoxServiciosCliente.Text;
        }

        private void buttonAsignarRS_Click(object sender, EventArgs e)
        {
            textBoxRRSScliente.Text = comboBoxRRSS.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDMercadeoDataSet.campannasMercadeo' Puede moverla o quitarla según sea necesario.
            this.campannasMercadeoTableAdapter.Fill(this.bDMercadeoDataSet.campannasMercadeo);

        }

        private void buttonReporteCampanna_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            var formateoFecha = dateTimePickerReporteCampannas.Value.ToString("yyyy/MM/dd");
                 
            String consulta = "Select * from campannasMercadeo where fechaInicio ='"+formateoFecha+"' order by pais";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
            var dataAdapter = new SqlDataAdapter(consulta, conexion);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewReportes.ReadOnly = true;
            dataGridViewReportes.DataSource = dataSet.Tables[0];

        }

        private void buttonReporteClientesyServicios_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            if (String.IsNullOrEmpty(textBoxCedulaClienteReportes.Text) | String.IsNullOrEmpty(textBoxIdServiciosReportes.Text) | String.IsNullOrEmpty(comboBoxFormaPagoReportes.Text))
            {
                String consulta= "Select idServicio, descripcionServicio, nombreCliente, apellido1Cliente, apellido2Cliente, formaDePago from Servicios, Clientes";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }
            else
            {
                String consulta = "Select idServicio, descripcionServicio, nombreCliente, apellido1Cliente, apellido2Cliente, formaDePago from Servicios, Clientes where Servicios.idServicio =" + textBoxIdServiciosReportes.Text + " or Clientes.cedula=" + textBoxCedulaClienteReportes.Text + " or Servicios.formaDePago='" + comboBoxFormaPagoReportes.Text + "'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();
            String consulta = "select nombreRedSocial, count (nombreRedSocial) as CantidadClientesPorRedSocial from RedesSociales, Clientes where Clientes.redesSociales = RedesSociales.nombreRedSocial and Clientes.redesSociales= '"+comboBoxRedSocialReportes.Text+"' group by nombreRedSocial";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
            var dataAdapter = new SqlDataAdapter(consulta, conexion);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewReportes.ReadOnly = true;
            dataGridViewReportes.DataSource = dataSet.Tables[0];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select cedula, nombreCliente, apellido1Cliente, apellido2Cliente, ciudad, pais, correoElectronico, serviciosCliente, redesSociales from Clientes where pais ='" + comboBoxPaisReportes.Text + "' and apellido1Cliente='" + textBoxApellidoReporteClientes.Text + "' or apellido2Cliente='" + textBoxApellidoReporteClientes.Text + "' and ciudad= '" + comboBoxCiudadesReporteClientes.Text+"'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
            var dataAdapter = new SqlDataAdapter(consulta, conexion);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewReportes.ReadOnly = true;
            dataGridViewReportes.DataSource = dataSet.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //ConexionBD.getInstance();
                MessageBox.Show("Entro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No entro");
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
