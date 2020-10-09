using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeteriaRecargada.Clases
{
    public class Cliente : Persona
    {
        public Cliente(int id, string nombre, string direccion, int telefono) : base(id, nombre, direccion, telefono)
        {
        }
        public override int ContarPedidos()
        {
            return 1;
        }
    }
}