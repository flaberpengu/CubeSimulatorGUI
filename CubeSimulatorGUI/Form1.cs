using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CubeSimulatorGUI
{
    public partial class Form1 : Form
    {
        private Cube mainCube;
        public Form1()
        {
            InitializeComponent();
            mainCube = new Cube();
            mainCube.InitialiseCube();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to update all faces
        public void UpdateFaces(string[][] edges, Corner[] corners)
        {
            rtbUFace.Clear();
            rtbUFace.Text = (corners[0].faces[0] + "    " + edges[0][0] + "    " + corners[1].faces[0] + "\n" + edges[3][0] + "    " + "W" + "    " + edges[1][0] + "\n" + corners[3].faces[0] + "    " + edges[2][0] + "    " + corners[2].faces[0]);
            rtbFFace.Clear();
            rtbFFace.Text = (corners[3].faces[1] + "    " + edges[2][1] + "    " + corners[2].faces[2] + "\n" + edges[6][0] + "    " + "G" + "    " + edges[5][0] + "\n" + corners[7].faces[2] + "    " + edges[10][1] + "    " + corners[6].faces[1]);
            rtbLFace.Clear();
            rtbLFace.Text = (corners[0].faces[1] + "    " + edges[3][1] + "    " + corners[3].faces[2] + "\n" + edges[7][1] + "    " + "O" + "    " + edges[6][1] + "\n" + corners[4].faces[2] + "    " + edges[11][1] + "    " + corners[7].faces[1]);
            rtbRFace.Clear();
            rtbRFace.Text = (corners[2].faces[1] + "    " + edges[1][1] + "    " + corners[1].faces[2] + "\n" + edges[5][1] + "    " + "R" + "    " + edges[4][1] + "\n" + corners[6].faces[2] + "    " + edges[9][1] + "    " + corners[5].faces[1]);
            rtbBFace.Clear();
            rtbBFace.Text = (corners[1].faces[1] + "    " + edges[0][1] + "    " + corners[0].faces[2] + "\n" + edges[4][0] + "    " + "B" + "    " + edges[7][0] + "\n" + corners[5].faces[2] + "    " + edges[8][1] + "    " + corners[4].faces[1]);
            rtbDFace.Clear();
            rtbDFace.Text = (corners[7].faces[0] + "    " + edges[10][0] + "    " + corners[6].faces[0] + "\n" + edges[11][0] + "    " + "Y" + "    " + edges[9][0] + "\n" + corners[4].faces[0] + "    " + edges[8][0] + "    " + corners[5].faces[0]);
        }

        //Method to be called when the button for a regular R move is pressed
        private void btnRegR_Click(object sender, EventArgs e)
        {
            mainCube.RegularR();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for a regular F move is pressed
        private void btnRegF_Click(object sender, EventArgs e)
        {
            mainCube.RegularF();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for a regular L move is pressed
        private void btnRegL_Click(object sender, EventArgs e)
        {
            mainCube.RegularL();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for a regular U move is pressed
        private void btnRegU_Click(object sender, EventArgs e)
        {
            mainCube.RegularU();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for a regular D move is pressed
        private void btnRegD_Click(object sender, EventArgs e)
        {
            mainCube.RegularD();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for a regular B move is pressed
        private void btnRegB_Click(object sender, EventArgs e)
        {
            mainCube.RegularB();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for an inverse R move is pressed
        private void btnInvR_Click(object sender, EventArgs e)
        {
            mainCube.InverseR();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for an inverse U move is pressed
        private void btnInvU_Click(object sender, EventArgs e)
        {
            mainCube.InverseU();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for an inverse L move is pressed
        private void btnInvL_Click(object sender, EventArgs e)
        {
            mainCube.InverseL();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for an inverse F move is pressed
        private void btnInvF_Click(object sender, EventArgs e)
        {
            mainCube.InverseF();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for an inverse B move is pressed
        private void btnInvB_Click(object sender, EventArgs e)
        {
            mainCube.InverseB();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to be called when the button for an inverse D move is pressed
        private void btnInvD_Click(object sender, EventArgs e)
        {
            mainCube.InverseD();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }

        //Method to reset cube back to default state
        private void btnReset_Click(object sender, EventArgs e)
        {
            mainCube.InitialiseCube();
            UpdateFaces(mainCube.edges, mainCube.corners);
            rtbScramble.Clear();
        }

        //Method to update the scramble on the page
        private void UpdateScramble()
        {
            rtbScramble.Clear();
            for (int i = 0; i < mainCube.scramble.Length; i++)
            {
                rtbScramble.AppendText(mainCube.scramble[i] + " ");
            }
        }

        //Method to get scramble and display it
        private void btnScramble_Click(object sender, EventArgs e)
        {
            mainCube.GetScramble();
            UpdateScramble();
            UpdateFaces(mainCube.edges, mainCube.corners);
        }
    }
}
//SORT MOVES OUT - change temp[i], make temp a list of corners