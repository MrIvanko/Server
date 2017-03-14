using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworksApi.TCP.SERVER;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;

namespace ServerApp
{
    public delegate void UpdateChatLog(string txt);
    public delegate void UpdateListBox(ListBox box, string value, bool Remove);
    public delegate void UpdateCounter(int count);
    public partial class Form1 : Form
    {
        Server server;
        public string IpAddressLocal;
        public Stack port = new Stack();
        public string actualPort;
        System.Threading.Thread myThread;

        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); //get my own IP
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IpAddressLocal = address.ToString();
                    actualLocalIP.Text = IpAddressLocal.ToString();
                }
            }
            GetFreePortsFromAzureCloud();
            myThread = new System.Threading.Thread(new System.Threading.ThreadStart(startHttpServer));
            myThread.Start();
        }

        private void ChangeChatLog(String txt)
        {
            if (chatLogTextBox.InvokeRequired)
            {
                Invoke(new UpdateChatLog(ChangeChatLog), new object[] { txt });
            }
            else
            {
                chatLogTextBox.Text += txt + "\r\n";
            }
        }

        private void ChangeListBox(ListBox box, string value, bool Remove)
        {
            if (box.InvokeRequired)
            {
                Invoke(new UpdateListBox(ChangeListBox), new object[] { box, value, Remove });
            }
            else
            {
                if (Remove)
                {
                    box.Items.Remove(value);
                }
                else
                {
                    box.Items.Add(value);
                }
            }
        }

        private void ChangeCounter(int count)
        {
            if(statusStrip1.InvokeRequired)
            {
                Invoke(new UpdateCounter(ChangeCounter), new object[] { count });
            }
            else
            {
                toolStripStatusLabel2.Text = count.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void chatLogTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconnectClientButton_Click(object sender, EventArgs e)
        {
            server.DisconnectClient((string)clientNameListBox.SelectedItem);
        }

        private void sendPrivateMessageButton_Click(object sender, EventArgs e)
        {
            server.SendTo((string)clientNameListBox.SelectedItem, messageTextBox.Text);
        }

        private void broadcastButton_Click(object sender, EventArgs e)
        {
            server.BroadCast(messageTextBox.Text);
            axVideoChatReceiver1.ReceiveAudioStream = true;
            axVideoChatReceiver1.ReceiveVideoStream = true;
            axVideoChatReceiver1.Listen(IpAddressLocal,Int32.Parse(actualPort));
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAvailablePorts();
            server = new Server(IpAddressLocal, actualPort);
            server.OnClientConnected += new OnConnectedDelegate(Server_OnClientConnected);
            server.OnClientDisconnected += new OnDisconnectedDelegate(Server_OnClientDisconnected);
            server.OnDataReceived += new OnReceivedDelegate(Server_OnDataReceived);
            server.OnServerError += new OnErrorDelegate(Server_OnServerError);
            server.Start();
        }

        private void Server_OnServerError(object Sender, ErrorArguments R)
        {
            throw new NotImplementedException();
        }

        private void Server_OnDataReceived(object Sender, ReceivedArguments R)
        {
            ChangeChatLog(R.ReceivedData);
            server.BroadCast(R.Name + " says: " + R.ReceivedData);
        }

        private void Server_OnClientDisconnected(object Sender, DisconnectedArguments R)
        {
            server.BroadCast(R.Name + " has Disconnected");
            ChangeListBox(clientNameListBox, R.Name, true);
            ChangeListBox(ipAddressListBox, R.Ip, true);
            ChangeListBox(portListBox, actualPort, true); //upravit
            ChangeCounter(server.NumberOfConnections);
           // port.Push(portListBox.SelectedIndex);
        }

        private void Server_OnClientConnected(object Sender, ConnectedArguments R)
        {
            server.BroadCast(R.Name + " has Connected");
            ChangeListBox(clientNameListBox, R.Name, false);
            ChangeListBox(ipAddressListBox, R.Ip, false);
            ChangeListBox(portListBox, actualPort, false); //upravit
            ChangeCounter(server.NumberOfConnections);
            GetAvailablePorts();
        }

        private void clientNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             portListBox.SelectedIndex = ipAddressListBox.SelectedIndex = clientNameListBox.SelectedIndex;
        }

        private void ipAddressListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             portListBox.SelectedIndex = clientNameListBox.SelectedIndex = ipAddressListBox.SelectedIndex;
        }
        //asdasdasda
        public void  startHttpServer()
        {
            HttpListener listener = null;
            try
            {
                listener = new HttpListener();
                listener.Prefixes.Add("http://localhost:1300/simpleserver/");
                listener.Start();
                while (true)
                {
                    HttpListenerContext context = listener.GetContext();
                    string msg = actualPort;
                    context.Equals("PORT");
                    
                    context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                    using (Stream stream = context.Response.OutputStream)
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(msg);
                        }
                    }
                }




            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.Write("chyba " + e);
            }
        }

        public void GetFreePortsFromAzureCloud()
        {
             //simulate fill stack with ports
            port.Push(80);
            port.Push(8080);
            port.Push(512);
            toolStripStatusLabel4.Text = port.Count.ToString();
        }

        public object GetAvailablePorts()
        {
            if (port.Count >= 1)
            {
                actualPort = port.Pop().ToString();
                return actualPort;
            }
            else
            {
                MessageBox.Show("Wait for free port");
                return null;
            }
        }

        private void portListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ipAddressListBox.SelectedIndex = clientNameListBox.SelectedIndex = portListBox.SelectedIndex;
        }

        private void startHttpServerButton_Click(object sender, EventArgs e)
        {
            startHttpServer();
        }
    }
}
