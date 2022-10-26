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
    public partial class frmAltaFactura : Form
    {
        public frmAltaFactura()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaFactura_Load(object sender, EventArgs e)
        {
            txtBox1.Visible = false; txtBox2.Visible = false; txtBox3.Visible = false; txtBox4.Visible = false; textBox1.Visible = false; panel1.Visible = true;
            txtBox5.Visible = false; txtBox6.Visible = false; txtBox7.Visible = false; txtBox8.Visible = false; textBox2.Visible = false; label11.Visible = true;
            txtBox9.Visible = false; txtBox10.Visible = false; txtBox11.Visible = false; txtBox12.Visible = false; textBox3.Visible = false;
            txtBox13.Visible = false; txtBox14.Visible = false; txtBox15.Visible = false; txtBox16.Visible = false; textBox4.Visible = false;
            txtBox17.Visible = false; txtBox18.Visible = false; txtBox19.Visible = false; txtBox20.Visible = false; txtTotal.Visible = false; label12.Visible = false;
            label7.Visible = false; label8.Visible = false; label9.Visible = false; label10.Visible = false; textBox5.Visible = false; label16.Visible = false; button2.Visible = false;
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            string sql = "SELECT idcliente as CODIGO,nombre as CLIENTE_NOMBRE, apellido as CLIENTE_APELLIDO FROM Clientes";
            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgvClientes.DataSource = dt;
            con.Open();
            
            string query = "SELECT max(idfactura) as Maximo from factura;";
            OleDbDataAdapter nro = new OleDbDataAdapter(query, cadena);
            DataTable dt1 = new DataTable();
            con.Close();
            nro.Fill(dt1);
            int siguiente = Convert.ToInt32(dt1.Rows[0]["Maximo"]) + 1;
            txtNroFactura.Text = Convert.ToString(siguiente);
            con.Open();
            string articulos = "SELECT idarticulos as CODIGO,nombre as ARTICULO,precio as PRECIO FROM articulos";
            OleDbDataAdapter art = new OleDbDataAdapter(articulos, cadena);
            DataTable dtArt = new DataTable();
            con.Close();
            art.Fill(dtArt);
            dgvArticulos.DataSource = dtArt;
            txtFechaHoy.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            label7.Visible = true; label8.Visible = true; label9.Visible = true; label10.Visible = true; label12.Visible = true;
            txtBox1.Visible = true; txtBox2.Visible = true; txtBox3.Visible = true; textBox1.Visible = true;
            txtBox1.ReadOnly = true; txtBox2.ReadOnly = true; txtBox3.Focus(); textBox1.ReadOnly = true;  
            txtBox1.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            txtBox2.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[1].Value.ToString();
            textBox1.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[2].Value.ToString();
            txtBox3.Text = "1";
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            txtBox5.Visible = true; txtBox6.Visible = true; textBox2.Visible = true; txtBox7.Visible = true;
            txtBox5.ReadOnly = true; txtBox6.ReadOnly = true; textBox2.ReadOnly = true ; txtBox7.Focus();
            txtBox5.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            txtBox6.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[1].Value.ToString();
            textBox2.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[2].Value.ToString();
            txtBox7.Text = "1";
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            txtBox9.Visible = true; txtBox10.Visible = true; textBox3.Visible = true; txtBox11.Visible = true;
            txtBox9.ReadOnly = true; txtBox10.ReadOnly = true; textBox3.ReadOnly = true; txtBox11.Focus();
            txtBox9.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            txtBox10.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[1].Value.ToString();
            textBox3.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[2].Value.ToString();
            txtBox11.Text = "1";
        }

        private void btnAgregar4_Click(object sender, EventArgs e)
        {
            txtBox13.Visible = true; txtBox14.Visible = true; textBox4.Visible = true; txtBox15.Visible = true;
            txtBox13.ReadOnly = true; txtBox14.ReadOnly = true; textBox4.ReadOnly = true; txtBox15.Focus();
            txtBox13.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            txtBox14.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[1].Value.ToString();
            textBox4.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[2].Value.ToString();
            txtBox15.Text = "1";
        }

        private void btnAgregar5_Click(object sender, EventArgs e)
        {
            txtBox17.Visible = true; txtBox18.Visible = true; textBox5.Visible = true; txtBox19.Visible = true;
            txtBox17.ReadOnly = true; txtBox18.ReadOnly = true; textBox5.ReadOnly = true; txtBox19.Focus();
            txtBox17.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            txtBox18.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[1].Value.ToString();
            textBox5.Text = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[2].Value.ToString();
            txtBox19.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Para continuar debe ingresar un Cliente");
                return;
            }
            if (txtBox1.Visible == true)
            {
                label10.Visible = true; txtBox4.Visible = true;
                decimal pre1, cant1;
                cant1 = Convert.ToDecimal(txtBox3.Text);
                pre1 = Convert.ToDecimal(textBox1.Text);
                txtBox4.ReadOnly = true;
                txtBox4.Text = Convert.ToString(cant1 * pre1);
            }
            else
            {
                MessageBox.Show("Debe al menos seleccionar un artículo. Vuelva a intentar");
                return;
            }
            if (txtBox5.Visible == true)
            {
                txtBox8.Visible = true;
                decimal pre2, cant2;
                cant2 = Convert.ToDecimal(txtBox7.Text);
                pre2 = Convert.ToDecimal(textBox2.Text);
                txtBox8.ReadOnly = true;
                txtBox8.Text = Convert.ToString(cant2 * pre2);
            }
            else
            {
                txtTotal.Visible = true; label16.Visible = true; button2.Visible = true;
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtBox4.Text));
                    return;
            }
            if (txtBox9.Visible == true)
            {
                txtBox12.Visible = true;
                decimal pre3, cant3;
                cant3 = Convert.ToDecimal(txtBox11.Text);
                pre3 = Convert.ToDecimal(textBox3.Text);
                txtBox12.ReadOnly = true;
                txtBox12.Text = Convert.ToString(cant3 * pre3);
            }
            else
            {
                txtTotal.Visible = true; label16.Visible = true; button2.Visible = true;
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtBox4.Text)+Convert.ToDecimal(txtBox8.Text));
                return;
            }
            if (txtBox13.Visible == true)
            {
                txtBox16.Visible = true;
                decimal pre4, cant4;
                cant4 = Convert.ToDecimal(txtBox15.Text);
                pre4 = Convert.ToDecimal(textBox4.Text);
                txtBox16.ReadOnly = true;
                txtBox16.Text = Convert.ToString(cant4 * pre4);
            }
            else
            {
                txtTotal.Visible = true; label16.Visible = true; button2.Visible = true;
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtBox4.Text) + Convert.ToDecimal(txtBox8.Text)+Convert.ToDecimal(txtBox12.Text));
                return;
            }
            if (txtBox17.Visible == true)
            {
                txtBox20.Visible = true; label16.Visible = true; button2.Visible = true;
                decimal pre5, cant5;
                cant5 = Convert.ToDecimal(txtBox19.Text);
                pre5 = Convert.ToDecimal(textBox5.Text);
                txtBox20.Text = Convert.ToString(cant5 * pre5);
                txtBox20.ReadOnly = true;
                txtTotal.Visible = true;
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtBox4.Text) + Convert.ToDecimal(txtBox8.Text) + Convert.ToDecimal(txtBox12.Text) + Convert.ToDecimal(txtBox16.Text) + Convert.ToDecimal(txtBox20));
                return;
            }
            else
            {
                txtTotal.Visible = true; label16.Visible = true; button2.Visible = true;
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtBox4.Text) + Convert.ToDecimal(txtBox8.Text)+ Convert.ToDecimal(txtBox12.Text) + Convert.ToDecimal(txtBox16.Text));
                return;
            }
            
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCliente.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString();
            txtClienteApellido.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[2].Value.ToString();
            txtClienteNombre.Text = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Preparamos el nuevo registro de factura */
            int factura = Convert.ToInt32(txtNroFactura.Text);
            DateTime fecha = DateTime.Parse(txtFechaHoy.Text); 
            int IdCliente = Convert.ToInt32(txtIdCliente.Text);
            decimal total = Decimal.Parse(txtTotal.Text);
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            string insertfactura = "INSERT INTO factura(nrofactura,fechafactura,idcliente,total) VALUES("+factura+",'"+fecha+"',"+IdCliente+","+total+")";
            //string nuevoIdfactura = "Select max(idfactura) as Maximo from factura";
            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();
            OleDbCommand comando = new OleDbCommand(insertfactura, con);
            comando.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Los datos de la FACTURA ingresaron exitosamente");
            
            /* Preparamos losregistros de detalle de factura */
            if (txtBox1.Visible == true)
            {
                int idart1 = Convert.ToInt32(txtBox1.Text);
                int cant1 = Convert.ToInt32(txtBox3.Text);
                string articulo1 = "INSERT INTO detalle(idfactura,idarticulo,cantidad) VALUES("+ factura +","+idart1+","+cant1+")";
                con.Open();
                OleDbCommand detalle = new OleDbCommand(articulo1, con);
                detalle.ExecuteNonQuery();
                MessageBox.Show("Los datos del DETALLE DE LA FACTURA ingresaron exitosamente");
                con.Close();
            }
            if (txtBox5.Visible == true)
            {
                int idart2 = Convert.ToInt32(txtBox5.Text);
                int cant2 = Convert.ToInt32(txtBox7.Text);
                string articulo2 = "INSERT INTO detalle(idfactura,idarticulo,cantidad) VALUES(" + factura + "," + idart2 + "," + cant2 + ")";
                con.Open();
                OleDbCommand detalle = new OleDbCommand(articulo2, con);
                detalle.ExecuteNonQuery();
                MessageBox.Show("Los datos del DETALLE DE LA FACTURA ingresaron exitosamente");
                con.Close();
            }
            else
            {
                MessageBox.Show("Se ingresó UN solo artículo en el Detalle");
                return;
            }
            if (txtBox9.Visible == true)
            {
                int idart3 = Convert.ToInt32(txtBox9.Text);
                int cant3 = Convert.ToInt32(txtBox11.Text);
                string articulo3 = "INSERT INTO detalle(idfactura,idarticulo,cantidad) VALUES(" + factura + "," + idart3 + "," + cant3 + ")";
                con.Open();
                OleDbCommand detalle = new OleDbCommand(articulo3, con);
                detalle.ExecuteNonQuery();
                MessageBox.Show("Los datos del DETALLE DE LA FACTURA ingresaron exitosamente");
                con.Close();
            }
            else
            {
                MessageBox.Show("Se ingresaron solo DOS artículo en el Detalle");
                return;
            }
            if (txtBox13.Visible == true)
            {
                int idart4 = Convert.ToInt32(txtBox13.Text);
                int cant4 = Convert.ToInt32(txtBox15.Text);
                string articulo4 = "INSERT INTO detalle(idfactura,idarticulo,cantidad) VALUES(" + factura + "," + idart4 + "," + cant4 + ")";
                con.Open();
                OleDbCommand detalle = new OleDbCommand(articulo4, con);
                detalle.ExecuteNonQuery();
                MessageBox.Show("Los datos del DETALLE DE LA FACTURA ingresaron exitosamente");
                con.Close();
            }
            else
            {
                MessageBox.Show("Se ingresaron solo TRES artículo en el Detalle");
                return;
            }
            if (txtBox17.Visible == true)
            {
                int idart5 = Convert.ToInt32(txtBox17.Text);
                int cant5 = Convert.ToInt32(txtBox19.Text);
                string articulo5 = "INSERT INTO detalle(idfactura,idarticulo,cantidad) VALUES(" + factura + "," + idart5 + "," + cant5 + ")";
                con.Open();
                OleDbCommand detalle = new OleDbCommand(articulo5, con);
                detalle.ExecuteNonQuery();
                MessageBox.Show("Los datos del DETALLE DE LA FACTURA ingresaron exitosamente");
                con.Close();
            }
            else
            {
                MessageBox.Show("Se ingresaron solo CUATRO artículo en el Detalle");
            }
        }

    }
}
