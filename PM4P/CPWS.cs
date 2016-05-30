/*
 * CPWS - Copy WebSite, tool for copy website as a Web Spoofing Attack
 */
using System.Net;
using System.Windows.Forms;

namespace PM4P
{
    class CPWS
    {
        public string copywebsite(string link)
        {
            WebClient wC = new WebClient();
            string data = "";
            string text = "";
            var htmldoc = new HtmlAgilityPack.HtmlDocument();

            //checking properly link of website
            if(link.StartsWith("http://"))
            {
                //try to take data
                try
                {
                    data = wC.DownloadString(link);
                }
                catch(WebException e)
                {
                    text += e.ToString();
                    MessageBox.Show(text, "Bad link!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    data = wC.DownloadString(link.Insert(0, "http://"));
                }
                catch(WebException e)
                {
                    text += e.ToString();
                    MessageBox.Show(text, "Bad liknk!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            return data;
        }
    }
}
