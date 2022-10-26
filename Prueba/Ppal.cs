using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Ppal : Form
    {
        public Ppal()
        {
            InitializeComponent();
        }

        private void formConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest();
            frm.Show();
        }

        private void formIngresoDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sALIDADELSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos frm = new frmArticulos();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿Está seguro de Salir?", "Salida del Sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (rpta == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("¿Tonces pa qué carajo eligió salir?", "Decídase", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas frm = new frmFacturas();
            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaFactura frm = new frmAltaFactura();
            frm.Show();
        }
    }
}
