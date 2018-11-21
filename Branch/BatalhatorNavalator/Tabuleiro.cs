using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator
{
    public class Tabuleiro
    {
        public int Tamanho
        {
            set;get;
           
           
        }
        public Jogador jogador { set; get; }
        public List<Celula> celulas { set; get; }
        public List<Peca> pecas { set; get; }
    
        public Tabuleiro(int tamanho)
        {
            this.Tamanho = tamanho;
            this.celulas = new List<Celula>();
            this.pecas = new List<Peca>();
            for(int i = 0; i < this.Tamanho * this.Tamanho; i++) this.InserirCelula(new Celula());
            this.InserirPeca(new Fragata());
            this.InserirPeca(new Fragata());
            this.InserirPeca(new Corveta());
            this.InserirPeca(new Corveta());
            this.InserirPeca(new Destroier());
            this.InserirPeca(new Destroier());
            this.InserirPeca(new Destroier());
            this.InserirPeca(new Cruzador());
            this.InserirPeca(new Cruzador());
            this.InserirPeca(new Cruzador());
            this.InserirPeca(new Submarino());
            this.InserirPeca(new Submarino());
            this.InserirPeca(new Submarino());
            this.InserirPeca(new Submarino());
            this.InserirPeca(new Encouracado());
            this.InserirPeca(new Encouracado());
            this.InserirPeca(new Encouracado());
            this.InserirPeca(new Encouracado());
            this.InserirPeca(new PortaAvioes());
            this.InserirPeca(new PortaAvioes());
            this.InserirPeca(new PortaAvioes());
            this.InserirPeca(new PortaAvioes());
        }

        public void InserirCelula(Celula celula)
        {
            this.celulas.Add(celula);
        }

        public void InserirPeca(Peca peca)
        {
            this.pecas.Add(peca);
        }

        public Celula GetCelula(int pos)
        {
            return this.celulas[pos];
        }

        public Peca GetPeca(int x, int y)
        {
            foreach(Peca peca in this.pecas)
            {
                if(x == peca.X && y == peca.Y)
                {
                    return peca;
                }
            }
            return null;

        }

      


       
    }
}
