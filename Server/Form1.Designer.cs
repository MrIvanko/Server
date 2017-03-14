namespace ServerApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chatLogTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLogTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendPrivateMessageButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.broadcastButton = new System.Windows.Forms.Button();
            this.disconnectClientButton = new System.Windows.Forms.Button();
            this.clientNameListBox = new System.Windows.Forms.ListBox();
            this.ipAddressListBox = new System.Windows.Forms.ListBox();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.actualLocalIP = new System.Windows.Forms.Label();
            this.startHttpServerButton = new System.Windows.Forms.Button();
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            this.SuspendLayout();
            // 
            // chatLogTextBox
            // 
            this.chatLogTextBox.Location = new System.Drawing.Point(334, 31);
            this.chatLogTextBox.Multiline = true;
            this.chatLogTextBox.Name = "chatLogTextBox";
            this.chatLogTextBox.ReadOnly = true;
            this.chatLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.chatLogTextBox.Size = new System.Drawing.Size(281, 270);
            this.chatLogTextBox.TabIndex = 3;
            this.chatLogTextBox.TextChanged += new System.EventHandler(this.chatLogTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ClientName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ip Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chat Log";
            // 
            // timeLogTextBox
            // 
            this.timeLogTextBox.Location = new System.Drawing.Point(622, 31);
            this.timeLogTextBox.Multiline = true;
            this.timeLogTextBox.Name = "timeLogTextBox";
            this.timeLogTextBox.ReadOnly = true;
            this.timeLogTextBox.Size = new System.Drawing.Size(100, 270);
            this.timeLogTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time Log";
            // 
            // sendPrivateMessageButton
            // 
            this.sendPrivateMessageButton.Location = new System.Drawing.Point(334, 332);
            this.sendPrivateMessageButton.Name = "sendPrivateMessageButton";
            this.sendPrivateMessageButton.Size = new System.Drawing.Size(151, 23);
            this.sendPrivateMessageButton.TabIndex = 10;
            this.sendPrivateMessageButton.Text = "Send Private Message";
            this.sendPrivateMessageButton.UseVisualStyleBackColor = true;
            this.sendPrivateMessageButton.Click += new System.EventHandler(this.sendPrivateMessageButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(120, 334);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(207, 60);
            this.messageTextBox.TabIndex = 11;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Message";
            // 
            // broadcastButton
            // 
            this.broadcastButton.Location = new System.Drawing.Point(334, 361);
            this.broadcastButton.Name = "broadcastButton";
            this.broadcastButton.Size = new System.Drawing.Size(151, 23);
            this.broadcastButton.TabIndex = 13;
            this.broadcastButton.Text = "Broadcast";
            this.broadcastButton.UseVisualStyleBackColor = true;
            this.broadcastButton.Click += new System.EventHandler(this.broadcastButton_Click);
            // 
            // disconnectClientButton
            // 
            this.disconnectClientButton.Location = new System.Drawing.Point(8, 332);
            this.disconnectClientButton.Name = "disconnectClientButton";
            this.disconnectClientButton.Size = new System.Drawing.Size(106, 62);
            this.disconnectClientButton.TabIndex = 14;
            this.disconnectClientButton.Text = "Disconnect Client";
            this.disconnectClientButton.UseVisualStyleBackColor = true;
            this.disconnectClientButton.Click += new System.EventHandler(this.disconnectClientButton_Click);
            // 
            // clientNameListBox
            // 
            this.clientNameListBox.FormattingEnabled = true;
            this.clientNameListBox.Location = new System.Drawing.Point(12, 31);
            this.clientNameListBox.Name = "clientNameListBox";
            this.clientNameListBox.Size = new System.Drawing.Size(123, 277);
            this.clientNameListBox.TabIndex = 15;
            this.clientNameListBox.SelectedIndexChanged += new System.EventHandler(this.clientNameListBox_SelectedIndexChanged);
            // 
            // ipAddressListBox
            // 
            this.ipAddressListBox.FormattingEnabled = true;
            this.ipAddressListBox.Location = new System.Drawing.Point(141, 31);
            this.ipAddressListBox.Name = "ipAddressListBox";
            this.ipAddressListBox.Size = new System.Drawing.Size(94, 277);
            this.ipAddressListBox.TabIndex = 16;
            this.ipAddressListBox.SelectedIndexChanged += new System.EventHandler(this.ipAddressListBox_SelectedIndexChanged);
            // 
            // portListBox
            // 
            this.portListBox.FormattingEnabled = true;
            this.portListBox.Location = new System.Drawing.Point(241, 31);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(86, 277);
            this.portListBox.TabIndex = 17;
            this.portListBox.SelectedIndexChanged += new System.EventHandler(this.portListBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(947, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "Connection Counter";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel3.Text = "Available Ports";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel4.Text = "0";
            // 
            // actualLocalIP
            // 
            this.actualLocalIP.AutoSize = true;
            this.actualLocalIP.Location = new System.Drawing.Point(619, 409);
            this.actualLocalIP.Name = "actualLocalIP";
            this.actualLocalIP.Size = new System.Drawing.Size(40, 13);
            this.actualLocalIP.TabIndex = 19;
            this.actualLocalIP.Text = "0.0.0.0";
            // 
            // startHttpServerButton
            // 
            this.startHttpServerButton.Location = new System.Drawing.Point(531, 331);
            this.startHttpServerButton.Name = "startHttpServerButton";
            this.startHttpServerButton.Size = new System.Drawing.Size(75, 23);
            this.startHttpServerButton.TabIndex = 20;
            this.startHttpServerButton.Text = "Start http server";
            this.startHttpServerButton.UseVisualStyleBackColor = true;
            this.startHttpServerButton.Click += new System.EventHandler(this.startHttpServerButton_Click);
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(751, 31);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(184, 98);
            this.axVideoChatReceiver1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 422);
            this.Controls.Add(this.axVideoChatReceiver1);
            this.Controls.Add(this.startHttpServerButton);
            this.Controls.Add(this.actualLocalIP);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.portListBox);
            this.Controls.Add(this.ipAddressListBox);
            this.Controls.Add(this.clientNameListBox);
            this.Controls.Add(this.disconnectClientButton);
            this.Controls.Add(this.broadcastButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.sendPrivateMessageButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeLogTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatLogTextBox);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox chatLogTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeLogTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sendPrivateMessageButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button broadcastButton;
        private System.Windows.Forms.Button disconnectClientButton;
        private System.Windows.Forms.ListBox clientNameListBox;
        private System.Windows.Forms.ListBox ipAddressListBox;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label actualLocalIP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Button startHttpServerButton;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
    }
}

