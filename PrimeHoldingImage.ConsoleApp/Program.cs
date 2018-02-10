using PrimeHoldingImage.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.ConsoleApp
{
    class Program
    {
        private static ImageTools tools = new ImageTools();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("### PrimeHoldingImage - Converter & Resizer ### ");
                Console.WriteLine("\n# Choose an option \n");
                Console.WriteLine("[C]onverter");
                Console.WriteLine("[R]esizer");
                Console.WriteLine("E[x]it\n");

                Console.Write(">> ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "C":
                        Convert();
                        break;

                    case "R":
                        ResizerMenu();
                        break;

                    case "X":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        private static void Convert()
        {
            Console.Clear();
            Console.Write("# Available formats: JPG,GIF,PNG\n\n");
            Console.Write("Source Image (path): ");
            string sourcePath = Console.ReadLine();

            Console.Write("Destination path: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Format: ");
            string type = Console.ReadLine();
            
            try
            {
                tools.Convert(sourcePath, destinatonPath, type);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Source image was not found!");
                Console.ReadKey(true);
            }
            catch (ImageFormatException ife)
            {
                Console.WriteLine(ife.Message);
                Console.ReadKey(true);
            }
        }

        private static void ResizerMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("### Resizer Menu\n");
                Console.WriteLine("\n# Choose an operation\n");
                Console.WriteLine("[C]rop");
                Console.WriteLine("[S]kew");
                Console.WriteLine("[K]eepAspect");
                Console.WriteLine("[B]ack\n");

                Console.Write(">> ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "C":
                        Crop();
                        break;

                    case "S":
                        Skew();
                        break;

                    case "K":
                        KeepAspect();
                        break;

                    case "B":
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        private static void Crop()
        {
            Console.Clear();
            Console.WriteLine("## Crop\n");
            Console.Write("Source Image (path): ");
            string sourcePath = Console.ReadLine();

            Console.Write("Destination path: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Enter expected width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter expected height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Start position X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Start position Y: ");
            int y = int.Parse(Console.ReadLine());

            try
            {
                tools.Resize(sourcePath, destinatonPath, "crop", width, height, x, y);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Source image was not found!");
                Console.ReadKey(true);
            }
            catch (InvalidImageDimensionsException iide)
            {
                Console.WriteLine(iide.Message);
                Console.ReadKey(true);
            }
        }

        private static void Skew()
        {
            Console.Clear();
            Console.WriteLine("## Skew\n");
            Console.Write("Source Image (path): ");
            string sourcePath = Console.ReadLine();

            Console.Write("Destination path: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Enter expected width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter expected height: ");
            int height = int.Parse(Console.ReadLine());

            try
            {
                tools.Resize(sourcePath, destinatonPath, "skew", width, height);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Source image was not found!");
                Console.ReadKey(true);
            }
            catch (InvalidImageDimensionsException iide)
            {
                Console.WriteLine(iide.Message);
                Console.ReadKey(true);
            }
        }

        private static void KeepAspect()
        {
            Console.Clear();
            Console.WriteLine("## KeepAspect\n");
            Console.Write("Source Image (path): ");
            string sourcePath = Console.ReadLine();

            Console.Write("Destination path: ");
            string destinatonPath = Console.ReadLine();

            Console.Write("Enter expected width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter expected height: ");
            int height = int.Parse(Console.ReadLine());

            try
            {
                tools.Resize(sourcePath, destinatonPath, "keepaspect", width, height);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Source image was not found!");
                Console.ReadKey(true);
            }
            catch (InvalidImageDimensionsException iide)
            {
                Console.WriteLine(iide.Message);
                Console.ReadKey(true);
            }
            catch (InvalidAspectRatioException iare)
            {
                Console.WriteLine(iare.Message);
                Console.ReadKey(true);
            }
        }
    }
}
