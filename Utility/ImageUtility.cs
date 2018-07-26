using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Utility
{
    public class ImageUtility
    {
        public enum ImageFormat
        {
            bmp,
            jpeg,
            png,
            unknown
        }

        public static ImageFormat GetImageFormat(byte[] bytes)
        {
            var bmp = Encoding.ASCII.GetBytes("BM");
            var png = new byte[] { 137, 80, 78, 71 };
            var jpeg = new byte[] { 255, 216, 255, 224 };
            var jpeg2 = new byte[] { 255, 216, 255, 225 };
            if (bmp.SequenceEqual(bytes.Take(bmp.Length)))
                return ImageFormat.bmp;

            if (png.SequenceEqual(bytes.Take(png.Length)))
                return ImageFormat.png;

            if (jpeg.SequenceEqual(bytes.Take(jpeg.Length)))
                return ImageFormat.jpeg;

            if (jpeg2.SequenceEqual(bytes.Take(jpeg2.Length)))
                return ImageFormat.jpeg;

            return ImageFormat.unknown;
        }

        public static Image GetImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png; *.jpg; *.jpeg; *.bmp";
                ofd.Title = "Select Image";
                ofd.Multiselect = false;
                ofd.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return GetImage(ofd.FileName);
                }
                return null;
            }
        }

        public static Image GetImage(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                Image image = Image.FromStream(fileStream);
                return image;
            }
            //FileInfo fileInfo = new FileInfo(path);
            //byte[] data = new byte[fileInfo.Length];
            //using (FileStream fs = fileInfo.OpenRead())
            //{
            //    fs.Read(data, 0, data.Length);
            //}
            //ImageFormat format = GetImageFormat(data);
            //if (format != ImageFormat.unknown)
            //{
            //    using (MemoryStream ms = new MemoryStream(data))
            //    {
            //        return  Image.FromStream(ms);
            //    }
            //}
            //return null;
        }

        public static void SaveImage(Image image, string path)
        {
            try
            {
                image.Save(path);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Image ChangeOpacity(Image img, float opacity)
        {
            if (img != null)
            {
                Image bmp = new Bitmap(img.Width, img.Height);
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    ColorMatrix colormatrix = new ColorMatrix();
                    colormatrix.Matrix33 = opacity;
                    using (ImageAttributes imgAttribute = new ImageAttributes())
                    {
                        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Any);
                        graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
                    }
                }
                return bmp;
            }
            return img;
        }

        public static Image SetWaterMark(Image mainImageFile, Image watermarkImage, float opacity, bool showDeveloperInfo, string contactNo)
        {
            Image newImage = null;
            try
            {
                int width = Screen.PrimaryScreen.WorkingArea.Width;
                int height = Screen.PrimaryScreen.WorkingArea.Height;
                Image img = mainImageFile; // ResizeImage(mainImageFile, width, height);
                using (mainImageFile)
                {
                    using (watermarkImage)
                    {
                        Image _watermark = ChangeOpacity(watermarkImage, opacity);
                        using (Graphics imageGraphics = Graphics.FromImage(mainImageFile))
                        {
                            using (TextureBrush watermarkBrush = new TextureBrush(_watermark))
                            {
                                int x = (mainImageFile.Width / 2 - watermarkImage.Width / 2);
                                int y = (mainImageFile.Height / 2 - watermarkImage.Height / 2);

                                watermarkBrush.TranslateTransform(x, y);
                                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                                string path = Environment.SpecialFolder.MyPictures + "tempWaterMarked.jpeg";

                                Font font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
                                Color color = Color.Yellow;
                                Point pt = new Point(x-200, watermarkImage.Height - 250);
                                SolidBrush brush = new SolidBrush(color);
                                string txt = string.Format("Developed by: {0}{1}Contact No.: {2}", "Bhuban Shrestha", Environment.NewLine, contactNo);
                                imageGraphics.DrawString(txt, font, brush, pt);
                                //imageGraphics.DrawImage(_watermark, new Point(x, y));
                                mainImageFile.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                                newImage = new Bitmap(img); // GetImage(path);
                            }
                        }
                    }
                }
                img.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return newImage;
        }

        public static Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }

    public static class ImageExtension
    {
        public static Image ChangeOpacity(this Image img, float opacity)
        {
            Image bmp = new Bitmap(img.Width, img.Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                ColorMatrix colormatrix = new ColorMatrix();
                colormatrix.Matrix33 = opacity;
                using (ImageAttributes imgAttribute = new ImageAttributes())
                {
                    imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
                }
            }
            return bmp;
        }

        public static void SaveImage(this Image img, string path)
        {
            try
            {
                img.Save(path);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
