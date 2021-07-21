using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project.Form_Kuan
{
    class CChatIP
    {
        string _ServiceIp = "127.0.0.1";
        public string ServiceIp {
            get { return _ServiceIp; }
            
        }
        string _ServicePort = "20000";
        public string ServicePort
        {
            get { return _ServicePort; }

        }
        Socket socketClient = null;
        Thread threadRecive = null;
        //public bool Create_server()
        //{
        //    socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //    IPAddress address = IPAddress.Parse( ServiceIp);
        //    IPEndPoint endPoint = new IPEndPoint(address, int.Parse( ServicePort));
        //    try
        //    {
        //        socketClient.Connect(endPoint);
        //    }
        //    catch
        //    {
                 
        //        return false;
        //    }
        //    threadRecive = new Thread(new ThreadStart(thread_receive));
        //    threadRecive.IsBackground = true;
        //    threadRecive.Start();
        //}
        //private void thread_receive()
        //{
        //    while (true)
        //    {
        //        if (socketClient != null)
        //        {
        //            if (socketClient.Connected)
        //            {
        //                try
        //                {
        //                    byte[] bytes = new byte[1024];
        //                    int length = socketClient.Receive(bytes);
        //                    if (length != 0)
        //                    {
        //                        String msg = System.Text.Encoding.UTF8.GetString(bytes, 0, length);
        //                        ShowMsg(msg);
        //                    }
        //                    else
        //                    {
        //                        socketClient.Disconnect(true);
        //                        socketClient = null;
        //                    }
        //                }
        //                catch
        //                {
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
