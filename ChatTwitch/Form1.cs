using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;

namespace ChatTwitch
{
    public partial class Form1 : Form
    {
        /*
         * TODO:
         *     Faire une deuxième connexion TcpClient pour mettre en relation deux personnes sur deux chat différent
         *     
        */

        string folderInDoc = @"\TwitchBotTroll";
        string SaveFileName = @"\save.txt";
        string pathMyDoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        bool isInit = false;
        TcpClient tcpClient;
        StreamReader reader;
        StreamWriter writer;


        string password, userName, tvTwitch, tempRepeatMsg, tempRepeatMsg2, tempRepeatMsg3, tempRepeatMsg4;
        string [] repeatAfterUserName;
        bool repeat = false;
        bool after = false;


		#region function

		//Scroll
		private void scroll()
        {
            if (cbx_autoscroll.Checked)
            {
                lbx_currentChat.SelectedIndex = lbx_currentChat.Items.Count - 1;
                lbx_currentChat.SelectedIndex = -1;
            }
        }
        // reconnection
        private void reconnect()
        {
            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            reader = new StreamReader(tcpClient.GetStream());
            writer = new StreamWriter(tcpClient.GetStream());

            password = tbx_password.Text; // Encoding.UTF8.GetString(Convert.FromBase64String(tbx_password.Text));
            userName = tbx_userName.Text.ToLower();
            tvTwitch = tbx_tvTwitch.Text.ToLower();


            writer.WriteLine(   "PASS " + password + Environment.NewLine + 
                                "NICK " + userName + Environment.NewLine + 
                                "USER " + userName + " 8 * :" + userName
                );
            writer.WriteLine("CAP REQ :twitch.tv/membership");
            writer.WriteLine("JOIN #" + tvTwitch);
            writer.Flush();
        
        }

        //Send any message with current autor
        private void sendMessage(string message)
        {
            //watchout about this string where tvTwitch
            string temp = ":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + tvTwitch + " :" + message; 
            writer.WriteLine(temp);
            writer.Flush();
            lbx_currentChat.Items.Add(userName.ToUpper() + ":" + message);
            scroll();
        }

		// after response
		private void afterResponse(string response)
		{
			sendMessage(response);
		}
		// after message
		private bool afterMessage(string message, string nick, out string response)
		{
			response = "";
			var words = tbx_afterOnText.Text.Split('|');

			foreach(var word in words)
			{
				if (message == word)
				{
					response = String.Format(tbx_afterDoText.Text, nick);
					return true;
				}
			}

			return false;
		}

		// repeat any message with delay
		private void repeatMessage(string message)
        {
            int time = message.Length * (int)nud_timeByLettre.Value + (int)nud_minTimeRepeat.Value; //en ms
            if (!timer_repeat.Enabled)
            {
                timer_repeat.Interval = time;
                tempRepeatMsg = String.Format("{0} {1}", message, suffixes()[0]);
                timer_repeat.Enabled = true;
            }else if (!timer_repeat2.Enabled)
            {
                timer_repeat2.Interval = time;
                tempRepeatMsg2 = String.Format("{0} {1}", message, suffixes()[1]);
                timer_repeat2.Enabled = true;
            }
            else if (!timer_repeat3.Enabled)
            {
                timer_repeat3.Interval = time;
                tempRepeatMsg3 = String.Format("{0} {1}", message, suffixes()[2]);
                timer_repeat3.Enabled = true;
            }
            else if (!timer_repeat4.Enabled)
            {
                timer_repeat4.Interval = time;
                tempRepeatMsg4 = String.Format("{0} {1}", message, suffixes()[3]);
                timer_repeat4.Enabled = true;
            }
        }
        private List<string> suffixes()
        {
            List<string> suffixes = new List<string>();
            string strSuf = tbx_suffix.Text.Trim();
            int j = 0;

            //here the minimum count is 4
            for (int i = 0; i < 4; i++)
                suffixes.Add("");
            foreach (string str in strSuf.Split(' '))
            {
                suffixes.Insert(j, str);
                j++;
            }

            return suffixes;
        }
        private bool repeatAfter(string autor, params string[] trigger)
        {
            foreach (string trig in trigger)
            {
                if (autor.ToLower() == trig.ToLower())
                    return true;
            }
            return false;
        }
        //Kamoulox
        private string kamoulox()
        {
            //Autre site http://benjiboss.free.fr/kamouloxgen/?g=best
            string kam = "";
            WebClient client = new WebClient();
            string htmlCode = client.DownloadString("http://kamoulox.cgx.me/index.php");
            kam = htmlCode.Split(new string[] { "<B>", "</B>" }, StringSplitOptions.None)[1];
            return kam;
        }

        // save or delete file 
        private void saveOrDelete (string path,  params string[] userParam)
        {
            string file = path + folderInDoc + SaveFileName;
            if (!Directory.Exists(path + folderInDoc))
                Directory.CreateDirectory(path + folderInDoc);

            if (cbx_rememberMe.Checked)
            {
                if (File.Exists(file))
                    File.Delete(file);
                // Create a file to write to.
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    foreach(string str in userParam)
                        sw.WriteLine(str);
                }
            }
            else
            {
                if (File.Exists(file))
                    File.Delete(file);
                try
                {
                    if (Directory.Exists(path + folderInDoc))
                        Directory.Delete(path + folderInDoc);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Une erreur est survenue lors de la création du fichié de sauvgarde");
                }
            }
        }
        // read file save.txt
        private void readSave(string path)
        {
            if (File.Exists(path))
            {
                using(StreamReader read = new StreamReader(path))
                {
                    string line;
                    int i = 0;
                    while ((line = read.ReadLine()) != null)
                    {
                        if (i == 0)
                            tbx_tvTwitch.Text = line;
                        else if (i == 1)
                            tbx_userName.Text = line;
                        else if (i == 2)
                            tbx_password.Text = line;
                        else if (i == 3)
                            tbx_suffix.Text = line;
						else if (i == 4)
							tbx_afterOnText.Text = line;
						else if (i == 5)
							tbx_afterDoText.Text = line;

						i++;
                    }
                    if (i > 0)
                        cbx_rememberMe.Checked = true;
                    else
                        cbx_rememberMe.Checked = false; 
                }
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
            readSave(pathMyDoc + folderInDoc + SaveFileName);
            isInit = true;
            this.MaximumSize = new Size(900, 550);
            this.MinimumSize = new Size(900, 550);
        }

        #region Action

        // button about start connection
        private void btn_connection_Click(object sender, EventArgs e)
        {
            if (btn_connection.Text == "Connection")
            {
                btn_connection.Text = "Close";
                reconnect();
                lbx_currentChat.Items.Add("Connection... You are not already connected into a channel.");
                timer_connection.Enabled = true;
            }else {
                lbl_isConnected.Text = "Disconnected";
                lbl_isConnected.ForeColor = Color.Red;
                btn_connection.Text = "Connection";
                timer_connection.Enabled = false;
                tcpClient.Close();
                lbx_currentChat.Items.Add("You are disconnected!");
            }
            scroll();
        }
        // Setting
        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (this.Size.Width == 900){
                this.Size = new Size(1100, 550);
                this.MaximumSize = new Size(1100, 550);
                this.MinimumSize = new Size(1100, 550);
                btn_setting.Text = "Setting <<";
            }
            else{
                this.Size = new Size(900, 550);
                this.MaximumSize = new Size(900, 550);
                this.MinimumSize = new Size(900, 550);
                btn_setting.Text = "Setting >>";
            }
        }

		// after button
		private void Btn_after_Click(object sender, EventArgs e)
		{
			if (btn_after.ForeColor == Color.Red)
			{
				btn_after.ForeColor = Color.Green;
				btn_after.Text = "On";
				after = true;
			}
			else if (btn_after.ForeColor == Color.Green)
			{
				btn_after.ForeColor = Color.Red;
				btn_after.Text = "Off";
				after = false;
			}
		}


		// repeat button
		private void btn_repeat_Click(object sender, EventArgs e)
        {
            if(btn_repeat.ForeColor == Color.Red && !String.IsNullOrEmpty(tbx_repeatUserName.Text))
            {
                btn_repeat.ForeColor = Color.Green;
                repeat = true;
                repeatAfterUserName = tbx_repeatUserName.Text.Split(' ');
            }
            else if (btn_repeat.ForeColor == Color.Green)
            {
                btn_repeat.ForeColor = Color.Red;
                repeat = false;
            }
        }
        // tbx On Change
        private void tbx_repeatUserName_TextChanged(object sender, EventArgs e)
        {
            btn_repeat.ForeColor = Color.Red;
            repeat = false;
        }
        // btn Kamoulox
        private void btn_kamoulox_Click(object sender, EventArgs e)
        {
            tbx_send.Text = kamoulox();
        }
        // Open OAuth gen password in web browser
        private void lnk_OAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://twitchapps.com/tmi/");
        }
        
        // save or not
        private void cbx_rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if(isInit)
                saveOrDelete(pathMyDoc, tbx_tvTwitch.Text, tbx_userName.Text, tbx_password.Text, tbx_suffix.Text, tbx_afterOnText.Text, tbx_afterDoText.Text);
        }

        //on unfocus tvtwitch
        private void tbx_tvTwitch_Leave(object sender, EventArgs e)
        {
            saveOrDelete(pathMyDoc, tbx_tvTwitch.Text, tbx_userName.Text, tbx_password.Text, tbx_suffix.Text, tbx_afterOnText.Text, tbx_afterDoText.Text);
        }
        //on unfocus userName
        private void tbx_userName_Leave(object sender, EventArgs e)
        {
            saveOrDelete(pathMyDoc, tbx_tvTwitch.Text, tbx_userName.Text, tbx_password.Text, tbx_suffix.Text, tbx_afterOnText.Text, tbx_afterDoText.Text);
        }

		private void Tbx_afterOnText_Leave(object sender, EventArgs e)
		{
			saveOrDelete(pathMyDoc, tbx_tvTwitch.Text, tbx_userName.Text, tbx_password.Text, tbx_suffix.Text, tbx_afterOnText.Text, tbx_afterDoText.Text);
		}

		//on unfocus password
		private void tbx_password_Leave(object sender, EventArgs e)
        {
            saveOrDelete(pathMyDoc, tbx_tvTwitch.Text, tbx_userName.Text, tbx_password.Text, tbx_suffix.Text, tbx_afterOnText.Text, tbx_afterDoText.Text);
        }
        private void tbx_suffix_Leave(object sender, EventArgs e)
        {
            saveOrDelete(pathMyDoc, tbx_tvTwitch.Text, tbx_userName.Text, tbx_password.Text, tbx_suffix.Text, tbx_afterOnText.Text, tbx_afterDoText.Text);
        }
        //clear all lbx_currentChat
        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbx_currentChat.Items.Clear();
        }

 

        // copy to clipboard the selected items
        private void btn_copyToClip_Click(object sender, EventArgs e)
        {
            string userNameOfLineSelected = "";
            if (cbx_hour.Checked)
                userNameOfLineSelected = lbx_currentChat.SelectedItem.ToString().Split(' ')[1];
            else
                userNameOfLineSelected = lbx_currentChat.SelectedItem.ToString().Split(' ')[0];

            Clipboard.SetText(userNameOfLineSelected); 
        }

        // alias of btn_send_Click()
        private void tbx_send_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_send_Click(sender, new EventArgs());
            }
        }





		// Send message
		private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient.Connected)
                    sendMessage(tbx_send.Text);
                tbx_send.Text = "";
            }
            catch
            {

            }
        }


        //On ticks repeat
        private void timer_repeat_Tick(object sender, EventArgs e)
        {
            if(timer_repeat.Enabled)
                sendMessage(tempRepeatMsg);
            timer_repeat.Enabled = false;
        }
        //On ticks repeat2
        private void timer_repeat2_Tick(object sender, EventArgs e)
        {
            if (timer_repeat2.Enabled)
                sendMessage(tempRepeatMsg2);//make temp 2
            timer_repeat2.Enabled = false;
        }
        //On ticks repeat3
        private void timer_repeat3_Tick(object sender, EventArgs e)
        {
            if (timer_repeat3.Enabled)
                sendMessage(tempRepeatMsg3);
            timer_repeat3.Enabled = false;
        }
        //On ticks repeat4
        private void timer_repeat4_Tick(object sender, EventArgs e)
        {
            if (timer_repeat4.Enabled)
                sendMessage(tempRepeatMsg4);
            timer_repeat4.Enabled = false;
        }
        // timer for still connected
        private void timer_connection_Tick(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                lbl_isConnected.Text = "Disconnected";
                lbl_isConnected.ForeColor = Color.Red;
                reconnect();
            }
            else
            {
                lbl_isConnected.Text = "Connected";
                lbl_isConnected.ForeColor = Color.Green;
            }

            if(tcpClient.Available > 0 || reader.Peek() >= 0)
            {
                string message = reader.ReadLine();
                string autor = message;
                if (message.Contains("PRIVMSG"))
                {
                    autor = message.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];
                    message = message.Split(new string[] { "PRIVMSG" }, StringSplitOptions.None)[1];
                    message = message.Split(':')[1];
                    lbx_currentChat.Items.Add((cbx_hour.Checked ? DateTime.Now.Hour +":"+  DateTime.Now.Minute + " " : "" ) +  autor + " : " + message);
                }
                else if(message.Contains("Welcome"))
                    lbx_currentChat.Items.Add("You are connected! HF...");
                
                if (repeat && repeatAfter(autor, repeatAfterUserName))
                    repeatMessage(message);

				string response = "";
				if (after && afterMessage(message, autor, out response))
					afterResponse(response);

                scroll();
            }
        }

		#endregion
	}
}
