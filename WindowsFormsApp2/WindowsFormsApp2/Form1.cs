using System;
using System.Windows.Forms;

namespace serialPortTest
{
    public partial class Form_SerialPortTest : Form
    {
        public Form_SerialPortTest()
        {
            InitializeComponent();
        }

        private void Form_SerialPortTest_Load(object sender, EventArgs e)
        {
            String str; // 用来临时存储大写的十六进制格式字符串
            for (int i = 0; i < 256; i++)
            {
                str = i.ToString("x").ToUpper(); // 转换成十六进制和大写
                if (str.Length == 1) str = "0" + str; // format: 1->01
                comboBox_Data.Items.Add("0X" + str); // format: 01->0X01
            }

        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            // 下拉框内容转换成文本、取后两位，再转换成16位的byte型变量
            buffer[0] = Convert.ToByte(comboBox_Data.Text.Substring(2, 2), 16);
            //MessageBox.Show("当前使用的是" + serialPort1.PortName + "串口");
            try // 防止出错
            {
                serialPort1.Open();
                // public void Write(byte[] buffer, int offset, int count);
                serialPort1.Write(buffer, 0, 1);

                serialPort1.Close();
            }
            catch (Exception err) // 如果出错就执行
            {
                if (serialPort1.IsOpen) serialPort1.Close(); // 如果是写数据时出错，此时窗口状态为开，就应关闭串口，防止下次不能使用，
                MessageBox.Show(err.ToString(), "错误");
            }
        }
    }
}
