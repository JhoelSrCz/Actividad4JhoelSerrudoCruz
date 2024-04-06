using SistemaPedidos.BSS;
using SistemaPedidos.Modelos;
using SistemaPedidos.VISTAS.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos.VISTAS.PedidoVistas
{
    public partial class CalcularPedidosVista : Form
    {
        public CalcularPedidosVista()
        {
            InitializeComponent();
        }
        public static int IdClienteteSeleccionado = 0;
        ClienteBss bssc = new ClienteBss();
        PedidoBss bssp = new PedidoBss();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssc.ObtenerClienteIdBss(IdClienteteSeleccionado);
                textBox1.Text = cliente.Nombre;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssp.CalcularPedidosClientesBss(IdClienteteSeleccionado);
        }
    }
}
