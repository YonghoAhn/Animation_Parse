using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_Parse
{
    public partial class Form1 : Form
    {
        //private int dayCount = 0;
        private int pageCount = 0;
        private ImageList imgList = new ImageList();
        private string[] srcList = new string[1000];
        private string[] titleList = new string[1000];

        //HTMLParser HTMLParser;
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://ani.today/");
            //Task.Factory.StartNew(() => GetAni("http://ani.today/"));
            //HtmlElementCollection imgs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetAni(string url)
        {
            string data = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
            }
            //HTMLParser.Test(data);
        }

        private Image LoadImage(string url)
        {
            WebRequest request =
                WebRequest.Create(url);

            WebResponse response = request.GetResponse();
            Stream responseStream =
                response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            int cnt = 0;
            if (pageCount == 0)
            {
                Console.WriteLine("Run");
                HtmlDocument docs = webBrowser1.Document;
                HtmlElementCollection tables = default(HtmlElementCollection);
                tables = docs.GetElementsByTagName("div");
                HtmlElementCollection spans = default(HtmlElementCollection);
                spans = docs.GetElementsByTagName("span");
                foreach (HtmlElement he in spans)
                {
                    if (he.GetAttribute("className").ToString() == "text")
                    {
                        if (he.InnerText != null)
                        {
                            string title = he.InnerText;
                            titleList[cnt] = title;
                            Console.WriteLine(title);
                            cnt++;
                        }
                    }
                }
                cnt = 0;
                foreach (HtmlElement he in tables)
                {
                    if (he.GetAttribute("className").ToString() == "enter-list-entity")
                    {
                        if (he.InnerHtml != null)
                        {
                            //Console.WriteLine(he.InnerHtml.ToString());
                            string imgSrc = Regex.Match(he.InnerHtml.ToString(), "src=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            //string titleStr = Regex.Match(he.InnerHtml.ToString(), "title=[\"'](.+?)[\"'].*?", RegexOptions.IgnoreCase).Groups[1].Value;
                            //string titleStr2 = Regex.Match(he.InnerHtml, "<a[\\s\\S]*?title=\"([^<>] *?)\">", RegexOptions.IgnoreCase).Groups[1].Value;
                            string hrefStr = Regex.Match(he.InnerHtml.ToString(), "href=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            img_Title.Images.Add(LoadImage(imgSrc));

                            srcList[cnt] = hrefStr;
                            LoadImage(imgSrc).Save(Application.StartupPath + "\\" + cnt.ToString() + ".jpg", ImageFormat.Jpeg);
                            cnt++;
                            //Console.WriteLine(titleStr);
                            //Console.WriteLine(titleStr2);
                            //Console.WriteLine(imgSrc);
                            //Console.WriteLine(hrefStr);
                        }
                        //Thread.Sleep(100);
                    }
                   // else if (he.GetAttribute("className").ToString() == "enter-list-head")
                  //  {
                     //   dayCount++;
                   // }
                }
                pageCount = 1;
                cnt = 0;
                foreach (string item in titleList)
                {
                    if (item != null && item != "")
                        if (img_Title.Images.Count < cnt)
                            break;
                        else
                            listView1.Items.Add(item, cnt);
                    cnt++;
                }
                Refresh();
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int idx = item.Index;
                VideoForm v = new VideoForm();
                VideoForm.navigateLink = srcList[idx];
                v.Show();

                //string sel_item = item.SubItems[1].Text;
            }
        }
    }
}
