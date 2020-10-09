using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CadeteriaRecargada.Helper;

namespace CadeteriaRecargada.Clases
{

    public class Pedido
    {
        int nro;
        string obs;
        Cliente cliente;
        EstadoPedido estado;
        TipoPedido tipopedido;
        float costoPedido;

        public Pedido(int nro, string obs, TipoPedido tipopedido, float costoPedido, int id, string nombre, string direccion, int telefono)
        {
            this.nro = nro;
            this.obs = obs;
            this.cliente = new Cliente(id, nombre, direccion, telefono);
            this.estado = EstadoPedido.Noentregado;
            this.tipopedido = tipopedido;
            this.costoPedido = costoPedido;
        }

        public int Nro { get => nro; set => nro = value; }
        public string Obs { get => obs; set => obs = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public EstadoPedido Estado { get => estado; set => estado = value; }
        public TipoPedido Tipopedido { get => tipopedido; set => tipopedido = value; }
        public float CostoPedido { get => costoPedido; set => costoPedido = value; }
    }
}
