namespace GamesApp
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
            this.gbAddGame = new System.Windows.Forms.GroupBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.lbPlatform = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btAddGame = new System.Windows.Forms.Button();
            this.libGames = new System.Windows.Forms.ListBox();
            this.gbAddGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddGame
            // 
            this.gbAddGame.Controls.Add(this.btAddGame);
            this.gbAddGame.Controls.Add(this.nudPrice);
            this.gbAddGame.Controls.Add(this.lbPrice);
            this.gbAddGame.Controls.Add(this.lbPlatform);
            this.gbAddGame.Controls.Add(this.tbPlatform);
            this.gbAddGame.Controls.Add(this.tbGenre);
            this.gbAddGame.Controls.Add(this.lbGenre);
            this.gbAddGame.Controls.Add(this.tbTitle);
            this.gbAddGame.Controls.Add(this.lbTitle);
            this.gbAddGame.Location = new System.Drawing.Point(13, 13);
            this.gbAddGame.Name = "gbAddGame";
            this.gbAddGame.Size = new System.Drawing.Size(207, 168);
            this.gbAddGame.TabIndex = 0;
            this.gbAddGame.TabStop = false;
            this.gbAddGame.Text = "Add Game";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(7, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(30, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(61, 17);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(140, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(7, 46);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(39, 13);
            this.lbGenre.TabIndex = 2;
            this.lbGenre.Text = "Genre:";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(61, 43);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(140, 20);
            this.tbGenre.TabIndex = 3;
            // 
            // tbPlatform
            // 
            this.tbPlatform.Location = new System.Drawing.Point(61, 69);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(140, 20);
            this.tbPlatform.TabIndex = 4;
            // 
            // lbPlatform
            // 
            this.lbPlatform.AutoSize = true;
            this.lbPlatform.Location = new System.Drawing.Point(7, 72);
            this.lbPlatform.Name = "lbPlatform";
            this.lbPlatform.Size = new System.Drawing.Size(48, 13);
            this.lbPlatform.TabIndex = 5;
            this.lbPlatform.Text = "Platform:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(7, 97);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price:";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(61, 95);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(140, 20);
            this.nudPrice.TabIndex = 7;
            // 
            // btAddGame
            // 
            this.btAddGame.Location = new System.Drawing.Point(126, 139);
            this.btAddGame.Name = "btAddGame";
            this.btAddGame.Size = new System.Drawing.Size(75, 23);
            this.btAddGame.TabIndex = 8;
            this.btAddGame.Text = "Add Game";
            this.btAddGame.UseVisualStyleBackColor = true;
            this.btAddGame.Click += new System.EventHandler(this.BtAddGame_Click);
            // 
            // libGames
            // 
            this.libGames.FormattingEnabled = true;
            this.libGames.Location = new System.Drawing.Point(227, 13);
            this.libGames.Name = "libGames";
            this.libGames.Size = new System.Drawing.Size(306, 355);
            this.libGames.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 385);
            this.Controls.Add(this.libGames);
            this.Controls.Add(this.gbAddGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAddGame.ResumeLayout(false);
            this.gbAddGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddGame;
        private System.Windows.Forms.Button btAddGame;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPlatform;
        private System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListBox libGames;
    }
}

