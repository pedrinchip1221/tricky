using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn1.Text.Equals(""))
                {
                    btn1.Text="X";
                }
                else
                {
                    btn1.Text="O";
                }
            }
            evaluar();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn2.Text.Equals(""))
                {
                    btn2.Text = "X";
                }
                else
                {
                    btn2.Text = "O";
                }
            }
            evaluar();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn3.Text.Equals(""))
                {
                    btn3.Text = "X";
                }
                else
                {
                    btn3.Text = "O";
                }
            }
            evaluar();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn4.Text.Equals(""))
                {
                    btn4.Text = "X";
                }
                else
                {
                    btn4.Text = "O";
                }
            }
            evaluar();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn5.Text.Equals(""))
                {
                    btn5.Text = "X";
                }
                else
                {
                    btn5.Text = "O";
                }
            }
            evaluar();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn6.Text.Equals(""))
                {
                    btn6.Text = "X";
                }
                else
                {
                    btn6.Text = "O";
                }
            }
            evaluar();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn7.Text.Equals(""))
                {
                    btn7.Text = "X";
                }
                else
                {
                    btn7.Text = "O";
                }
            }
            evaluar();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn8.Text.Equals(""))
                {
                    btn8.Text = "X";
                }
                else
                {
                    btn8.Text = "O";
                }
            }
            evaluar();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text.Equals(""))
            {
                cont++;
                if (cont % 2 == 0 && btn9.Text.Equals(""))
                {
                    btn9.Text = "X";
                }
                else
                {
                    btn9.Text = "O";
                }
            }
            evaluar();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void btnmostrarX_Click(object sender, EventArgs e)
        {
            btnmostrarX.Enabled = false;
        }

        private void btnmostrarO_Click(object sender, EventArgs e)
        {
            btnmostrarO.Enabled = false;
        }
        int cont = 0, ganador = 0, ganadorX = 0, ganadorO = 0, conX = 0, conO = 0;
        private void evaluar()
        {
            if (btn1.Text.Equals("X") && btn2.Text.Equals("X") && btn3.Text.Equals("X") ||
                    btn4.Text.Equals("X") && btn5.Text.Equals("X") && btn6.Text.Equals("X") ||
                    btn7.Text.Equals("X") && btn8.Text.Equals("X") && btn9.Text.Equals("X") ||
                    btn1.Text.Equals("X") && btn4.Text.Equals("X") && btn7.Text.Equals("X") ||
                    btn2.Text.Equals("X") && btn5.Text.Equals("X") && btn8.Text.Equals("X") ||
                    btn3.Text.Equals("X") && btn6.Text.Equals("X") && btn9.Text.Equals("X") ||
                    btn1.Text.Equals("X") && btn5.Text.Equals("X") && btn9.Text.Equals("X") ||
                    btn3.Text.Equals("X") && btn5.Text.Equals("X") && btn7.Text.Equals("X")
                    )
            {
                MessageBox.Show("el ganador es el jugador con las X");
                ganador = 1;
                ganadorX = 1;
                contador();
                terminarjuego();

            }
            if (btn1.Text.Equals("O") && btn2.Text.Equals("O") && btn3.Text.Equals("O") ||
                    btn4.Text.Equals("O") && btn5.Text.Equals("O") && btn6.Text.Equals("O") ||
                    btn7.Text.Equals("O") && btn8.Text.Equals("O") && btn9.Text.Equals("O") ||
                    btn1.Text.Equals("O") && btn4.Text.Equals("O") && btn7.Text.Equals("O") ||
                    btn2.Text.Equals("O") && btn5.Text.Equals("O") && btn8.Text.Equals("O") ||
                    btn3.Text.Equals("O") && btn6.Text.Equals("O") && btn9.Text.Equals("O") ||
                    btn1.Text.Equals("O") && btn5.Text.Equals("O") && btn9.Text.Equals("O") ||
                    btn3.Text.Equals("O") && btn5.Text.Equals("O") && btn7.Text.Equals("O")
                    )
            {
                MessageBox.Show("el ganador es el jugador con las O");
                ganador = 1;
                ganadorO = 1;
                contador();
                terminarjuego();
            }
            else if (cont == 9 && ganador == 0)
            {
                MessageBox.Show(this, "es empate");
                contador();
                terminarjuego();
            }
        }
        private void terminarjuego()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            cont = 0;
        }
        private void reiniciar()
        {
            cont = 0;
            btn1.Enabled = true;
            btn1.Text = "";
            btn2.Enabled = true;
            btn2.Text = "";
            btn3.Enabled = true;
            btn3.Text = "";
            btn4.Enabled = true;
            btn4.Text = "";
            btn5.Enabled = true;
            btn5.Text = "";
            btn6.Enabled = true;
            btn6.Text = "";
            btn7.Enabled = true;
            btn7.Text = "";
            btn8.Enabled = true;
            btn8.Text = "";
            btn9.Enabled = true;
            btn9.Text = "";
        }
        private void contador()
        {
            if (ganadorX == 1)
            {
                conX = conX + 1;
            }
            else if (ganadorO == 1)
            {
                conO = conO + 1;
            }
            btnmostrarX.Text = " " + conX;
            btnmostrarO.Text = " " + conO;
        }







    }
}
