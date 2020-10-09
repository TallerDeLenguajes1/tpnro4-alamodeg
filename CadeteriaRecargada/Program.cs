using CadeteriaRecargada.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeteriaRecargada
{
    class Program
    {
        static void Main()
        {
            Cadeteria MiCadeteria = new Cadeteria("Musi S.A",Helper.CrearCadetes());
            Console.ReadKey();
        }
    }
}
