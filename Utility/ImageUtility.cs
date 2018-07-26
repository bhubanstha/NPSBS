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
			using (FileStream s =new FileStream(path, FileMode.Open))
			{
				return Image.FromStream(s);
			}
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


		public static void SaveImage(Image image, string path)
		{
			try
			{
				image.Save(path);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static Image ChangeOpacity(Image img, float opacity)
		{
			if (img != null)
			{
				Bitmap b = new Bitmap(img.Width, img.Height);
				using (Graphics graphics = Graphics.FromImage(b))
				{
					ColorMatrix colormatrix = new ColorMatrix();
					colormatrix.Matrix33 = opacity;
					using (ImageAttributes imgAttribute = new ImageAttributes())
					{
						imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
						graphics.DrawImage(img, new Rectangle(0, 0, b.Width, b.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
						return b;
					}
				}
			}
			return img;
		}

		public static Image SetWaterMark(Image mainImageFile, Image watermarkImage, float opacity, string contactNo)
		{
			Image newImage = null;
			try
			{
				int x = Screen.PrimaryScreen.WorkingArea.Width;
				int y = Screen.PrimaryScreen.WorkingArea.Height;
				using (mainImageFile = ResizeImage(mainImageFile, x, y))
				{
					using (Image _watermark = ChangeOpacity(watermarkImage,opacity))
					{
						using (Graphics imageGraphics = Graphics.FromImage(mainImageFile))
						{
							 x = (mainImageFile.Width / 2 - watermarkImage.Width / 2);
							 y = (mainImageFile.Height / 2 - watermarkImage.Height / 2-150);
							imageGraphics.DrawImage(_watermark, x, y);
							Font font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
							Color color = Color.Yellow;
							Point pt = new Point(x - 200, mainImageFile.Height - 250);
							SolidBrush brush = new SolidBrush(color);
							string txt = string.Format("Developed by: {0}{1}Contact No.: {2}", "Bhuban Shrestha", Environment.NewLine, contactNo);
							imageGraphics.DrawString(txt, font, brush, pt);
							string path = "tempWaterMarked.jpeg";
							mainImageFile.Save(path, System.Drawing.Imaging.ImageFormat.Png);
							newImage = GetImage(path);
							File.Delete(path);
						}
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return newImage;
		}
	}

	public static class ImageExtension
	{
		public static Image ChangeOpacity(this Image img, float opacity)
		{
			Bitmap bmp = new Bitmap(img.Width, img.Height);
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

		public static Image ResizeImage(this Image image, int width, int height)
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
}
