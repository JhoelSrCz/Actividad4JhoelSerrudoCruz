using SistemaPedidos.BSS;
using SistemaPedidos.Modelos;
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

namespace SistemaPedidos.VISTAS.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bss.ObtenerClienteIdBss(idx);
            textBox2.Text = cliente.Nombre;
            textBox3.Text = cliente.Apellido;
            textBox4.Text = cliente.CorreoElectronico;
            textBox5.Text = cliente.Telefono;
            textBox6.Text = cliente.Direccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = textBox2.Text;
            cliente.Apellido = textBox3.Text;
            cliente.CorreoElectronico = textBox4.Text;
            cliente.Telefono = textBox5.Text;
            cliente.Direccion = textBox6.Text;

            bss.EditarClienteBss(cliente);

            MessageBox.Show("Los datos del cliente han sido actualizados correctamente");
        }
    }
}
