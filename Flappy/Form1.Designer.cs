namespace Flappy
{
    partial class Flappy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy));
            this.TopPipe = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.BottomPipe = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPipe
            // 
            this.TopPipe.BackColor = System.Drawing.Color.Transparent;
            this.TopPipe.BackgroundImage = global::Flappy.Properties.Resources.pipedown;
            this.TopPipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPipe.Location = new System.Drawing.Point(771, -1);
            this.TopPipe.Name = "TopPipe";
            this.TopPipe.Size = new System.Drawing.Size(114, 171);
            this.TopPipe.TabIndex = 1;
            this.TopPipe.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.BackgroundImage = global::Flappy.Properties.Resources._794718342707281990;
            this.Bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bird.InitialImage = ((System.Drawing.Image)(resources.GetObject("Bird.InitialImage")));
            this.Bird.Location = new System.Drawing.Point(121, 282);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(73, 75);
            this.Bird.TabIndex = 2;
            this.Bird.TabStop = false;
            // 
            // BottomPipe
            // 
            this.BottomPipe.BackColor = System.Drawing.Color.Transparent;
            this.BottomPipe.BackgroundImage = global::Flappy.Properties.Resources.pipe;
            this.BottomPipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomPipe.Location = new System.Drawing.Point(433, 336);
            this.BottomPipe.Name = "BottomPipe";
            this.BottomPipe.Size = new System.Drawing.Size(112, 299);
            this.BottomPipe.TabIndex = 3;
            this.BottomPipe.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackgroundImage = global::Flappy.Properties.Resources.ground;
            this.Ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ground.Location = new System.Drawing.Point(-2, 626);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(948, 67);
            this.Ground.TabIndex = 4;
            this.Ground.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(32, 38);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(94, 30);
            this.ScoreText.TabIndex = 6;
            this.ScoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Flappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 688);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.BottomPipe);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.TopPipe);
            this.Name = "Flappy";
            this.Text = "Flappy";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Flappy_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Flappy_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopPipe;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox BottomPipe;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

