using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Challenge1
{
    class HTML_Reader : IDisposable
    {
        // Flag: Has Dispose already been called?
        bool disposed = false;

        
        private Stream receiveStream = null;
        private StreamReader readStream = null;
        private HttpWebResponse response = null;

        /// <summary>
        /// Returns Html of the given url
        /// </summary>
        /// <param name="urlAddress">url address of the website</param>
        /// <returns>returns html code</returns>
        public string GetHTML(string urlAddress = "https://google.com")
        {


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                receiveStream = response.GetResponseStream();


                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                return data;



            }
            else
            {
                return string.Empty;
            }


        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {

                if (readStream != null)
                {
                    readStream.Close();
                }
                if (receiveStream != null)
                {
                    receiveStream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
            }

            disposed = true;
        }
        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
