namespace Jogoda_Velha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.lblJogador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnDeNovo = new System.Windows.Forms.Button();
            this.lblGanhador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(506, 12);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(50, 50);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(562, 12);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(50, 50);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(618, 12);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(50, 50);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(506, 68);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(50, 50);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(562, 68);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(50, 50);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(618, 68);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(50, 50);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(506, 124);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(50, 50);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(562, 124);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(50, 50);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(618, 124);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(50, 50);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(262, 237);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(0, 18);
            this.lblJogador.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jogador da vez:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o número da linha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Digite o número da coluna:";
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(233, 279);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(100, 20);
            this.txtLinha.TabIndex = 13;
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(233, 317);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(100, 20);
            this.txtColuna.TabIndex = 14;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(403, 279);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(93, 56);
            this.btnJogar.TabIndex = 15;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnDeNovo
            // 
            this.btnDeNovo.Location = new System.Drawing.Point(665, 397);
            this.btnDeNovo.Name = "btnDeNovo";
            this.btnDeNovo.Size = new System.Drawing.Size(123, 51);
            this.btnDeNovo.TabIndex = 16;
            this.btnDeNovo.Text = "Jogar novamente";
            this.btnDeNovo.UseVisualStyleBackColor = true;
            this.btnDeNovo.Click += new System.EventHandler(this.btnDeNovo_Click);
            // 
            // lblGanhador
            // 
            this.lblGanhador.AutoSize = true;
            this.lblGanhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanhador.Location = new System.Drawing.Point(198, 385);
            this.lblGanhador.Name = "lblGanhador";
            this.lblGanhador.Size = new System.Drawing.Size(135, 20);
            this.lblGanhador.TabIndex = 17;
            this.lblGanhador.Text = "Quem ganhou foi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGanhador);
            this.Controls.Add(this.btnDeNovo);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtColuna);
            this.Controls.Add(this.txtLinha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnDeNovo;
        private System.Windows.Forms.Label lblGanhador;
    }
}

