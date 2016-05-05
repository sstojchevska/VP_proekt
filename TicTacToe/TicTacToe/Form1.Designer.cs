namespace TicTacToe
{
    partial class Form1
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
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(65, 41);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(103, 76);
            this.btn11.TabIndex = 0;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(163, 41);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(103, 76);
            this.btn12.TabIndex = 1;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(263, 41);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(103, 76);
            this.btn13.TabIndex = 2;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn23
            // 
            this.btn23.Location = new System.Drawing.Point(263, 114);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(103, 76);
            this.btn23.TabIndex = 5;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(163, 114);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(103, 76);
            this.btn22.TabIndex = 4;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(65, 114);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(103, 76);
            this.btn21.TabIndex = 3;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn33
            // 
            this.btn33.Location = new System.Drawing.Point(263, 186);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(103, 76);
            this.btn33.TabIndex = 8;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn32
            // 
            this.btn32.Location = new System.Drawing.Point(163, 186);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(103, 76);
            this.btn32.TabIndex = 7;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn31
            // 
            this.btn31.Location = new System.Drawing.Point(65, 186);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(103, 76);
            this.btn31.TabIndex = 6;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.btns_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(148, 324);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(114, 42);
            this.button10.TabIndex = 9;
            this.button10.Text = "PLAY";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Click_Play);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 408);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button button10;
    }
}

