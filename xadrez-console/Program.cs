﻿using System;
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
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));


            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
            }
        catch (TabuleiroExcecao e)
            {       
            Console.WriteLine(e.Message);
        }
        

    }
}
