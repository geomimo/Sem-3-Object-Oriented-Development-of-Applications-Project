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
    public partial class LeaderForm : Form
    {
        public LeaderForm(Color c)
        {
            InitializeComponent();
            this.BackColor = c;
            setTable();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Gets the data from a file and displays the leaderboard.
        private void setTable()
        {
            string path = Application.StartupPath + "\\Players";
            string[] playerPaths = Directory.GetFiles(path);

            if (playerPaths.Length > 0)
            {
                //Deserialize each player-save.
                Player[] playerArray = new Player[playerPaths.Length];
                for (int i = 0; i < playerPaths.Length; i++)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Stream st = new FileStream(playerPaths[i], FileMode.Open);
                    playerArray[i] = (Player)bf.Deserialize(st);
                    st.Close();
                }
                
                //Fill the table.
                playerArray = playerArray.OrderBy(x => x.tries).ToArray();
                for (int i = 0; i < playerArray.Length % 10; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Label lb = new Label();
                        lb.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Bold);
                        switch (j)
                        {
                            case (0):
                                lb.Text = playerArray[i].username;
                                break;
                            case (1):
                                lb.Text = playerArray[i].tries.ToString();
                                break;
                            case (2):
                                lb.Text = playerArray[i].time.ToString();
                                break;
                        }

                        leaderTable.Controls.Add(lb, j, i);

                    }
                }
            }
        }
    }
}
