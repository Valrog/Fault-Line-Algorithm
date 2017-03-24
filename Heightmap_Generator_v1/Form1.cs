using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; // For Stopwatch


namespace Heightmap_Generator_v1
{
    public partial class Form1 : Form
    {

        // ----------------- ALGORITHM IMPLEMENTATIONS -----------------

        // ----------------- DIAMOND-SQUARE -----------------
        public static void Plasma()
        {

        }

        // ----------------- FAULT LINE -----------------
        public void FaultLine()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            Bitmap bmp = new Bitmap(pctbxHeightmap.Image);
            int itNum = Convert.ToInt32(txtbxNumOfIterations.Text); // Number of iterations received from textBox1

            Random gen = new Random(); // For generating random values

            // It is sufficient to use int rather than double

            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            double m, b; // m - slope, b - y-intercept
            double m1 = 0, b1 = 0; // m1 - slope, b1 - y-intercept, used for a fault calculated in the previous iteration
            double yF; // Value for y coordinate on a fault line for given x
            double yF1; // Value for y coordinate on a fault for given x, based on the previously generated fault

            int h = 1; // Height displacement factor
            //int dh = 4;

            Color c; // Object Color, for getting RGB data out of a pixel
            int grey; // Value for color grey, used in setting a pixel's RGB


            for (int j = 0; j < itNum; j++) // Generates itNum fault lines
            {
                // Calculates two random points, from which we will calculate a fault line

                // It is less complex to simply not allow vertical lines to be generated

                while (x1 == x2) // In this case, a vertical line would be the result
                {
                    x1 = gen.Next(0, bmp.Width); // Generates the x coordinate of the first point
                    x2 = gen.Next(0, bmp.Width); // Generates the y coordinate of the second point
                }

                y1 = gen.Next(0, bmp.Height); // Generates the y coordinate of the first point
                y2 = gen.Next(0, bmp.Height); // Generates the y coordinate of the second point

                // Slope-intercept form of a line y = mx + b

                m = (double)(y2 - y1) / (x2 - x1); // It calculates the slope m
                b = (double)y1 - m * x1; // It calculates the y-intercept b
                // Having m and b is enough to calculate the points on the fault line for comparison with the rest

                /*textBox2.AppendText("x1 = " + x1.ToString("F4") + " y1 = " + y1.ToString("F4")
                    + " x2 =  " + x2.ToString("F4") + " y2 =  " + y2.ToString("F4") + "\n"
                    + " k = " + m.ToString("F4") + " n = " + b.ToString("F4") + "\n");
                 */


                if (j != 0) // We skip the first iteration, because we have no fault as a predecessor
                {
                    for (int v = 0; v < bmp.Height; v++) // Goes through the y coordinate of the bitmap
                    {
                        for (int u = 0; u < bmp.Width; u++) // Goes through the x coordinate of the bitmap
                        {
                            yF = m * u + b; // Calculates the yF (fault) coordinate of the current point (u, v)
                            yF1 = m1 * u + b1; // Calculates the yF1 (previous fault) coordinates of the point (u, v)

                            //if ((v >= yF1 && v <= yF) || (v <= yF1 && v >= yF)) // We change the color of the space between the current fault and the previous fault
                            if(v >= yF)
                            {
                                c = bmp.GetPixel(u, v);
                                grey = c.R - h;

                                if (grey > 0)
                                {
                                    bmp.SetPixel(u, v, Color.FromArgb(grey, grey, grey));
                                }
                            }
                        }
                    }
                }

                m1 = m; // Sets the current m to act as a previous m in the next iteration
                b1 = b; // Sets the current b to act as a previous b in the next iteration

                //if (h > 2)
                  //  h -= dh; // Decreases the displacement factor


            }

            pctbxHeightmap.Image = new Bitmap(bmp);

            pctbxHeightmap.Refresh();

            sw.Stop();

            MessageBox.Show("Time Elapsed: " + sw.Elapsed.ToString(), "Title",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        // ----------------- DIAMOND-SQUARE -----------------
        static public void DiamondSquare()
        {

        }

        // ----------------- PERLIN NOISE -----------------
        static public void PerlinNoise()
        {

        }

        // ----------------- Helper methods -----------------

        static public void CheckInput(string input)
        {
            int number;

            bool result = Int32.TryParse(input, out number);

            if (result)
            {
                if (number < 0)
                {
                    MessageBox.Show("Negative integers are not allowed.", "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Error converting to integer.", "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }


        // ----------------- FORM -----------------

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            switch (cbxAlgorithmSelection.SelectedIndex)
            {
                case 0:
                    // MessageBox.Show("Fault Line Algorithm was chosen.", "Fault Line Algorithm",
                    //  MessageBoxButtons.OK,
                    //  MessageBoxIcon.Information);
                    FaultLine(); // Calls the method FaultLine to generate a heightmap
                    break;

                case 1:
                    MessageBox.Show("Diamond-square Algorithm was chosen.", "Diamond-square Algorithm",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    DiamondSquare(); // Calls the method DiamondSquare to generate a heightmap
                    break;

                case 2:
                    MessageBox.Show("Perlin noise Algorithm was chosen.", "Perlin Noise Algorithm",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    PerlinNoise(); // Calls the method PerlinNoise to generate a heightmap
                    break;

            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumOfIterations_TextChanged(object sender, EventArgs e)
        {
            string input = txtbxNumOfIterations.Text.ToString(); // Gets a string from TextBox

            CheckInput(input);
        }

        private void TxbxDimensions_TextChanged(object sender, EventArgs e)
        {
            string input = txbxDimensions.Text.ToString(); // Gets a string from TextBox

            CheckInput(input);
        }


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFileDialog1 = new OpenFileDialog())
            {
                OpenFileDialog1.Title = "Open Empty Heightmap";
                //OpenFileDialog1.Filter = "TGA Files (*.tga) | *.tga"; // Can't view TGA images in pictureBox
                OpenFileDialog1.Filter = "BMP Files (*.bmp) | *.bmp";

                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pctbxHeightmap.Image = new Bitmap(OpenFileDialog1.FileName);
                }
            }
        }

        private void SaveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            SaveFileDialog1.InitialDirectory = @"C:\";
            SaveFileDialog1.Title = "Save Heightmap";

            //SaveFileDialog1.Filter = "TIFF Files (*.tiff) | *.tiff";

            SaveFileDialog1.CheckPathExists = true;

            //SaveFileDialog1.ShowDialog();

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = SaveFileDialog1.FileName;

                pctbxHeightmap.Image.Save(fileName + ".tiff");
                pctbxHeightmap.Image.Save(fileName + ".raw");
                pctbxHeightmap.Image.Save(fileName + ".jpg");
                pctbxHeightmap.Image.Save(fileName + ".bmp");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
