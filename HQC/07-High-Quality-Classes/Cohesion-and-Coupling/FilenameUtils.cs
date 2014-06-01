namespace CohesionAndCoupling
{
    using System;

    public static class FilenameUtils
    {
        public static string GetFileExtension(string fileName)
        {
            if (fileName == String.Empty)
            {
                throw new ArgumentException("Filename cannot be empty string.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == String.Empty)
            {
                throw new ArgumentException("Filename cannot be empty string.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
