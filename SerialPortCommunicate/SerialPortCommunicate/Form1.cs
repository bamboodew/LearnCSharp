using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortCommunicate
{
    public partial class Form_SerialPortCom : Form
    {
        public Form_SerialPortCom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                comboBox_Ports.Items.Add("COM" + i.ToString());
            }
            comboBox_Ports.Text = "COM1"; // 串口号默认值

            for (int i = 0; i < 7; i++)
            {
                comboBox_BaudRate.Items.Add((Math.Pow(2, i)) * 1200);
            }
            comboBox_BaudRate.Text = "1200"; // 波特率默认值

            // 引用：端口数据接收的方法
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);


            button_Send.Enabled = false;
        }

        /* 
         * 串口数据———接收事件
         */
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (radioButton_ReceiveChar.Checked) // 接收字符模式
            {
                string str = serialPort1.ReadExisting(); // 字符串方式读取
                textBox_Receive.AppendText(str); // 接收内容
            }
            else // 接收数值模式
            {
                byte data = (byte)serialPort1.ReadByte(); // 接收byte型数据
                string str = Convert.ToString(data, 16).ToUpper(); // 转换成16进制大写
                textBox_Receive.AppendText("0X" + (str.Length == 1 ? "0" + str : str) + " ");
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Receive.Text = "";
        }

        private void button_OpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_Ports.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text, 10);

                serialPort1.Open();
                button_OpenPort.Enabled = false; // 不能再次打开
                button_ClosePort.Enabled = true; // 可以关闭
            }
            catch
            {
                MessageBox.Show("端口错误，请修改。", "错误");
            }
        }

        private void button_ClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                button_OpenPort.Enabled = true; // 可以打开
                button_ClosePort.Enabled = false; // 不能关闭
            }
            catch
            {
            }
        }

        /* 
         * 串口数据———发送事件
         */
        private void button_Send_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1]; // 新建一个单个元素的字节数组
            if (serialPort1.IsOpen)
            {
                if (textBox_Send.Text != "") // 发送区不为空
                {
                    if (radioButton_SendChar.Checked) // 发送字符
                    {
                        try
                        {
                            serialPort1.WriteLine(textBox_Send.Text); // 将发送区的字符写入串口
                        }
                        catch
                        {
                            MessageBox.Show("串口字符写入错误", "错误提示");

                            serialPort1.Close(); // 关闭串口
                            button_OpenPort.Enabled = true; // 可以打开
                            button_ClosePort.Enabled = false; // 不能关闭
                        }
                    }
                    else // 发送数值
                    {
                        try
                        {
                            for (int i = 0; i < (textBox_Send.Text.Length - textBox_Send.Text.Length % 2) / 2; i++) // 处理前最多的偶数个字节
                            {
                                // 逐两个字符转换为16进制数字，并赋值给单元素字节数组
                                Data[0] = Convert.ToByte(textBox_Send.Text.Substring(i * 2, 2), 16);
                                // 将数组写入串口，从第0位元素开始，共写1位元素
                                serialPort1.Write(Data, 0, 1);
                            }
                            if (textBox_Send.Text.Length % 2 != 0) // 如果为奇数个字节，处理最后一个
                            {
                                // 将最后1位转换为16进制数字，并赋值给单元素字节数组
                                Data[0] = Convert.ToByte(textBox_Send.Text.Substring(textBox_Send.Text.Length - 1, 1), 16);
                                // 将数组写入串口，从第0位开始，共写1位
                                serialPort1.Write(Data, 0, 1);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("串口数字写入错误", "错误提示");

                            serialPort1.Close(); // 关闭串口
                            button_OpenPort.Enabled = true; // 可以打开
                            button_ClosePort.Enabled = false; // 不能关闭
                        }

                    }
                }
            }

        }

        

        private void textBox_Send_TextChanged(object sender, EventArgs e)
        {
            this.button_Send.Enabled = !string.IsNullOrWhiteSpace(this.textBox_Send.Text);
        }

        private void textBox_Receive_TextChanged(object sender, EventArgs e)
        {
            textBox_Receive.ScrollToCaret();
        }
    }
}
