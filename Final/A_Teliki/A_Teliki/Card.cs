using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Teliki
{
    class Card
    {
        public int id { get; }
        public string cardPath { get; } //image
        public bool locked { get; set; }

        public Card(int id, string cardPath)
        {
            this.id = id;
            this.cardPath = cardPath;
        }

    }
}
