namespace serialPortTest
{
    partial class Form_SerialPortTest
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
            this.Button_Send = new System.Windows.Forms.Button();
            this.label_Data = new System.Windows.Forms.Label();
            this.comboBox_Data = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // Button_Send
            // 
            this.Button_Send.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Send.Location = new System.Drawing.Point(52, 85);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(161, 23);
            this.Button_Send.TabIndex = 0;
            this.Button_Send.Text = "发送";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Data.Location = new System.Drawing.Point(49, 37);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(35, 14);
            this.label_Data.TabIndex = 1;
            this.label_Data.Text = "数据";
            // 
            // comboBox_Data
            // 
            this.comboBox_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Data.FormattingEnabled = true;
            this.comboBox_Data.Location = new System.Drawing.Point(117, 34);
            this.comboBox_Data.Name = "comboBox_Data";
            this.comboBox_Data.Size = new System.Drawing.Size(96, 20);
            this.comboBox_Data.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 4800;
            this.serialPort1.PortName = "COM4";
            // 
            // Form_SerialPortTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 139);
            this.Controls.Add(this.comboBox_Data);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.Button_Send);
            this.MaximizeBox = false;
            this.Name = "Form_SerialPortTest";
            this.Text = "串口测试";
            this.Load += new System.EventHandler(this.Form_SerialPortTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.ComboBox comboBox_Data;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

