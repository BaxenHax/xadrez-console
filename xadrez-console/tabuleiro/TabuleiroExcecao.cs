using System;

namespace xadrez_console.tabuleiro
{
    internal class TabuleiroExcecao : Exception
    {
        public TabuleiroExcecao(string msg) : base(msg) 
        {
            
        }
    }
}