using System;
using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(1, 8));
                tab.colocarPeca(new Rei(tab, Cor.preta), new Posicao(0, 2));



                Tela.imprimirTabulerio(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
