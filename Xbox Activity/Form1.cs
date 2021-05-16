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
    }
}
