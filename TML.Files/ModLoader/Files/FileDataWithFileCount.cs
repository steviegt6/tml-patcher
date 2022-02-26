﻿namespace TML.Files.ModLoader.Files
{
    /// <summary>
    ///     Struct containing information for a file's hash, and length, as well as the containing file count.
    /// </summary>
    public readonly struct FileDataWithFileCount
    {
        /// <summary>
        ///     The .tmod file's hash.
        /// </summary>
        public readonly string FileHash;

        /// <summary>
        ///     The length of the .tmod file.
        /// </summary>
        public readonly uint FileLength;

        /// <summary>
        ///     The amount of files stored in the .tmod file.
        /// </summary>
        public readonly int FileCount;

        /// <summary>
        ///     Constructs a new <see cref="FileDataWithFileCount"/> instance.
        /// </summary>
        public FileDataWithFileCount(string hash, uint length, int count)
        {
            FileHash = hash;
            FileLength = length;
            FileCount = count;
        }
    }
}