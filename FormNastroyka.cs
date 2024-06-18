using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Stend_cnt
{
    public partial class FormNastroyka : Form
    {
        SerialPort serialPort;
        public FormNastroyka(SerialPort _serialPort)
        {
            InitializeComponent();
            serialPort = _serialPort;
            serialPort.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //записать настройки в параметры
            //  string Checked_ = ChBoxComPortIspolz.Checked.ToString();
            Properties.Settings.Default.Param_ComPort = cmbPort.Text.ToString() + ";" + cmbBaud.Text.ToString() + ";" + cmbDataBit.Text.ToString() + ";" + cmbParity.Text.ToString() + ";" + cmbStopBit.Text.ToString() + ";";
            Properties.Settings.Default.Save();
        }

        private void FormNastroyka_Load(object sender, EventArgs e)
        {
            SerialPortClass.PropertiesReadSerialPort(ref serialPort);
            string[] ports = SerialPort.GetPortNames();
            int indPortName = 0;
            int i = 0;
            foreach (string s in ports)
            {
                cmbPort.Items.Add(s);

                if (serialPort.PortName == s)
                {
                    indPortName = i;
                }
                i++;
            }

            cmbPort.SelectedIndex = indPortName;
            cmbBaud.SelectedItem = serialPort.BaudRate.ToString();
            cmbDataBit.SelectedItem = serialPort.DataBits.ToString();
            cmbParity.SelectedItem = serialPort.Parity.ToString();
            cmbStopBit.SelectedItem = serialPort.StopBits.ToString();
        }
    }
}
