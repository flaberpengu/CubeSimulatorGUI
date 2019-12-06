using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSimulatorGUI
{
    public class Corner
    {
        public string[] faces;

        public void IncrementFaces()
        {
            string[] tempFaces = new string[3] { faces[2], faces[0], faces[1] };
            Array.Copy(tempFaces, faces, 3);
        }

        public void DecrementFaces()
        {
            string[] tempFaces = new string[3] { faces[1], faces[2], faces[0] };
            Array.Copy(tempFaces, faces, 3);
        }

        public Corner(string face0, string face1, string face2)
        {
            faces = new string[3] { face0, face1, face2 };
        }
    }
}
