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

using System.Data.SqlTypes;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ChatAndTrainer : Form
    {
        private string NICK, AUTH;
        private TwitchClient client;
        string redFighter;
        string blueFighter;
        int redTier;
        int blueTier;
        int redCrowdPool;
        int blueCrowdPool;
        int redStreak;
        int blueStreak;

        SQLiteConnection sql_con;

        public ChatAndTrainer(string uNick, string uOauth)
        {
            InitializeComponent();
            NICK = uNick;
            AUTH = uOauth;

            sql_con = new SQLiteConnection("Data Source =MatchHistory.s3db;Version=3;");
        }

        private void onMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            SafeAppendToChatBox(String.Format("{0}: {1}\n", e.ChatMessage.Username, e.ChatMessage.Message));
            if(e.ChatMessage.Username=="waifu4u")
            {
                //stream bot, announces matches, odds, 
                string msg = String.Copy(e.ChatMessage.Message);
                //new match announced
                if(msg.StartsWith("Bets are OPEN for"))
                {
                    int rNameStart = msg.IndexOf("or") + 3;
                    int rNameLength = msg.IndexOf("vs") - rNameStart - 1;
                    int bNameStart = msg.IndexOf("vs")+ 3;
                    int bNameLength = msg.IndexOf("! (") - 1 - bNameStart;
                    switch(msg.Substring(msg.IndexOf("! (") + 3, 1))
                    {
                        case "P":
                            blueTier = 1;
                            redTier = 1;
                            break;
                        case "B":
                            blueTier = 2;
                            redTier = 2;
                            break;
                        case "A":
                            blueTier = 3;
                            redTier = 3;
                            break;
                        case "S":
                            blueTier = 4;
                            redTier = 4;
                            break;
                        case "X":
                            blueTier = 5;
                            redTier = 5;
                            break;
                    }
                    redFighter = msg.Substring(rNameStart, rNameLength);
                    blueFighter = msg.Substring(bNameStart, bNameLength);
                    SafeLabelChange(String.Format("Name: {0}", redFighter), RedName);
                    SafeLabelChange(String.Format("Name: {0}", blueFighter), BlueName);
                    SafeLabelChange(String.Format("Tier: {0}", redTier), RCurrTier);
                    SafeLabelChange(String.Format("Tier: {0}", blueTier), BCurrTier);
                }
                else if(msg.StartsWith("Bets are locked."))
                {
                    //bets locked, scrapes winstreaks and bet values
                    string[] tokens = msg.Split();
                    int i = 0;
                    while (!tokens[i].StartsWith("("))
                    {
                        i++;
                    }
                    redStreak = Convert.ToInt32(tokens[i].Substring(1, tokens[i].Length - 2));
                    SafeLabelChange(String.Format("W/L Streak: {0}", redStreak), RedWL);
                    while (!tokens[i].StartsWith("$"))
                    {
                        i++;
                    }
                    tokens[i] = tokens[i].Remove(0, 1);
                    tokens[i] = tokens[i].Replace(",", "");
                    redCrowdPool = Convert.ToInt32(tokens[i]);
                    while (!tokens[i].StartsWith("("))
                    {
                        i++;
                    }
                    blueStreak = Convert.ToInt32(tokens[i].Substring(1, tokens[i].Length - 2));
                    SafeLabelChange(String.Format("W/L Streak: {0}", blueStreak), BlueWL);
                    while (!tokens[i].StartsWith("$"))
                    {
                        i++;
                    }
                    tokens[i] = tokens[i].Remove(0, 1);
                    tokens[i] = tokens[i].Replace(",", "");
                    blueCrowdPool = Convert.ToInt32(tokens[i]);

                    int PrizePool = redCrowdPool + blueCrowdPool;
                    double redFavorPct = ((double)redCrowdPool / PrizePool)*100.0;
                    SafeBarChange((int)redFavorPct, RedCrowd);
                    double blueFavorPct = ((double)blueCrowdPool / PrizePool) * 100.0;
                    SafeBarChange((int)blueFavorPct, BlueCrowd);
                }
            }
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
                //starts threaded client thing, chat event functions run on separate thread
                client.Connect();
            }
            catch
            {
                SafeAppendToChatBox("CONNECTION FAILED\n");
            }
        }
       
        
        private void ChatAndTrainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                client.Disconnect();
            }
            catch
            {

            }
        }
        

        private void SendButton_Click(object sender, EventArgs e)
        {
            client.SendMessage("saltybet", ChatEntry.Text, false);
            SafeAppendToChatBox(String.Format("{0}: {1}\n", NICK, ChatEntry.Text));
        }

        delegate void PbCheck(int val, ProgressBar P);

        private void SafeBarChange(int val, ProgressBar P)
        {
            if (ChatBox.InvokeRequired)
            {
                PbCheck c = new PbCheck(SafeBarChange);
                this.Invoke(c, new object[] { val, P });
            }
            else
            {
                P.Value = val;
            }
        }

        delegate void LbCheck(string text, Label L);
        
        private void SafeLabelChange(string text, Label L)
        {
            if (ChatBox.InvokeRequired)
            {
                LbCheck c = new LbCheck(SafeLabelChange);
                this.Invoke(c, new object[] {text, L});
            }
            else
            {
                L.Text = text;
            }
        }

        delegate void CbCheck(string text);

        private void button3_Click(object sender, EventArgs e)
        {
            DbControl Dbc = new DbControl(sql_con);
            Dbc.Show();
        }

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
