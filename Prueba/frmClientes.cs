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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            //OleDbConnection con = new OleDbConnection(cadena);
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito_pba.mdb;User Id=admin;Password=;";
            con.Open();
            string sql = "select * from Clientes";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con.ConnectionString);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor;
            valor = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            MessageBox.Show(valor, "El valor capturado");

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAltaCliente frm = new frmAltaCliente();
            frm.Show();
        }
    }
}
