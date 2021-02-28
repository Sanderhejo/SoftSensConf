using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;


namespace SoftSensConf
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string recievedConfig = "0;1;2;3;4";
        string[] instrumentConfigRead = { };
        string instrumentConfigWrite;

        bool erstartknapptrykket;

        List<MeasurementPointRaw> AllMeasurementPointsRaw = new List<MeasurementPointRaw>();
        List<MeasurementPointScaled> AllMeasurementPointsScaled = new List<MeasurementPointScaled>();


        string enstringsammen()
        {
            return string.Format("{0};{1};{2};{3};{4}", textBoxName.Text, textBoxLRV.Text, textBoxURV.Text, textBoxAlarmLow.Text, textBoxAlarmHigh.Text);
        }

        public class MeasurementPointRaw
        {
            public string time { get; set; }
            public string RawValue { get; set; }
            public MeasurementPointRaw(string time, string RawValue)
            {
                this.time = time;
                this.RawValue = RawValue;
                
            }
            public override string ToString()
            {
                return time + ";" + RawValue;
            }
        }

        public class MeasurementPointScaled
        {
            public string time { get; set; }
            public string ScaledValue { get; set; }
            public MeasurementPointScaled(string time, string ScaledValue)
            {
                this.time = time;
                this.ScaledValue = ScaledValue;
            }
            public override string ToString()
            {
                return time + ";" + ScaledValue;
            }
        }

        private void comboBoxPort_Enter(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBoxPort.Items.Add(ports);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);

                serialPort1.Open();
                radioButtonConnectionStatus1.Checked = true;
                radioButtonConnectionStatus2.Checked = true;
                radioButtonConnectionStatus3.Checked = true;
                MessageBox.Show("Device is connected!");
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Unable to connect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonConnectionStatus1.Checked = false;
                radioButtonConnectionStatus2.Checked = false;
                radioButtonConnectionStatus3.Checked = false;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            radioButtonConnectionStatus1.Checked = false;
            radioButtonConnectionStatus2.Checked = false;
            radioButtonConnectionStatus3.Checked = false;
            timerChartReceive.Enabled = false;
            MessageBox.Show("Device is disconnected!");
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("readconf");
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
                recievedConfig = serialPort1.ReadExisting();
                instrumentConfigRead = recievedConfig.Split(';');
                TextBox[] textboxes = { textBoxName, textBoxLRV, textBoxURV, textBoxAlarmLow, textBoxAlarmHigh };

                textBoxName.Text = instrumentConfigRead[0];
                textBoxLRV.Text = instrumentConfigRead[1];
                textBoxURV.Text = instrumentConfigRead[2];
                textBoxAlarmLow.Text = instrumentConfigRead[3];
                textBoxAlarmHigh.Text = instrumentConfigRead[4];

                if (serialPort1.IsOpen)
                {
                    recievedConfig = serialPort1.ReadExisting();
                    MessageBox.Show("Read sucessful!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Device is not connected!");
                serialPort1.Close();
                radioButtonConnectionStatus1.Checked = false;
                radioButtonConnectionStatus2.Checked = false;
                radioButtonConnectionStatus3.Checked = false;
                timerChartReceive.Enabled = false;
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            instrumentConfigWrite = enstringsammen();

            if (textBoxName.Text == "")
            {
                MessageBox.Show("ERROR!, Please fill in empty box(es)!");
                textBoxName.Focus();
            }
            else if (textBoxLRV.Text == "")
            {
                MessageBox.Show("ERROR!, Please fill in empty box(es)!");
                textBoxLRV.Focus();
            }
            else if (textBoxURV.Text == "")
            {
                MessageBox.Show("ERROR!, Please fill in empty box(es)!");
                textBoxURV.Focus();
            }
            else if (textBoxAlarmLow.Text == "")
            {
                MessageBox.Show("ERROR!, Please fill in empty box(es)!");
                textBoxAlarmLow.Focus();
            }
            else if (textBoxAlarmHigh.Text == "")
            {
                MessageBox.Show("ERROR!, Please fill in empty box(es)!");
                textBoxAlarmHigh.Focus();
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Write("writeconf>" + textBoxNAPW.Text + ">" + instrumentConfigWrite);
                        int milliseconds = 2000;
                        Thread.Sleep(milliseconds);
                        string receivedConfirmation = serialPort1.ReadExisting();
                        int writeSuccess = int.Parse(receivedConfirmation);
                        if (writeSuccess == 1)
                        {
                            MessageBox.Show("Configuration is successfully written!");
                        }
                        else
                        {
                            MessageBox.Show("Write ERROR! Wrong password!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Write ERROR! Wrong password!");

                    }
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            var fileName = string.Empty;

            LoadFileToSoftSensConf.InitialDirectory = "c:\\";
            LoadFileToSoftSensConf.RestoreDirectory = true;
            LoadFileToSoftSensConf.Filter = "ssc files (*.ssc)|*.ssc|All files (*.*)|*.*";
            LoadFileToSoftSensConf.FileName = "";

            if (LoadFileToSoftSensConf.ShowDialog() == DialogResult.OK)
            {

                recievedConfig = File.ReadAllText(LoadFileToSoftSensConf.FileName);
                instrumentConfigRead = recievedConfig.Split(';');
                TextBox[] textboxes = { textBoxName, textBoxLRV, textBoxURV, textBoxAlarmLow, textBoxAlarmHigh };

                textBoxName.Text = instrumentConfigRead[0];
                textBoxLRV.Text = instrumentConfigRead[1];
                textBoxURV.Text = instrumentConfigRead[2];
                textBoxAlarmLow.Text = instrumentConfigRead[3];
                textBoxAlarmHigh.Text = instrumentConfigRead[4];
            }
            
        }
        
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            LoadFileToSoftSensConf.InitialDirectory = "c:\\";
            LoadFileToSoftSensConf.RestoreDirectory = true;
            LoadFileToSoftSensConf.Filter = "ssc files (*.ssc)|*.ssc|All files (*.*)|*.*";
            LoadFileToSoftSensConf.FileName = "";

            if (textBoxName.Text == "")
            {
                if (textBoxLRV.Text == "")
                {
                    if (textBoxURV.Text == "")
                    {
                        if (textBoxAlarmLow.Text == "")
                        {
                            if (textBoxAlarmHigh.Text == "")
                            {
                                MessageBox.Show("Can't save empty configuration!");
                            }
                            
                        }
                        else
                        {
                            
                            if (SaveFileSoftSensConf.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllText(SaveFileSoftSensConf.FileName, string.Join(";", instrumentConfigRead));
                            }
                        }
                    }
                    else
                    {
                        
                        if (SaveFileSoftSensConf.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(SaveFileSoftSensConf.FileName, string.Join(";", instrumentConfigRead));
                        }
                    }
                }
                else
                {
                    
                    if (SaveFileSoftSensConf.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(SaveFileSoftSensConf.FileName, string.Join(";", instrumentConfigRead));
                    }
                }
                
            }
            else
            {
                
                if (SaveFileSoftSensConf.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(SaveFileSoftSensConf.FileName, string.Join(";", instrumentConfigRead));
                }
            }

            
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && erstartknapptrykket)
            {
                if (checkBoxRaw.Checked)
                {
                    serialPort1.WriteLine("readraw");
                    timerChartReceive.Enabled = true;
                    timerChartAdd.Enabled = false;
                }
                else if (checkBoxScaled.Checked)
                {
                    serialPort1.WriteLine("readscaled");
                    timerChartReceive.Enabled = true;
                    timerChartAdd.Enabled = false;
                }
            }
        }

        private void timerChartReceived_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead > 0.0)
                {
                    if (checkBoxRaw.Checked)
                    {
                        MeasurementPointRaw measuredPointraw;
                        string avilableData = "";
                        avilableData += serialPort1.ReadExisting().ToString();

                        textBoxChartData.AppendText(avilableData + "\r\n");
                        measuredPointraw = new MeasurementPointRaw(DateTime.Now.ToLongTimeString(), string.Format(avilableData));
                        
                        
                        if (measuredPointraw != null)
                        {
                            AllMeasurementPointsRaw.Add(measuredPointraw);
                            
                        }
                        
                        chartData.Series[0].Points.AddXY(measuredPointraw.time, measuredPointraw.RawValue);
                        timerChartAdd.Enabled = true;
                        timerChartReceive.Enabled = false;

                        
                    }
                    else if (checkBoxScaled.Checked)
                    {
                        MeasurementPointScaled measuredPointscaled;
                        string avilableData = "";
                        avilableData += serialPort1.ReadExisting().ToString();

                        textBoxChartData.AppendText(avilableData + "\r\n");
                        measuredPointscaled = new MeasurementPointScaled(DateTime.Now.ToLongTimeString(), string.Format(avilableData));
                        
                        
                        if (measuredPointscaled != null)
                        {
                            AllMeasurementPointsScaled.Add(measuredPointscaled);
                        }
                        
                        chartData.Series[1].Points.AddXY(measuredPointscaled.time, measuredPointscaled.ScaledValue);
                        timerChartAdd.Enabled = true;
                        timerChartReceive.Enabled = false;
                    }
                }
            }
        }

        private void buttonReadRaw_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Thread.Sleep(1000);
                string LastDataRead = serialPort1.ReadExisting();
                serialPort1.Write("readraw");
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
                textBoxReadRaw.Text = serialPort1.ReadExisting();
            }
            erstartknapptrykket = true;
            timerChartAdd.Enabled = true;
            timerChartReceive.Enabled = false;
        }

        private void buttonReadScaled_Click(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen)
            {
                Thread.Sleep(1000);
                string LastDataRead = serialPort1.ReadExisting();
                serialPort1.Write("readscaled");
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
                textBoxReadScaled.Text = serialPort1.ReadExisting();                
            }
            erstartknapptrykket = true;
            timerChartAdd.Enabled = true;
            timerChartReceive.Enabled = false;
        }

        private void buttonReadStatus_Click(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen)
            {
                timerChartAdd.Enabled = false;
                timerChartReceive.Enabled = false;
                erstartknapptrykket = false;
                Thread.Sleep(1000);
                string LastDataRead = serialPort1.ReadExisting();

                try
                {
                    serialPort1.Write("readstatus");
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    textBoxReadStatus.Text = serialPort1.ReadExisting();
                    int writeSuccess = int.Parse(textBoxReadStatus.Text);

                    if (writeSuccess == 0)
                    {
                        MessageBox.Show("Status: OK");
                    }
                    if (writeSuccess == 1)
                    {
                        MessageBox.Show("Status: Fail!");
                    }
                    if (writeSuccess == 2)
                    {
                        MessageBox.Show("Attention!: Alram Low!");
                    }
                    if (writeSuccess == 3)
                    {
                        MessageBox.Show("Attention!: Alerm High!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR! Nothing to show!");

                }
                finally
                {
                    erstartknapptrykket = true;
                    timerChartAdd.Enabled = true;
                    timerChartReceive.Enabled = false;
                }

            }

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxSend.Text == "")
            {
                MessageBox.Show("Write: readconf, readraw or readscaled before pressing send");
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write(textBoxSend.Text);
                        textBoxSend.Clear();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void buttonReceived_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textBoxReceived.Text = serialPort1.ReadExisting();
            }
        }

        private void buttonStopMonitoring_Click(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = false;
            timerChartReceive.Enabled = false;
            erstartknapptrykket = false;

            checkBoxRaw.Enabled = true;
            checkBoxScaled.Enabled = true;

            checkBoxRaw.Checked = false;
            checkBoxScaled.Checked = false;

            buttonStopMonitoring.Enabled = false;



            DialogResult SaveQuestion = (MessageBox.Show(this, "Do you want to save?", "Save chartdata?", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (SaveQuestion == DialogResult.Yes)
            {
                LoadFileToSoftSensConf.InitialDirectory = "c:\\";
                LoadFileToSoftSensConf.RestoreDirectory = true;
                LoadFileToSoftSensConf.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                LoadFileToSoftSensConf.FileName = "";

                

                if (saveFileChart.ShowDialog() == DialogResult.OK)
                {
                    if (checkBoxRaw.Checked)
                    {
                        using (StreamWriter streamWritePoints = new StreamWriter(saveFileChart.FileName))

                            foreach (MeasurementPointRaw point in AllMeasurementPointsRaw)
                            {
                                streamWritePoints.WriteLine(point.ToString());
                            }
                    }
                    else if (checkBoxScaled.Checked)
                    {
                        using (StreamWriter streamWritePoints = new StreamWriter(saveFileChart.FileName))

                            foreach (MeasurementPointScaled point in AllMeasurementPointsScaled)
                            {
                                streamWritePoints.WriteLine(point.ToString());
                            }
                    }
                }
                
            }

        }

        private void buttonStartMonitoring_Click(object sender, EventArgs e)
        {
            erstartknapptrykket = true;
            timerChartAdd.Enabled = true;
            timerChartReceive.Enabled = false;

            if (checkBoxRaw.Checked)
            {
                checkBoxScaled.Enabled = false;
                checkBoxRaw.Enabled = false;
            }
            else if (checkBoxScaled.Checked)
            {
                checkBoxRaw.Enabled = false;
                checkBoxScaled.Enabled = false;
            }

            buttonStopMonitoring.Enabled = true;
            buttonStartMonitoring.Enabled = false;
             
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
            this.Visible = false;
            aboutWindow.FormClosed += new FormClosedEventHandler(aboutWindow_FormClosed);
            
        }

        void aboutWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void checkBoxRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRaw.Checked)
            {
                checkBoxScaled.Enabled = false;
                buttonStartMonitoring.Enabled = true;
            }
            else
            {
                checkBoxRaw.Enabled = true;
                checkBoxScaled.Enabled = true;
            }
        }

        private void checkBoxScaled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxScaled.Checked)
            {
                checkBoxRaw.Enabled = false;
                buttonStartMonitoring.Enabled = true;
            }
            else
            {
                checkBoxRaw.Enabled = true;
                checkBoxScaled.Enabled = true;
            }
        }
    }
}
