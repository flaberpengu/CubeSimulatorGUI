using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    public class Piece
    {
        public string[] faces;
        public Piece(string gFace)
        {
            faces = new string[1] { gFace };
        }

        public Piece(string gFace1, string gFace2)
        {
            faces = new string[2] { gFace1, gFace2 };
        }

        public Piece(string gFace1, string gFace2, string gFace3)
        {
            faces = new string[3] { gFace1, gFace2, gFace3 };
        }
    }
}
