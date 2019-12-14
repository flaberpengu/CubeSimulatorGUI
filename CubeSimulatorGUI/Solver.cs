using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    public class Solver
    {
        private Cube myCube;

        //Method to copy faces from scramble to practise cube
        private void copyFaces()
        {
            myCube.InitialiseCube();
            myCube.GiveScramble(Scramble.lastScramble);
        }

        //Constructor
        public Solver()
        {
            myCube = new Cube();
            copyFaces();
        }

        //Method to flip UF faces & add performed moves
        private List<string> FlipUF(List<string> movesPerformed)
        {
            myCube.RegularF();
            myCube.InverseU();
            myCube.RegularR();
            myCube.RegularU();
            movesPerformed.Add("F");
            movesPerformed.Add("U'");
            movesPerformed.Add("R");
            movesPerformed.Add("U");
            return movesPerformed;
        }

        //Method to get white piece to top face
        private List<string> WhiteToUF(int edgeIndex)
        {
            List<string> movesPerformed = new List<string>();
            bool whiteInserted = false;
            switch (edgeIndex)
            {
                case 0:
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("U");
                    movesPerformed.Add("U");
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 1:
                    myCube.RegularU();
                    movesPerformed.Add("U");
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 2:
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 3:
                    myCube.InverseU();
                    movesPerformed.Add("U'");
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 4:
                    if (myCube.edges[9].faces[0] == "W")
                    {
                        whiteInserted = true;
                    }
                    myCube.InverseR();
                    myCube.RegularU();
                    movesPerformed.Add("R'");
                    movesPerformed.Add("U");
                    if (whiteInserted)
                    {
                        myCube.RegularR();
                        movesPerformed.Add("R");
                    }
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 5:
                    if (myCube.edges[9].faces[0] == "W")
                    {
                        whiteInserted = true;
                    }
                    myCube.RegularR();
                    myCube.RegularU();
                    movesPerformed.Add("R");
                    movesPerformed.Add("U");
                    if (whiteInserted)
                    {
                        myCube.InverseR();
                        movesPerformed.Add("R'");
                    }
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 6:
                    if (myCube.edges[11].faces[0] == "W")
                    {
                        whiteInserted = true;
                    }
                    myCube.InverseL();
                    myCube.InverseU();
                    movesPerformed.Add("L'");
                    movesPerformed.Add("U'");
                    if (whiteInserted)
                    {
                        myCube.RegularL();
                        movesPerformed.Add("L");
                    }
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 7:
                    if (myCube.edges[11].faces[0] == "W")
                    {
                        whiteInserted = true;
                    }
                    myCube.RegularL();
                    myCube.InverseU();
                    movesPerformed.Add("L");
                    movesPerformed.Add("U'");
                    if (whiteInserted)
                    {
                        myCube.InverseL();
                        movesPerformed.Add("L'");
                    }
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 8:
                    myCube.RegularB();
                    myCube.RegularB();
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("B");
                    movesPerformed.Add("B");
                    movesPerformed.Add("U");
                    movesPerformed.Add("U");
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 9:
                    myCube.RegularR();
                    myCube.RegularR();
                    myCube.RegularU();
                    movesPerformed.Add("R");
                    movesPerformed.Add("R");
                    movesPerformed.Add("U");
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 10:
                    myCube.RegularF();
                    myCube.RegularF();
                    movesPerformed.Add("F");
                    movesPerformed.Add("F");
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
                case 11:
                    myCube.RegularL();
                    myCube.RegularL();
                    myCube.InverseU();
                    movesPerformed.Add("L");
                    movesPerformed.Add("L");
                    movesPerformed.Add("U'");
                    if (myCube.edges[2].faces[1] == "W")
                    {
                        movesPerformed = FlipUF(movesPerformed);
                    }
                    break;
            }
            return movesPerformed;
        }

        //Method to put white piece in place
        private List<string> UFToSlot()
        {
            List<string> movesPerformed = new List<string>();
            for (int i = 0; i < myCube.centres.Length; i++)
            {
                if (myCube.centres[i].faces[0] == myCube.edges[2].faces[1])
                {
                    switch (i)
                    {
                        case 1:
                            myCube.RegularF();
                            myCube.RegularF();
                            movesPerformed.Add("F");
                            movesPerformed.Add("F");
                            break;
                        case 2:
                    }
                }
            }
            return movesPerformed;
        }

        //Method to do white cross on U face
        private List<string> WhiteCross(List<string> movesPerformed)
        {
            List<string> tempMovesPerformed;
            myCube.RegularZ();
            myCube.RegularZ();
            movesPerformed.Add("Z");
            movesPerformed.Add("Z");

            int[] foundPos = new int[4];
            for (int i = 0; i < myCube.edges.Length; i++)
            {
                if (myCube.edges[i].faces[0] == "W" || myCube.edges[i].faces[1] == "W")
                {
                    tempMovesPerformed = WhiteToUF(i);
                    foreach (string s in tempMovesPerformed)
                    {
                        movesPerformed.Add(s);
                    }
                    i = 0;
                    tempMovesPerformed.Clear();
                }
            }

            return movesPerformed;
        }
    }
}
