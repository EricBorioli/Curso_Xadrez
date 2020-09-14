using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Primeiro teste
            /*
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(1, 7));
                tab.colocarPeca(new Rei(tab, Cor.preta), new Posicao(0, 2));



                Tela.imprimirTabulerio(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            */
            #endregion

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadKey();
        }
    }
}
