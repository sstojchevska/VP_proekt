using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    //TODO: Dizajn vo Unity (ili samo slikichki mesto X/O) ???
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button[] btnArray = new Button[9];
        static private int [,] Win = new int[,]
           {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
           };
        bool isX = true;
        int turns = 0;
        //TODO: Opcija za biranje koj e prv

        public Form1()
        {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = true;
            }
            turns = 0;
            InitializeComponent();
            btnArray = new Button[9] { btn11, btn12, btn13, btn21, btn22, btn23, btn31, btn32, btn33 };
            //TODO: koj prv -> if(X == prv) isX = true; else (y prv) isX= false;
            //TODO: Highscore table, chiv e sleden poteg
        }

        private void Click_Play(object sender, EventArgs e)
        {
            //TODO: ako e igrata vo tek, messagebox pred da pocne nova igra;
            turns = 0;
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                if (b.Text == "PLAY") continue;
                b.Text = "";
                b.Enabled = true;
            }
            
        }

        private void btns_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            if (isX) b.Text = "X";
            else b.Text = "O";
            isX = !isX;
            b.Enabled = false;
            turns++;
            checkWinner();

            /*for (int i = 0; i < 9; i++)
                this.btnArray[i].Click += new System.EventHandler(this.ClickHandler); */
        }

        private void checkWinner() {
            bool gameover = false;
            //horisontal
            if ((btn11.Text == btn12.Text) && (btn12.Text == btn13.Text) && (!btn11.Enabled)) gameover = true;
            if ((btn21.Text == btn22.Text) && (btn22.Text == btn23.Text) && (!btn21.Enabled)) gameover = true;
            if ((btn31.Text == btn32.Text) && (btn32.Text == btn33.Text) && (!btn31.Enabled)) gameover = true;
            //vertical
            if ((btn11.Text == btn21.Text) && (btn21.Text == btn31.Text) && (!btn11.Enabled)) gameover = true;
            if ((btn12.Text == btn22.Text) && (btn22.Text == btn32.Text) && (!btn12.Enabled)) gameover = true;
            if ((btn13.Text == btn23.Text) && (btn23.Text == btn33.Text) && (!btn13.Enabled)) gameover = true;
            //diagonal
            if ((btn11.Text == btn22.Text) && (btn22.Text == btn33.Text) && (!btn11.Enabled)) gameover = true;
            if ((btn13.Text == btn22.Text) && (btn22.Text == btn31.Text) && (!btn13.Enabled)) gameover = true;

            if (gameover)
            {
                MessageBox.Show("Is of winings");
                //TODO: Think of new deathwish
                disable_btns();
                //TODO: Panela so pobednik
            }
            else {
                if (turns == 9)
                    MessageBox.Show("Of much neresheno such wow");
            }
        }

        private void disable_btns() {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
                if (b.Text == "PLAY") b.Enabled = true ;
            }
        }



    }
}
