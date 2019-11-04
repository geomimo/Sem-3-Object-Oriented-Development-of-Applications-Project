using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Teliki
{
    [Serializable]
    class Player
    {
        public string username { get; set; }
        public int tries { get; set; }
        public int time { get; set; }

        public Player(string username)
        {
            this.username = username;
            this.tries = 0;
            this.time = 0;
        }

        public static bool exists(string username)
        {
            string[] pathArr = Directory.GetFiles(Application.StartupPath + "\\Players");
            foreach(string playerPath in pathArr)
            {
                bool temp = playerPath.Split('\\').Last() == username + ".txt";
                if (temp)
                {
                    return true;
                }
            }
            
            return false;
        }

    }
}
