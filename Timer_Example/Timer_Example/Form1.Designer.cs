namespace Timer_Example
{
    partial class Timer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Hour_TextBox = new System.Windows.Forms.TextBox();
            this.Min_TextBox = new System.Windows.Forms.TextBox();
            this.Sec_TextBox = new System.Windows.Forms.TextBox();
            this.Start_Stop_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Set_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hour_TextBox
            // 
            this.Hour_TextBox.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Hour_TextBox.Location = new System.Drawing.Point(12, 68);
            this.Hour_TextBox.Multiline = true;
            this.Hour_TextBox.Name = "Hour_TextBox";
            this.Hour_TextBox.Size = new System.Drawing.Size(150, 150);
            this.Hour_TextBox.TabIndex = 0;
            this.Hour_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Min_TextBox
            // 
            this.Min_TextBox.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Min_TextBox.Location = new System.Drawing.Point(236, 68);
            this.Min_TextBox.Multiline = true;
            this.Min_TextBox.Name = "Min_TextBox";
            this.Min_TextBox.Size = new System.Drawing.Size(150, 150);
            this.Min_TextBox.TabIndex = 1;
            this.Min_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sec_TextBox
            // 
            this.Sec_TextBox.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sec_TextBox.Location = new System.Drawing.Point(460, 68);
            this.Sec_TextBox.Multiline = true;
            this.Sec_TextBox.Name = "Sec_TextBox";
            this.Sec_TextBox.Size = new System.Drawing.Size(150, 150);
            this.Sec_TextBox.TabIndex = 2;
            this.Sec_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start_Stop_Button
            // 
            this.Start_Stop_Button.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Start_Stop_Button.Location = new System.Drawing.Point(12, 267);
            this.Start_Stop_Button.Name = "Start_Stop_Button";
            this.Start_Stop_Button.Size = new System.Drawing.Size(150, 50);
            this.Start_Stop_Button.TabIndex = 3;
            this.Start_Stop_Button.Text = "Start";
            this.Start_Stop_Button.UseVisualStyleBackColor = true;
            this.Start_Stop_Button.Click += new System.EventHandler(this.Start_Stop_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset_Button.Location = new System.Drawing.Point(236, 267);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(150, 50);
            this.Reset_Button.TabIndex = 4;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Set_Button
            // 
            this.Set_Button.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Set_Button.Location = new System.Drawing.Point(460, 267);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(150, 50);
            this.Set_Button.TabIndex = 5;
            this.Set_Button.Text = "Set";
            this.Set_Button.UseVisualStyleBackColor = true;
            this.Set_Button.Click += new System.EventHandler(this.Set_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(168, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 100);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(392, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 100);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Start_Stop_Button);
            this.Controls.Add(this.Sec_TextBox);
            this.Controls.Add(this.Min_TextBox);
            this.Controls.Add(this.Hour_TextBox);
            this.Name = "Timer";
            this.Text = "アラム時計";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Hour_TextBox;
        private System.Windows.Forms.TextBox Min_TextBox;
        private System.Windows.Forms.TextBox Sec_TextBox;
        private System.Windows.Forms.Button Start_Stop_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

