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
            this.Coins = new System.Windows.Forms.PictureBox();
            this.CoinH = new System.Windows.Forms.PictureBox();
            this.CoinT = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Money = new System.Windows.Forms.ListBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyCounter = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Bet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinT)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(561, 215);
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
            // Coins
            // 
            this.Coins.BackColor = System.Drawing.Color.Transparent;
            this.Coins.Image = ((System.Drawing.Image)(resources.GetObject("Coins.Image")));
            this.Coins.Location = new System.Drawing.Point(395, 149);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(131, 119);
            this.Coins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coins.TabIndex = 0;
            this.Coins.TabStop = false;
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
            // CoinT
            // 
            this.CoinT.BackColor = System.Drawing.Color.Transparent;
            this.CoinT.Enabled = false;
            this.CoinT.Image = ((System.Drawing.Image)(resources.GetObject("CoinT.Image")));
            this.CoinT.Location = new System.Drawing.Point(779, 326);
            this.CoinT.Name = "CoinT";
            this.CoinT.Size = new System.Drawing.Size(131, 119);
            this.CoinT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinT.TabIndex = 9;
            this.CoinT.TabStop = false;
            this.CoinT.Visible = false;
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
            this.panel2.Location = new System.Drawing.Point(275, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 296);
            this.panel2.TabIndex = 1;
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaceBet);
            this.Controls.Add(this.Flip);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Coins);
            this.Controls.Add(this.panel2);
            this.Name = "Coinflip";
            this.Text = "Coinflip";
            this.Load += new System.EventHandler(this.Coinflip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinT)).EndInit();
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
    }
}