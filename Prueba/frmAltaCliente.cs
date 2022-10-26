using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtDomicilio.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string domicilio = txtDomicilio.Text;
            decimal telefono = Convert.ToDecimal(txtTelefono.Text);
            string email = txtEmail.Text;
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            string sql = "INSERT INTO clientes(nombre,apellido,domicilio,telefono,email) VALUES('"+nombre+"','"+apellido+"','"+domicilio+"',"+telefono+",'"+email+"')";

            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();

            OleDbCommand comando = new OleDbCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtDomicilio.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }
    }
}
