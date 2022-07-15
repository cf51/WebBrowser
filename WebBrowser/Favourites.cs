using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CW1
{
    class Favourites
    {
        public Favourites() {}


        //Text file that will store the URL's & names used for favourites
        string favFile = @"favourites.txt";

        //List that will store the URL's & names used for favourites
        List<string> favFileList = new List<string>();

        /// <summary>
        /// Creates a favourites file under the condition that the 
        /// file does not already exist, using FileStream to create
        /// the file
        /// </summary>
        public void createFavourites()
        {
            if (!File.Exists(favFile))
            {
                using (FileStream fs = File.Create(favFile)) { };
            }
        }

        /// <summary>
        /// Sets the users favourites by appending the text file with the new urls
        /// using StreamWriter to append the text file
        /// </summary>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <returns> url </returns>
        public string setFavourites(string url, string name)
        {
            using (StreamWriter sw = File.AppendText(favFile))
            {
               sw.WriteLine(name);
                sw.WriteLine(url); 
            }

            return url;
        }

        /// <summary>
        /// Gets the favourites by opening then reading the file to a list
        /// Reversing the list so that the most recent URL is at the top
        /// </summary>
        /// <returns> favFileList </returns>
        public List<string> getFavourites()
        {
            // Opening the file to read from
            string readText = File.ReadAllText(favFile);

            //Reading all of the lines in the file and inserting them into the list
            favFileList = File.ReadAllLines(favFile).ToList();

            // Reversing the list so that the most recent URL is at the top
            favFileList.Reverse();

            //Displaying the list to console **Used for debugging**
            favFileList.ForEach(p => Console.WriteLine(p));

            return favFileList;
        }


    }
}
