using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace CW1
{
    class History
    {

        //Text file that will store the URL's used for history
        string historyFile = @"history.txt";

        //List that will store the URL's used for history
        List<string> historyFileList = new List<string>();
        //public event EventHandler Click;

        public History() {}

        /// <summary>
        /// Creates a file under the condition that the file does not already
        /// exist. Using FileStream to create a new file.
        /// </summary>
        /// <returns></returns>
        public void createHistory()
        {
            if (!File.Exists(historyFile))
            {
                using (FileStream fs = File.Create(historyFile)) { }; 
            } 
        }

        /// <summary>
        /// Deletes the history by over-writing the file with a blank string
        /// </summary>
        public string deleteHistory()
        {
            using(StreamWriter sw = new StreamWriter(historyFile))
            {
                //File.WriteAllText(historyFile, String.Empty);
                sw.WriteLine(string.Empty);
            }

            return null; 
        }

        /// <summary>
        /// Sets the history by appending the text file with the new url entered by the user
        /// </summary>
        /// <param name="url"></param>
        /// <returns> url </returns>
        public string setHistory(string url)
        {
                using (StreamWriter sw = File.AppendText(historyFile))
                {
                    sw.WriteLine(url);
                }

            return url; 
        }

        /// <summary>
        /// Gets the history by opening then reading the file to a list
        /// Reversing the list so that the most recent URL is at the top
        /// </summary>
        public List<string> getHistory()
        {
            // Opening the file to read from
            string readText = File.ReadAllText(historyFile);

            //Reading all of the lines in the file and inserting them into the list
            historyFileList = File.ReadAllLines(historyFile).ToList();

            // Reversing the list so that the most recent URL is at the top
            historyFileList.Reverse(); 

            //Displaying the list to console **Used for debugging**
            historyFileList.ForEach(p => Console.WriteLine(p));

            return historyFileList;
        }
    }
}
