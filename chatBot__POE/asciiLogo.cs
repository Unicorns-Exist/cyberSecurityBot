using System;
using System.Drawing;

namespace chatBot__POE
{
    internal class asciiLogo
    {

        public void ShowLogo()
        {
            try
            {
                // STEP 1: Get base directory
                string basePath = AppDomain.CurrentDomain.BaseDirectory;

                // STEP 2: Fix path (remove bin\Debug\ and point to image)
                string fullPath = basePath.Replace(@"bin\Debug\", "") + "ASCIIartLogo.png";

                /* DEBUG (optional)
                 Console.WriteLine(fullPath);*/

                // STEP 3: Load image
                Bitmap image = new Bitmap(fullPath);

                // STEP 4: Resize image
                int width = 120;
                int height = 60;
                Bitmap resized = new Bitmap(image, new Size(width, height));

                // STEP 5: ASCII characters (dark → light)
                string asciiChars = "@#S%?*+;:,. ";

                // 🎨 STEP 6: HEADER + BORDER
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==================================================================================================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("           HELLO, WELCOME TO THE CYBERSECURITY AWARENESS BOT. I AM HERE TO HELP YOU STAY SAFE ONLINE.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==================================================================================================================\n");

                // STEP 7: Convert image to ASCII
                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color pixel = resized.GetPixel(x, y);

                        int gray = (pixel.R + pixel.G + pixel.B) / 3;

                        int index = (gray * (asciiChars.Length - 1)) / 255;

                        // 🎨 STEP 8: Add colour effect based on brightness
                        if (gray < 85)
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        else if (gray < 170)
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        else
                            Console.ForegroundColor = ConsoleColor.White;

                        Console.Write(asciiChars[index]);
                    }
                    Console.WriteLine();
                }

                // 🎨 STEP 9: FOOTER BORDER
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n============================================================================================================");

                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not load logo image.");
                Console.WriteLine(ex.Message);
            }
        }

        public void ShowWelcome(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello {name}, stay safe online! ");
            Console.ResetColor();
        }

    }//end of class

}// end of name space