using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class MyTimer : Form
    {
        int count; // 用于定时器计数，每次1000ms；初始默认值为0
        int time; // 存储设定的定时值

        public MyTimer()
        {
            InitializeComponent();
        }

        // 加载设置的定时时间下拉框
        private void MyTimer_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 100; i++) // 计数范围0~99
            {
                comboBox_TotalTime.Items.Add(i.ToString() + " 秒"); // 初始化下拉框内容
            }
            comboBox_TotalTime.Text = "1 秒"; // 初始化
        }

        // 计时器后台和进度条前台的动作
        private void timer_Tick(object sender, EventArgs e) // Tick相当于一个无限循环Loop
        {
            count++; // 后台记录：当前累计次数*1000ms
            label_LeftTimeView.Text = (time - count).ToString() + "秒"; // 显示剩余时间
            progressBar_LiveTime.Value = count; // 关键语句：赋值给进度条显示出来

            if (count == time)
            {
                timer.Stop(); // 停止计时
                System.Media.SystemSounds.Asterisk.Play(); // 播放提示音
                MessageBox.Show("时间到了！", "提示"); // 弹窗提醒；程序断点卡住（暂停）
                count = 0; // 计数器复位
                button_Timer.Text = "开始计时";
            }
        }

        // 计时开始按钮的动作
        private void button_Timer_Click(object sender, EventArgs e)
        {
            if (button_Timer.Text == "开始计时" || button_Timer.Text == "恢复计时")
            {
                button_Timer.Text = "暂停";
                String str = comboBox_TotalTime.Text; // 将下拉框的内容赋给一个叫str名字的变量
                time = Convert.ToInt16(str.Substring(0, 2)); // 得到设定定时值（整形）
                progressBar_LiveTime.Maximum = time; // 进度条的最大值
                // 计时器的enable初始化为false，即timer.Stop()
                timer.Start(); // 开始计时
            }
            else if (button_Timer.Text == "暂停")
            {
                timer.Stop(); // 点击“暂停”后，计时停止
                button_Timer.Text = "恢复计时"; // 点击“暂停”后，按键显示变为“恢复计时”
            }
        }
    }
}