using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;

namespace CW1
{
  
    public class HttpClass
    {
        public HttpClient client = new HttpClient();
        public WebResponse response;
        public string errorMessage = null;

        public HttpClass()
        {
            new HttpClient();
        }

        /// <summary>
        /// Get the response, uses HttpResponseMessage to generate the 
        /// response with http client
        /// </summary>
        /// <param name="url"></param>
        /// <returns> response content </returns>
        public async Task<string> GetResponse(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }

      
        /// <summary>
        ///  Creates a request for the url which will be in the 
        ///  search box on windows forms.
        ///  uses .Message to deal with any error codes that come
        ///  from the exception
        /// </summary>
        /// <param name="url"></param>
        /// <returns> responseFromServer </returns>
        public string GetResponseWebRequest(string url)
        {
            string responseFromServer = null;
            try
            {
                WebRequest request = WebRequest.Create(url);    // Creating a request for the URL
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();  //Getting the response
                //Getting the stream containing cotent returned by the server
                Stream dataStream = response.GetResponseStream();
                //Opening the stream using a StreamReader
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
         
            }
            catch (WebException e)
            {
                errorMessage = (e.Message);
                responseFromServer = (e.Message);
            }
     
            return responseFromServer; 
        }

    }
}
