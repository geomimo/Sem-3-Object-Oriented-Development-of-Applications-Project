using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace A_Teliki
{
    class Deck
    {
        public Card[][] deck;
        string folderPath;
        
        //Constructor. Deck 4x5, initialising and suffling.
        public Deck(string folderPath)
        {
            this.folderPath = folderPath;
            deck = new Card[4][];
            for(int i = 0; i < 4; i++)
            {
                deck[i] = new Card[5];
            }

            string[] images = Directory.GetFiles(folderPath);
            if (images.Length == 10)
            {
                Card[][] cards = new Card[10][];
                for (int i = 0; i < 10; i++)
                {
                    cards[i] = new Card[2];
                    cards[i][0] = new Card(i, images[i]);
                    cards[i][1] = new Card(i, images[i]);
                }
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        deck[(i + 10 * j) / 5][i % 5] = cards[i][j];
                    }
                }
                suffleDeck();
            }
            else
            {
                MessageBox.Show("Please choose a folder with only 10 images.");
                MainForm.tenCards = false;
            }
        }

        void suffleDeck()
        {
            Random r = new Random();
            Card[]randomDeck= new Card[20];
            for(int i = 0; i < 20; i++)
            {
                randomDeck[i] = deck[i / 5][i % 5]; 
            }
            //Sort by a random tag => suffling.
            randomDeck = randomDeck.OrderBy(x => r.Next()).ToArray();
            for(int i = 0; i < 20; i++)
            {
                deck[i / 5][i % 5] = randomDeck[i];
            }
        }

        public void hide(TableLayoutPanel tlp)
        {
            foreach(PictureBox pctbx in tlp.Controls)
            {
                pctbx.ImageLocation = Application.StartupPath + "\\back.jpg";
            }
                
        }

        public void show(TableLayoutPanel tlp, Timer timer)
        {
            int k = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    ((PictureBox)tlp.GetControlFromPosition(j, i)).ImageLocation = deck[i][j].cardPath;
                }
            }
            timer.Enabled = true;
        }

    }       
}
