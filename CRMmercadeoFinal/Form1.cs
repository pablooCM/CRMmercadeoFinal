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

namespace CRMmercadeoFinal
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            jalaDatosComboBoxServClientes();
            jalaDatosComboBoxRRSSclientes();
        }

        private void jalaDatosComboBoxServClientes()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

            String consulta = "Select descripcionServicio from Servicios";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            while (leerDatos.Read())
            {
                comboBoxServiciosCliente.Items.Add(leerDatos[0].ToString());
            }
        }

        private void jalaDatosComboBoxRRSSclientes()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

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
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
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
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=WIN-1SDP8NVLN2A\\SA;Initial Catalog=BDMercadeo;Persist Security Info=True;User ID=sa;Password=claveParaAvanzadas2016!";
            conexion.Open();

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

    }
}
