using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhatorNavalator
{
    static class Program
    {
     
        static void Main()
        {
            Jogo jogo = new Jogo();
            jogo.loop();

        }
    }
}
