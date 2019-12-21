using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    public static class Rotations
    {
        //Method to rotate all edges in a Z move (clockwise facing F)
        static public Edge[] ZEdges(Edge[] edges)
        {
            //Move edges in blocks of three, starting with UB, UR, UF
            Edge temp1 = edges[4];
            Edge temp2 = edges[9];
            Edge temp3 = edges[5];
            edges[0].Flip();
            edges[1].Flip();
            edges[2].Flip();
            edges[4] = edges[0];
            edges[9] = edges[1];
            edges[5] = edges[2];

            Edge temp4 = edges[8];
            Edge temp5 = edges[11];
            Edge temp6 = edges[10];
            temp1.Flip();
            temp2.Flip();
            temp3.Flip();
            edges[8] = temp1;
            edges[11] = temp2;
            edges[10] = temp3;

            temp1 = edges[7];
            temp2 = edges[3];
            temp3 = edges[6];
            temp4.Flip();
            temp5.Flip();
            temp6.Flip();
            edges[7] = temp4;
            edges[3] = temp5;
            edges[6] = temp6;

            temp1.Flip();
            temp2.Flip();
            temp3.Flip();
            edges[0] = temp1;
            edges[1] = temp2;
            edges[2] = temp3;

            return edges;
        }

        //Method to rotate all centres in a Z move (clockwise facing F)
        static public Centre[] ZCentres(Centre[] centres)
        {
            //Rotates centres
            Centre temp1 = centres[2];
            centres[2] = centres[0];
            Centre temp2 = centres[4];
            centres[4] = temp1;
            temp1 = centres[5];
            centres[5] = temp2;
            centres[0] = temp1;

            return centres;
        }

        //Method to rotate all corners in a Z move (clockwise facing F)
        static public Corner[] ZCorners(Corner[] corners)
        {
            Corner temp1 = corners[5];
            Corner temp2 = corners[6];
            corners[1].IncrementFaces();
            corners[2].DecrementFaces();
            corners[5] = corners[1];
            corners[6] = corners[2];

            Corner temp3 = corners[4];
            Corner temp4 = corners[7];
            temp1.DecrementFaces();
            temp2.IncrementFaces();
            corners[4] = temp1;
            corners[7] = temp2;

            temp1 = corners[0];
            temp2 = corners[3];
            temp3.IncrementFaces();
            temp4.DecrementFaces();
            corners[0] = temp3;
            corners[3] = temp4;

            temp1.DecrementFaces();
            temp2.IncrementFaces();
            corners[1] = temp1;
            corners[2] = temp2;

            return corners;
        }

        //Method to rotate centres in an E move (clockwise facing U)
        static public Centre[] ECentres(Centre[] centres)
        {
            Centre temp = centres[2];
            centres[2] = centres[1];
            Centre temp2 = centres[3];
            centres[3] = temp;
            temp = centres[5];
            centres[5] = temp2;
            centres[1] = temp;

            return centres;
        }

        //Method to rotate edges in an E move (clockwise facing U)
        static public Edge[] EEdges(Edge[] edges)
        {
            Edge temp = edges[5];
            edges[5] = edges[6];
            Edge temp2 = edges[4];
            edges[4] = temp;
            temp = edges[7];
            edges[7] = temp2;
            edges[6] = temp;

            return edges;
        }
    }
}