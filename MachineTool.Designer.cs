namespace AdapterLab
{
    partial class MachineTool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.estop = new System.Windows.Forms.CheckBox();
            this.mode = new System.Windows.Forms.GroupBox();
            this.edit = new System.Windows.Forms.RadioButton();
            this.mdi = new System.Windows.Forms.RadioButton();
            this.manual = new System.Windows.Forms.RadioButton();
            this.automatic = new System.Windows.Forms.RadioButton();
            this.Execution = new System.Windows.Forms.GroupBox();
            this.ready = new System.Windows.Forms.RadioButton();
            this.feedhold = new System.Windows.Forms.RadioButton();
            this.stopped = new System.Windows.Forms.RadioButton();
            this.running = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.program = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xPositionValue = new System.Windows.Forms.TextBox();
            this.xLoadValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xPosition = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xLoad = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flazBat = new System.Windows.Forms.CheckBox();
            this.travel = new System.Windows.Forms.CheckBox();
            this.something = new System.Windows.Forms.CheckBox();
            this.overtemp = new System.Windows.Forms.CheckBox();
            this.coolant = new System.Windows.Forms.CheckBox();
            this.noProgram = new System.Windows.Forms.CheckBox();
            this.overload = new System.Windows.Forms.CheckBox();
            this.gather = new System.Windows.Forms.Timer(this.components);
            this.cuttingToolButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.messageCode = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cSpeedValue = new System.Windows.Forms.TextBox();
            this.cLoadValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cSpeed = new System.Windows.Forms.HScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cLoad = new System.Windows.Forms.HScrollBar();
            this.label12 = new System.Windows.Forms.Label();
            this.functionalMode = new System.Windows.Forms.ComboBox();
            this.partID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.commonVariables = new System.Windows.Forms.DataGridView();
            this.cv21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cv22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cv23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cv24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.mode.SuspendLayout();
            this.Execution.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonVariables)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Info";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(213, 14);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(132, 14);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(50, 17);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(62, 20);
            this.port.TabIndex = 1;
            this.port.Text = "7878";
            this.port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // estop
            // 
            this.estop.AutoSize = true;
            this.estop.Location = new System.Drawing.Point(12, 64);
            this.estop.Name = "estop";
            this.estop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.estop.Size = new System.Drawing.Size(104, 17);
            this.estop.TabIndex = 1;
            this.estop.Text = "Emergency Stop";
            this.estop.UseVisualStyleBackColor = true;
            // 
            // mode
            // 
            this.mode.Controls.Add(this.edit);
            this.mode.Controls.Add(this.mdi);
            this.mode.Controls.Add(this.manual);
            this.mode.Controls.Add(this.automatic);
            this.mode.Location = new System.Drawing.Point(12, 88);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(379, 48);
            this.mode.TabIndex = 6;
            this.mode.TabStop = false;
            this.mode.Text = "Mode";
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.Location = new System.Drawing.Point(299, 16);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(43, 17);
            this.edit.TabIndex = 9;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // mdi
            // 
            this.mdi.AutoSize = true;
            this.mdi.Location = new System.Drawing.Point(180, 15);
            this.mdi.Name = "mdi";
            this.mdi.Size = new System.Drawing.Size(113, 17);
            this.mdi.TabIndex = 8;
            this.mdi.Text = "Manual Data Input";
            this.mdi.UseVisualStyleBackColor = true;
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Checked = true;
            this.manual.Location = new System.Drawing.Point(114, 15);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(60, 17);
            this.manual.TabIndex = 7;
            this.manual.TabStop = true;
            this.manual.Text = "Manual";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // automatic
            // 
            this.automatic.AutoSize = true;
            this.automatic.Location = new System.Drawing.Point(36, 16);
            this.automatic.Name = "automatic";
            this.automatic.Size = new System.Drawing.Size(72, 17);
            this.automatic.TabIndex = 6;
            this.automatic.Text = "Automatic";
            this.automatic.UseVisualStyleBackColor = true;
            // 
            // Execution
            // 
            this.Execution.Controls.Add(this.ready);
            this.Execution.Controls.Add(this.feedhold);
            this.Execution.Controls.Add(this.stopped);
            this.Execution.Controls.Add(this.running);
            this.Execution.Location = new System.Drawing.Point(12, 139);
            this.Execution.Name = "Execution";
            this.Execution.Size = new System.Drawing.Size(379, 48);
            this.Execution.TabIndex = 10;
            this.Execution.TabStop = false;
            this.Execution.Text = "Execution";
            // 
            // ready
            // 
            this.ready.AutoSize = true;
            this.ready.Checked = true;
            this.ready.Location = new System.Drawing.Point(114, 16);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(56, 17);
            this.ready.TabIndex = 9;
            this.ready.TabStop = true;
            this.ready.Text = "Ready";
            this.ready.UseVisualStyleBackColor = true;
            // 
            // feedhold
            // 
            this.feedhold.AutoSize = true;
            this.feedhold.Location = new System.Drawing.Point(253, 16);
            this.feedhold.Name = "feedhold";
            this.feedhold.Size = new System.Drawing.Size(74, 17);
            this.feedhold.TabIndex = 8;
            this.feedhold.Text = "Feed Hold";
            this.feedhold.UseVisualStyleBackColor = true;
            // 
            // stopped
            // 
            this.stopped.AutoSize = true;
            this.stopped.Location = new System.Drawing.Point(180, 16);
            this.stopped.Name = "stopped";
            this.stopped.Size = new System.Drawing.Size(65, 17);
            this.stopped.TabIndex = 7;
            this.stopped.Text = "Stopped";
            this.stopped.UseVisualStyleBackColor = true;
            // 
            // running
            // 
            this.running.AutoSize = true;
            this.running.Location = new System.Drawing.Point(36, 16);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(65, 17);
            this.running.TabIndex = 6;
            this.running.Text = "Running";
            this.running.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Program";
            // 
            // program
            // 
            this.program.Location = new System.Drawing.Point(102, 225);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(100, 20);
            this.program.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xPositionValue);
            this.groupBox2.Controls.Add(this.xLoadValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.xPosition);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.xLoad);
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "X Axis";
            // 
            // xPositionValue
            // 
            this.xPositionValue.Location = new System.Drawing.Point(266, 39);
            this.xPositionValue.Name = "xPositionValue";
            this.xPositionValue.Size = new System.Drawing.Size(100, 20);
            this.xPositionValue.TabIndex = 26;
            // 
            // xLoadValue
            // 
            this.xLoadValue.Location = new System.Drawing.Point(266, 16);
            this.xLoadValue.Name = "xLoadValue";
            this.xLoadValue.Size = new System.Drawing.Size(100, 20);
            this.xLoadValue.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Position";
            // 
            // xPosition
            // 
            this.xPosition.Location = new System.Drawing.Point(82, 39);
            this.xPosition.Name = "xPosition";
            this.xPosition.Size = new System.Drawing.Size(168, 18);
            this.xPosition.TabIndex = 23;
            this.xPosition.Scroll += new System.Windows.Forms.ScrollEventHandler(this.xPosition_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Load";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 21;
            // 
            // xLoad
            // 
            this.xLoad.Location = new System.Drawing.Point(82, 18);
            this.xLoad.Name = "xLoad";
            this.xLoad.Size = new System.Drawing.Size(168, 18);
            this.xLoad.TabIndex = 20;
            this.xLoad.Scroll += new System.Windows.Forms.ScrollEventHandler(this.xLoad_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flazBat);
            this.groupBox3.Controls.Add(this.travel);
            this.groupBox3.Controls.Add(this.something);
            this.groupBox3.Controls.Add(this.overtemp);
            this.groupBox3.Controls.Add(this.coolant);
            this.groupBox3.Controls.Add(this.noProgram);
            this.groupBox3.Controls.Add(this.overload);
            this.groupBox3.Location = new System.Drawing.Point(402, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 114);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alarms";
            // 
            // flazBat
            // 
            this.flazBat.AutoSize = true;
            this.flazBat.Location = new System.Drawing.Point(151, 43);
            this.flazBat.Name = "flazBat";
            this.flazBat.Size = new System.Drawing.Size(76, 17);
            this.flazBat.TabIndex = 6;
            this.flazBat.Text = "FLAZ BAT";
            this.flazBat.UseVisualStyleBackColor = true;
            // 
            // travel
            // 
            this.travel.AutoSize = true;
            this.travel.Location = new System.Drawing.Point(151, 89);
            this.travel.Name = "travel";
            this.travel.Size = new System.Drawing.Size(155, 17);
            this.travel.TabIndex = 5;
            this.travel.Text = "FM_1_Achse_Positionierun";
            this.travel.UseVisualStyleBackColor = true;
            // 
            // something
            // 
            this.something.AutoSize = true;
            this.something.Location = new System.Drawing.Point(151, 20);
            this.something.Name = "something";
            this.something.Size = new System.Drawing.Size(89, 17);
            this.something.TabIndex = 4;
            this.something.Text = "ALR DK TLD";
            this.something.UseVisualStyleBackColor = true;
            // 
            // overtemp
            // 
            this.overtemp.AutoSize = true;
            this.overtemp.Location = new System.Drawing.Point(7, 89);
            this.overtemp.Name = "overtemp";
            this.overtemp.Size = new System.Drawing.Size(72, 17);
            this.overtemp.TabIndex = 3;
            this.overtemp.Text = "Overtemp";
            this.overtemp.UseVisualStyleBackColor = true;
            // 
            // coolant
            // 
            this.coolant.AutoSize = true;
            this.coolant.Location = new System.Drawing.Point(7, 66);
            this.coolant.Name = "coolant";
            this.coolant.Size = new System.Drawing.Size(85, 17);
            this.coolant.TabIndex = 2;
            this.coolant.Text = "Coolant Low";
            this.coolant.UseVisualStyleBackColor = true;
            this.coolant.CheckedChanged += new System.EventHandler(this.coolant_CheckedChanged);
            // 
            // noProgram
            // 
            this.noProgram.AutoSize = true;
            this.noProgram.Location = new System.Drawing.Point(7, 43);
            this.noProgram.Name = "noProgram";
            this.noProgram.Size = new System.Drawing.Size(82, 17);
            this.noProgram.TabIndex = 1;
            this.noProgram.Text = "No Program";
            this.noProgram.UseVisualStyleBackColor = true;
            // 
            // overload
            // 
            this.overload.AutoSize = true;
            this.overload.Location = new System.Drawing.Point(7, 20);
            this.overload.Name = "overload";
            this.overload.Size = new System.Drawing.Size(91, 17);
            this.overload.TabIndex = 0;
            this.overload.Text = "Axis Overload";
            this.overload.UseVisualStyleBackColor = true;
            // 
            // gather
            // 
            this.gather.Tick += new System.EventHandler(this.gather_Tick);
            // 
            // cuttingToolButton
            // 
            this.cuttingToolButton.Location = new System.Drawing.Point(503, 329);
            this.cuttingToolButton.Name = "cuttingToolButton";
            this.cuttingToolButton.Size = new System.Drawing.Size(75, 23);
            this.cuttingToolButton.TabIndex = 15;
            this.cuttingToolButton.Text = "Add Tool";
            this.cuttingToolButton.UseVisualStyleBackColor = true;
            this.cuttingToolButton.Click += new System.EventHandler(this.cuttingToolButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.messageText);
            this.groupBox4.Controls.Add(this.messageCode);
            this.groupBox4.Location = new System.Drawing.Point(11, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 52);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Code";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(151, 23);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(215, 20);
            this.messageText.TabIndex = 14;
            this.messageText.Leave += new System.EventHandler(this.message_Leave);
            // 
            // messageCode
            // 
            this.messageCode.Location = new System.Drawing.Point(50, 23);
            this.messageCode.Name = "messageCode";
            this.messageCode.Size = new System.Drawing.Size(62, 20);
            this.messageCode.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cSpeedValue);
            this.groupBox5.Controls.Add(this.cLoadValue);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cSpeed);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.cLoad);
            this.groupBox5.Location = new System.Drawing.Point(402, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 70);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rotary C (Spindle)";
            // 
            // cSpeedValue
            // 
            this.cSpeedValue.Location = new System.Drawing.Point(266, 39);
            this.cSpeedValue.Name = "cSpeedValue";
            this.cSpeedValue.Size = new System.Drawing.Size(100, 20);
            this.cSpeedValue.TabIndex = 26;
            // 
            // cLoadValue
            // 
            this.cLoadValue.Location = new System.Drawing.Point(266, 16);
            this.cLoadValue.Name = "cLoadValue";
            this.cLoadValue.Size = new System.Drawing.Size(100, 20);
            this.cLoadValue.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Speed";
            // 
            // cSpeed
            // 
            this.cSpeed.Location = new System.Drawing.Point(82, 39);
            this.cSpeed.Name = "cSpeed";
            this.cSpeed.Size = new System.Drawing.Size(168, 18);
            this.cSpeed.TabIndex = 23;
            this.cSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cSpeed_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Load";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 21;
            // 
            // cLoad
            // 
            this.cLoad.Location = new System.Drawing.Point(82, 18);
            this.cLoad.Name = "cLoad";
            this.cLoad.Size = new System.Drawing.Size(168, 18);
            this.cLoad.TabIndex = 20;
            this.cLoad.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cLoad_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Functional Mode";
            // 
            // functionalMode
            // 
            this.functionalMode.FormattingEnabled = true;
            this.functionalMode.Items.AddRange(new object[] {
            "PRODUCTION",
            "SETUP",
            "TEARDOWN",
            "MAINTENANCE",
            "PROCESS_DEVELOPMENT"});
            this.functionalMode.Location = new System.Drawing.Point(102, 197);
            this.functionalMode.Name = "functionalMode";
            this.functionalMode.Size = new System.Drawing.Size(121, 21);
            this.functionalMode.TabIndex = 29;
            this.functionalMode.Text = "SETUP";
            // 
            // partID
            // 
            this.partID.Location = new System.Drawing.Point(277, 225);
            this.partID.Name = "partID";
            this.partID.Size = new System.Drawing.Size(100, 20);
            this.partID.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Part ID";
            // 
            // commonVariables
            // 
            this.commonVariables.AllowUserToAddRows = false;
            this.commonVariables.AllowUserToDeleteRows = false;
            this.commonVariables.AllowUserToResizeColumns = false;
            this.commonVariables.AllowUserToResizeRows = false;
            this.commonVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commonVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cv21,
            this.cv22,
            this.cv23,
            this.cv24});
            this.commonVariables.Location = new System.Drawing.Point(9, 17);
            this.commonVariables.Name = "commonVariables";
            this.commonVariables.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commonVariables.Size = new System.Drawing.Size(344, 48);
            this.commonVariables.TabIndex = 32;
            // 
            // cv21
            // 
            this.cv21.HeaderText = "21";
            this.cv21.Name = "cv21";
            this.cv21.Width = 75;
            // 
            // cv22
            // 
            this.cv22.HeaderText = "22";
            this.cv22.Name = "cv22";
            this.cv22.Width = 75;
            // 
            // cv23
            // 
            this.cv23.HeaderText = "23";
            this.cv23.Name = "cv23";
            this.cv23.Width = 75;
            // 
            // cv24
            // 
            this.cv24.HeaderText = "24";
            this.cv24.Name = "cv24";
            this.cv24.Width = 75;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.commonVariables);
            this.groupBox6.Location = new System.Drawing.Point(12, 312);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 74);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Common Variables (EXT)";
            // 
            // MachineTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 399);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.functionalMode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cuttingToolButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.program);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Execution);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.estop);
            this.Controls.Add(this.groupBox1);
            this.Name = "MachineTool";
            this.Text = "Machine Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mode.ResumeLayout(false);
            this.mode.PerformLayout();
            this.Execution.ResumeLayout(false);
            this.Execution.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonVariables)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox estop;
        private System.Windows.Forms.GroupBox mode;
        private System.Windows.Forms.RadioButton edit;
        private System.Windows.Forms.RadioButton mdi;
        private System.Windows.Forms.RadioButton manual;
        private System.Windows.Forms.RadioButton automatic;
        private System.Windows.Forms.GroupBox Execution;
        private System.Windows.Forms.RadioButton feedhold;
        private System.Windows.Forms.RadioButton stopped;
        private System.Windows.Forms.RadioButton running;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox program;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox xPositionValue;
        private System.Windows.Forms.TextBox xLoadValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar xPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar xLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox coolant;
        private System.Windows.Forms.CheckBox noProgram;
        private System.Windows.Forms.CheckBox overload;
        private System.Windows.Forms.CheckBox overtemp;
        private System.Windows.Forms.CheckBox something;
        private System.Windows.Forms.CheckBox travel;
        private System.Windows.Forms.Timer gather;
        private System.Windows.Forms.CheckBox flazBat;
        private System.Windows.Forms.Button cuttingToolButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.TextBox messageCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cSpeedValue;
        private System.Windows.Forms.TextBox cLoadValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HScrollBar cSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.HScrollBar cLoad;
        private System.Windows.Forms.RadioButton ready;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox functionalMode;
        private System.Windows.Forms.TextBox partID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView commonVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn cv21;
        private System.Windows.Forms.DataGridViewTextBoxColumn cv22;
        private System.Windows.Forms.DataGridViewTextBoxColumn cv23;
        private System.Windows.Forms.DataGridViewTextBoxColumn cv24;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

