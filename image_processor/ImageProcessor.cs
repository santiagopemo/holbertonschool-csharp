using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

/// <summary>ImageProcessor Class</summary>
class ImageProcessor
{
    /// <summary>Method that inverts an image’s color</summary>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, (currentFile) => {
            string invertedImageName = Path.GetFileNameWithoutExtension(currentFile) + "_inverse" + Path.GetExtension(currentFile);
            Bitmap imageBitmap = new Bitmap(currentFile);

            for (int x = 0; x < imageBitmap.Width; x++)
            {
                for (int y = 0; y < imageBitmap.Height; y++)
                {
                    Color pixel = imageBitmap.GetPixel(x, y);
                    imageBitmap.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            imageBitmap.Save(invertedImageName);
        });
    }

    /// <summary>Method that converts each image to grayscale</summary>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, (currentFile) => {
            string grayscaleImageName = Path.GetFileNameWithoutExtension(currentFile) + "_grayscale" + Path.GetExtension(currentFile);
            Bitmap imageBitmap = new Bitmap(currentFile);

            for (int x = 0; x < imageBitmap.Width; x++)
            {
                for (int y = 0; y < imageBitmap.Height; y++)
                {
                    Color originalPixel = imageBitmap.GetPixel(x, y);
                    int grayscale = (int)((originalPixel.R * .3) + (originalPixel.G * .59) + (originalPixel.B * .11));
                    Color grayscalePixel = Color.FromArgb(grayscale, grayscale, grayscale);
                    imageBitmap.SetPixel(x, y, grayscalePixel);
                }
            }
            imageBitmap.Save(grayscaleImageName);
        });
    }

    /// <summary>Method that reduces each image to only black and white values, based on a given threshold</summary>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, (currentFile) => {
            string bwImageName = Path.GetFileNameWithoutExtension(currentFile) + "_bw" + Path.GetExtension(currentFile);
            Bitmap imageBitmap = new Bitmap(currentFile);

            for (int x = 0; x < imageBitmap.Width; x++)
            {
                for (int y = 0; y < imageBitmap.Height; y++)
                {
                    Color originalPixel = imageBitmap.GetPixel(x, y);
                    double luminance = ((originalPixel.R * .2126) + (originalPixel.G * .7152) + (originalPixel.B * .0722));
                    if (luminance >= threshold)
                        imageBitmap.SetPixel(x, y, Color.White);
                    else
                        imageBitmap.SetPixel(x, y, Color.Black);
                }
            }
            imageBitmap.Save(bwImageName);
        });
    }

    /// <summary>Method that creates a thumbnail image based on a given height</summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        Parallel.ForEach(filenames, (currentFile) => {
            string thumbnailImageName = Path.GetFileNameWithoutExtension(currentFile) + "_th" + Path.GetExtension(currentFile);
            Bitmap imageBitmap = new Bitmap(currentFile);
            Image thumbnail = imageBitmap.GetThumbnailImage(((imageBitmap.Width * height) / imageBitmap.Height), height, () => false, IntPtr.Zero);
            thumbnail.Save(thumbnailImageName);
        });
    }
}
