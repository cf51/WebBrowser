/*


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;


namespace CW1
{

	public class WebRequest
	{
		public HttpClient client = new HttpClient(); 

		public WebRequest()
        {
			new HttpClient();
        }

		public async Task<string> GetResponse(string url)
        {
			HttpResponseMessage response = await client.getAsync(url);
			var responseContent = await response.Content.ReadAsStringAsync();
			return responseContent; 
        }

		public string ResponseWebRequest(string url)
        {
			// Creating a request for the URL
			WebRequest request = WebRequest.create(url);
			// Getting the response
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			//Getting the stream containing cotent returned by the server 
			Stream dataStream = response.GetResponseStream();

			//Opening the stream using a StreamReader
			StreamReader reader = new StreamReader(dataStream);
			string responseFromServer = reader.ReadToEnd();
			return responseFromServer;
		}
	}
}
*/ 