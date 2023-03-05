namespace FormTop_games
{
    partial class Coinflip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coinflip));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.x = new System.Windows.Forms.Label();
            this.Flip = new System.Windows.Forms.Button();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Bet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowBet = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Money = new System.Windows.Forms.ListBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyCounter = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.CoinT = new System.Windows.Forms.PictureBox();
            this.CoinH = new System.Windows.Forms.PictureBox();
            this.Coins = new System.Windows.Forms.PictureBox();
            this.Tailss = new System.Windows.Forms.Button();
            this.Headss = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Choice = new System.Windows.Forms.TextBox();
            this.Win = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoinT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).BeginInit();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.Color.Transparent;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(413, 271);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(103, 17);
            this.x.TabIndex = 1;
            this.x.Text = "Heads Or Tails";
            this.x.Click += new System.EventHandler(this.label1_Click);
            // 
            // Flip
            // 
            this.Flip.Enabled = false;
            this.Flip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flip.Location = new System.Drawing.Point(416, 344);
            this.Flip.Name = "Flip";
            this.Flip.Size = new System.Drawing.Size(91, 24);
            this.Flip.TabIndex = 2;
            this.Flip.Text = "Flip A Coin";
            this.Flip.UseVisualStyleBackColor = true;
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // PlaceBet
            // 
            this.PlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceBet.Location = new System.Drawing.Point(416, 291);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(91, 24);
            this.PlaceBet.TabIndex = 3;
            this.PlaceBet.Text = "Place A Bet";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.PlaceBet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coinflip";
            // 
            // Bet
            // 
            this.Bet.Location = new System.Drawing.Point(416, 318);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(91, 20);
            this.Bet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bet";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ShowBet
            // 
            this.ShowBet.Enabled = false;
            this.ShowBet.Location = new System.Drawing.Point(532, 235);
            this.ShowBet.Name = "ShowBet";
            this.ShowBet.ReadOnly = true;
            this.ShowBet.Size = new System.Drawing.Size(91, 20);
            this.ShowBet.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-8, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 71);
            this.panel1.TabIndex = 0;
            // 
            // Money
            // 
            this.Money.FormattingEnabled = true;
            this.Money.Location = new System.Drawing.Point(811, 63);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(89, 17);
            this.Money.TabIndex = 34;
            this.Money.Visible = false;
            // 
            // Balance
            // 
            this.Balance.Enabled = false;
            this.Balance.Location = new System.Drawing.Point(811, 37);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(89, 20);
            this.Balance.TabIndex = 33;
            this.Balance.TextChanged += new System.EventHandler(this.Balance_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Balance";
            // 
            // MoneyCounter
            // 
            this.MoneyCounter.Interval = 1;
            this.MoneyCounter.Tick += new System.EventHandler(this.MoneyCounter_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Win);
            this.panel2.Controls.Add(this.Choice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Headss);
            this.panel2.Controls.Add(this.Tailss);
            this.panel2.Controls.Add(this.Coins);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(275, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 296);
            this.panel2.TabIndex = 1;
            // 
            // CoinT
            // 
            this.CoinT.BackColor = System.Drawing.Color.Transparent;
            this.CoinT.Enabled = false;
            this.CoinT.Image = ((System.Drawing.Image)(resources.GetObject("CoinT.Image")));
            this.CoinT.Location = new System.Drawing.Point(779, 331);
            this.CoinT.Name = "CoinT";
            this.CoinT.Size = new System.Drawing.Size(131, 119);
            this.CoinT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinT.TabIndex = 9;
            this.CoinT.TabStop = false;
            this.CoinT.Visible = false;
            // 
            // CoinH
            // 
            this.CoinH.BackColor = System.Drawing.Color.Transparent;
            this.CoinH.Enabled = false;
            this.CoinH.Image = ((System.Drawing.Image)(resources.GetObject("CoinH.Image")));
            this.CoinH.Location = new System.Drawing.Point(779, 206);
            this.CoinH.Name = "CoinH";
            this.CoinH.Size = new System.Drawing.Size(131, 119);
            this.CoinH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinH.TabIndex = 8;
            this.CoinH.TabStop = false;
            this.CoinH.Visible = false;
            // 
            // Coins
            // 
            this.Coins.BackColor = System.Drawing.Color.Transparent;
            this.Coins.Image = ((System.Drawing.Image)(resources.GetObject("Coins.Image")));
            this.Coins.Location = new System.Drawing.Point(120, 68);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(131, 119);
            this.Coins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coins.TabIndex = 0;
            this.Coins.TabStop = false;
            // 
            // Tailss
            // 
            this.Tailss.Enabled = false;
            this.Tailss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tailss.Location = new System.Drawing.Point(238, 210);
            this.Tailss.Name = "Tailss";
            this.Tailss.Size = new System.Drawing.Size(91, 24);
            this.Tailss.TabIndex = 35;
            this.Tailss.Text = "Tails";
            this.Tailss.UseVisualStyleBackColor = true;
            this.Tailss.Click += new System.EventHandler(this.Tailss_Click);
            // 
            // Headss
            // 
            this.Headss.Enabled = false;
            this.Headss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headss.Location = new System.Drawing.Point(44, 210);
            this.Headss.Name = "Headss";
            this.Headss.Size = new System.Drawing.Size(91, 24);
            this.Headss.TabIndex = 36;
            this.Headss.Text = "Heads";
            this.Headss.UseVisualStyleBackColor = true;
            this.Headss.Click += new System.EventHandler(this.Headss_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Choice";
            // 
            // Choice
            // 
            this.Choice.Enabled = false;
            this.Choice.Location = new System.Drawing.Point(23, 154);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(91, 20);
            this.Choice.TabIndex = 37;
            // 
            // Win
            // 
            this.Win.Enabled = false;
            this.Win.Location = new System.Drawing.Point(257, 111);
            this.Win.Name = "Win";
            this.Win.ReadOnly = true;
            this.Win.Size = new System.Drawing.Size(91, 20);
            this.Win.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Win";
            // 
            // Coinflip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(912, 521);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoinT);
            this.Controls.Add(this.CoinH);
            this.Controls.Add(this.ShowBet);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaceBet);
            this.Controls.Add(this.Flip);
            this.Controls.Add(this.x);
            this.Controls.Add(this.panel2);
            this.Name = "Coinflip";
            this.Text = "Coinflip";
            this.Load += new System.EventHandler(this.Coinflip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoinT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Coins;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Button Flip;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Bet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ShowBet;
        private System.Windows.Forms.PictureBox CoinH;
        private System.Windows.Forms.PictureBox CoinT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Money;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MoneyCounter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Headss;
        private System.Windows.Forms.Button Tailss;
        private System.Windows.Forms.TextBox Choice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Win;
    }
}