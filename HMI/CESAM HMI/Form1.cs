using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using CESAMKinematics;

namespace CESAM_HMI
{
    public partial class Form1 : Form
    {
        
        //Serial port parameters
        string portName;
        SerialPort port;

        //estop button variables for the blinking animation
        bool blnEStopActivated = false;
        bool blnEStopBlinkFlag = true;
        System.Windows.Forms.Timer timerEStopBlink = new System.Windows.Forms.Timer();

        //Jog button variables for jogging the axes
        static bool blnJogCW = false;
        static bool blnJogCCW = false;
        static int selectedJogAxis = 0;


        ToolTip toolTip = new ToolTip();
        public Form1()
        {
            InitializeComponent();  
        }

        public void ShowSplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //populating the serial port listbox with the serial ports
            RefreshCOMPorts();
            //lstBoxSerialPorts.Update();

            //setting tooltip parameters
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            //setting estopbutton blinktimer parameters
            timerEStopBlink.Tick += new EventHandler((sender1, e1) => EStopBlink(sender1, e1));
            timerEStopBlink.Interval = 250;

        }

        public void RefreshCOMPorts()
        {
            string[] serialPorts = System.IO.Ports.SerialPort.GetPortNames();

            if(lstBoxSerialPorts.Items.Count > 0)
            {
                lstBoxSerialPorts.Items.Clear();
            }

            foreach (string serialPort in serialPorts)
            {
                lstBoxSerialPorts.Items.Add(serialPort);
                Console.WriteLine(serialPort);
            }
        }

        private void Form1_closed(object sender, EventArgs e)
        {
            if(port != null)
            {
                port.Close();
            }
            
        }
        private void SendCommand(string command)
        {
            
            try
            {

                port.Open();
                port.WriteLine(command);
                
                //System.Threading.Thread.Sleep(1);
                lstBoxCommandWindow.Items.Add($">>{command}");
                lstBoxCommandWindow.SelectedIndex = lstBoxCommandWindow.Items.Count - 1;
            }catch(Exception e)
            {
                MessageBox.Show($"Communication Error:{e} ");
            }
            finally
            {
                port.Close();
            }

        }

        private void SendCharCommand(Char commandChar)
        {
            //string portName = txtBoxCOMPort.Text;
            //SerialPort port = new SerialPort(portName, 9600);

            try
            {
                port.Open();
                //port.WriteLine(commandChar.ToString());
                byte[] byteArray = {((byte)commandChar)};
                port.Write(byteArray, 0, 1);
                
                //System.Threading.Thread.Sleep(1);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Communication Error:{e} ");
            }
            finally
            {
                port.Close();
            }
        }

        private void trkBarJogSpeed_Scroll(object sender, EventArgs e)
        {
            toolTip.SetToolTip(trkBarJogSpeed, "Jog Speed = " + (trkBarJogSpeed.Value * 10) + "%" );
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            blnEStopActivated = !blnEStopActivated;
            
            if (blnEStopActivated)
            {
                timerEStopBlink.Enabled = true;
                timerEStopBlink.Start();
                SendCharCommand('S');
            }
            else
            {
                timerEStopBlink.Stop();
                //timerEStopBlink.Enabled = false;
                btnSTOP.ForeColor = Color.White;
            }
        }

        public void EStopBlink(object sender, EventArgs e)
        {
            if(blnEStopBlinkFlag == true)
            {
                btnSTOP.ForeColor = Color.DarkRed;
                blnEStopBlinkFlag = false;
            }
            else
            {
                btnSTOP.ForeColor = Color.White;
                blnEStopBlinkFlag = true;
            }
        }

        private void btnJogCW_Click(object sender, EventArgs e)
        {
            

            
        }
        private void btnJogCCW_Click(object sender, EventArgs e)
        {
            
        }


        private void btnJogCW_MouseDown(object sender, EventArgs e)
        {
            //Console.WriteLine("Mouse Down");
            selectedJogAxis = lstBoxJogAxis.SelectedIndex + 1;
            SendCommand($"JCW-{selectedJogAxis}");
            
        }

        private void btnJogCW_MouseUp(object sender, EventArgs e)
        {
            //Console.WriteLine("Mouse Up");
            //blnJogCW = false;
            SendCharCommand('S');
        }

        private void btnJogCCW_MouseDown(object sender, EventArgs e)
        {
            //Console.WriteLine("Mouse Down");
            selectedJogAxis = lstBoxJogAxis.SelectedIndex + 1;
            SendCommand($"JCC-{selectedJogAxis}");
        }

        private void btnJogCCW_MouseUp(object sender, EventArgs e)
        {
            //Console.WriteLine("STOPJOG");
            //blnJogCCW = false;
            SendCharCommand('S');

        }

        

        

        private void btnAbsPosition_Click(object sender, EventArgs e)
        {
            int absAngle = Int32.Parse(txtBoxAbsPos.Text);
            int selectedAxis = lstBoxAbsPositionAxis.SelectedIndex + 1;
            Console.WriteLine(selectedAxis);
            SendCommand($"AB-{selectedAxis}-{absAngle}");
        }

        private void btnInitAxis_Click(object sender, EventArgs e)
        {
            int initAngle = Int32.Parse(txtBoxInitAngle.Text);
            int selectedAxis = lstBoxHomeAxis.SelectedIndex + 1;
            SendCommand($"INITAXIS-{selectedAxis}-{initAngle}");
        }

        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            

            try
            {
                portName = lstBoxSerialPorts.SelectedItem.ToString().Trim();
                if (portName != null)
                {
                    port = new SerialPort(portName, 9600);

                    
                    grpBoxJog.Enabled = true;
                    grpBoxAbsPos.Enabled = true;
                    grpBoxHoming.Enabled = true;
                    grpboxJointMove.Enabled = true;
                    grpBoxCmdWdw.Enabled = true;
                    grpBoxESTOP.Enabled = true;  
                }
                else
                {
                    MessageBox.Show("Port Name cannot be empty");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

        private void txtBoxCOMPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerialDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(port != null)
                {
                    port.Close();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("Cannot close port that isn't open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            grpBoxJog.Enabled = false;
            grpBoxAbsPos.Enabled = false;
            grpBoxHoming.Enabled = false;
            grpboxJointMove.Enabled = false;
            grpBoxCmdWdw.Enabled = false;
            grpBoxESTOP.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCOMPorts();
        }
    }
}
