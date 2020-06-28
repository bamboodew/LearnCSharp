using System.Drawing;
using System.Windows.Forms;

/*
 * 红绿灯系统：
 * 停——红灯10秒
 * 行——绿灯7秒，黄灯3秒
 * 
 * 按键1：开始、暂停、恢复
 * 按键2：停止
 */

namespace TrafficLights
{
    public partial class Form_TrafficLights : Form
    {
        private int count = 0;                                  // 计数器
        private int time = 20;                                  // 定义初始时间10秒

        public Form_TrafficLights()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            count++;                                            // 计数器自加一
            if (time - count == 0)
            {
                count = 0;                                      // 计数器清零复位
                label1.BackColor = Color.LimeGreen;             // 颜色复位
                label2.BackColor = Color.LimeGreen;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label1.Text = (time - 10 - count).ToString();   // 绿灯10~4、黄灯3~1
                label2.Text = (time - 10 - count).ToString();
                label3.Text = (time - 10 - count).ToString();
                label4.Text = (time - 10 - count).ToString();
            }
            else if (time - count > 10)                         // 南北绿灯+黄灯、东西红灯
            {
                label1.Text = (time - 10 - count).ToString();   // 绿灯10~4、黄灯3~1
                label2.Text = (time - 10 - count).ToString();
                label3.Text = (time - 10 - count).ToString();
                label4.Text = (time - 10 - count).ToString();
                if (time - count > 13)
                {
                    label1.BackColor = Color.LimeGreen;         // 南北绿灯10~4颜色
                    label2.BackColor = Color.LimeGreen;
                }
                else
                {
                    label1.BackColor = Color.Yellow;            // 南北黄灯3~1颜色
                    label2.BackColor = Color.Yellow;
                }
                label3.BackColor = Color.Red;                   // 东西红灯10~1颜色
                label4.BackColor = Color.Red;
            }
            else                                                // 南北红灯、东西绿灯+黄灯
            {
                label1.Text = (time - count).ToString();        // 绿灯10~4、黄灯3~1
                label2.Text = (time - count).ToString();
                label3.Text = (time - count).ToString();
                label4.Text = (time - count).ToString();
                label1.BackColor = Color.Red;                   // 南北红灯
                label2.BackColor = Color.Red;
                if (time - count > 3)
                {
                    label3.BackColor = Color.LimeGreen;         //东西绿灯
                    label4.BackColor = Color.LimeGreen;
                }
                else
                {
                    label3.BackColor = Color.Yellow;            // 东西黄灯
                    label4.BackColor = Color.Yellow;
                }
            }
        }

        private void button_Start_Click(object sender, System.EventArgs e)
        {
            if (button_Start.Text == "开始" || button_Start.Text == "恢复")
            {
                button_Start.Text = "暂停";                     // 点击“开始”或“恢复”之后跳变显示为“暂停”
                button_Start.BackColor = Color.LimeGreen;       // 按键颜色跳变为绿色，表示正在运行
                timer.Start();                                  // 计时器开始工作
            }
            else
            {
                button_Start.Text = "恢复";                     // 点击“暂停”之后跳变显示为“恢复”
                button_Start.BackColor = Color.LightGray;       // 按键颜色跳变为灰色，表示暂停运行
                timer.Stop();                                   // 计时器暂停工作
            }
        }

        private void button_Stop_Click(object sender, System.EventArgs e)
        {
            timer.Stop();                                       // 定时器停止
            count = 0;                                          // 计数器清零
            button_Start.Text = "开始";                         // 按键内容跳变为“开始”
            button_Start.BackColor = Color.LightGray;           // 按键颜色跳变为灰色
            label1.Text = 10.ToString();                        // 4路灯的数字复位为10
            label2.Text = 10.ToString();
            label3.Text = 10.ToString();
            label4.Text = 10.ToString();
            label1.BackColor = Color.LimeGreen;                 // 南北灯复位为绿色
            label2.BackColor = Color.LimeGreen;
            label3.BackColor = Color.Red;                       // 东西灯复位为红色
            label4.BackColor = Color.Red;
        }
    }
}
