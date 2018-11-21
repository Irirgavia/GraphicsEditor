using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLibrary
{
    public class MyGraphics
    {
        //Get pixel using a location image, stride, coordinates pixel and how many bytes occupied images pixel format
        public unsafe byte[] GetPixel(byte* firstPixelImage, int stride, int indexX, int indexY, int coefficentPixelFormal)
        {
            byte[] pixelValue = new byte[coefficentPixelFormal];

            for (int i = 0; i < pixelValue.Length; i++)
            {
                pixelValue[i] = *(firstPixelImage + indexY * stride + indexX + i);
            }

            return pixelValue;
        }

        //Set pixel using a location image, a array bytes (size = how many bytes occupied images pixel format), stride and coordinates pixel
        public unsafe void SetPixel(byte* firstPixelImage, byte[] pixelValue, int stride, int indexX, int indexY)
        {
            for (int i = 0; i < pixelValue.Length; i++)
            {
                *(firstPixelImage + indexY * stride + indexX + i) = pixelValue[i];
            }
        }

        //Scaling image with Bitmap format using coefficient X and Y
        public Bitmap ScalingImage(Bitmap oldImage, double coefficientX, double coefficientY)
        {
            //Create a new bitmap with scaling parameters entered
            int newWidth = (int)Math.Round(oldImage.Width * coefficientX);
            int newHeight = (int)Math.Round(oldImage.Height * coefficientY);
            PixelFormat newPixelFormat = oldImage.PixelFormat;

            Bitmap newImage = new Bitmap(newWidth, newHeight, newPixelFormat);

            BitmapData newBmpData = newImage.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.ReadWrite, newImage.PixelFormat);
            BitmapData oldBmpData = oldImage.LockBits(new Rectangle(0, 0, oldImage.Width, oldImage.Height), ImageLockMode.ReadWrite, oldImage.PixelFormat);

            //PixelFormat.Format24bppRgb occupies 3 bytes: R, G, B
            //PixelFormat.Format32bppArgb occupies 4 bytes: A, R, G, B
            int coefficentPixelFormal = 4;
            if (oldImage.PixelFormat == PixelFormat.Format24bppRgb) coefficentPixelFormal = 3;

            unsafe
            {
                //Search for images location in memory
                byte* newPtr = (byte*)newBmpData.Scan0.ToPointer();
                byte* oldPtr = (byte*)oldBmpData.Scan0.ToPointer();

                //Loop through the pixels of the new image and find them to the corresponding pixel in the old image
                for (int i = 0; i < newImage.Height; i++)
                {
                    for (int j = 0; j < newImage.Width; j++)
                    {
                        //The coordinates of the corresponding pixel in the old image
                        int indexX = (int)Math.Floor(j / coefficientX);
                        int indexY = (int)Math.Floor(i / coefficientY);

                        byte[] pixelValue = GetPixel(oldPtr, oldBmpData.Stride, indexX * coefficentPixelFormal, indexY, coefficentPixelFormal);
                        SetPixel(newPtr, pixelValue, newBmpData.Stride, j * coefficentPixelFormal, i);

                    }
                }
            }

            newImage.UnlockBits(newBmpData);
            oldImage.UnlockBits(oldBmpData);

            return newImage;
        }

        //Rotate image with Bitmap format using angle regarding point[X, Y]
        public Bitmap RotateImage(Bitmap oldImage, double angle)
        {
            //Create a new bitmap with rotate angle entered
            double angleRadian = angle * Math.PI / 180;
            double cosAngleRadian = Math.Cos(angleRadian);
            double sinAngleRadian = Math.Sin(angleRadian);

            double d = Math.Sqrt(Math.Pow(oldImage.Width, 2) + Math.Pow(oldImage.Height, 2));

            //int newWidth = (int)Math.Round((d * Math.Sin(Math.Atan(oldImage.Height * 1.0 / oldImage.Width) + angleRadian)));
            //int newHeight = (int)Math.Round((d * Math.Sin(Math.Atan(oldImage.Width * 1.0 / oldImage.Height) + angleRadian)));

            int newWidth = (int)d;
            int newHeight = (int)d;

            int dx = (newWidth - oldImage.Width) / 2;
            int dy = (newHeight - oldImage.Height) / 2;

            int pointIndexX = oldImage.Width / 2;
            int pointIndexY = oldImage.Height / 2;

            PixelFormat newPixelFormat = oldImage.PixelFormat;

            Bitmap newImage = new Bitmap(newWidth, newHeight, newPixelFormat);
            newImage.MakeTransparent();

            BitmapData newBmpData = newImage.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.ReadWrite, newImage.PixelFormat);
            BitmapData oldBmpData = oldImage.LockBits(new Rectangle(0, 0, oldImage.Width, oldImage.Height), ImageLockMode.ReadWrite, oldImage.PixelFormat);

            //PixelFormat.Format24bppRgb occupies 3 bytes: R, G, B
            //PixelFormat.Format32bppArgb occupies 4 bytes: A, R, G, B
            int oldCoefficentPixcelFormal = 4;
            if (oldImage.PixelFormat == PixelFormat.Format24bppRgb) oldCoefficentPixcelFormal = 3;

            int newCoefficentPixcelFormal = 4;

            unsafe
            {
                //Search for images location in memory
                byte* newPtr = (byte*)newBmpData.Scan0.ToPointer();
                byte* oldPtr = (byte*)oldBmpData.Scan0.ToPointer();

                for (int i = 0; i < oldImage.Height; i++)
                {
                    for (int j = 0; j < oldImage.Width; j++)
                    {
                        //The coordinates of the corresponding pixel in the new image
                        int newX = (int)Math.Round((j - pointIndexX) * cosAngleRadian + (i - pointIndexY) * sinAngleRadian + pointIndexX + dx);
                        int newY = (int)Math.Round(-(j - pointIndexX) * sinAngleRadian + (i - pointIndexY) * cosAngleRadian + pointIndexY + dy);

                        byte[] pixelValue = GetPixel(oldPtr, oldBmpData.Stride, j * oldCoefficentPixcelFormal, i, oldCoefficentPixcelFormal);
                        if (oldCoefficentPixcelFormal == 3)
                        {
                            Array.Resize(ref pixelValue, 4);
                            pixelValue[3] = 255;
                        }

                        if(newX > 0 && newX < newImage.Width && newY >0 && newY < newImage.Height)
                        {
                            SetPixel(newPtr, pixelValue, newBmpData.Stride, (newX) * newCoefficentPixcelFormal, newY);

                            //for next pixel
                            SetPixel(newPtr, pixelValue, newBmpData.Stride, (newX + 1) * newCoefficentPixcelFormal, newY);
                        }
                    }
                }
            }

            newImage.UnlockBits(newBmpData);
            oldImage.UnlockBits(oldBmpData);

            return newImage;
        }

        public double[] RGBtoHSV(byte[] rgbColor)
        {
            int max = Math.Max(rgbColor[2], Math.Max(rgbColor[1], rgbColor[0]));
            int min = Math.Min(rgbColor[2], Math.Min(rgbColor[1], rgbColor[0]));

            double[] hsvColor = new double[3];
            Color color = Color.FromArgb(Convert.ToInt32(rgbColor[2]), Convert.ToInt32(rgbColor[1]), Convert.ToInt32(rgbColor[0]));

            hsvColor[0] = color.GetHue();
            hsvColor[1] = (max == 0) ? 0 : 1d - (1d * min / max);
            hsvColor[2] = max / 255d;

            return hsvColor;
        }

        public byte[] HSVtoRGB(double[] hsvColor)
        {
            double hue = hsvColor[0];
            double saturation = hsvColor[1];
            double value = hsvColor[2];

            byte[] rgbColor = new byte[3];

            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (v > 255) v = 255;
            if (p > 255) p = 255;
            if (q > 255) q = 255;
            if (t > 255) t = 255;

            if (v < 0) v = 0;
            if (p < 0) p = 0;
            if (q < 0) q = 0;
            if (t < 0) t = 0;

            switch (hi)
            {
                case 0:
                    {
                        rgbColor[2] = Convert.ToByte(v);
                        rgbColor[1] = Convert.ToByte(t);
                        rgbColor[0] = Convert.ToByte(p);
                    }
                    break;

                case 1:
                    {
                        rgbColor[2] = Convert.ToByte(q);
                        rgbColor[1] = Convert.ToByte(v);
                        rgbColor[0] = Convert.ToByte(p);
                    }
                    break;

                case 2:
                    {
                        rgbColor[2] = Convert.ToByte(p);
                        rgbColor[1] = Convert.ToByte(v);
                        rgbColor[0] = Convert.ToByte(t);
                    }
                    break;

                case 3:
                    {
                        rgbColor[2] = Convert.ToByte(p);
                        rgbColor[1] = Convert.ToByte(q);
                        rgbColor[0] = Convert.ToByte(v);
                    }
                    break;
                case 4:
                    {
                        rgbColor[2] = Convert.ToByte(t);
                        rgbColor[1] = Convert.ToByte(p);
                        rgbColor[0] = Convert.ToByte(v);
                    }
                    break;

                default:
                    {
                        rgbColor[2] = Convert.ToByte(v);
                        rgbColor[1] = Convert.ToByte(p);
                        rgbColor[0] = Convert.ToByte(q);
                    }
                    break;
            }
            return rgbColor;
        }

        //Find medium color from array color
        public byte[] GetMediumColor(List<byte[]> rgbColors, int indexCurrentPixel)
        {
            double[] mediumColor = new double[3];
            
            double[] value = new double[rgbColors.Count];

            for (int i = 0; i < rgbColors.Count; i++)
            {
                byte[] rgbColor = new byte[3];
                rgbColor[0] = rgbColors[i][0];
                rgbColor[1] = rgbColors[i][1];
                rgbColor[2] = rgbColors[i][2];

                double[] hsvColor = RGBtoHSV(rgbColor);
                
                value[i] = hsvColor[2];

                if (i == indexCurrentPixel)
                {
                    mediumColor[0] = hsvColor[0];
                    mediumColor[1] = hsvColor[1];
                }
            }
            
            Array.Sort(value);
            
            mediumColor[2] = value[value.Length / 2];

            return HSVtoRGB(mediumColor);
        }

        //Get array pixels from window [windowR,windowR] corecponding point[X, Y]
        public unsafe List<byte[]> GetArrayPixelsFromWindow(byte* ptr, int Stride, int Width, int Height,  int windowR, int indexX, int indexY, int coefficentPixelFormal)
        {
            List<byte[]> arrayPixel = new List<byte[]>();
            byte[] pixelValue = new byte[coefficentPixelFormal];

            //Search for pixels in a pixel window of a impact radius
            for (int iWindow = -windowR; iWindow <= windowR; iWindow++)
            {
                for (int jWindow = -windowR; jWindow <= windowR; jWindow++)
                {
                    if ((indexX + jWindow) >= Width && (indexY + iWindow) >= Height)
                    {
                        pixelValue = GetPixel(ptr, Stride, Math.Abs(indexX - jWindow) * coefficentPixelFormal, Math.Abs(indexY - iWindow), coefficentPixelFormal);
                    }
                    else if ((indexX + jWindow) >= Width)
                    {
                        pixelValue = GetPixel(ptr, Stride, Math.Abs(indexX - jWindow) * coefficentPixelFormal, Math.Abs(indexY + iWindow), coefficentPixelFormal);
                    }
                    else if ((indexY + iWindow) >= Height)
                    {
                        pixelValue = GetPixel(ptr, Stride, Math.Abs(indexX + jWindow) * coefficentPixelFormal, Math.Abs(indexY - iWindow), coefficentPixelFormal);
                    }
                    else
                    {
                        pixelValue = GetPixel(ptr, Stride, Math.Abs(indexX + jWindow) * coefficentPixelFormal, Math.Abs(indexY + iWindow), coefficentPixelFormal);
                    }

                    arrayPixel.Add(pixelValue);
                }
            }

            return arrayPixel;
        }

        public Bitmap MedianFilter(Bitmap oldImage, int windowSize)
        {
            int windowR = windowSize / 2;
            int coefficentPixelFormal = 3;

            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height, oldImage.PixelFormat);

            BitmapData newBmpData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.ReadWrite, newImage.PixelFormat);
            BitmapData oldBmpData = oldImage.LockBits(new Rectangle(0, 0, oldImage.Width, oldImage.Height), ImageLockMode.ReadWrite, oldImage.PixelFormat);
            
            unsafe
            {
                //Search for images location in memory
                byte* newPtr = (byte*)newBmpData.Scan0.ToPointer();
                byte* oldPtr = (byte*)oldBmpData.Scan0.ToPointer();

                for (int i = 0; i < oldImage.Height; i++)
                {
                    for (int j = 0; j < oldImage.Width; j++)
                    {
                        //Search for pixels in a pixel window of a impact radius
                        List<byte[]> arrayPixelWindow = GetArrayPixelsFromWindow(oldPtr, oldBmpData.Stride, oldImage.Width, oldImage.Height, windowR, j, i, coefficentPixelFormal);

                        byte[] mediumPixelValue = GetMediumColor(arrayPixelWindow, windowSize * windowR + windowR);

                        //Setting pixels in a new image with filter
                        SetPixel(newPtr, mediumPixelValue, newBmpData.Stride, j * coefficentPixelFormal, i);
                    }
                }
            }

            newImage.UnlockBits(newBmpData);
            oldImage.UnlockBits(oldBmpData);

            return newImage;
        }

        public Bitmap MonochromeFilter(Bitmap oldImage)
        {
            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height, oldImage.PixelFormat);

            BitmapData newBmpData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.ReadWrite, newImage.PixelFormat);
            BitmapData oldBmpData = oldImage.LockBits(new Rectangle(0, 0, oldImage.Width, oldImage.Height), ImageLockMode.ReadWrite, oldImage.PixelFormat);

            //PixelFormat.Format24bppRgb occupies 3 bytes: R, G, B
            //PixelFormat.Format32bppArgb occupies 4 bytes: A, R, G, B
            int coefficentPixelFormal = 4;
            if (oldImage.PixelFormat == PixelFormat.Format24bppRgb) coefficentPixelFormal = 3;

            unsafe
            {
                //Search for images location in memory
                byte* newPtr = (byte*)newBmpData.Scan0.ToPointer();
                byte* oldPtr = (byte*)oldBmpData.Scan0.ToPointer();

                //Loop through the pixels of the new image and find them to the corresponding pixel in the old image
                for (int i = 0; i < newImage.Height; i++)
                {
                    for (int j = 0; j < newImage.Width; j++)
                    {
                        byte[] pixelValue = GetPixel(oldPtr, oldBmpData.Stride, j * coefficentPixelFormal, i, coefficentPixelFormal);

                        for (int k = 0; k < 3; k++)
                        {
                            pixelValue[k] = (byte)(0.2126 * pixelValue[0] + 0.7152 * pixelValue[1] + 0.0722 * pixelValue[2]);
                        }

                        SetPixel(newPtr, pixelValue, newBmpData.Stride, j * coefficentPixelFormal, i);
                    }
                }
            }

            newImage.UnlockBits(newBmpData);
            oldImage.UnlockBits(oldBmpData);

            return newImage;
        }

        public byte[] MultiplicationMatrix(double[,] convolutionMatrix, List<byte[]> rgbArrayPixelWindow, int coefficentPixelFormal = 3)
        {
            double[] pixelValue = new double[coefficentPixelFormal];

            double div = 0;
            for (int i = 0; i < Math.Sqrt(convolutionMatrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(convolutionMatrix.Length); j++)
                {
                    div += convolutionMatrix[j, i];
                }
            }

            for (int i = 0; i < coefficentPixelFormal; i++)
            {
                pixelValue[i] = 0;
            }

            List<double[]> hsvArrayPixelWindow = new List<double[]>();
            for (int i = 0; i < rgbArrayPixelWindow.Count; i++)
            {
                hsvArrayPixelWindow.Add(RGBtoHSV(rgbArrayPixelWindow[i]));
            }

            for (int index = 0; index < pixelValue.Length; index++)
            {
                for (int i = 0; i < Math.Sqrt(convolutionMatrix.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(convolutionMatrix.Length); j++)
                    {
                        pixelValue[index] += convolutionMatrix[j, i] * hsvArrayPixelWindow[j][index];
                    }
                }
            }

            for (int i = 0; i < pixelValue.Length; i++)
            {
                pixelValue[i] = pixelValue[i] / div;
            }

            return HSVtoRGB(pixelValue);
        }

        public Bitmap СonvolutionFilter(Bitmap oldImage, double[,] convolutionMatrix)
        {
            int coefficentPixelFormal = 3;
            int windowR = 1;

            Bitmap newImage = new Bitmap(oldImage.Width, oldImage.Height, oldImage.PixelFormat);

            BitmapData newBmpData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.ReadWrite, newImage.PixelFormat);
            BitmapData oldBmpData = oldImage.LockBits(new Rectangle(0, 0, oldImage.Width, oldImage.Height), ImageLockMode.ReadWrite, oldImage.PixelFormat);
            
            unsafe
            {
                //Search for images location in memory
                byte* newPtr = (byte*)newBmpData.Scan0.ToPointer();
                byte* oldPtr = (byte*)oldBmpData.Scan0.ToPointer();

                for (int i = 0; i < oldImage.Height; i++)
                {
                    for (int j = 0; j < oldImage.Width; j++)
                    {
                        List<byte[]> arrayPixel = GetArrayPixelsFromWindow(oldPtr, oldBmpData.Stride, oldImage.Width, oldImage.Height, windowR, j, i, coefficentPixelFormal);

                        byte[] pixelValue = MultiplicationMatrix(convolutionMatrix, arrayPixel);

                        //Setting pixels in a new image with filter
                        SetPixel(newPtr, pixelValue, newBmpData.Stride, j * coefficentPixelFormal, i);
                    }
                }
            }

            newImage.UnlockBits(newBmpData);
            oldImage.UnlockBits(oldBmpData);

            return newImage;
        }

        public void DrawImage(Bitmap image, PictureBox pictureBox)
        {
            //Graphics graphics = panel.CreateGraphics();
            //graphics.DrawImage(image, new Point());

            pictureBox.Size = image.Size;
            pictureBox.Image = image;
        }

        public void DrawLine(Bitmap image, PictureBox pictureBox, int indexX0, int indexY0, int indexX1, int indexY1, Color color0, Color color1)
        {
            BitmapData bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);

            //PixelFormat.Format24bppRgb occupies 3 bytes: R, G, B
            //PixelFormat.Format32bppArgb occupies 4 bytes: A, R, G, B
            int coefficentPixelFormal = 4;
            if (image.PixelFormat == PixelFormat.Format24bppRgb) coefficentPixelFormal = 3;

            unsafe
            {
                //Search for images location in memory
                byte* ptr = (byte*)bmpData.Scan0.ToPointer();

                if (image.Width < pictureBox.Width || image.Height < pictureBox.Height)
                {
                    Bitmap newImage = new Bitmap(pictureBox.Width, pictureBox.Height, image.PixelFormat);
                    newImage.MakeTransparent();
                    BitmapData newBmpData = newImage.LockBits(new Rectangle(0, 0, newImage.Width, newImage.Height), ImageLockMode.ReadWrite, newImage.PixelFormat);
                    byte* newPtr = (byte*)newBmpData.Scan0.ToPointer();

                    for (int i = 0; i < image.Height; i++)
                    {
                        for (int j = 0; j < image.Width; j++)
                        {
                            byte[] pixelValue = GetPixel(ptr, bmpData.Stride, j * coefficentPixelFormal, i, coefficentPixelFormal);
                            SetPixel(newPtr, pixelValue, newBmpData.Stride, j * coefficentPixelFormal, i);
                        }
                    }

                    newImage.UnlockBits(newBmpData);
                    image.UnlockBits(bmpData);
                    image = newImage;
                    
                    bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);
                    ptr = (byte*)bmpData.Scan0.ToPointer();
                }

                List<int[]> coordinate = BresenhamAlgorithmLine(indexX0, indexY0, indexX1, indexY1);
                List<Color> interpolationColor = Interpolation(color0, color1, coordinate.Count);

                //Loop through draw line corresponding coordinate and color in the image
                for (int i = 0; i < coordinate.Count; i++)  
                {
                    Color pointColor = interpolationColor[i];

                    byte[] pixelValue = new byte[coefficentPixelFormal];
                    pixelValue[0] = pointColor.B;
                    pixelValue[1] = pointColor.G;
                    pixelValue[2] = pointColor.R;

                    if (coefficentPixelFormal == 4) pixelValue[3] = pointColor.A;

                    SetPixel(ptr, pixelValue, bmpData.Stride, coordinate[i][0] * coefficentPixelFormal, coordinate[i][1]);
                }
            }
            image.UnlockBits(bmpData);
            
            pictureBox.Image = image;
        }

        public void DrawCircle(Bitmap image, PictureBox pictureBox, int indexX0, int indexY0, int radius, Color colorBorder)
        {
            BitmapData bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);

            //PixelFormat.Format24bppRgb occupies 3 bytes: R, G, B
            //PixelFormat.Format32bppArgb occupies 4 bytes: A, R, G, B
            int coefficentPixelFormal = 4;
            if (image.PixelFormat == PixelFormat.Format24bppRgb) coefficentPixelFormal = 3;

            unsafe
            {
                //Search for images location in memory
                byte* ptr = (byte*)bmpData.Scan0.ToPointer();
                
                List<int[]> coordinate = BresenhamAlgorithmCircle(indexX0, indexY0, radius);

                //Loop through draw line corresponding coordinate and color in the image
                for (int i = 0; i < coordinate.Count; i++)
                {
                    byte[] pixelValue = new byte[coefficentPixelFormal];
                    pixelValue[0] = colorBorder.B;
                    pixelValue[1] = colorBorder.G;
                    pixelValue[2] = colorBorder.R;

                    if (coefficentPixelFormal == 4) pixelValue[3] = colorBorder.A;

                    SetPixel(ptr, pixelValue, bmpData.Stride, coordinate[i][0] * coefficentPixelFormal, coordinate[i][1]);
                }
            }
            image.UnlockBits(bmpData);

            pictureBox.Image = image;
        }

        public List<int[]> BresenhamAlgorithmLine(int indexX0, int indexY0, int indexX1, int indexY1)
        {
            List<int[]> coordinate = new List<int[]>();

            int deltaX = Math.Abs(indexX1 - indexX0);
            int deltaY = Math.Abs(indexY1 - indexY0);

            int signX = indexX0 < indexX1 ? 1 : -1;
            int signY = indexY0 < indexY1 ? 1 : -1;

            int error = deltaX - deltaY;

            coordinate.Add(new int[] { indexX1, indexY1 });

            while (indexX0 != indexX1 || indexY0 != indexY1)
            {
                coordinate.Add(new int[] { indexX0, indexY0 });

                int error2 = error * 2;

                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    indexX0 += signX;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    indexY0 += signY;
                }
            }

            return coordinate;
        }

        public List<int[]> BresenhamAlgorithmCircle(int indexX0, int indexY0, int radius)
        {
            List<int[]> coordinate = new List<int[]>();

            int x = 0;
            int y = radius;
            int delta = 1 - 2 * radius;
            int error = 0;
            while (y >= 0)
            {
                coordinate.Add(new int[] { indexX0 + x, indexY0 + y });
                coordinate.Add(new int[] { indexX0 + x, indexY0 - y });
                coordinate.Add(new int[] { indexX0 - x, indexY0 + y });
                coordinate.Add(new int[] { indexX0 - x, indexY0 - y });

                error = 2 * (delta + y) - 1;

                if (delta < 0 && error <= 0)
                {
                    ++x;
                    delta += 2 * x + 1;
                    continue;
                }

                error = 2 * (delta - x) - 1;

                if (delta > 0 && error > 0)
                {
                    --y;
                    delta += 1 - 2 * y;
                    continue;
                }

                ++x;
                delta += 2 * (x - y);
                --y;
            }

            return coordinate;
        }

        public List<Color> Interpolation(Color color0, Color color1, int countPoints)
        {
            List<Color> interpolationColor = new List<Color>();

            for (int i = 0; i < countPoints; i++)
            {
                int R = Convert.ToInt32(color0.R + i * 1.0 * (color1.R - color0.R) / countPoints);
                int G = Convert.ToInt32(color0.G + i * 1.0 * (color1.G - color0.G) / countPoints);
                int B = Convert.ToInt32(color0.B + i * 1.0 * (color1.B - color0.B) / countPoints);

                if (R > 255) R = 255;
                if (G > 255) G = 255;
                if (B > 255) B = 255;

                if (R < 0) R = 0;
                if (G < 0) G = 0;
                if (B < 0) B = 0;

                interpolationColor.Add(Color.FromArgb(R, G, B));
            } 
            
            return interpolationColor;
        }
    }
}
