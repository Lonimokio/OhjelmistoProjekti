namespace FormTop_games
{
    partial class SignIn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SName = new System.Windows.Forms.TextBox();
            this.SPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPassword = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-25, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(38, 31);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(185, 167);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // SName
            // 
            this.SName.Location = new System.Drawing.Point(37, 73);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(119, 26);
            this.SName.TabIndex = 0;
            this.SName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SPassword
            // 
            this.SPassword.Location = new System.Drawing.Point(37, 125);
            this.SPassword.Name = "SPassword";
            this.SPassword.Size = new System.Drawing.Size(119, 26);
            this.SPassword.TabIndex = 1;
            this.SPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(37, 157);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(119, 46);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CPassword);
            this.groupBox1.Controls.Add(this.CName);
            this.groupBox1.Controls.Add(this.CAccount);
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SPassword);
            this.groupBox1.Controls.Add(this.SName);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(320, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign in";
            // 
            // CAccount
            // 
            this.CAccount.Location = new System.Drawing.Point(195, 157);
            this.CAccount.Name = "CAccount";
            this.CAccount.Size = new System.Drawing.Size(129, 46);
            this.CAccount.TabIndex = 5;
            this.CAccount.Text = "Create account";
            this.CAccount.UseVisualStyleBackColor = true;
            this.CAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // CPassword
            // 
            this.CPassword.Location = new System.Drawing.Point(195, 125);
            this.CPassword.Name = "CPassword";
            this.CPassword.Size = new System.Drawing.Size(129, 26);
            this.CPassword.TabIndex = 7;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(195, 73);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(129, 26);
            this.CName.TabIndex = 6;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignIn";
            this.Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.TextBox SPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CPassword;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Button CAccount;
    }
}

