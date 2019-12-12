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

            /*
            //Temp copies edges, starts at U, clockwise (facing R side)
            string[][] temp = new string[4][];
            temp[0] = new string[2];
            Array.Copy(edges[1], temp[0], 2);
            temp[1] = new string[2];
            Array.Copy(edges[4], temp[1], 2);
            temp[2] = new string[2];
            Array.Copy(edges[9], temp[2], 2);
            temp[3] = new string[2];
            Array.Copy(edges[5], temp[3], 2);

            //Copy edges into new places
            Array.Copy(temp[0], edges[4], 2);
            Array.Copy(temp[1], edges[9], 2);
            Array.Copy(temp[2], edges[5], 2);
            Array.Copy(temp[3], edges[1], 2);

            //Return edited array
            return edges;
            */
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

            /*


            //Temp copies corners, starts at UFR, clockwise (facing R side)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[2].faces, temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[1].faces, temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[5].faces, temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[6].faces, temp[3], 3);

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                if (i == 0 || i == 2)
                {
                    temp[i].IncrementFaces();
                }
                else
                {
                    temp[i].DecrementFaces();
                }
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[1].faces, 3);
            Array.Copy(temp[1], corners[5].faces, 3);
            Array.Copy(temp[2], corners[6].faces, 3);
            Array.Copy(temp[3], corners[2].faces, 3);

            //Return edited array
            return corners;
            */
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

            /*
            //Temp copies edges, starts at U, clockwise (facing L side)
            string[][] temp = new string[4][];
            temp[0] = new string[2];
            Array.Copy(edges[3], temp[0], 2);
            temp[1] = new string[2];
            Array.Copy(edges[6], temp[1], 2);
            temp[2] = new string[2];
            Array.Copy(edges[11], temp[2], 2);
            temp[3] = new string[2];
            Array.Copy(edges[7], temp[3], 2);

            //Copy edges into new places
            Array.Copy(temp[0], edges[6], 2);
            Array.Copy(temp[1], edges[11], 2);
            Array.Copy(temp[2], edges[7], 2);
            Array.Copy(temp[3], edges[3], 2);

            //Return edited array
            return edges;
            */
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
            
            /*
            //Temp copies corners, starts at UBL, clockwise (facing L face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[0].faces, temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[3].faces, temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[7].faces, temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[4].faces, temp[3], 3);

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                if (i == 0 || i == 2)
                {
                    corners[i].IncrementFaces();
                }
                else
                {
                    corners[i].DecrementFaces();
                }
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[3].faces, 3);
            Array.Copy(temp[1], corners[7].faces, 3);
            Array.Copy(temp[2], corners[4].faces, 3);
            Array.Copy(temp[3], corners[0].faces, 3);

            //Return edited array
            return corners;
            */
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

            /*
            //Temp copies edges, starts at UB, clockwise (facing U side)
            string[][] temp = new string[4][];
            temp[0] = new string[2];
            Array.Copy(edges[0], temp[0], 2);
            temp[1] = new string[2];
            Array.Copy(edges[1], temp[1], 2);
            temp[2] = new string[2];
            Array.Copy(edges[2], temp[2], 2);
            temp[3] = new string[2];
            Array.Copy(edges[3], temp[3], 2);

            //Copy edges into new places
            Array.Copy(temp[0], edges[1], 2);
            Array.Copy(temp[1], edges[2], 2);
            Array.Copy(temp[2], edges[3], 2);
            Array.Copy(temp[3], edges[0], 2);

            //Return edited array of edges
            return edges;
            */
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

            /*
            //Temp copies corners, starts at UBL, clockwise (facing U face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[0].faces, temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[1].faces, temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[2].faces, temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[3].faces, temp[3], 3);

            //Copy corners into new places
            Array.Copy(temp[0], corners[1].faces, 3);
            Array.Copy(temp[1], corners[2].faces, 3);
            Array.Copy(temp[2], corners[3].faces, 3);
            Array.Copy(temp[3], corners[0].faces, 3);

            //Return edited array
            return corners;
            */
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

            /*
            //Temp copies edges, starts at DB, clockwise (facing D side)
            string[][] temp = new string[4][];
            temp[0] = new string[2];
            Array.Copy(edges[8], temp[0], 2);
            temp[1] = new string[2];
            Array.Copy(edges[9], temp[1], 2);
            temp[2] = new string[2];
            Array.Copy(edges[10], temp[2], 2);
            temp[3] = new string[2];
            Array.Copy(edges[11], temp[3], 2);

            //Copy edges into new places
            Array.Copy(temp[0], edges[9], 2);
            Array.Copy(temp[1], edges[10], 2);
            Array.Copy(temp[2], edges[11], 2);
            Array.Copy(temp[3], edges[8], 2);

            //Return edited array of edges
            return edges;
            */
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
            
            /*
            //Temp copies corners, starts at DBL, clockwise (facing D face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[4].faces, temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[5].faces, temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[6].faces, temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[7].faces, temp[3], 3);

            //Copy corners into new places
            Array.Copy(temp[0], corners[5].faces, 3);
            Array.Copy(temp[1], corners[6].faces, 3);
            Array.Copy(temp[2], corners[7].faces, 3);
            Array.Copy(temp[3], corners[4].faces, 3);

            //Return edited array
            return corners;
            */
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

            /*
            //Temp copies edges, starts at U, clockwise (facing F side)
            string[][] temp = new string[4][];
            temp[0] = new string[2];
            Array.Copy(edges[2], temp[0], 2);
            temp[1] = new string[2];
            Array.Copy(edges[5], temp[1], 2);
            temp[2] = new string[2];
            Array.Copy(edges[10], temp[2], 2);
            temp[3] = new string[2];
            Array.Copy(edges[6], temp[3], 2);

            //Flip each edge
            for (int i = 0; i < temp.Length; i++)
            {
                string[] temp2 = new string[2];
                temp2[0] = temp[i][1];
                temp2[1] = temp[i][0];
                Array.Copy(temp2, temp[i], 2);
            }

            //Copy edges into new places
            Array.Copy(temp[0], edges[5], 2);
            Array.Copy(temp[1], edges[10], 2);
            Array.Copy(temp[2], edges[6], 2);
            Array.Copy(temp[3], edges[2], 2);

            //Return edited array of edges
            return edges;
            */
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

            /*
            //Temp copies corners, starts at UFL, clockwise (facing F face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[3].faces, temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[2].faces, temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[6].faces, temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[7].faces, temp[3], 3);

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                if (i == 0 || i == 2)
                {
                    corners[i].IncrementFaces();
                }
                else
                {
                    corners[i].DecrementFaces();
                }
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[2].faces, 3);
            Array.Copy(temp[1], corners[6].faces, 3);
            Array.Copy(temp[2], corners[7].faces, 3);
            Array.Copy(temp[3], corners[3].faces, 3);

            //Return edited array
            return corners;
            */
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

            /*
            //Temp copies edges, starts at U, clockwise (facing B side)
            string[][] temp = new string[4][];
            temp[0] = new string[2];
            Array.Copy(edges[0], temp[0], 2);
            temp[1] = new string[2];
            Array.Copy(edges[7], temp[1], 2);
            temp[2] = new string[2];
            Array.Copy(edges[8], temp[2], 2);
            temp[3] = new string[2];
            Array.Copy(edges[4], temp[3], 2);

            //Flip each edge
            for (int i = 0; i < temp.Length; i++)
            {
                string[] temp2 = new string[2];
                temp2[0] = temp[i][1];
                temp2[1] = temp[i][0];
                Array.Copy(temp2, temp[i], 2);
            }

            //Copy edges into new places
            Array.Copy(temp[0], edges[7], 2);
            Array.Copy(temp[1], edges[8], 2);
            Array.Copy(temp[2], edges[4], 2);
            Array.Copy(temp[3], edges[0], 2);

            //Return edited array of edges
            return edges;
            */
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

            /*
            //Temp copies corners, starts at UBR, clockwise (facing B face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[1].faces, temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[0].faces, temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[4].faces, temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[5].faces, temp[3], 3);

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                if (i == 0 || i == 2)
                {
                    corners[i].IncrementFaces();
                }
                else
                {
                    corners[i].DecrementFaces();
                }
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[0].faces, 3);
            Array.Copy(temp[1], corners[4].faces, 3);
            Array.Copy(temp[2], corners[5].faces, 3);
            Array.Copy(temp[3], corners[1].faces, 3);

            //Return edited array
            return corners;
            */
        }
    }
}
