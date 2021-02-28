
namespace SoftSensConf
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.radioButtonConnectionStatus1 = new System.Windows.Forms.RadioButton();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelConnectstatus1 = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelChooseBaudRate = new System.Windows.Forms.Label();
            this.labelChoosePort = new System.Windows.Forms.Label();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.radioButtonConnectionStatus2 = new System.Windows.Forms.RadioButton();
            this.labelConnectionStatus2 = new System.Windows.Forms.Label();
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonReceived = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxNAPW = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelAlarmHigh = new System.Windows.Forms.Label();
            this.labelAlarmLow = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxAlarmLow = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.tabPageMonitoring = new System.Windows.Forms.TabPage();
            this.textBoxChartData = new System.Windows.Forms.TextBox();
            this.checkBoxScaled = new System.Windows.Forms.CheckBox();
            this.checkBoxRaw = new System.Windows.Forms.CheckBox();
            this.radioButtonConnectionStatus3 = new System.Windows.Forms.RadioButton();
            this.labelConnectionStatus3 = new System.Windows.Forms.Label();
            this.textBoxReadStatus = new System.Windows.Forms.TextBox();
            this.textBoxReadScaled = new System.Windows.Forms.TextBox();
            this.textBoxReadRaw = new System.Windows.Forms.TextBox();
            this.buttonReadStatus = new System.Windows.Forms.Button();
            this.buttonReadScaled = new System.Windows.Forms.Button();
            this.buttonReadRaw = new System.Windows.Forms.Button();
            this.buttonStopMonitoring = new System.Windows.Forms.Button();
            this.buttonStartMonitoring = new System.Windows.Forms.Button();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SaveFileSoftSensConf = new System.Windows.Forms.SaveFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LoadFileToSoftSensConf = new System.Windows.Forms.OpenFileDialog();
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.timerChartReceive = new System.Windows.Forms.Timer(this.components);
            this.saveFileChart = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.tabPageMonitoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageConnection);
            this.tabControlMain.Controls.Add(this.tabPageConfiguration);
            this.tabControlMain.Controls.Add(this.tabPageMonitoring);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 33);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1052, 474);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabStop = false;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.radioButtonConnectionStatus1);
            this.tabPageConnection.Controls.Add(this.comboBoxBaud);
            this.tabPageConnection.Controls.Add(this.comboBoxPort);
            this.tabPageConnection.Controls.Add(this.labelConnectstatus1);
            this.tabPageConnection.Controls.Add(this.buttonDisconnect);
            this.tabPageConnection.Controls.Add(this.buttonConnect);
            this.tabPageConnection.Controls.Add(this.labelChooseBaudRate);
            this.tabPageConnection.Controls.Add(this.labelChoosePort);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 29);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(1044, 441);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // radioButtonConnectionStatus1
            // 
            this.radioButtonConnectionStatus1.AutoSize = true;
            this.radioButtonConnectionStatus1.Location = new System.Drawing.Point(171, 373);
            this.radioButtonConnectionStatus1.Name = "radioButtonConnectionStatus1";
            this.radioButtonConnectionStatus1.Size = new System.Drawing.Size(21, 20);
            this.radioButtonConnectionStatus1.TabIndex = 8;
            this.radioButtonConnectionStatus1.UseVisualStyleBackColor = true;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxBaud.Location = new System.Drawing.Point(186, 113);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(171, 28);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(186, 38);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(171, 28);
            this.comboBoxPort.Sorted = true;
            this.comboBoxPort.TabIndex = 1;
            this.comboBoxPort.Enter += new System.EventHandler(this.comboBoxPort_Enter);
            // 
            // labelConnectstatus1
            // 
            this.labelConnectstatus1.AutoSize = true;
            this.labelConnectstatus1.Location = new System.Drawing.Point(8, 373);
            this.labelConnectstatus1.Name = "labelConnectstatus1";
            this.labelConnectstatus1.Size = new System.Drawing.Size(145, 20);
            this.labelConnectstatus1.TabIndex = 0;
            this.labelConnectstatus1.Text = "Connection Status:";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(221, 194);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(110, 43);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(53, 194);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(108, 43);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelChooseBaudRate
            // 
            this.labelChooseBaudRate.AutoSize = true;
            this.labelChooseBaudRate.Location = new System.Drawing.Point(33, 113);
            this.labelChooseBaudRate.Name = "labelChooseBaudRate";
            this.labelChooseBaudRate.Size = new System.Drawing.Size(142, 20);
            this.labelChooseBaudRate.TabIndex = 1;
            this.labelChooseBaudRate.Text = "Choose Baud rate:";
            // 
            // labelChoosePort
            // 
            this.labelChoosePort.AutoSize = true;
            this.labelChoosePort.Location = new System.Drawing.Point(29, 47);
            this.labelChoosePort.Name = "labelChoosePort";
            this.labelChoosePort.Size = new System.Drawing.Size(101, 20);
            this.labelChoosePort.TabIndex = 0;
            this.labelChoosePort.Text = "Choose Port:";
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.radioButtonConnectionStatus2);
            this.tabPageConfiguration.Controls.Add(this.labelConnectionStatus2);
            this.tabPageConfiguration.Controls.Add(this.textBoxReceived);
            this.tabPageConfiguration.Controls.Add(this.textBoxSend);
            this.tabPageConfiguration.Controls.Add(this.buttonReceived);
            this.tabPageConfiguration.Controls.Add(this.buttonSend);
            this.tabPageConfiguration.Controls.Add(this.labelPassword);
            this.tabPageConfiguration.Controls.Add(this.textBoxNAPW);
            this.tabPageConfiguration.Controls.Add(this.buttonLoad);
            this.tabPageConfiguration.Controls.Add(this.labelAlarmHigh);
            this.tabPageConfiguration.Controls.Add(this.labelAlarmLow);
            this.tabPageConfiguration.Controls.Add(this.labelURV);
            this.tabPageConfiguration.Controls.Add(this.labelLRV);
            this.tabPageConfiguration.Controls.Add(this.labelName);
            this.tabPageConfiguration.Controls.Add(this.textBoxAlarmHigh);
            this.tabPageConfiguration.Controls.Add(this.textBoxAlarmLow);
            this.tabPageConfiguration.Controls.Add(this.textBoxURV);
            this.tabPageConfiguration.Controls.Add(this.textBoxLRV);
            this.tabPageConfiguration.Controls.Add(this.textBoxName);
            this.tabPageConfiguration.Controls.Add(this.buttonSaveFile);
            this.tabPageConfiguration.Controls.Add(this.buttonWrite);
            this.tabPageConfiguration.Controls.Add(this.buttonRead);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(1044, 438);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // radioButtonConnectionStatus2
            // 
            this.radioButtonConnectionStatus2.AutoSize = true;
            this.radioButtonConnectionStatus2.Location = new System.Drawing.Point(171, 373);
            this.radioButtonConnectionStatus2.Name = "radioButtonConnectionStatus2";
            this.radioButtonConnectionStatus2.Size = new System.Drawing.Size(21, 20);
            this.radioButtonConnectionStatus2.TabIndex = 30;
            this.radioButtonConnectionStatus2.UseVisualStyleBackColor = true;
            // 
            // labelConnectionStatus2
            // 
            this.labelConnectionStatus2.AutoSize = true;
            this.labelConnectionStatus2.Location = new System.Drawing.Point(8, 373);
            this.labelConnectionStatus2.Name = "labelConnectionStatus2";
            this.labelConnectionStatus2.Size = new System.Drawing.Size(145, 20);
            this.labelConnectionStatus2.TabIndex = 0;
            this.labelConnectionStatus2.Text = "Connection Status:";
            // 
            // textBoxReceived
            // 
            this.textBoxReceived.Location = new System.Drawing.Point(582, 123);
            this.textBoxReceived.Multiline = true;
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.Size = new System.Drawing.Size(373, 125);
            this.textBoxReceived.TabIndex = 13;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(582, 37);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(373, 26);
            this.textBoxSend.TabIndex = 11;
            // 
            // buttonReceived
            // 
            this.buttonReceived.Location = new System.Drawing.Point(444, 123);
            this.buttonReceived.Name = "buttonReceived";
            this.buttonReceived.Size = new System.Drawing.Size(109, 43);
            this.buttonReceived.TabIndex = 14;
            this.buttonReceived.Text = "Received";
            this.buttonReceived.UseVisualStyleBackColor = true;
            this.buttonReceived.Click += new System.EventHandler(this.buttonReceived_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(444, 37);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(109, 46);
            this.buttonSend.TabIndex = 12;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(23, 290);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxNAPW
            // 
            this.textBoxNAPW.Location = new System.Drawing.Point(128, 290);
            this.textBoxNAPW.Name = "textBoxNAPW";
            this.textBoxNAPW.PasswordChar = '*';
            this.textBoxNAPW.Size = new System.Drawing.Size(151, 26);
            this.textBoxNAPW.TabIndex = 6;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(379, 389);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(93, 43);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelAlarmHigh
            // 
            this.labelAlarmHigh.AutoSize = true;
            this.labelAlarmHigh.Location = new System.Drawing.Point(23, 222);
            this.labelAlarmHigh.Name = "labelAlarmHigh";
            this.labelAlarmHigh.Size = new System.Drawing.Size(91, 20);
            this.labelAlarmHigh.TabIndex = 0;
            this.labelAlarmHigh.Text = "Alarm High:";
            // 
            // labelAlarmLow
            // 
            this.labelAlarmLow.AutoSize = true;
            this.labelAlarmLow.Location = new System.Drawing.Point(23, 171);
            this.labelAlarmLow.Name = "labelAlarmLow";
            this.labelAlarmLow.Size = new System.Drawing.Size(87, 20);
            this.labelAlarmLow.TabIndex = 0;
            this.labelAlarmLow.Text = "Alarm Low:";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(23, 123);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(48, 20);
            this.labelURV.TabIndex = 0;
            this.labelURV.Text = "URV:";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(23, 74);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(45, 20);
            this.labelLRV.TabIndex = 0;
            this.labelLRV.Text = "LRV:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // textBoxAlarmHigh
            // 
            this.textBoxAlarmHigh.Location = new System.Drawing.Point(128, 222);
            this.textBoxAlarmHigh.Name = "textBoxAlarmHigh";
            this.textBoxAlarmHigh.Size = new System.Drawing.Size(151, 26);
            this.textBoxAlarmHigh.TabIndex = 5;
            // 
            // textBoxAlarmLow
            // 
            this.textBoxAlarmLow.Location = new System.Drawing.Point(128, 171);
            this.textBoxAlarmLow.Name = "textBoxAlarmLow";
            this.textBoxAlarmLow.Size = new System.Drawing.Size(151, 26);
            this.textBoxAlarmLow.TabIndex = 4;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(128, 123);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(151, 26);
            this.textBoxURV.TabIndex = 3;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(128, 74);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(151, 26);
            this.textBoxLRV.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(280, 389);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(93, 43);
            this.buttonSaveFile.TabIndex = 9;
            this.buttonSaveFile.Text = "Save";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(379, 338);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(93, 45);
            this.buttonWrite.TabIndex = 8;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(280, 338);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(93, 45);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // tabPageMonitoring
            // 
            this.tabPageMonitoring.Controls.Add(this.textBoxChartData);
            this.tabPageMonitoring.Controls.Add(this.checkBoxScaled);
            this.tabPageMonitoring.Controls.Add(this.checkBoxRaw);
            this.tabPageMonitoring.Controls.Add(this.radioButtonConnectionStatus3);
            this.tabPageMonitoring.Controls.Add(this.labelConnectionStatus3);
            this.tabPageMonitoring.Controls.Add(this.textBoxReadStatus);
            this.tabPageMonitoring.Controls.Add(this.textBoxReadScaled);
            this.tabPageMonitoring.Controls.Add(this.textBoxReadRaw);
            this.tabPageMonitoring.Controls.Add(this.buttonReadStatus);
            this.tabPageMonitoring.Controls.Add(this.buttonReadScaled);
            this.tabPageMonitoring.Controls.Add(this.buttonReadRaw);
            this.tabPageMonitoring.Controls.Add(this.buttonStopMonitoring);
            this.tabPageMonitoring.Controls.Add(this.buttonStartMonitoring);
            this.tabPageMonitoring.Controls.Add(this.chartData);
            this.tabPageMonitoring.Location = new System.Drawing.Point(4, 29);
            this.tabPageMonitoring.Name = "tabPageMonitoring";
            this.tabPageMonitoring.Size = new System.Drawing.Size(1044, 441);
            this.tabPageMonitoring.TabIndex = 2;
            this.tabPageMonitoring.Text = "Monitoring";
            this.tabPageMonitoring.UseVisualStyleBackColor = true;
            // 
            // textBoxChartData
            // 
            this.textBoxChartData.Location = new System.Drawing.Point(363, 51);
            this.textBoxChartData.Multiline = true;
            this.textBoxChartData.Name = "textBoxChartData";
            this.textBoxChartData.Size = new System.Drawing.Size(112, 165);
            this.textBoxChartData.TabIndex = 24;
            this.textBoxChartData.TabStop = false;
            // 
            // checkBoxScaled
            // 
            this.checkBoxScaled.AutoSize = true;
            this.checkBoxScaled.Location = new System.Drawing.Point(363, 270);
            this.checkBoxScaled.Name = "checkBoxScaled";
            this.checkBoxScaled.Size = new System.Drawing.Size(129, 24);
            this.checkBoxScaled.TabIndex = 5;
            this.checkBoxScaled.Text = "Scaled Value";
            this.checkBoxScaled.UseVisualStyleBackColor = true;
            this.checkBoxScaled.CheckedChanged += new System.EventHandler(this.checkBoxScaled_CheckedChanged);
            // 
            // checkBoxRaw
            // 
            this.checkBoxRaw.AutoSize = true;
            this.checkBoxRaw.Location = new System.Drawing.Point(363, 231);
            this.checkBoxRaw.Name = "checkBoxRaw";
            this.checkBoxRaw.Size = new System.Drawing.Size(112, 24);
            this.checkBoxRaw.TabIndex = 4;
            this.checkBoxRaw.Text = "Raw Value";
            this.checkBoxRaw.UseVisualStyleBackColor = true;
            this.checkBoxRaw.CheckedChanged += new System.EventHandler(this.checkBoxRaw_CheckedChanged);
            // 
            // radioButtonConnectionStatus3
            // 
            this.radioButtonConnectionStatus3.AutoSize = true;
            this.radioButtonConnectionStatus3.Location = new System.Drawing.Point(171, 373);
            this.radioButtonConnectionStatus3.Name = "radioButtonConnectionStatus3";
            this.radioButtonConnectionStatus3.Size = new System.Drawing.Size(21, 20);
            this.radioButtonConnectionStatus3.TabIndex = 21;
            this.radioButtonConnectionStatus3.UseVisualStyleBackColor = true;
            // 
            // labelConnectionStatus3
            // 
            this.labelConnectionStatus3.AutoSize = true;
            this.labelConnectionStatus3.Location = new System.Drawing.Point(8, 373);
            this.labelConnectionStatus3.Name = "labelConnectionStatus3";
            this.labelConnectionStatus3.Size = new System.Drawing.Size(145, 20);
            this.labelConnectionStatus3.TabIndex = 0;
            this.labelConnectionStatus3.Text = "Connection Status:";
            // 
            // textBoxReadStatus
            // 
            this.textBoxReadStatus.Location = new System.Drawing.Point(183, 216);
            this.textBoxReadStatus.Name = "textBoxReadStatus";
            this.textBoxReadStatus.Size = new System.Drawing.Size(100, 26);
            this.textBoxReadStatus.TabIndex = 19;
            this.textBoxReadStatus.TabStop = false;
            // 
            // textBoxReadScaled
            // 
            this.textBoxReadScaled.Location = new System.Drawing.Point(183, 134);
            this.textBoxReadScaled.Name = "textBoxReadScaled";
            this.textBoxReadScaled.Size = new System.Drawing.Size(100, 26);
            this.textBoxReadScaled.TabIndex = 18;
            this.textBoxReadScaled.TabStop = false;
            // 
            // textBoxReadRaw
            // 
            this.textBoxReadRaw.Location = new System.Drawing.Point(183, 51);
            this.textBoxReadRaw.Name = "textBoxReadRaw";
            this.textBoxReadRaw.Size = new System.Drawing.Size(100, 26);
            this.textBoxReadRaw.TabIndex = 17;
            this.textBoxReadRaw.TabStop = false;
            // 
            // buttonReadStatus
            // 
            this.buttonReadStatus.Location = new System.Drawing.Point(25, 204);
            this.buttonReadStatus.Name = "buttonReadStatus";
            this.buttonReadStatus.Size = new System.Drawing.Size(141, 51);
            this.buttonReadStatus.TabIndex = 3;
            this.buttonReadStatus.Text = "Read Status";
            this.buttonReadStatus.UseVisualStyleBackColor = true;
            this.buttonReadStatus.Click += new System.EventHandler(this.buttonReadStatus_Click);
            // 
            // buttonReadScaled
            // 
            this.buttonReadScaled.Location = new System.Drawing.Point(25, 121);
            this.buttonReadScaled.Name = "buttonReadScaled";
            this.buttonReadScaled.Size = new System.Drawing.Size(141, 53);
            this.buttonReadScaled.TabIndex = 2;
            this.buttonReadScaled.Text = "Read Scaled";
            this.buttonReadScaled.UseVisualStyleBackColor = true;
            this.buttonReadScaled.Click += new System.EventHandler(this.buttonReadScaled_Click);
            // 
            // buttonReadRaw
            // 
            this.buttonReadRaw.Location = new System.Drawing.Point(25, 39);
            this.buttonReadRaw.Name = "buttonReadRaw";
            this.buttonReadRaw.Size = new System.Drawing.Size(141, 51);
            this.buttonReadRaw.TabIndex = 1;
            this.buttonReadRaw.Text = "Read Raw";
            this.buttonReadRaw.UseVisualStyleBackColor = true;
            this.buttonReadRaw.Click += new System.EventHandler(this.buttonReadRaw_Click);
            // 
            // buttonStopMonitoring
            // 
            this.buttonStopMonitoring.Enabled = false;
            this.buttonStopMonitoring.Location = new System.Drawing.Point(422, 324);
            this.buttonStopMonitoring.Name = "buttonStopMonitoring";
            this.buttonStopMonitoring.Size = new System.Drawing.Size(75, 34);
            this.buttonStopMonitoring.TabIndex = 7;
            this.buttonStopMonitoring.Text = "Stop";
            this.buttonStopMonitoring.UseVisualStyleBackColor = true;
            this.buttonStopMonitoring.Click += new System.EventHandler(this.buttonStopMonitoring_Click);
            // 
            // buttonStartMonitoring
            // 
            this.buttonStartMonitoring.Enabled = false;
            this.buttonStartMonitoring.Location = new System.Drawing.Point(331, 324);
            this.buttonStartMonitoring.Name = "buttonStartMonitoring";
            this.buttonStartMonitoring.Size = new System.Drawing.Size(75, 34);
            this.buttonStartMonitoring.TabIndex = 6;
            this.buttonStartMonitoring.Text = "Start";
            this.buttonStartMonitoring.UseVisualStyleBackColor = true;
            this.buttonStartMonitoring.Click += new System.EventHandler(this.buttonStartMonitoring_Click);
            // 
            // chartData
            // 
            chartArea4.AxisX.Title = "Time";
            chartArea4.AxisY.Title = "Value";
            chartArea4.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartData.Legends.Add(legend4);
            this.chartData.Location = new System.Drawing.Point(503, 0);
            this.chartData.Name = "chartData";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Raw Value";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Scaled Value";
            this.chartData.Series.Add(series7);
            this.chartData.Series.Add(series8);
            this.chartData.Size = new System.Drawing.Size(531, 393);
            this.chartData.TabIndex = 11;
            this.chartData.TabStop = false;
            this.chartData.Text = "Data";
            title4.Name = "Light Data";
            this.chartData.Titles.Add(title4);
            // 
            // SaveFileSoftSensConf
            // 
            this.SaveFileSoftSensConf.DefaultExt = "ssc";
            // 
            // LoadFileToSoftSensConf
            // 
            this.LoadFileToSoftSensConf.DefaultExt = "ssc";
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Interval = 1000;
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // timerChartReceive
            // 
            this.timerChartReceive.Interval = 1000;
            this.timerChartReceive.Tick += new System.EventHandler(this.timerChartReceived_Tick);
            // 
            // saveFileChart
            // 
            this.saveFileChart.DefaultExt = "csv";
            this.saveFileChart.FileName = "Chart_Data";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(78, 29);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 507);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(1074, 539);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.tabPageMonitoring.ResumeLayout(false);
            this.tabPageMonitoring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Label labelConnectstatus1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelChooseBaudRate;
        private System.Windows.Forms.Label labelChoosePort;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.SaveFileDialog SaveFileSoftSensConf;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton radioButtonConnectionStatus1;
        private System.Windows.Forms.TextBox textBoxAlarmHigh;
        private System.Windows.Forms.TextBox textBoxAlarmLow;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAlarmHigh;
        private System.Windows.Forms.Label labelAlarmLow;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog LoadFileToSoftSensConf;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.Timer timerChartReceive;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNAPW;
        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonReceived;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TabPage tabPageMonitoring;
        private System.Windows.Forms.Button buttonStopMonitoring;
        private System.Windows.Forms.Button buttonStartMonitoring;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.TextBox textBoxReadStatus;
        private System.Windows.Forms.TextBox textBoxReadScaled;
        private System.Windows.Forms.TextBox textBoxReadRaw;
        private System.Windows.Forms.Button buttonReadStatus;
        private System.Windows.Forms.Button buttonReadScaled;
        private System.Windows.Forms.Button buttonReadRaw;
        private System.Windows.Forms.RadioButton radioButtonConnectionStatus2;
        private System.Windows.Forms.Label labelConnectionStatus2;
        private System.Windows.Forms.RadioButton radioButtonConnectionStatus3;
        private System.Windows.Forms.Label labelConnectionStatus3;
        private System.Windows.Forms.CheckBox checkBoxScaled;
        private System.Windows.Forms.CheckBox checkBoxRaw;
        private System.Windows.Forms.SaveFileDialog saveFileChart;
        private System.Windows.Forms.TextBox textBoxChartData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
    }
}

