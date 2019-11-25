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
        static public string[][] REdges(string[][] edges)
        {
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

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");

            //Copy edges into new places
            Array.Copy(temp[0], edges[4], 2);
            Array.Copy(temp[1], edges[9], 2);
            Array.Copy(temp[2], edges[5], 2);
            Array.Copy(temp[3], edges[1], 2);

            //Test printing after
            Console.Write(edges[1][0] + edges[1][1] + "\n" + edges[4][0] + edges[4][1] + "\n" + edges[9][0] + edges[9][1] + "\n" + edges[5][0] + edges[5][1] + "\n");

            //Return edited array
            return edges;
        }

        //Method to rotate corners during R move; takes in and returns jagged array of corners
        static public string[][] RCorners(string[][] corners)
        {
            //Temp copies corners, starts at UFR, clockwise (facing R side)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[2], temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[1], temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[5], temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[6], temp[3], 3);

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                string[] temp2 = new string[3];
                if (i == 0 || i == 2)
                {
                    temp2[0] = temp[i][2];
                    temp2[1] = temp[i][0];
                    temp2[2] = temp[i][1];
                }
                else
                {
                    temp2[0] = temp[i][1];
                    temp2[1] = temp[i][2];
                    temp2[2] = temp[i][0];
                }
                Array.Copy(temp2, temp[i], 3);
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[1], 3);
            Array.Copy(temp[1], corners[5], 3);
            Array.Copy(temp[2], corners[6], 3);
            Array.Copy(temp[3], corners[2], 3);

            //Test printing after
            Console.Write(corners[2][0] + corners[2][1] + corners[2][2] + "\n" + corners[1][0] + corners[1][1] + corners[1][2] + "\n" + corners[5][0] + corners[5][1] + corners[5][2] + "\n" + corners[6][0] + corners[6][1] + corners[6][2] + "\n");

            //Return edited array
            return corners;
        }

        //Method to rotate edges during L move; takes in and returns jagged array of edges
        static public string[][] LEdges(string[][] edges)
        {
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

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }

            //Copy edges into new places
            Array.Copy(temp[0], edges[6], 2);
            Array.Copy(temp[1], edges[11], 2);
            Array.Copy(temp[2], edges[7], 2);
            Array.Copy(temp[3], edges[3], 2);

            //Test printing after
            Console.Write(edges[3][0] + edges[3][1] + "\n" + edges[6][0] + edges[6][1] + "\n" + edges[11][0] + edges[11][1] + "\n" + edges[7][0] + edges[7][1] + "\n");

            //Return edited array
            return edges;
        }

        //Method to rotate corners during L move; takes in and returns jagged array of corners
        static public string[][] LCorners(string[][] corners)
        {
            //Temp copies corners, starts at UBL, clockwise (facing L face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[0], temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[3], temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[7], temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[4], temp[3], 3);

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                string[] temp2 = new string[3];
                if (i == 0 || i == 2)
                {
                    temp2[0] = temp[i][2];
                    temp2[1] = temp[i][0];
                    temp2[2] = temp[i][1];
                }
                else
                {
                    temp2[0] = temp[i][1];
                    temp2[1] = temp[i][2];
                    temp2[2] = temp[i][0];
                }
                Array.Copy(temp2, temp[i], 3);
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[3], 3);
            Array.Copy(temp[1], corners[7], 3);
            Array.Copy(temp[2], corners[4], 3);
            Array.Copy(temp[3], corners[0], 3);

            //Test printing after
            Console.Write(corners[0][0] + corners[0][1] + corners[0][2] + "\n" + corners[3][0] + corners[3][1] + corners[3][2] + "\n" + corners[7][0] + corners[7][1] + corners[7][2] + "\n" + corners[4][0] + corners[4][1] + corners[4][2] + "\n");

            //Return edited array
            return corners;
        }

        //Method to rotate edges during U move; takes in and returns jagged array of edges
        static public string[][] UEdges(string[][] edges)
        {
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

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");

            //Copy edges into new places
            Array.Copy(temp[0], edges[1], 2);
            Array.Copy(temp[1], edges[2], 2);
            Array.Copy(temp[2], edges[3], 2);
            Array.Copy(temp[3], edges[0], 2);

            //Test printing after
            Console.Write(edges[0][0] + edges[0][1] + "\n" + edges[1][0] + edges[1][1] + "\n" + edges[2][0] + edges[2][1] + "\n" + edges[3][0] + edges[3][1] + "\n");

            //Return edited array of edges
            return edges;
        }

        //Method to rotate corners during U move; takes in and returns jagged array of corners
        static public string[][] UCorners(string[][] corners)
        {
            //Temp copies corners, starts at UBL, clockwise (facing U face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[0], temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[1], temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[2], temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[3], temp[3], 3);

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[1], 3);
            Array.Copy(temp[1], corners[2], 3);
            Array.Copy(temp[2], corners[3], 3);
            Array.Copy(temp[3], corners[0], 3);

            //Test printing after
            Console.Write(corners[0][0] + corners[0][1] + corners[0][2] + "\n" + corners[1][0] + corners[1][1] + corners[1][2] + "\n" + corners[2][0] + corners[2][1] + corners[2][2] + "\n" + corners[3][0] + corners[3][1] + corners[3][2] + "\n");

            //Return edited array
            return corners;
        }

        //Method to rotate edges during D move; takes in and returns jagged array of edges
        static public string[][] DEdges(string[][] edges)
        {
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

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");

            //Copy edges into new places
            Array.Copy(temp[0], edges[9], 2);
            Array.Copy(temp[1], edges[10], 2);
            Array.Copy(temp[2], edges[11], 2);
            Array.Copy(temp[3], edges[8], 2);

            //Test printing after
            Console.Write(edges[8][0] + edges[8][1] + "\n" + edges[9][0] + edges[9][1] + "\n" + edges[10][0] + edges[10][1] + "\n" + edges[11][0] + edges[11][1] + "\n");

            //Return edited array of edges
            return edges;
        }

        //Method to rotate corners during D move; takes in and returns jagged array of corners
        static public string[][] DCorners(string[][] corners)
        {
            //Temp copies corners, starts at DBL, clockwise (facing D face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[4], temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[5], temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[6], temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[7], temp[3], 3);

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[5], 3);
            Array.Copy(temp[1], corners[6], 3);
            Array.Copy(temp[2], corners[7], 3);
            Array.Copy(temp[3], corners[4], 3);

            //Test printing after
            Console.Write(corners[4][0] + corners[4][1] + corners[4][2] + "\n" + corners[5][0] + corners[5][1] + corners[5][2] + "\n" + corners[6][0] + corners[6][1] + corners[6][2] + "\n" + corners[7][0] + corners[7][1] + corners[7][2] + "\n");

            //Return edited array
            return corners;
        }

        //Method to rotate edges during F move; takes in and returns jagged array of corners
        static public string[][] FEdges(string[][] edges)
        {
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

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");

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

            //Test printing after
            Console.Write(edges[2][0] + edges[2][1] + "\n" + edges[5][0] + edges[5][1] + "\n" + edges[10][0] + edges[10][1] + "\n" + edges[6][0] + edges[6][1] + "\n");

            //Return edited array of edges
            return edges;
        }

        //Method to rotate corners during F move; takes in and returns jagged array of corners
        static public string[][] FCorners(string[][] corners)
        {
            //Temp copies corners, starts at UFL, clockwise (facing F face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[3], temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[2], temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[6], temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[7], temp[3], 3);

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                string[] temp2 = new string[3];
                if (i == 0 || i == 2)
                {
                    temp2[0] = temp[i][2];
                    temp2[1] = temp[i][0];
                    temp2[2] = temp[i][1];
                }
                else
                {
                    temp2[0] = temp[i][1];
                    temp2[1] = temp[i][2];
                    temp2[2] = temp[i][0];
                }
                Array.Copy(temp2, temp[i], 3);
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[2], 3);
            Array.Copy(temp[1], corners[6], 3);
            Array.Copy(temp[2], corners[7], 3);
            Array.Copy(temp[3], corners[3], 3);

            //Test printing after
            Console.Write(corners[3][0] + corners[3][1] + corners[3][2] + "\n" + corners[2][0] + corners[2][1] + corners[2][2] + "\n" + corners[6][0] + corners[6][1] + corners[6][2] + "\n" + corners[7][0] + corners[7][1] + corners[7][2] + "\n");

            //Return edited array
            return corners;
        }

        //Method to rotate edges during B move; takes in and returns jagged array of corners
        static public string[][] BEdges(string[][] edges)
        {
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

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");

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

            //Test printing after
            Console.Write(edges[0][0] + edges[0][1] + "\n" + edges[7][0] + edges[7][1] + "\n" + edges[8][0] + edges[8][1] + "\n" + edges[4][0] + edges[4][1] + "\n");

            //Return edited array of edges
            return edges;
        }

        //Method to rotate corners during B move; takes in and returns jagged array of corners
        static public string[][] BCorners(string[][] corners)
        {
            //Temp copies corners, starts at UBR, clockwise (facing B face)
            string[][] temp = new string[4][];
            temp[0] = new string[3];
            Array.Copy(corners[1], temp[0], 3);
            temp[1] = new string[3];
            Array.Copy(corners[0], temp[1], 3);
            temp[2] = new string[3];
            Array.Copy(corners[4], temp[2], 3);
            temp[3] = new string[3];
            Array.Copy(corners[5], temp[3], 3);

            //Test printing before
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length; j++)
                {
                    Console.Write(temp[i][j]);
                }
                Console.Write("\n");
            }

            //Sort corner rotations
            for (int i = 0; i < temp.Length; i++)
            {
                //temp corners 0 and 2 increment, 1 and 3 decrement
                string[] temp2 = new string[3];
                if (i == 0 || i == 2)
                {
                    temp2[0] = temp[i][2];
                    temp2[1] = temp[i][0];
                    temp2[2] = temp[i][1];
                }
                else
                {
                    temp2[0] = temp[i][1];
                    temp2[1] = temp[i][2];
                    temp2[2] = temp[i][0];
                }
                Array.Copy(temp2, temp[i], 3);
            }

            //Copy corners into new places
            Array.Copy(temp[0], corners[0], 3);
            Array.Copy(temp[1], corners[4], 3);
            Array.Copy(temp[2], corners[5], 3);
            Array.Copy(temp[3], corners[1], 3);

            //Test printing after
            Console.Write(corners[1][0] + corners[1][1] + corners[1][2] + "\n" + corners[0][0] + corners[0][1] + corners[0][2] + "\n" + corners[4][0] + corners[4][1] + corners[4][2] + "\n" + corners[5][0] + corners[5][1] + corners[5][2] + "\n");

            //Return edited array
            return corners;
        }
    }
}
