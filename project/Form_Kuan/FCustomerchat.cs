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
using project.Form_Kuan;
using project;

namespace m_project
{
	public partial class FCustomerchat : Form
	{
		DeliciousEntities DE = new DeliciousEntities();
		public FCustomerchat()
		{
			InitializeComponent();
		}
		int M_member = 2;
		private void Form1_Load(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(this.button1, "客服工作時間為\r\n 9:00AM到5:00PM \r\n 造成不便敬請見諒");
			sockettxt.Add(textBox1);
			//var v = from n in DE.Member_Table
			//		where n.MemberID == M_member
			//		select n.Figure;

			//pictureBox1.ImageLocation = v.FirstOrDefault().ToString();
			pictureBox1.ImageLocation = Viewbag.member.Figure;
		}
		Socket socketClient = null;
		Thread threadRecive = null;
		private void button1_Click(object sender, EventArgs e)
		{
			CChatIP m_Location = new CChatIP();
			socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			IPAddress address = IPAddress.Parse(m_Location.ServiceIp);
			IPEndPoint endPoint = new IPEndPoint(address, int.Parse(m_Location.ServicePort));
			try
			{
				socketClient.Connect(endPoint);
			}
            catch
            {
				MessageBox.Show("客服工作時間為\r\n 9:00AM到5:00PM \r\n 造成不便敬請見諒");
				return;
            }
			threadRecive = new Thread(new ThreadStart(thread_receive));
			threadRecive.IsBackground = true;
			threadRecive.Start();



		}
		static List<TextBox> sockettxt = new List<TextBox>();
		delegate void ShowMsgCallback(String msg);
		private void thread_receive()
		{
			while (true)
			{
				 
				if (socketClient != null) 
				{
					if (socketClient.Connected) 
					{
						try
						{
							byte[] bytes = new byte[1024];


							int length = socketClient.Receive(bytes);
							if (length != 0)
							{
								String msg = System.Text.Encoding.UTF8.GetString(bytes, 0, length);
								ShowMsg( msg);
								 
							}
							else 
							{
								 
								socketClient.Disconnect(true);
								socketClient = null;
							}
						}
						catch 
						{
							 
						}
					
					}
				}
			}
		}
		private void ShowMsg(String msg)
		{
			if (textBox1.InvokeRequired) 
			{
				textBox1.Invoke(new ShowMsgCallback(ShowMsg), msg);
			}
			else
			{
				textBox1.AppendText(msg + "\r\n");
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			if (socketClient != null )
			{
				if (socketClient.Connected)
				{
					String  msg = "MemberID " + Viewbag.member.MemberID + " 發送 " + textBox2.Text.Trim();
					if (msg.Length != 0)
					{
						socketClient.Send( System.Text.Encoding.UTF8.GetBytes(msg));
						ShowMsg("發送" + msg);
					}
					else
					{

					}
				}
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}
