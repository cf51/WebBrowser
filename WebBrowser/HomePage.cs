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
    class HomePage
    {
        // Text file that will store the home page URL
        string homePageFile = @"homePage.txt";

        public HomePage(){}

        /// <summary>
        /// Sets the users homepage by getting the URL from the text box
        /// Creating a file to store the URL then writing that URL to the file
        /// </summary>
        /// <param name="homePageUrl"></param>
        /// <returns> null </returns>
        public string setHomePage(string homePageUrl)
        {
            using (FileStream fs = File.Create(homePageFile)){}
            using (StreamWriter sw = new StreamWriter(homePageFile))
            {
                sw.WriteLine(homePageUrl);               
            }

            return null;
        }

        /// <summary>
        /// Gets the users home page by using a stream reader and reading the lines of the 
        /// homePageUrl file 
        /// </summary>
        /// <param name="homePageUrl"></param>
        /// <returns> homePageUrl </returns>
        public string getHomePage(string homePageUrl)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(homePageFile))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    homePageUrl = line;

                    // **Used for debugging **
                    Console.WriteLine(line); 

                }
            }
            return homePageUrl;
        }
    }
}
