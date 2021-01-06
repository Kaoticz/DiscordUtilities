using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmoteResizerLibrary
{
    public abstract class EmoteGeneral
    {
        private readonly string[] _validExtensions = { ".png", ".jpg", ".gif" };
        protected readonly char slash = (Environment.OSVersion.Platform < PlatformID.Unix) ? '\\' : '/';

        /// <summary>
        /// Gets the name of all valid images in the specified directory.
        /// </summary>
        /// <param name="directoryPath">The directory where the images are located.</param>
        /// <returns>A collection of emote names with their corresponding extensions.</returns>
        public IEnumerable<string> FetchEmoteNames(string directoryPath)
        {
            return Directory.GetFiles(directoryPath)
                .Where(file => _validExtensions.Contains(Path.GetExtension(file)))
                .Select(Path.GetFileName);
        }
    }
}
