using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;

namespace ClockSync_Receiver
{
    public partial class frmMain : Form
    {
        TcpListener _server = null;
        Thread _listenerWorkingThread;
        Int32 _port;

        private void InitServer()
        {
            try
            {
                _server = new TcpListener(IPAddress.Any, 1895);

                // Start listening for client requests.
                _server.Start();
                _lbxLog.Items.Add(DateTime.Now.ToString() + "\tStart listener on port " + _port.ToString());

                _listenerWorkingThread.Start();

                _btnStopServer.Enabled = true;
                _btnStartServer.Enabled = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Listener()
        {
            try
            {
                // Enter the listening loop.
                while (true)
                {
                    if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate { _lblServerStatus.Text = "Server Online"; _lblServerStatus.BackColor = Color.LimeGreen; });

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = _server.AcceptTcpClient();

                    if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate { _lbxLog.Items.Add(DateTime.Now.ToString() + "\tReceiving socket connection request from: " + ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()); });
                    ThreadPool.QueueUserWorkItem(PushTime, client);
                }

            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                _server.Stop();
            }
        }

        private void PushTime(object obj)
        {
            TcpClient client = (TcpClient)obj;

            // Get a stream object for reading and writing
            NetworkStream stream = client.GetStream();

            byte[] msg = Encoding.ASCII.GetBytes(ClockSync_Sever.SYSTEMTIME.Get().AddHours(1).ToString());
            stream.Write(msg, 0, msg.Length);

            if (this.InvokeRequired == true) this.Invoke((MethodInvoker)delegate { _lbxLog.Items.Add(DateTime.Now.ToString() + "\tPush timestring to client : " + ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()); });
            
            // Shutdown and end connection
            client.Close();

        }

        public frmMain()
        {
            InitializeComponent();

            _port = Properties.Settings.Default.SocketPort;
            _listenerWorkingThread = new Thread(this.Listener);
            _lblCurrentTime.Text = ClockSync_Sever.SYSTEMTIME.Get().AddHours(1).ToString();
        }

        private void _btnStartServer_Click(object sender, EventArgs e)
        {
            InitServer();
        }

        private void _btnStopServer_Click(object sender, EventArgs e)
        {
            _server.Stop();
            _listenerWorkingThread.Abort();
            _btnStopServer.Enabled = false;
            _btnStartServer.Enabled = true;
            _lblServerStatus.Text = "Server Offline";
            _lblServerStatus.BackColor = Color.Tomato;
            _lbxLog.Items.Add(DateTime.Now.ToString() + "\tStop listener by user");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_listenerWorkingThread.ThreadState == ThreadState.Running)
            {
                _listenerWorkingThread.Abort(); 
            }

            Properties.Settings.Default.SocketPort = _port;
            Properties.Settings.Default.Save();
        }

        private void _lnkLblClearLogBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _lbxLog.Items.Clear();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            _lblCurrentTime.Text = ClockSync_Sever.SYSTEMTIME.Get().AddHours(1).ToString();
        }
    }
}
