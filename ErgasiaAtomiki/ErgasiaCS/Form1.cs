using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;


namespace ErgasiaCS
{
    public partial class Form1 : Form
    {
        float score, scoreMultiplier, speed, speedMultiplier;
        int hits, time, ticks;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
       
        }

        //main form, initialising locations, drawing random bitcoins at the background. 
        private void Form1_Load(object sender, EventArgs e)
        {
            title.Location= new Point((int)(this.Width / 2) - (int)(title.Width / 2), 150);
            Random r = new Random();
            int rX, rY;
            for(int i = 0; i < 15; i++)
            {
                PictureBox pctBox = new PictureBox();
                pctBox.ImageLocation = "bitcoin.gif";
                pctBox.Name = "pictureBox1";
                pctBox.Size = new System.Drawing.Size(70, 63);
                pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                do
                {
                    rX = r.Next(this.Width - pctBox.Width - 10);
                    rY = r.Next(this.Height - pctBox.Height - 10);
                } while (rX + pctBox.Width + 10 > title.Location.X && rX < title.Location.X + title.Width); //avoid labels
                pctBox.Location = new System.Drawing.Point(rX, rY);
                pctBox.BackColor = Color.Transparent;
                this.Controls.Add(pctBox);

            }
            pictureBox1.ImageLocation = "bitcoin.gif";
            pictureBox1.Location = new Point((int)(this.Width / 2) - (int)(pictureBox1.Width / 2), 20);
            groupLevel.Location = new Point((int)(this.Width / 2) - (int)(groupLevel.Width / 2), 300);
            leaderBtn.Location = new Point(groupLevel.Location.X - leaderBtn.Width - 80, 500);
            playBtn.Location = new Point(groupLevel.Location.X + groupLevel.Width + 80, 500);
            nameTextBox.Location = new Point((int)(this.Width / 2) - (int)(nameTextBox.Width / 2), 500);
            label1.Location = new Point((int)(this.Width / 2) - (int)(label1.Width / 2), nameTextBox.Location.Y+nameTextBox.Height+5);
            mainExitBtn.Location = new Point((int)(this.Width / 2) - (int)(mainExitBtn.Width / 2), label1.Location.Y + nameTextBox.Height + 100);
            infoBtn.Location = new Point((int)(this.Width / 2) - (int)(infoBtn.Width / 2), mainExitBtn.Location.Y + mainExitBtn.Height + 30);
            this.Cursor = new Cursor("scope.cur");
            easyBtn.Checked = true;
            playPanel.Dock = DockStyle.Fill;
            leaderboardPanel.Dock = DockStyle.Fill;
            leaderboardPanel.Visible = false;
        }

        //stop and exit the game/playpanel without saving.
        private void stopBtn_Click(object sender, EventArgs e)
        {
            infoLbl.Visible = false;
            loseLbl.Visible = true;
            loseLbl.Location = new Point((int)(playPanel.Width / 2) - (int)(loseLbl.Width / 2), (int)(playPanel.Height / 3));
            mainTimer.Enabled = false;
            locTimer.Enabled = false;
            hitBox.Visible = false;
            continueBtn.Location = new Point((int)(playPanel.Width / 2) - (int)(continueBtn.Width / 2), (int)(playPanel.Height * 0.75));
            continueBtn.Visible = true;

        }

        //exit the leaderboardpanel. Dispose all the labels in table.
        private void exitBtn_Click(object sender, EventArgs e)
        {
            leaderboardPanel.Visible = false;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 3;  j++)
                {
                    leaderboardTable.GetControlFromPosition(j, i).Dispose();
                }
            }
        }

        //exit the game/playpanel with saving.
        private void continueBtn_Click(object sender, EventArgs e)
        {
            scoreLbl.Text = " ";
            playPanel.Visible = false;
            finalScrLbl.Text = "your score is: ";
            if (time == 0)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("leaderboard.txt", true))
                {
                    file.WriteLine(userLbl.Text + " " + score.ToString("F2") + " " + hits.ToString());
                }
            }
            nameTextBox.Clear();

        }

        //open leaderboard panel, read txt file and set labels in descending order.
        private void leaderBtn_Click(object sender, EventArgs e)
        {
            leaderboardLbl.Visible = true;
            leaderboardPanel.Visible = true;
            leaderboardTable.Visible = true;
            leaderboardLbl.Location = new Point((int)(this.Width / 2) - (int)(leaderboardLbl.Width / 2), 50);
            leaderboardTable.Location= new Point((int)(this.Width / 2) - (int)(leaderboardTable.Width / 2), leaderboardLbl.Location.Y + leaderboardLbl.Height + 50);
            exitBtn.Location = new Point((int)(leaderboardPanel.Width * 0.75), (int)(leaderboardPanel.Height / 2));
            exitBtn.Visible = true;
            string[] textInput = System.IO.File.ReadAllLines("leaderboard.txt");
            textInput = textInput.Where(c => c != "").ToArray();//remove any empty lines
            string[][] leaderboard = new string[textInput.Length][];
            for(int i = 0; i < textInput.Length; i++)
            {
                string[] tmp = textInput[i].Split(' ');
                for(int j = 0; j < 3; j++)
                {
                    leaderboard[i] = tmp;
                    
                }
            }
            leaderboard = leaderboard.OrderByDescending(x => Double.Parse(x.Skip(1).First())).ToArray();
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Font = new System.Drawing.Font("Stencil", 10.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb.Name = "lb";
                    if (i == 0)
                    {
                        lb.Font = new System.Drawing.Font("Stencil", 14.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        switch (j)
                        {
                            case (0):
                                lb.Text = "username";
                                break;
                            case (1):
                                lb.Text = "score";
                                break;
                            case (2):
                                lb.Text = "hits";
                                break;
                        }
                    }
                    else
                    {
                        if (leaderboard.Length > i-1)
                        {
                            lb.Text = leaderboard[i-1][j];
                        }
                        else
                        {
                            lb.Text = " ";
                        }
                    }
                    leaderboardTable.Controls.Add(lb, j, i);
                }
            }

            
        }

        //exit the app.
        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //just some info.
        private void infoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!\n\n" +
                "Bitcoin Hunter is a game that requires speed and precision.\n" +
                "Select a difficulty, type a username and play!\n" +
                "Each level has different speed and score multipliers so \n" +
                "choose wisely!\n" +
                "Every 15 seconds the speed and the size of the bitcoin will change,\n" +
                "so prepare yourself.\n\n" +
                "Good luck, Hunter!");
        }

        //change backcolor on bitcoin hit.
        private void backColorTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 1)//change backcolor for only 1 tick.
            {
                playPanel.BackColor = Color.FromArgb(232, 69, 69);
            }
            else
            {
                playPanel.BackColor = Color.FromArgb(15, 83, 219);
                backColorTimer.Enabled = false;
            }
        }

        //change random location of bitcoin.
        private void locTimer_Tick(object sender, EventArgs e)
        {
            hitBox.Visible = true;
            int rX, rY;
            do
            {
                rX = r.Next(hitBox.Width + 3, this.Width - hitBox.Width - 3);
                rY = r.Next(topPanel.Height + 3, this.Height - hitBox.Height - 50);
            } while (rX + hitBox.Width >= stopBtn.Location.X && rY <= stopBtn.Height);//avoid stop button
            hitBox.Location = new Point(rX,rY);

        }

        //open playpanel, initialising multipliers and components and start the game.
        private void playBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Count() == 0)
                MessageBox.Show("Please type a username to continue.");
            else if (nameTextBox.Text.Contains(" "))
                MessageBox.Show("Please use underscore '_' for space.");
            else
            {
                time = 60;
                hits = 0;
                score = 0;
                playPanel.Visible = true;
                infoLbl.Visible = true;
                hitBox.Visible = true;
                stopBtn.Visible = true;
                timeLbl.Location = new Point((int)(this.Width / 2) - (int)(timeLbl.Width / 2), (int)(topPanel.Height / 3));
                timeLbl.Text = "60";
                hitBox.ImageLocation = "bitcoin.gif";
                hitBox.Size = new System.Drawing.Size(115, 127);
                hitBox.Location = new Point((int)(playPanel.Width / 2) - (int)(hitBox.Width / 2), (int)(playPanel.Height / 2));
                infoLbl.Location = new Point((int)(playPanel.Width / 2) - (int)(infoLbl.Width / 2), (int)(playPanel.Height / 3));
                label2.Location = new Point((int)(topPanel.Width * 0.85), userLbl.Location.Y);
                scoreLbl.Location = new Point((int)(topPanel.Width * 0.925), userLbl.Location.Y);
                stopBtn.Location = new Point(playPanel.Width - stopBtn.Width, topPanel.Height);
                userLbl.Text = nameTextBox.Text;
                congraLbl.Visible = false;
                finalScrLbl.Visible = false;
                continueBtn.Visible = false;
                loseLbl.Visible = false;
                if (easyBtn.Checked)
                {
                    scoreMultiplier = 0.1F;
                    speed = 1;
                    speedMultiplier = 1;
                }
                else if (regularBtn.Checked)
                {
                    scoreMultiplier = 0.15F;
                    speed = 1.13F;
                    speedMultiplier = 1.15F;
                }
                else
                {
                    scoreMultiplier = 0.225F;
                    speed = 1.25F;
                    speedMultiplier = 1.30F;
                }
                locTimer.Interval = (int)(1500 / (speed * speedMultiplier));
            }
            
        }

        //a 60sec timer for the game, changing speed and size of bitcoin every 15sec.
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            time -= 1;
            timeLbl.Text = time.ToString();
            if (time==0)//end of time
            {
                mainTimer.Enabled = false;
                locTimer.Enabled = false;
                hitBox.Visible = false;
                stopBtn.Visible = false;
                congraLbl.Location = new Point((int)(playPanel.Width / 2) - (int)(congraLbl.Width / 2), (int)(playPanel.Height / 3));
                congraLbl.Visible = true;
                finalScrLbl.Text += score.ToString("F2");
                finalScrLbl.Location = new Point((int)(playPanel.Width / 2) - (int)(finalScrLbl.Width / 2), congraLbl.Location.Y + congraLbl.Height + 20);
                finalScrLbl.Visible = true;
                continueBtn.Location = new Point((int)(playPanel.Width / 2) - (int)(continueBtn.Width / 2), (int)(playPanel.Height * 0.75));
                continueBtn.Visible = true;
            }
            if (time % 15 == 0)//changing speed and score multipliers, scale
            {
                speedMultiplier *= 0.15F;
                scoreMultiplier *= 1.2F;
                locTimer.Interval -= (int)(1500 * speedMultiplier);
                hitBox.Width = (int)(hitBox.Width * 0.9);
                hitBox.Height = (int)(hitBox.Height * 0.9);
            }
        }

        //hit 1st time the bitcoin to start the game, just hitting things.
        private void hitBox_Click(object sender, EventArgs e)
        {
            hits += 1;
            hitBox.Visible = false;
            backColorTimer.Enabled = true;
            ticks = 0;
            if (hits == 1)
            {
                infoLbl.Visible = false;
                mainTimer.Enabled = true;
                locTimer.Enabled = true;
            }
            score += (float)(10 * scoreMultiplier);
            scoreLbl.Text = score.ToString("F2");
           
                       
        }
    }
}
