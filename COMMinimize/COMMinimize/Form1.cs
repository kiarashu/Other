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
using System.Threading;
using System.Runtime.InteropServices;

namespace COMMinimize
{
    public partial class Form1 : Form
    {
        //Just some configurations***********************************************
        //***********************************************************************
        //***********************************************************************
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
        static extern IntPtr SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, IntPtr lParam);

        const int WM_COMMAND = 0x111;
        const int MIN_ALL = 419;
        const int MIN_ALL_UNDO = 416;
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************


        SerialPort srlport = new SerialPort();
        bool connectOrDisconnect = true;
        bool minimizingButton = true;
        bool checkWhile = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPortsName.Items.Count != 0 && (stopBitOne.Checked == true || stopBitOnePointOne.Checked == true || stopBitTwo.Checked == true) && (dataBit5.Checked == true || dataBit6.Checked == true || dataBit7.Checked == true || dataBit8.Checked == true) && (baudRate115200.Checked == true || baudRate128000.Checked == true || baudRate19200.Checked == true || baudRate9600.Checked == true) && (parityEven.Checked == true || parityMark.Checked == true || parityNone.Checked == true || parityOdd.Checked == true))
                {
                    if (connectOrDisconnect == true)
                    {
                        //Ports
                        srlport.PortName = (string)cmbPortsName.SelectedItem;

                        //Stop Bit
                        if (stopBitOne.Checked)
                        {
                            srlport.StopBits = StopBits.One;
                        }
                        else if (stopBitOnePointOne.Checked)
                        {
                            srlport.StopBits = StopBits.OnePointFive;
                        }
                        else if (stopBitTwo.Checked)
                        {
                            srlport.StopBits = StopBits.Two;
                        }

                        //Data Bit
                        if (dataBit5.Checked)
                        {
                            srlport.DataBits = 5;
                        }
                        else if (dataBit6.Checked)
                        {
                            srlport.DataBits = 6;
                        }
                        else if (dataBit7.Checked)
                        {
                            srlport.DataBits = 7;
                        }
                        else if (dataBit8.Checked)
                        {
                            srlport.DataBits = 8;
                        }

                        //Parity
                        if (parityNone.Checked)
                        {
                            srlport.Parity = Parity.None;
                        }
                        else if (parityEven.Checked)
                        {
                            srlport.Parity = Parity.Even;
                        }
                        else if (parityOdd.Checked)
                        {
                            srlport.Parity = Parity.Odd;
                        }
                        else if (parityMark.Checked)
                        {
                            srlport.Parity = Parity.Mark;
                        }

                        //Baud Rate
                        if (baudRate9600.Checked)
                        {
                            srlport.BaudRate = 9600;
                        }
                        else if (baudRate19200.Checked)
                        {
                            srlport.BaudRate = 19200;
                        }
                        else if (baudRate115200.Checked)
                        {
                            srlport.BaudRate = 115200;
                        }
                        else if (baudRate128000.Checked)
                        {
                            srlport.BaudRate = 128000;
                        }
                        srlport.Open();
                        btnConnect.Text = "Disconnect";
                        connectOrDisconnect = false;
                        lblStatus.Text = "Connected!";
                        lblStatus.ForeColor = Color.Green;
                    }
                    else if (connectOrDisconnect == false)
                    {
                        srlport.Close();
                        connectOrDisconnect = true;
                        btnConnect.Text = "Connect";
                        lblStatus.Text = "Disconnected!";
                        lblStatus.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Please set all settings.", "Not all settings are choosed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCheckPorts_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strSerialPortNames = new string[20];
                int i = 0;
                while (true)
                {
                    strSerialPortNames[i] = Convert.ToString(SerialPort.GetPortNames()[i]);
                    cmbPortsName.Items.Add(strSerialPortNames[i]);
                    i++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                try
                {
                    cmbPortsName.SelectedIndex = 0;
                }
                catch
                {
                    MessageBox.Show("Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReadPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectOrDisconnect == false)
                {
                    if (minimizingButton == true)
                    {
                        lblStatus.Text = "Minimizing...!";
                        lblStatus.ForeColor = Color.Blue;
                        minimizingButton = false;
                        btnReadPort.Text = "Stop Minimizing";
                        checkWhile = true;
                        new Thread(() =>
                        {
                            try
                            {
                                while (checkWhile)
                                {
                                    int? read = srlport.ReadByte();
                                    if (read != null)
                                    {
                                        IntPtr lHwnd = FindWindow("Shell_TrayWnd", null);
                                        SendMessage(lHwnd, WM_COMMAND, (IntPtr)MIN_ALL, IntPtr.Zero);
                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }).Start();
                    }
                    else if (minimizingButton == false)
                    {
                        minimizingButton = true;
                        lblStatus.Text = "Minimizing Stoped.";
                        lblStatus.ForeColor = Color.Blue;
                        btnReadPort.Text = "Click to minimize";
                        checkWhile = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
