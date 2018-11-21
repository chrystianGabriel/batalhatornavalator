using BatalhatorNavalator.Server;
using BatalhatorNavalator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhatorNavalator
{
    class Jogo
    {
        private Jogador jogador { set; get; }
        private Servidor conexao { set; get; }
        public void loop()
        {
            this.criarPartida();
        }

        [STAThread]
        public void criarPartida()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TelaInicial tela = new TelaInicial();
            Application.Run(tela);
            tela.FormClosed += new FormClosedEventHandler((object sender, FormClosedEventArgs e) =>
            {
                this.jogador = new Jogador(tela.Nome, new Tabuleiro(tela.Tamanho));
                this.conexao = tela.Conexao;
                
                
            });
            TelaPosicionarBarcos telaPoicionar = new TelaPosicionarBarcos();
            telaPoicionar.ShowDialog();


        }
      

    }
}
