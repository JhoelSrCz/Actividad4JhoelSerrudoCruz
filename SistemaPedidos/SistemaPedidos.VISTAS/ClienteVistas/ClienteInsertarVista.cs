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

namespace SistemaPedidos.VISTAS.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        public static int IdClienteSeleccionado = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBox2.Text;
            cliente.Apellido = textBox3.Text;
            cliente.CorreoElectronico = textBox4.Text;
            cliente.Telefono = textBox5.Text;
            cliente.Direccion = textBox6.Text;

            bss.InsertarClienteBss(cliente);

            MessageBox.Show("El cliente a sido insertado correctamente");
        }

        private void ClienteInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
