using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class TabletGarcom
    {
        private string nome;
        public void MostraMensagemPedidoProntoCozinha(object fonte, EventArgsPedidoPronto e) //método para printar mensagem
        {
            Console.WriteLine("O pedido " + e.Pedido + " está pronto na cozinha, " + nome);
        }
        public TabletGarcom(string nome, Cozinha cozinha) //Construtor para que assim que a classe TabletGarcom for acionada, ja chamar o evento
        {
            this.nome = nome;
            cozinha.MenssagemPedidoProntoEvent += MostraMensagemPedidoProntoCozinha; //Printa a mensagem no tableto do garçom
        }
    }
}
