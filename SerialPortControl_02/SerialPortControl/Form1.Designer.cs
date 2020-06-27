using System;
using System.Drawing;

namespace SerialPortControl
{
    partial class Form_SerialPortControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_SerialPort = new System.Windows.Forms.GroupBox();
            this.button_SPSwitch = new System.Windows.Forms.Button();
            this.label_SPSwitch = new System.Windows.Forms.Label();
            this.button_Scan = new System.Windows.Forms.Button();
            this.comboBox_AvailableCOM = new System.Windows.Forms.ComboBox();
            this.groupBox_NO1COM = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_CloseTimer = new System.Windows.Forms.Label();
            this.button_NO1COMClose = new System.Windows.Forms.Button();
            this.button_NO1COMOpen = new System.Windows.Forms.Button();
            this.groupBox_NO2COM = new System.Windows.Forms.GroupBox();
            this.button_NO2COMClose = new System.Windows.Forms.Button();
            this.button_NO2COMOpen = new System.Windows.Forms.Button();
            this.groupBox_NO3COM = new System.Windows.Forms.GroupBox();
            this.button_NO3COMClose = new System.Windows.Forms.Button();
            this.button_NO3COMOpen = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_SerialPort.SuspendLayout();
            this.groupBox_NO1COM.SuspendLayout();
            this.groupBox_NO2COM.SuspendLayout();
            this.groupBox_NO3COM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SerialPort
            // 
            this.groupBox_SerialPort.Controls.Add(this.button_SPSwitch);
            this.groupBox_SerialPort.Controls.Add(this.label_SPSwitch);
            this.groupBox_SerialPort.Controls.Add(this.button_Scan);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_AvailableCOM);
            this.groupBox_SerialPort.Location = new System.Drawing.Point(12, 12);
            this.groupBox_SerialPort.Name = "groupBox_SerialPort";
            this.groupBox_SerialPort.Size = new System.Drawing.Size(316, 55);
            this.groupBox_SerialPort.TabIndex = 0;
            this.groupBox_SerialPort.TabStop = false;
            this.groupBox_SerialPort.Text = "串口";
            // 
            // button_SPSwitch
            // 
            this.button_SPSwitch.BackColor = System.Drawing.Color.Transparent;
            this.button_SPSwitch.BackgroundImage = global::SerialPortControl.Properties.Resources.按钮_灰;
            this.button_SPSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SPSwitch.FlatAppearance.BorderSize = 0;
            this.button_SPSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_SPSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_SPSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SPSwitch.Location = new System.Drawing.Point(236, 12);
            this.button_SPSwitch.Name = "button_SPSwitch";
            this.button_SPSwitch.Size = new System.Drawing.Size(34, 34);
            this.button_SPSwitch.TabIndex = 7;
            this.button_SPSwitch.UseVisualStyleBackColor = false;
            this.button_SPSwitch.Click += new System.EventHandler(this.button_SPSwitch_Click);
            this.button_SPSwitch.MouseLeave += new System.EventHandler(this.button_SPSwitch_MouseLeave);
            this.button_SPSwitch.MouseHover += new System.EventHandler(this.button_SPSwitch_MouseHover);
            // 
            // label_SPSwitch
            // 
            this.label_SPSwitch.AutoSize = true;
            this.label_SPSwitch.Location = new System.Drawing.Point(177, 24);
            this.label_SPSwitch.Name = "label_SPSwitch";
            this.label_SPSwitch.Size = new System.Drawing.Size(53, 12);
            this.label_SPSwitch.TabIndex = 4;
            this.label_SPSwitch.Text = "串口开关";
            // 
            // button_Scan
            // 
            this.button_Scan.Location = new System.Drawing.Point(96, 20);
            this.button_Scan.Name = "button_Scan";
            this.button_Scan.Size = new System.Drawing.Size(51, 20);
            this.button_Scan.TabIndex = 1;
            this.button_Scan.Text = "扫描";
            this.button_Scan.UseVisualStyleBackColor = true;
            this.button_Scan.Click += new System.EventHandler(this.button_Scan_Click);
            // 
            // comboBox_AvailableCOM
            // 
            this.comboBox_AvailableCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AvailableCOM.FormattingEnabled = true;
            this.comboBox_AvailableCOM.Location = new System.Drawing.Point(6, 20);
            this.comboBox_AvailableCOM.Name = "comboBox_AvailableCOM";
            this.comboBox_AvailableCOM.Size = new System.Drawing.Size(84, 20);
            this.comboBox_AvailableCOM.TabIndex = 0;
            // 
            // groupBox_NO1COM
            // 
            this.groupBox_NO1COM.Controls.Add(this.textBox1);
            this.groupBox_NO1COM.Controls.Add(this.label_CloseTimer);
            this.groupBox_NO1COM.Controls.Add(this.button_NO1COMClose);
            this.groupBox_NO1COM.Controls.Add(this.button_NO1COMOpen);
            this.groupBox_NO1COM.Location = new System.Drawing.Point(12, 73);
            this.groupBox_NO1COM.Name = "groupBox_NO1COM";
            this.groupBox_NO1COM.Size = new System.Drawing.Size(316, 95);
            this.groupBox_NO1COM.TabIndex = 1;
            this.groupBox_NO1COM.TabStop = false;
            this.groupBox_NO1COM.Text = "No.1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 21);
            this.textBox1.TabIndex = 6;
            // 
            // label_CloseTimer
            // 
            this.label_CloseTimer.AutoSize = true;
            this.label_CloseTimer.Location = new System.Drawing.Point(15, 31);
            this.label_CloseTimer.Name = "label_CloseTimer";
            this.label_CloseTimer.Size = new System.Drawing.Size(59, 12);
            this.label_CloseTimer.TabIndex = 5;
            this.label_CloseTimer.Text = "关定时(s)";
            // 
            // button_NO1COMClose
            // 
            this.button_NO1COMClose.Location = new System.Drawing.Point(169, 55);
            this.button_NO1COMClose.Name = "button_NO1COMClose";
            this.button_NO1COMClose.Size = new System.Drawing.Size(141, 20);
            this.button_NO1COMClose.TabIndex = 2;
            this.button_NO1COMClose.Text = "关";
            this.button_NO1COMClose.UseVisualStyleBackColor = true;
            this.button_NO1COMClose.Click += new System.EventHandler(this.button_NO1COMClose_Click);
            // 
            // button_NO1COMOpen
            // 
            this.button_NO1COMOpen.Location = new System.Drawing.Point(6, 55);
            this.button_NO1COMOpen.Name = "button_NO1COMOpen";
            this.button_NO1COMOpen.Size = new System.Drawing.Size(141, 20);
            this.button_NO1COMOpen.TabIndex = 1;
            this.button_NO1COMOpen.Text = "开";
            this.button_NO1COMOpen.UseVisualStyleBackColor = true;
            this.button_NO1COMOpen.Click += new System.EventHandler(this.button_NO1COMOpen_Click);
            // 
            // groupBox_NO2COM
            // 
            this.groupBox_NO2COM.Controls.Add(this.button_NO2COMClose);
            this.groupBox_NO2COM.Controls.Add(this.button_NO2COMOpen);
            this.groupBox_NO2COM.Location = new System.Drawing.Point(12, 174);
            this.groupBox_NO2COM.Name = "groupBox_NO2COM";
            this.groupBox_NO2COM.Size = new System.Drawing.Size(316, 55);
            this.groupBox_NO2COM.TabIndex = 2;
            this.groupBox_NO2COM.TabStop = false;
            this.groupBox_NO2COM.Text = "NO.2";
            // 
            // button_NO2COMClose
            // 
            this.button_NO2COMClose.Location = new System.Drawing.Point(169, 20);
            this.button_NO2COMClose.Name = "button_NO2COMClose";
            this.button_NO2COMClose.Size = new System.Drawing.Size(141, 20);
            this.button_NO2COMClose.TabIndex = 2;
            this.button_NO2COMClose.Text = "关";
            this.button_NO2COMClose.UseVisualStyleBackColor = true;
            this.button_NO2COMClose.Click += new System.EventHandler(this.button_NO2COMClose_Click);
            // 
            // button_NO2COMOpen
            // 
            this.button_NO2COMOpen.Location = new System.Drawing.Point(6, 20);
            this.button_NO2COMOpen.Name = "button_NO2COMOpen";
            this.button_NO2COMOpen.Size = new System.Drawing.Size(141, 20);
            this.button_NO2COMOpen.TabIndex = 1;
            this.button_NO2COMOpen.Text = "开";
            this.button_NO2COMOpen.UseVisualStyleBackColor = true;
            this.button_NO2COMOpen.Click += new System.EventHandler(this.button_NO2COMOpen_Click);
            // 
            // groupBox_NO3COM
            // 
            this.groupBox_NO3COM.Controls.Add(this.button_NO3COMClose);
            this.groupBox_NO3COM.Controls.Add(this.button_NO3COMOpen);
            this.groupBox_NO3COM.Location = new System.Drawing.Point(12, 235);
            this.groupBox_NO3COM.Name = "groupBox_NO3COM";
            this.groupBox_NO3COM.Size = new System.Drawing.Size(316, 55);
            this.groupBox_NO3COM.TabIndex = 3;
            this.groupBox_NO3COM.TabStop = false;
            this.groupBox_NO3COM.Text = "NO.3";
            // 
            // button_NO3COMClose
            // 
            this.button_NO3COMClose.Location = new System.Drawing.Point(169, 20);
            this.button_NO3COMClose.Name = "button_NO3COMClose";
            this.button_NO3COMClose.Size = new System.Drawing.Size(141, 20);
            this.button_NO3COMClose.TabIndex = 2;
            this.button_NO3COMClose.Text = "关";
            this.button_NO3COMClose.UseVisualStyleBackColor = true;
            this.button_NO3COMClose.Click += new System.EventHandler(this.button_NO3COMClose_Click);
            // 
            // button_NO3COMOpen
            // 
            this.button_NO3COMOpen.Location = new System.Drawing.Point(6, 20);
            this.button_NO3COMOpen.Name = "button_NO3COMOpen";
            this.button_NO3COMOpen.Size = new System.Drawing.Size(141, 20);
            this.button_NO3COMOpen.TabIndex = 1;
            this.button_NO3COMOpen.Text = "开";
            this.button_NO3COMOpen.UseVisualStyleBackColor = true;
            this.button_NO3COMOpen.Click += new System.EventHandler(this.button_NO3COMOpen_Click);
            // 
            // Form_SerialPortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 297);
            this.Controls.Add(this.groupBox_NO3COM);
            this.Controls.Add(this.groupBox_NO2COM);
            this.Controls.Add(this.groupBox_NO1COM);
            this.Controls.Add(this.groupBox_SerialPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SerialPortControl";
            this.Text = "串口控制";
            this.Load += new System.EventHandler(this.Form_SerialPortControl_Load);
            this.groupBox_SerialPort.ResumeLayout(false);
            this.groupBox_SerialPort.PerformLayout();
            this.groupBox_NO1COM.ResumeLayout(false);
            this.groupBox_NO1COM.PerformLayout();
            this.groupBox_NO2COM.ResumeLayout(false);
            this.groupBox_NO3COM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SerialPort;
        private System.Windows.Forms.Button button_Scan;
        private System.Windows.Forms.ComboBox comboBox_AvailableCOM;
        private System.Windows.Forms.GroupBox groupBox_NO1COM;
        private System.Windows.Forms.Button button_NO1COMClose;
        private System.Windows.Forms.Button button_NO1COMOpen;
        private System.Windows.Forms.GroupBox groupBox_NO2COM;
        private System.Windows.Forms.Button button_NO2COMClose;
        private System.Windows.Forms.Button button_NO2COMOpen;
        private System.Windows.Forms.GroupBox groupBox_NO3COM;
        private System.Windows.Forms.Button button_NO3COMClose;
        private System.Windows.Forms.Button button_NO3COMOpen;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label_SPSwitch;
        private System.Windows.Forms.Label label_CloseTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_SPSwitch;
    }
}

