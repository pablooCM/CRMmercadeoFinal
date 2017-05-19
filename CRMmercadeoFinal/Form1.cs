using System;
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
        
        public Form1()
        {
            InitializeComponent();
            jalaPaisesComboBox();
            jalaCiudadesComboBox();
            jalaServiciosComboBox();
            jalarPaisesListBox();
            jalarPaisesListBoxCampanna();
            jalaClientesDataGridCampanna();
        }


        private void jalaClientesDataGridCampanna()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select cedula, nombre from Cliente";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
            var dataAdapter = new SqlDataAdapter(consulta, conexion);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewClientesCampanna.ReadOnly = true;
            dataGridViewClientesCampanna.DataSource = dataSet.Tables[0];


            
        }
        private void jalarPaisesListBoxCampanna()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select nombrePais from Pais";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                listBoxPaisesCampanna.Items.Add(leerDatos[0].ToString());
            }
        }
      
        private void jalaPaisesComboBox()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "Select nombrePais from Pais";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxPaisReportes.Items.Add(leerDatos[0].ToString());
            }
        }
        private void jalarPaisesListBox()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select nombrePais from Pais";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                listBoxPaises.Items.Add(leerDatos[0].ToString());
            }
        }
        private void jalaServiciosComboBox()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select descripcion from Servicio";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxServiciosCliente.Items.Add(leerDatos[0].ToString());
            }
        }
        private void jalaCiudadesComboBox()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "Select ciudad from Cliente";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxCiudadesReporteClientes.Items.Add(leerDatos[0].ToString());
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
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();
            
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

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Cliente creado correctamente");
        }

        private void buttonConsultaCliente_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "Select * from Cliente where cedula=" + textBoxCedulaCliente.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxNombreCliente.Text = leerDatos["nombre"].ToString();
                textBoxPrimerApellidoCliente.Text = leerDatos["apellido1"].ToString();
                textBoxSegundoApellidoCliente.Text = leerDatos["apellido2"].ToString();
                textBoxCiudadCliente.Text = leerDatos["ciudad"].ToString();
                textBoxPaisCliente.Text = leerDatos["pais"].ToString();
                textBoxCorreoElectronicoCliente.Text = leerDatos["correoElectronico"].ToString();

            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
        }

        private void buttonActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
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
                param2.Size = 30;
                cmd.Parameters.Add(param2);

                var param3 = new SqlParameter("@apellido1", SqlDbType.VarChar);
                param3.Direction = ParameterDirection.Input;
                param3.Value = textBoxPrimerApellidoCliente.Text;
                param3.Size = 30;
                cmd.Parameters.Add(param3);

                var param4 = new SqlParameter("@apellido2", SqlDbType.VarChar);
                param4.Direction = ParameterDirection.Input;
                param4.Value = textBoxSegundoApellidoCliente.Text;
                param4.Size = 30;
                cmd.Parameters.Add(param4);

                var param5 = new SqlParameter("@ciudad", SqlDbType.VarChar);
                param5.Direction = ParameterDirection.Input;
                param5.Value = textBoxCiudadCliente.Text;
                param5.Size = 30;
                cmd.Parameters.Add(param5);

                var param6 = new SqlParameter("@pais", SqlDbType.VarChar);
                param6.Direction = ParameterDirection.Input;
                param6.Value = textBoxPaisCliente.Text;
                param6.Size = 30;
                cmd.Parameters.Add(param6);

                var param7 = new SqlParameter("@correoElectronico", SqlDbType.VarChar);
                param7.Direction = ParameterDirection.Input;
                param7.Value = textBoxCorreoElectronicoCliente.Text;
                param7.Size = 30;
                cmd.Parameters.Add(param7);

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
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
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
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
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
            MessageBox.Show("Red social registrada correctamente");
        }

        private void buttonAsignarServicioCliente_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select idServicio from Servicio where descripcion='"+ comboBoxServiciosCliente.Text+"'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            if (leerDatos.Read() == true)
            {
                textBoxGeneraIdServicio.Text = leerDatos["idServicio"].ToString();

            }
            else
            {
                MessageBox.Show("No existe el servicio");
            }
            leerDatos.Close();

            SqlCommand cmd = new SqlCommand("dbo.asignarServicioCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@idServicio", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxGeneraIdServicio.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@cedula", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxCedulaCliente.Text;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter("@estadoServicio", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = comboBoxEstadoServicioClienteCliente.Text;
            param3.Size = 30;
            cmd.Parameters.Add(param3);

            var param4 = new SqlParameter("@idPais", SqlDbType.Int);
            param4.Direction = ParameterDirection.Input;
            param4.Value = textBoxPaisCliente.Text;
            cmd.Parameters.Add(param4);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Servicio asignado correctamente");

        }

        private void buttonAsignarRS_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select idRedSocial from RedSocialCliente where nombreRedSocial='" + comboBoxRRSS.Text + "'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            if (leerDatos.Read() == true)
            {
                textBoxGeneraIdRedSocial.Text = leerDatos["idRedSocial"].ToString();

            }
            else
            {
                MessageBox.Show("No existe red social");
            }
            leerDatos.Close();

            SqlCommand cmd = new SqlCommand("dbo.asignarRedSocialCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@idRedSocial", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxGeneraIdRedSocial.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@cedula", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxCedulaCliente.Text;
            cmd.Parameters.Add(param2);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Red Social asignada correctamente");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDMercadeoDataSet.campannasMercadeo' Puede moverla o quitarla según sea necesario.
            this.campannasMercadeoTableAdapter.Fill(this.bDMercadeoDataSet.campannasMercadeo);

        }

        private void buttonReporteCampanna_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            var formateoFecha = dateTimePickerReporteCampannas.Value.ToString("yyyy/MM/dd");
                 
            String consulta = "Select * from CampannaMercadeo, Pais where fechaInicio ='"+formateoFecha+"' or fechaFinal='"+formateoFecha+"' order by nombrePais";
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
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            if (String.IsNullOrEmpty(textBoxCedulaClienteReportes.Text) && String.IsNullOrEmpty(textBoxIdServiciosReportes.Text) && String.IsNullOrEmpty(comboBoxFormaPagoReportes.Text))
            {
                String consulta= "Select idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Servicio, Cliente";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }

            if (!string.IsNullOrWhiteSpace(textBoxCedulaClienteReportes.Text))
            {
                String consulta = "Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Cliente.cedula =" + textBoxCedulaClienteReportes.Text;
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }
            if (!string.IsNullOrWhiteSpace(textBoxIdServiciosReportes.Text))
            {
                String consulta = "Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Servicio.idServicio =" + textBoxIdServiciosReportes.Text;
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }
            if (!string.IsNullOrWhiteSpace(comboBoxFormaPagoReportes.Text))
            {
                String consulta = "Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Servicio.formaDePago ='" + comboBoxFormaPagoReportes.Text+"'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }
            if(!string.IsNullOrWhiteSpace(textBoxCedulaClienteReportes.Text) && !string.IsNullOrWhiteSpace(textBoxIdServiciosReportes.Text))
            {
                String consulta = "Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Cliente.cedula ="+textBoxCedulaClienteReportes.Text+" and Servicio.idServicio="+ textBoxIdServiciosReportes.Text;
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }
            if (!string.IsNullOrWhiteSpace(textBoxCedulaClienteReportes.Text) && !string.IsNullOrWhiteSpace(comboBoxFormaPagoReportes.Text))
            {
                String consulta = "Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Cliente.cedula =" + textBoxCedulaClienteReportes.Text + " and Servicio.formaDePago='" + comboBoxFormaPagoReportes.Text + "'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }
            if (!string.IsNullOrWhiteSpace(textBoxIdServiciosReportes.Text) && !string.IsNullOrWhiteSpace(comboBoxFormaPagoReportes.Text))
            {
                String consulta = "Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Servicio.formaDePago='"+comboBoxFormaPagoReportes.Text+"' and Servicio.idServicio="+textBoxIdServiciosReportes.Text;
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
                var dataAdapter = new SqlDataAdapter(consulta, conexion);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewReportes.ReadOnly = true;
                dataGridViewReportes.DataSource = dataSet.Tables[0];
            }

            if (!string.IsNullOrWhiteSpace(textBoxCedulaClienteReportes.Text) && !string.IsNullOrWhiteSpace(textBoxIdServiciosReportes.Text) && !string.IsNullOrWhiteSpace(comboBoxFormaPagoReportes.Text))
            {
                String consulta = "Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Servicio.formaDePago='"+comboBoxFormaPagoReportes.Text+"' and Servicio.idServicio="+textBoxIdServiciosReportes.Text+" and Cliente.cedula =" +textBoxCedulaClienteReportes.Text;
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
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
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
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
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

        private void buttonCrearServicio_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.crearServicio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@idServicio", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxIdServicio.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@descripcion", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxDescripcionServicio.Text;
            param2.Size = 30;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter("@formaDePago", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = comboBoxFormaPago.Text;
            param3.Size = 30;
            cmd.Parameters.Add(param3);

            var param4 = new SqlParameter("@estadoServicio", SqlDbType.VarChar);
            param4.Direction = ParameterDirection.Input;
            param4.Value = comboBoxEstadoServicio.Text;
            param4.Size = 30;
            cmd.Parameters.Add(param4);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Servicio creado correctamente");
        }

        private void buttonAgregarPais_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            foreach (var item in listBoxPaises.SelectedItems)
            {
                MessageBox.Show(item.ToString());
                listBoxPaisesServicio.Items.Add(item);

                String consulta = "select idPais from Pais where nombrePais='" +item+"'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

                SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

                if (leerDatos.Read() == true)
                {
                    textBoxGeneraIdPais.Text = leerDatos["idPais"].ToString();

                }
                else
                {
                    MessageBox.Show("No existe el pais");
                }
                leerDatos.Close();


                SqlCommand cmd = new SqlCommand("dbo.asignarPaisaServicio", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idServicio", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdServicio.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@idPais", SqlDbType.Int);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxGeneraIdPais.Text;
                cmd.Parameters.Add(param2);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }


        }

        private void buttonConsultarServicio_Click(object sender, EventArgs e)
        {
            listBoxPaisesServicio.Items.Clear();
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "Select * from Servicio where idServicio=" + textBoxIdServicio.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxDescripcionServicio.Text = leerDatos["descripcion"].ToString();
                comboBoxFormaPago.Text = leerDatos["formaDePago"].ToString();
                comboBoxEstadoServicio.Text = leerDatos["estadoServicio"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el servicio");
            }
            leerDatos.Close();
            String consulta2 = "select nombrePais from Pais, IntermediaServicioyPais, Servicio where IntermediaServicioyPais.idPais=Pais.idPais and Servicio.idServicio =" + textBoxIdServicio.Text;
            SqlCommand consultaEnBD2 = new SqlCommand(consulta2, conexion);


            SqlDataReader leerDatos2 = consultaEnBD2.ExecuteReader();

            while (leerDatos2.Read())
            {
                listBoxPaisesServicio.Items.Add(leerDatos2[0].ToString());
            }
            leerDatos2.Close();

        }


        private void jalarPaisesConServicioListBox()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "select nombrePais from Pais, Servicio, IntermediaServicioyPais where IntermediaServicioyPais.idPais="+ textBoxGeneraIdPais.Text +" and IntermediaServicioyPais.idServicio =" + textBoxIdServicio.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                listBoxPaises.Items.Add(leerDatos[0].ToString());
            }
        }

        private void buttonQuitarPais_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            foreach (var item in listBoxPaisesServicio.SelectedItems)
            {
                MessageBox.Show(item.ToString());

                String consulta = "select idPais from Pais where nombrePais='" + item + "'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

                SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

                if (leerDatos.Read() == true)
                {
                    textBoxGeneraIdPais.Text = leerDatos["idPais"].ToString();

                }
                else
                {
                    MessageBox.Show("No existe el pais");
                }
                leerDatos.Close();


                SqlCommand cmd = new SqlCommand("dbo.quitarPaisServicio", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idServicio", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdServicio.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@idPais", SqlDbType.Int);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxGeneraIdPais.Text;
                cmd.Parameters.Add(param2);

                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Pais quitado correctamente");

            }


            
        }

        private void buttonActualizarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.actualizaServicio", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idServicio", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdServicio.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@descripcion", SqlDbType.VarChar);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxDescripcionServicio.Text;
                param2.Size = 30;
                cmd.Parameters.Add(param2);

                var param3 = new SqlParameter("@formaDePago", SqlDbType.VarChar);
                param3.Direction = ParameterDirection.Input;
                param3.Value = comboBoxFormaPago.Text;
                param3.Size = 30;
                cmd.Parameters.Add(param3);

                var param4 = new SqlParameter("@estadoServicio", SqlDbType.VarChar);
                param4.Direction = ParameterDirection.Input;
                param4.Value = comboBoxEstadoServicio.Text;
                param4.Size = 30;
                cmd.Parameters.Add(param4);

                cmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Servicio actualizado correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBorrarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.eliminaServicio", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idServicio", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdServicio.Text;
                cmd.Parameters.Add(param1);

                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Se ha borrado el servicio");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void buttonCrearCampanna_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.crearCampanna", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@idCampannaMercadeo", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxIdCampanna.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@nombreCampanna", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxNombreCampanna.Text;
            param2.Size = 40;
            cmd.Parameters.Add(param2);


            var formateoFechaIni = dateTimePickerFechaInicioCampanna.Value.ToString("yyyy/MM/dd");
            var param3 = new SqlParameter("@fechaInicio", SqlDbType.Date);
            param3.Direction = ParameterDirection.Input;
            param3.Value = formateoFechaIni;
            cmd.Parameters.Add(param3);

            var formateoFechaFin = dateTimePickerfFechaFinalizacionCampanna.Value.ToString("yyyy/MM/dd");
            var param4 = new SqlParameter("@fechaFinal", SqlDbType.Date);
            param4.Direction = ParameterDirection.Input;
            param4.Value = formateoFechaFin;
            cmd.Parameters.Add(param4);

            var param5 = new SqlParameter("@costoCampanna", SqlDbType.Int);
            param5.Direction = ParameterDirection.Input;
            param5.Value = textBoxCostoCampanna.Text;
            cmd.Parameters.Add(param5);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Campaña creada correctamente");
        }

        private void buttonAgregarPaisCampanna_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            foreach (var item in listBoxPaisesCampanna.SelectedItems)
            {
                MessageBox.Show(item.ToString());
                listBoxPaisesConCampanna.Items.Add(item);

                String consulta = "select idPais from Pais where nombrePais='" + item + "'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

                SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

                if (leerDatos.Read() == true)
                {
                    textBoxGeneraIdPais.Text = leerDatos["idPais"].ToString();
                }
                else
                {
                    MessageBox.Show("No existe el pais");
                }
                leerDatos.Close();


                SqlCommand cmd = new SqlCommand("dbo.asignarPaisaCampanna", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idCampannaMercadeo", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdCampanna.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@idPais", SqlDbType.Int);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxGeneraIdPais.Text;
                cmd.Parameters.Add(param2);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        private void buttonConsultarCampanna_Click(object sender, EventArgs e)
        {
            listBoxPaisesConCampanna.Items.Clear();
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "Select * from CampannaMercadeo where idCampannaMercadeo=" + textBoxIdCampanna.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxNombreCampanna.Text = leerDatos["nombreCampanna"].ToString();
                dateTimePickerFechaInicioCampanna.Text = leerDatos["fechaInicio"].ToString();
                dateTimePickerfFechaFinalizacionCampanna.Text = leerDatos["fechaFinal"].ToString();
                textBoxCostoCampanna.Text = leerDatos["costoCampanna"].ToString();
            }
            else
            {
                MessageBox.Show("No existe la campaña");
            }

            leerDatos.Close();
            String consulta2 = "select nombrePais from Pais, IntermediaPaisyCampannaMercadeo, CampannaMercadeo where IntermediaPaisyCampannaMercadeo.idPais=Pais.idPais and CampannaMercadeo.idCampannaMercadeo ="+ textBoxIdCampanna.Text;
            SqlCommand consultaEnBD2 = new SqlCommand(consulta2, conexion);


            SqlDataReader leerDatos2 = consultaEnBD2.ExecuteReader();

            while (leerDatos2.Read())
            {
                listBoxPaisesConCampanna.Items.Add(leerDatos2[0].ToString());
            }

        }

        private void buttonQuitarPaisCampanna_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            foreach (var item in listBoxPaisesConCampanna.SelectedItems)
            {
                MessageBox.Show(item.ToString());

                String consulta = "select idPais from Pais where nombrePais='" + item + "'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

                SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

                if (leerDatos.Read() == true)
                {
                    textBoxGeneraIdPais.Text = leerDatos["idPais"].ToString();

                }
                else
                {
                    MessageBox.Show("No existe el pais");
                }
                leerDatos.Close();


                SqlCommand cmd = new SqlCommand("dbo.quitarPaisCampanna", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idCampannaMercadeo", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdCampanna.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@idPais", SqlDbType.Int);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxGeneraIdPais.Text;
                cmd.Parameters.Add(param2);

                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Pais quitado correctamente");

            }
        }

        private void buttonActualizarCampanna_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.actualizaCampanna", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idCampannaMercadeo", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdCampanna.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@nombreCampanna", SqlDbType.VarChar);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxNombreCampanna.Text;
                param2.Size = 40;
                cmd.Parameters.Add(param2);

                var formateoFechaIni = dateTimePickerFechaInicioCampanna.Value.ToString("yyyy/MM/dd");
                var param3 = new SqlParameter("@fechaInicio", SqlDbType.Date);
                param3.Direction = ParameterDirection.Input;
                param3.Value = formateoFechaIni;
                cmd.Parameters.Add(param3);

                var formateoFechaFin = dateTimePickerfFechaFinalizacionCampanna.Value.ToString("yyyy/MM/dd");
                var param4 = new SqlParameter("@fechaFinal", SqlDbType.Date);
                param4.Direction = ParameterDirection.Input;
                param4.Value = formateoFechaFin;
                cmd.Parameters.Add(param4);

                var param5 = new SqlParameter("@costoCampanna", SqlDbType.Int);
                param5.Direction = ParameterDirection.Input;
                param5.Value = textBoxCostoCampanna.Text;
                cmd.Parameters.Add(param5);

                cmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Campaña actualizada correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBorrarCampanna_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.eliminaCampanna", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idCampannaMercadeo", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdCampanna.Text;
                cmd.Parameters.Add(param1);

                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Se ha borrado la campaña");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


        //borrar

        DataTable GetSelectedRows(DataGridView dataGridViewClientesCampanna)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dataGridViewClientesCampanna.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dataGridViewClientesCampanna.Columns.Count];
            foreach (DataGridViewRow row in dataGridViewClientesCampanna.Rows)
            {
                if (!row.Selected) continue;

                for (int i = 0; i < row.Cells.Count; i++)
                    cellValues[i] = row.Cells[i].Value;

                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void buttonAgregarClientesaCamapanna_Click(object sender, EventArgs e)
        {
            //dataGridViewClientesBeneficiadosCampanna.DataSource = GetSelectedRows(dataGridViewClientesCampanna);
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeoFinal;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            Int32 selectedCellCount = dataGridViewClientesCampanna.GetCellCount(DataGridViewElementStates.Selected);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (selectedCellCount > 0)
                {
                    if (dataGridViewClientesCampanna.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("Todas las ids seleccionadas");
                    }
                    else
                    {
                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            sb.Append(dataGridViewClientesCampanna.SelectedCells[i].Value.ToString());
                            MessageBox.Show(sb.ToString(), "IDs Seleccionados");
                        }
                    }
            }

            SqlCommand cmd = new SqlCommand("dbo.asignarClienteaCampanna", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            int cedulaParseada = int.Parse(sb.ToString());
            var param1 = new SqlParameter("@cedula", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = cedulaParseada;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@idCampannaMercadeo", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxIdCampanna.Text;
            cmd.Parameters.Add(param2);

            cmd.ExecuteNonQuery();

            String consulta = "select Cliente.cedula, nombre from Cliente, IntermediaCampannaMercadeoyCliente, CampannaMercadeo where IntermediaCampannaMercadeoyCliente.cedula =" + cedulaParseada + " and IntermediaCampannaMercadeoyCliente.idCampannaMercadeo =" + textBoxIdCampanna.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);
            var dataAdapter = new SqlDataAdapter(consulta, conexion);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewClientesBeneficiadosCampanna.ReadOnly = true;
            dataGridViewClientesBeneficiadosCampanna.DataSource = dataSet.Tables[0];

            conexion.Close();
        }

        private void buttonQuitarClientesaCampanna_Click(object sender, EventArgs e)
        {

        }
    }
}

        


