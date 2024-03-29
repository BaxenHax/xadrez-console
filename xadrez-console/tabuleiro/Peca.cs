﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console.tabuleiro;


namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tab { get; set; }

        public Peca( Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }

        public void IncrementarQteMovimentos ()
        {
            QteMovimentos++;
        }
    }
}
