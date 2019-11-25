using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    class Cube
    {
        public string[][] edges;
        public string[][] corners;
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
            edges = new string[12][];
            edges[0] = new string[2] { "W", "B" };
            edges[1] = new string[2] { "W", "R" };
            edges[2] = new string[2] { "W", "G" };
            edges[3] = new string[2] { "W", "O" };
            edges[4] = new string[2] { "B", "R" };
            edges[5] = new string[2] { "G", "R" };
            edges[6] = new string[2] { "G", "O" };
            edges[7] = new string[2] { "B", "O" };
            edges[8] = new string[2] { "Y", "B" };
            edges[9] = new string[2] { "Y", "R" };
            edges[10] = new string[2] { "Y", "G" };
            edges[11] = new string[2] { "Y", "O" };
            corners = new string[8][];
            corners[0] = new string[3] { "W", "O", "B" };
            corners[1] = new string[3] { "W", "B", "R" };
            corners[2] = new string[3] { "W", "R", "G" };
            corners[3] = new string[3] { "W", "G", "O" };
            corners[4] = new string[3] { "Y", "B", "O" };
            corners[5] = new string[3] { "Y", "R", "B" };
            corners[6] = new string[3] { "Y", "G", "R" };
            corners[7] = new string[3] { "Y", "O", "G" };
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
    }
}
