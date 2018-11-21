using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsLibrary;

namespace Animation
{
    public partial class FormAnimation : Form
    {
        MyGraphics myGraphics = new MyGraphics();

        Bitmap image;

        Random random = new Random();

        double externalAngle;
        double internalAngle;

        void validationStart()
        {
            double tempDouble = 0;
            int tempInt = 0;

            if (int.TryParse(textBoxTimerInterval.Text, out tempInt) && textBoxTimerInterval.Text != string.Empty &&
                Double.TryParse(textBoxExternalV.Text, out tempDouble) && textBoxExternalV.Text != string.Empty &&
                Double.TryParse(textBoxInternalV.Text, out tempDouble) && textBoxInternalV.Text != string.Empty)
            {
                buttonStart.Enabled = true;
                timer.Interval = int.Parse(textBoxTimerInterval.Text);
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        public FormAnimation()
        {
            InitializeComponent();

            buttonStop.Enabled = false;
            buttonStart.Enabled = false;
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();

            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();

            buttonStop.Enabled = false;
            validationStart();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            timer.Stop();

            buttonStop.Enabled = false;
            validationStart();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Width < panelImage.Width || pictureBox1.Height < panelImage.Height)
            {
                pictureBox1.Width = panelImage.Width - 20;
                pictureBox1.Height = panelImage.Height - 20;
            }

            Color color0 = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            Color color1 = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));

            if (radioButtonSimpleLines.Checked)
            {
                int x0 = random.Next(pictureBox1.Width);
                int x1 = random.Next(pictureBox1.Width);
                int y0 = random.Next(pictureBox1.Height);
                int y1 = random.Next(pictureBox1.Height);

                myGraphics.DrawLine(image, pictureBox1, x0, y0, x1, y1, color0, color1);
                image = (Bitmap)pictureBox1.Image;
            }

            if (radioButtonSpinningLines.Checked)
            {
                image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                //draw circle
                int x0 = pictureBox1.Width / 2;
                int y0 = pictureBox1.Height / 2;

                int externalRadius = 200;
                Color colorBorder = Color.Black;

                myGraphics.DrawCircle(image, pictureBox1, x0, y0, externalRadius, colorBorder);

                //draw radius line
                double externalAngleRotarion = externalAngle + double.Parse(textBoxExternalV.Text);
                externalAngle = externalAngleRotarion;

                if (externalAngle >= 360)
                {
                    externalAngle -= 360;
                }

                int x1 = x0 + Convert.ToInt32(externalRadius * Math.Cos(externalAngleRotarion));
                int y1 = y0 + Convert.ToInt32(externalRadius * Math.Sin(externalAngleRotarion));

                myGraphics.DrawLine(image, pictureBox1, x0, y0, x1, y1, color0, color1);

                //draw additional line
                int internalRadius = 50;
                double internalAngleRoration = internalAngle + double.Parse(textBoxInternalV.Text);
                internalAngle = internalAngleRoration;

                if (internalAngle >= 360)
                {
                    internalAngle -= 360;
                }

                int internalX0 = x1 + Convert.ToInt32(internalRadius * Math.Cos(internalAngleRoration));
                int internalY0 = y1 + Convert.ToInt32(internalRadius * Math.Sin(internalAngleRoration));

                int internalX1 = x1 - Convert.ToInt32(internalRadius * Math.Cos(internalAngleRoration));
                int internalY1 = y1 - Convert.ToInt32(internalRadius * Math.Sin(internalAngleRoration));

                myGraphics.DrawLine(image, pictureBox1, x1, y1, internalX0, internalY0, color0, color1);
                myGraphics.DrawLine(image, pictureBox1, x1, y1, internalX1, internalY1, color0, color1);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            validationStart();
        }
    }
}
