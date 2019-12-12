using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    static class RegularMoves
    {
        //Method to rotate edges during R move; takes in and returns jagged array of edges
        static public Edge[] REdges(Edge[] edges)
        {
            //Rotate R face, starting at U, clockwise (facing R side)
            Edge temp = edges[4];
            edges[4] = edges[1];
            Edge temp2 = edges[9];
            edges[9] = temp;
            temp = edges[5];
            edges[5] = temp2;
            edges[1] = temp;

            //Return edited array
            return edges;
        }

        //Method to rotate corners during R move; takes in and returns jagged array of corners
        static public Corner[] RCorners(Corner[] corners)
        {
            //Rotate corners
            corners[2].IncrementFaces();
            corners[1].DecrementFaces();
            corners[5].IncrementFaces();
            corners[6].DecrementFaces();

            //Move corners
            Corner temp = corners[1];
            corners[1] = corners[2];
            Corner temp2 = corners[5];
            corners[5] = temp;
            temp = corners[6];
            corners[6] = temp2;
            corners[2] = temp;

            //Return array
            return corners;
        }

        //Method to rotate edges during L move; takes in and returns jagged array of edges
        static public Edge[] LEdges(Edge[] edges)
        {
            //Rotate L face, starting at U, clockwise (facing L side)
            Edge temp = edges[6];
            edges[6] = edges[3];
            Edge temp2 = edges[11];
            edges[11] = temp;
            temp = edges[7];
            edges[7] = temp2;
            edges[3] = temp;

            //Return edited array
            return edges;
        }

        //Method to rotate corners during L move; takes in and returns jagged array of corners
        static public Corner[] LCorners(Corner[] corners)
        {
            //Rotate corners
            corners[0].IncrementFaces();
            corners[3].DecrementFaces();
            corners[7].IncrementFaces();
            corners[4].DecrementFaces();

            //Move corners
            Corner temp = corners[3];
            corners[3] = corners[0];
            Corner temp2 = corners[7];
            corners[7] = temp;
            temp = corners[4];
            corners[4] = temp2;
            corners[0] = temp;

            //Return array
            return corners;
        }

        //Method to rotate edges during U move; takes in and returns jagged array of edges
        static public Edge[] UEdges(Edge[] edges)
        {
            //Rotate U face, starting at UB, clockwise (facing U side)
            Edge temp = edges[1];
            edges[1] = edges[0];
            Edge temp2 = edges[2];
            edges[2] = temp;
            temp = edges[3];
            edges[3] = temp2;
            edges[0] = temp;

            //Return edited array
            return edges;
        }

        //Method to rotate corners during U move; takes in and returns jagged array of corners
        static public Corner[] UCorners(Corner[] corners)
        {
            //Move corners
            Corner temp = corners[1];
            corners[1] = corners[0];
            Corner temp2 = corners[2];
            corners[2] = temp;
            temp = corners[3];
            corners[3] = temp2;
            corners[0] = temp;

            //Return array
            return corners;
        }

        //Method to rotate edges during D move; takes in and returns jagged array of edges
        static public Edge[] DEdges(Edge[] edges)
        {
            //Rotate D face, starting at DB, clockwise (facing D side)
            Edge temp = edges[9];
            edges[9] = edges[8];
            Edge temp2 = edges[10];
            edges[10] = temp;
            temp = edges[11];
            edges[11] = temp2;
            edges[8] = temp;

            //Return edited array
            return edges;
        }

        //Method to rotate corners during D move; takes in and returns jagged array of corners
        static public Corner[] DCorners(Corner[] corners)
        {
            //Move corners
            Corner temp = corners[5];
            corners[5] = corners[4];
            Corner temp2 = corners[6];
            corners[6] = temp;
            temp = corners[7];
            corners[7] = temp2;
            corners[4] = temp;

            //Return array
            return corners;
        }

        //Method to rotate edges during F move; takes in and returns jagged array of corners
        static public Edge[] FEdges(Edge[] edges)
        {
            //Flip edges
            edges[2].Flip();
            edges[5].Flip();
            edges[10].Flip();
            edges[6].Flip();

            //Rotate F face, starting at U, clockwise (facing F side)
            Edge temp = edges[5];
            edges[5] = edges[2];
            Edge temp2 = edges[10];
            edges[10] = temp;
            temp = edges[6];
            edges[6] = temp2;
            edges[2] = temp;

            //Return edited array
            return edges;
        }

        //Method to rotate corners during F move; takes in and returns jagged array of corners
        static public Corner[] FCorners(Corner[] corners)
        {
            //Rotate corners
            corners[3].IncrementFaces();
            corners[2].DecrementFaces();
            corners[6].IncrementFaces();
            corners[7].DecrementFaces();

            //Move corners
            Corner temp = corners[2];
            corners[2] = corners[3];
            Corner temp2 = corners[6];
            corners[6] = temp;
            temp = corners[7];
            corners[7] = temp2;
            corners[3] = temp;

            //Return array
            return corners;
        }

        //Method to rotate edges during B move; takes in and returns jagged array of corners
        static public Edge[] BEdges(Edge[] edges)
        {
            //Flip edges
            edges[0].Flip();
            edges[7].Flip();
            edges[8].Flip();
            edges[4].Flip();

            //Rotate B face, starting at UB, clockwise (facing B side)
            Edge temp = edges[7];
            edges[7] = edges[0];
            Edge temp2 = edges[8];
            edges[8] = temp;
            temp = edges[4];
            edges[4] = temp2;
            edges[0] = temp;

            //Return edited array
            return edges;
        }

        //Method to rotate corners during B move; takes in and returns jagged array of corners
        static public Corner[] BCorners(Corner[] corners)
        {
            //Rotate corners
            corners[1].IncrementFaces();
            corners[0].DecrementFaces();
            corners[4].IncrementFaces();
            corners[5].DecrementFaces();

            //Move corners
            Corner temp = corners[0];
            corners[0] = corners[1];
            Corner temp2 = corners[4];
            corners[4] = temp;
            temp = corners[5];
            corners[5] = temp2;
            corners[1] = temp;

            //Return array
            return corners;
        }
    }
}
