using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Teliki
{
    
    class Math
    {
        public int ID { get; set; } // 1-20
        public string MathText { get; set; }
        public int Solution { get; set; } //Correct anwer
        public string Answer { get; set; } //User's answer

        public Math(Random r, int ID)
        {
            this.ID = ID;
            this.Answer = String.Empty;

            //Creates a random math equation.
            int a, b;
            a = r.Next(-300,300);
            b = r.Next(-300,300);
            string oper = String.Empty;
            do
            {
                switch (r.Next(4))
                {
                    case (0):
                        oper = "+";
                        Solution = a + b;
                        break;
                    case (1):
                        oper = "-";
                        Solution = a - b;
                        break;
                    case (2):
                        oper = "*";
                        Solution = a * b;
                        break;
                    case (3):
                        oper = "/";
                        if (b != 0)
                        {
                            Solution = a / b;
                        }
                        break;
                }
            } while (oper == "/" && b == 0);

            if (b < 0)
                MathText = a.ToString() + " " + oper + " (" + b.ToString() + ") = ";
            else
                MathText = a.ToString() + " " + oper + " " + b.ToString() + " = ";
            
        }
    }
}
