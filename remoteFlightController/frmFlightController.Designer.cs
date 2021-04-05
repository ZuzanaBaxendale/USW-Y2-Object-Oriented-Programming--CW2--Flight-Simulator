namespace remoteFlightController
{
    partial class frmFlightController
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.grpPlane = new System.Windows.Forms.GroupBox();
            this.txtElevatorPitch = new System.Windows.Forms.TextBox();
            this.txtThrottle = new System.Windows.Forms.TextBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.lblElevatorPitch = new System.Windows.Forms.Label();
            this.txtVerticalSpeed = new System.Windows.Forms.TextBox();
            this.txtPitchAngle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPitchAngle = new System.Windows.Forms.Label();
            this.txtAirspeed = new System.Windows.Forms.TextBox();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblAirspeed = new System.Windows.Forms.Label();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.lblThrottleMin = new System.Windows.Forms.Label();
            this.lblThrottleMax = new System.Windows.Forms.Label();
            this.lblElevatorPitchMin = new System.Windows.Forms.Label();
            this.lblElevatorPitchMax = new System.Windows.Forms.Label();
            this.grpElevatorPitchCurrent = new System.Windows.Forms.GroupBox();
            this.lblCurrentElevatorPitch = new System.Windows.Forms.Label();
            this.grpThrottleCurrent = new System.Windows.Forms.GroupBox();
            this.lblCurrentThrottle = new System.Windows.Forms.Label();
            this.lblControlsThrottle = new System.Windows.Forms.Label();
            this.lblControlsElevatorPitch = new System.Windows.Forms.Label();
            this.trkPitch = new System.Windows.Forms.TrackBar();
            this.trkThrottle = new System.Windows.Forms.TrackBar();
            this.dgvDataRecieved = new System.Windows.Forms.DataGridView();
            this.clnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAltitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThrottle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnWarningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpWarning = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPlane.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.grpElevatorPitchCurrent.SuspendLayout();
            this.grpThrottleCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataRecieved)).BeginInit();
            this.grpWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(409, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 54);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Remote flight controller";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(792, 174);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 57);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(728, 98);
            this.txtIpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(208, 22);
            this.txtIpAddress.TabIndex = 12;
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(724, 75);
            this.lblIpAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(75, 17);
            this.lblIpAddress.TabIndex = 13;
            this.lblIpAddress.Text = "IP address";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(724, 123);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 17);
            this.lblPort.TabIndex = 14;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(728, 144);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(208, 22);
            this.txtPort.TabIndex = 15;
            // 
            // grpPlane
            // 
            this.grpPlane.Controls.Add(this.txtElevatorPitch);
            this.grpPlane.Controls.Add(this.txtThrottle);
            this.grpPlane.Controls.Add(this.txtAltitude);
            this.grpPlane.Controls.Add(this.lblElevatorPitch);
            this.grpPlane.Controls.Add(this.txtVerticalSpeed);
            this.grpPlane.Controls.Add(this.txtPitchAngle);
            this.grpPlane.Controls.Add(this.label8);
            this.grpPlane.Controls.Add(this.label7);
            this.grpPlane.Controls.Add(this.lblPitchAngle);
            this.grpPlane.Controls.Add(this.txtAirspeed);
            this.grpPlane.Controls.Add(this.lblThrottle);
            this.grpPlane.Controls.Add(this.lblAirspeed);
            this.grpPlane.Location = new System.Drawing.Point(16, 332);
            this.grpPlane.Margin = new System.Windows.Forms.Padding(4);
            this.grpPlane.Name = "grpPlane";
            this.grpPlane.Padding = new System.Windows.Forms.Padding(4);
            this.grpPlane.Size = new System.Drawing.Size(797, 126);
            this.grpPlane.TabIndex = 16;
            this.grpPlane.TabStop = false;
            this.grpPlane.Text = "Plane";
            // 
            // txtElevatorPitch
            // 
            this.txtElevatorPitch.Location = new System.Drawing.Point(500, 89);
            this.txtElevatorPitch.Margin = new System.Windows.Forms.Padding(4);
            this.txtElevatorPitch.Name = "txtElevatorPitch";
            this.txtElevatorPitch.ReadOnly = true;
            this.txtElevatorPitch.Size = new System.Drawing.Size(271, 22);
            this.txtElevatorPitch.TabIndex = 14;
            // 
            // txtThrottle
            // 
            this.txtThrottle.Location = new System.Drawing.Point(93, 89);
            this.txtThrottle.Margin = new System.Windows.Forms.Padding(4);
            this.txtThrottle.Name = "txtThrottle";
            this.txtThrottle.ReadOnly = true;
            this.txtThrottle.Size = new System.Drawing.Size(271, 22);
            this.txtThrottle.TabIndex = 13;
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(500, 58);
            this.txtAltitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.ReadOnly = true;
            this.txtAltitude.Size = new System.Drawing.Size(271, 22);
            this.txtAltitude.TabIndex = 12;
            // 
            // lblElevatorPitch
            // 
            this.lblElevatorPitch.AutoSize = true;
            this.lblElevatorPitch.Location = new System.Drawing.Point(396, 94);
            this.lblElevatorPitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElevatorPitch.Name = "lblElevatorPitch";
            this.lblElevatorPitch.Size = new System.Drawing.Size(94, 17);
            this.lblElevatorPitch.TabIndex = 8;
            this.lblElevatorPitch.Text = "Elevator pitch";
            // 
            // txtVerticalSpeed
            // 
            this.txtVerticalSpeed.Location = new System.Drawing.Point(500, 26);
            this.txtVerticalSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerticalSpeed.Name = "txtVerticalSpeed";
            this.txtVerticalSpeed.ReadOnly = true;
            this.txtVerticalSpeed.Size = new System.Drawing.Size(271, 22);
            this.txtVerticalSpeed.TabIndex = 10;
            // 
            // txtPitchAngle
            // 
            this.txtPitchAngle.Location = new System.Drawing.Point(93, 62);
            this.txtPitchAngle.Margin = new System.Windows.Forms.Padding(4);
            this.txtPitchAngle.Name = "txtPitchAngle";
            this.txtPitchAngle.ReadOnly = true;
            this.txtPitchAngle.Size = new System.Drawing.Size(271, 22);
            this.txtPitchAngle.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Altitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vertical speed";
            // 
            // lblPitchAngle
            // 
            this.lblPitchAngle.AutoSize = true;
            this.lblPitchAngle.Location = new System.Drawing.Point(7, 63);
            this.lblPitchAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPitchAngle.Name = "lblPitchAngle";
            this.lblPitchAngle.Size = new System.Drawing.Size(78, 17);
            this.lblPitchAngle.TabIndex = 4;
            this.lblPitchAngle.Text = "Pitch angle";
            // 
            // txtAirspeed
            // 
            this.txtAirspeed.Location = new System.Drawing.Point(93, 32);
            this.txtAirspeed.Margin = new System.Windows.Forms.Padding(4);
            this.txtAirspeed.Name = "txtAirspeed";
            this.txtAirspeed.ReadOnly = true;
            this.txtAirspeed.Size = new System.Drawing.Size(271, 22);
            this.txtAirspeed.TabIndex = 9;
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Location = new System.Drawing.Point(9, 92);
            this.lblThrottle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(57, 17);
            this.lblThrottle.TabIndex = 5;
            this.lblThrottle.Text = "Throttle";
            // 
            // lblAirspeed
            // 
            this.lblAirspeed.AutoSize = true;
            this.lblAirspeed.Location = new System.Drawing.Point(8, 37);
            this.lblAirspeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirspeed.Name = "lblAirspeed";
            this.lblAirspeed.Size = new System.Drawing.Size(64, 17);
            this.lblAirspeed.TabIndex = 3;
            this.lblAirspeed.Text = "Airspeed";
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.lblThrottleMin);
            this.grpControl.Controls.Add(this.lblThrottleMax);
            this.grpControl.Controls.Add(this.lblElevatorPitchMin);
            this.grpControl.Controls.Add(this.lblElevatorPitchMax);
            this.grpControl.Controls.Add(this.grpElevatorPitchCurrent);
            this.grpControl.Controls.Add(this.grpThrottleCurrent);
            this.grpControl.Controls.Add(this.lblControlsThrottle);
            this.grpControl.Controls.Add(this.lblControlsElevatorPitch);
            this.grpControl.Controls.Add(this.trkPitch);
            this.grpControl.Controls.Add(this.trkThrottle);
            this.grpControl.Location = new System.Drawing.Point(16, 9);
            this.grpControl.Margin = new System.Windows.Forms.Padding(4);
            this.grpControl.Name = "grpControl";
            this.grpControl.Padding = new System.Windows.Forms.Padding(4);
            this.grpControl.Size = new System.Drawing.Size(385, 316);
            this.grpControl.TabIndex = 17;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Controls";
            // 
            // lblThrottleMin
            // 
            this.lblThrottleMin.AutoSize = true;
            this.lblThrottleMin.Location = new System.Drawing.Point(49, 283);
            this.lblThrottleMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThrottleMin.Name = "lblThrottleMin";
            this.lblThrottleMin.Size = new System.Drawing.Size(58, 17);
            this.lblThrottleMin.TabIndex = 21;
            this.lblThrottleMin.Text = "Min: 0.0";
            // 
            // lblThrottleMax
            // 
            this.lblThrottleMax.AutoSize = true;
            this.lblThrottleMax.Location = new System.Drawing.Point(29, 57);
            this.lblThrottleMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThrottleMax.Name = "lblThrottleMax";
            this.lblThrottleMax.Size = new System.Drawing.Size(77, 17);
            this.lblThrottleMax.TabIndex = 20;
            this.lblThrottleMax.Text = "Max: 100.0";
            // 
            // lblElevatorPitchMin
            // 
            this.lblElevatorPitchMin.AutoSize = true;
            this.lblElevatorPitchMin.Location = new System.Drawing.Point(237, 283);
            this.lblElevatorPitchMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElevatorPitchMin.Name = "lblElevatorPitchMin";
            this.lblElevatorPitchMin.Size = new System.Drawing.Size(63, 17);
            this.lblElevatorPitchMin.TabIndex = 19;
            this.lblElevatorPitchMin.Text = "Min: -5.0";
            // 
            // lblElevatorPitchMax
            // 
            this.lblElevatorPitchMax.AutoSize = true;
            this.lblElevatorPitchMax.Location = new System.Drawing.Point(237, 57);
            this.lblElevatorPitchMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElevatorPitchMax.Name = "lblElevatorPitchMax";
            this.lblElevatorPitchMax.Size = new System.Drawing.Size(61, 17);
            this.lblElevatorPitchMax.TabIndex = 18;
            this.lblElevatorPitchMax.Text = "Max: 5.0";
            // 
            // grpElevatorPitchCurrent
            // 
            this.grpElevatorPitchCurrent.Controls.Add(this.lblCurrentElevatorPitch);
            this.grpElevatorPitchCurrent.Location = new System.Drawing.Point(201, 134);
            this.grpElevatorPitchCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.grpElevatorPitchCurrent.Name = "grpElevatorPitchCurrent";
            this.grpElevatorPitchCurrent.Padding = new System.Windows.Forms.Padding(4);
            this.grpElevatorPitchCurrent.Size = new System.Drawing.Size(100, 73);
            this.grpElevatorPitchCurrent.TabIndex = 17;
            this.grpElevatorPitchCurrent.TabStop = false;
            this.grpElevatorPitchCurrent.Text = "Current";
            // 
            // lblCurrentElevatorPitch
            // 
            this.lblCurrentElevatorPitch.AutoSize = true;
            this.lblCurrentElevatorPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentElevatorPitch.Location = new System.Drawing.Point(9, 25);
            this.lblCurrentElevatorPitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentElevatorPitch.Name = "lblCurrentElevatorPitch";
            this.lblCurrentElevatorPitch.Size = new System.Drawing.Size(55, 31);
            this.lblCurrentElevatorPitch.TabIndex = 0;
            this.lblCurrentElevatorPitch.Text = "0.0";
            // 
            // grpThrottleCurrent
            // 
            this.grpThrottleCurrent.Controls.Add(this.lblCurrentThrottle);
            this.grpThrottleCurrent.Location = new System.Drawing.Point(12, 134);
            this.grpThrottleCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.grpThrottleCurrent.Name = "grpThrottleCurrent";
            this.grpThrottleCurrent.Padding = new System.Windows.Forms.Padding(4);
            this.grpThrottleCurrent.Size = new System.Drawing.Size(100, 73);
            this.grpThrottleCurrent.TabIndex = 16;
            this.grpThrottleCurrent.TabStop = false;
            this.grpThrottleCurrent.Text = "Current";
            // 
            // lblCurrentThrottle
            // 
            this.lblCurrentThrottle.AutoSize = true;
            this.lblCurrentThrottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentThrottle.Location = new System.Drawing.Point(9, 25);
            this.lblCurrentThrottle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentThrottle.Name = "lblCurrentThrottle";
            this.lblCurrentThrottle.Size = new System.Drawing.Size(71, 29);
            this.lblCurrentThrottle.TabIndex = 0;
            this.lblCurrentThrottle.Text = "0.0%";
            // 
            // lblControlsThrottle
            // 
            this.lblControlsThrottle.AutoSize = true;
            this.lblControlsThrottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlsThrottle.Location = new System.Drawing.Point(53, 20);
            this.lblControlsThrottle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlsThrottle.Name = "lblControlsThrottle";
            this.lblControlsThrottle.Size = new System.Drawing.Size(66, 20);
            this.lblControlsThrottle.TabIndex = 15;
            this.lblControlsThrottle.Text = "Throttle";
            // 
            // lblControlsElevatorPitch
            // 
            this.lblControlsElevatorPitch.AutoSize = true;
            this.lblControlsElevatorPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlsElevatorPitch.Location = new System.Drawing.Point(220, 20);
            this.lblControlsElevatorPitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlsElevatorPitch.Name = "lblControlsElevatorPitch";
            this.lblControlsElevatorPitch.Size = new System.Drawing.Size(111, 20);
            this.lblControlsElevatorPitch.TabIndex = 15;
            this.lblControlsElevatorPitch.Text = "Elevator pitch";
            // 
            // trkPitch
            // 
            this.trkPitch.Cursor = System.Windows.Forms.Cursors.Default;
            this.trkPitch.Enabled = false;
            this.trkPitch.Location = new System.Drawing.Point(317, 57);
            this.trkPitch.Margin = new System.Windows.Forms.Padding(4);
            this.trkPitch.Maximum = 50;
            this.trkPitch.Minimum = -50;
            this.trkPitch.Name = "trkPitch";
            this.trkPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPitch.Size = new System.Drawing.Size(56, 260);
            this.trkPitch.TabIndex = 12;
            this.trkPitch.Scroll += new System.EventHandler(this.trkPitch_Scroll);
            // 
            // trkThrottle
            // 
            this.trkThrottle.Enabled = false;
            this.trkThrottle.Location = new System.Drawing.Point(113, 57);
            this.trkThrottle.Margin = new System.Windows.Forms.Padding(4);
            this.trkThrottle.Maximum = 100;
            this.trkThrottle.Name = "trkThrottle";
            this.trkThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThrottle.Size = new System.Drawing.Size(56, 260);
            this.trkThrottle.TabIndex = 11;
            this.trkThrottle.Scroll += new System.EventHandler(this.trkThrottle_Scroll);
            // 
            // dgvDataRecieved
            // 
            this.dgvDataRecieved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataRecieved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSpeed,
            this.clnVerticalSpeed,
            this.clnPitch,
            this.clnAltitude,
            this.clnThrottle,
            this.clnElevatorPitch,
            this.clnWarningCode});
            this.dgvDataRecieved.Location = new System.Drawing.Point(13, 503);
            this.dgvDataRecieved.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDataRecieved.Name = "dgvDataRecieved";
            this.dgvDataRecieved.Size = new System.Drawing.Size(800, 241);
            this.dgvDataRecieved.TabIndex = 18;
            // 
            // clnSpeed
            // 
            this.clnSpeed.HeaderText = "Speed";
            this.clnSpeed.Name = "clnSpeed";
            this.clnSpeed.ReadOnly = true;
            this.clnSpeed.Width = 85;
            // 
            // clnVerticalSpeed
            // 
            this.clnVerticalSpeed.HeaderText = "Vertical Speed";
            this.clnVerticalSpeed.Name = "clnVerticalSpeed";
            this.clnVerticalSpeed.ReadOnly = true;
            this.clnVerticalSpeed.Width = 80;
            // 
            // clnPitch
            // 
            this.clnPitch.HeaderText = "Pitch angle";
            this.clnPitch.Name = "clnPitch";
            this.clnPitch.Width = 80;
            // 
            // clnAltitude
            // 
            this.clnAltitude.HeaderText = "Altitude";
            this.clnAltitude.Name = "clnAltitude";
            this.clnAltitude.ReadOnly = true;
            this.clnAltitude.Width = 80;
            // 
            // clnThrottle
            // 
            this.clnThrottle.HeaderText = "Throttle";
            this.clnThrottle.Name = "clnThrottle";
            this.clnThrottle.ReadOnly = true;
            this.clnThrottle.Width = 70;
            // 
            // clnElevatorPitch
            // 
            this.clnElevatorPitch.HeaderText = "Elevator pitch";
            this.clnElevatorPitch.Name = "clnElevatorPitch";
            this.clnElevatorPitch.ReadOnly = true;
            this.clnElevatorPitch.Width = 70;
            // 
            // clnWarningCode
            // 
            this.clnWarningCode.HeaderText = "Warning Code";
            this.clnWarningCode.Name = "clnWarningCode";
            this.clnWarningCode.ReadOnly = true;
            this.clnWarningCode.Width = 54;
            // 
            // grpWarning
            // 
            this.grpWarning.Controls.Add(this.lblWarning);
            this.grpWarning.Location = new System.Drawing.Point(13, 752);
            this.grpWarning.Margin = new System.Windows.Forms.Padding(4);
            this.grpWarning.Name = "grpWarning";
            this.grpWarning.Padding = new System.Windows.Forms.Padding(4);
            this.grpWarning.Size = new System.Drawing.Size(791, 59);
            this.grpWarning.TabIndex = 19;
            this.grpWarning.TabStop = false;
            this.grpWarning.Text = "Warning";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(21, 21);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(71, 20);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Warning";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(836, 239);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFlightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 824);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpWarning);
            this.Controls.Add(this.dgvDataRecieved);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.grpPlane);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIpAddress);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFlightController";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFlightController_Load);
            this.grpPlane.ResumeLayout(false);
            this.grpPlane.PerformLayout();
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.grpElevatorPitchCurrent.ResumeLayout(false);
            this.grpElevatorPitchCurrent.PerformLayout();
            this.grpThrottleCurrent.ResumeLayout(false);
            this.grpThrottleCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataRecieved)).EndInit();
            this.grpWarning.ResumeLayout(false);
            this.grpWarning.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox grpPlane;
        private System.Windows.Forms.TextBox txtElevatorPitch;
        private System.Windows.Forms.TextBox txtThrottle;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.Label lblElevatorPitch;
        private System.Windows.Forms.TextBox txtVerticalSpeed;
        private System.Windows.Forms.TextBox txtPitchAngle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPitchAngle;
        private System.Windows.Forms.TextBox txtAirspeed;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.Label lblAirspeed;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Label lblThrottleMin;
        private System.Windows.Forms.Label lblThrottleMax;
        private System.Windows.Forms.Label lblElevatorPitchMin;
        private System.Windows.Forms.Label lblElevatorPitchMax;
        private System.Windows.Forms.GroupBox grpElevatorPitchCurrent;
        private System.Windows.Forms.Label lblCurrentElevatorPitch;
        private System.Windows.Forms.GroupBox grpThrottleCurrent;
        private System.Windows.Forms.Label lblCurrentThrottle;
        private System.Windows.Forms.Label lblControlsThrottle;
        private System.Windows.Forms.Label lblControlsElevatorPitch;
        private System.Windows.Forms.TrackBar trkPitch;
        private System.Windows.Forms.TrackBar trkThrottle;
        private System.Windows.Forms.DataGridView dgvDataRecieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAltitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThrottle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnWarningCode;
        private System.Windows.Forms.GroupBox grpWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnExit;
    }
}

