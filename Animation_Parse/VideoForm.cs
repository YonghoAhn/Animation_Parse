using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_Parse
{
    public partial class VideoForm : Form
    {
        private int pageCnt = 0;
        private int icnt = 0;
        private int hcnt = 0;
        public static string navigateLink { get; set; }
        private string[] hrefsrc = new string[1000];
        private string[] alt = new string[1000];
        public VideoForm()
        {
            InitializeComponent();
        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(navigateLink);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(pageCnt == 0)
            {
                HtmlDocument docs = webBrowser1.Document;
                HtmlElementCollection tables = default(HtmlElementCollection);
                tables = docs.GetElementsByTagName("div");
                HtmlElementCollection spans = default(HtmlElementCollection);
                spans = docs.GetElementsByTagName("span");
                foreach (HtmlElement he in tables)
                {
                    if (he.GetAttribute("className").ToString() == "thumb")
                    {
                        if (he.InnerHtml != null)
                        {
                            string imgalt = Regex.Match(he.InnerHtml.ToString(), "alt=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            Console.WriteLine(imgalt);
                            alt[icnt] = imgalt;
                            icnt++;
                            //string imgSrc = Regex.Match(he.InnerHtml.ToString(), "src=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            //Console.WriteLine(imgSrc);
                        }
                    }
                    if (he.GetAttribute("className").ToString() == "board-list-item")
                    {
                        if (he.InnerHtml != null)
                        {
                            string href = Regex.Match(he.InnerHtml.ToString(), "href=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            hrefsrc[hcnt] = href;
                            Console.WriteLine(href);
                            hcnt++;
                        }
                    }
                }
                for(int i = 0; i<icnt;i++)
                {
                    listView1.Items.Add(alt[i]);
                }
                pageCnt = 1;
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int idx = item.Index;
                GetVideoURL(hrefsrc[idx]);
            }

        }

        private void GetVideoURL(string NavigateURL)
        {
            pageCnt = 0;
            videoBrowser.Navigate(NavigateURL);
        }
        private string videosrc;
        private void videoBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(pageCnt == 0)
            {
                HtmlDocument docs = videoBrowser.Document;
                HtmlElementCollection videos = docs.GetElementsByTagName("video");
                foreach(HtmlElement he in videos)
                {
                    videosrc = he.GetAttribute("src");
                }
                axWindowsMediaPlayer1.URL = videosrc;
                //axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void 다운로드DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.mp4|*.mp4";
            saveFileDialog1.Title = "Download";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != null)
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(videosrc, saveFileDialog1.FileName);
                }
            }
        }
    }
}
