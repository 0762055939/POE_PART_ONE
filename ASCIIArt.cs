using System.IO;
using System;
using System.Drawing;

namespace POE_PART_ONE
{
    public class ASCIIArt
    {

            public ASCIIArt()
            {
                // Get the current project directory
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;

                // Adjust the path to remove 'bin\\Debug\\'
                string adjustedPath = projectPath.Replace("bin\\Debug\\", "");

                // Combine the project path with the image file name
                string imagePath = Path.Combine(adjustedPath, "download.jpg");

                // Load and resize the image
                Bitmap image = new Bitmap(imagePath);
                image = new Bitmap(image, new Size(100, 60));

                // Iterate through the image pixels and create ASCII art
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        // Get pixel color and calculate brightness
                        Color pixelColor = image.GetPixel(x, y);
                        int brightness = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                        // Determine the ASCII character based on brightness
                        char asciiChar = brightness > 200 ? '.' :
                                         brightness > 150 ? '*' :
                                         brightness > 100 ? 'O' :
                                         brightness > 50 ? '#' : '@';

                        // Print the ASCII character
                        Console.Write(asciiChar);
                    }

                    // Move to the next line after each row
                    Console.WriteLine();
                }
            }
        }
    }
