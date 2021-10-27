using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    class ListaEnlazada
    {
        public Nodo header { get; set; }

        /* Métodos de recorrido */
        public void MostrarLista()
        {
            Console.WriteLine("============ INICIO DE LISTA DE PEDIDOS ============");
            Console.WriteLine("----------------------------------------------------");
            Nodo actual = header;
            while (actual != null)
            {
                Console.WriteLine(actual.datos.id + " | " + actual.datos.namePedido + " | " + actual.datos.direccion);
                actual = actual.next;
            }
            Console.WriteLine("============ FIN DE LISTA DE PEDIDOS ============");
            Console.WriteLine();
        }

        public void GenerarListaInicial(Pedido datos)
        {
            if (header == null)
            {
                header = new Nodo();
                header.datos = datos;
                header.next = null;
            }
            else
            {
                Nodo actual = header;
                Nodo nuevo = new Nodo();
                nuevo.datos = datos;
                while (actual.next != null)
                {
                    actual = actual.next;
                }
                actual.next = nuevo;
            }
        }

        /* Métodos de Inserción */
        public void AgregarPedidoAlInicio(Pedido datos)
        {
            Console.WriteLine("- Se agregó '" + datos.namePedido + "' (id: " + datos.id + ") al inicio.\n");
            Nodo nuevo = new Nodo();
            nuevo.datos = datos;
            nuevo.next = header;
            header = nuevo;
        }

        public void AgregarPedidoLuegoDe(Pedido referencia, Pedido datos)
        {
            Console.WriteLine("- Se agregó '" + datos.namePedido + "' (id: " + datos.id + ") " +
                "luego de '" + referencia.namePedido + "' (id: " + referencia.id + ") \n");
            Nodo nuevo = new Nodo();
            nuevo.datos = datos;
            Nodo actual = header;
            while (actual.datos.id != referencia.id)
            {
                actual = actual.next;
            }
            nuevo.next = actual.next;
            actual.next = nuevo;
        }

        public void AgregarPedidoAlFinal(Pedido datos)
        {
            Console.WriteLine("- Se agregó '" + datos.namePedido + "' (id: " + datos.id + ") al final.\n");
            if (header == null)
            {
                header = new Nodo();
                header.datos = datos;
                header.next = null;
            }
            else
            {
                Nodo actual = header;
                Nodo nuevo = new Nodo();
                nuevo.datos = datos;
                while (actual.next != null)
                {
                    actual = actual.next;
                }
                actual.next = nuevo;
            }
        }

        /* Métodos de Eliminación */
        public void EliminarPedidoInicio()
        {
            string eliminado;
            int id;
            Nodo tempnodo = new Nodo();
            tempnodo = header;
            eliminado = tempnodo.datos.namePedido;
            id = tempnodo.datos.id;
            header = header.next;
            tempnodo = null;
            Console.WriteLine("- Se eliminó pedido al inicio: '" + eliminado + "' (id: " + id + ") \n");
        }

        public void EliminarPedidoLuegoDe(Pedido referencia)
        {
            Nodo tempnodo, actual = new Nodo();
            actual = header;
            while (actual.next.datos.id != referencia.id)
            {
                actual = actual.next;
            }
            tempnodo = actual.next;
            actual.next = actual.next.next;
            tempnodo = null;
            Console.WriteLine("- Se eliminó '" + referencia.namePedido + "' (id: " + referencia.id + ")\n");
        }

        public void EliminarPedidoFinal()
        {
            string eliminado;
            int id;
            Nodo tempnodo, actual = new Nodo();
            actual = header;
            while (actual.next.next != null)
            {
                actual = actual.next;
            }
            tempnodo = actual.next;
            eliminado = tempnodo.datos.namePedido;
            id = tempnodo.datos.id;
            actual.next = null;
            tempnodo = null;
            Console.WriteLine("- Se eliminó pedido del final: '" + eliminado + "' (id: " + id + ") \n");
        }
    }
}
