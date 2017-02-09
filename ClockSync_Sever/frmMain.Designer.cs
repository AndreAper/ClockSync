namespace ClockSync_Receiver
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._lblServerStatus = new System.Windows.Forms.Label();
            this._btnStopServer = new System.Windows.Forms.Button();
            this._btnStartServer = new System.Windows.Forms.Button();
            this._lbxLog = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this._lnkLblClearLogBox = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this._lblCurrentTime = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // _lblServerStatus
            // 
            this._lblServerStatus.BackColor = System.Drawing.Color.Tomato;
            this._lblServerStatus.Location = new System.Drawing.Point(98, 12);
            this._lblServerStatus.Margin = new System.Windows.Forms.Padding(3);
            this._lblServerStatus.Name = "_lblServerStatus";
            this._lblServerStatus.Padding = new System.Windows.Forms.Padding(3);
            this._lblServerStatus.Size = new System.Drawing.Size(143, 23);
            this._lblServerStatus.TabIndex = 0;
            this._lblServerStatus.Text = "Offline";
            // 
            // _btnStopServer
            // 
            this._btnStopServer.AutoSize = true;
            this._btnStopServer.Enabled = false;
            this._btnStopServer.Location = new System.Drawing.Point(96, 372);
            this._btnStopServer.Name = "_btnStopServer";
            this._btnStopServer.Size = new System.Drawing.Size(75, 27);
            this._btnStopServer.TabIndex = 6;
            this._btnStopServer.Text = "Stop";
            this._btnStopServer.UseVisualStyleBackColor = true;
            this._btnStopServer.Click += new System.EventHandler(this._btnStopServer_Click);
            // 
            // _btnStartServer
            // 
            this._btnStartServer.AutoSize = true;
            this._btnStartServer.Location = new System.Drawing.Point(15, 372);
            this._btnStartServer.Name = "_btnStartServer";
            this._btnStartServer.Size = new System.Drawing.Size(75, 27);
            this._btnStartServer.TabIndex = 7;
            this._btnStartServer.Text = "Start";
            this._btnStartServer.UseVisualStyleBackColor = true;
            this._btnStartServer.Click += new System.EventHandler(this._btnStartServer_Click);
            // 
            // _lbxLog
            // 
            this._lbxLog.FormattingEnabled = true;
            this._lbxLog.ItemHeight = 17;
            this._lbxLog.Location = new System.Drawing.Point(12, 70);
            this._lbxLog.Name = "_lbxLog";
            this._lbxLog.Size = new System.Drawing.Size(655, 293);
            this._lbxLog.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Log";
            // 
            // _lnkLblClearLogBox
            // 
            this._lnkLblClearLogBox.AutoSize = true;
            this._lnkLblClearLogBox.Location = new System.Drawing.Point(630, 366);
            this._lnkLblClearLogBox.Name = "_lnkLblClearLogBox";
            this._lnkLblClearLogBox.Size = new System.Drawing.Size(37, 17);
            this._lnkLblClearLogBox.TabIndex = 9;
            this._lnkLblClearLogBox.TabStop = true;
            this._lnkLblClearLogBox.Text = "Clear";
            this._lnkLblClearLogBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkLblClearLogBox_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Time";
            // 
            // _lblCurrentTime
            // 
            this._lblCurrentTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this._lblCurrentTime.Location = new System.Drawing.Point(353, 12);
            this._lblCurrentTime.Margin = new System.Windows.Forms.Padding(3);
            this._lblCurrentTime.Name = "_lblCurrentTime";
            this._lblCurrentTime.Padding = new System.Windows.Forms.Padding(3);
            this._lblCurrentTime.Size = new System.Drawing.Size(143, 23);
            this._lblCurrentTime.TabIndex = 0;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this._lnkLblClearLogBox);
            this.Controls.Add(this._lbxLog);
            this.Controls.Add(this._btnStopServer);
            this.Controls.Add(this._btnStartServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._lblCurrentTime);
            this.Controls.Add(this._lblServerStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "ClockSync Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblServerStatus;
        private System.Windows.Forms.Button _btnStopServer;
        private System.Windows.Forms.Button _btnStartServer;
        private System.Windows.Forms.ListBox _lbxLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel _lnkLblClearLogBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblCurrentTime;
        private System.Windows.Forms.Timer clock;
    }
}

