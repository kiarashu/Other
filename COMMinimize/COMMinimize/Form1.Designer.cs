namespace COMMinimize
{
    partial class Form1
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
            this.btnReadPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPortsName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckPorts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parityNone = new System.Windows.Forms.RadioButton();
            this.parityEven = new System.Windows.Forms.RadioButton();
            this.parityOdd = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stopBitOne = new System.Windows.Forms.RadioButton();
            this.stopBitOnePointOne = new System.Windows.Forms.RadioButton();
            this.stopBitTwo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataBit5 = new System.Windows.Forms.RadioButton();
            this.dataBit6 = new System.Windows.Forms.RadioButton();
            this.dataBit7 = new System.Windows.Forms.RadioButton();
            this.dataBit8 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.baudRate9600 = new System.Windows.Forms.RadioButton();
            this.baudRate115200 = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.baudRate19200 = new System.Windows.Forms.RadioButton();
            this.baudRate128000 = new System.Windows.Forms.RadioButton();
            this.parityMark = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadPort
            // 
            this.btnReadPort.Location = new System.Drawing.Point(12, 284);
            this.btnReadPort.Name = "btnReadPort";
            this.btnReadPort.Size = new System.Drawing.Size(262, 42);
            this.btnReadPort.TabIndex = 0;
            this.btnReadPort.Text = "Click to minimize";
            this.btnReadPort.UseVisualStyleBackColor = true;
            this.btnReadPort.Click += new System.EventHandler(this.BtnReadPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status: ";
            // 
            // cmbPortsName
            // 
            this.cmbPortsName.FormattingEnabled = true;
            this.cmbPortsName.Location = new System.Drawing.Point(49, 19);
            this.cmbPortsName.Name = "cmbPortsName";
            this.cmbPortsName.Size = new System.Drawing.Size(121, 21);
            this.cmbPortsName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ports: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckPorts);
            this.groupBox1.Controls.Add(this.cmbPortsName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ports: ";
            // 
            // btnCheckPorts
            // 
            this.btnCheckPorts.Location = new System.Drawing.Point(9, 53);
            this.btnCheckPorts.Name = "btnCheckPorts";
            this.btnCheckPorts.Size = new System.Drawing.Size(161, 23);
            this.btnCheckPorts.TabIndex = 4;
            this.btnCheckPorts.Text = "Check";
            this.btnCheckPorts.UseVisualStyleBackColor = true;
            this.btnCheckPorts.Click += new System.EventHandler(this.BtnCheckPorts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.parityMark);
            this.groupBox2.Controls.Add(this.parityOdd);
            this.groupBox2.Controls.Add(this.parityEven);
            this.groupBox2.Controls.Add(this.parityNone);
            this.groupBox2.Location = new System.Drawing.Point(191, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parity: ";
            // 
            // parityNone
            // 
            this.parityNone.AutoSize = true;
            this.parityNone.Location = new System.Drawing.Point(11, 17);
            this.parityNone.Name = "parityNone";
            this.parityNone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parityNone.Size = new System.Drawing.Size(54, 17);
            this.parityNone.TabIndex = 6;
            this.parityNone.TabStop = true;
            this.parityNone.Text = ":None";
            this.parityNone.UseVisualStyleBackColor = true;
            // 
            // parityEven
            // 
            this.parityEven.AutoSize = true;
            this.parityEven.Location = new System.Drawing.Point(12, 40);
            this.parityEven.Name = "parityEven";
            this.parityEven.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parityEven.Size = new System.Drawing.Size(53, 17);
            this.parityEven.TabIndex = 9;
            this.parityEven.TabStop = true;
            this.parityEven.Text = ":Even";
            this.parityEven.UseVisualStyleBackColor = true;
            // 
            // parityOdd
            // 
            this.parityOdd.AutoSize = true;
            this.parityOdd.Location = new System.Drawing.Point(11, 63);
            this.parityOdd.Name = "parityOdd";
            this.parityOdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parityOdd.Size = new System.Drawing.Size(54, 17);
            this.parityOdd.TabIndex = 10;
            this.parityOdd.TabStop = true;
            this.parityOdd.Text = ":Odd  ";
            this.parityOdd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopBitTwo);
            this.groupBox3.Controls.Add(this.stopBitOne);
            this.groupBox3.Controls.Add(this.stopBitOnePointOne);
            this.groupBox3.Location = new System.Drawing.Point(199, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(75, 88);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop Bit: ";
            // 
            // stopBitOne
            // 
            this.stopBitOne.AutoSize = true;
            this.stopBitOne.Location = new System.Drawing.Point(23, 19);
            this.stopBitOne.Name = "stopBitOne";
            this.stopBitOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stopBitOne.Size = new System.Drawing.Size(34, 17);
            this.stopBitOne.TabIndex = 7;
            this.stopBitOne.TabStop = true;
            this.stopBitOne.Text = ":1";
            this.stopBitOne.UseVisualStyleBackColor = true;
            // 
            // stopBitOnePointOne
            // 
            this.stopBitOnePointOne.AutoSize = true;
            this.stopBitOnePointOne.Location = new System.Drawing.Point(14, 42);
            this.stopBitOnePointOne.Name = "stopBitOnePointOne";
            this.stopBitOnePointOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stopBitOnePointOne.Size = new System.Drawing.Size(43, 17);
            this.stopBitOnePointOne.TabIndex = 8;
            this.stopBitOnePointOne.TabStop = true;
            this.stopBitOnePointOne.Text = ":1.5";
            this.stopBitOnePointOne.UseVisualStyleBackColor = true;
            // 
            // stopBitTwo
            // 
            this.stopBitTwo.AutoSize = true;
            this.stopBitTwo.Location = new System.Drawing.Point(23, 65);
            this.stopBitTwo.Name = "stopBitTwo";
            this.stopBitTwo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stopBitTwo.Size = new System.Drawing.Size(34, 17);
            this.stopBitTwo.TabIndex = 9;
            this.stopBitTwo.TabStop = true;
            this.stopBitTwo.Text = ":2";
            this.stopBitTwo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataBit8);
            this.groupBox4.Controls.Add(this.dataBit7);
            this.groupBox4.Controls.Add(this.dataBit5);
            this.groupBox4.Controls.Add(this.dataBit6);
            this.groupBox4.Location = new System.Drawing.Point(15, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(65, 118);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Bit: ";
            // 
            // dataBit5
            // 
            this.dataBit5.AutoSize = true;
            this.dataBit5.Location = new System.Drawing.Point(9, 19);
            this.dataBit5.Name = "dataBit5";
            this.dataBit5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataBit5.Size = new System.Drawing.Size(34, 17);
            this.dataBit5.TabIndex = 8;
            this.dataBit5.TabStop = true;
            this.dataBit5.Text = ":5";
            this.dataBit5.UseVisualStyleBackColor = true;
            // 
            // dataBit6
            // 
            this.dataBit6.AutoSize = true;
            this.dataBit6.Location = new System.Drawing.Point(9, 42);
            this.dataBit6.Name = "dataBit6";
            this.dataBit6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataBit6.Size = new System.Drawing.Size(34, 17);
            this.dataBit6.TabIndex = 9;
            this.dataBit6.TabStop = true;
            this.dataBit6.Text = ":6";
            this.dataBit6.UseVisualStyleBackColor = true;
            // 
            // dataBit7
            // 
            this.dataBit7.AutoSize = true;
            this.dataBit7.Location = new System.Drawing.Point(9, 65);
            this.dataBit7.Name = "dataBit7";
            this.dataBit7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataBit7.Size = new System.Drawing.Size(34, 17);
            this.dataBit7.TabIndex = 10;
            this.dataBit7.TabStop = true;
            this.dataBit7.Text = ":7";
            this.dataBit7.UseVisualStyleBackColor = true;
            // 
            // dataBit8
            // 
            this.dataBit8.AutoSize = true;
            this.dataBit8.Location = new System.Drawing.Point(9, 88);
            this.dataBit8.Name = "dataBit8";
            this.dataBit8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataBit8.Size = new System.Drawing.Size(34, 17);
            this.dataBit8.TabIndex = 11;
            this.dataBit8.TabStop = true;
            this.dataBit8.Text = ":8";
            this.dataBit8.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.baudRate19200);
            this.groupBox5.Controls.Add(this.baudRate128000);
            this.groupBox5.Controls.Add(this.baudRate9600);
            this.groupBox5.Controls.Add(this.baudRate115200);
            this.groupBox5.Location = new System.Drawing.Point(92, 106);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(93, 118);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Baud Rate: ";
            // 
            // baudRate9600
            // 
            this.baudRate9600.AutoSize = true;
            this.baudRate9600.Location = new System.Drawing.Point(20, 19);
            this.baudRate9600.Name = "baudRate9600";
            this.baudRate9600.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.baudRate9600.Size = new System.Drawing.Size(52, 17);
            this.baudRate9600.TabIndex = 9;
            this.baudRate9600.TabStop = true;
            this.baudRate9600.Text = ":9600";
            this.baudRate9600.UseVisualStyleBackColor = true;
            // 
            // baudRate115200
            // 
            this.baudRate115200.AutoSize = true;
            this.baudRate115200.Location = new System.Drawing.Point(8, 65);
            this.baudRate115200.Name = "baudRate115200";
            this.baudRate115200.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.baudRate115200.Size = new System.Drawing.Size(64, 17);
            this.baudRate115200.TabIndex = 10;
            this.baudRate115200.TabStop = true;
            this.baudRate115200.Text = ":115200";
            this.baudRate115200.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStatus.Location = new System.Drawing.Point(58, 333);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Waiting to set the port...";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 236);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(262, 42);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // baudRate19200
            // 
            this.baudRate19200.AutoSize = true;
            this.baudRate19200.Location = new System.Drawing.Point(14, 42);
            this.baudRate19200.Name = "baudRate19200";
            this.baudRate19200.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.baudRate19200.Size = new System.Drawing.Size(58, 17);
            this.baudRate19200.TabIndex = 13;
            this.baudRate19200.TabStop = true;
            this.baudRate19200.Text = ":19200";
            this.baudRate19200.UseVisualStyleBackColor = true;
            // 
            // baudRate128000
            // 
            this.baudRate128000.AutoSize = true;
            this.baudRate128000.Location = new System.Drawing.Point(8, 88);
            this.baudRate128000.Name = "baudRate128000";
            this.baudRate128000.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.baudRate128000.Size = new System.Drawing.Size(64, 17);
            this.baudRate128000.TabIndex = 14;
            this.baudRate128000.TabStop = true;
            this.baudRate128000.Text = ":128000";
            this.baudRate128000.UseVisualStyleBackColor = true;
            // 
            // parityMark
            // 
            this.parityMark.AutoSize = true;
            this.parityMark.Location = new System.Drawing.Point(13, 86);
            this.parityMark.Name = "parityMark";
            this.parityMark.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parityMark.Size = new System.Drawing.Size(52, 17);
            this.parityMark.TabIndex = 11;
            this.parityMark.TabStop = true;
            this.parityMark.Text = ":Mark";
            this.parityMark.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 358);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM Minimize";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPortsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckPorts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton parityEven;
        private System.Windows.Forms.RadioButton parityNone;
        private System.Windows.Forms.RadioButton parityOdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton stopBitTwo;
        private System.Windows.Forms.RadioButton stopBitOne;
        private System.Windows.Forms.RadioButton stopBitOnePointOne;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton dataBit8;
        private System.Windows.Forms.RadioButton dataBit7;
        private System.Windows.Forms.RadioButton dataBit5;
        private System.Windows.Forms.RadioButton dataBit6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton baudRate9600;
        private System.Windows.Forms.RadioButton baudRate115200;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton parityMark;
        private System.Windows.Forms.RadioButton baudRate19200;
        private System.Windows.Forms.RadioButton baudRate128000;
    }
}

