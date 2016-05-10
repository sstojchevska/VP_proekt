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
        
        bool isX = true;
        int turns = 0;
        int xwon= 0;
        int owon= 0;
        int tie = 0;
        int total = 0;
        //TODO: Opcija za biranje koj e prv

        public Form1()
        {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = true;
            }
            turns = 0;
            xwon = 0;
            owon = 0;
            tie = 0;
            total = 0;
            InitializeComponent();
        }

        private void Click_Play(object sender, EventArgs e)
        {
            //TODO: ako e igrata vo tek, messagebox pred da pocne nova igra;
            turns = 0;
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                if (b.Text == "PLAY" || b.Text == "HIGHSCORE" || b.Text == "ABOUT") continue;
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
        }

        private void checkWinner()
        {
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
            //tie
            bool winner = false;

            if (gameover)
            {
                if (!isX)
                {
                    MessageBox.Show("X won");
                    xwon++;
                    total++;
                    winner = true;
                }
                else
                {
                    MessageBox.Show("O won");
                    owon++;
                    total++;
                    winner = true;
                }
                disable_btns();
            }
                    if (turns == 9 && winner == false)
                    {
                        MessageBox.Show("It's a tie");
                        tie++;
                        total++;
                        disable_btns();
                    }

                }
                
        private void disable_btns() {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
                if (b.Text == "PLAY" || b.Text == "HIGHSCORE" || b.Text == "ABOUT") b.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = xwon.ToString();
            string o = owon.ToString();
            string t = tie.ToString();
            string ttl = total.ToString();

            MessageBox.Show("Results: X won - " + x + "; O won - " + o + "; Tie - " + t + "; Total - " + ttl +".");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TicTacToe VP 2016, made by 121171 & 123041");
        }



    }
}
