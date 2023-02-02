using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    //Passando parâmetros para um evento
    internal class EventArgsPedidoPronto: EventArgs
    {
        private int numPedido;
        public int Pedido { get { return numPedido; } }

        public EventArgsPedidoPronto(int numPedido)
        {
            this.numPedido = numPedido;
        }   
    }
}
