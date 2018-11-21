using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator
{
    public class Jogador
    {
        public String Nome { set; get; }
        public Tabuleiro tabueiro { set; get; }

        public Jogador(string Nome, Tabuleiro tabuleiro)
        {
            this.Nome = Nome;
            this.tabueiro = tabueiro;
        }
    }
}
