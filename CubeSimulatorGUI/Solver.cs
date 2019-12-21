using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeSimulatorGUI
{
    public class Solver
    {
        private Cube myCube;

        //Method to copy faces from scramble to practise cube
        private void CopyFaces()
        {
            myCube.InitialiseCube();
            myCube.GiveScramble(Scramble.lastScramble);
        }

        public void InitialiseForSolve()
        {
            CopyFaces();
        }

        //Constructor
        public Solver()
        {
            myCube = new Cube();
        }

        //Method to flip UF faces & add performed moves
        private List<string> FlipUF(List<string> movesPerformed)
        {
            bool whiteInsertedF = false;
            bool whiteInsertedR = false;
            if (myCube.edges[10].faces[0] == "W")
            {
                whiteInsertedF = true;
            }
            if (myCube.edges[9].faces[0] == "W")
            {
                whiteInsertedR = true;
            }
            myCube.RegularF();
            myCube.InverseU();
            myCube.RegularR();
            myCube.RegularU();
            movesPerformed.Add("F");
            movesPerformed.Add("U'");
            movesPerformed.Add("R");
            movesPerformed.Add("U");
            if (whiteInsertedR)
            {
                myCube.InverseR();
                movesPerformed.Add("R'");
            }
            if (whiteInsertedF)
            {
                myCube.InverseU();
                myCube.InverseF();
                myCube.RegularU();
                movesPerformed.Add("U'");
                movesPerformed.Add("F'");
                movesPerformed.Add("U");
            }
            return movesPerformed;
        }

        //Method to get white piece to top face
        private List<string> WhiteToUF(int edgeIndex, List<string> movesPerformed)
        {
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
        private List<string> UFToSlot(List<string> movesPerformed)
        {
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
                            myCube.InverseU();
                            myCube.RegularR();
                            myCube.RegularR();
                            movesPerformed.Add("U'");
                            movesPerformed.Add("R");
                            movesPerformed.Add("R");
                            break;
                        case 3:
                            myCube.RegularU();
                            myCube.RegularU();
                            myCube.RegularB();
                            myCube.RegularB();
                            movesPerformed.Add("U");
                            movesPerformed.Add("U");
                            movesPerformed.Add("B");
                            movesPerformed.Add("B");
                            break;
                        case 5:
                            myCube.RegularU();
                            myCube.RegularL();
                            myCube.RegularL();
                            movesPerformed.Add("U");
                            movesPerformed.Add("L");
                            movesPerformed.Add("L");
                            break;
                    }
                    i = myCube.centres.Length;
                }
            }
            return movesPerformed;
        }

        //Method to do white cross on U face
        private List<string> WhiteCross(List<string> movesPerformed)
        {
            List<string> tempMovesPerformed = new List<string>();
            myCube.RegularZ();
            myCube.RegularZ();
            movesPerformed.Add("Z");
            movesPerformed.Add("Z");

            List<int> foundPos = new List<int>();
            for (int i = 0; i < myCube.edges.Length; i++)
            {
                if (myCube.edges[i].faces[0].ToString() == "W" || myCube.edges[i].faces[1].ToString() == "W")
                {
                    if (i < 8)
                    {
                        tempMovesPerformed = WhiteToUF(i, tempMovesPerformed);
                        tempMovesPerformed = UFToSlot(tempMovesPerformed);
                        foreach (string s in tempMovesPerformed)
                        {
                            movesPerformed.Add(s);
                        }
                        foundPos.Add(i);
                        i = -1;
                        tempMovesPerformed.Clear();
                    }
                    else
                    {
                        if (myCube.edges[i].faces[1].ToString() == "W")
                        {
                            tempMovesPerformed = WhiteToUF(i, tempMovesPerformed);
                            tempMovesPerformed = UFToSlot(tempMovesPerformed);
                            foreach (string s in tempMovesPerformed)
                            {
                                movesPerformed.Add(s);
                            }
                            foundPos.Add(i);
                            i = -1;
                            tempMovesPerformed.Clear();
                        }
                        else
                        {
                            switch (i)
                            {
                                case 8:
                                    if (myCube.edges[i].faces[1] != myCube.centres[3].faces[0])
                                    {
                                        tempMovesPerformed = WhiteToUF(i, tempMovesPerformed);
                                        tempMovesPerformed = UFToSlot(tempMovesPerformed);
                                        foreach (string s in tempMovesPerformed)
                                        {
                                            movesPerformed.Add(s);
                                        }
                                        foundPos.Add(i);
                                        i = -1;
                                        tempMovesPerformed.Clear();
                                    }
                                    continue;
                                case 9:
                                    if (myCube.edges[i].faces[1] != myCube.centres[2].faces[0])
                                    {
                                        tempMovesPerformed = WhiteToUF(i, tempMovesPerformed);
                                        tempMovesPerformed = UFToSlot(tempMovesPerformed);
                                        foreach (string s in tempMovesPerformed)
                                        {
                                            movesPerformed.Add(s);
                                        }
                                        foundPos.Add(i);
                                        i = -1;
                                        tempMovesPerformed.Clear();
                                    }
                                    continue;
                                case 10:
                                    if (myCube.edges[i].faces[1] != myCube.centres[1].faces[0])
                                    {
                                        tempMovesPerformed = WhiteToUF(i, tempMovesPerformed);
                                        tempMovesPerformed = UFToSlot(tempMovesPerformed);
                                        foreach (string s in tempMovesPerformed)
                                        {
                                            movesPerformed.Add(s);
                                        }
                                        foundPos.Add(i);
                                        i = -1;
                                        tempMovesPerformed.Clear();
                                    }
                                    continue;
                                case 11:
                                    if (myCube.edges[i].faces[1] != myCube.centres[5].faces[0])
                                    {
                                        tempMovesPerformed = WhiteToUF(i, tempMovesPerformed);
                                        tempMovesPerformed = UFToSlot(tempMovesPerformed);
                                        foreach (string s in tempMovesPerformed)
                                        {
                                            movesPerformed.Add(s);
                                        }
                                        foundPos.Add(i);
                                        i = -1;
                                        tempMovesPerformed.Clear();
                                    }
                                    continue;
                            }
                        }
                    }
                    if (foundPos.Count >= 4)
                    {
                        i = myCube.edges.Length;
                    }
                }
            }
            return movesPerformed;
        }

        //Private method to execute alg to insert, white facing F
        private List<string> InsertCornerF(List<string> movesPerformed)
        {
            myCube.RegularU();
            myCube.RegularR();
            myCube.InverseU();
            myCube.InverseR();
            movesPerformed.Add("U");
            movesPerformed.Add("R");
            movesPerformed.Add("U'");
            movesPerformed.Add("R'");
            return movesPerformed;
        }

        //Private method to execute alg to insert, white facing R
        private List<string> InsertCornerR(List<string> movesPerformed)
        {
            myCube.RegularR();
            myCube.RegularU();
            myCube.InverseR();
            movesPerformed.Add("R");
            movesPerformed.Add("U");
            movesPerformed.Add("R'");
            return movesPerformed;
        }

        //Private method to execute alg to insert, white facing U
        private List<string> InsertCornerU(List<string> movesPerformed)
        {
            myCube.RegularU();
            myCube.RegularR();
            myCube.RegularU();
            myCube.RegularU();
            myCube.InverseR();
            myCube.RegularU();
            myCube.RegularR();
            myCube.InverseU();
            myCube.InverseR();
            movesPerformed.Add("U");
            movesPerformed.Add("R");
            movesPerformed.Add("U2");
            movesPerformed.Add("R'");
            movesPerformed.Add("U");
            movesPerformed.Add("R");
            movesPerformed.Add("U'");
            movesPerformed.Add("R'");
            return movesPerformed;
        }

        //Method to move corner to FR
        private List<string> CornerToFR(int cornerIndex, List<string> movesPerformed)
        {
            switch (cornerIndex)
            {
                case 0:
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("U2");
                    break;
                case 1:
                    myCube.RegularU();
                    movesPerformed.Add("U");
                    break;
                case 2:
                    break;
                case 3:
                    myCube.InverseU();
                    movesPerformed.Add("U'");
                    break;
                case 4:
                    myCube.RegularL();
                    myCube.RegularU();
                    myCube.RegularU();
                    myCube.InverseL();
                    movesPerformed.Add("L");
                    movesPerformed.Add("U2");
                    movesPerformed.Add("L'");
                    break;
                case 5:
                    myCube.InverseR();
                    myCube.RegularU();
                    myCube.RegularU();
                    myCube.RegularR();
                    myCube.InverseU();
                    movesPerformed.Add("R'");
                    movesPerformed.Add("U2");
                    movesPerformed.Add("R");
                    movesPerformed.Add("U'");
                    break;
                case 6:
                    myCube.RegularR();
                    myCube.RegularU();
                    myCube.InverseR();
                    myCube.InverseU();
                    movesPerformed.Add("R");
                    movesPerformed.Add("U");
                    movesPerformed.Add("R'");
                    movesPerformed.Add("U'");
                    break;
                case 7:
                    myCube.InverseL();
                    myCube.InverseU();
                    myCube.RegularL();
                    movesPerformed.Add("L'");
                    movesPerformed.Add("U'");
                    movesPerformed.Add("L");
                    break;
            }
            return movesPerformed;
        }

        //Method to insert corner pieces
        private List<string> InsertCorners(List<string> movesPerformed)
        {
            bool cornerInUF;
            List<int> foundPos = new List<int>();
            string cornerCase;
            for (int i = 0; i < myCube.corners.Length; i++)
            {
                cornerInUF = false;
                if (myCube.corners[i].faces[0] == "W" || myCube.corners[i].faces[1] == "W" || myCube.corners[i].faces[2] == "W")
                {
                    if (i < 4)
                    {
                        movesPerformed = CornerToFR(i, movesPerformed);
                        cornerInUF = true;
                        foundPos.Add(i);
                        i = -1;
                    }
                    else
                    {
                        if (myCube.corners[i].faces[0] != "W")
                        {
                            movesPerformed = CornerToFR(i, movesPerformed);
                            cornerInUF = true;
                            foundPos.Add(i);
                            i = -1;
                        }
                    }
                    if (cornerInUF)
                    {
                        if (myCube.corners[2].faces[0] == "W")
                        {
                            cornerCase = "U";
                        }
                        else if (myCube.corners[2].faces[1] == "W")
                        {
                            cornerCase = "R";
                        }
                        else
                        {
                            cornerCase = "F";
                        }
                        switch (cornerCase)
                        {
                            case "U":
                                if (myCube.centres[1].faces[0] == myCube.corners[2].faces[1])
                                {
                                    movesPerformed = InsertCornerU(movesPerformed);
                                }
                                else if (myCube.centres[2].faces[0] == myCube.corners[2].faces[1])
                                {
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d");
                                    movesPerformed = InsertCornerU(movesPerformed);
                                    myCube.InverseWideD();
                                    movesPerformed.Add("d'");
                                }
                                else if (myCube.centres[3].faces[0] == myCube.corners[2].faces[1])
                                {
                                    myCube.RegularWideD();
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d2");
                                    movesPerformed = InsertCornerU(movesPerformed);
                                    myCube.RegularWideD();
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d2");
                                }
                                else if (myCube.corners[5].faces[0] == myCube.corners[2].faces[1])
                                {
                                    myCube.InverseWideD();
                                    movesPerformed.Add("d'");
                                    movesPerformed = InsertCornerU(movesPerformed);
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d");
                                }
                                break;
                            case "R":
                                if (myCube.centres[1].faces[0] == myCube.corners[2].faces[2])
                                {
                                    movesPerformed = InsertCornerR(movesPerformed);
                                }
                                else if (myCube.centres[2].faces[0] == myCube.corners[2].faces[2])
                                {
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d");
                                    movesPerformed = InsertCornerR(movesPerformed);
                                    myCube.InverseWideD();
                                    movesPerformed.Add("d'");
                                }
                                else if (myCube.centres[3].faces[0] == myCube.corners[2].faces[2])
                                {
                                    myCube.RegularWideD();
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d2");
                                    movesPerformed = InsertCornerR(movesPerformed);
                                    myCube.RegularWideD();
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d2");
                                }
                                else if (myCube.corners[5].faces[0] == myCube.corners[2].faces[1])
                                {
                                    myCube.InverseWideD();
                                    movesPerformed.Add("d'");
                                    movesPerformed = InsertCornerR(movesPerformed);
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d");
                                }
                                break;
                            case "F":
                                if (myCube.centres[1].faces[0] == myCube.corners[2].faces[0])
                                {
                                    movesPerformed = InsertCornerF(movesPerformed);
                                }
                                else if (myCube.centres[2].faces[0] == myCube.corners[2].faces[0])
                                {
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d");
                                    movesPerformed = InsertCornerF(movesPerformed);
                                    myCube.InverseWideD();
                                    movesPerformed.Add("d'");
                                }
                                else if (myCube.centres[3].faces[0] == myCube.corners[2].faces[0])
                                {
                                    myCube.RegularWideD();
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d2");
                                    movesPerformed = InsertCornerF(movesPerformed);
                                    myCube.RegularWideD();
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d2");
                                }
                                else if (myCube.corners[5].faces[0] == myCube.corners[2].faces[0])
                                {
                                    myCube.InverseWideD();
                                    movesPerformed.Add("d'");
                                    movesPerformed = InsertCornerF(movesPerformed);
                                    myCube.RegularWideD();
                                    movesPerformed.Add("d");
                                }
                                break;
                        }
                    }
                    if (foundPos.Count >= 4)
                    {
                        i = myCube.corners.Length;
                    }
                }
            }

            return movesPerformed;
        }

        //Method to insert edge to right
        private List<string> InsertMEdgeR(List<string> movesPerformed)
        {
            myCube.RegularU();
            myCube.RegularR();
            myCube.InverseU();
            myCube.InverseR();
            myCube.InverseU();
            myCube.InverseF();
            myCube.RegularU();
            myCube.RegularF();
            movesPerformed.Add("U");
            movesPerformed.Add("R");
            movesPerformed.Add("U'");
            movesPerformed.Add("R'");
            movesPerformed.Add("U'");
            movesPerformed.Add("F'");
            movesPerformed.Add("U");
            movesPerformed.Add("F");
            return movesPerformed;
        }

        //Method to insert edge to left
        private List<string> InsertMEdgeL(List<string> movesPerformed)
        {
            myCube.InverseU();
            myCube.InverseL();
            myCube.RegularU();
            myCube.RegularL();
            myCube.RegularU();
            myCube.RegularF();
            myCube.InverseU();
            myCube.InverseF();
            movesPerformed.Add("U'");
            movesPerformed.Add("L'");
            movesPerformed.Add("U");
            movesPerformed.Add("L");
            movesPerformed.Add("U");
            movesPerformed.Add("F");
            movesPerformed.Add("U'");
            movesPerformed.Add("F'");
            return movesPerformed;
        }

        //Method to move edge to UF
        private List<string> EdgeToUF(int edgeIndex, List<string> movesPerformed)
        {
            switch (edgeIndex)
            {
                case 0:
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("U2");
                    break;
                case 1:
                    myCube.RegularU();
                    movesPerformed.Add("U");
                    break;
                case 2:
                    break;
                case 3:
                    myCube.InverseU();
                    movesPerformed.Add("U'");
                    break;
                case 4:
                    myCube.RegularWideD();
                    movesPerformed.Add("d");
                    movesPerformed = InsertMEdgeR(movesPerformed);
                    myCube.InverseWideD();
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("d'");
                    movesPerformed.Add("U2");
                    break;
                case 5:
                    movesPerformed = InsertMEdgeR(movesPerformed);
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("U2");
                    break;
                case 6:
                    movesPerformed = InsertMEdgeL(movesPerformed);
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("U2");
                    break;
                case 7:
                    myCube.InverseWideD();
                    movesPerformed.Add("d'");
                    movesPerformed = InsertMEdgeL(movesPerformed);
                    myCube.RegularWideD();
                    myCube.RegularU();
                    myCube.RegularU();
                    movesPerformed.Add("d");
                    movesPerformed.Add("U2");
                    break;
            }
            return movesPerformed;
        }

        //Method to insert middle edge pieces
        private List<string> InsertMidEdges(List<string> movesPerformed)
        {
            string sideToInsert;
            for (int i = 0; i < 8; i++)
            {

            }

            return movesPerformed;
        }

        //Method to solve cube
        public List<string> SolveCube(List<string> movesPerformed)
        {
            movesPerformed = WhiteCross(movesPerformed);
            movesPerformed = InsertCorners(movesPerformed);
            return movesPerformed;
        }
    }
}
//TODO - LINE UP D AND E
//TODO - INSERT MEDGES
//TODO - WHITE CROSS - CHECK BOTTOM FACE IS WHITE AND IS CORRECT - CURRENTLY IGNORES IF INCORRECT PLACE