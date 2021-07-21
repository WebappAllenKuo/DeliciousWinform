using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using customerChatServer;

namespace m_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void ShowMsgCallback(String msg);
        Thread threadWatch = null;
        Socket socketWatch = null;
        Dictionary<String, Socket> dictCommunication = new Dictionary<String, Socket>();
        Socket socketCommunication = null;
        Dictionary<String, Thread> dictThread = new Dictionary<String, Thread>();
        private void ShowMsg(String msg)
        {
            if (txtMsg.InvokeRequired)
            {
                txtMsg.Invoke(new ShowMsgCallback(ShowMsg), msg);
            }
            else
            {

                txtMsg.AppendText(msg + "\r\n");
            }
        }
        private void ShowIP(String msg)
        {
            if (lbSocketOnline.InvokeRequired)
            {
                lbSocketOnline.Invoke(new ShowMsgCallback(ShowIP), msg);
            }
            else
            {
                lbSocketOnline.Items.Add(msg);
                
            }
        }
        private void Watch()
        {

            while (true)
            {
                 
                socketCommunication = socketWatch.Accept();

                dictCommunication.Add(socketCommunication.RemoteEndPoint.ToString(), socketCommunication);
                ShowIP(socketCommunication.RemoteEndPoint.ToString());


                Thread thread = new Thread(new ThreadStart(Watch1));
                thread.IsBackground = true;
                thread.Start();
                dictThread.Add(socketCommunication.RemoteEndPoint.ToString(), thread);

                ShowMsg("用戶" + socketCommunication.RemoteEndPoint.ToString());
                String msg = "歡迎使用AI回答, 請輸入食譜或是會員";
                dictCommunication[socketCommunication.RemoteEndPoint.ToString()].Send(System.Text.Encoding.UTF8.GetBytes(msg));
            }
        }
        private void Watch1()
        {
           Socket local_sock = socketCommunication;
            while (true)
            {
                
                byte[] bytes = new byte[1024];
                try
                {
                    
                    int length = local_sock.Receive(bytes);
                    if (length != 0)
                    {
                        String msg = System.Text.Encoding.UTF8.GetString(bytes, 0, length);
                        ShowMsg("收到" + local_sock.RemoteEndPoint.ToString() + "資料" + msg);
                         
                        String Rmsg = new CCustomerServer().mAI(msg);
                        dictCommunication[local_sock.RemoteEndPoint.ToString()].Send(System.Text.Encoding.UTF8.GetBytes(Rmsg));
                    }
                }
                catch (SocketException ex)
                {
                    int Error_code = ex.NativeErrorCode;
                    dictCommunication.Remove(local_sock.RemoteEndPoint.ToString());
                    break;
                }

                catch
                {
                    ShowMsg("receivesocket unknow error!\r\n");
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);            
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(txtPort.Text.Trim()));
            socketWatch.Bind(endPoint);
            socketWatch.Listen(20);
            threadWatch = new Thread(new ThreadStart(Watch));
            threadWatch.IsBackground = true;
            threadWatch.Start();
            ShowMsg("服務器啟動成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbSocketOnline.Text.Length == 0)
            {
                MessageBox.Show("未選取");
            }
            else
            {
                
                String msg = txtSendMsg.Text.Trim();
                dictCommunication[lbSocketOnline.Text].Send(System.Text.Encoding.UTF8.GetBytes(msg));
                ShowMsg("發送" + msg);
            }
        }
    }
}
