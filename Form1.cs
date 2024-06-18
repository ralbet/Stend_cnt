using Microsoft.Win32;
using Modbus.Device;
using System;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stend_cnt.SerialPortClass;

namespace Stend_cnt
{
    public partial class Form1 : Form
    {

        //private SerialPort _serialPort;//= new SerialPort();
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




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var d = SerialPortClass.PropertiesReadSerialPort(ref serialPort1);
            if (d)
            {
                serialPort1.ReadTimeout = 100;//указать обязательно, для срабатывания исключения
                serialPort1.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort1);
            }



            // create modbus master

            // timer1.Start();
        }

        //private void OpenPortMaster()
        //{
        //    try
        //    {
        //        if (SerialPortClass.PropertiesReadSerialPort(ref _serialPort))
        //        {
        //            _serialPort.Open();

        //            master = ModbusSerialMaster.CreateRtu(_serialPort);
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show("Ошибка подключения " + err.Message);
        //        // richTextBox1.AppendText($"SerialPort(\"COM7\"), BaudRate = 115200, DataBits = 8, Parity = Parity.None, StopBits = StopBits.One  \n");
        //        return;
        //    }
        //}

        private void Timer1_Tick(object sender, EventArgs e)
        {
            decimal MB2Press;
            decimal MB2Drain;
            decimal MB2Move;
            decimal MB2Speed;
            decimal MB2in;
            decimal MB2out;
            //TB_MB2Drain
            try
            {
                Thread.Sleep(_sleeping);
                registers = master.ReadHoldingRegisters(slaveId, 523, 1);
                decimal registersD = Convert.ToDecimal(registers[0]);
                TB_MB2Drain.Text = registersD.ToString();
                MB2Drain = registersD;
            }
            catch (Exception err)
            {
                richTextBox1.AppendText($"MB2Drain: {err.Message} \n");
            }


            //TB_MB2Press
            try
            {
                Thread.Sleep(_sleeping);
                registers = master.ReadHoldingRegisters(slaveId, 522, 1);
                decimal registersD = Convert.ToDecimal(registers[0]);
                TB_MB2Press.Text = registersD.ToString();
                MB2Press = registersD;
            }
            catch (Exception err)
            {
                richTextBox1.AppendText($"MB2Press: {err.Message} \n");

            }

            //TB_MB2in
            try
            {
                Thread.Sleep(_sleeping);
                registers = master.ReadHoldingRegisters(slaveId, 526, 1);
                decimal registersD = Convert.ToDecimal(registers[0]);
                TB_MB2in.Text = registersD.ToString();
            }
            catch (Exception err)
            {
                richTextBox1.AppendText($"MB2in: {err.Message} \n");
            }


            //TB_MB2Speed
            try
            {
                Thread.Sleep(_sleeping);
                registers = master.ReadHoldingRegisters(slaveId, 525, 1);
                decimal registersD = Convert.ToDecimal(registers[0]);
                TB_MB2Speed.Text = registersD.ToString();
            }
            catch (Exception err)
            {
                richTextBox1.AppendText($"MB2Speed: {err.Message} \n");
            }

            //TB_MB2Move
            try
            {
                Thread.Sleep(_sleeping);
                registers = master.ReadHoldingRegisters(slaveId, 524, 1);
                decimal registersD = Convert.ToDecimal(registers[0]);
                TB_MB2Move.Text = registersD.ToString();
            }
            catch (Exception err)
            {
                richTextBox1.AppendText($"MB2Move: {err.Message} \n");
            }

            //TB_MB2out
            try
            {
                Thread.Sleep(_sleeping);
                registers = master.ReadHoldingRegisters(slaveId, 527, 1);
                decimal registersD = Convert.ToDecimal(registers[0]);
                TB_MB2out.Text = registersD.ToString();
            }
            catch (Exception err)
            {
                richTextBox1.AppendText($"MB2out: {err.Message} \n");
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string com = cmbPort.SelectedItem.ToString();
            // configure serial port
            serialPort1 = new SerialPort(com)
            {
                BaudRate = 115200,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One
            };
            try
            {
                serialPort1.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка подключения " + err.Message);
                richTextBox1.AppendText($"SerialPort(\"COM3\"), BaudRate = 115200, DataBits = 8, Parity = Parity.None, StopBits = StopBits.One  \n");

            }
            // create modbus master
            master = ModbusSerialMaster.CreateRtu(serialPort1);

            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ushort value_ = Convert.ToUInt16(textBox1.Text);
            //master.WriteSingleRegister(slaveId, 526, value_);
            // master.WriteSingleRegister(slaveId, 0, value_);
            slaveId = 2;
            var dr = master.WriteSingleRegisterAsync(slaveId, 0, value_);
        }

        private void TB_MB2in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                //if (e.KeyChar == (char)Keys.Enter)
                //{
                //    Properties.Settings.Default.PARAM_ID = Convert.ToInt16(((TextBox)sender).Text);
                //    Properties.Settings.Default.Save();
                //    PARAM_ID = Convert.ToInt16(tb_PARAM_ID.Text);
                //}
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                //if (e.KeyChar == (char)Keys.Enter)
                //{
                //    Properties.Settings.Default.PARAM_ID = Convert.ToInt16(((TextBox)sender).Text);
                //    Properties.Settings.Default.Save();
                //    PARAM_ID = Convert.ToInt16(tb_PARAM_ID.Text);
                //}
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                //if (e.KeyChar == (char)Keys.Enter)
                //{
                //    Properties.Settings.Default.PARAM_ID = Convert.ToInt16(((TextBox)sender).Text);
                //    Properties.Settings.Default.Save();
                //    PARAM_ID = Convert.ToInt16(tb_PARAM_ID.Text);
                //}
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //сжатие
            //////ushort value_ = Convert.ToUInt16(textBox2.Text);
            //////while (MB2Press <= value_)
            //////{
            //////    master.WriteSingleRegister(slaveId, 526, 1);
            //////}
            //////master.WriteSingleRegister(slaveId, 526, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //растяжение
            //////////ushort value_ = Convert.ToUInt16(textBox2.Text);
            //////////while (MB2Drain <= value_)
            //////////{
            //////////    master.WriteSingleRegister(slaveId, 526, 2);
            //////////}
            //////////master.WriteSingleRegister(slaveId, 526, 0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            master.WriteSingleRegister(slaveId, 526, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OprosRegistrov();
            //  OprosRegistrov2();
        }

        private void OprosRegistrov()
        {
            if (thread1 != null && thread1.IsAlive)
            {
                thread1.Abort();
            }
            thread1 = new Thread(new ParameterizedThreadStart(ReadRegistersWhele))
            {
                IsBackground = true,
                Name = "ReadRegistersWhelePotok",
            };
            Start_potok = true;
            //if (thread1.ThreadState == ThreadState.Running) return;

            try
            {
                object kontroller = 16; //адрес устройства
                thread1.Start(kontroller);
            }
            catch (ThreadStateException err)
            {
                this.SafeInvoke(() =>
                {
                    richTextBox1.AppendText($"ThreadStateException {err}\n");
                });
            }
            catch (OutOfMemoryException err)
            {
                this.SafeInvoke(() =>
                {
                    richTextBox1.AppendText("Exception err \n");
                });
            }
            catch (InvalidOperationException err)
            {
                this.SafeInvoke(() =>
                {
                    richTextBox1.AppendText("Exception err \n");
                });
            }

            //if (thread1.IsAlive)
            //{
            //    button6.Enabled = false;
            //}
            //*******готовим поток
            richTextBox1.AppendText($"Стартанули\n");
        }

        void ReadRegistersWhele(Object _slaveId)
        {
            while (Start_potok)
            {
                if (flag)
                {
                    flag = false;

                    byte slaveId = Convert.ToByte(_slaveId);
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            registers = master.ReadHoldingRegisters(slaveId, 306, 2);

                           // float Znach_ = PreobrZnach(registers);
                            valueRegister.MB2Press = PreobrZnach(registers);

                            DannyeNaEcran(valueRegister);

                        }
                        catch (Exception err)
                        {
                            registers = new ushort[0];
                            this.SafeInvoke(() =>
                            {
                                richTextBox1.AppendText($"registers1: {err}\n");
                            });
                        }


                        //decimal registers1 = Convert.ToDecimal(registers[0]);
                        //decimal registers2 = Convert.ToDecimal(registers[1]);
                        //decimal registers3 = Convert.ToDecimal(registers[2]);
                        //decimal registers4 = Convert.ToDecimal(registers[3]);
                        //decimal registers5 = Convert.ToDecimal(registers[4]);
                        //decimal registers6 = Convert.ToDecimal(registers[5]);

                        flag = true;
                        Thread.Sleep(_sleeping);
                    }
                    else
                    {
                        serialPort1.Open();
                    }

                }
            }
            this.SafeInvoke(() =>
            {
                richTextBox1.AppendText($"Завершился\n");
            });
        }

        void ReadRegistersWhele2(Object _slaveId)
        {
            while (Start_potok)
            {
                if (flag)
                {
                    flag = false;

                    byte slaveId = Convert.ToByte(_slaveId);
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            registers2 = master.ReadInputRegisters(slaveId, 0, 1);
 DannyeNaEcran2(registers2);
                        }
                        catch (Exception err)
                        {
                            this.SafeInvoke(() =>
                            {
                                richTextBox1.AppendText($"registers2: {err}\n");
                            });
                        }


                       
                        flag = true;
                        //if (registers2 == null) return;
                        Thread.Sleep(_sleeping);
                    }
                    else
                    {

                        serialPort1.Open();
                    }
                }
            }
            this.SafeInvoke(() =>
            {
                richTextBox1.AppendText($"Завершился2\n");
            });

        }

        private void DannyeNaEcran(ValueRegister valueRegister)
        {
            ValueRegister _valueRegister = valueRegister;
            if (_valueRegister == null) return;
            this.SafeInvoke(() =>
            {
                TB_MB2Drain.Text = _valueRegister.MB2Drain.ToString();
                TB_MB2Press.Text = _valueRegister.MB2Press.ToString();
                TB_MB2in.Text = _valueRegister.MB2in.ToString();
                TB_MB2Speed.Text = _valueRegister.MB2Speed.ToString();
                TB_MB2Move.Text = _valueRegister.MB2Move.ToString();
                TB_MB2out.Text = _valueRegister.MB2out.ToString();


            });
        }

        private void DannyeNaEcran2(ushort[] valueRegister)
        {
            ushort[] _valueRegister = valueRegister;
            if (_valueRegister == null) return;
            this.SafeInvoke(() =>
            {
                TB_temper.Text = _valueRegister[0].ToString();


            });
        }
        private void OprosRegistrov2()
        {
            if (thread2 != null && thread2.IsAlive)
            {
                thread2.Abort();
            }
            thread2 = new Thread(new ParameterizedThreadStart(ReadRegistersWhele2))
            {
                IsBackground = true,
                Name = "ReadRegistersWhelePotok2",
            };
            Start_potok = true;
            //if (thread2.ThreadState == ThreadState.Running) return;

            try
            {
                object kontroller = 2; //адрес устройства
                thread2.Start(kontroller);
            }
            catch (ThreadStateException err)
            {
                this.SafeInvoke(() =>
                {
                    richTextBox1.AppendText("ThreadStateException err\n");
                });
            }
            catch (OutOfMemoryException err)
            {
                this.SafeInvoke(() =>
                {
                    richTextBox1.AppendText("Exception err \n");
                });
            }
            catch (InvalidOperationException err)
            {
                this.SafeInvoke(() =>
                {
                    richTextBox1.AppendText("Exception err \n");
                });
            }

            //if (thread1.IsAlive)
            //{
            //    button6.Enabled = false;
            //}
            //*******готовим поток
            richTextBox1.AppendText($"Стартанули поток 2\n");
        }



        private static float PreobrZnach(ushort[] respBuffer)
        {
            //считываем 
            // registers = master.ReadHoldingRegisters(slaveId, 306, 2);
            //(1)slaveId-базовый адрес прибора(16 десят), (2)адрес регистра(дес). в инстр смотрим номер канала(7) и там адрес READ (132 h)/306 дес, (3) колич регистров сколько нужно считать
            //подставляем сюда
            byte[] canal_1 = BitConverter.GetBytes(respBuffer[0]).ToArray();//берем первое слово
            byte[] canal_2 = BitConverter.GetBytes(respBuffer[1]).ToArray();//берем второе слово
            byte[] canal_3 = canal_2.Concat(canal_1).ToArray();//(1)и(2) меняем местами

            float RetFloat = BitConverter.ToSingle(canal_3, 0);
            return RetFloat;
            //предназначен для значения которое хранится в двух регистрах
            //если в одном, можно сразу конвертировать?
        }
        public double BcdToDec(double val)
        {
            byte[] bcdNumber = BitConverter.GetBytes(val);
            double result = 0;
            foreach (byte b in bcdNumber)
            {
                int digit1 = b >> 4;
                int digit2 = b & 0x0f;
                result = (result * 100) + digit1 * 10 + digit2;
            }
            return result;
        }

        public double BcdToDec21(double val)
        {
            byte[] bcdNumber = BitConverter.GetBytes(val);
            double result = 0;
            foreach (byte b in bcdNumber)
            {
                int digit1 = b >> 4;
                int digit2 = b & 0x0f;
                result = (result * 100) + digit2 * 10 + digit1;
            }
            return result;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //настройка
            using (FormNastroyka form = new FormNastroyka(serialPort1)
            {
                Owner = this
            })
            {
                form.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Start_potok = false;
            flag = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OprosRegistrov2();
        }

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int _slaveId = 16;
            while (Start_potok)
            {
                if (flag)
                {
                    flag = false;

                    byte slaveId = Convert.ToByte(_slaveId);
                    if (!serialPort1.RtsEnable)
                    {
                        try
                        {
                            registers = master.ReadHoldingRegisters(slaveId, 306, 2);
                        }
                        catch (Exception err)
                        {

                            this.SafeInvoke(() =>
                            {
                                richTextBox1.AppendText($"registers1: {err}\n");
                            });
                        }

                       // float Znach_ = PreobrZnach(registers);
                        valueRegister.MB2Press = PreobrZnach(registers);

                        DannyeNaEcran(valueRegister);

                        flag = true;
                        Application.DoEvents();
                        Thread.Sleep(_sleeping);
                    }
                    else
                    {
                        serialPort1.Open();
                    }

                }
            }
            this.SafeInvoke(() =>
            {
                richTextBox1.AppendText($"Завершился\n");
            });
        }
    }

    public static class GUIExtensions
    {
        internal delegate void InvokeHandler();
        internal static void SafeInvoke(this System.Windows.Forms.Control control, InvokeHandler handler)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(handler);
            }
            else
            {
                handler();
            }
        }
    }
}
