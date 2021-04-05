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

namespace Formulario_Proyecto_Final
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        string query = string.Empty;
        ServicioClienteCredito.ServicioClienteCredidoSoapClient servicio = new ServicioClienteCredito.ServicioClienteCredidoSoapClient();
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection("server=RENEGONZALEZ\\SQLEXPRESS ; database=Solicitud ; integrated security = true");
            conexion.Open();
            try
            {
                query = string.Format("select Descripcion from catalogoEmpleados");
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    cbTrabajos.Items.Add(dr["Descripcion"].ToString().TrimStart().TrimEnd());

                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            conexion.Close();
        }

        private void BtnConsultarEficiencia_Click(object sender, EventArgs e)
        {
            txtEficiencia.Text = servicio.ConsultarTrabajoDesempeñado(Convert.ToInt32(txtNumeroCuenta.Text));
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (servicio.Grabar(txtNumeroCuenta.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, 
                txtFecha.Text, txtDomicilio.Text, cbTrabajos.Text, txtReferencia.Text, txtEficiencia.Text))
            {
                MessageBox.Show("Grabo con exito");
                txtNumeroCuenta.Text = string.Empty;
                txtNumeroCuenta.Focus();
                txtPrimerNombre.Text = string.Empty;
                txtSegundoNombre.Text = string.Empty;
                txtApellidoPaterno.Text = string.Empty;
                txtApellidoMaterno.Text = string.Empty;
                txtFecha.Text = string.Empty;
                txtDomicilio.Text = string.Empty; 
                cbTrabajos.Text = string.Empty;
                txtReferencia.Text = string.Empty; 
                txtEficiencia.Text = string.Empty;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
