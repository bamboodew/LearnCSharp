namespace SerialPortCommunicate
{
    partial class Form_SerialPortCom
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
            this.groupBox_Set = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_ReceiveChar = new System.Windows.Forms.RadioButton();
            this.radioButton_ReceiveNum = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_SendChar = new System.Windows.Forms.RadioButton();
            this.radioButton_SendNum = new System.Windows.Forms.RadioButton();
            this.button_ClosePort = new System.Windows.Forms.Button();
            this.button_OpenPort = new System.Windows.Forms.Button();
            this.label_ReceiveMode = new System.Windows.Forms.Label();
            this.label_SendMode = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.textBox_Receive = new System.Windows.Forms.TextBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_Set.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Set
            // 
            this.groupBox_Set.Controls.Add(this.panel2);
            this.groupBox_Set.Controls.Add(this.panel1);
            this.groupBox_Set.Controls.Add(this.button_ClosePort);
            this.groupBox_Set.Controls.Add(this.button_OpenPort);
            this.groupBox_Set.Controls.Add(this.label_ReceiveMode);
            this.groupBox_Set.Controls.Add(this.label_SendMode);
            this.groupBox_Set.Controls.Add(this.comboBox_BaudRate);
            this.groupBox_Set.Controls.Add(this.label_BaudRate);
            this.groupBox_Set.Controls.Add(this.comboBox_Ports);
            this.groupBox_Set.Controls.Add(this.label_Port);
            this.groupBox_Set.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Set.Location = new System.Drawing.Point(24, 21);
            this.groupBox_Set.Name = "groupBox_Set";
            this.groupBox_Set.Size = new System.Drawing.Size(252, 255);
            this.groupBox_Set.TabIndex = 0;
            this.groupBox_Set.TabStop = false;
            this.groupBox_Set.Text = "设置";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_ReceiveChar);
            this.panel2.Controls.Add(this.radioButton_ReceiveNum);
            this.panel2.Location = new System.Drawing.Point(97, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 47);
            this.panel2.TabIndex = 9;
            // 
            // radioButton_ReceiveChar
            // 
            this.radioButton_ReceiveChar.AutoSize = true;
            this.radioButton_ReceiveChar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ReceiveChar.Location = new System.Drawing.Point(67, 14);
            this.radioButton_ReceiveChar.Name = "radioButton_ReceiveChar";
            this.radioButton_ReceiveChar.Size = new System.Drawing.Size(60, 25);
            this.radioButton_ReceiveChar.TabIndex = 2;
            this.radioButton_ReceiveChar.Text = "字符";
            this.radioButton_ReceiveChar.UseVisualStyleBackColor = true;
            // 
            // radioButton_ReceiveNum
            // 
            this.radioButton_ReceiveNum.AutoSize = true;
            this.radioButton_ReceiveNum.Checked = true;
            this.radioButton_ReceiveNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ReceiveNum.Location = new System.Drawing.Point(3, 14);
            this.radioButton_ReceiveNum.Name = "radioButton_ReceiveNum";
            this.radioButton_ReceiveNum.Size = new System.Drawing.Size(60, 25);
            this.radioButton_ReceiveNum.TabIndex = 1;
            this.radioButton_ReceiveNum.TabStop = true;
            this.radioButton_ReceiveNum.Text = "数值";
            this.radioButton_ReceiveNum.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_SendChar);
            this.panel1.Controls.Add(this.radioButton_SendNum);
            this.panel1.Location = new System.Drawing.Point(97, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 47);
            this.panel1.TabIndex = 8;
            // 
            // radioButton_SendChar
            // 
            this.radioButton_SendChar.AutoSize = true;
            this.radioButton_SendChar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_SendChar.Location = new System.Drawing.Point(67, 14);
            this.radioButton_SendChar.Name = "radioButton_SendChar";
            this.radioButton_SendChar.Size = new System.Drawing.Size(60, 25);
            this.radioButton_SendChar.TabIndex = 2;
            this.radioButton_SendChar.Text = "字符";
            this.radioButton_SendChar.UseVisualStyleBackColor = true;
            // 
            // radioButton_SendNum
            // 
            this.radioButton_SendNum.AutoSize = true;
            this.radioButton_SendNum.Checked = true;
            this.radioButton_SendNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_SendNum.Location = new System.Drawing.Point(3, 14);
            this.radioButton_SendNum.Name = "radioButton_SendNum";
            this.radioButton_SendNum.Size = new System.Drawing.Size(60, 25);
            this.radioButton_SendNum.TabIndex = 1;
            this.radioButton_SendNum.TabStop = true;
            this.radioButton_SendNum.Text = "数值";
            this.radioButton_SendNum.UseVisualStyleBackColor = true;
            // 
            // button_ClosePort
            // 
            this.button_ClosePort.Enabled = false;
            this.button_ClosePort.Location = new System.Drawing.Point(143, 204);
            this.button_ClosePort.Name = "button_ClosePort";
            this.button_ClosePort.Size = new System.Drawing.Size(84, 31);
            this.button_ClosePort.TabIndex = 7;
            this.button_ClosePort.Text = "关闭端口";
            this.button_ClosePort.UseVisualStyleBackColor = true;
            this.button_ClosePort.Click += new System.EventHandler(this.button_ClosePort_Click);
            // 
            // button_OpenPort
            // 
            this.button_OpenPort.Location = new System.Drawing.Point(19, 204);
            this.button_OpenPort.Name = "button_OpenPort";
            this.button_OpenPort.Size = new System.Drawing.Size(84, 31);
            this.button_OpenPort.TabIndex = 6;
            this.button_OpenPort.Text = "打开端口";
            this.button_OpenPort.UseVisualStyleBackColor = true;
            this.button_OpenPort.Click += new System.EventHandler(this.button_OpenPort_Click);
            // 
            // label_ReceiveMode
            // 
            this.label_ReceiveMode.AutoSize = true;
            this.label_ReceiveMode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ReceiveMode.Location = new System.Drawing.Point(16, 160);
            this.label_ReceiveMode.Name = "label_ReceiveMode";
            this.label_ReceiveMode.Size = new System.Drawing.Size(74, 21);
            this.label_ReceiveMode.TabIndex = 5;
            this.label_ReceiveMode.Text = "接收模式";
            // 
            // label_SendMode
            // 
            this.label_SendMode.AutoSize = true;
            this.label_SendMode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SendMode.Location = new System.Drawing.Point(16, 114);
            this.label_SendMode.Name = "label_SendMode";
            this.label_SendMode.Size = new System.Drawing.Size(74, 21);
            this.label_SendMode.TabIndex = 4;
            this.label_SendMode.Text = "发送模式";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BaudRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(97, 67);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_BaudRate.TabIndex = 3;
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_BaudRate.Location = new System.Drawing.Point(16, 70);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(58, 21);
            this.label_BaudRate.TabIndex = 2;
            this.label_BaudRate.Text = "波特率";
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ports.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(97, 24);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Ports.TabIndex = 1;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Port.Location = new System.Drawing.Point(18, 29);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(42, 21);
            this.label_Port.TabIndex = 0;
            this.label_Port.Text = "端口";
            // 
            // textBox_Receive
            // 
            this.textBox_Receive.Enabled = false;
            this.textBox_Receive.Location = new System.Drawing.Point(295, 30);
            this.textBox_Receive.Multiline = true;
            this.textBox_Receive.Name = "textBox_Receive";
            this.textBox_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Receive.Size = new System.Drawing.Size(297, 246);
            this.textBox_Receive.TabIndex = 1;
            this.textBox_Receive.TextChanged += new System.EventHandler(this.textBox_Receive_TextChanged);
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(124, 292);
            this.textBox_Send.Multiline = true;
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Send.Size = new System.Drawing.Size(365, 57);
            this.textBox_Send.TabIndex = 2;
            this.textBox_Send.TextChanged += new System.EventHandler(this.textBox_Send_TextChanged);
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Send.Location = new System.Drawing.Point(24, 292);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(87, 57);
            this.button_Send.TabIndex = 8;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Clear.Location = new System.Drawing.Point(505, 292);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(87, 57);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "清零";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_SerialPortCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 373);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Send);
            this.Controls.Add(this.textBox_Receive);
            this.Controls.Add(this.groupBox_Set);
            this.MaximizeBox = false;
            this.Name = "Form_SerialPortCom";
            this.Text = "串口通信";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Set.ResumeLayout(false);
            this.groupBox_Set.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Set;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_ReceiveChar;
        private System.Windows.Forms.RadioButton radioButton_ReceiveNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_SendChar;
        private System.Windows.Forms.RadioButton radioButton_SendNum;
        private System.Windows.Forms.Button button_ClosePort;
        private System.Windows.Forms.Button button_OpenPort;
        private System.Windows.Forms.Label label_ReceiveMode;
        private System.Windows.Forms.Label label_SendMode;
        private System.Windows.Forms.TextBox textBox_Receive;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button_Send;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_Clear;
    }
}

