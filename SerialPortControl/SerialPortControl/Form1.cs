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

        public Form_SerialPortControl()
        {
            InitializeComponent();                                       // 串口构造
        }

        private void button_OpenSerialPort_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)                                       // 后台：如果串口出于打开状态
            {
                try { serialPort.Close(); }                              // 后台：就关闭串口
                catch { MessageBox.Show("串口操作失败", "错误"); }         // 前台：错误提示

                button_OpenSerialPort.Text = "打开串口";                  // 前台：改变按钮内容
                //button_OpenSerialPort.BackColor = Color.Gold;            // 前台：改变按钮颜色
                ovalShape_SP_Statement.FillColor = Color.Yellow;
            }
            else                                                         // 后台：如果串口出于关闭状态
            {
                try
                {
                    serialPort.PortName = comboBox_AvailableCOM.Text;    // 后台：将下拉框选中的串口名赋值给串口对象
                    serialPort.Open();                                   // 后台：打开串口

                    button_OpenSerialPort.Text = "关闭串口";              // 前台：改变按钮内容
                    //button_OpenSerialPort.BackColor = Color.Lime;        // 前台：改变串口颜色
                    ovalShape_SP_Statement.FillColor = Color.Green;

                }
                catch
                {
                    MessageBox.Show("串口操作失败", "错误");              // 前台：错误提示
                }
            }
        }

        private void Form_SerialPortControl_Load(object sender, EventArgs e)
        {
            ScanSerialPort(serialPort, comboBox_AvailableCOM);          // 扫描可用端口号，添加到下拉框
            ovalShape_SP_Statement.FillColor = Color.Yellow;            // 指示灯黄色
        }

        private void button_Scan_Click(object sender, EventArgs e)
        {
            if (button_OpenSerialPort.Text == "关闭串口")                // 检查按钮是否处于打开状态
            {
                System.Media.SystemSounds.Beep.Play();                  // 
                MessageBox.Show("请先关闭串口", "提示");
            }
            else
                ScanSerialPort(serialPort, comboBox_AvailableCOM);      // 扫描可用端口号添加到下拉框
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
    }
}
