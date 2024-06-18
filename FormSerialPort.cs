using Modbus.Device;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Stend_cnt
{
    public partial class FormSerialPort : Form
    {
        IModbusSerialMaster master;
        byte slaveId = 16;
        ushort[] registers;
        ushort[] registers2;
        int _sleeping = 100;
        bool Start_potok = true;
        ValueRegister valueRegister = new ValueRegister();
        bool flag = true;//true-свободен
        Thread thread1;
        Thread thread2;
        public FormSerialPort()
        {
            InitializeComponent();
        }

        private void FormSerialPort_Load(object sender, EventArgs e)
        {
            if (SerialPortClass.PropertiesReadSerialPort(ref serialPort1))
            {
                serialPort1.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort1);
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
