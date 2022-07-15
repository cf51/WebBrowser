using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;


namespace CW1
{
    public partial class CW1 : Form
    {
        // Used for calling other classses
        public HttpClass http = new HttpClass();
        History history = new History();
        Favourites favourites = new Favourites();
        HomePage hpage = new HomePage();
        
        // Declarations 
        public List<Button> buttons = new List<Button>();
        public string homePageUrl;
        public string historyButtonUrl;
        public string favButtonUrl; 

        public CW1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks if the search bar is empty, it then calls the web request method from the http class
        /// to create a new web request using the url that the user has entered in the search bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void goBtn_Click(object sender, EventArgs e)
        {
            
            if (searchBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a URL in the search box");
                return;
            }

            history.createHistory(); 
            string url = searchBox.Text;
            string historyURL = history.setHistory(url); 
            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;
        }

        /// <summary>
        /// Refreshes the browser by creating a new web request 
        /// using the current url 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string url = searchBox.Text;
            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;
        }

        /// <summary>
        /// Displays the home page by calling the getHomePage method of the 
        /// home page file to retreive the current home page url, it then
        /// creates a new web request using that url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeBtn_Click(object sender, EventArgs e)
        {
            string url = hpage.getHomePage(homePageUrl);
            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;
        }

        /// <summary>
        /// EMPTY METHOD (AUTO GENERATED CODE)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBox_TextChanged(object sender, EventArgs e){}

        /// <summary>
        /// EMPTY METHOD (AUTO GENERATED CODE)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayBox_TextChanged(object sender, EventArgs e){}

        /// <summary>
        /// Displays the set home page menu when the 
        /// home page button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setHomeBtn_Click(object sender, EventArgs e)
        {
            homePagePanel.Visible = true; 
        }

        /// <summary>
        /// Sets the form up with the program is loaded, it also sets the 
        /// default home page url to my heriot watt homepage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CW1_Load(object sender, EventArgs e)
        {
            homePagePanel.Visible = false;
            historyPanel.Visible = false;
            showFavPanel.Visible = false;
            favPanel.Visible = false; 
            string url = "https://www2.macs.hw.ac.uk/~cf51/";
            hpage.setHomePage(url);
            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;
        }

        /// <summary>
        /// Sets the users home page by calling the setHomePage method
        /// of the Home Page class with the users entered url as the 
        /// parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setHomePageBtn_Click(object sender, EventArgs e)
        {
            string url = hpage.setHomePage(homePageUrlBox.Text);
            homePagePanel.Visible = false; 
        }

        /// <summary>
        /// EMPTY METHOD (AUTO GENERATED CODE)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homePageUrlBox_TextChanged(object sender, EventArgs e){}

        /// <summary>
        /// Button click event handler, created a web request using the name of the 
        /// button as the url, used for the history requirement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void buttonClick(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button; 
            historyPanel.Visible = false;
            string url = buttonClicked.Text;
            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;

            //** Used for Debugging ** 
            // Console.WriteLine(url);
        }

        /// <summary>
        /// Deletes the users history by calling the deleteHistory method 
        /// of the History class when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteHistoryBtn_Click(object sender, EventArgs e)
        {
            history.deleteHistory();
            historyPanel.Visible = false;
            MessageBox.Show("History Deleted");
        }

        /// <summary>
        /// Closes the history menu when the close button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeHistoryPanel_Click(object sender, EventArgs e)
        {
            historyPanel.Visible = false; 
        }

        /// <summary>
        /// Closes the home page menu when the close button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeHomePagePanel_Click(object sender, EventArgs e)
        {
            homePagePanel.Visible = false; 
        }

        /// <summary>
        /// Dynamically creates buttons and adds them to the history menu panel
        /// creates the buttons text as the url from the historyFileList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void historyButton_Click(object sender, EventArgs e)
        {
            List<string> historyFileList = history.getHistory();
            int top = 55;
            int left = 110;
            for (int i = 0; i < historyFileList.Count; i++)
            {
                Button newButton = new Button();
                buttons.Add(newButton);
                newButton.Width = 250;
                newButton.Left = left;
                newButton.Top = top;
                newButton.Text = historyFileList[i];
                historyButtonUrl = historyFileList[i];
                top += newButton.Height + 2;
                historyPanel.Controls.Add(newButton);
                newButton.Click += buttonClick;

                // ** Used for debugging **
                //Console.WriteLine("Button added");  
            }
            historyPanel.Visible = true;
            history.getHistory();
        }

        /// <summary>
        /// Searches through the history file list looking for a string match
        /// it then returns the index of that match and adds 1 to it, giving the 
        /// previous page url, it then creates a web request with that url as the 
        /// parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            List<string> historyFileList = history.getHistory();
            string url = searchBox.Text;
            var ea = url;
            int indexNextUrl = 0;

            Console.WriteLine();
            foreach (String urlName in historyFileList)
            {

                if (historyFileList.Contains(url))
                {
                    Console.WriteLine("This URL is at Index: "+ historyFileList.FindIndex(ea.StartsWith));
                    indexNextUrl = historyFileList.FindIndex(ea.StartsWith);
                }

                url = historyFileList[indexNextUrl + 1];
            }

            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;
            searchBox.Text = url; 
        }

        /// <summary>
        /// Searches through the history file list looking for a string match
        /// it then returns the index of that match and subtracts 1 from it, giving the 
        /// previous page url, it then creates a web request with that url as the 
        /// parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            List<string> historyFileList = history.getHistory();
            string url = searchBox.Text;
            var ea = url;
            int indexNextUrl = 0;

            Console.WriteLine();
            foreach (String urlName in historyFileList)
            {
                if (historyFileList.Contains(url))
                {
                    Console.WriteLine("This URL is at Index: " + historyFileList.FindIndex(ea.StartsWith));
                    indexNextUrl = historyFileList.FindIndex(ea.StartsWith);
                }
                url = historyFileList[indexNextUrl - 1];
            }

            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;
            searchBox.Text = url;
        }

        /// <summary>
        /// Displays the favourite menu when the favourite button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favBtn_Click(object sender, EventArgs e)
        {
            favPanel.Visible = true; 
        }

        /// <summary>
        /// Sets the users favourites url and name by calling the setFavourites method
        /// in the Favourites class with the content of the two textboxes as the
        /// parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setFavBtn_Click(object sender, EventArgs e)
        {
            favourites.setFavourites(favUrlBox.Text, favNameBox.Text);
        }

        /// <summary>
        /// Closes the favourites panel when the close button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeFavPanel_Click(object sender, EventArgs e)
        {
            favPanel.Visible = false; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void favButtonClick(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            string url = buttonClicked.Text;
            var ea = url;
            int indexNextUrl = 0;
            List<string> favFileList = favourites.getFavourites();
       
            //string name = buttonClicked.Text;
            foreach (String name in favFileList)
            {
                if (favFileList.Contains(url))
                {
                    Console.WriteLine("This URL is at Index: " + favFileList.FindIndex(ea.StartsWith));
                    indexNextUrl = favFileList.FindIndex(ea.StartsWith);
                }
                url = favFileList[indexNextUrl + 1];
                Console.WriteLine("URL INDEX IS " + url);
            }
            
            string response = http.GetResponseWebRequest(url);
            displayBox.Text = response;

            //** Used for Debugging ** 
            // Console.WriteLine(url);
        }
        /// <summary>
        /// Searches through the favorites file list looking for a string match
        /// it then returns the index of that match and adds 1 to it, giving the 
        /// url that is associated with the that name in the list. Then creates a 
        /// web request with that url as the parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showFavBtn_Click(object sender, EventArgs e)
        {
            List<string> favFileList = favourites.getFavourites();

            int top = 50;
            int left = 100;
            for (int i = 1; i < favFileList.Count; i+=2)
            {
                Button newButton = new Button();
                buttons.Add(newButton);
                newButton.Width = 250;
                newButton.Left = left;
                newButton.Top = top;
                newButton.Text = favFileList[i];
                favButtonUrl = favFileList[i];
                top += newButton.Height + 2;
                showFavPanel.Controls.Add(newButton);
                newButton.Click += buttonClick;

                // ** Used for debugging **
                //Console.WriteLine("Button added");  
            }
            
            showFavPanel.Visible = true; 

        }

        /// <summary>
        /// Closes the favourites menu when the close button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeShowFavPanel_Click(object sender, EventArgs e)
        {
            showFavPanel.Visible = false; 
        }
    }
}

