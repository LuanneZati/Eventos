using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
	class Cozinha
	{
		public delegate void DelegatePedidoPronto(object fonte, EventArgsPedidoPronto e); //delegate padrão
		public event DelegatePedidoPronto MenssagemPedidoProntoEvent; //evento do tipo do delegate
		public void EnviaMenssagemPedidoPronto(int NumPedido) //método que dispara o evento
		{
			if(MenssagemPedidoProntoEvent != null)
			{
				//Padrão
                EventArgsPedidoPronto e = new EventArgsPedidoPronto(NumPedido); //cria um objeto evento
				MenssagemPedidoProntoEvent(this, e); //passa o objeto do evento para o evento
			}
		}

    }
}