using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace Chapter_10_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryFileName = "ImageData.dat";
            string imageFileName = "SavedImage.png";

            byte[] imageData = DownloadImageStream("http://www.logospike.com/wp-content/uploads/2016/05/Csharp_Logo_03.png");

            //save this image as bytes in file
            SaveImageInBinary(binaryFileName, imageData);


            //now reads the bytes of an image from file
            byte[] readFileData = GetFileBytes(binaryFileName);


            //Now Save Image Bytes as Image File
            SaveImage(imageFileName,readFileData);

            Console.WriteLine("Done Challenge.");
            Console.ReadLine();
        }


        /// <summary>
        /// Download Image stream from given url
        /// </summary>
        /// <param name="url">url from which image stream should be downloaded</param>
        /// <returns>return byte array of image stream downloaded</returns>
        public static byte[] DownloadImageStream(string url = "http://www.logospike.com/wp-content/uploads/2016/05/Csharp_Logo_03.png")
        {
            WebClient client = new WebClient();

            byte[] imageData = client.DownloadData(url);

            return imageData;
        }


        /// <summary>
        /// Save Image in fiven file path
        /// </summary>
        /// <param name="fileName">complete file path</param>
        /// <param name="imageData">image stream bytes array</param>
        public static void SaveImageInBinary(string fileName,byte[] imageData)
        {
            FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            file.Write(imageData, 0, imageData.Length);
            file.Close();
        }

        /// <summary>
        /// Returns File Bytes Array at given path
        /// </summary>
        /// <param name="fileName">complete file path</param>
        /// <returns>byte array of given file</returns>
        public static byte[] GetFileBytes(string fileName)
        {
            FileStream readFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] readImageData = new byte[readFile.Length];
            int bytes = readFile.Read(readImageData, 0, readImageData.Length);
            int index = 0;
            while (bytes < 0)
            {
                readImageData[index] = (byte)readFile.ReadByte();
                index++;

            }
            readFile.Close();

            return readImageData;
        }


        /// <summary>
        /// Save File Bytes at given path as an image
        /// </summary>
        /// <param name="fileName">complete file path</param>
        /// <param name="fileBytes">file bytes of the image</param>
        public static void SaveImage(string fileName,byte[] fileBytes)
        {
            Image img = Image.FromStream(new MemoryStream(fileBytes));
            //save the image in local location
            img.Save(fileName);
        }
    }
}
