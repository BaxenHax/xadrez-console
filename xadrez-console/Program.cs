using System;
using tabuleiro;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;


class program
{
    static void Main(string[] args)
    
    
    {

        try
             {
            PartidadeXadrez Partida = new PartidadeXadrez();

            while (!Partida.Terminada)
            {
                Console.Clear();
                Tela.imprimirTabuleiro(Partida.tab);

                
                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                Partida.ExecutaMovimento(origem, destino);
                     


            }

            


            
            Console.ReadLine();
            }
        catch (TabuleiroExcecao e)
            {       
            Console.WriteLine(e.Message);
        }
        

    }
}
