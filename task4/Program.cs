using System;
using System.IO;

public class ImageStatisticsCalculator
{
    public double Mean { get; private set; }
    public double StandardDeviation { get; private set; }
    public byte MinValue { get; private set; }
    public byte MaxValue { get; private set; }

    public void CalculateStatistics(string imagePath)
    {
        using var stream = new FileStream(imagePath, FileMode.Open);
        using var reader = new BinaryReader(stream);

        // Read the image header
        int width = reader.ReadInt32();
        int height = reader.ReadInt32();
        int bytesPerPixel = reader.ReadInt32();
        int stride = reader.ReadInt32();

        // Verify that the image is an 8-bit grayscale image
        // if (bytesPerPixel != 1)
        // {
        //     throw new ArgumentException("The image must be an 8-bit grayscale image.");
        // }

        // Read the pixel data into a byte array
        byte[] pixels = reader.ReadBytes(width * height * bytesPerPixel);

        // Calculate the mean gray value
        double sum = 0;
        for (int i = 0; i < pixels.Length; i++)
        {
            sum += pixels[i];
        }
        Mean = sum / (width * height);

        // Calculate the standard deviation
        double variance = 0;
        for (int i = 0; i < pixels.Length; i++)
        {
            variance += Math.Pow(pixels[i] - Mean, 2);
        }
        variance /= (width * height);
        StandardDeviation = Math.Sqrt(variance);

        // Find the minimum and maximum gray values
        MinValue = pixels[0];
        MaxValue = pixels[0];
        for (int i = 1; i < pixels.Length; i++)
        {
            if (pixels[i] < MinValue)
            {
                MinValue = pixels[i];
            }
            if (pixels[i] > MaxValue)
            {
                MaxValue = pixels[i];
            }
        }
    }
}
