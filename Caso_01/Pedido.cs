using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    class Pedido
    {
        public int id;
        public string namePedido;
        public string direccion;

        public Pedido(int id, string namePedido, string direccion)
        {
            this.id = id;
            this.namePedido = namePedido;
            this.direccion = direccion;
        }
    }
}
