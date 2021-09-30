using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace JogodaVelha
{
    public partial class Form1 : Form
    {


        bool jogada = true;


        private void BT_fechar_Click(object sender, EventArgs e)
        {
            // Ao clicar no botão fechao jogo será fechado
            Application.Exit();
        }

        private void BT_inicio_Click(object sender, EventArgs e)
        {
            // limpa todos os campos

            BT_1.Text = "";
            BT_2.Text = "";
            BT_3.Text = "";
            BT_4.Text = "";
            BT_5.Text = "";
            BT_6.Text = "";
            BT_7.Text = "";
            BT_8.Text = "";
            BT_9.Text = "";

            //Reabilita todos os botões

            BT_1.Enabled = true;
            BT_2.Enabled = true;
            BT_3.Enabled = true;
            BT_4.Enabled = true;
            BT_5.Enabled = true;
            BT_6.Enabled = true;
            BT_7.Enabled = true;
            BT_8.Enabled = true;
            BT_9.Enabled = true;
        }

        //Após leitura do botão limpa o porgrama sera reiniciado
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void BT_1_Click(object sender, EventArgs e)
        {

            Button bt = (Button)sender;

            if (bt.Text == "") // se um campo estiver em branco seu proximo valor sera a sequencia da jogada de X ou O
            {
                // se a jogada for = a X a proxima jogada sera = a 0
                if (jogada)
                {
                    bt.Text = "x";

                    jogada = !jogada;
                }
                else
                {
                    bt.Text = "O";

                    jogada = !jogada;
                }                
                   
            }      
        }
    }
}

