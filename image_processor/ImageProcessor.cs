using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

/// <summary>ImageProcessor Class</summary>
class ImageProcessor
{
    /// <summary>Method that inverts an image’s color</summary>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, (currentFile) => {
            string invertedImageName = Path.GetFileNameWithoutExtension(currentFile) + "_inverse" + Path.GetExtension(currentFile);
            // Create a new bitmap.
            Bitmap bmp = new Bitmap(currentFile);

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes  = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // Invert every value 255 - byte value.  
            for (int counter = 0; counter < rgbValues.Length; counter++)
                rgbValues[counter] = (byte) (255 - rgbValues[counter]);

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            // Save the modified bitmap
            bmp.Save(invertedImageName);
        });
    }

    /// <summary>Method that converts each image to grayscale</summary>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, (currentFile) => {
            string grayScaleImageName = Path.GetFileNameWithoutExtension(currentFile) + "_grayscale" + Path.GetExtension(currentFile);
            // Create a new bitmap.
            Bitmap bmp = new Bitmap(currentFile);

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes  = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // Set RGB values to grayscale.  
            for (int counter = 2; counter < rgbValues.Length; counter += 3)
            {
                int grayscale = (int)(.11 * rgbValues[counter - 2] + .59 * rgbValues[counter - 1] + .3 * rgbValues[counter]);
                rgbValues[counter - 2] = (byte) grayscale;
                rgbValues[counter - 1] = (byte) grayscale;
                rgbValues[counter] = (byte) grayscale;
            }                

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            // Save the modified bitmap
            bmp.Save(grayScaleImageName);
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
