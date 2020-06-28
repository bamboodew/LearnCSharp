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
        private int count = 0;                      // 计数器
        private int time = 20;                  // 定义初始时间10秒

        public Form_TrafficLights()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            count++;                            // 计数器自加一
            if (time - count == 0)
            {
                count = 0;
                label1.BackColor = Color.LimeGreen;
                label2.BackColor = Color.LimeGreen;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
            }
            if (time - count > 10)
            {
                label1.Text = (time - 10 - count).ToString();
                label2.Text = (time - 10 - count).ToString();

                label3.Text = (time - 10 - count).ToString();
                label4.Text = (time - 10 - count).ToString();

                if (time - count > 13)
                {
                    label1.BackColor = Color.LimeGreen;
                    label2.BackColor = Color.LimeGreen;
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Red;
                }
                else
                {
                    label1.BackColor = Color.Yellow;
                    label2.BackColor = Color.Yellow;
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Red;
                }
            }
            else if (time - count < 11 && time - count > 0)
            {
                label1.Text = (time - count).ToString();
                label2.Text = (time - count).ToString();

                label3.Text = (time - count).ToString();
                label4.Text = (time - count).ToString();

                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;

                if (time - count > 3)
                {
                    label3.BackColor = Color.LimeGreen;
                    label4.BackColor = Color.LimeGreen;
                }
                else
                {
                    label3.BackColor = Color.Yellow;
                    label4.BackColor = Color.Yellow;
                }
            }


        }

        private void button_Start_Click(object sender, System.EventArgs e)
        {
            if (button_Start.Text == "开始" || button_Start.Text == "恢复")
            {
                button_Start.Text = "暂停";
                button_Start.BackColor = Color.LimeGreen;

                // 计时器开始工作
                timer.Start();
            }
            else
            {
                button_Start.Text = "恢复";
                button_Start.BackColor = Color.LightGray;

                // 计时器暂停工作
                timer.Stop();
            }
        }

        private void button_Stop_Click(object sender, System.EventArgs e)
        {
            // 全部清零复位
            timer.Stop();
            time = 20;
            count = 0;

            button_Start.Text = "开始";
            button_Start.BackColor = Color.LightGray;

            label1.Text = 10.ToString();
            label2.Text = 10.ToString();
            label3.Text = 10.ToString();
            label4.Text = 10.ToString();

            label1.BackColor = Color.LimeGreen;
            label2.BackColor = Color.LimeGreen;
            label3.BackColor = Color.Red;
            label4.BackColor = Color.Red;
        }
    }
}
