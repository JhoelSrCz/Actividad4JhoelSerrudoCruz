using SistemaPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.DAL
{
    public class PedidoDal
    {
        public DataTable ListarPedidoDal()
        {
            string consulta = "select * from pedido";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPedidoDal(Pedido pedido)
        {
            string consulta = "insert into pedido values(" + pedido.IdCliente + "," +
                                                            "'" + pedido.Fecha + "'," +
                                                            "" + pedido.Total + "," +
                                                            "" + pedido.Estado + "," +
                                                            "')";
            conexion.Ejecutar(consulta);
        }
        public Pedido ObtenerPedidoIdDal(int id)
        {
            string consulta = "select * from pedido where idpedido=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Pedido pedido = new Pedido();
            if (tabla.Rows.Count > 0)
            {
                pedido.IdPedido = Convert.ToInt32(tabla.Rows[0]["idpedido"]);
                pedido.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                pedido.Fecha = Convert.ToDateTime(tabla.Rows[0]["nombre"]);
                pedido.Total = Convert.ToInt32(tabla.Rows[0]["total"]);
                pedido.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return pedido;
        }
        public void EditarPedidoDal(Pedido pedido)
        {
            string consulta = "update producto set idcliente=" + pedido.IdCliente + "," +
                                                        "fecha='" + pedido.Fecha + "'," +
                                                        "total=" + pedido.Total + "," +
                                                        "estado='" + pedido.Estado + "' " +
                                                "where idpedido=" + pedido.IdPedido;
            conexion.Ejecutar(consulta);
        }
        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from pedido where idpedido=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
