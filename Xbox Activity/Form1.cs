using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using XRPCPlusPlus;
using XDevkit;
using XRPCLib;
using JRPC_Client;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Xbox_Activity
{
    public partial class Form1 : Form
    {
        private Extensions.DiscordRpc.EventHandlers handlers;
        private Extensions.DiscordRpc.RichPresence presence;
        public static XRPC RGH = new XRPC();
        public static IXboxConsole jtag;
        public byte[] titleid;
        public byte[] ProfileID;
        public static string HaloReachTitleID = "4D53085B";
        public static string DashboardTitleID = "FFFE07D1";
        public static string AvatarEditorTitleID = "584D07D1";

        public Form1()
        {
            InitializeComponent();
        }
        public void GetTitleID()
        {
            titleid = RGH.GetMemory(0xC0292070, 4);
            TitleIDTxt.Text = $"Title ID:{BitConverter.ToString(titleid).Replace("-", "")}";
        }
        public void GetProfileID()
        {
            ProfileID = RGH.GetMemory(0xC0291FF0, 7);
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }
        private void Connect()
        {

            if (jtag.Connect(out jtag, "default"))
            {
                ConnectionTxt.Text = "Connected";
                RGH.Connect();
                if (RGH.activeConnection)
                {
                    ConnectionTxt.Text = $"Connected to {jtag.Name}";
                    Form1.ActiveForm.Text = $"Xbox Activity:{GetGamertag(jtag)}";
                }
                else
                {
                    MessageBox.Show("Not connected");
                }
                ActivityLoop();
            }

            }
        private async void ActivityLoop()
        {
            Extensions.DiscordRpc.Initialize("843287927663886377", ref this.handlers, true, null);
            Extensions.DiscordRpc.UpdatePresence(ref this.presence);
            while (true)
            {
                GetTitleID();
                var lines = File.ReadAllLines(Application.StartupPath + "\\TitleIDs.txt");
                foreach (string line in lines)
                {
                    string[] words = line.Split(',');
                    var TITLEID = words.First();
                    var GameName = words[1];
                    var Image = words[2];
                    var PresenceImage = words.Last();
                    if (TitleIDTxt.Text == $"Title ID:{TITLEID}")
                    {
                        this.presence.details = ($"GT:{GetGamertag(jtag)}");
                        this.presence.state = GameName;
                        this.presence.largeImageKey = "xbox";
                        this.presence.smallImageKey = PresenceImage;
                        this.presence.largeImageText = $"TitleID:{TITLEID} on {GameName}!";
                        this.presence.smallImageText = $"Gamertag:{GetGamertag(jtag)}";
                        this.BoxArt.ImageLocation = Image;
                        StatusTxt.Text = $"Status:{GameName}";
                        Extensions.DiscordRpc.UpdatePresence(ref this.presence);
                    }
                }
                Extensions.DiscordRpc.UpdatePresence(ref this.presence);
                await Task.Delay(15000);
            }
        }
        static public string GetGamertag(XDevkit.IXboxConsole xbc)
        {
            byte[] addrdata = RGH.GetMemory(0x81AA28FC, 16 * 2);
            return Encoding.BigEndianUnicode.GetString(addrdata);
        }

        private void TitleIDTxt_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(BitConverter.ToString(titleid).Replace("-", ""));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Extensions.DiscordRpc.Initialize("843287927663886377", ref this.handlers, true, null);
            Extensions.DiscordRpc.UpdatePresence(ref this.presence);
            HttpWebRequest request = WebRequest.Create("https://peoplehub.xboxlive.com/users/me/people/xuids(" + XUID.Text + ")/decoration/broadcast,multiplayersummary,preferredcolor,socialManager,tournamentSummary") as HttpWebRequest;
            request.Method = "GET";
            request.Headers.Add("x-xbl-contract-version", "1");
            request.Headers.Add("Accept-Encoding", "gzip; q=1.0, deflate; q=0.5, identity; q=0.1");
            request.Headers.Add("Accept-Language", "en-US, en, en-AU, en");
            request.Headers.Add("Authorization", XSTS.Text);
            request.Headers.Add("Signature", "AAAAAQHW0Zzb5TQBf9TLmReR62PYoOpscvtjUKjNjXl0Un5Eyi5Vrk2klBrnllMW4N/UsTxpB945Q2y2l9xQ6MYYqkHlIsDKOhUw6g==");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            var str = reader.ReadToEnd();
            string result = FindTextBetween(str, "displayPicRaw", ",");
            string leet = result.Replace("\"", "");
            string bruh = leet.Replace(":", "");
            string GamerPicture = bruh.Replace("http", "http:");
            string result1 = FindTextBetween(str, "gamertag", ",");
            string leet1 = result1.Replace("\"", "");
            string Gamertag = leet1.Replace(":", "");
            string result2 = FindTextBetween(str, "gamerScore", ",");
            string leet2 = result2.Replace("\"", "");
            string GamerScore = leet2.Replace(":", "");
            string result3 = FindTextBetween(str, "xboxOneRep", ",");
            string leet3 = result3.Replace("\"", "");
            string XboxOneRep = leet3.Replace(":", "");
            string result4 = FindTextBetween(str, "presenceText", ",");
            string leet4 = result4.Replace("\"", "");
            string PresenceText = leet4.Replace(":", "");
            richTextBox1.AppendText(Gamertag + "," + GamerPicture + "," + GamerScore + "," + XboxOneRep + "," + PresenceText);
            this.presence.details = ($"GT:{Gamertag}");
            this.presence.state = PresenceText;
            this.presence.largeImageKey = "xboxone";
            this.presence.smallImageKey = "xb1c";
            this.presence.largeImageText = $"GamerScore:{GamerScore}!";
            this.presence.smallImageText = $"Reputation:{XboxOneRep}";
            this.BoxArt.ImageLocation = GamerPicture;
            StatusTxt.Text = $"Status:{PresenceText}";
            TitleIDTxt.Text = "Xbox One Mode";
            Extensions.DiscordRpc.UpdatePresence(ref this.presence);
        }
        public string FindTextBetween(string text, string left, string right)
        {
            // TODO: Validate input arguments

            int beginIndex = text.IndexOf(left); // find occurence of left delimiter
            if (beginIndex == -1)
                return string.Empty; // or throw exception?

            beginIndex += left.Length;

            int endIndex = text.IndexOf(right, beginIndex); // find occurence of right delimiter
            if (endIndex == -1)
                return string.Empty; // or throw exception?

            return text.Substring(beginIndex, endIndex - beginIndex).Trim();
        }
    }
}
