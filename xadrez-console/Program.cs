using System;
using tabuleiro;
using xadrez_console;
using xadrez_console.tabuleiro;


class program
{
    static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8);
        Tela.imprimirTabuleiro(tab);
        Console.ReadLine();
    }
}
