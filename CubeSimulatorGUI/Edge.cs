using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    class Edge : Piece
    {
        public void Flip()
        {
            string temp = faces[1];
            faces[1] = faces[0];
            faces[0] = temp;
        }
        public Edge(string face1, string face2) : base(face1, face2)
        {
        }
    }
}
