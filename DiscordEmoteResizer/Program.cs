using EmoteResizerLibrary;
using System;
using System.IO;

namespace DiscordEmoteResizer
{
    public class Program
    {
        private readonly static EmoteResizer _emoteResizer = new EmoteResizer();
        private static void Main(string[] args)
        {
            string sourcePath = GetValidPath("Enter the source directory: ");  // Get source directory
            string[] emoteNames = CheckForImages(ref sourcePath);                // Check if there is a valid image in the source directory
            string outputPath = GetValidPath("Enter the output directory: ");  // Get output directory
            

            // Resize and save emotes to the output directory
            Console.WriteLine("Working..." + Environment.NewLine);
            _emoteResizer.ProcessEmotes(emoteNames, sourcePath, outputPath);
            Console.WriteLine(emoteNames.Length + " emotes were saved to " + outputPath);
        }

        private static string[] CheckForImages(ref string folderPath)
        {
            while (true)
            {
                var emoteNames = _emoteResizer.FetchEmoteNames(folderPath);

                if (emoteNames.Length == 0)
                {
                    Console.WriteLine("No valid images were found." + Environment.NewLine);
                    folderPath = GetValidPath("Enter the source directory: ");
                }
                else
                {
                    Console.WriteLine(emoteNames.Length + " valid images were found." + Environment.NewLine);
                    return emoteNames;
                }
            }
        }

        private static string GetValidPath(string message)
        {
            while (true)
            {
                Console.Write(message);
                var path = Console.ReadLine();

                if (Directory.Exists(path))
                    return path;
                else
                    message = Environment.NewLine + "Invalid path. Please, enter a valid location: ";
            }
        }
    }
}