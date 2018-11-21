using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhatorNavalator
{
    public partial class TelaPosicionarBarcos : Form
    {
        private Tabuleiro tabuleiro;
        public TelaPosicionarBarcos()
        {
            InitializeComponent();
            this.tabuleiro = new Tabuleiro(10);
            this.desenharPecas();
            this.DesenharTabuleiro();
            
        }

        public void DesenharTabuleiro()
        {
            int x = 250;
            int y = 50;
            for (int i = 0; i < tabuleiro.Tamanho; i++)
            {
                for (int j = 0; j < tabuleiro.Tamanho; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/celula.png");
                    pictureBox.Location = new Point(x, y);
                    pictureBox.Size = new Size(30, 30);
                    this.Controls.Add(pictureBox);
                    tabuleiro.GetCelula(j * this.tabuleiro.Tamanho + i).X = x;
                    tabuleiro.GetCelula(j * this.tabuleiro.Tamanho + i).X = y;
                    tabuleiro.GetCelula(j * this.tabuleiro.Tamanho + i).Largura = 30;
                    tabuleiro.GetCelula(j * this.tabuleiro.Tamanho + i).Altura = 30;
                    x += 30;
                }
                y += 30;
                x = 250;

            }


        }
        public void desenharPecas()
        {
            List<Peca> pecas = this.tabuleiro.pecas;
            for(int i = 0; i < pecas.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                if (pecas[i].GetType().ToString().IndexOf("Fragata") > -1)
                {
                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/fragata.png");
                    pictureBox.Location = new Point(50, 50);
                    pictureBox.Size = new Size(60, 30);
                    pecas[i].X = 50;
                    pecas[i].Y = 50;
                    pecas[i].Largura = 60;
                    pecas[i].Altura = 30;
                    this.Controls.Add(pictureBox);
                }
                else if (pecas[i].GetType().ToString().IndexOf("Corveta") > -1)
                {
                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/corveta.png");
                    pictureBox.Location = new Point(50, 85);
                    pictureBox.Size = new Size(60, 30);
                    pecas[i].X = 50;
                    pecas[i].Y = 85;
                    pecas[i].Largura = 60;
                    pecas[i].Altura = 30;
                    this.Controls.Add(pictureBox);
                }
                else if (pecas[i].GetType().ToString().IndexOf("Destroier") > -1)
                {
                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/destroier.png");
                    pictureBox.Location = new Point(50, 120);
                    pictureBox.Size = new Size(90, 30);
                    pecas[i].X = 50;
                    pecas[i].Y = 120;
                    pecas[i].Largura = 90;
                    pecas[i].Altura = 30;
                    this.Controls.Add(pictureBox);
                }
                else if (pecas[i].GetType().ToString().IndexOf("Cruzador") > -1)
                {

                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/cruzador.png");
                    pictureBox.Location = new Point(50, 155);
                    pictureBox.Size = new Size(90, 30);
                    pecas[i].X = 50;
                    pecas[i].Y = 155;
                    pecas[i].Largura = 90;
                    pecas[i].Altura = 30;
                    this.Controls.Add(pictureBox);
                }
                else if (pecas[i].GetType().ToString().IndexOf("Submarino") > -1)
                {
                    
                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/submarino.png");
                    pictureBox.Location = new Point(50, 190);
                    pictureBox.Size = new Size(120, 30);
                    pecas[i].X = 50;
                    pecas[i].Y = 190;
                    pecas[i].Largura = 120;
                    pecas[i].Altura = 30;
                    this.Controls.Add(pictureBox);
                }
                else if (pecas[i].GetType().ToString().IndexOf("Encouracado") > -1)
                {
                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/encouracado.png");
                    pictureBox.Location = new Point(50, 225);
                    pictureBox.Size = new Size(120, 30);
                    pecas[i].X = 50;
                    pecas[i].Y = 225;
                    pecas[i].Largura = 120;
                    pecas[i].Altura = 30;
                    this.Controls.Add(pictureBox);
                }
                else if (pecas[i].GetType().ToString().IndexOf("PortaAvioes") > -1)
                {
                    pictureBox.Image = Image.FromFile("C:/Users/chrys/Documents/batalhatornavalator/BatalhatorNavalator/BatalhatorNavalator/Sprites/porta_avioes.png");
                    pictureBox.Location = new Point(50, 260);
                    pictureBox.Size = new Size(120, 30);
                    pecas[i].X = 50;
                    pecas[i].Y = 260;
                    pecas[i].Largura = 120;
                    pecas[i].Altura = 30;
                    this.Controls.Add(pictureBox);
                }

                pictureBox.MouseUp += new MouseEventHandler(this.inserirPeca);
                pictureBox.MouseDoubleClick += new MouseEventHandler(this.girarPeca);
                ControlExtension.Draggable(pictureBox, true);
            }
        }
        public void inserirPeca(object sender, MouseEventArgs e)
        {

            int posX = (((PictureBox)sender).Location.X-250)/30;
            int posY = (((PictureBox)sender).Location.Y-50)/30;
            Celula bloco = this.tabuleiro.GetCelula(posY * this.tabuleiro.Tamanho + posX);
            ((PictureBox)sender).Location = new Point((posX * 30) + 250, ((posY * 30) + 50));
           
        }
        
        public void girarPeca(object sender, MouseEventArgs e)
        {
            Console.WriteLine("pipoca2");
            PictureBox pictureBox = (PictureBox)sender;
            int posX = (pictureBox.Location.X - 250) / 30;
            int posY = (pictureBox.Location.Y - 50) / 30;
            Celula bloco1 = this.tabuleiro.GetCelula(posY * this.tabuleiro.Tamanho + posX);
            Image img = pictureBox.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox.Size = new Size(img.Size.Width, img.Size.Height);
            pictureBox.Image = img;
        }


    }
}
