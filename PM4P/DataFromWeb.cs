using System.Net;
using HtmlAgilityPack;
using System.Windows.Forms;
using System;

namespace PM4P
{
    class DataFromWeb
    {
        public string HSD(string link)  //HTMLSTEALDATA
        {
            //variables and object
            WebClient wC = new WebClient();
            string data = "";
            string text = "You set bad link!!! => ";
            string newdata = "";
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();

            //checking link started with http://
            if (link.StartsWith("http://"))
            {
                //try take data from code of website
                try
                {
                    data = wC.DownloadString(link);
                    htmlDoc.LoadHtml(data);

                    newdata += part1(htmlDoc, newdata);
                    newdata += part2(htmlDoc, newdata);
                    newdata += part3(htmlDoc, newdata);
                    newdata += part4(htmlDoc, newdata);
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
                    htmlDoc.LoadHtml(data);

                    newdata += part1(htmlDoc, newdata);
                    newdata += part2(htmlDoc, newdata);
                    newdata += part3(htmlDoc, newdata);
                    newdata += part4(htmlDoc, newdata);
                }
                catch(WebException e)
                {
                    text += e.ToString();
                    MessageBox.Show(text, "Bad link!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            return newdata;
        }

        //functions taking data and checking that exists from website
        public string part1(HtmlAgilityPack.HtmlDocument htmlDoc, string newdata)
        {
            if(htmlDoc.DocumentNode.SelectNodes("//title") != null)
                foreach (var title in htmlDoc.DocumentNode.SelectNodes("//title"))
                {
                    string titles = title.InnerText;
                    newdata += titles;
                }

            if(htmlDoc.DocumentNode.SelectNodes("//h1") != null)
                foreach (var h1 in htmlDoc.DocumentNode.SelectNodes("//h1"))
                {
                    string h1s = h1.InnerText;
                    newdata += h1s;
                }
            
            if(htmlDoc.DocumentNode.SelectNodes("//h2") != null)
                foreach (var h2 in htmlDoc.DocumentNode.SelectNodes("//h2"))
                {
                    string h2s = h2.InnerText;
                    newdata += h2s;
                }

            return newdata;
        }

        public string part2(HtmlAgilityPack.HtmlDocument htmlDoc, string newdata)
        {
            if(htmlDoc.DocumentNode.SelectNodes("//h3") != null)
                foreach (var h3 in htmlDoc.DocumentNode.SelectNodes("//h3"))
                {
                    string h3s = h3.InnerText;
                    newdata += h3s;
                }

            if(htmlDoc.DocumentNode.SelectNodes("//p") != null)
                foreach (var p in htmlDoc.DocumentNode.SelectNodes("//p"))
                {
                    string ps = p.InnerText;
                    newdata += ps;
                }

            if(htmlDoc.DocumentNode.SelectNodes("//a") != null)
                foreach (var a in htmlDoc.DocumentNode.SelectNodes("//a"))
                {
                    string ass = a.InnerText;
                    newdata += ass;
                }

            return newdata;
        }

        public string part3(HtmlAgilityPack.HtmlDocument htmlDoc, string newdata)
        {
            if(htmlDoc.DocumentNode.SelectNodes("//a[@title]") != null)
                foreach (var title in htmlDoc.DocumentNode.SelectNodes("//a[@title]"))
                {
                    HtmlAttribute titleAttribute = title.Attributes["title"];
                    newdata += titleAttribute.Value;
                }

            if(htmlDoc.DocumentNode.SelectNodes("//meta") != null)
                foreach (HtmlNode content in htmlDoc.DocumentNode.SelectNodes("//meta"))
                {
                    HtmlAttribute attcont = content.Attributes["content"];
                    if (attcont != null)
                        newdata += attcont.Value;
                }

            if(htmlDoc.DocumentNode.SelectNodes("//a[@href]") != null)
                foreach (HtmlNode l in htmlDoc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    HtmlAttribute att = l.Attributes["href"];
                    newdata += att.Value;
                }

            return newdata;
        }

        public string part4(HtmlAgilityPack.HtmlDocument htmlDoc, string newdata)
        {
            if(htmlDoc.DocumentNode.SelectNodes("//span") != null)
                foreach (HtmlNode span in htmlDoc.DocumentNode.SelectNodes("//span"))
                {
                    string spans = span.InnerText;
                    foreach (var strong in spans)
                    {
                        if (strong.Equals("<strong>") || strong.Equals("</strong>"))
                            strong.Equals("");
                        else
                            continue;
                    }
                }

            if(htmlDoc.DocumentNode.SelectNodes("//div") != null)
                foreach (var div in htmlDoc.DocumentNode.SelectNodes("//div"))
                {
                    HtmlAttribute classAttribute = div.Attributes["class"];
                    if (classAttribute != null)
                        newdata += classAttribute.Value;
                }

            return newdata;
        }
    }
}
