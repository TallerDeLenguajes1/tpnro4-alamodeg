using CadeteriaRecargada.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeteriaRecargada
{
    public class Helper
    {
        public static int IdCadete = 1;
        private static Random rand = new Random();
        public enum EstadoPedido { Noentregado, Entregado }
        public enum TipoPedido { Express, Delicado, Ecologico }
        public enum TipoVehiculo { Moto, Auto, Bicicleta }

        private static string[] nombres = { "Escanor", "Musi", "Ticiano", "Maxi", "Zilverman" };
        private static string[] apellidos = { "del Valle", "Ponce de Leon", "Gomez", "Albornoz", "de la Vega" };
        private static string[] observaciones = { "Cuidado con el perro", "Traer cambio", "Dejar en la puerta" };
        private static string[] direcciones = { "Lomas de Tafi Manzana 17 casa 20 ", "Av. Belgrano 4000", "Pasaje Roca 380" };

        public static TipoPedido Pedido()
        {
            return (TipoPedido)rand.Next(3);
        }
        public static TipoVehiculo Vehiculo()
        {
            return (TipoVehiculo)rand.Next(3);
        }
        public static int Telefono()
        {
            return rand.Next(4000000, 50000000);
        }
        public static string Nombre()
        {
            return nombres[rand.Next(5)];
        }
        public static string Apellido()
        {
            return apellidos[rand.Next(5)];
        }
        public static string Observacion()
        {
            return observaciones[rand.Next(3)];
        }
        public static string Direccion()
        {
            return observaciones[rand.Next(3)];
        }
        public static List<Cadete> CrearCadetes()
        {
            List<Cadete> ListaCadetes = new List<Cadete>();
            int cant_cadete = rand.Next(1, 11);
            for (int i = 0; i < cant_cadete; i++)
            {
                Cadete NuevoCadete = new Cadete(IdCadete, Nombre(), Direccion(), Telefono(), CrearPedidos(), Vehiculo());
                ListaCadetes.Add(NuevoCadete);
                IdCadete++;
            }
            return ListaCadetes;
        }
        public static List<Pedido> CrearPedidos()
        {
            int cant_pedidos = rand.Next(1, 10);
            List<Pedido> ListaPedidos = new List<Pedido>();

            for (int i = 0; i < cant_pedidos; i++)
            {
                Pedido NuevoPedido = new Pedido(i+1, Observacion(), Pedido(), 0, i+1, Nombre(), Direccion(), Telefono());
                ListaPedidos.Add(NuevoPedido);
            }
            return ListaPedidos;
        }
        /// <summary>
        /// Genera valores aleatorios del atributo Estado de entrega
        /// </summary>
        /// <param name="listacadetes"></param>
        public static List<Cadete> EntregarPedidos(List<Cadete> listacadetes)
        {
            foreach (var cadeteX in listacadetes)
            {
                //cadeteX.lista
            }
            return listacadetes;
        }
    }
}
