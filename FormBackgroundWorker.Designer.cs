namespace Stend_cnt
{
    partial class FormBackgroundWorker
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
            this.btnStartEnd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_MB2out = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_MB2Move = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_MB2Speed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_MB2in = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_MB2Press = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_MB2Drain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxPress = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_R8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_R7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_R6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_R5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_R4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_R3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_R2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_R1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TB_KOM = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxPress.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartEnd
            // 
            this.btnStartEnd.Location = new System.Drawing.Point(12, 316);
            this.btnStartEnd.Name = "btnStartEnd";
            this.btnStartEnd.Size = new System.Drawing.Size(223, 23);
            this.btnStartEnd.TabIndex = 0;
            this.btnStartEnd.Text = "Старт пресс";
            this.btnStartEnd.UseVisualStyleBackColor = true;
            this.btnStartEnd.Click += new System.EventHandler(this.btnStartEnd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "MB2out_состояние";
            // 
            // TB_MB2out
            // 
            this.TB_MB2out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_MB2out.Location = new System.Drawing.Point(239, 204);
            this.TB_MB2out.Name = "TB_MB2out";
            this.TB_MB2out.Size = new System.Drawing.Size(100, 31);
            this.TB_MB2out.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "MB2Move";
            // 
            // TB_MB2Move
            // 
            this.TB_MB2Move.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_MB2Move.Location = new System.Drawing.Point(239, 164);
            this.TB_MB2Move.Name = "TB_MB2Move";
            this.TB_MB2Move.Size = new System.Drawing.Size(100, 31);
            this.TB_MB2Move.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "MB2Speed";
            // 
            // TB_MB2Speed
            // 
            this.TB_MB2Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_MB2Speed.Location = new System.Drawing.Point(239, 127);
            this.TB_MB2Speed.Name = "TB_MB2Speed";
            this.TB_MB2Speed.Size = new System.Drawing.Size(100, 31);
            this.TB_MB2Speed.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "MB2in_вход.команда";
            // 
            // TB_MB2in
            // 
            this.TB_MB2in.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_MB2in.Location = new System.Drawing.Point(239, 87);
            this.TB_MB2in.Name = "TB_MB2in";
            this.TB_MB2in.Size = new System.Drawing.Size(100, 31);
            this.TB_MB2in.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "MB2Press";
            // 
            // TB_MB2Press
            // 
            this.TB_MB2Press.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_MB2Press.Location = new System.Drawing.Point(239, 47);
            this.TB_MB2Press.Name = "TB_MB2Press";
            this.TB_MB2Press.Size = new System.Drawing.Size(100, 31);
            this.TB_MB2Press.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "MB2Drain";
            // 
            // TB_MB2Drain
            // 
            this.TB_MB2Drain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_MB2Drain.Location = new System.Drawing.Point(239, 10);
            this.TB_MB2Drain.Name = "TB_MB2Drain";
            this.TB_MB2Drain.Size = new System.Drawing.Size(100, 31);
            this.TB_MB2Drain.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "термометр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxPress
            // 
            this.groupBoxPress.Controls.Add(this.label1);
            this.groupBoxPress.Controls.Add(this.TB_MB2Drain);
            this.groupBoxPress.Controls.Add(this.TB_MB2Press);
            this.groupBoxPress.Controls.Add(this.label4);
            this.groupBoxPress.Controls.Add(this.label2);
            this.groupBoxPress.Controls.Add(this.TB_MB2out);
            this.groupBoxPress.Controls.Add(this.TB_MB2in);
            this.groupBoxPress.Controls.Add(this.label5);
            this.groupBoxPress.Controls.Add(this.label3);
            this.groupBoxPress.Controls.Add(this.TB_MB2Move);
            this.groupBoxPress.Controls.Add(this.TB_MB2Speed);
            this.groupBoxPress.Controls.Add(this.label6);
            this.groupBoxPress.Location = new System.Drawing.Point(12, 27);
            this.groupBoxPress.Name = "groupBoxPress";
            this.groupBoxPress.Size = new System.Drawing.Size(347, 244);
            this.groupBoxPress.TabIndex = 60;
            this.groupBoxPress.TabStop = false;
            this.groupBoxPress.Text = "Пресс";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.TB_KOM);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 257);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(17, 154);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 31);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(17, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 31);
            this.numericUpDown1.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(417, 72);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 68);
            this.button7.TabIndex = 2;
            this.button7.Text = "STOP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(336, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 66);
            this.button6.TabIndex = 1;
            this.button6.Text = "Низ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(336, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 0;
            this.button2.Text = "Верх";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(864, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 195);
            this.richTextBox1.TabIndex = 62;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuItem1.Text = "Настройка";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TB_R8);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TB_R7);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TB_R6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TB_R5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TB_R4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TB_R3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TB_R2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TB_R1);
            this.groupBox3.Location = new System.Drawing.Point(365, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 303);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MB110";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "R8";
            // 
            // TB_R8
            // 
            this.TB_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R8.Location = new System.Drawing.Point(54, 266);
            this.TB_R8.Name = "TB_R8";
            this.TB_R8.Size = new System.Drawing.Size(100, 31);
            this.TB_R8.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "R7";
            // 
            // TB_R7
            // 
            this.TB_R7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R7.Location = new System.Drawing.Point(54, 229);
            this.TB_R7.Name = "TB_R7";
            this.TB_R7.Size = new System.Drawing.Size(100, 31);
            this.TB_R7.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "R6";
            // 
            // TB_R6
            // 
            this.TB_R6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R6.Location = new System.Drawing.Point(54, 192);
            this.TB_R6.Name = "TB_R6";
            this.TB_R6.Size = new System.Drawing.Size(100, 31);
            this.TB_R6.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "R5";
            // 
            // TB_R5
            // 
            this.TB_R5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R5.Location = new System.Drawing.Point(54, 155);
            this.TB_R5.Name = "TB_R5";
            this.TB_R5.Size = new System.Drawing.Size(100, 31);
            this.TB_R5.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "R4";
            // 
            // TB_R4
            // 
            this.TB_R4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R4.Location = new System.Drawing.Point(54, 118);
            this.TB_R4.Name = "TB_R4";
            this.TB_R4.Size = new System.Drawing.Size(100, 31);
            this.TB_R4.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "R3";
            // 
            // TB_R3
            // 
            this.TB_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R3.Location = new System.Drawing.Point(54, 81);
            this.TB_R3.Name = "TB_R3";
            this.TB_R3.Size = new System.Drawing.Size(100, 31);
            this.TB_R3.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "R2";
            // 
            // TB_R2
            // 
            this.TB_R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R2.Location = new System.Drawing.Point(54, 47);
            this.TB_R2.Name = "TB_R2";
            this.TB_R2.Size = new System.Drawing.Size(100, 31);
            this.TB_R2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "R1";
            // 
            // TB_R1
            // 
            this.TB_R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_R1.Location = new System.Drawing.Point(54, 13);
            this.TB_R1.Name = "TB_R1";
            this.TB_R1.Size = new System.Drawing.Size(100, 31);
            this.TB_R1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Сжатие";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Растяжение";
            // 
            // TB_KOM
            // 
            this.TB_KOM.Location = new System.Drawing.Point(336, 94);
            this.TB_KOM.Name = "TB_KOM";
            this.TB_KOM.Size = new System.Drawing.Size(75, 20);
            this.TB_KOM.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Низ 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // FormBackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 733);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStartEnd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPress);
            this.Controls.Add(this.button1);
            this.Name = "FormBackgroundWorker";
            this.Text = "FormBackgroundWorker";
            this.Load += new System.EventHandler(this.FormBackgroundWorker_Load);
            this.groupBoxPress.ResumeLayout(false);
            this.groupBoxPress.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_MB2out;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_MB2Move;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_MB2Speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_MB2in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_MB2Press;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_MB2Drain;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxPress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_R8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_R7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_R6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_R5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_R4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_R3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_R2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_R1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TB_KOM;
        private System.Windows.Forms.Button button3;
    }
}