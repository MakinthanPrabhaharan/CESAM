
namespace CESAM_HMI
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
            this.grpBoxCOMPort = new System.Windows.Forms.GroupBox();
            this.btnSerialDisconnect = new System.Windows.Forms.Button();
            this.lstBoxSerialPorts = new System.Windows.Forms.ListBox();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpBoxJog = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trkBarJogSpeed = new System.Windows.Forms.TrackBar();
            this.btnJogCW = new System.Windows.Forms.Button();
            this.btnJogCCW = new System.Windows.Forms.Button();
            this.lstBoxJogAxis = new System.Windows.Forms.ListBox();
            this.grpBoxAbsPos = new System.Windows.Forms.GroupBox();
            this.btnAbsPosition = new System.Windows.Forms.Button();
            this.txtBoxAbsPos = new System.Windows.Forms.TextBox();
            this.lblAxisCurrentPosition = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lstBoxAbsPositionAxis = new System.Windows.Forms.ListBox();
            this.grpBoxHoming = new System.Windows.Forms.GroupBox();
            this.txtBoxInitAngle = new System.Windows.Forms.TextBox();
            this.btnInitAxis = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstBoxHomeAxis = new System.Windows.Forms.ListBox();
            this.grpBoxESTOP = new System.Windows.Forms.GroupBox();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.grpboxJointMove = new System.Windows.Forms.GroupBox();
            this.grpBoxCmdWdw = new System.Windows.Forms.GroupBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.txtBoxCommand = new System.Windows.Forms.TextBox();
            this.lstBoxCommandWindow = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpBoxCOMPort.SuspendLayout();
            this.grpBoxJog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarJogSpeed)).BeginInit();
            this.grpBoxAbsPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.grpBoxHoming.SuspendLayout();
            this.grpBoxESTOP.SuspendLayout();
            this.grpBoxCmdWdw.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxCOMPort
            // 
            this.grpBoxCOMPort.Controls.Add(this.btnRefresh);
            this.grpBoxCOMPort.Controls.Add(this.btnSerialDisconnect);
            this.grpBoxCOMPort.Controls.Add(this.lstBoxSerialPorts);
            this.grpBoxCOMPort.Controls.Add(this.btnSerialConnect);
            this.grpBoxCOMPort.Location = new System.Drawing.Point(12, 22);
            this.grpBoxCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxCOMPort.Name = "grpBoxCOMPort";
            this.grpBoxCOMPort.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxCOMPort.Size = new System.Drawing.Size(324, 138);
            this.grpBoxCOMPort.TabIndex = 0;
            this.grpBoxCOMPort.TabStop = false;
            this.grpBoxCOMPort.Text = "Serial Port Selection";
            // 
            // btnSerialDisconnect
            // 
            this.btnSerialDisconnect.Location = new System.Drawing.Point(209, 85);
            this.btnSerialDisconnect.Name = "btnSerialDisconnect";
            this.btnSerialDisconnect.Size = new System.Drawing.Size(110, 47);
            this.btnSerialDisconnect.TabIndex = 3;
            this.btnSerialDisconnect.Text = "Disconnect";
            this.btnSerialDisconnect.UseVisualStyleBackColor = true;
            this.btnSerialDisconnect.Click += new System.EventHandler(this.btnSerialDisconnect_Click);
            // 
            // lstBoxSerialPorts
            // 
            this.lstBoxSerialPorts.FormattingEnabled = true;
            this.lstBoxSerialPorts.ItemHeight = 16;
            this.lstBoxSerialPorts.Location = new System.Drawing.Point(6, 32);
            this.lstBoxSerialPorts.Name = "lstBoxSerialPorts";
            this.lstBoxSerialPorts.Size = new System.Drawing.Size(196, 68);
            this.lstBoxSerialPorts.TabIndex = 2;
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Location = new System.Drawing.Point(208, 32);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(110, 47);
            this.btnSerialConnect.TabIndex = 1;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // grpBoxJog
            // 
            this.grpBoxJog.Controls.Add(this.label1);
            this.grpBoxJog.Controls.Add(this.trkBarJogSpeed);
            this.grpBoxJog.Controls.Add(this.btnJogCW);
            this.grpBoxJog.Controls.Add(this.btnJogCCW);
            this.grpBoxJog.Controls.Add(this.lstBoxJogAxis);
            this.grpBoxJog.Enabled = false;
            this.grpBoxJog.Location = new System.Drawing.Point(12, 166);
            this.grpBoxJog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxJog.Name = "grpBoxJog";
            this.grpBoxJog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxJog.Size = new System.Drawing.Size(324, 372);
            this.grpBoxJog.TabIndex = 1;
            this.grpBoxJog.TabStop = false;
            this.grpBoxJog.Text = "Jog Axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jog Speed: ";
            // 
            // trkBarJogSpeed
            // 
            this.trkBarJogSpeed.Location = new System.Drawing.Point(140, 138);
            this.trkBarJogSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trkBarJogSpeed.Name = "trkBarJogSpeed";
            this.trkBarJogSpeed.Size = new System.Drawing.Size(179, 56);
            this.trkBarJogSpeed.TabIndex = 3;
            this.trkBarJogSpeed.Scroll += new System.EventHandler(this.trkBarJogSpeed_Scroll);
            // 
            // btnJogCW
            // 
            this.btnJogCW.Image = global::CESAM_HMI.Properties.Resources.icons8_rotate_right_100;
            this.btnJogCW.Location = new System.Drawing.Point(163, 199);
            this.btnJogCW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogCW.Name = "btnJogCW";
            this.btnJogCW.Size = new System.Drawing.Size(149, 150);
            this.btnJogCW.TabIndex = 2;
            this.btnJogCW.UseVisualStyleBackColor = true;
            this.btnJogCW.Click += new System.EventHandler(this.btnJogCW_Click);
            this.btnJogCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogCW_MouseDown);
            this.btnJogCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogCW_MouseUp);
            // 
            // btnJogCCW
            // 
            this.btnJogCCW.Image = global::CESAM_HMI.Properties.Resources.icons8_rotate_left_100;
            this.btnJogCCW.Location = new System.Drawing.Point(5, 199);
            this.btnJogCCW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogCCW.Name = "btnJogCCW";
            this.btnJogCCW.Size = new System.Drawing.Size(149, 150);
            this.btnJogCCW.TabIndex = 1;
            this.btnJogCCW.UseVisualStyleBackColor = true;
            this.btnJogCCW.Click += new System.EventHandler(this.btnJogCCW_Click);
            this.btnJogCCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogCCW_MouseDown);
            this.btnJogCCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogCCW_MouseUp);
            // 
            // lstBoxJogAxis
            // 
            this.lstBoxJogAxis.FormattingEnabled = true;
            this.lstBoxJogAxis.ItemHeight = 16;
            this.lstBoxJogAxis.Items.AddRange(new object[] {
            "J1",
            "J2",
            "J3",
            "J4",
            "J5",
            "J6"});
            this.lstBoxJogAxis.Location = new System.Drawing.Point(79, 32);
            this.lstBoxJogAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxJogAxis.Name = "lstBoxJogAxis";
            this.lstBoxJogAxis.ScrollAlwaysVisible = true;
            this.lstBoxJogAxis.Size = new System.Drawing.Size(163, 100);
            this.lstBoxJogAxis.TabIndex = 0;
            // 
            // grpBoxAbsPos
            // 
            this.grpBoxAbsPos.Controls.Add(this.btnAbsPosition);
            this.grpBoxAbsPos.Controls.Add(this.txtBoxAbsPos);
            this.grpBoxAbsPos.Controls.Add(this.lblAxisCurrentPosition);
            this.grpBoxAbsPos.Controls.Add(this.trackBar1);
            this.grpBoxAbsPos.Controls.Add(this.lstBoxAbsPositionAxis);
            this.grpBoxAbsPos.Enabled = false;
            this.grpBoxAbsPos.Location = new System.Drawing.Point(12, 544);
            this.grpBoxAbsPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxAbsPos.Name = "grpBoxAbsPos";
            this.grpBoxAbsPos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxAbsPos.Size = new System.Drawing.Size(324, 318);
            this.grpBoxAbsPos.TabIndex = 4;
            this.grpBoxAbsPos.TabStop = false;
            this.grpBoxAbsPos.Text = "Absolute Positioning";
            // 
            // btnAbsPosition
            // 
            this.btnAbsPosition.Location = new System.Drawing.Point(101, 239);
            this.btnAbsPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbsPosition.Name = "btnAbsPosition";
            this.btnAbsPosition.Size = new System.Drawing.Size(104, 42);
            this.btnAbsPosition.TabIndex = 6;
            this.btnAbsPosition.Text = "Go";
            this.btnAbsPosition.UseVisualStyleBackColor = true;
            this.btnAbsPosition.Click += new System.EventHandler(this.btnAbsPosition_Click);
            // 
            // txtBoxAbsPos
            // 
            this.txtBoxAbsPos.Location = new System.Drawing.Point(107, 164);
            this.txtBoxAbsPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAbsPos.Name = "txtBoxAbsPos";
            this.txtBoxAbsPos.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAbsPos.TabIndex = 5;
            // 
            // lblAxisCurrentPosition
            // 
            this.lblAxisCurrentPosition.AutoSize = true;
            this.lblAxisCurrentPosition.Location = new System.Drawing.Point(76, 135);
            this.lblAxisCurrentPosition.Name = "lblAxisCurrentPosition";
            this.lblAxisCurrentPosition.Size = new System.Drawing.Size(113, 17);
            this.lblAxisCurrentPosition.TabIndex = 4;
            this.lblAxisCurrentPosition.Text = "Current Position:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 192);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(307, 56);
            this.trackBar1.TabIndex = 3;
            // 
            // lstBoxAbsPositionAxis
            // 
            this.lstBoxAbsPositionAxis.FormattingEnabled = true;
            this.lstBoxAbsPositionAxis.ItemHeight = 16;
            this.lstBoxAbsPositionAxis.Items.AddRange(new object[] {
            "J1",
            "J2",
            "J3",
            "J4",
            "J5",
            "J6"});
            this.lstBoxAbsPositionAxis.Location = new System.Drawing.Point(79, 32);
            this.lstBoxAbsPositionAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxAbsPositionAxis.Name = "lstBoxAbsPositionAxis";
            this.lstBoxAbsPositionAxis.ScrollAlwaysVisible = true;
            this.lstBoxAbsPositionAxis.Size = new System.Drawing.Size(163, 100);
            this.lstBoxAbsPositionAxis.TabIndex = 0;
            // 
            // grpBoxHoming
            // 
            this.grpBoxHoming.Controls.Add(this.txtBoxInitAngle);
            this.grpBoxHoming.Controls.Add(this.btnInitAxis);
            this.grpBoxHoming.Controls.Add(this.button3);
            this.grpBoxHoming.Controls.Add(this.button2);
            this.grpBoxHoming.Controls.Add(this.lstBoxHomeAxis);
            this.grpBoxHoming.Enabled = false;
            this.grpBoxHoming.Location = new System.Drawing.Point(353, 22);
            this.grpBoxHoming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxHoming.Name = "grpBoxHoming";
            this.grpBoxHoming.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxHoming.Size = new System.Drawing.Size(361, 276);
            this.grpBoxHoming.TabIndex = 7;
            this.grpBoxHoming.TabStop = false;
            this.grpBoxHoming.Text = "Homing and Initialization";
            // 
            // txtBoxInitAngle
            // 
            this.txtBoxInitAngle.Location = new System.Drawing.Point(199, 154);
            this.txtBoxInitAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxInitAngle.Name = "txtBoxInitAngle";
            this.txtBoxInitAngle.Size = new System.Drawing.Size(104, 22);
            this.txtBoxInitAngle.TabIndex = 7;
            // 
            // btnInitAxis
            // 
            this.btnInitAxis.Location = new System.Drawing.Point(176, 191);
            this.btnInitAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInitAxis.Name = "btnInitAxis";
            this.btnInitAxis.Size = new System.Drawing.Size(163, 64);
            this.btnInitAxis.TabIndex = 8;
            this.btnInitAxis.Text = "Initialize Axis";
            this.btnInitAxis.UseVisualStyleBackColor = true;
            this.btnInitAxis.Click += new System.EventHandler(this.btnInitAxis_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 144);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Home Axis";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "Home All Axes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lstBoxHomeAxis
            // 
            this.lstBoxHomeAxis.FormattingEnabled = true;
            this.lstBoxHomeAxis.ItemHeight = 16;
            this.lstBoxHomeAxis.Items.AddRange(new object[] {
            "J1",
            "J2",
            "J3",
            "J4",
            "J5",
            "J6"});
            this.lstBoxHomeAxis.Location = new System.Drawing.Point(5, 32);
            this.lstBoxHomeAxis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxHomeAxis.Name = "lstBoxHomeAxis";
            this.lstBoxHomeAxis.ScrollAlwaysVisible = true;
            this.lstBoxHomeAxis.Size = new System.Drawing.Size(332, 100);
            this.lstBoxHomeAxis.TabIndex = 0;
            // 
            // grpBoxESTOP
            // 
            this.grpBoxESTOP.Controls.Add(this.btnSTOP);
            this.grpBoxESTOP.Enabled = false;
            this.grpBoxESTOP.Location = new System.Drawing.Point(345, 544);
            this.grpBoxESTOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxESTOP.Name = "grpBoxESTOP";
            this.grpBoxESTOP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxESTOP.Size = new System.Drawing.Size(177, 318);
            this.grpBoxESTOP.TabIndex = 8;
            this.grpBoxESTOP.TabStop = false;
            this.grpBoxESTOP.Text = "E-Stop";
            // 
            // btnSTOP
            // 
            this.btnSTOP.BackColor = System.Drawing.Color.Red;
            this.btnSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSTOP.Location = new System.Drawing.Point(5, 33);
            this.btnSTOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(163, 278);
            this.btnSTOP.TabIndex = 0;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = false;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // grpboxJointMove
            // 
            this.grpboxJointMove.Location = new System.Drawing.Point(351, 304);
            this.grpboxJointMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxJointMove.Name = "grpboxJointMove";
            this.grpboxJointMove.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxJointMove.Size = new System.Drawing.Size(363, 234);
            this.grpboxJointMove.TabIndex = 8;
            this.grpboxJointMove.TabStop = false;
            this.grpboxJointMove.Text = "Joint Move";
            // 
            // grpBoxCmdWdw
            // 
            this.grpBoxCmdWdw.Controls.Add(this.btnSendCommand);
            this.grpBoxCmdWdw.Controls.Add(this.txtBoxCommand);
            this.grpBoxCmdWdw.Controls.Add(this.lstBoxCommandWindow);
            this.grpBoxCmdWdw.Enabled = false;
            this.grpBoxCmdWdw.Location = new System.Drawing.Point(547, 544);
            this.grpBoxCmdWdw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxCmdWdw.Name = "grpBoxCmdWdw";
            this.grpBoxCmdWdw.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxCmdWdw.Size = new System.Drawing.Size(669, 318);
            this.grpBoxCmdWdw.TabIndex = 9;
            this.grpBoxCmdWdw.TabStop = false;
            this.grpBoxCmdWdw.Text = "Command Window";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(543, 30);
            this.btnSendCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(121, 30);
            this.btnSendCommand.TabIndex = 2;
            this.btnSendCommand.Text = "Send Command";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            // 
            // txtBoxCommand
            // 
            this.txtBoxCommand.Location = new System.Drawing.Point(5, 32);
            this.txtBoxCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxCommand.Name = "txtBoxCommand";
            this.txtBoxCommand.Size = new System.Drawing.Size(531, 22);
            this.txtBoxCommand.TabIndex = 1;
            // 
            // lstBoxCommandWindow
            // 
            this.lstBoxCommandWindow.FormattingEnabled = true;
            this.lstBoxCommandWindow.ItemHeight = 16;
            this.lstBoxCommandWindow.Location = new System.Drawing.Point(5, 66);
            this.lstBoxCommandWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxCommandWindow.Name = "lstBoxCommandWindow";
            this.lstBoxCommandWindow.Size = new System.Drawing.Size(657, 244);
            this.lstBoxCommandWindow.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(730, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(486, 518);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joint Move";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 106);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(196, 27);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxCmdWdw);
            this.Controls.Add(this.grpboxJointMove);
            this.Controls.Add(this.grpBoxESTOP);
            this.Controls.Add(this.grpBoxHoming);
            this.Controls.Add(this.grpBoxAbsPos);
            this.Controls.Add(this.grpBoxJog);
            this.Controls.Add(this.grpBoxCOMPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CESAM HMI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxCOMPort.ResumeLayout(false);
            this.grpBoxJog.ResumeLayout(false);
            this.grpBoxJog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarJogSpeed)).EndInit();
            this.grpBoxAbsPos.ResumeLayout(false);
            this.grpBoxAbsPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.grpBoxHoming.ResumeLayout(false);
            this.grpBoxHoming.PerformLayout();
            this.grpBoxESTOP.ResumeLayout(false);
            this.grpBoxCmdWdw.ResumeLayout(false);
            this.grpBoxCmdWdw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCOMPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox grpBoxJog;
        private System.Windows.Forms.Button btnJogCW;
        private System.Windows.Forms.Button btnJogCCW;
        private System.Windows.Forms.ListBox lstBoxJogAxis;
        private System.Windows.Forms.TrackBar trkBarJogSpeed;
        private System.Windows.Forms.GroupBox grpBoxAbsPos;
        private System.Windows.Forms.Label lblAxisCurrentPosition;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox lstBoxAbsPositionAxis;
        private System.Windows.Forms.Button btnAbsPosition;
        private System.Windows.Forms.TextBox txtBoxAbsPos;
        private System.Windows.Forms.GroupBox grpBoxHoming;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstBoxHomeAxis;
        private System.Windows.Forms.GroupBox grpBoxESTOP;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxJointMove;
        private System.Windows.Forms.GroupBox grpBoxCmdWdw;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox txtBoxCommand;
        private System.Windows.Forms.ListBox lstBoxCommandWindow;
        private System.Windows.Forms.TextBox txtBoxInitAngle;
        private System.Windows.Forms.Button btnInitAxis;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.ListBox lstBoxSerialPorts;
        private System.Windows.Forms.Button btnSerialDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

