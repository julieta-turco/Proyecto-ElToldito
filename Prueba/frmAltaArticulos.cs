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
    public partial class frmAltaArticulos : Form
    {
        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio = Decimal.Parse(txtPrecio.Text);
            decimal stock = Decimal.Parse(txtStock.Text);
            
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            string sql = "INSERT INTO articulos(nombre,precio,stock) VALUES('" + nombre + "'," + precio + "," + stock + ")";

            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();

            OleDbCommand comando = new OleDbCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmArticulos frm = new frmArticulos();
            frm.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNombre.Focus();
        }

        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
