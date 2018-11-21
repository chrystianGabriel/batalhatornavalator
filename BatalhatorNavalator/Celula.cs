using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator
{
    public class Celula : Objeto
    {
        public bool Ocupado {set; get;}
        public bool colidiu(Objeto outro)
        {

            return ((this.X + this.Largura) > outro.X) &&
                   (this.X < (outro.X + outro.Largura)) &&
                   ((this.Y + this.Altura) > outro.Y) &&
                   (this.Y < (outro.Y + outro.Altura));
        }
    }
}
