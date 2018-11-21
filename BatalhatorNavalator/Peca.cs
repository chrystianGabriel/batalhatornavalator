using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator
{
    public class Peca : Objeto
    {
        public char Orientacao { set; get; }
        public int Tamanho { set; get; }

        public Peca()
        {
            this.Orientacao = 'H'; //H = horizontal, V = Vertical, D = Diagonal
        }

        
        public List<Tuple<int,int>> GetPos()
        {
            List<Tuple<int,int>> lista = new List<Tuple<int, int>>();
            if (this.Orientacao == 'H')
            {
               
                int x = this.X;
                int y = this.Y;
                lista.Add(new Tuple<int, int>(x, y));
                for (int i = 0; i < this.Tamanho-1; i++)
                {
                    x += this.Largura / this.Tamanho;
                    lista.Add(new Tuple<int, int>(x, y));
                }

                return lista;
              


            }

            return lista;
        }
        
    }
}
