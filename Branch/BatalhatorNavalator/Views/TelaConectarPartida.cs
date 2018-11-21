using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhatorNavalator.Views
{
    public partial class TelaConectarPartida : Form
    {
        public string Nome { set; get; }
        public string IP { set; get; }
        public TelaConectarPartida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Nome = txtInput.Text;
            this.IP = txtIP.Text;
            this.Close();
        }
    }
}
