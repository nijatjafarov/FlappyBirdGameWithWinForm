
namespace FlappyBirdForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ground = new System.Windows.Forms.PictureBox();
            this.UpPipe = new System.Windows.Forms.PictureBox();
            this.DownPipe = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdForm.Properties.Resources.FlappyBirdGround;
            this.ground.Location = new System.Drawing.Point(-8, 612);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1023, 160);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // UpPipe
            // 
            this.UpPipe.Image = global::FlappyBirdForm.Properties.Resources.FlappyBirdPipeUp;
            this.UpPipe.Location = new System.Drawing.Point(665, -130);
            this.UpPipe.Name = "UpPipe";
            this.UpPipe.Size = new System.Drawing.Size(111, 473);
            this.UpPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpPipe.TabIndex = 0;
            this.UpPipe.TabStop = false;
            // 
            // DownPipe
            // 
            this.DownPipe.Image = global::FlappyBirdForm.Properties.Resources.FlappyBirdPipe;
            this.DownPipe.Location = new System.Drawing.Point(665, 474);
            this.DownPipe.Name = "DownPipe";
            this.DownPipe.Size = new System.Drawing.Size(111, 473);
            this.DownPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPipe.TabIndex = 0;
            this.DownPipe.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBirdForm.Properties.Resources.PngItem_509222;
            this.bird.Location = new System.Drawing.Point(119, 281);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(77, 62);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.MovePipes);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.score.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(39, 29);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(54, 60);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1009, 725);
            this.Controls.Add(this.score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.DownPipe);
            this.Controls.Add(this.UpPipe);
            this.Controls.Add(this.bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Flappy Bird Game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox UpPipe;
        private System.Windows.Forms.PictureBox DownPipe;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
    }
}

