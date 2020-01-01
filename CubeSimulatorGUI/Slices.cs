using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    public static class Slices
    {
        //Method to rotate centres in an E move (clockwise facing D)
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

        //Method to rotate edges in an E move (clockwise facing D)
        static public Edge[] EEdges(Edge[] edges)
        {
            Edge temp = edges[5];
            temp.Flip();
            edges[6].Flip();
            edges[5] = edges[6];
            Edge temp2 = edges[4];
            temp2.Flip();
            edges[4] = temp;
            temp = edges[7];
            temp.Flip();
            edges[7] = temp2;
            edges[6] = temp;

            return edges;
        }

        //Method to rotate centres in an M move (clockwise facing R)
        static public Centre[] MCentres(Centre[] centres)
        {
            Centre temp = centres[3];
            centres[3] = centres[0];
            Centre temp2 = centres[4];
            centres[4] = temp;
            temp = centres[1];
            centres[1] = temp2;
            centres[0] = temp;

            return centres;
        }

        //Method to rotate edges in an M move (clockwise facing R)
        static public Edge[] MEdges(Edge[] edges)
        {
            Edge temp = edges[0];
            //temp.Flip();
            edges[0] = edges[2];
            //edges[0].Flip();
            Edge temp2 = edges[8];
            edges[8] = temp;
            temp = edges[10];
            edges[10] = temp2;
            edges[2] = temp;

            edges[0].Flip();
            edges[8].Flip();
            edges[10].Flip();
            edges[2].Flip();

            return edges;
        }
    }
}
