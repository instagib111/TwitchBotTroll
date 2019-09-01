namespace ChatTwitch
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btn_connection = new System.Windows.Forms.Button();
			this.lbl_isConnected = new System.Windows.Forms.Label();
			this.btn_kamoulox = new System.Windows.Forms.Button();
			this.btn_repeat = new System.Windows.Forms.Button();
			this.tbx_repeatUserName = new System.Windows.Forms.TextBox();
			this.tbx_send = new System.Windows.Forms.TextBox();
			this.btn_send = new System.Windows.Forms.Button();
			this.timer_connection = new System.Windows.Forms.Timer(this.components);
			this.btn_setting = new System.Windows.Forms.Button();
			this.tbx_tvTwitch = new System.Windows.Forms.TextBox();
			this.tbx_userName = new System.Windows.Forms.TextBox();
			this.tbx_password = new System.Windows.Forms.TextBox();
			this.lbl_tvTwitch = new System.Windows.Forms.Label();
			this.lbl_NickName = new System.Windows.Forms.Label();
			this.lbl_password = new System.Windows.Forms.Label();
			this.lnk_OAuth = new System.Windows.Forms.LinkLabel();
			this.cbx_autoscroll = new System.Windows.Forms.CheckBox();
			this.cbx_rememberMe = new System.Windows.Forms.CheckBox();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_copyToClip = new System.Windows.Forms.Button();
			this.lbx_currentChat = new System.Windows.Forms.ListBox();
			this.cbx_hour = new System.Windows.Forms.CheckBox();
			this.timer_repeat = new System.Windows.Forms.Timer(this.components);
			this.timer_repeat2 = new System.Windows.Forms.Timer(this.components);
			this.timer_repeat3 = new System.Windows.Forms.Timer(this.components);
			this.timer_repeat4 = new System.Windows.Forms.Timer(this.components);
			this.nud_minTimeRepeat = new System.Windows.Forms.NumericUpDown();
			this.nud_timeByLettre = new System.Windows.Forms.NumericUpDown();
			this.lbl_minTimeRepeat = new System.Windows.Forms.Label();
			this.lbl_timeByLettre = new System.Windows.Forms.Label();
			this.lbl_suffix = new System.Windows.Forms.Label();
			this.tbx_suffix = new System.Windows.Forms.TextBox();
			this.ttip_suffix = new System.Windows.Forms.ToolTip(this.components);
			this.btn_after = new System.Windows.Forms.Button();
			this.tbx_afterOnText = new System.Windows.Forms.TextBox();
			this.tbx_afterDoText = new System.Windows.Forms.TextBox();
			this.lbl_afterOnText = new System.Windows.Forms.Label();
			this.lbl_afterDoText = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nud_minTimeRepeat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_timeByLettre)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_connection
			// 
			this.btn_connection.Location = new System.Drawing.Point(18, 18);
			this.btn_connection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_connection.Name = "btn_connection";
			this.btn_connection.Size = new System.Drawing.Size(112, 35);
			this.btn_connection.TabIndex = 0;
			this.btn_connection.Text = "Connection";
			this.btn_connection.UseVisualStyleBackColor = true;
			this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
			// 
			// lbl_isConnected
			// 
			this.lbl_isConnected.AutoSize = true;
			this.lbl_isConnected.ForeColor = System.Drawing.Color.Red;
			this.lbl_isConnected.Location = new System.Drawing.Point(140, 26);
			this.lbl_isConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_isConnected.Name = "lbl_isConnected";
			this.lbl_isConnected.Size = new System.Drawing.Size(107, 20);
			this.lbl_isConnected.TabIndex = 2;
			this.lbl_isConnected.Text = "Disconnected";
			// 
			// btn_kamoulox
			// 
			this.btn_kamoulox.Location = new System.Drawing.Point(762, 18);
			this.btn_kamoulox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_kamoulox.Name = "btn_kamoulox";
			this.btn_kamoulox.Size = new System.Drawing.Size(112, 35);
			this.btn_kamoulox.TabIndex = 3;
			this.btn_kamoulox.Text = "Kamoulox";
			this.btn_kamoulox.UseVisualStyleBackColor = true;
			this.btn_kamoulox.Click += new System.EventHandler(this.btn_kamoulox_Click);
			// 
			// btn_repeat
			// 
			this.btn_repeat.ForeColor = System.Drawing.Color.Red;
			this.btn_repeat.Location = new System.Drawing.Point(884, 18);
			this.btn_repeat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_repeat.Name = "btn_repeat";
			this.btn_repeat.Size = new System.Drawing.Size(112, 35);
			this.btn_repeat.TabIndex = 4;
			this.btn_repeat.Text = "Repeat after";
			this.btn_repeat.UseVisualStyleBackColor = true;
			this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
			// 
			// tbx_repeatUserName
			// 
			this.tbx_repeatUserName.Location = new System.Drawing.Point(1005, 22);
			this.tbx_repeatUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbx_repeatUserName.Name = "tbx_repeatUserName";
			this.tbx_repeatUserName.Size = new System.Drawing.Size(180, 26);
			this.tbx_repeatUserName.TabIndex = 5;
			this.ttip_suffix.SetToolTip(this.tbx_repeatUserName, "sépare tes pseudo par un espace");
			this.tbx_repeatUserName.TextChanged += new System.EventHandler(this.tbx_repeatUserName_TextChanged);
			// 
			// tbx_send
			// 
			this.tbx_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tbx_send.Location = new System.Drawing.Point(18, 737);
			this.tbx_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbx_send.Name = "tbx_send";
			this.tbx_send.Size = new System.Drawing.Size(1166, 26);
			this.tbx_send.TabIndex = 7;
			this.tbx_send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_send_KeyPress);
			// 
			// btn_send
			// 
			this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_send.Location = new System.Drawing.Point(1196, 732);
			this.btn_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(112, 35);
			this.btn_send.TabIndex = 8;
			this.btn_send.Text = "Send";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// timer_connection
			// 
			this.timer_connection.Interval = 50;
			this.timer_connection.Tick += new System.EventHandler(this.timer_connection_Tick);
			// 
			// btn_setting
			// 
			this.btn_setting.Location = new System.Drawing.Point(1196, 18);
			this.btn_setting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_setting.Name = "btn_setting";
			this.btn_setting.Size = new System.Drawing.Size(112, 35);
			this.btn_setting.TabIndex = 9;
			this.btn_setting.Text = "Setting >>";
			this.btn_setting.UseVisualStyleBackColor = true;
			this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
			// 
			// tbx_tvTwitch
			// 
			this.tbx_tvTwitch.Location = new System.Drawing.Point(1356, 88);
			this.tbx_tvTwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbx_tvTwitch.Name = "tbx_tvTwitch";
			this.tbx_tvTwitch.Size = new System.Drawing.Size(216, 26);
			this.tbx_tvTwitch.TabIndex = 10;
			this.tbx_tvTwitch.Leave += new System.EventHandler(this.tbx_tvTwitch_Leave);
			// 
			// tbx_userName
			// 
			this.tbx_userName.Location = new System.Drawing.Point(1356, 172);
			this.tbx_userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbx_userName.Name = "tbx_userName";
			this.tbx_userName.Size = new System.Drawing.Size(216, 26);
			this.tbx_userName.TabIndex = 11;
			this.tbx_userName.Leave += new System.EventHandler(this.tbx_userName_Leave);
			// 
			// tbx_password
			// 
			this.tbx_password.Location = new System.Drawing.Point(1356, 232);
			this.tbx_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbx_password.Name = "tbx_password";
			this.tbx_password.PasswordChar = '*';
			this.tbx_password.Size = new System.Drawing.Size(216, 26);
			this.tbx_password.TabIndex = 12;
			this.tbx_password.Leave += new System.EventHandler(this.tbx_password_Leave);
			// 
			// lbl_tvTwitch
			// 
			this.lbl_tvTwitch.AutoSize = true;
			this.lbl_tvTwitch.Location = new System.Drawing.Point(1353, 63);
			this.lbl_tvTwitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_tvTwitch.Name = "lbl_tvTwitch";
			this.lbl_tvTwitch.Size = new System.Drawing.Size(66, 20);
			this.lbl_tvTwitch.TabIndex = 13;
			this.lbl_tvTwitch.Text = "tvTwitch";
			// 
			// lbl_NickName
			// 
			this.lbl_NickName.AutoSize = true;
			this.lbl_NickName.Location = new System.Drawing.Point(1353, 148);
			this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_NickName.Name = "lbl_NickName";
			this.lbl_NickName.Size = new System.Drawing.Size(83, 20);
			this.lbl_NickName.TabIndex = 14;
			this.lbl_NickName.Text = "Nick name";
			// 
			// lbl_password
			// 
			this.lbl_password.AutoSize = true;
			this.lbl_password.Location = new System.Drawing.Point(1353, 208);
			this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_password.Name = "lbl_password";
			this.lbl_password.Size = new System.Drawing.Size(128, 20);
			this.lbl_password.TabIndex = 15;
			this.lbl_password.Text = "Password OAuth";
			// 
			// lnk_OAuth
			// 
			this.lnk_OAuth.AutoSize = true;
			this.lnk_OAuth.Location = new System.Drawing.Point(1401, 740);
			this.lnk_OAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lnk_OAuth.Name = "lnk_OAuth";
			this.lnk_OAuth.Size = new System.Drawing.Size(128, 20);
			this.lnk_OAuth.TabIndex = 16;
			this.lnk_OAuth.TabStop = true;
			this.lnk_OAuth.Tag = "http://twitchapps.com/tmi/";
			this.lnk_OAuth.Text = "OAuth Password";
			this.lnk_OAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_OAuth_LinkClicked);
			// 
			// cbx_autoscroll
			// 
			this.cbx_autoscroll.AutoSize = true;
			this.cbx_autoscroll.Checked = true;
			this.cbx_autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbx_autoscroll.Location = new System.Drawing.Point(1356, 603);
			this.cbx_autoscroll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbx_autoscroll.Name = "cbx_autoscroll";
			this.cbx_autoscroll.Size = new System.Drawing.Size(109, 24);
			this.cbx_autoscroll.TabIndex = 17;
			this.cbx_autoscroll.Text = "Auto scroll";
			this.cbx_autoscroll.UseVisualStyleBackColor = true;
			// 
			// cbx_rememberMe
			// 
			this.cbx_rememberMe.AutoSize = true;
			this.cbx_rememberMe.Location = new System.Drawing.Point(1356, 568);
			this.cbx_rememberMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbx_rememberMe.Name = "cbx_rememberMe";
			this.cbx_rememberMe.Size = new System.Drawing.Size(144, 24);
			this.cbx_rememberMe.TabIndex = 18;
			this.cbx_rememberMe.Text = "Remember me!";
			this.cbx_rememberMe.UseVisualStyleBackColor = true;
			this.cbx_rememberMe.CheckedChanged += new System.EventHandler(this.cbx_rememberMe_CheckedChanged);
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(255, 19);
			this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(112, 35);
			this.btn_clear.TabIndex = 19;
			this.btn_clear.Text = "CLEAR";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_copyToClip
			// 
			this.btn_copyToClip.Location = new System.Drawing.Point(375, 19);
			this.btn_copyToClip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_copyToClip.Name = "btn_copyToClip";
			this.btn_copyToClip.Size = new System.Drawing.Size(112, 35);
			this.btn_copyToClip.TabIndex = 20;
			this.btn_copyToClip.Text = "COPY ID";
			this.btn_copyToClip.UseVisualStyleBackColor = true;
			this.btn_copyToClip.Click += new System.EventHandler(this.btn_copyToClip_Click);
			// 
			// lbx_currentChat
			// 
			this.lbx_currentChat.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lbx_currentChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbx_currentChat.FormattingEnabled = true;
			this.lbx_currentChat.ItemHeight = 20;
			this.lbx_currentChat.Location = new System.Drawing.Point(18, 103);
			this.lbx_currentChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lbx_currentChat.Name = "lbx_currentChat";
			this.lbx_currentChat.Size = new System.Drawing.Size(1290, 620);
			this.lbx_currentChat.TabIndex = 22;
			// 
			// cbx_hour
			// 
			this.cbx_hour.AutoSize = true;
			this.cbx_hour.Checked = true;
			this.cbx_hour.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbx_hour.Location = new System.Drawing.Point(1356, 638);
			this.cbx_hour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbx_hour.Name = "cbx_hour";
			this.cbx_hour.Size = new System.Drawing.Size(120, 24);
			this.cbx_hour.TabIndex = 23;
			this.cbx_hour.Text = "Display time";
			this.cbx_hour.UseVisualStyleBackColor = true;
			// 
			// timer_repeat
			// 
			this.timer_repeat.Tick += new System.EventHandler(this.timer_repeat_Tick);
			// 
			// timer_repeat2
			// 
			this.timer_repeat2.Tick += new System.EventHandler(this.timer_repeat2_Tick);
			// 
			// timer_repeat3
			// 
			this.timer_repeat3.Tick += new System.EventHandler(this.timer_repeat3_Tick);
			// 
			// timer_repeat4
			// 
			this.timer_repeat4.Tick += new System.EventHandler(this.timer_repeat4_Tick);
			// 
			// nud_minTimeRepeat
			// 
			this.nud_minTimeRepeat.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_minTimeRepeat.Location = new System.Drawing.Point(1354, 354);
			this.nud_minTimeRepeat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nud_minTimeRepeat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nud_minTimeRepeat.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nud_minTimeRepeat.Name = "nud_minTimeRepeat";
			this.nud_minTimeRepeat.Size = new System.Drawing.Size(218, 26);
			this.nud_minTimeRepeat.TabIndex = 24;
			this.nud_minTimeRepeat.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// nud_timeByLettre
			// 
			this.nud_timeByLettre.Location = new System.Drawing.Point(1354, 414);
			this.nud_timeByLettre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nud_timeByLettre.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nud_timeByLettre.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_timeByLettre.Name = "nud_timeByLettre";
			this.nud_timeByLettre.Size = new System.Drawing.Size(218, 26);
			this.nud_timeByLettre.TabIndex = 25;
			this.nud_timeByLettre.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// lbl_minTimeRepeat
			// 
			this.lbl_minTimeRepeat.AutoSize = true;
			this.lbl_minTimeRepeat.Location = new System.Drawing.Point(1352, 329);
			this.lbl_minTimeRepeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_minTimeRepeat.Name = "lbl_minTimeRepeat";
			this.lbl_minTimeRepeat.Size = new System.Drawing.Size(144, 20);
			this.lbl_minTimeRepeat.TabIndex = 26;
			this.lbl_minTimeRepeat.Text = "Min time delay (ms)";
			// 
			// lbl_timeByLettre
			// 
			this.lbl_timeByLettre.AutoSize = true;
			this.lbl_timeByLettre.Location = new System.Drawing.Point(1352, 389);
			this.lbl_timeByLettre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_timeByLettre.Name = "lbl_timeByLettre";
			this.lbl_timeByLettre.Size = new System.Drawing.Size(217, 20);
			this.lbl_timeByLettre.TabIndex = 27;
			this.lbl_timeByLettre.Text = "Time between each char (ms)";
			// 
			// lbl_suffix
			// 
			this.lbl_suffix.AutoSize = true;
			this.lbl_suffix.Location = new System.Drawing.Point(1358, 455);
			this.lbl_suffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_suffix.Name = "lbl_suffix";
			this.lbl_suffix.Size = new System.Drawing.Size(66, 20);
			this.lbl_suffix.TabIndex = 28;
			this.lbl_suffix.Text = "Suffixes";
			// 
			// tbx_suffix
			// 
			this.tbx_suffix.Location = new System.Drawing.Point(1354, 480);
			this.tbx_suffix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbx_suffix.Name = "tbx_suffix";
			this.tbx_suffix.Size = new System.Drawing.Size(216, 26);
			this.tbx_suffix.TabIndex = 29;
			this.tbx_suffix.Leave += new System.EventHandler(this.tbx_suffix_Leave);
			// 
			// ttip_suffix
			// 
			this.ttip_suffix.AutomaticDelay = 100;
			this.ttip_suffix.AutoPopDelay = 3000;
			this.ttip_suffix.InitialDelay = 100;
			this.ttip_suffix.ReshowDelay = 20;
			this.ttip_suffix.ToolTipTitle = "You can write ";
			// 
			// btn_after
			// 
			this.btn_after.ForeColor = System.Drawing.Color.Red;
			this.btn_after.Location = new System.Drawing.Point(539, 57);
			this.btn_after.Name = "btn_after";
			this.btn_after.Size = new System.Drawing.Size(112, 33);
			this.btn_after.TabIndex = 30;
			this.btn_after.Text = "Off";
			this.btn_after.UseVisualStyleBackColor = true;
			this.btn_after.Click += new System.EventHandler(this.Btn_after_Click);
			// 
			// tbx_afterOnText
			// 
			this.tbx_afterOnText.Location = new System.Drawing.Point(713, 61);
			this.tbx_afterOnText.Name = "tbx_afterOnText";
			this.tbx_afterOnText.Size = new System.Drawing.Size(261, 26);
			this.tbx_afterOnText.TabIndex = 31;
			this.tbx_afterOnText.Text = "TO|to|To";
			this.ttip_suffix.SetToolTip(this.tbx_afterOnText, "séparation par des mots par |");
			this.tbx_afterOnText.Leave += new System.EventHandler(this.Tbx_afterOnText_Leave);
			// 
			// tbx_afterDoText
			// 
			this.tbx_afterDoText.Location = new System.Drawing.Point(1047, 60);
			this.tbx_afterDoText.Name = "tbx_afterDoText";
			this.tbx_afterDoText.Size = new System.Drawing.Size(261, 26);
			this.tbx_afterDoText.TabIndex = 32;
			this.tbx_afterDoText.Text = "/timeout {0} 100";
			this.ttip_suffix.SetToolTip(this.tbx_afterDoText, "{0} = nickname");
			this.tbx_afterDoText.Leave += new System.EventHandler(this.Tbx_afterOnText_Leave);
			// 
			// lbl_afterOnText
			// 
			this.lbl_afterOnText.AutoSize = true;
			this.lbl_afterOnText.Location = new System.Drawing.Point(688, 63);
			this.lbl_afterOnText.Name = "lbl_afterOnText";
			this.lbl_afterOnText.Size = new System.Drawing.Size(19, 20);
			this.lbl_afterOnText.TabIndex = 33;
			this.lbl_afterOnText.Text = "If";
			// 
			// lbl_afterDoText
			// 
			this.lbl_afterDoText.AutoSize = true;
			this.lbl_afterDoText.Location = new System.Drawing.Point(995, 63);
			this.lbl_afterDoText.Name = "lbl_afterDoText";
			this.lbl_afterDoText.Size = new System.Drawing.Size(46, 20);
			this.lbl_afterDoText.TabIndex = 34;
			this.lbl_afterDoText.Text = "Write";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(1617, 760);
			this.Controls.Add(this.lbl_afterDoText);
			this.Controls.Add(this.lbl_afterOnText);
			this.Controls.Add(this.tbx_afterDoText);
			this.Controls.Add(this.tbx_afterOnText);
			this.Controls.Add(this.btn_after);
			this.Controls.Add(this.tbx_suffix);
			this.Controls.Add(this.lbl_suffix);
			this.Controls.Add(this.lbl_timeByLettre);
			this.Controls.Add(this.lbl_minTimeRepeat);
			this.Controls.Add(this.nud_timeByLettre);
			this.Controls.Add(this.nud_minTimeRepeat);
			this.Controls.Add(this.cbx_hour);
			this.Controls.Add(this.lbx_currentChat);
			this.Controls.Add(this.btn_copyToClip);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.cbx_rememberMe);
			this.Controls.Add(this.cbx_autoscroll);
			this.Controls.Add(this.lnk_OAuth);
			this.Controls.Add(this.lbl_password);
			this.Controls.Add(this.lbl_NickName);
			this.Controls.Add(this.lbl_tvTwitch);
			this.Controls.Add(this.tbx_password);
			this.Controls.Add(this.tbx_userName);
			this.Controls.Add(this.tbx_tvTwitch);
			this.Controls.Add(this.btn_setting);
			this.Controls.Add(this.btn_send);
			this.Controls.Add(this.tbx_send);
			this.Controls.Add(this.tbx_repeatUserName);
			this.Controls.Add(this.btn_repeat);
			this.Controls.Add(this.btn_kamoulox);
			this.Controls.Add(this.lbl_isConnected);
			this.Controls.Add(this.btn_connection);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(1639, 816);
			this.MinimumSize = new System.Drawing.Size(1339, 816);
			this.Name = "Form1";
			this.Text = "Twitch Bot Troller";
			((System.ComponentModel.ISupportInitialize)(this.nud_minTimeRepeat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_timeByLettre)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Label lbl_isConnected;
        private System.Windows.Forms.Button btn_kamoulox;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.TextBox tbx_repeatUserName;
        private System.Windows.Forms.TextBox tbx_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Timer timer_connection;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.TextBox tbx_tvTwitch;
        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_tvTwitch;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.LinkLabel lnk_OAuth;
        private System.Windows.Forms.CheckBox cbx_autoscroll;
        private System.Windows.Forms.CheckBox cbx_rememberMe;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_copyToClip;
        private System.Windows.Forms.ListBox lbx_currentChat;
        private System.Windows.Forms.CheckBox cbx_hour;
        private System.Windows.Forms.Timer timer_repeat;
        private System.Windows.Forms.Timer timer_repeat2;
        private System.Windows.Forms.Timer timer_repeat3;
        private System.Windows.Forms.Timer timer_repeat4;
        private System.Windows.Forms.NumericUpDown nud_minTimeRepeat;
        private System.Windows.Forms.NumericUpDown nud_timeByLettre;
        private System.Windows.Forms.Label lbl_minTimeRepeat;
        private System.Windows.Forms.Label lbl_timeByLettre;
        private System.Windows.Forms.Label lbl_suffix;
        private System.Windows.Forms.TextBox tbx_suffix;
        private System.Windows.Forms.ToolTip ttip_suffix;
		private System.Windows.Forms.Button btn_after;
		private System.Windows.Forms.TextBox tbx_afterOnText;
		private System.Windows.Forms.TextBox tbx_afterDoText;
		private System.Windows.Forms.Label lbl_afterOnText;
		private System.Windows.Forms.Label lbl_afterDoText;
	}
}

