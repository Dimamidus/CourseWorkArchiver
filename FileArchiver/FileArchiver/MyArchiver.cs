using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace FileArchiver
{
    public static class MyArchiver
    {
        private static readonly char s_pathSeperator = '\\';
        public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding)
        {
            FileMode mode2;
            FileAccess access;
            FileShare share;
            switch (mode)
            {
                case ZipArchiveMode.Read:
                    mode2 = FileMode.Open;
                    access = FileAccess.Read;
                    share = FileShare.Read;
                    break;
                case ZipArchiveMode.Create:
                    mode2 = FileMode.CreateNew;
                    access = FileAccess.Write;
                    share = FileShare.None;
                    break;
                case ZipArchiveMode.Update:
                    mode2 = FileMode.OpenOrCreate;
                    access = FileAccess.ReadWrite;
                    share = FileShare.None;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("mode");
            }

            FileStream fileStream = null;
            try
            {
                fileStream = File.Open(archiveFileName, mode2, access, share);
                return new ZipArchive(fileStream, mode, leaveOpen: false, entryNameEncoding);
            }
            catch
            {
                fileStream?.Dispose();
                throw;
            }
        }
        public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName)
        {
            if (sourceArchiveFileName == null)
            {
                throw new ArgumentNullException("sourceArchiveFileName");
            }

            ZipArchive source = Open(sourceArchiveFileName, ZipArchiveMode.Read, null);
            source.ExtractToDirectory(destinationDirectoryName);
        }
        public static void CreateFromDirectory(string sourceFileName, string destinationDirectoryName)
        {
            var allfiles = Directory.GetFiles(destinationDirectoryName, "*.*", SearchOption.AllDirectories);
            using (var fileStream = new FileStream(sourceFileName, FileMode.CreateNew))
            using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create, true))
            {
                foreach (var file in allfiles)
                {
                    archive.CreateEntryFromFile(file, Path.GetFileName(file));
                }
            }
        }
        public static void CreateFromFile(string sourceFileName, string destinationDirectoryName)
        {
            using (var fileStream = new FileStream(destinationDirectoryName, FileMode.CreateNew))
            using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create, true))
                archive.CreateEntryFromFile(sourceFileName, Path.GetFileName(sourceFileName));
        }
    }
}
