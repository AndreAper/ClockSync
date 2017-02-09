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
            this._tbxIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._tbxPort = new System.Windows.Forms.TextBox();
            this._btnStartReceiver = new System.Windows.Forms.Button();
            this._btnStopReceiver = new System.Windows.Forms.Button();
            this._lblServerStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._dtpRepeatTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._btnPull = new System.Windows.Forms.Button();
            this._lbxLog = new System.Windows.Forms.ListBox();
            this._lnkLblClearLogBox = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this._lblCurrentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _tbxIpAddress
            // 
            this._tbxIpAddress.Location = new System.Drawing.Point(98, 42);
            this._tbxIpAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tbxIpAddress.Name = "_tbxIpAddress";
            this._tbxIpAddress.Size = new System.Drawing.Size(330, 25);
            this._tbxIpAddress.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // _tbxPort
            // 
            this._tbxPort.Location = new System.Drawing.Point(479, 42);
            this._tbxPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tbxPort.Name = "_tbxPort";
            this._tbxPort.Size = new System.Drawing.Size(99, 25);
            this._tbxPort.TabIndex = 20;
            // 
            // _btnStartReceiver
            // 
            this._btnStartReceiver.AutoSize = true;
            this._btnStartReceiver.Location = new System.Drawing.Point(15, 372);
            this._btnStartReceiver.Name = "_btnStartReceiver";
            this._btnStartReceiver.Size = new System.Drawing.Size(75, 27);
            this._btnStartReceiver.TabIndex = 40;
            this._btnStartReceiver.Text = "Start";
            this._btnStartReceiver.UseVisualStyleBackColor = true;
            this._btnStartReceiver.Click += new System.EventHandler(this._btnStartReceiver_Click);
            // 
            // _btnStopReceiver
            // 
            this._btnStopReceiver.AutoSize = true;
            this._btnStopReceiver.Enabled = false;
            this._btnStopReceiver.Location = new System.Drawing.Point(96, 372);
            this._btnStopReceiver.Name = "_btnStopReceiver";
            this._btnStopReceiver.Size = new System.Drawing.Size(75, 27);
            this._btnStopReceiver.TabIndex = 50;
            this._btnStopReceiver.Text = "Stop";
            this._btnStopReceiver.UseVisualStyleBackColor = true;
            this._btnStopReceiver.Click += new System.EventHandler(this._btnStopReceiver_Click);
            // 
            // _lblServerStatus
            // 
            this._lblServerStatus.BackColor = System.Drawing.Color.Tomato;
            this._lblServerStatus.Location = new System.Drawing.Point(98, 12);
            this._lblServerStatus.Margin = new System.Windows.Forms.Padding(3);
            this._lblServerStatus.Name = "_lblServerStatus";
            this._lblServerStatus.Padding = new System.Windows.Forms.Padding(3);
            this._lblServerStatus.Size = new System.Drawing.Size(143, 23);
            this._lblServerStatus.TabIndex = 6;
            this._lblServerStatus.Text = "Offline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // _dtpRepeatTime
            // 
            this._dtpRepeatTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this._dtpRepeatTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._dtpRepeatTime.Location = new System.Drawing.Point(98, 74);
            this._dtpRepeatTime.Name = "_dtpRepeatTime";
            this._dtpRepeatTime.ShowUpDown = true;
            this._dtpRepeatTime.Size = new System.Drawing.Size(142, 25);
            this._dtpRepeatTime.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Repeat time:";
            // 
            // _timer
            // 
            this._timer.Interval = 1000;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // _btnPull
            // 
            this._btnPull.AutoSize = true;
            this._btnPull.Location = new System.Drawing.Point(177, 372);
            this._btnPull.Name = "_btnPull";
            this._btnPull.Size = new System.Drawing.Size(75, 27);
            this._btnPull.TabIndex = 50;
            this._btnPull.Text = "Pull";
            this._btnPull.UseVisualStyleBackColor = true;
            this._btnPull.Click += new System.EventHandler(this._btnPull_Click);
            // 
            // _lbxLog
            // 
            this._lbxLog.FormattingEnabled = true;
            this._lbxLog.ItemHeight = 17;
            this._lbxLog.Location = new System.Drawing.Point(15, 113);
            this._lbxLog.Name = "_lbxLog";
            this._lbxLog.Size = new System.Drawing.Size(655, 242);
            this._lbxLog.TabIndex = 51;
            // 
            // _lnkLblClearLogBox
            // 
            this._lnkLblClearLogBox.AutoSize = true;
            this._lnkLblClearLogBox.Location = new System.Drawing.Point(633, 358);
            this._lnkLblClearLogBox.Name = "_lnkLblClearLogBox";
            this._lnkLblClearLogBox.Size = new System.Drawing.Size(37, 17);
            this._lnkLblClearLogBox.TabIndex = 52;
            this._lnkLblClearLogBox.TabStop = true;
            this._lnkLblClearLogBox.Text = "Clear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(584, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Default: 1895";
            // 
            // _lblCurrentTime
            // 
            this._lblCurrentTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this._lblCurrentTime.Location = new System.Drawing.Point(353, 12);
            this._lblCurrentTime.Margin = new System.Windows.Forms.Padding(3);
            this._lblCurrentTime.Name = "_lblCurrentTime";
            this._lblCurrentTime.Padding = new System.Windows.Forms.Padding(3);
            this._lblCurrentTime.Size = new System.Drawing.Size(143, 23);
            this._lblCurrentTime.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Current Time";
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
            this.Controls.Add(this._lblCurrentTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lnkLblClearLogBox);
            this.Controls.Add(this._lbxLog);
            this.Controls.Add(this._dtpRepeatTime);
            this.Controls.Add(this._lblServerStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._btnPull);
            this.Controls.Add(this._btnStopReceiver);
            this.Controls.Add(this._btnStartReceiver);
            this.Controls.Add(this._tbxPort);
            this.Controls.Add(this._tbxIpAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "ClockSync Receiver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbxIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbxPort;
        private System.Windows.Forms.Button _btnStartReceiver;
        private System.Windows.Forms.Button _btnStopReceiver;
        private System.Windows.Forms.Label _lblServerStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker _dtpRepeatTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Button _btnPull;
        private System.Windows.Forms.ListBox _lbxLog;
        private System.Windows.Forms.LinkLabel _lnkLblClearLogBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblCurrentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer clock;
    }
}

