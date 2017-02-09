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
using System.Net.NetworkInformation;

namespace ClockSync_Receiver
{
    public partial class frmMain : Form
    {
        private DateTime _repeatTime, _receivedTimeString, _lastTime;
        private string _remoteHost;
        private Int32 _port;

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME st);

        private void PullTime()
        {
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024];

            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // This example uses port 11000 on the local computer.
                IPAddress ipAddress = IPAddress.Parse(_remoteHost);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, _port);

                if (new Ping().Send(ipAddress).Status != IPStatus.Success)
                {
                    _lbxLog.Items.Add(DateTime.Now.ToString() + "\tRemote host not available! Pulling canceld.");
                    return;
                }

                // Create a TCP/IP  socket.
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.Connect(remoteEP);
                    _lbxLog.Items.Add(DateTime.Now.ToString() + "\tConnect tcp socket to: " + _remoteHost + ", port: " + _port.ToString());
                    
                    // Receive the response from the remote device.
                    int bytesRec = sender.Receive(bytes);
                    string msg = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    _receivedTimeString = DateTime.Parse(msg);
                    _lbxLog.Items.Add(DateTime.Now.ToString() + "\tNew timestring received with value: " + _receivedTimeString.ToString());
                    _lbxLog.Items.Add(DateTime.Now.ToString() + "\tOffset: " + (DateTime.Now - _receivedTimeString).ToString());

                    SYSTEMTIME.Set(_receivedTimeString.AddHours(-1));

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (Exception e)
                {
                    _lbxLog.Items.Add(DateTime.Now.ToString() + "\tException: " + e.Message);
                    return;
                }
            }
            catch (Exception e)
            {
                _lbxLog.Items.Add(DateTime.Now.ToString() + "\tException: " + e.Message);
                return;
            }

        }

        public frmMain()
        {
            InitializeComponent();

            _remoteHost = Properties.Settings.Default.IpAddress;
            _port = Properties.Settings.Default.Port;
            _repeatTime = Properties.Settings.Default.RepeatTime;

            if (_port == 0)
            {
                _port = 1895;
            }


            _tbxIpAddress.Text = _remoteHost;
            _tbxPort.Text = _port.ToString();
            _dtpRepeatTime.Value = _repeatTime;
            _lblCurrentTime.Text = SYSTEMTIME.Get().AddHours(1).ToString();
        }

        private void _btnStartReceiver_Click(object sender, EventArgs e)
        {
            PullTime();

            _repeatTime = _dtpRepeatTime.Value;

            if (!String.IsNullOrEmpty(_tbxIpAddress.Text))
            {
                _remoteHost = _tbxIpAddress.Text; 
            }
            else
            {
                _lbxLog.Items.Add(DateTime.Now.ToString() + "\tNo server address entered! Pulling canceled.");
                return;
            }

            if (!String.IsNullOrEmpty(_tbxPort.Text))
            {
                _port = Int32.Parse(_tbxPort.Text);
            }
            else
            {
                _port = 1895;
                _tbxPort.Text = _port.ToString();
            }

            _timer.Enabled = true;
            _tbxIpAddress.Enabled = false;
            _tbxPort.Enabled = false;
            _dtpRepeatTime.Enabled = false;
            _btnPull.Enabled = false;
            _btnStopReceiver.Enabled = true;
            _btnStartReceiver.Enabled = false;

            _lbxLog.Items.Add(DateTime.Now.ToString() + "\tAuto sync activated");
            _lblServerStatus.Text = "Online";
            _lblServerStatus.BackColor = Color.LimeGreen;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_repeatTime.ToString("HH:mm:ss") == DateTime.Now.ToString("HH:mm:ss"))
            {
                PullTime();
            }
        }

        private void _btnStopReceiver_Click(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _tbxIpAddress.Enabled = true;
            _tbxPort.Enabled = true;
            _dtpRepeatTime.Enabled = true;
            _btnPull.Enabled = true;
            _btnStopReceiver.Enabled = false;
            _btnStartReceiver.Enabled = true;

            _lbxLog.Items.Add(DateTime.Now.ToString() + "\tAuto sync deactivated");

            _lblServerStatus.Text = "Offline";
            _lblServerStatus.BackColor = Color.Tomato;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            _lblCurrentTime.Text = SYSTEMTIME.Get().AddHours(1).ToString();
        }

        private void _btnPull_Click(object sender, EventArgs e)
        {
            _lbxLog.Items.Add(DateTime.Now.ToString() + "\tManually pull started.");

            if (!String.IsNullOrEmpty(_tbxIpAddress.Text))
            {
                _remoteHost = _tbxIpAddress.Text;
            }
            else
            {
                _lbxLog.Items.Add(DateTime.Now.ToString() + "\tNo server address entered! Pulling canceled.");
                return;
            }

            if (!String.IsNullOrEmpty(_tbxPort.Text))
            {
                _port = Int32.Parse(_tbxPort.Text);

                if (_port == 0)
                {
                    _port = 1895;
                }
            }
            else
            {
                _port = 1895;
                _tbxPort.Text = _port.ToString();
            }

            PullTime();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IpAddress = _tbxIpAddress.Text;
            Properties.Settings.Default.Port = _port;
            Properties.Settings.Default.RepeatTime = _repeatTime;
            Properties.Settings.Default.Save();
        }
    }
}
