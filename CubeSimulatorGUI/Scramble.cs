using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace CubeSimulatorGUI
{
    class Scramble
    {
        private string[] possibleMoves = new string[18] { "R", "R'", "R2", "L", "L'", "L2", "U", "U'", "U2", "F", "F'", "F2", "D", "D'", "D2", "B", "B'", "B2" };
        private Random rnd;

        public Scramble()
        {
            rnd = new Random();
        }

        private bool GetIfSimilar(string previousMove, string newMove)
        {
            bool similar = false;
            if (previousMove == newMove)
            {
                similar = true;
            }
            else if (previousMove.Substring(0,1) == newMove.Substring(0, 1))
            {
                similar = true;
            }
            return similar;
        }

        //Gets random character from possibleMoves array
        private string GetRandomChar()
        {
            int rndNum = rnd.Next(0, 18);
            return possibleMoves[rndNum];
        }
        public string[] GenerateScramble()
        {
            string[] scramble = new string[25];
            string previousMove = "x";
            string newMove = "";
            int i = 0;
            while (i <= 24)
            {
                newMove = GetRandomChar();
                while (GetIfSimilar(previousMove, newMove))
                {
                    newMove = GetRandomChar();
                }
                scramble[i] = newMove;
                previousMove = newMove;
                i++;
            }
            return scramble;
        }
    }
}
