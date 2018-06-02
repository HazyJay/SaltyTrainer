using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;

namespace WindowsFormsApp1
{
    public partial class ChatAndTrainer : Form
    {
        private string NICK, AUTH;
        private TwitchClient client;

        public ChatAndTrainer(string uNick, string uOauth)
        {
            InitializeComponent();
            NICK = uNick;
            AUTH = uOauth;
        }

        private void onMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            SafeAppendToChatBox(String.Format("{0}: {1}\n", e.ChatMessage.Username, e.ChatMessage.Message));
        }

        private void ChatAndTrainer_Load(object sender, EventArgs e)
        {
            SafeAppendToChatBox("CONNECTING TO TWITCH CHAT\n");
            SafeAppendToChatBox(String.Format("NICK : {0}\n", NICK));
            SafeAppendToChatBox(String.Format("AUTH : {0}\n", AUTH));
            try
            {
                ConnectionCredentials login = new ConnectionCredentials(NICK, AUTH);

                client = new TwitchClient();
                client.Initialize(login, "saltybet");

                //twitch chat event fcuntions -- add more if needed?
                client.OnMessageReceived += onMessageReceived;

                client.Connect();
            }
            catch
            {
                SafeAppendToChatBox("CONNECTION FAILED\n");
            }
        }
       
        
        private void ChatAndTrainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }
        

        private void SendButton_Click(object sender, EventArgs e)
        {
            client.SendMessage("saltybet", ChatEntry.Text, false);
        }

        delegate void CbCheck(string text);

        private void SafeAppendToChatBox(string text)
        {
            if (ChatBox.InvokeRequired)
            {
                CbCheck c = new CbCheck(SafeAppendToChatBox);
                this.Invoke(c, new object[] { text });
            }
            else
            {
                ChatBox.AppendText(text);
            }
        }
    }
}
