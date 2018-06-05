using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fault_Line_Algorithm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGenerateMap_Click(object sender, EventArgs e)
        {
            if (CheckInput(txtbxNumOfIterations.Text) == false) // Checks if input is correct
            {
                return;
            }

            int width = 0, height = 0;

            switch (cbxMapResolution.SelectedIndex) // Defines the resolution of the Heightmap
            {
                case 0:
                    pctbxHeightmap.Image = new Bitmap(256, 256);
                    width = 256;
                    height = 256;
                    break;

                case 1:
                    pctbxHeightmap.Image = new Bitmap(512, 512);
                    width = 512;
                    height = 512;
                    break;

                case 2:
                    pctbxHeightmap.Image = new Bitmap(1024, 1024);
                    width = 1024;
                    height = 1024;
                    break;

                case 3:
                    pctbxHeightmap.Image = new Bitmap(2048, 2048);
                    width = 2048;
                    height = 2048;
                    break;
            }

            using (Graphics blankMap = Graphics.FromImage(pctbxHeightmap.Image))
            {
                Rectangle mapSize = new Rectangle(0, 0, width, height);
                blankMap.FillRectangle(Brushes.White, mapSize);
            }

            FaultFractal();
        }


        public void FaultFractal()
        {
            Stopwatch sw = new Stopwatch();

            Bitmap heightMap = new Bitmap(pctbxHeightmap.Image); // Initializes the Heightmap
            int itNum = Convert.ToInt32(txtbxNumOfIterations.Text); // Number of iterations
            Random randomGenerator = new Random();

            int x1 = 0, y1 = 0, x2 = 0, y2 = 0; // Coordinates for points
            double m, b; // m - slope, b - y-intercept
            double m1 = 0, b1 = 0; // m1 - slope, b1 - y-intercept, used for a fault calculated in the previous iteration
            double yF; // Value for y coordinate on a fault line for given x
            double yF1; // Value for y coordinate on a fault for given x, based on the previously generated fault

            int h = 4; // Height displacement factor


            Color c; // Color object for storing RGB data of a pixel
            int grey; // Value for calculating grey color

            for (int j = 0; j < itNum; j++) // Generates itNum fault lines
            {
                // Calculates two random points, from which we will calculate a fault line

                // It is less complex to simply not allow vertical lines to be generated

                // In this case, a vertical line would be the result
                do
                {
                    x1 = randomGenerator.Next(0, heightMap.Width); // Generates the x coordinate of the first point
                    x2 = randomGenerator.Next(0, heightMap.Width); // Generates the y coordinate of the second point
                } while (x1 == x2);

                    y1 = randomGenerator.Next(0, heightMap.Height); // Generates the y coordinate of the first point
                y2 = randomGenerator.Next(0, heightMap.Height); // Generates the y coordinate of the second point

                // Slope-intercept form of a line y = mx + b

                m = (double)(y2 - y1) / (x2 - x1); // It calculates the slope m
                b = (double)y1 - m * x1; // It calculates the y-intercept b
                                         // Having m and b is enough to calculate the points on the fault line for comparison with the rest

                txtbxTestOutput.AppendText("x1 = " + x1.ToString("F4") + " y1 = " + y1.ToString("F4")
                    + " x2 =  " + x2.ToString("F4") + " y2 =  " + y2.ToString("F4") + "\n"
                    + " k = " + m.ToString("F4") + " n = " + b.ToString("F4") + "\n");



                for (int v = 0; v < heightMap.Height; v++) // Goes through the y coordinate of the bitmap
                {
                    for (int u = 0; u < heightMap.Width; u++) // Goes through the x coordinate of the bitmap
                    {
                        yF = m * u + b; // Calculates the yF (fault) coordinate of the current point (u, v)
                        yF1 = m1 * u + b1; // Calculates the yF1 (previous fault) coordinates of the point (u, v)

                        if (v >= yF)
                        {
                            c = heightMap.GetPixel(u, v);
                            grey = c.R - h;

                            if (grey > 0)
                            {
                                heightMap.SetPixel(u, v, Color.FromArgb(grey, grey, grey));
                            }
                        }
                    }
                }

                m1 = m; // Sets the current m to act as a previous m in the next iteration
                b1 = b; // Sets the current b to act as a previous b in the next iteration
            }

            pctbxHeightmap.Image = new Bitmap(heightMap);

            pctbxHeightmap.Refresh();

            sw.Stop();

            MessageBox.Show("Time Elapsed: " + sw.Elapsed.ToString(), "Title",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool CheckInput(string input) // Checks if input is valid in textBoxes
        {
            bool result = Int32.TryParse(input, out int number);

            if (result)
            {
                if (number < 0)
                {
                    MessageBox.Show("Negative integers are not allowed.", "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);

                    return false;
                }
            }

            else
            {
                MessageBox.Show("Error converting to integer.", "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
