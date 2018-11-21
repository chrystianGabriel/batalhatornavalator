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

    public partial class TelaDeAguardo : Form
    {
        public TelaDeAguardo(string IP, string Nome)
        {
            InitializeComponent();
            lblBemVindo.Text += Nome;
            lblIP.Text += IP;
        }


    }
}
