using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cozinha cozinhaHamburguer = new Cozinha();
            Cozinha cozinhaJaponesa = new Cozinha();

            TabletGarcom TabletJoao = new TabletGarcom("João", cozinhaHamburguer);
            TabletGarcom TabletPedro = new TabletGarcom("Pedro", cozinhaHamburguer);
            TabletGarcom TabletMaria = new TabletGarcom("Maria", cozinhaHamburguer);

            TabletGarcom TabletJoana = new TabletGarcom("Joana", cozinhaJaponesa);
            TabletGarcom TabletAline = new TabletGarcom("Aline", cozinhaJaponesa);
            TabletGarcom TabletMarcos = new TabletGarcom("Marcos", cozinhaJaponesa);
            //Chamando evento para um pedido pronto
            cozinhaHamburguer.EnviaMenssagemPedidoPronto(25);
            cozinhaJaponesa.EnviaMenssagemPedidoPronto(83);
        }
    }
}
