using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lista de 10 pedidos iniciales */
            Pedido uno = new Pedido(1, "Lomo Saltado", "Av Precursores 111, San Miguel");
            Pedido dos = new Pedido(2, "Arroz con pollo", "Av La Marina 1024, San Miguel");
            Pedido tres = new Pedido(3, "Tallarín Saltado", "Av Tingo María 325, Breña");
            Pedido cuatro = new Pedido(4, "Seco de cordero", "Av Brasil 1245, Jesús María");
            Pedido cinco = new Pedido(5, "Carapulcra", "Av Salaverry 2418, San Isidro");
            Pedido seis = new Pedido(6, "Sopaseca", "Av El Ejército 1510, Magdalena del Mar");
            Pedido siete = new Pedido(7, "Chaufa", "Av Arequipa 1920, Lince");
            Pedido ocho = new Pedido(8, "Ají de gallina", "Av Arenales 2080, Lince");
            Pedido nueve = new Pedido(9, "Chancho al palo", "Av Pardo 189, Miraflores");
            Pedido diez = new Pedido(10, "Caldo de gallina", "Av Costanera 415, San Miguel");

            Nodo header = new Nodo();
            header.datos = uno;

            ListaEnlazada ListaPedido = new ListaEnlazada();
            ListaPedido.header = header;

            Console.WriteLine("=============================================");
            Console.WriteLine("|| WABY CONSULTING - DEMO RAPPID (PEDIDOS) ||");
            Console.WriteLine("=============================================\n");

            /* Mostrando la lista inicial de pedidos */
            ListaPedido.GenerarListaInicial(dos);
            ListaPedido.GenerarListaInicial(tres);
            ListaPedido.GenerarListaInicial(cuatro);
            ListaPedido.GenerarListaInicial(cinco);
            ListaPedido.GenerarListaInicial(seis);
            ListaPedido.GenerarListaInicial(siete);
            ListaPedido.GenerarListaInicial(ocho);
            ListaPedido.GenerarListaInicial(nueve);
            ListaPedido.GenerarListaInicial(diez);
            ListaPedido.MostrarLista();

            /* Insertando un nuevo pedido al inicio de la lista */
            Console.WriteLine("<<<<<<<<<< AGREGANDO PEDIDO AL INICIO >>>>>>>>>>");
            Pedido once = new Pedido(11, "Arroz con mariscos", "Av El Reducto 1277, Miraflores");
            ListaPedido.AgregarPedidoAlInicio(once);
            ListaPedido.MostrarLista();

            /* Insertando un nuevo pedido después de un pedido referencial de la lista */
            Console.WriteLine("<<<<<<<<<< AGREGANDO PEDIDO POR REFERENCIA >>>>>>>>>>");
            Pedido doce = new Pedido(12, "Estofado de res", "Jr Lampa 879, Cercado de Lima");
            ListaPedido.AgregarPedidoLuegoDe(cuatro, doce);
            ListaPedido.MostrarLista();

            /* Insertando un nuevo pedido al final de la lista */
            Console.WriteLine("<<<<<<<<<< AGREGANDO PEDIDO AL FINAL >>>>>>>>>>");
            Pedido trece = new Pedido(13, "Pollo al maní", "Av Tacna 493, Cercado de Lima");
            ListaPedido.AgregarPedidoAlFinal(trece);
            ListaPedido.MostrarLista();

            /* Eliminando el pedido al inicio de la lista */
            Console.WriteLine("<<<<<<<<<< ELIMINANDO PEDIDO AL INICIO >>>>>>>>>>");
            ListaPedido.EliminarPedidoInicio();
            ListaPedido.MostrarLista();

            /* Eliminando un pedido después de otro pedido de la lista */
            Console.WriteLine("<<<<<<<<<< ELIMINANDO PEDIDO POR REFERENCIA >>>>>>>>>>");
            ListaPedido.EliminarPedidoLuegoDe(doce);
            ListaPedido.MostrarLista();

            /* Eliminando el pedido al final de la lista */
            Console.WriteLine("<<<<<<<<<< ELIMINANDO PEDIDO AL FINAL >>>>>>>>>>");
            ListaPedido.EliminarPedidoFinal();
            ListaPedido.MostrarLista();

            Console.ReadKey();
        }
    }
}
