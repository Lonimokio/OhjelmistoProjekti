namespace FormTop_games
{
    partial class Slot
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
            this.Spin = new System.Windows.Forms.Button();
            this.Money = new System.Windows.Forms.ListBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bet = new System.Windows.Forms.Button();
            this.Betting = new System.Windows.Forms.NumericUpDown();
            this.Add10 = new System.Windows.Forms.Button();
            this.Add1 = new System.Windows.Forms.Button();
            this.Add50 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.MoneyCounter = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Totalbet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BetR = new System.Windows.Forms.Button();
            this.Sloticon = new System.Windows.Forms.PictureBox();
            this.Slotheart = new System.Windows.Forms.PictureBox();
            this.Slotdiamond = new System.Windows.Forms.PictureBox();
            this.Slotcherry = new System.Windows.Forms.PictureBox();
            this.Slotbar = new System.Windows.Forms.PictureBox();
            this.Slot3 = new System.Windows.Forms.PictureBox();
            this.Slot2 = new System.Windows.Forms.PictureBox();
            this.Slot1 = new System.Windows.Forms.PictureBox();
            this.Help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Winn = new System.Windows.Forms.NumericUpDown();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Betting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Totalbet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotheart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotdiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotcherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winn)).BeginInit();
            this.SuspendLayout();
            // 
            // Spin
            // 
            this.Spin.Enabled = false;
            this.Spin.Location = new System.Drawing.Point(364, 252);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(132, 43);
            this.Spin.TabIndex = 3;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Money
            // 
            this.Money.FormattingEnabled = true;
            this.Money.Location = new System.Drawing.Point(764, 66);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(89, 17);
            this.Money.TabIndex = 96;
            this.Money.Visible = false;
            // 
            // Balance
            // 
            this.Balance.Enabled = false;
            this.Balance.Location = new System.Drawing.Point(764, 40);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(89, 20);
            this.Balance.TabIndex = 95;
            this.Balance.TextChanged += new System.EventHandler(this.Balance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(763, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 94;
            this.label2.Text = "Balance";
            // 
            // Bet
            // 
            this.Bet.Location = new System.Drawing.Point(295, 408);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(132, 43);
            this.Bet.TabIndex = 97;
            this.Bet.Text = "Bet";
            this.Bet.UseVisualStyleBackColor = true;
            this.Bet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // Betting
            // 
            this.Betting.Enabled = false;
            this.Betting.Location = new System.Drawing.Point(364, 333);
            this.Betting.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Betting.Name = "Betting";
            this.Betting.Size = new System.Drawing.Size(132, 20);
            this.Betting.TabIndex = 98;
            // 
            // Add10
            // 
            this.Add10.Location = new System.Drawing.Point(364, 359);
            this.Add10.Name = "Add10";
            this.Add10.Size = new System.Drawing.Size(132, 43);
            this.Add10.TabIndex = 99;
            this.Add10.Text = "Add 10";
            this.Add10.UseVisualStyleBackColor = true;
            this.Add10.Click += new System.EventHandler(this.Add10_Click);
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(226, 359);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(132, 43);
            this.Add1.TabIndex = 100;
            this.Add1.Text = "Add 1";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // Add50
            // 
            this.Add50.Location = new System.Drawing.Point(502, 359);
            this.Add50.Name = "Add50";
            this.Add50.Size = new System.Drawing.Size(132, 43);
            this.Add50.TabIndex = 101;
            this.Add50.Text = "Add 50";
            this.Add50.UseVisualStyleBackColor = true;
            this.Add50.Click += new System.EventHandler(this.Add50_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MoneyCounter
            // 
            this.MoneyCounter.Interval = 1;
            this.MoneyCounter.Tick += new System.EventHandler(this.MoneyCounter_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Totalbet
            // 
            this.Totalbet.Enabled = false;
            this.Totalbet.Location = new System.Drawing.Point(502, 275);
            this.Totalbet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Totalbet.Name = "Totalbet";
            this.Totalbet.Size = new System.Drawing.Size(132, 20);
            this.Totalbet.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Total Bet";
            // 
            // BetR
            // 
            this.BetR.Location = new System.Drawing.Point(433, 408);
            this.BetR.Name = "BetR";
            this.BetR.Size = new System.Drawing.Size(132, 43);
            this.BetR.TabIndex = 109;
            this.BetR.Text = "Reset Bet";
            this.BetR.UseVisualStyleBackColor = true;
            this.BetR.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sloticon
            // 
            this.Sloticon.Image = global::FormTop_games.Properties.Resources.Sloticon;
            this.Sloticon.Location = new System.Drawing.Point(744, 359);
            this.Sloticon.Name = "Sloticon";
            this.Sloticon.Size = new System.Drawing.Size(118, 72);
            this.Sloticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Sloticon.TabIndex = 106;
            this.Sloticon.TabStop = false;
            this.Sloticon.Visible = false;
            // 
            // Slotheart
            // 
            this.Slotheart.Image = global::FormTop_games.Properties.Resources.Slotheart;
            this.Slotheart.Location = new System.Drawing.Point(744, 368);
            this.Slotheart.Name = "Slotheart";
            this.Slotheart.Size = new System.Drawing.Size(118, 72);
            this.Slotheart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Slotheart.TabIndex = 105;
            this.Slotheart.TabStop = false;
            this.Slotheart.Visible = false;
            // 
            // Slotdiamond
            // 
            this.Slotdiamond.Image = global::FormTop_games.Properties.Resources.Slotdiamond;
            this.Slotdiamond.Location = new System.Drawing.Point(744, 377);
            this.Slotdiamond.Name = "Slotdiamond";
            this.Slotdiamond.Size = new System.Drawing.Size(118, 72);
            this.Slotdiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Slotdiamond.TabIndex = 104;
            this.Slotdiamond.TabStop = false;
            this.Slotdiamond.Visible = false;
            // 
            // Slotcherry
            // 
            this.Slotcherry.Image = global::FormTop_games.Properties.Resources.Slotcherry;
            this.Slotcherry.Location = new System.Drawing.Point(744, 388);
            this.Slotcherry.Name = "Slotcherry";
            this.Slotcherry.Size = new System.Drawing.Size(118, 72);
            this.Slotcherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Slotcherry.TabIndex = 103;
            this.Slotcherry.TabStop = false;
            this.Slotcherry.Visible = false;
            // 
            // Slotbar
            // 
            this.Slotbar.Image = global::FormTop_games.Properties.Resources.Slotbar;
            this.Slotbar.Location = new System.Drawing.Point(744, 398);
            this.Slotbar.Name = "Slotbar";
            this.Slotbar.Size = new System.Drawing.Size(118, 72);
            this.Slotbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Slotbar.TabIndex = 102;
            this.Slotbar.TabStop = false;
            this.Slotbar.Visible = false;
            // 
            // Slot3
            // 
            this.Slot3.Image = global::FormTop_games.Properties.Resources.Slotdiamond;
            this.Slot3.Location = new System.Drawing.Point(502, 132);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(132, 114);
            this.Slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Slot3.TabIndex = 2;
            this.Slot3.TabStop = false;
            this.Slot3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Slot2
            // 
            this.Slot2.Image = global::FormTop_games.Properties.Resources.Sloticon;
            this.Slot2.Location = new System.Drawing.Point(364, 132);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(132, 114);
            this.Slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Slot2.TabIndex = 1;
            this.Slot2.TabStop = false;
            this.Slot2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Slot1
            // 
            this.Slot1.Image = global::FormTop_games.Properties.Resources.Slotbar;
            this.Slot1.Location = new System.Drawing.Point(226, 132);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(132, 114);
            this.Slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Slot1.TabIndex = 0;
            this.Slot1.TabStop = false;
            this.Slot1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(12, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(108, 48);
            this.Help.TabIndex = 110;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 112;
            this.label3.Text = "Win";
            // 
            // Winn
            // 
            this.Winn.Enabled = false;
            this.Winn.Location = new System.Drawing.Point(226, 275);
            this.Winn.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Winn.Name = "Winn";
            this.Winn.Size = new System.Drawing.Size(132, 20);
            this.Winn.TabIndex = 111;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 66);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 48);
            this.Back.TabIndex = 113;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Slot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(868, 477);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Winn);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.BetR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Totalbet);
            this.Controls.Add(this.Sloticon);
            this.Controls.Add(this.Slotheart);
            this.Controls.Add(this.Slotdiamond);
            this.Controls.Add(this.Slotcherry);
            this.Controls.Add(this.Slotbar);
            this.Controls.Add(this.Add50);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.Add10);
            this.Controls.Add(this.Betting);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Slot3);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.Slot1);
            this.Name = "Slot";
            this.Text = "Slot";
            this.Load += new System.EventHandler(this.Slot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Betting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Totalbet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotheart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotdiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotcherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slotbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Slot1;
        private System.Windows.Forms.PictureBox Slot2;
        private System.Windows.Forms.PictureBox Slot3;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.ListBox Money;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bet;
        private System.Windows.Forms.NumericUpDown Betting;
        private System.Windows.Forms.Button Add10;
        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.Button Add50;
        private System.Windows.Forms.PictureBox Slotbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer MoneyCounter;
        private System.Windows.Forms.PictureBox Slotcherry;
        private System.Windows.Forms.PictureBox Slotdiamond;
        private System.Windows.Forms.PictureBox Slotheart;
        private System.Windows.Forms.PictureBox Sloticon;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.NumericUpDown Totalbet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BetR;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Winn;
        private System.Windows.Forms.Button Back;
    }
}