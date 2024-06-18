using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stend_cnt
{
    internal class SerialPortClass
    {
        public static void OpenPortMaster(SerialPort _serialPort)
        {
            try
            {
                if (SerialPortClass.PropertiesReadSerialPort(ref _serialPort))
                {
                    if (!_serialPort.IsOpen) _serialPort.Open();
                   
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка подключения " + err.Message);
                // richTextBox1.AppendText($"SerialPort(\"COM7\"), BaudRate = 115200, DataBits = 8, Parity = Parity.None, StopBits = StopBits.One  \n");
                return;
            }
        }
        public static bool PropertiesReadSerialPort(ref SerialPort _serialPort)
        {
            string pattern = @"(.*?);"; //(.); // @"(.*?);
            Regex regex = new Regex(pattern);
            string[] port_ = new string[5];
            MatchCollection match = regex.Matches(Properties.Settings.Default.Param_ComPort);
            if (match.Count == 5)//если распознали 5 слов, то разбираем их
            {
                port_[0] = match[0].Groups[1].Value;
                port_[1] = match[1].Groups[1].Value;
                port_[2] = match[2].Groups[1].Value;
                port_[3] = match[3].Groups[1].Value;
                port_[4] = match[4].Groups[1].Value;
            }
            else
            {
                return false;
            }
            _serialPort = new SerialPort()
            {
                PortName = port_[0],
                BaudRate = Convert.ToInt32(port_[1]),
                Parity = (Parity)Enum.Parse(typeof(Parity), port_[3], true),
                DataBits = int.Parse(port_[2].ToUpperInvariant()),
                StopBits = (StopBits)Enum.Parse(typeof(StopBits), port_[4], true),
            };
   
           // if (!_serialPort.IsOpen) _serialPort.Open();
            return true;
        }
    }

   public class ValueRegister
    {

        public float MB2Press { get; set; }
        public float MB2Drain { get; set; }
        public float MB2Move { get; set; }
        public float MB2Speed { get; set; }
        public float MB2in { get; set; }
        public float MB2out { get; set; }

        public List<ValueRegister> ValueRegisters = new List<ValueRegister>();


        //public ValueRegister _valueRegister;
        //public ValueRegister valueRegister
        //{
        //    get
        //    {
        //        return _valueRegister;
        //    }
        //        set 
        //        { 
        //         this.Form1.TB_MB2Drain

        //            _valueRegister = value;
        //        }
        //}
    }



}
