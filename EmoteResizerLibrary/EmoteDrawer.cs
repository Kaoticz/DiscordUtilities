using System;
using System.Collections.Generic;
using System.Drawing;

namespace EmoteResizerLibrary
{
    public class EmoteDrawer : EmoteGeneral
    {
        /// <summary>
        /// Gets an image with the specified path and name.
        /// </summary>
        /// <param name="sourceDirectory">Path to the folder the image is located in.</param>
        /// <param name="emoteName">Name of the image.</param>
        /// <returns>The image stored in the provided location.</returns>
        public Bitmap GetImage(string sourceDirectory, string emoteName)
            => new Bitmap(sourceDirectory + slash + emoteName);

        /// <summary>
        /// Creates a resized copy of all images from the source directory to the output directory.
        /// </summary>
        /// <param name="emoteNames">A collection of all images to be copied.</param>
        /// <param name="sourceDirectory">Directory where the original images are.</param>
        /// <param name="outputDirectory">Directory where the copies should be saved to.</param>
        public void ProcessEmotes(IEnumerable<string> emoteNames, string sourceDirectory, string outputDirectory)
        {
            foreach (var emoteName in emoteNames)
            {
                var originalEmote = new Bitmap(sourceDirectory + slash + emoteName);
                var resizedEmote = ResizeImage(originalEmote, 48.0, 48.0);
                resizedEmote.Save(outputDirectory + slash + emoteName);

                originalEmote.Dispose();
                resizedEmote.Dispose();
            }
        }

        /// <summary>
        /// Resizes an image while preserving its aspect ratio.
        /// </summary>
        /// <param name="img">Image to be resized.</param>
        /// <param name="maxWidth">Maximum width of the resulting image.</param>
        /// <param name="maxHeight">Maximum height of the resulting image.</param>
        /// <returns>The resized image.</returns>
        public Bitmap ResizeImage(Image img, double maxWidth, double maxHeight)
        {
            var ratio = Math.Min(maxWidth / img.Width, maxHeight / img.Height);
            return new Bitmap(img, (int)(img.Width * ratio), (int)(img.Height * ratio));
        }

        /// <summary>
        /// Gets an image that comforms to the boundaries of an ImageBox.
        /// </summary>
        /// <param name="sourceDirectory">Path to the folder the image is located in.</param>
        /// <param name="emoteName">Name of the image.</param>
        /// <param name="boxWidth">Width of the ImageBox.</param>
        /// <param name="boxHeight">Height of the ImageBox.</param>
        /// <returns>An image that fits in the ImageBox and its old dimensions.</returns>
        public (Bitmap, int, int) GetEmote(string sourceDirectory, string emoteName, int boxWidth, int boxHeight)
        {
            var emote = new Bitmap(sourceDirectory + slash + emoteName);

            if (emote.Width > boxWidth || emote.Height > boxHeight)
            {
                var resizedEmote = ResizeImage(emote, boxWidth, boxHeight);
                var originalWidth = emote.Width;
                var originalHeigth = emote.Height;
                emote.Dispose();

                return (resizedEmote, originalWidth, originalHeigth);
            }
            else
            {
                return (emote, emote.Width, emote.Height);
            }
        }
    }
}