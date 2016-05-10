Проектна задача по Визуелно Програмирање:

Тема: Игра (Tic-Tac-Toe)

Изработена од: Симона Стојчевска 121171 и Кристина Трајковска 123041

#1.	Опис на апликацијата: 

  1.1.	Класична Tic-Tac-Toe (Икс - Точка) игра со технолошка тема.  Направена за двајца играчи има едноставен дизајн и е лесна за користење. 
 
#2.	Правила на играта:

  2.1.	Tic-Tac-Toe сама по себе има многу едноставни правила еден од играчите мора да направи да има три исти симболи (Х или О) во еден ред, една колона или по било која од дијагоналите на матрицата 3х3 во која се игра. 

  2.2. По секоја завршена игра прв почнува оној чиј ред бил следен да стави симбол.
  
#3.	High Scores:

3.1.	За играчите се чува колку пати победиле, колку пати било нерешено и колку вкупно игри се изиграле:
	
3.2. Логиката за High Scores:
					
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
                
  3.3. Логиката за принтање на High Scores:
  
    private void button1_Click(object sender, EventArgs e)
        {
            string x = xwon.ToString();
            string o = owon.ToString();
            string t = tie.ToString();
            string ttl = total.ToString();

            MessageBox.Show("Results: X won - " + x + "; O won - " + o + "; Tie - " + t + "; Total - " + ttl +".");

        

#4.	Логиката позади играта:

 4.1.	Логиката за бодувањето:
 
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

 4.2. Логиката за копчињата:
 
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
			        
			 private void disable_btns() {
			            foreach (Control c in Controls)
			            {
			                Button b = (Button)c;
			                b.Enabled = false;
			                if (b.Text == "PLAY" || b.Text == "HIGHSCORE" || b.Text == "ABOUT") b.Enabled = true;
			            }
			        }
        
#5. За нас копчето:
	
5.1. Ова копче дава информации за то што е оваа апликација и кои студенти ја направиле (односно нашите индекси)
	
				private void button2_Click(object sender, EventArgs e)
			        {
			            MessageBox.Show("TicTacToe VP 2016, made by 121171 & 123041");
			        }

