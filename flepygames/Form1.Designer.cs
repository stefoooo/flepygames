namespace flepygames
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
            this.black1 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.black2 = new System.Windows.Forms.PictureBox();
            this.txtscore = new System.Windows.Forms.Label();
            this.timerGames = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.black1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black2)).BeginInit();
            this.SuspendLayout();
            // 
            // black1
            // 
            this.black1.Image = global::flepygames.Properties.Resources.black;
            this.black1.Location = new System.Drawing.Point(2, 417);
            this.black1.Name = "black1";
            this.black1.Size = new System.Drawing.Size(357, 50);
            this.black1.TabIndex = 4;
            this.black1.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.Image = global::flepygames.Properties.Resources.red;
            this.pipe2.Location = new System.Drawing.Point(306, 319);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(37, 205);
            this.pipe2.TabIndex = 2;
            this.pipe2.TabStop = false;
            this.pipe2.Click += new System.EventHandler(this.pipe2_Click);
            // 
            // player
            // 
            this.player.Image = global::flepygames.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(41, 194);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(63, 45);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // pipe1
            // 
            this.pipe1.Image = global::flepygames.Properties.Resources.red;
            this.pipe1.Location = new System.Drawing.Point(261, 41);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(27, 162);
            this.pipe1.TabIndex = 0;
            this.pipe1.TabStop = false;
            // 
            // black2
            // 
            this.black2.Image = global::flepygames.Properties.Resources.black;
            this.black2.Location = new System.Drawing.Point(2, 0);
            this.black2.Name = "black2";
            this.black2.Size = new System.Drawing.Size(357, 50);
            this.black2.TabIndex = 5;
            this.black2.TabStop = false;
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(12, 64);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(92, 25);
            this.txtscore.TabIndex = 6;
            this.txtscore.Text = "Score: 0";
            // 
            // timerGames
            // 
            this.timerGames.Enabled = true;
            this.timerGames.Tick += new System.EventHandler(this.timeGamesEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 463);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.black2);
            this.Controls.Add(this.black1);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pipe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.black1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.PictureBox black1;
        private System.Windows.Forms.PictureBox black2;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Timer timerGames;
    }
}

