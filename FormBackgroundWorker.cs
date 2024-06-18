using Modbus.Device;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Stend_cnt
{
    public partial class FormBackgroundWorker : Form
    {
        private SerialPort _serialPort = new SerialPort();
        IModbusSerialMaster master;
        byte slaveId1 = 20;//адрес пресса
        byte slaveId2 = 16;//адрес МВ110 - датчики давления
        ushort[] registers;
        ushort[] registers2;
        int _sleeping = 100;
        bool Start_potok = true;
        ValueRegister valueRegister = new ValueRegister();
        float[] valueRegisters2 = new float[8];

        BackgroundWorker worker;
        BackgroundWorker worker2;
        BackgroundWorker worker3;
        int PressKomand = -1;
        float delta = 0.2F;

        public FormBackgroundWorker()
        {
            InitializeComponent();
        }

        private void FormBackgroundWorker_Load(object sender, EventArgs e)
        {
            //SerialPortClass.OpenPortMaster(_serialPort);

            var d = SerialPortClass.PropertiesReadSerialPort(ref serialPort1);
            if (d)
            {
                serialPort1.ReadTimeout = 100;//указать обязательно, для срабатывания исключения
                serialPort1.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort1);
            }

            //master = ModbusSerialMaster.CreateRtu(_serialPort);
            //master.Transport.ReadTimeout = _sleeping;
            //master.Transport.WriteTimeout = _sleeping;

            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);//отображение на экране
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);//завершение потока
            //worker.Disposed += Worker_Disposed;

            worker2 = new BackgroundWorker();
            worker2.WorkerReportsProgress = true;
            worker2.WorkerSupportsCancellation = true;

            worker2.DoWork += new DoWorkEventHandler(worker2_DoWork);
            worker2.ProgressChanged += new ProgressChangedEventHandler(worker2_ProgressChanged);
            worker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker2_RunWorkerCompleted);
            //worker2.Disposed += Worker2_Disposed;

            worker3 = new BackgroundWorker();
            worker3.WorkerReportsProgress = true;
            worker3.WorkerSupportsCancellation = true;

            worker3.DoWork += new DoWorkEventHandler(worker3_DoWork);
            worker3.ProgressChanged += new ProgressChangedEventHandler(worker3_ProgressChanged);
            worker3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker3_RunWorkerCompleted);
            //worker3.Disposed += Worker3_Disposed;

            worker.RunWorkerAsync();
            worker2.RunWorkerAsync();
            worker3.RunWorkerAsync();
        }



        private void worker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int kom = (int)e.UserState;
            TB_KOM.Text = kom.ToString();
        }

        void worker3_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        if (PressKomand == 0)
                        {
                            if (valueRegister.MB2in != PressKomand)
                            {
                                if (!_serialPort.IsOpen) _serialPort.Open();
                                master.WriteSingleRegister(slaveId1, 526, (ushort)PressKomand);
                            }

                        }
                        if (PressKomand == 1)
                        {
                            if (valueRegister.MB2Press < (float)numericUpDown1.Value && valueRegister.MB2in != PressKomand)
                            {
                                if (!_serialPort.IsOpen) _serialPort.Open();
                                master.WriteSingleRegister(slaveId1, 526, (ushort)PressKomand);
                            }
                            else if (valueRegister.MB2Press >= (float)numericUpDown1.Value && valueRegister.MB2in != 0)
                            {
                                if (!_serialPort.IsOpen) _serialPort.Open();
                                master.WriteSingleRegister(slaveId1, 526, 0);
                            }
                        }

                        if (PressKomand == 2)
                        {
                            if (valueRegister.MB2Drain < (float)numericUpDown2.Value && valueRegister.MB2in != PressKomand)
                            {
                                if (!_serialPort.IsOpen) _serialPort.Open();
                                master.WriteSingleRegister(slaveId1, 526, (ushort)PressKomand);
                            }
                            else if (valueRegister.MB2Drain >= (float)numericUpDown1.Value && valueRegister.MB2in != 0)
                            {
                                if (!_serialPort.IsOpen) _serialPort.Open();
                                master.WriteSingleRegister(slaveId1, 526, 0);
                            }
                        }

                        worker3.ReportProgress(1, PressKomand);
                    }
                    catch (Exception err)
                    {
                        richTextBox1.AppendText(err.Message);
                    }
                    Thread.Sleep(_sleeping);
                }
            }
        }
        private void Worker2_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show("Worker2_Disposed");
        }

        private void Worker_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show("Worker_Disposed");
        }

        void worker2_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                if (worker2.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        if (!_serialPort.IsOpen) _serialPort.Open();
                        registers2 = master.ReadHoldingRegisters(slaveId2, 288, 24);
                        if (registers2 == null) return;
                        ushort[] d01 = new ushort[2];
                        int r = 0;
                        valueRegisters2 = new float[8];
                        for (global::System.Int32 i = 0; i < 8; i++)
                        {
                            d01[0] = registers2[r]; d01[1] = registers2[r + 1];
                            valueRegisters2[i] = PreobrZnach(d01);
                            r = r + 3;
                        }
                        //число занимает 3 регистра. 1 и 2 значение и тредий время
                        //регистры читаются с 288 адреса 24 штуки(до311)
                        Thread.Sleep(_sleeping);
                        worker2.ReportProgress(1, valueRegisters2);
                    }
                    catch (Exception err)
                    {
                        this.SafeInvoke(() =>
                        {
                            richTextBox1.AppendText(err.Message);
                        });
                        //TxtSendErr(err.Message);
                    }
                }
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        if (!_serialPort.IsOpen) _serialPort.Open();
                        registers = master.ReadHoldingRegisters(slaveId1, 522, 6);
                        if (registers == null) return;

                        Thread.Sleep(_sleeping);
                        worker.ReportProgress(1, registers);

                    }
                    catch (Exception err)
                    {
                        richTextBox1.AppendText(err.Message);
                    }
                }
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //получили значение регистров и отображаем на экране 1
            ushort[] registers = (ushort[])e.UserState;
            if (registers == null) return;
            // float Znach_ = PreobrZnach(registers);
            valueRegister.MB2Press = (float)Convert.ToDouble(registers[0]);//522
            valueRegister.MB2Drain = (float)Convert.ToDecimal(registers[1]);//523
            valueRegister.MB2Move = (float)Convert.ToDecimal(registers[2]);//524
            valueRegister.MB2Speed = (float)Convert.ToDecimal(registers[3]);//525
            valueRegister.MB2in = (float)Convert.ToDecimal(registers[4]);//526
            valueRegister.MB2out = (float)Convert.ToDecimal(registers[5]);//527

            DannyeNaEcran(valueRegister);
            //progressBar1.Value = e.ProgressPercentage;//www.csharp-console-examples.com
        }

        void worker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //получили значение регистров и отображаем на экране 2
            float[] reg = (float[])e.UserState;
            if (reg == null) return;

            TB_R1.Text = float.IsNaN(reg[0]) ? "##.#" : reg[0].ToString("F3");
            TB_R2.Text = float.IsNaN(reg[1]) ? "##.#" : reg[1].ToString("F3");
            TB_R3.Text = float.IsNaN(reg[2]) ? "##.#" : reg[2].ToString("F3");
            TB_R4.Text = float.IsNaN(reg[3]) ? "##.#" : reg[3].ToString("F3");
            TB_R5.Text = float.IsNaN(reg[4]) ? "##.#" : reg[4].ToString("F3");
            TB_R6.Text = float.IsNaN(reg[5]) ? "##.#" : reg[5].ToString("F3");
            TB_R7.Text = float.IsNaN(reg[6]) ? "##.#" : reg[6].ToString("F3");
            TB_R8.Text = float.IsNaN(reg[7]) ? "##.#" : reg[7].ToString("F3");
        }

        private void worker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //завершение потока

        }
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //завершение потока
            if (e.Cancelled)
            {

            }
            else
            {
                MessageBox.Show("Asynchronous thread came up to the value:" + e.Result.ToString());
            }
            btnStartEnd.Text = "Start1";
        }

        void worker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //завершение потока
            if (e.Cancelled)
            {

            }
            else
            {
                MessageBox.Show("Asynchronous thread came up to the value:" + e.Result.ToString());
            }
            button1.Text = "Start2";
        }

        private void btnStartEnd_Click(object sender, EventArgs e)
        {
            //кнопка запуска опроса пресса
            if (worker.IsBusy)
            {
                worker.CancelAsync();
                btnStartEnd.Text = "Start";
            }
            else
            {
                worker.RunWorkerAsync();
                btnStartEnd.Text = "Stop1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка запуска опроса МВ110
            if (worker2.IsBusy)
            {
                worker2.CancelAsync();
                btnStartEnd.Text = "Start";
            }
            else
            {
                worker2.RunWorkerAsync();
                button1.Text = "Stop2";
            }
        }

        private void DannyeNaEcran(ValueRegister valueRegister)
        {
            ValueRegister _valueRegister = valueRegister;
            if (_valueRegister == null) return;
            //this.SafeInvoke(() =>{
            TB_MB2Drain.Text = _valueRegister.MB2Drain.ToString();
            TB_MB2Press.Text = float.IsNaN(_valueRegister.MB2Press) ? "##.#" : _valueRegister.MB2Press.ToString();
            TB_MB2in.Text = _valueRegister.MB2in.ToString();
            TB_MB2Speed.Text = _valueRegister.MB2Speed.ToString();
            TB_MB2Move.Text = _valueRegister.MB2Move.ToString();
            TB_MB2out.Text = _valueRegister.MB2out.ToString();
            //});
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


        public static void TxtSendErr(string Mess)
        {
            string txtErr = DateTime.Now.ToString() + ": " + Mess + Environment.NewLine;
            //формируем текст сообщения
            //string FN = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName.Split('\\').Last();
            // string FN1 = FN.Remove(FN.Length - 4, 4);
            //имя исполняемого файла с расширением
            File.AppendAllText(Path.GetTempPath() + "Ошибка_stanok.txt", txtErr);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Red;

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Blue;
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            //сжатие - вверх
            //запускаем отслеживание: MB2Press должно дыть не больше numericUpDown1
            //останавливается при нажатии на стоп???
            //master.WriteSingleRegister(slaveId1, 526, 1);
            //проверить на управление:местное/дистанционное
            if (valueRegister.MB2out == 64F)
            {
                MessageBox.Show("Переведите ПРЕСС на дистанционное управление");
                return;
            }
            PressKomand = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //растяжение - вниз
            // master.WriteSingleRegister(slaveId1, 526, 2);
            if (valueRegister.MB2out == 64F)
            {
                MessageBox.Show("Переведите ПРЕСС на дистанционное управление");
                return;
            }
            PressKomand = 2;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //стоп
            //  master.WriteSingleRegister(slaveId1, 526, 0);
            // 0 - обнуление
            // 4 - авария
            if (valueRegister.MB2out == 64F)
            {
                MessageBox.Show("Переведите ПРЕСС на дистанционное управление");
                return;
            }
            PressKomand = 0;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            master.WriteSingleRegister(slaveId1, 526, 2);
        }

        /// <summary>
        /// Чтение бита из регистра, возвращает значение бита
        /// </summary>
        /// <param name="slaveID"> всегда =1 </param>
        /// <param name="registerAddress">адрес регистра </param>
        /// <param name="adressBit">номер бита </param>
        /// <returns></returns>
        //////private int ReadToBit(byte slaveID, ushort registerAddress, int adressBit)
        //////{
        //////    int Result;
        //////    try
        //////    {
        //////        if (!tcpClient.Connected) tcpClient.Connect(Stanok_.IpAddress, Stanok_.Ip_port);//ошибка если не находит устройство
        //////        Master = ModbusIpMaster.CreateIp(tcpClient);
        //////        ushort[] r14 = Master.ReadHoldingRegisters(slaveID, registerAddress, 1);//прочитать из регистра_registerAddress 1 слово/ размерность массива зависит от того, сколько регистров считали
        //////        //перерасчитать, изменить и отправить 
        //////        string r14Str2 = Convert.ToString(r14[0], 2).PadLeft(16, '0');
        //////        char[] bit_str = (r14Str2.Reverse()).ToArray();
        //////        Result = Convert.ToInt16(new string(bit_str[adressBit], 1));
        //////    }
        //////    catch (Exception err)
        //////    {
        //////        richTextBox2.AppendText($" ReadToBit: {err.Message}\n");
        //////        TcpClientOpen();
        //////        ReadToBit(slaveID, registerAddress, adressBit);
        //////        Result = -1;
        //////    }
        //////    return Result;
        //////}
    }
}
