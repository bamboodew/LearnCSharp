using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortControl
{
    public partial class Form_SerialPortControl : Form
    {
        const byte NO1COMOpen = 0X01;                                   // 定义数据
        const byte NO1COMClose = 0X81;                                  // 定义数据

        const byte NO2COMOpen = 0X02;                                   // 定义数据
        const byte NO2COMClose = 0X82;                                  // 定义数据

        const byte NO3COMOpen = 0X03;                                   // 定义数据
        const byte NO3COMClose = 0X83;                                  // 定义数据


        byte[] SerialPortDataBuffer = new byte[1];                       // 串口写入缓存：serialport Write Buffer
        private bool button_SPSwitchState;

        public Form_SerialPortControl()
        {
            InitializeComponent();                                       // 串口构造
        }

        private void Form_SerialPortControl_Load(object sender, EventArgs e)
        {
            ScanSerialPort(serialPort, comboBox_AvailableCOM);          // 扫描可用端口号，添加到下拉框
        }

        private void button_Scan_Click(object sender, EventArgs e)
        {
            ScanSerialPort(serialPort, comboBox_AvailableCOM);          // 扫描可用端口号添加到下拉框
        }

        private void button_NO1COMOpen_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(NO1COMOpen);                          // 写入数据
        }

        private void button_NO1COMClose_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(NO1COMClose);                         // 写入数据
        }

        private void button_NO2COMOpen_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(NO2COMOpen);                          // 写入数据
        }

        private void button_NO2COMClose_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(NO2COMClose);                         // 写入数据
        }

        private void button_NO3COMOpen_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(NO3COMOpen);                          // 写入数据
        }

        private void button_NO3COMClose_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(NO3COMClose);                         // 写入数据
        }

        private void ScanSerialPort(SerialPort serialPort, ComboBox comboBox)
        {                                                               // 将可用端口号添加到下拉框
            string[] COMNames = new string[20];                         // 临时过渡用的中间数组，最多容纳20个
            string Buffer;                                              // 临时缓存
            comboBox.Items.Clear();                                     // 清空下拉框
            int count = 0;                                              // 定义一个计数器初始值为0

            for (int i = 1; i < 21; i++)                                // 循环逐个添加
            {
                try
                {
                    Buffer = "COM" + i.ToString();                      // 字符串拼接
                    serialPort.PortName = Buffer;                       // 赋值给串口的端口名

                    serialPort.Open();                                  // 若不可用，就停止执行下一句、执行catch

                    COMNames[count] = Buffer;                           // 赋值给串口名数组
                    comboBox.Items.Add(Buffer);                         // 添加给下拉框
                    serialPort.Close();                                 // 关闭串口
                    count++;
                }
                catch { };                                              // catch语句为空，继续执行下一个for村换
            }
            comboBox.Text = COMNames[0];                                // 下拉框初始化
        }

        private void WriteByteToSerialPort(byte data)                   // 单字节写入串口
        {
            byte[] Buffer = new byte[2] { 0X00, data };                 // 字节数组：头码+数据
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(Buffer, 0, 2);                     // 将字节数组写入串口

                }
                catch
                {
                    MessageBox.Show("串口数据发送错误", "错误");          // 提示发送错误
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "提示");                   // 提示串口未打开
            }
        }

        private void button_SPSwitch_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch
                {
                    button_SPSwitch.BackgroundImage = Properties.Resources.按钮_灰;    // light close
                    button_SPSwitchState = false;
                }
            }
            else
            {
                try
                {
                    serialPort.PortName = comboBox_AvailableCOM.Text;
                    serialPort.Open();
                    button_SPSwitch.BackgroundImage = Properties.Resources.按钮_深绿;
                    button_SPSwitchState = true;
                }
                catch
                {
                    MessageBox.Show("串口打开失败", "错误");
                }
            }
        }

        private void button_SPSwitch_MouseHover(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            button_SPSwitch.BackgroundImage = Properties.Resources.按钮_浅绿;
            this.button_SPSwitch.BackColor = Color.Transparent; // 去背景
        }

        private void button_SPSwitch_MouseLeave(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (button_SPSwitchState == true)
            {
                button_SPSwitch.BackgroundImage = Properties.Resources.按钮_深绿;
                this.button_SPSwitch.BackColor = Color.Transparent; // 去背景
            }
            else
            {
                button_SPSwitch.BackgroundImage = Properties.Resources.按钮_灰;
                this.button_SPSwitch.BackColor = Color.Transparent; // 去背景
            }
        }
    }
}
