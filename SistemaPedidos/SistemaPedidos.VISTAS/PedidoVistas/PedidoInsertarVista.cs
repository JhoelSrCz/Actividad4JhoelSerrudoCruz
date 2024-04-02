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
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSelecionada = 0;
        PedidoBss bssp = new PedidoBss();
        ClienteBss bss = new ClienteBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.IdCliente = IdClienteSelecionada;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToInt32(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bssp.InsertarPedidoBss(pedido);

            MessageBox.Show("El pedido ha sido insertado correctamente");
        }

        private void PedidoInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerClienteIdBss(IdClienteSelecionada);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }
    }
}
