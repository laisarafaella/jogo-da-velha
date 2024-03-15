using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogoda_Velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variáveis globais
        string[,] velha = new string[3, 3];
        int jogador, nJogos = 0, playerO = 0, playerX = 0, velhas = 0;

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int col, lin;

            //Ler e converte em inteiro
            col = int.Parse(txtColuna.Text);
            lin = int.Parse(txtLinha.Text);

            //Se já está marcada
            if (velha[lin, col] == "X" || velha[lin, col] == "O")
            {
                MessageBox.Show("Você já marcou ai");
            }
            else if (jogador % 2 == 0) //Se o resto for igual a 0, o jogador X começa
            {
                // Coloca o "X" na posição escolhida na matriz
                velha[lin, col] = "X";
                // Limpa a TextBox
                txtColuna.Text = "";
                txtLinha.Text = "";
                // Adiciona +1 para o próximo jogador
                jogador++;

                // Testa em qual botão será marcado.
                if (lin == 0 && col == 0)
                {
                    btn00.Text = "X";
                }
                else if (lin == 0 && col == 1)
                {
                    btn01.Text = "X";
                }
                else if (lin == 0 && col == 2)
                {
                    btn02.Text = "X";
                }
                else if (lin == 1 && col == 0)
                {
                    btn10.Text = "X";
                }
                else if (lin == 1 && col == 1)
                {
                    btn11.Text = "X";
                }
                else if (lin == 1 && col == 2)
                {
                    btn12.Text = "X";
                }
                else if (lin == 2 && col == 0)
                {
                    btn20.Text = "X";
                }
                else if (lin == 2 && col == 1)
                {
                    btn21.Text = "X";
                }
                else if (lin == 2 && col == 2)
                {
                    btn22.Text = "X";
                }

                lblJogador.Text = "O";

                TestaMatriz();
            }
            //Vez do jogador O
            else if (jogador % 2 != 0)
            {
                // Coloca o "O" na posição escolhida na matriz
                velha[lin, col] = "O";
                // Limpa a TextBox
                txtColuna.Text = "";
                txtLinha.Text = "";
                // Adiciona +1 para o próximo jogador
                jogador++;

                // Testa em qual botão será marcado.
                if (lin == 0 && col == 0)
                {
                    btn00.Text = "O";
                }
                else if (lin == 0 && col == 1)
                {
                    btn01.Text = "O";
                }
                else if (lin == 0 && col == 2)
                {
                    btn02.Text = "O";
                }
                else if (lin == 1 && col == 0)
                {
                    btn10.Text = "O";
                }
                else if (lin == 1 && col == 1)
                {
                    btn11.Text = "O";
                }
                else if (lin == 1 && col == 2)
                {
                    btn12.Text = "O";
                }
                else if (lin == 2 && col == 0)
                {
                    btn20.Text = "O";
                }
                else if (lin == 2 && col == 1)
                {
                    btn21.Text = "O";
                }
                else if (lin == 2 && col == 2)
                {
                    btn22.Text = "O";
                }

                // Muda a vez do jogador
                lblJogador.Text = "X";

                TestaMatriz();

            }
        }

        private void btnDeNovo_Click(object sender, EventArgs e)
        {
            LimpaMatriz();
            LimpaBotao();
            jogador = 1;
            Habilita();
        }

        //Acionado quando o formulário do jogo é carregado pela primeira vez e preparando o jogo
        private void Form1_Load(object sender, EventArgs e)
        {
            jogador = 1;
            //Para controlar qual jogador está atualmente fazendo uma jogada
            //Inicializar com 1 significa que o jogador "O" começa o jogo
            lblJogador.Text = "O";
            LimpaMatriz();
            // Redefinir o tabuleiro do jogo
        }

        //Ver quem ganhou
        public void TestaMatriz()
        {
            //Verifica as linhas horizontais, se estão preenchidas
            if (velha[0, 0] != "" && velha[0, 0] == velha[0, 1] && velha[0, 1] == velha[0, 2])
            {
                if (velha[0, 0] == "X")
                {
                    //Se for verdadeira X ganha, atualiza a pontuação e incrementa o nº de jogos
                    MessageBox.Show("X ganhou");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        //Contar pontos até os 9 jogos e repetir
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    //Se for verdadeira O ganha, atualiza a pontuação e incrementa o nº de jogos
                    MessageBox.Show("O ganhou");
                    lblGanhador.Text += " O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        //Contar pontos até os 9 jogos e repetir
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            else if (velha[1, 0] != "" && velha[1, 0] == velha[1, 1] && velha[1, 1] == velha[1, 2])
            {
                if (velha[1, 0] == "X")
                {
                    //Mesmo processo
                    MessageBox.Show("X ganhou");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    //Mesmo processo
                    MessageBox.Show("O ganhou");
                    lblGanhador.Text += " O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            else if (velha[2, 0] != "" && velha[2, 0] == velha[2, 1] && velha[2, 1] == velha[2, 2])
            {
                if (velha[2, 0] == "X")
                {
                    MessageBox.Show("X ganhou");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O ganhou");
                    lblGanhador.Text += " O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            else if (velha[0, 0] != "" && velha[0, 0] == velha[1, 0] && velha[1, 0] == velha[2, 0])
            {
                if (velha[0, 0] == "X")
                {
                    MessageBox.Show("X ganhou");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O ganhou");
                    lblGanhador.Text += " O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            //Verifica as colunas verticais, se estão preenchidas
            else if (velha[0, 1] != "" && velha[0, 1] == velha[1, 1] && velha[1, 1] == velha[2, 1])
            {
                if (velha[0, 1] == "X")
                {
                    MessageBox.Show("X ganhou");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        //Mesmo processo
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O ganhou");
                    lblGanhador.Text += " O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            else if (velha[0, 2] != "" && velha[0, 2] == velha[1, 2] && velha[1, 2] == velha[2, 2])
            {
                if (velha[0, 2] == "X")
                {
                    MessageBox.Show("X ganhou");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O ganhou");
                    lblGanhador.Text += " O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            //Verifica as diagonais, se estão preenchidas
            else if (velha[0, 0] != "" && velha[0, 0] == velha[1, 1] && velha[1, 1] == velha[2, 2])
            {
                if (velha[0, 0] == "X")
                {
                    MessageBox.Show("X ganhou");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O ganhou");
                    lblGanhador.Text += "O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            else if (velha[2, 0] != "" && velha[2, 0] == velha[1, 1] && velha[1, 1] == velha[0, 2])
            {
                if (velha[0, 0] == "X")
                {
                    MessageBox.Show("X ganhou!");
                    lblGanhador.Text += " X ganhou \n";
                    playerX++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O ganhou!");
                    lblGanhador.Text += " O ganhou \n ";
                    playerO++;
                    nJogos++;
                    if (nJogos == 9)
                    {
                        Desabilita();
                        if (velhas > playerO && velhas > playerX)
                        {
                            MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                        }
                        else if (playerO > velhas && playerO > playerX)
                        {
                            MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                        }
                        else if (playerX > velhas && playerX > playerO)
                        {
                            MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                        }
                    }
                }
            }
            //Verifica se estão preenchidas e se teve vencedor ou empate
            else if (velha[0, 0] != "" && velha[0, 1] != "" && velha[0, 2] != "" && velha[1, 0] != "" && velha[1, 1] != "" && velha[1, 2] != "" && velha[2, 0] != "" && velha[2, 1] != "" && velha[2, 2] != "")
            {
                MessageBox.Show("Deu véia!");
                //Atualiza o contador de empates
                velhas++;
                nJogos++;
                if (nJogos == 9)
                {
                    //Se atingir os 9 jogos, desabilita o jogo
                    Desabilita();
                    if (velhas > playerO && velhas > playerX)
                    {
                        MessageBox.Show($"Ninguém ganhou, pois houve {velhas} velhas.");
                    }
                    else if (playerO > velhas && playerO > playerX)
                    {
                        MessageBox.Show($"O jogador O ganhou com {playerO} pontos.");
                    }
                    else if (playerX > velhas && playerX > playerO)
                    {
                        MessageBox.Show($"O jogador X ganhou com {playerX} pontos.");
                    }
                }
            }
        }
        //Limpar a Matriz
        public void LimpaMatriz()
        {
            for (int i = 0; i < velha.GetLength(0); i++)
            {
                for (int j = 0; j < velha.GetLength(1); j++)
                {
                    velha[i, j] = "";
                }
            }
        }
        //Limpar os botões
        public void LimpaBotao()
        {
            btn00.Text = "";
            btn01.Text = "";
            btn02.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
        }
        public void Desabilita()
        {
            //Desabilita as funções
            txtColuna.Enabled = false;
            txtLinha.Enabled = false;
            btn00.Enabled = false;
            btn01.Enabled = false;
            btn02.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn20.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
        }
        public void Habilita()
        {
            //Habilita as funções
            txtColuna.Enabled = true;
            txtLinha.Enabled = true;
            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
        }
    }
}
