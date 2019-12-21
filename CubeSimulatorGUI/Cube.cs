using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeSimulatorGUI
{
    public class Cube
    {
        public Edge[] edges;
        public Corner[] corners;
        public Centre[] centres;
        public string[] scramble;
        public void InitialiseCube()
        {
            /*Layout of edges and indexing:
                UB - 0
                UR - 1
                UF - 2
                UL - 3
                MBR - 4
                MFR - 5
                MFL - 6
                MBL - 7
                DB - 8
                DR - 9
                DF - 10
                DL - 11
            */
            /*Layout of corners and indexing:
                UBL - 0
                UBR - 1
                UFR - 2
                UFL - 3
                DBL - 4
                DBR - 5
                DFR - 6
                DFL - 7
            */
            //Always assume U = White, F = Green, R = Red
            //Corners - start on U/D, go clockwise
            //Edges - Start on U/D, or F/B (U/D takes priority)
            //Centres - W, G, R, B, Y, O
            edges = new Edge[12];
            edges[0] = new Edge("W", "B");
            edges[1] = new Edge("W", "R");
            edges[2] = new Edge("W", "G");
            edges[3] = new Edge("W", "O");
            edges[4] = new Edge("B", "R");
            edges[5] = new Edge("G", "R");
            edges[6] = new Edge("G", "O");
            edges[7] = new Edge("B", "O");
            edges[8] = new Edge("Y", "B");
            edges[9] = new Edge("Y", "R");
            edges[10] = new Edge("Y", "G");
            edges[11] = new Edge("Y", "O");
            corners = new Corner[8];
            corners[0] = new Corner("W", "O", "B");
            corners[1] = new Corner("W", "B", "R");
            corners[2] = new Corner("W", "R", "G");
            corners[3] = new Corner("W", "G", "O");
            corners[4] = new Corner("Y", "B", "O");
            corners[5] = new Corner("Y", "R", "B");
            corners[6] = new Corner("Y", "G", "R");
            corners[7] = new Corner("Y", "O", "G");
            centres = new Centre[6];
            centres[0] = new Centre("W");
            centres[1] = new Centre("G");
            centres[2] = new Centre("R");
            centres[3] = new Centre("B");
            centres[4] = new Centre("Y");
            centres[5] = new Centre("O");
        }

        //Method to do an R rotation
        public void RegularR()
        {
            edges = RegularMoves.REdges(edges);
            corners = RegularMoves.RCorners(corners);
        }

        //Method to do an L rotation
        public void RegularL()
        {
            edges = RegularMoves.LEdges(edges);
            corners = RegularMoves.LCorners(corners);
        }

        //Method to do a U rotation
        public void RegularU()
        {
            edges = RegularMoves.UEdges(edges);
            corners = RegularMoves.UCorners(corners);
        }

        //Method to do a D rotation
        public void RegularD()
        {
            edges = RegularMoves.DEdges(edges);
            corners = RegularMoves.DCorners(corners);
        }

        //Method to do an F rotation
        public void RegularF()
        {
            edges = RegularMoves.FEdges(edges);
            corners = RegularMoves.FCorners(corners);
        }

        //Method to do a B rotation
        public void RegularB()
        {
            edges = RegularMoves.BEdges(edges);
            corners = RegularMoves.BCorners(corners);
        }

        //Method to do an R' rotation
        public void InverseR()
        {
            edges = InverseMoves.REdges(edges);
            corners = InverseMoves.RCorners(corners);
        }

        //Method to do an L' rotation
        public void InverseL()
        {
            edges = InverseMoves.LEdges(edges);
            corners = InverseMoves.LCorners(corners);
        }

        //Method to do a U' rotation
        public void InverseU()
        {
            edges = InverseMoves.UEdges(edges);
            corners = InverseMoves.UCorners(corners);
        }

        //Method to do a D' rotation
        public void InverseD()
        {
            edges = InverseMoves.DEdges(edges);
            corners = InverseMoves.DCorners(corners);
        }

        //Method to do an F' rotation
        public void InverseF()
        {
            edges = InverseMoves.FEdges(edges);
            corners = InverseMoves.FCorners(corners);
        }

        //Method to do a B' rotation
        public void InverseB()
        {
            edges = InverseMoves.BEdges(edges);
            corners = InverseMoves.BCorners(corners);
        }

        //Method to do a Z cube rotation
        public void RegularZ()
        {
            edges = Rotations.ZEdges(edges);
            centres = Rotations.ZCentres(centres);
            corners = Rotations.ZCorners(corners);
        }

        //Method to do an E cube slice
        public void RegularE()
        {
            edges = Rotations.EEdges(edges);
            centres = Rotations.ZCentres(centres);
        }

        //Method to do a wide D rotation (D but inc. E)
        public void RegularWideD()
        {
            RegularD();
            RegularE();
            RegularE();
            RegularE();
        }

        //Method to do an inverse D rotation
        public void InverseWideD()
        {
            InverseD();
            RegularE();
        }

        //Method to get and apply a random scramble to the cube
        public void GetScramble()
        {
            Scramble scrmbl = new Scramble();
            scramble = scrmbl.GenerateScramble();
            GiveScramble(scramble);
            /*foreach (string s in scramble)
            {
                switch (s)
                {
                    case "R":
                        RegularR();
                        continue;
                    case "R'":
                        InverseR();
                        continue;
                    case "R2":
                        RegularR();
                        RegularR();
                        continue;
                    case "L":
                        RegularL();
                        continue;
                    case "L'":
                        InverseL();
                        continue;
                    case "L2":
                        RegularL();
                        RegularL();
                        continue;
                    case "U":
                        RegularU();
                        continue;
                    case "U'":
                        InverseU();
                        continue;
                    case "U2":
                        RegularU();
                        RegularU();
                        continue;
                    case "F":
                        RegularF();
                        continue;
                    case "F'":
                        InverseF();
                        continue;
                    case "F2":
                        RegularF();
                        RegularF();
                        continue;
                    case "D":
                        RegularD();
                        continue;
                    case "D'":
                        InverseD();
                        continue;
                    case "D2":
                        RegularD();
                        RegularD();
                        continue;
                    case "B":
                        RegularB();
                        continue;
                    case "B'":
                        InverseB();
                        continue;
                    case "B2":
                        RegularB();
                        RegularB();
                        continue;
                }
            }*/
        }

        //Method to apply a scramble to the cube
        public void GiveScramble(string[] gScramble)
        {
            //foreach (string s in gScramble)
            //{
            for (int i = 0; i < gScramble.Length; i++)
            {
                switch (gScramble[i])
                {
                    case "R":
                        RegularR();
                        continue;
                    case "R'":
                        InverseR();
                        continue;
                    case "R2":
                        RegularR();
                        RegularR();
                        continue;
                    case "L":
                        RegularL();
                        continue;
                    case "L'":
                        InverseL();
                        continue;
                    case "L2":
                        RegularL();
                        RegularL();
                        continue;
                     case "U":
                        RegularU();
                        continue;
                     case "U'":
                        InverseU();
                        continue;
                     case "U2":
                        RegularU();
                        RegularU();
                        continue;
                     case "F":
                        RegularF();
                        continue;
                     case "F'":
                        InverseF();
                        continue;
                     case "F2":
                        RegularF();
                        RegularF();
                        continue;
                     case "D":
                        RegularD();
                        continue;
                     case "D'":
                        InverseD();
                        continue;
                     case "D2":
                        RegularD();
                        RegularD();
                        continue;
                     case "B":
                        RegularB();
                        continue;
                     case "B'":
                        InverseB();
                        continue;
                     case "B2":
                        RegularB();
                        RegularB();
                        continue;
                     case "Z":
                        RegularZ();
                        continue;
                     case "d":
                        RegularWideD();
                        continue;
                     case "d'":
                        InverseWideD();
                        continue;
                     case "d2":
                        RegularWideD();
                        RegularWideD();
                        continue;
                     case " ":
                        continue;
                }
            }
        }
    }
}
