using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int dayCount = 0;
        private int pageCount = 0;
        private ImageList imgList;
        private string[] srcList;
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
            if(response.StatusCode == HttpStatusCode.OK)
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
            System.Net.WebRequest request =
                System.Net.WebRequest.Create(url);

            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (pageCount == 0)
            {
                Console.WriteLine("Run");
                HtmlDocument docs = webBrowser1.Document;
                HtmlElementCollection tables = default(HtmlElementCollection);
                tables = docs.GetElementsByTagName("div");
                foreach (HtmlElement he in tables)
                {
                    if (he.GetAttribute("className").ToString() == "enter-list-entity")
                    {
                        if (he.InnerHtml != null)
                        {
                            //Console.WriteLine(he.InnerHtml.ToString());
                            string imgSrc = Regex.Match(he.InnerHtml.ToString(), "src=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            string titleStr = Regex.Match(he.InnerHtml.ToString(), "title=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            string hrefStr = Regex.Match(he.InnerHtml.ToString(), "href=[\"'](.+?)[\"'].+?", RegexOptions.IgnoreCase).Groups[1].Value;
                            Console.WriteLine(titleStr);
                            Console.WriteLine(imgSrc);
                            Console.WriteLine(hrefStr);
                        }
                        //Thread.Sleep(100);
                    }
                    else if(he.GetAttribute("className").ToString() == "enter-list-head")
                    {
                        dayCount++;
                    }
                }
                pageCount = 1;
            }
        }
    }
}
