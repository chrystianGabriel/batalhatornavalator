namespace BatalhatorNavalator.Views
{
    partial class TelaDeAguardo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(102, 38);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(171, 31);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem Vindo, ";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(102, 121);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(132, 31);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "Seu IP é: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aguardando outro jogador se conectar a partida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 246);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaDeAguardo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "TelaDeAguardo";
            this.Text = "TelaDeAguardo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}