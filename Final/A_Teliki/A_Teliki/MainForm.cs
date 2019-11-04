using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Teliki
{
    public partial class MainForm : Form
    {
        string folderPath = Application.StartupPath + "\\Images"; //Default folder.
        Player player1;
        Deck myDeck;
        int cardsPicked, correct, mainTime;
        Card secondCard, firstCard;
        int[] firstIndex, secondIndex;
        public static bool tenCards;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            playPanel.Visible = false;
            firstIndex = new int[2];
            secondIndex = new int[2];
            correct = 0;
            mainTime = 0;            
        }

        private void setAndPlay()
        {
            if (usernameTextBox.Text.Count() == 0)
                MessageBox.Show("Please type a username to continue.");
            else if (usernameTextBox.Text.Contains(" "))
                MessageBox.Show("Please use underscore '_' for space.");
            else
            {
                //Creating player's data.
                if (Player.exists(usernameTextBox.Text))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Stream st = new FileStream(Application.StartupPath + "\\Players\\" + usernameTextBox.Text + ".txt", FileMode.Open);
                    player1 = (Player)bf.Deserialize(st);
                    st.Close();
                }
                else
                {
                    player1 = new Player(usernameTextBox.Text);
                }

                tenCards = true;
                myDeck = new Deck(folderPath);
                if (tenCards)
                {
                    playPanel.Visible = true;
                    playPanel.Dock = DockStyle.Fill;
                    cardsPicked = 0;
                    usernameVarLbl.Text = player1.username;
                    triesVarLbl.Text = player1.tries.ToString();
                    myDeck.show(tableDeck, showTimer);
                }

            }
        }

        //Checking pairs on clicks
        private void clicked(PictureBox pctbx)
        {
            //Gets the position i,j of the clicked image.
            TableLayoutPanelCellPosition position = tableDeck.GetPositionFromControl(pctbx);
            cardsPicked++;
            int i = position.Row;
            int j = position.Column;
            Card currentCard = myDeck.deck[i][j];

            if (!currentCard.locked)
            {
                pctbx.ImageLocation = currentCard.cardPath;
                //Only 1 picked card, just show.
                if (cardsPicked == 1)
                {
                    firstCard = myDeck.deck[i][j];
                    firstIndex[0] = i;
                    firstIndex[1] = j;

                }
                //else show and check for matching, then lock them.
                else if (cardsPicked == 2)
                {
                    player1.tries++;
                    triesVarLbl.Text = player1.tries.ToString();
                    cardsPicked = 0;
                    secondCard = myDeck.deck[i][j];
                    secondIndex[0] = i;
                    secondIndex[1] = j;
                    if (firstCard.id != secondCard.id)
                    {
                        showTimer1.Enabled = true;
                        tableDeck.Enabled = false;
                    }
                    else
                    {
                        correct++;
                        firstCard.locked = true;
                        secondCard.locked = true;
                        //Saving data, game over.
                        if (correct == 10)
                        {
                            mainTimer.Enabled = false;
                            player1.time = mainTime;
                            string text = "Congratulations " + player1.username + "!" + Environment.NewLine + "Tries: " + player1.tries + Environment.NewLine + "Time: " + player1.time;
                            MessageBox.Show(text, "Congratulations");
                            BinaryFormatter bf = new BinaryFormatter();
                            Stream st = new FileStream(Application.StartupPath + "\\Players\\" + player1.username + ".txt",FileMode.Create);
                            bf.Serialize(st, player1);
                            st.Close();
                            playPanel.Visible = false;
                            usernameTextBox.Text = String.Empty;
                        }
                    }

                }
            }
          

        }

        #region Menu strips
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setAndPlay();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Match 'em  is a memory card game.\n" +
                            "You have 5sec to see a random deck. Try to memorize the cards." +
                            "Then, find the pairs.\n\n" +
                            "You can import your own cards on settings." , "Info");
        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                mainPanel.BackColor = colorDialog1.Color; 
            }
        }

        private void changeCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                folderPath = folderBrowserDialog1.SelectedPath;

            }
        }

        private void leaderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaderForm leaderForm = new LeaderForm(mainPanel.BackColor);
            leaderForm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Buttons
        private void playBtn_Click(object sender, EventArgs e)
        {
            setAndPlay();
        }

        private void leaderboardBtn_Click(object sender, EventArgs e)
        {
            LeaderForm leaderForm = new LeaderForm(mainPanel.BackColor);
            leaderForm.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            string[] tmp = folderPath.Split('\\');
            colourLb.Text = "Current Color: " + mainPanel.BackColor.Name.ToString();
            folderLb.Text = "Current Folder: " + tmp.Last();           

        }

        private void changeBackgroundBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                mainPanel.BackColor = colorDialog1.Color;
            }
            colourLb.Text = "Current Color: " + mainPanel.BackColor.Name.ToString();

        }

        private void changeCardsBtn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            string[] tmp = folderPath.Split('\\');
            folderLb.Text = "Current Folder: "+ tmp.Last();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        #endregion

        #region Timers

        //Updates the timer label.
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            mainTime++;
            mainTimeLbl.Text = mainTime.ToString();
        }

        //Shows cards for 5sec.
        private void showTimer_Tick(object sender, EventArgs e)
        {
            myDeck.hide(tableDeck);
            showTimer.Enabled = false;
            mainTimer.Enabled = true;
        }
      
        //Hides cards.
        private void showTimer1_Tick(object sender, EventArgs e)
        {
            ((PictureBox)tableDeck.GetControlFromPosition(firstIndex[1], firstIndex[0])).ImageLocation = Application.StartupPath + "\\back.jpg";
            ((PictureBox)tableDeck.GetControlFromPosition(secondIndex[1], secondIndex[0])).ImageLocation = Application.StartupPath + "\\back.jpg";
            showTimer1.Enabled = false;
            tableDeck.Enabled = true;
        }
        #endregion

        #region PictureBoxes Events
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }


        private void pictureBox17_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }


        private void pictureBox18_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }


        private void pictureBox19_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            clicked((PictureBox)sender);

        }

        #endregion

    }
}
