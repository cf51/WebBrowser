
namespace CW1
{
    partial class CW1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBox = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.setHomeBtn = new System.Windows.Forms.Button();
            this.homePagePanel = new System.Windows.Forms.Panel();
            this.setHomePageBtn = new System.Windows.Forms.Button();
            this.homePageUrlBox = new System.Windows.Forms.TextBox();
            this.closeHomePagePanel = new System.Windows.Forms.Button();
            this.deleteHistoryBtn = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.closeHistoryPanel = new System.Windows.Forms.Button();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.favBtn = new System.Windows.Forms.Button();
            this.favPanel = new System.Windows.Forms.Panel();
            this.favUrlBox = new System.Windows.Forms.TextBox();
            this.setFavBtn = new System.Windows.Forms.Button();
            this.closeFavPanel = new System.Windows.Forms.Button();
            this.favNameBox = new System.Windows.Forms.TextBox();
            this.showFavPanel = new System.Windows.Forms.Panel();
            this.closeShowFavPanel = new System.Windows.Forms.Button();
            this.showFavBtn = new System.Windows.Forms.Button();
            this.homePagePanel.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.favPanel.SuspendLayout();
            this.showFavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(247, 12);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(584, 23);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(845, 12);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 25);
            this.goBtn.TabIndex = 1;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(926, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 25);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 25);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "<<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(58, 12);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(40, 25);
            this.forwardBtn.TabIndex = 4;
            this.forwardBtn.Text = ">>";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(12, 53);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(1632, 742);
            this.displayBox.TabIndex = 5;
            this.displayBox.TextChanged += new System.EventHandler(this.displayBox_TextChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(104, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(40, 25);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "🗘";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // setHomeBtn
            // 
            this.setHomeBtn.Location = new System.Drawing.Point(1604, 12);
            this.setHomeBtn.Name = "setHomeBtn";
            this.setHomeBtn.Size = new System.Drawing.Size(40, 25);
            this.setHomeBtn.TabIndex = 8;
            this.setHomeBtn.Text = "⌂";
            this.setHomeBtn.UseVisualStyleBackColor = true;
            this.setHomeBtn.Click += new System.EventHandler(this.setHomeBtn_Click);
            // 
            // homePagePanel
            // 
            this.homePagePanel.Controls.Add(this.setHomePageBtn);
            this.homePagePanel.Controls.Add(this.homePageUrlBox);
            this.homePagePanel.Controls.Add(this.closeHomePagePanel);
            this.homePagePanel.Location = new System.Drawing.Point(771, 95);
            this.homePagePanel.Name = "homePagePanel";
            this.homePagePanel.Size = new System.Drawing.Size(481, 84);
            this.homePagePanel.TabIndex = 9;
            // 
            // setHomePageBtn
            // 
            this.setHomePageBtn.Location = new System.Drawing.Point(171, 36);
            this.setHomePageBtn.Name = "setHomePageBtn";
            this.setHomePageBtn.Size = new System.Drawing.Size(138, 36);
            this.setHomePageBtn.TabIndex = 1;
            this.setHomePageBtn.Text = "Set Home Page";
            this.setHomePageBtn.UseVisualStyleBackColor = true;
            this.setHomePageBtn.Click += new System.EventHandler(this.setHomePageBtn_Click);
            // 
            // homePageUrlBox
            // 
            this.homePageUrlBox.Location = new System.Drawing.Point(19, 8);
            this.homePageUrlBox.Name = "homePageUrlBox";
            this.homePageUrlBox.Size = new System.Drawing.Size(422, 22);
            this.homePageUrlBox.TabIndex = 0;
            this.homePageUrlBox.TextChanged += new System.EventHandler(this.homePageUrlBox_TextChanged);
            // 
            // closeHomePagePanel
            // 
            this.closeHomePagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.closeHomePagePanel.ForeColor = System.Drawing.Color.Red;
            this.closeHomePagePanel.Location = new System.Drawing.Point(447, 3);
            this.closeHomePagePanel.Name = "closeHomePagePanel";
            this.closeHomePagePanel.Size = new System.Drawing.Size(31, 27);
            this.closeHomePagePanel.TabIndex = 13;
            this.closeHomePagePanel.Text = "X";
            this.closeHomePagePanel.UseVisualStyleBackColor = false;
            this.closeHomePagePanel.Click += new System.EventHandler(this.closeHomePagePanel_Click);
            // 
            // deleteHistoryBtn
            // 
            this.deleteHistoryBtn.Location = new System.Drawing.Point(238, 555);
            this.deleteHistoryBtn.Name = "deleteHistoryBtn";
            this.deleteHistoryBtn.Size = new System.Drawing.Size(132, 34);
            this.deleteHistoryBtn.TabIndex = 1;
            this.deleteHistoryBtn.Text = "Delete History";
            this.deleteHistoryBtn.UseVisualStyleBackColor = true;
            this.deleteHistoryBtn.Click += new System.EventHandler(this.deleteHistoryBtn_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(1007, 12);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(75, 25);
            this.historyButton.TabIndex = 11;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // closeHistoryPanel
            // 
            this.closeHistoryPanel.BackColor = System.Drawing.SystemColors.Control;
            this.closeHistoryPanel.ForeColor = System.Drawing.Color.Red;
            this.closeHistoryPanel.Location = new System.Drawing.Point(495, 3);
            this.closeHistoryPanel.Name = "closeHistoryPanel";
            this.closeHistoryPanel.Size = new System.Drawing.Size(31, 27);
            this.closeHistoryPanel.TabIndex = 12;
            this.closeHistoryPanel.Text = "X";
            this.closeHistoryPanel.UseVisualStyleBackColor = false;
            this.closeHistoryPanel.Click += new System.EventHandler(this.closeHistoryPanel_Click);
            // 
            // historyPanel
            // 
            this.historyPanel.Controls.Add(this.closeHistoryPanel);
            this.historyPanel.Controls.Add(this.deleteHistoryBtn);
            this.historyPanel.Location = new System.Drawing.Point(210, 95);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(529, 600);
            this.historyPanel.TabIndex = 13;
            // 
            // favBtn
            // 
            this.favBtn.Location = new System.Drawing.Point(1088, 12);
            this.favBtn.Name = "favBtn";
            this.favBtn.Size = new System.Drawing.Size(85, 25);
            this.favBtn.TabIndex = 14;
            this.favBtn.Text = "Favourites";
            this.favBtn.UseVisualStyleBackColor = true;
            this.favBtn.Click += new System.EventHandler(this.favBtn_Click);
            // 
            // favPanel
            // 
            this.favPanel.Controls.Add(this.showFavBtn);
            this.favPanel.Controls.Add(this.favNameBox);
            this.favPanel.Controls.Add(this.closeFavPanel);
            this.favPanel.Controls.Add(this.setFavBtn);
            this.favPanel.Controls.Add(this.favUrlBox);
            this.favPanel.Location = new System.Drawing.Point(771, 221);
            this.favPanel.Name = "favPanel";
            this.favPanel.Size = new System.Drawing.Size(481, 111);
            this.favPanel.TabIndex = 15;
            // 
            // favUrlBox
            // 
            this.favUrlBox.Location = new System.Drawing.Point(19, 36);
            this.favUrlBox.Name = "favUrlBox";
            this.favUrlBox.Size = new System.Drawing.Size(422, 22);
            this.favUrlBox.TabIndex = 0;
            this.favUrlBox.Text = "http://";
            // 
            // setFavBtn
            // 
            this.setFavBtn.Location = new System.Drawing.Point(92, 64);
            this.setFavBtn.Name = "setFavBtn";
            this.setFavBtn.Size = new System.Drawing.Size(138, 36);
            this.setFavBtn.TabIndex = 1;
            this.setFavBtn.Text = "Set Favourites";
            this.setFavBtn.UseVisualStyleBackColor = true;
            this.setFavBtn.Click += new System.EventHandler(this.setFavBtn_Click);
            // 
            // closeFavPanel
            // 
            this.closeFavPanel.BackColor = System.Drawing.SystemColors.Control;
            this.closeFavPanel.ForeColor = System.Drawing.Color.Red;
            this.closeFavPanel.Location = new System.Drawing.Point(447, 3);
            this.closeFavPanel.Name = "closeFavPanel";
            this.closeFavPanel.Size = new System.Drawing.Size(31, 27);
            this.closeFavPanel.TabIndex = 14;
            this.closeFavPanel.Text = "X";
            this.closeFavPanel.UseVisualStyleBackColor = false;
            this.closeFavPanel.Click += new System.EventHandler(this.closeFavPanel_Click);
            // 
            // favNameBox
            // 
            this.favNameBox.Location = new System.Drawing.Point(19, 8);
            this.favNameBox.Name = "favNameBox";
            this.favNameBox.Size = new System.Drawing.Size(422, 22);
            this.favNameBox.TabIndex = 15;
            this.favNameBox.Text = "Enter Name";
            // 
            // showFavPanel
            // 
            this.showFavPanel.Controls.Add(this.closeShowFavPanel);
            this.showFavPanel.Location = new System.Drawing.Point(213, 67);
            this.showFavPanel.Name = "showFavPanel";
            this.showFavPanel.Size = new System.Drawing.Size(526, 545);
            this.showFavPanel.TabIndex = 16;
            // 
            // closeShowFavPanel
            // 
            this.closeShowFavPanel.BackColor = System.Drawing.SystemColors.Control;
            this.closeShowFavPanel.ForeColor = System.Drawing.Color.Red;
            this.closeShowFavPanel.Location = new System.Drawing.Point(492, 3);
            this.closeShowFavPanel.Name = "closeShowFavPanel";
            this.closeShowFavPanel.Size = new System.Drawing.Size(31, 27);
            this.closeShowFavPanel.TabIndex = 16;
            this.closeShowFavPanel.Text = "X";
            this.closeShowFavPanel.UseVisualStyleBackColor = false;
            this.closeShowFavPanel.Click += new System.EventHandler(this.closeShowFavPanel_Click);
            // 
            // showFavBtn
            // 
            this.showFavBtn.Location = new System.Drawing.Point(236, 64);
            this.showFavBtn.Name = "showFavBtn";
            this.showFavBtn.Size = new System.Drawing.Size(136, 36);
            this.showFavBtn.TabIndex = 16;
            this.showFavBtn.Text = "Show Favourites";
            this.showFavBtn.UseVisualStyleBackColor = true;
            this.showFavBtn.Click += new System.EventHandler(this.showFavBtn_Click);
            // 
            // CW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 807);
            this.Controls.Add(this.showFavPanel);
            this.Controls.Add(this.favPanel);
            this.Controls.Add(this.favBtn);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.homePagePanel);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.setHomeBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.searchBox);
            this.Name = "CW1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CW1_Load);
            this.homePagePanel.ResumeLayout(false);
            this.homePagePanel.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.favPanel.ResumeLayout(false);
            this.favPanel.PerformLayout();
            this.showFavPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button setHomeBtn;
        private System.Windows.Forms.Panel homePagePanel;
        private System.Windows.Forms.Button setHomePageBtn;
        private System.Windows.Forms.TextBox homePageUrlBox;
        private System.Windows.Forms.Button deleteHistoryBtn;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button closeHistoryPanel;
        private System.Windows.Forms.Button closeHomePagePanel;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Button favBtn;
        private System.Windows.Forms.Panel favPanel;
        private System.Windows.Forms.Button setFavBtn;
        private System.Windows.Forms.TextBox favUrlBox;
        private System.Windows.Forms.Button closeFavPanel;
        private System.Windows.Forms.TextBox favNameBox;
        private System.Windows.Forms.Panel showFavPanel;
        private System.Windows.Forms.Button closeShowFavPanel;
        private System.Windows.Forms.Button showFavBtn;
    }
}

