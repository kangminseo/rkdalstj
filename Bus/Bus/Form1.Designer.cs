namespace Bus
{
    partial class FindBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBus));
            this.bus1 = new System.Windows.Forms.TextBox();
            this.bus2 = new System.Windows.Forms.TextBox();
            this.bus3 = new System.Windows.Forms.TextBox();
            this.bus4 = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_x = new System.Windows.Forms.Button();
            this.button_o = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bus1
            // 
            this.bus1.Location = new System.Drawing.Point(12, 135);
            this.bus1.Multiline = true;
            this.bus1.Name = "bus1";
            this.bus1.Size = new System.Drawing.Size(79, 69);
            this.bus1.TabIndex = 0;
            // 
            // bus2
            // 
            this.bus2.Font = new System.Drawing.Font("굴림", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bus2.Location = new System.Drawing.Point(97, 135);
            this.bus2.Multiline = true;
            this.bus2.Name = "bus2";
            this.bus2.Size = new System.Drawing.Size(71, 69);
            this.bus2.TabIndex = 1;
            // 
            // bus3
            // 
            this.bus3.Location = new System.Drawing.Point(174, 135);
            this.bus3.Multiline = true;
            this.bus3.Name = "bus3";
            this.bus3.Size = new System.Drawing.Size(265, 69);
            this.bus3.TabIndex = 2;
            // 
            // bus4
            // 
            this.bus4.Font = new System.Drawing.Font("궁서체", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bus4.Location = new System.Drawing.Point(447, 135);
            this.bus4.Multiline = true;
            this.bus4.Name = "bus4";
            this.bus4.Size = new System.Drawing.Size(73, 69);
            this.bus4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "좌석";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "버스 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "버스 현재 위치";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "도착 시간";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "302",
            "16",
            "14-1",
            "123-1",
            "123-12"});
            this.listBox1.Location = new System.Drawing.Point(8, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 64);
            this.listBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_x);
            this.groupBox1.Controls.Add(this.button_o);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "버스 찾기";
            // 
            // button_x
            // 
            this.button_x.Location = new System.Drawing.Point(179, 58);
            this.button_x.Name = "button_x";
            this.button_x.Size = new System.Drawing.Size(75, 30);
            this.button_x.TabIndex = 10;
            this.button_x.Text = "취소";
            this.button_x.UseVisualStyleBackColor = true;
            this.button_x.Click += new System.EventHandler(this.button_ca);
            // 
            // button_o
            // 
            this.button_o.Location = new System.Drawing.Point(179, 24);
            this.button_o.Name = "button_o";
            this.button_o.Size = new System.Drawing.Size(75, 30);
            this.button_o.TabIndex = 9;
            this.button_o.Text = "확인";
            this.button_o.UseVisualStyleBackColor = true;
            this.button_o.Click += new System.EventHandler(this.button_ch);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("궁서", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(341, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "현재 시간";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("굴림", 25F);
            this.time.Location = new System.Drawing.Point(277, 58);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(101, 42);
            this.time.TabIndex = 12;
            this.time.Text = "time";
            // 
            // FindBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 215);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bus4);
            this.Controls.Add(this.bus3);
            this.Controls.Add(this.bus2);
            this.Controls.Add(this.bus1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindBus";
            this.Text = "FindBus";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bus1;
        private System.Windows.Forms.TextBox bus2;
        private System.Windows.Forms.TextBox bus3;
        private System.Windows.Forms.TextBox bus4;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_x;
        private System.Windows.Forms.Button button_o;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label time;
    }
}

