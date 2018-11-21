using BatalhatorNavalator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatalhatorNavalator.Server;
namespace BatalhatorNavalator
{
    public partial class TelaInicial : Form
    {
        public int Tamanho { set; get; }
        public string Nome { set; get; }
        public Servidor Conexao { set; get; }
        public TelaInicial()
        {
            InitializeComponent();
            this.Conexao = new Servidor();
        }


        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            TelaCriarPartida CriarPartida = new TelaCriarPartida();
            CriarPartida.ShowDialog();
            this.Tamanho = CriarPartida.Tamanho;
            this.Nome = CriarPartida.Nome;
            this.Conexao.CriarConexao();
            this.Close();


            
            
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            TelaConectarPartida tela = new TelaConectarPartida();
            tela.ShowDialog();
            this.Nome = tela.Nome;
            this.Conexao.Conectar(tela.IP);
            this.Close();
            
        }
    }
}
