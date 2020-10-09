using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CadeteriaRecargada.Helper;

namespace CadeteriaRecargada.Clases
{
    public class Cadete : Persona
    {
        List<Pedido> listapedido;
        TipoVehiculo tipoVehiculo;

        public Cadete(int id, string nombre, string direccion, int telefono, List<Pedido> listapedido, TipoVehiculo tipoVehiculo) :base(id, nombre, direccion, telefono) //Construye la clase padre primero
        {
            this.listapedido = listapedido;
            this.tipoVehiculo = tipoVehiculo;
        }
        public override int ContarPedidos()
        {
            return 2;
        }
    }
}
