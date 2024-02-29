using System;
using tabuleiro;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;


class program
{
    static void Main(string[] args)
    
    
    {

        PosicaoXadrez pos = new PosicaoXadrez('C', 7);
        Console.WriteLine(pos);
        Console.WriteLine(pos.ToPosicao());
        Console.ReadLine();


    }
}
