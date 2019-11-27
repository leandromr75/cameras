namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.streamPlayerControl1 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this._urlTextBox = new System.Windows.Forms.TextBox();
            this._playButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._imageButton = new System.Windows.Forms.Button();
            this._statusTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._statusTextBox2 = new System.Windows.Forms.TextBox();
            this._imageButton2 = new System.Windows.Forms.Button();
            this._stopButton2 = new System.Windows.Forms.Button();
            this._playButton2 = new System.Windows.Forms.Button();
            this._urlTextBox2 = new System.Windows.Forms.TextBox();
            this.streamPlayerControl2 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.button6 = new System.Windows.Forms.Button();
            this._statusTextBox3 = new System.Windows.Forms.TextBox();
            this._imageButton3 = new System.Windows.Forms.Button();
            this._stopButton3 = new System.Windows.Forms.Button();
            this._playButton3 = new System.Windows.Forms.Button();
            this._urlTextBox3 = new System.Windows.Forms.TextBox();
            this.streamPlayerControl3 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.button10 = new System.Windows.Forms.Button();
            this._statusTextBox4 = new System.Windows.Forms.TextBox();
            this._imageButton4 = new System.Windows.Forms.Button();
            this._stopButton4 = new System.Windows.Forms.Button();
            this._playButton4 = new System.Windows.Forms.Button();
            this._urlTextBox4 = new System.Windows.Forms.TextBox();
            this.streamPlayerControl4 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // streamPlayerControl1
            // 
            this.streamPlayerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streamPlayerControl1.Location = new System.Drawing.Point(22, 14);
            this.streamPlayerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.streamPlayerControl1.Name = "streamPlayerControl1";
            this.streamPlayerControl1.Size = new System.Drawing.Size(300, 250);
            this.streamPlayerControl1.TabIndex = 0;
            this.streamPlayerControl1.StreamStarted += new System.EventHandler(this.HandleStreamStartedEvent);
            this.streamPlayerControl1.StreamStopped += new System.EventHandler(this.HandleStreamStoppedEvent);
            this.streamPlayerControl1.StreamFailed += new System.EventHandler<WebEye.Controls.WinForms.StreamPlayerControl.StreamFailedEventArgs>(this.HandleStreamFailedEvent);
            // 
            // _urlTextBox
            // 
            this._urlTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._urlTextBox.Location = new System.Drawing.Point(22, 268);
            this._urlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._urlTextBox.Name = "_urlTextBox";
            this._urlTextBox.Size = new System.Drawing.Size(300, 20);
            this._urlTextBox.TabIndex = 1;
            this._urlTextBox.Text = "rtsp://admin:TLXVKN@192.168.0.104/mpeg4/media.amp";
            // 
            // _playButton
            // 
            this._playButton.Location = new System.Drawing.Point(22, 292);
            this._playButton.Margin = new System.Windows.Forms.Padding(2);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(50, 24);
            this._playButton.TabIndex = 2;
            this._playButton.Text = "Play";
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.Enabled = false;
            this._stopButton.Location = new System.Drawing.Point(22, 320);
            this._stopButton.Margin = new System.Windows.Forms.Padding(2);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(50, 24);
            this._stopButton.TabIndex = 3;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // _imageButton
            // 
            this._imageButton.Enabled = false;
            this._imageButton.Location = new System.Drawing.Point(197, 292);
            this._imageButton.Margin = new System.Windows.Forms.Padding(2);
            this._imageButton.Name = "_imageButton";
            this._imageButton.Size = new System.Drawing.Size(50, 24);
            this._imageButton.TabIndex = 4;
            this._imageButton.Text = "REC";
            this._imageButton.UseVisualStyleBackColor = true;
            this._imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // _statusTextBox
            // 
            this._statusTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._statusTextBox.Enabled = false;
            this._statusTextBox.Location = new System.Drawing.Point(251, 292);
            this._statusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._statusTextBox.Name = "_statusTextBox";
            this._statusTextBox.Size = new System.Drawing.Size(71, 20);
            this._statusTextBox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 24);
            this.button2.TabIndex = 13;
            this.button2.Text = "Stop Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _statusTextBox2
            // 
            this._statusTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._statusTextBox2.Enabled = false;
            this._statusTextBox2.Location = new System.Drawing.Point(652, 292);
            this._statusTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this._statusTextBox2.Name = "_statusTextBox2";
            this._statusTextBox2.Size = new System.Drawing.Size(71, 20);
            this._statusTextBox2.TabIndex = 12;
            // 
            // _imageButton2
            // 
            this._imageButton2.Location = new System.Drawing.Point(598, 292);
            this._imageButton2.Margin = new System.Windows.Forms.Padding(2);
            this._imageButton2.Name = "_imageButton2";
            this._imageButton2.Size = new System.Drawing.Size(50, 24);
            this._imageButton2.TabIndex = 11;
            this._imageButton2.Text = "REC";
            this._imageButton2.UseVisualStyleBackColor = true;
            this._imageButton2.Click += new System.EventHandler(this._imageButton2_Click);
            // 
            // _stopButton2
            // 
            this._stopButton2.Location = new System.Drawing.Point(423, 320);
            this._stopButton2.Margin = new System.Windows.Forms.Padding(2);
            this._stopButton2.Name = "_stopButton2";
            this._stopButton2.Size = new System.Drawing.Size(50, 24);
            this._stopButton2.TabIndex = 10;
            this._stopButton2.Text = "Stop";
            this._stopButton2.UseVisualStyleBackColor = true;
            this._stopButton2.Click += new System.EventHandler(this._stopButton2_Click);
            // 
            // _playButton2
            // 
            this._playButton2.Location = new System.Drawing.Point(423, 292);
            this._playButton2.Margin = new System.Windows.Forms.Padding(2);
            this._playButton2.Name = "_playButton2";
            this._playButton2.Size = new System.Drawing.Size(50, 24);
            this._playButton2.TabIndex = 9;
            this._playButton2.Text = "Play";
            this._playButton2.UseVisualStyleBackColor = true;
            this._playButton2.Click += new System.EventHandler(this._playButton2_Click);
            // 
            // _urlTextBox2
            // 
            this._urlTextBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._urlTextBox2.Location = new System.Drawing.Point(423, 268);
            this._urlTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this._urlTextBox2.Name = "_urlTextBox2";
            this._urlTextBox2.Size = new System.Drawing.Size(300, 20);
            this._urlTextBox2.TabIndex = 8;
            this._urlTextBox2.Text = "rtsp://admin:QUHQJA@192.168.0.105/mpeg4/media.amp";
            // 
            // streamPlayerControl2
            // 
            this.streamPlayerControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streamPlayerControl2.Location = new System.Drawing.Point(423, 14);
            this.streamPlayerControl2.Margin = new System.Windows.Forms.Padding(2);
            this.streamPlayerControl2.Name = "streamPlayerControl2";
            this.streamPlayerControl2.Size = new System.Drawing.Size(300, 250);
            this.streamPlayerControl2.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(197, 670);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 24);
            this.button6.TabIndex = 20;
            this.button6.Text = "Stop Record";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // _statusTextBox3
            // 
            this._statusTextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._statusTextBox3.Enabled = false;
            this._statusTextBox3.Location = new System.Drawing.Point(251, 642);
            this._statusTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this._statusTextBox3.Name = "_statusTextBox3";
            this._statusTextBox3.Size = new System.Drawing.Size(71, 20);
            this._statusTextBox3.TabIndex = 19;
            // 
            // _imageButton3
            // 
            this._imageButton3.Location = new System.Drawing.Point(197, 642);
            this._imageButton3.Margin = new System.Windows.Forms.Padding(2);
            this._imageButton3.Name = "_imageButton3";
            this._imageButton3.Size = new System.Drawing.Size(50, 24);
            this._imageButton3.TabIndex = 18;
            this._imageButton3.Text = "REC";
            this._imageButton3.UseVisualStyleBackColor = true;
            this._imageButton3.Click += new System.EventHandler(this._imageButton3_Click);
            // 
            // _stopButton3
            // 
            this._stopButton3.Location = new System.Drawing.Point(22, 670);
            this._stopButton3.Margin = new System.Windows.Forms.Padding(2);
            this._stopButton3.Name = "_stopButton3";
            this._stopButton3.Size = new System.Drawing.Size(50, 24);
            this._stopButton3.TabIndex = 17;
            this._stopButton3.Text = "Stop";
            this._stopButton3.UseVisualStyleBackColor = true;
            this._stopButton3.Click += new System.EventHandler(this._stopButton3_Click);
            // 
            // _playButton3
            // 
            this._playButton3.Location = new System.Drawing.Point(22, 642);
            this._playButton3.Margin = new System.Windows.Forms.Padding(2);
            this._playButton3.Name = "_playButton3";
            this._playButton3.Size = new System.Drawing.Size(50, 24);
            this._playButton3.TabIndex = 16;
            this._playButton3.Text = "Play";
            this._playButton3.UseVisualStyleBackColor = true;
            this._playButton3.Click += new System.EventHandler(this._playButton3_Click);
            // 
            // _urlTextBox3
            // 
            this._urlTextBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._urlTextBox3.Location = new System.Drawing.Point(22, 618);
            this._urlTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this._urlTextBox3.Name = "_urlTextBox3";
            this._urlTextBox3.Size = new System.Drawing.Size(300, 20);
            this._urlTextBox3.TabIndex = 15;
            this._urlTextBox3.Text = "rtsp://admin:IVNRWF@192.168.0.102/mpeg4/media.amp";
            // 
            // streamPlayerControl3
            // 
            this.streamPlayerControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streamPlayerControl3.Location = new System.Drawing.Point(22, 364);
            this.streamPlayerControl3.Margin = new System.Windows.Forms.Padding(2);
            this.streamPlayerControl3.Name = "streamPlayerControl3";
            this.streamPlayerControl3.Size = new System.Drawing.Size(300, 250);
            this.streamPlayerControl3.TabIndex = 14;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(598, 670);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 24);
            this.button10.TabIndex = 27;
            this.button10.Text = "Stop Record";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // _statusTextBox4
            // 
            this._statusTextBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._statusTextBox4.Enabled = false;
            this._statusTextBox4.Location = new System.Drawing.Point(652, 642);
            this._statusTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this._statusTextBox4.Name = "_statusTextBox4";
            this._statusTextBox4.Size = new System.Drawing.Size(71, 20);
            this._statusTextBox4.TabIndex = 26;
            // 
            // _imageButton4
            // 
            this._imageButton4.Location = new System.Drawing.Point(598, 642);
            this._imageButton4.Margin = new System.Windows.Forms.Padding(2);
            this._imageButton4.Name = "_imageButton4";
            this._imageButton4.Size = new System.Drawing.Size(50, 24);
            this._imageButton4.TabIndex = 25;
            this._imageButton4.Text = "REC";
            this._imageButton4.UseVisualStyleBackColor = true;
            this._imageButton4.Click += new System.EventHandler(this._imageButton4_Click);
            // 
            // _stopButton4
            // 
            this._stopButton4.Location = new System.Drawing.Point(423, 670);
            this._stopButton4.Margin = new System.Windows.Forms.Padding(2);
            this._stopButton4.Name = "_stopButton4";
            this._stopButton4.Size = new System.Drawing.Size(50, 24);
            this._stopButton4.TabIndex = 24;
            this._stopButton4.Text = "Stop";
            this._stopButton4.UseVisualStyleBackColor = true;
            this._stopButton4.Click += new System.EventHandler(this._stopButton4_Click);
            // 
            // _playButton4
            // 
            this._playButton4.Location = new System.Drawing.Point(423, 642);
            this._playButton4.Margin = new System.Windows.Forms.Padding(2);
            this._playButton4.Name = "_playButton4";
            this._playButton4.Size = new System.Drawing.Size(50, 24);
            this._playButton4.TabIndex = 23;
            this._playButton4.Text = "Play";
            this._playButton4.UseVisualStyleBackColor = true;
            this._playButton4.Click += new System.EventHandler(this._playButton4_Click);
            // 
            // _urlTextBox4
            // 
            this._urlTextBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._urlTextBox4.Location = new System.Drawing.Point(423, 618);
            this._urlTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this._urlTextBox4.Name = "_urlTextBox4";
            this._urlTextBox4.Size = new System.Drawing.Size(300, 20);
            this._urlTextBox4.TabIndex = 22;
            this._urlTextBox4.Text = "rtsp://admin:INGBQR@192.168.0.112/mpeg4/media.amp";
            // 
            // streamPlayerControl4
            // 
            this.streamPlayerControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streamPlayerControl4.Location = new System.Drawing.Point(423, 364);
            this.streamPlayerControl4.Margin = new System.Windows.Forms.Padding(2);
            this.streamPlayerControl4.Name = "streamPlayerControl4";
            this.streamPlayerControl4.Size = new System.Drawing.Size(300, 250);
            this.streamPlayerControl4.TabIndex = 21;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 200;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 42);
            this.button3.TabIndex = 28;
            this.button3.Text = "PLAY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 42);
            this.button4.TabIndex = 29;
            this.button4.Text = "REC";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 6000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(748, 711);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this._statusTextBox4);
            this.Controls.Add(this._imageButton4);
            this.Controls.Add(this._stopButton4);
            this.Controls.Add(this._playButton4);
            this.Controls.Add(this._urlTextBox4);
            this.Controls.Add(this.streamPlayerControl4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this._statusTextBox3);
            this.Controls.Add(this._imageButton3);
            this.Controls.Add(this._stopButton3);
            this.Controls.Add(this._playButton3);
            this.Controls.Add(this._urlTextBox3);
            this.Controls.Add(this.streamPlayerControl3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._statusTextBox2);
            this.Controls.Add(this._imageButton2);
            this.Controls.Add(this._stopButton2);
            this.Controls.Add(this._playButton2);
            this.Controls.Add(this._urlTextBox2);
            this.Controls.Add(this.streamPlayerControl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._statusTextBox);
            this.Controls.Add(this._imageButton);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._playButton);
            this.Controls.Add(this._urlTextBox);
            this.Controls.Add(this.streamPlayerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVR - RTSP Stream - [ArtChik 2018]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl streamPlayerControl1;
        private System.Windows.Forms.TextBox _urlTextBox;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.Button _imageButton;
        private System.Windows.Forms.TextBox _statusTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox _statusTextBox2;
        private System.Windows.Forms.Button _imageButton2;
        private System.Windows.Forms.Button _stopButton2;
        private System.Windows.Forms.Button _playButton2;
        private System.Windows.Forms.TextBox _urlTextBox2;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl streamPlayerControl2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox _statusTextBox3;
        private System.Windows.Forms.Button _imageButton3;
        private System.Windows.Forms.Button _stopButton3;
        private System.Windows.Forms.Button _playButton3;
        private System.Windows.Forms.TextBox _urlTextBox3;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl streamPlayerControl3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox _statusTextBox4;
        private System.Windows.Forms.Button _imageButton4;
        private System.Windows.Forms.Button _stopButton4;
        private System.Windows.Forms.Button _playButton4;
        private System.Windows.Forms.TextBox _urlTextBox4;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl streamPlayerControl4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

