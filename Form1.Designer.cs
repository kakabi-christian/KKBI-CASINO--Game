namespace JEUX2
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Ibl_casiino = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Ibl_balance = new System.Windows.Forms.Label();
            this.Ibl_win = new System.Windows.Forms.Label();
            this.Ibl_loss = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_bit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Ibl_casiino
            // 
            this.Ibl_casiino.AutoSize = true;
            this.Ibl_casiino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibl_casiino.ForeColor = System.Drawing.Color.Yellow;
            this.Ibl_casiino.Location = new System.Drawing.Point(12, 23);
            this.Ibl_casiino.Name = "Ibl_casiino";
            this.Ibl_casiino.Size = new System.Drawing.Size(110, 32);
            this.Ibl_casiino.TabIndex = 1;
            this.Ibl_casiino.Text = "Casino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JEUX2.Properties.Resources.dollar;
            this.pictureBox1.Location = new System.Drawing.Point(35, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JEUX2.Properties.Resources.dollar;
            this.pictureBox2.Location = new System.Drawing.Point(164, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JEUX2.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(294, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ibl_balance
            // 
            this.Ibl_balance.AutoSize = true;
            this.Ibl_balance.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibl_balance.ForeColor = System.Drawing.Color.Gray;
            this.Ibl_balance.Location = new System.Drawing.Point(13, 74);
            this.Ibl_balance.Name = "Ibl_balance";
            this.Ibl_balance.Size = new System.Drawing.Size(149, 33);
            this.Ibl_balance.TabIndex = 2;
            this.Ibl_balance.Text = "Balance :$";
            // 
            // Ibl_win
            // 
            this.Ibl_win.AutoSize = true;
            this.Ibl_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibl_win.ForeColor = System.Drawing.Color.ForestGreen;
            this.Ibl_win.Location = new System.Drawing.Point(12, 291);
            this.Ibl_win.Name = "Ibl_win";
            this.Ibl_win.Size = new System.Drawing.Size(105, 29);
            this.Ibl_win.TabIndex = 3;
            this.Ibl_win.Text = "Wins : 0";
            // 
            // Ibl_loss
            // 
            this.Ibl_loss.AutoSize = true;
            this.Ibl_loss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibl_loss.ForeColor = System.Drawing.Color.Tomato;
            this.Ibl_loss.Location = new System.Drawing.Point(14, 349);
            this.Ibl_loss.Name = "Ibl_loss";
            this.Ibl_loss.Size = new System.Drawing.Size(103, 29);
            this.Ibl_loss.TabIndex = 4;
            this.Ibl_loss.Text = "Loss : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(244, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bit -Amounts";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(265, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 6;
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(12, 406);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(190, 60);
            this.btn_play.TabIndex = 7;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_bit
            // 
            this.btn_bit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bit.ForeColor = System.Drawing.Color.White;
            this.btn_bit.Location = new System.Drawing.Point(237, 406);
            this.btn_bit.Name = "btn_bit";
            this.btn_bit.Size = new System.Drawing.Size(190, 60);
            this.btn_bit.TabIndex = 8;
            this.btn_bit.Text = "New Bid";
            this.btn_bit.UseVisualStyleBackColor = true;
            this.btn_bit.Click += new System.EventHandler(this.btn_bit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.btn_bit);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ibl_loss);
            this.Controls.Add(this.Ibl_win);
            this.Controls.Add(this.Ibl_balance);
            this.Controls.Add(this.Ibl_casiino);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casino Game in C# by kakabi christian";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Ibl_casiino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Ibl_balance;
        private System.Windows.Forms.Label Ibl_win;
        private System.Windows.Forms.Label Ibl_loss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_bit;
        private System.Windows.Forms.Timer timer1;
    }
}

