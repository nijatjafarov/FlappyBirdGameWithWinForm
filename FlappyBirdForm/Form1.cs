using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdForm
{
    public partial class Form1 : Form
    {
        int gravity = 5;
        int birdUpSpeed = 50;

        int pipeSpeed = 5;

        int passedPipe = 0;

        private List<PictureBox> upPipes = new List<PictureBox>();
        private List<PictureBox> downPipes = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            upPipes.Add(UpPipe);
            downPipes.Add(DownPipe);
        }


        private void MovePipes(object sender, EventArgs e)
        {
            PictureBox lastUpPipe = upPipes[upPipes.Count - 1];
            PictureBox lastDownPipe = downPipes[downPipes.Count - 1];

            if (lastUpPipe.Left < 550)
            {
                Random rand = new Random();
                PictureBox newUpPipe = new PictureBox()
                {
                    Left = 1020,
                    Top = rand.Next(-400, -60),
                    Image = lastUpPipe.Image,
                    Width = lastUpPipe.Width,
                    Height = lastUpPipe.Height,
                    SizeMode = lastUpPipe.SizeMode,
                };

                upPipes.Add(newUpPipe);

                PictureBox newDownPipe = new PictureBox()
                {
                    Left = 1020,
                    Top = newUpPipe.Top + 600,
                    Image = lastDownPipe.Image,
                    Width = lastDownPipe.Width,
                    Height = lastDownPipe.Height,
                    SizeMode = lastDownPipe.SizeMode
                };

                downPipes.Add(newDownPipe);

                Controls.Add(newUpPipe);
                Controls.Add(newDownPipe);

                bird.SendToBack();

            }

            if (upPipes[passedPipe].Left + upPipes[passedPipe].Width < bird.Left)
            {
                score.Text = (int.Parse(score.Text) + 1).ToString();
                passedPipe += 1;
            }
            else if (upPipes[0].Left + upPipes[0].Width < 0)
            {
                Controls.Remove(upPipes[0]);
                Controls.Remove(downPipes[0]);
                upPipes.Remove(upPipes[0]);
                downPipes.Remove(downPipes[0]);
                passedPipe -= 1;
            }

            bird.Top += gravity;

            if (bird.Top + bird.Height > ground.Top)
            {
                timer1.Enabled = false;
            }

            for (int i = 0; i < upPipes.Count; i++)
            {
                
                upPipes[i].Left -= pipeSpeed;
                downPipes[i].Left -= pipeSpeed;


                if (bird.Left + bird.Width > upPipes[i].Left && bird.Left < upPipes[i].Left + upPipes[i].Width)
                {
                    PictureBox selectedUpPipe = upPipes[i];
                    

                    if (bird.Top < selectedUpPipe.Top + selectedUpPipe.Height || bird.Top + bird.Height > downPipes[i].Top)
                    {
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timer1.Enabled)
            {
                bird.Top -= birdUpSpeed;
            }
            else
            {
                Application.Restart();
            }
        }
    }
}
