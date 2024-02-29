using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console;
using xadrez_console.tabuleiro;


namespace xadrez_console.xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez (char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public Posicao ToPosicao()
        {
            return new Posicao (8 -  Linha,  Coluna - 'A');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
