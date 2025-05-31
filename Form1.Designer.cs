namespace happy_bird_game
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipe_bottom = new System.Windows.Forms.PictureBox();
            this.pipe_top = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.game_time = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.exlife = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exlife)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::happy_bird_game.Properties.Resources.background2;
            this.ground.Location = new System.Drawing.Point(3, 358);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(499, 80);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipe_bottom
            // 
            this.pipe_bottom.Image = global::happy_bird_game.Properties.Resources.flappy_up;
            this.pipe_bottom.Location = new System.Drawing.Point(161, 269);
            this.pipe_bottom.Name = "pipe_bottom";
            this.pipe_bottom.Size = new System.Drawing.Size(70, 154);
            this.pipe_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_bottom.TabIndex = 2;
            this.pipe_bottom.TabStop = false;
            // 
            // pipe_top
            // 
            this.pipe_top.Image = global::happy_bird_game.Properties.Resources.flappy_down;
            this.pipe_top.Location = new System.Drawing.Point(420, -1);
            this.pipe_top.Name = "pipe_top";
            this.pipe_top.Size = new System.Drawing.Size(70, 151);
            this.pipe_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_top.TabIndex = 1;
            this.pipe_top.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::happy_bird_game.Properties.Resources.bird2;
            this.bird.Location = new System.Drawing.Point(16, 12);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(42, 40);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.life3);
            this.panel1.Controls.Add(this.life2);
            this.panel1.Controls.Add(this.life1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(13, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 44);
            this.panel1.TabIndex = 4;
            // 
            // life3
            // 
            this.life3.Image = global::happy_bird_game.Properties.Resources.heart;
            this.life3.Location = new System.Drawing.Point(83, 3);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(34, 38);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 1;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = global::happy_bird_game.Properties.Resources.heart;
            this.life2.Location = new System.Drawing.Point(43, 3);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(34, 38);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 1;
            this.life2.TabStop = false;
            // 
            // life1
            // 
            this.life1.Image = global::happy_bird_game.Properties.Resources.heart;
            this.life1.Location = new System.Drawing.Point(3, 3);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(34, 38);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 1;
            this.life1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 50);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // score_lbl
            // 
            this.score_lbl.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(304, 385);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(186, 38);
            this.score_lbl.TabIndex = 5;
            this.score_lbl.Text = "Score :";
            this.score_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // game_time
            // 
            this.game_time.Enabled = true;
            this.game_time.Interval = 20;
            this.game_time.Tick += new System.EventHandler(this.gameTimeTickEvent);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(92, 127);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(322, 95);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "label1";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverLabel.Visible = false;
            this.gameOverLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // exlife
            // 
            this.exlife.Image = global::happy_bird_game.Properties.Resources.heart;
            this.exlife.Location = new System.Drawing.Point(363, 86);
            this.exlife.Name = "exlife";
            this.exlife.Size = new System.Drawing.Size(34, 38);
            this.exlife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exlife.TabIndex = 1;
            this.exlife.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(503, 438);
            this.Controls.Add(this.exlife);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe_bottom);
            this.Controls.Add(this.pipe_top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exlife)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipe_top;
        private System.Windows.Forms.PictureBox pipe_bottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Timer game_time;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.PictureBox exlife;
    }
}

