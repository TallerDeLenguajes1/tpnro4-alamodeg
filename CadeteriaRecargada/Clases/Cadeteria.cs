using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeteriaRecargada.Clases
{
    class Cadeteria
    {
        string nombre;
        List<Cadete> listaCadete;

        public Cadeteria(string nombre, List<Cadete> listaCadete)
        {
            this.nombre = nombre;
            this.listaCadete = listaCadete;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Cadete> ListaCadete { get => listaCadete; set => listaCadete = value; }
    }
}
