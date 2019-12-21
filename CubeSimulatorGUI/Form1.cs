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
        public Cube mainCube;
        private Solver mySolver;
        public Form1()
        {
            InitializeComponent();
            mainCube = new Cube();
            mainCube.InitialiseCube();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
            mySolver = new Solver();
        }

        //Method to update all faces
        public void UpdateFaces(Edge[] edges, Corner[] corners, Centre[] centres)
        {
            rtbUFace.Clear();
            rtbUFace.Text = (corners[0].faces[0] + "    " + edges[0].faces[0] + "    " + corners[1].faces[0] + "\n" + edges[3].faces[0] + "    " + centres[0].faces[0] + "    " + edges[1].faces[0] + "\n" + corners[3].faces[0] + "    " + edges[2].faces[0] + "    " + corners[2].faces[0]);
            rtbFFace.Clear();
            rtbFFace.Text = (corners[3].faces[1] + "    " + edges[2].faces[1] + "    " + corners[2].faces[2] + "\n" + edges[6].faces[0] + "    " + centres[1].faces[0] + "    " + edges[5].faces[0] + "\n" + corners[7].faces[2] + "    " + edges[10].faces[1] + "    " + corners[6].faces[1]);
            rtbLFace.Clear();
            rtbLFace.Text = (corners[0].faces[1] + "    " + edges[3].faces[1] + "    " + corners[3].faces[2] + "\n" + edges[7].faces[1] + "    " + centres[5].faces[0] + "    " + edges[6].faces[1] + "\n" + corners[4].faces[2] + "    " + edges[11].faces[1] + "    " + corners[7].faces[1]);
            rtbRFace.Clear();
            rtbRFace.Text = (corners[2].faces[1] + "    " + edges[1].faces[1] + "    " + corners[1].faces[2] + "\n" + edges[5].faces[1] + "    " + centres[2].faces[0] + "    " + edges[4].faces[1] + "\n" + corners[6].faces[2] + "    " + edges[9].faces[1] + "    " + corners[5].faces[1]);
            rtbBFace.Clear();
            rtbBFace.Text = (corners[1].faces[1] + "    " + edges[0].faces[1] + "    " + corners[0].faces[2] + "\n" + edges[4].faces[0] + "    " + centres[3].faces[0] + "    " + edges[7].faces[0] + "\n" + corners[5].faces[2] + "    " + edges[8].faces[1] + "    " + corners[4].faces[1]);
            rtbDFace.Clear();
            rtbDFace.Text = (corners[7].faces[0] + "    " + edges[10].faces[0] + "    " + corners[6].faces[0] + "\n" + edges[11].faces[0] + "    " + centres[4].faces[0] + "    " + edges[9].faces[0] + "\n" + corners[4].faces[0] + "    " + edges[8].faces[0] + "    " + corners[5].faces[0]);
        }

        //Method to refine solve algorithm
        private string[] RefineSolve(string[] solve)
        {
            string lastMove = "P";
            List<string> newSolveL = new List<string>();
            for (int i = 0; i < solve.Length-1; i++)
            {
                if (lastMove.Substring(0, 1) != solve[i].Substring(0, 1))
                {
                    if (solve[i].Substring(0, 1) == solve[i + 1].Substring(0, 1))
                    {
                        if (solve[i].Length == 1)
                        {
                            if (solve[i + 1].Length == 1)
                            {
                                string temp = solve[i] + "2";
                                newSolveL.Add(temp);
                                i++;
                                lastMove = temp;
                            }
                            else
                            {
                                if (solve[i + 1].Substring(1, 1) == "'")
                                {
                                    i++;
                                    lastMove = "P";
                                }
                                else
                                {
                                    string temp = solve[i] + "'";
                                    newSolveL.Add(temp);
                                    i++;
                                    lastMove = temp;
                                }
                            }
                        }
                        else
                        {
                            if (solve[i + 1].Length == 1)
                            {
                                if (solve[i].Substring(1, 1) == "2")
                                {
                                    string temp = solve[i] + "'";
                                    newSolveL.Add(temp);
                                    i++;
                                    lastMove = temp;
                                }
                                else
                                {
                                    i++;
                                    lastMove = "P";
                                }
                            }
                            else
                            {
                                if (solve[i].Substring(1, 1) == "2")
                                {
                                    if (solve[i + 1].Substring(1, 1) == "2")
                                    {
                                        i++;
                                        lastMove = "P";
                                    }
                                    else
                                    {
                                        newSolveL.Add(solve[i].Substring(0, 1));
                                        i++;
                                        lastMove = solve[i].Substring(0,1);
                                    }
                                }
                                else
                                {
                                    if (solve[i + 1].Substring(1, 1) == "2")
                                    {
                                        newSolveL.Add(solve[i].Substring(0, 1));
                                        i++;
                                        lastMove = solve[i].Substring(0,1);
                                    }
                                    else
                                    {
                                        string temp = solve[i].Substring(0, 1) + "2";
                                        newSolveL.Add(temp);
                                        i++;
                                        lastMove = temp;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        newSolveL.Add(solve[i]);
                        lastMove = solve[i];
                    }
                }
                else
                {
                    if (lastMove.Length == 1)
                    {
                        if (solve[i].Length == 1)
                        {
                            newSolveL.RemoveAt(newSolveL.Count - 1);
                            string temp = solve[i] + "2";
                            newSolveL.Add(temp);
                            lastMove = temp;
                            i++;
                        }
                        else
                        {
                            if (solve[i].Substring(1,1) == "2")
                            {
                                newSolveL.RemoveAt(newSolveL.Count - 1);
                                string temp = solve[i] + "'";
                                newSolveL.Add(temp);
                                lastMove = temp;
                                i++;
                            }
                            else
                            {
                                newSolveL.RemoveAt(newSolveL.Count - 1);
                                lastMove = "P";
                                i++;
                            }
                        }
                    }
                    else
                    {
                        if (lastMove.Substring(1,1) == "2")
                        {
                            if (solve[i].Length == 1)
                            {
                                newSolveL.RemoveAt(newSolveL.Count - 1);
                                string temp = solve[i] + "'";
                                newSolveL.Add(temp);
                                lastMove = temp;
                                i++;
                            }
                            else
                            {
                                if (solve[i].Substring(1,1) == "2")
                                {
                                    newSolveL.RemoveAt(newSolveL.Count - 1);
                                    lastMove = "P";
                                    i++;
                                }
                                else
                                {
                                    newSolveL.RemoveAt(newSolveL.Count - 1);
                                    newSolveL.Add(solve[i].Substring(0, 1));
                                    lastMove = solve[i].Substring(0, 1);
                                    i++;
                                }
                            }
                        }
                        else
                        {
                            if (solve[i].Length == 1)
                            {
                                newSolveL.RemoveAt(newSolveL.Count - 1);
                                lastMove = "P";
                                i++;
                            }
                            else
                            {
                                if (solve[i].Substring(1, 1) == "2")
                                {
                                    newSolveL.RemoveAt(newSolveL.Count - 1);
                                    newSolveL.Add(solve[i].Substring(0, 1));
                                    lastMove = solve[i].Substring(0, 1);
                                    i++;
                                }
                                else
                                {
                                    newSolveL.RemoveAt(newSolveL.Count - 1);
                                    string temp = solve[i] + "2";
                                    newSolveL.Add(temp);
                                    lastMove = temp;
                                    i++;
                                }
                            }
                        }
                    }
                }
            }
            string[] newSolveA = newSolveL.ToArray();
            return newSolveA;
        }

        //Method to put solve in textbox
        public void UpdateSolve(string[] solve)
        {
            rtbSolve.Clear();
            //solve = RefineSolve(solve);
            foreach (string s in solve)
            {
                rtbSolve.Text += s;
            }
        }

        //Method to be called when the button for a regular R move is pressed
        private void btnRegR_Click(object sender, EventArgs e)
        {
            mainCube.RegularR();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for a regular F move is pressed
        private void btnRegF_Click(object sender, EventArgs e)
        {
            mainCube.RegularF();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for a regular L move is pressed
        private void btnRegL_Click(object sender, EventArgs e)
        {
            mainCube.RegularL();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for a regular U move is pressed
        private void btnRegU_Click(object sender, EventArgs e)
        {
            mainCube.RegularU();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for a regular D move is pressed
        private void btnRegD_Click(object sender, EventArgs e)
        {
            mainCube.RegularD();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for a regular B move is pressed
        private void btnRegB_Click(object sender, EventArgs e)
        {
            mainCube.RegularB();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for an inverse R move is pressed
        private void btnInvR_Click(object sender, EventArgs e)
        {
            mainCube.InverseR();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for an inverse U move is pressed
        private void btnInvU_Click(object sender, EventArgs e)
        {
            mainCube.InverseU();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for an inverse L move is pressed
        private void btnInvL_Click(object sender, EventArgs e)
        {
            mainCube.InverseL();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for an inverse F move is pressed
        private void btnInvF_Click(object sender, EventArgs e)
        {
            mainCube.InverseF();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for an inverse B move is pressed
        private void btnInvB_Click(object sender, EventArgs e)
        {
            mainCube.InverseB();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to be called when the button for an inverse D move is pressed
        private void btnInvD_Click(object sender, EventArgs e)
        {
            mainCube.InverseD();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        //Method to reset cube back to default state
        private void btnReset_Click(object sender, EventArgs e)
        {
            mainCube.InitialiseCube();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
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
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        private void btnRegZ_Click(object sender, EventArgs e)
        {
            mainCube.RegularZ();
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
        }

        private void btnSolver_Click(object sender, EventArgs e)
        {
            mySolver.InitialiseForSolve();
            List<string> movesToPerform = new List<string>();
            movesToPerform = mySolver.SolveCube(movesToPerform);
            string[] aMovesToPerform = movesToPerform.ToArray();
            //MessageBox.Show("Executed ToArray()");
            //aMovesToPerform = movesToPerform.ToArray();
            //for (int i = 0; i < movesToPerform.Count; i++)
            //{
            //    aMovesToPerform[i] = movesToPerform[i];
            //}
            //MessageBox.Show(movesToPerform[4]);
            //MessageBox.Show(aMovesToPerform[4]);
            mainCube.GiveScramble(aMovesToPerform);
            UpdateFaces(mainCube.edges, mainCube.corners, mainCube.centres);
            UpdateSolve(aMovesToPerform);
        }
    }
}
//COLOURS
//3D RENDER?
//CREATE d' MOVE -- CHANGE d' CASE FROM d3 TO d'