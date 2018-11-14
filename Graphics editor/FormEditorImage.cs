using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using GraphicsLibrary;

namespace GraphicsEditor
{
    public partial class FormEditorImage : Form
    {
        Bitmap bitmap;
        MyGraphics myGraphics = new MyGraphics();
        double[,] convolutionMatrix = new double[3, 3];
        
        public FormEditorImage()
        {
            InitializeComponent();

            buttonScaling.Enabled = false;
            textBoxScalingX.Enabled = false;
            textBoxScalingY.Enabled = false;

            textBoxAngle.Enabled = false;
            buttonRotate.Enabled = false;

            buttonMonochromeFilter.Enabled = false;

            buttonMedianFilter.Enabled = false;
            textBoxWindow.Enabled = false;

            buttonСonvolutionFilter.Enabled = false;
            textBox00.Enabled = false;
            textBox01.Enabled = false;
            textBox02.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            radioButtonBlur.Enabled = false;
            radioButtonSharpn.Enabled = false;
            radioButtonLegibility.Enabled = false;
        }        

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFile.FileName;
                bitmap = new Bitmap(fileName);

                labelNameImage.Text = Path.GetFileName(openFile.FileName);
                textBoxScalingX.Enabled = true;
                textBoxScalingY.Enabled = true;

                textBoxAngle.Enabled = true;

                buttonMonochromeFilter.Enabled = true;
                
                textBoxWindow.Enabled = true;

                textBox00.Enabled = true;
                textBox01.Enabled = true;
                textBox02.Enabled = true;
                textBox10.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox20.Enabled = true;
                textBox21.Enabled = true;
                textBox22.Enabled = true;
                radioButtonBlur.Enabled = true;
                radioButtonSharpn.Enabled = true;
                radioButtonLegibility.Enabled = true;

                myGraphics.DrawImage(bitmap, pictureBox1);
            }
        }

        private void buttonScaling_Click(object sender, EventArgs e)
        {
            myGraphics.DrawImage(myGraphics.ScalingImage(bitmap, double.Parse(textBoxScalingX.Text), double.Parse(textBoxScalingY.Text)), pictureBox1);
        }

        private void textBoxScalingX_TextChanged(object sender, EventArgs e)
        {
            double rezalt = 0;

            if (textBoxScalingX.Text != string.Empty &&
                Double.TryParse(textBoxScalingX.Text, out rezalt) &&
                Double.TryParse(textBoxScalingY.Text, out rezalt) &&
                Double.Parse(textBoxScalingX.Text) > 0 &&
                Double.Parse(textBoxScalingY.Text) > 0) 
            {
                buttonScaling.Enabled = true;
            }
            else
            {
                buttonScaling.Enabled = false;
            }
        }

        private void textBoxScalingY_TextChanged(object sender, EventArgs e)
        {
            double rezalt = 0;

            if (textBoxScalingX.Text != string.Empty &&
                Double.TryParse(textBoxScalingX.Text, out rezalt) &&
                Double.TryParse(textBoxScalingY.Text, out rezalt) &&
                Double.Parse(textBoxScalingX.Text) > 0 &&
                Double.Parse(textBoxScalingY.Text) > 0)
            {
                buttonScaling.Enabled = true;
            }
            else
            {
                buttonScaling.Enabled = false;
            }
        }

        private void textBoxAngle_TextChanged(object sender, EventArgs e)
        {
            double rexalt = 0;

            if(textBoxAngle.Text != string.Empty &&
                Double.TryParse(textBoxAngle.Text, out rexalt))
            {
                buttonRotate.Enabled = true;
            }
            else
            {
                buttonRotate.Enabled = false;
            }
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            myGraphics.DrawImage(myGraphics.RotateImage(bitmap, double.Parse(textBoxAngle.Text)), pictureBox1);
        }

        private void buttonMonochromeFilter_Click(object sender, EventArgs e)
        {
            myGraphics.DrawImage(myGraphics.MonochromeFilter(bitmap), pictureBox1);
        }

        private void buttonMedianFilter_Click(object sender, EventArgs e)
        {
            myGraphics.DrawImage(myGraphics.MedianFilter(bitmap, int.Parse(textBoxWindow.Text)), pictureBox1);
        }

        private void buttonСonvolutionFilter_Click(object sender, EventArgs e)
        {
            convolutionMatrix = new double[,]
            {
                { Double.Parse(textBox00.Text), Double.Parse(textBox01.Text), Double.Parse(textBox02.Text)},
                { Double.Parse(textBox10.Text), Double.Parse(textBox11.Text), Double.Parse(textBox12.Text)},
                { Double.Parse(textBox20.Text), Double.Parse(textBox21.Text), Double.Parse(textBox22.Text)},
            };

            myGraphics.DrawImage(myGraphics.СonvolutionFilter(bitmap, convolutionMatrix), pictureBox1);
        }

        private void textBoxWindow_TextChanged(object sender, EventArgs e)
        {
            int rexalt = 0;

            if (textBoxWindow.Text != string.Empty &&
                int.TryParse(textBoxWindow.Text, out rexalt))
            {
                buttonMedianFilter.Enabled = true;
            }
            else
            {
                buttonMedianFilter.Enabled = false;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton == radioButtonBlur)
            {
                textBox00.Text = "1";
                textBox01.Text = "1";
                textBox02.Text = "1";

                textBox10.Text = "1";
                textBox11.Text = "1";
                textBox12.Text = "1";

                textBox20.Text = "1";
                textBox21.Text = "1";
                textBox22.Text = "1";
            }
            else if(radioButton == radioButtonSharpn)
            {
                textBox00.Text = "-1";
                textBox01.Text = "-1";
                textBox02.Text = "-1";

                textBox10.Text = "-1";
                textBox11.Text = "9";
                textBox12.Text = "-1";

                textBox20.Text = "-1";
                textBox21.Text = "-1";
                textBox22.Text = "-1";
            }
            else if (radioButton == radioButtonLegibility)
            {
                textBox00.Text = "-0.1";
                textBox01.Text = "-0.1";
                textBox02.Text = "-0.1";

                textBox10.Text = "-0.1";
                textBox11.Text = "2";
                textBox12.Text = "-0.1";

                textBox20.Text = "-0.1";
                textBox21.Text = "-0.1";
                textBox22.Text = "-0.1";
            }
        }

        private void textBoxMatrix_TextChanged(object sender, EventArgs e)
        {
            double temp = 0;
            if (Double.TryParse(textBox00.Text, out temp) && textBox00.Text != string.Empty && 
                Double.TryParse(textBox01.Text, out temp) && textBox01.Text != string.Empty &&
                Double.TryParse(textBox02.Text, out temp) && textBox02.Text != string.Empty &&
                Double.TryParse(textBox10.Text, out temp) && textBox10.Text != string.Empty &&
                Double.TryParse(textBox11.Text, out temp) && textBox11.Text != string.Empty &&
                Double.TryParse(textBox12.Text, out temp) && textBox12.Text != string.Empty &&
                Double.TryParse(textBox20.Text, out temp) && textBox20.Text != string.Empty &&
                Double.TryParse(textBox21.Text, out temp) && textBox21.Text != string.Empty &&
                Double.TryParse(textBox22.Text, out temp) && textBox22.Text != string.Empty)  
            {
                buttonСonvolutionFilter.Enabled = true;
            }
            else
            {
                buttonСonvolutionFilter.Enabled = false;
            }
        }
    }
}
