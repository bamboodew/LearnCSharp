namespace Timer
{
    partial class MyTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_TotalTime = new System.Windows.Forms.Label();
            this.label_LeftTime = new System.Windows.Forms.Label();
            this.label_LeftTimeView = new System.Windows.Forms.Label();
            this.button_Timer = new System.Windows.Forms.Button();
            this.progressBar_LiveTime = new System.Windows.Forms.ProgressBar();
            this.comboBox_TotalTime = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_TotalTime
            // 
            this.label_TotalTime.AutoSize = true;
            this.label_TotalTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TotalTime.Location = new System.Drawing.Point(75, 36);
            this.label_TotalTime.Name = "label_TotalTime";
            this.label_TotalTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_TotalTime.Size = new System.Drawing.Size(42, 21);
            this.label_TotalTime.TabIndex = 0;
            this.label_TotalTime.Text = "时长";
            // 
            // label_LeftTime
            // 
            this.label_LeftTime.AutoSize = true;
            this.label_LeftTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LeftTime.Location = new System.Drawing.Point(75, 83);
            this.label_LeftTime.Name = "label_LeftTime";
            this.label_LeftTime.Size = new System.Drawing.Size(74, 21);
            this.label_LeftTime.TabIndex = 0;
            this.label_LeftTime.Text = "剩余时间";
            // 
            // label_LeftTimeView
            // 
            this.label_LeftTimeView.AutoSize = true;
            this.label_LeftTimeView.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LeftTimeView.Location = new System.Drawing.Point(160, 83);
            this.label_LeftTimeView.Name = "label_LeftTimeView";
            this.label_LeftTimeView.Size = new System.Drawing.Size(35, 21);
            this.label_LeftTimeView.TabIndex = 0;
            this.label_LeftTimeView.Text = "0秒";
            // 
            // button_Timer
            // 
            this.button_Timer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Timer.Location = new System.Drawing.Point(288, 36);
            this.button_Timer.Name = "button_Timer";
            this.button_Timer.Size = new System.Drawing.Size(99, 29);
            this.button_Timer.TabIndex = 1;
            this.button_Timer.Text = "开始计时";
            this.button_Timer.UseVisualStyleBackColor = true;
            this.button_Timer.Click += new System.EventHandler(this.button_Timer_Click);
            // 
            // progressBar_LiveTime
            // 
            this.progressBar_LiveTime.Location = new System.Drawing.Point(75, 145);
            this.progressBar_LiveTime.Name = "progressBar_LiveTime";
            this.progressBar_LiveTime.Size = new System.Drawing.Size(312, 23);
            this.progressBar_LiveTime.TabIndex = 2;
            // 
            // comboBox_TotalTime
            // 
            this.comboBox_TotalTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TotalTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_TotalTime.Location = new System.Drawing.Point(160, 36);
            this.comboBox_TotalTime.Name = "comboBox_TotalTime";
            this.comboBox_TotalTime.Size = new System.Drawing.Size(81, 29);
            this.comboBox_TotalTime.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 214);
            this.Controls.Add(this.comboBox_TotalTime);
            this.Controls.Add(this.progressBar_LiveTime);
            this.Controls.Add(this.button_Timer);
            this.Controls.Add(this.label_LeftTimeView);
            this.Controls.Add(this.label_LeftTime);
            this.Controls.Add(this.label_TotalTime);
            this.Name = "MyTimer";
            this.Text = "定时器";
            this.Load += new System.EventHandler(this.MyTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TotalTime;
        private System.Windows.Forms.Label label_LeftTime;
        private System.Windows.Forms.Label label_LeftTimeView;
        private System.Windows.Forms.Button button_Timer;
        private System.Windows.Forms.ProgressBar progressBar_LiveTime;
        private System.Windows.Forms.ComboBox comboBox_TotalTime;
        private System.Windows.Forms.Timer timer;
    }
}

