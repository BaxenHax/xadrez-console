using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao Pos)
        {
            ValidarPosicao(Pos);
            return peca(Pos) != null;

        }
        public void ColocarPeca (Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroExcecao("Já existe uma peça aqui!");
            }

                pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
            
            }
        public Peca RetirarPeca( Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }
        
        public bool PosicaoValida (Posicao Pos)
        {
            if (Pos.Linha<0 || Pos.Linha>=Linhas || Pos.Coluna <0 || Pos.Coluna>=Colunas)
            {
                return false;
            }
            return true;
        }
        public bool ValidarPosicao (Posicao Pos)
        {
            if(!PosicaoValida(Pos))
            {
                throw new TabuleiroExcecao("Posição Inválida");
            }
            return true;
        }
    }
}
