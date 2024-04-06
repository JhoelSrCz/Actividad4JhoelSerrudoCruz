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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaPedidos.VISTAS.PedidoVistas
{
    public partial class PedidoEditarVista : Form
    {
        int idx = 0;
        Pedido pedido = new Pedido();
        PedidoBss bss = new PedidoBss();
        public PedidoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bssc = new ClienteBss();
        private void PedidoEditarVista_Load(object sender, EventArgs e)
        {
            pedido = bss.ObtenerPedidoIdBss(idx);
            IdClienteSeleccionado = pedido.IdCliente;
            textBox1.Text = pedido.IdCliente.ToString();
            dateTimePicker1.Value = pedido.Fecha;
            textBox2.Text = pedido.Total.ToString();
            textBox3.Text = pedido.Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pedido.IdCliente = IdClienteSeleccionado;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bss.EditarPedidoBss(pedido);

            MessageBox.Show("Datos actualizados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssc.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.Nombre;
            }
        }
    }
}
