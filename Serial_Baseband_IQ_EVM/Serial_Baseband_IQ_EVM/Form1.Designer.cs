namespace Serial_Baseband_IQ_EVM
{
    partial class Form1
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
            this.Serial_Connect = new System.Windows.Forms.Button();
            this.Label_Serial = new System.Windows.Forms.Label();
            this.comboBox_Serial = new System.Windows.Forms.ComboBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Device = new System.Windows.Forms.Label();
            this.groupBox_Setting = new System.Windows.Forms.GroupBox();
            this.textBox_Vout = new System.Windows.Forms.TextBox();
            this.label_Vout = new System.Windows.Forms.Label();
            this.comboBox_Gain = new System.Windows.Forms.ComboBox();
            this.label_Gain = new System.Windows.Forms.Label();
            this.comboBox_VoutPort = new System.Windows.Forms.ComboBox();
            this.label_VoutPort = new System.Windows.Forms.Label();
            this.comboBox_Enable = new System.Windows.Forms.ComboBox();
            this.label_Enable = new System.Windows.Forms.Label();
            this.comboBox_Device = new System.Windows.Forms.ComboBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_MSG = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serial_Connect
            // 
            this.Serial_Connect.Location = new System.Drawing.Point(713, 14);
            this.Serial_Connect.Name = "Serial_Connect";
            this.Serial_Connect.Size = new System.Drawing.Size(75, 22);
            this.Serial_Connect.TabIndex = 0;
            this.Serial_Connect.Text = "연결";
            this.Serial_Connect.UseVisualStyleBackColor = true;
            this.Serial_Connect.Click += new System.EventHandler(this.Serial_Connect_Click);
            // 
            // Label_Serial
            // 
            this.Label_Serial.AutoSize = true;
            this.Label_Serial.CausesValidation = false;
            this.Label_Serial.Location = new System.Drawing.Point(506, 19);
            this.Label_Serial.Name = "Label_Serial";
            this.Label_Serial.Size = new System.Drawing.Size(80, 12);
            this.Label_Serial.TabIndex = 1;
            this.Label_Serial.Text = "시리얼_PORT";
            // 
            // comboBox_Serial
            // 
            this.comboBox_Serial.FormattingEnabled = true;
            this.comboBox_Serial.Location = new System.Drawing.Point(594, 15);
            this.comboBox_Serial.Name = "comboBox_Serial";
            this.comboBox_Serial.Size = new System.Drawing.Size(113, 20);
            this.comboBox_Serial.TabIndex = 2;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.label_Title.Location = new System.Drawing.Point(30, 14);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(214, 25);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Serial_BaseBand_IQ_EVM";
            // 
            // label_Device
            // 
            this.label_Device.AutoSize = true;
            this.label_Device.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Device.Location = new System.Drawing.Point(31, 32);
            this.label_Device.Name = "label_Device";
            this.label_Device.Size = new System.Drawing.Size(52, 15);
            this.label_Device.TabIndex = 5;
            this.label_Device.Text = "Device";
            // 
            // groupBox_Setting
            // 
            this.groupBox_Setting.CausesValidation = false;
            this.groupBox_Setting.Controls.Add(this.textBox_Vout);
            this.groupBox_Setting.Controls.Add(this.label_Vout);
            this.groupBox_Setting.Controls.Add(this.comboBox_Gain);
            this.groupBox_Setting.Controls.Add(this.label_Gain);
            this.groupBox_Setting.Controls.Add(this.comboBox_VoutPort);
            this.groupBox_Setting.Controls.Add(this.label_VoutPort);
            this.groupBox_Setting.Controls.Add(this.comboBox_Enable);
            this.groupBox_Setting.Controls.Add(this.label_Enable);
            this.groupBox_Setting.Controls.Add(this.comboBox_Device);
            this.groupBox_Setting.Controls.Add(this.label_Device);
            this.groupBox_Setting.Font = new System.Drawing.Font("굴림", 10F);
            this.groupBox_Setting.Location = new System.Drawing.Point(35, 91);
            this.groupBox_Setting.Name = "groupBox_Setting";
            this.groupBox_Setting.Size = new System.Drawing.Size(280, 230);
            this.groupBox_Setting.TabIndex = 6;
            this.groupBox_Setting.TabStop = false;
            this.groupBox_Setting.Text = "Setting";
            // 
            // textBox_Vout
            // 
            this.textBox_Vout.Location = new System.Drawing.Point(125, 175);
            this.textBox_Vout.Name = "textBox_Vout";
            this.textBox_Vout.Size = new System.Drawing.Size(113, 23);
            this.textBox_Vout.TabIndex = 15;
            // 
            // label_Vout
            // 
            this.label_Vout.AutoSize = true;
            this.label_Vout.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Vout.Location = new System.Drawing.Point(32, 179);
            this.label_Vout.Name = "label_Vout";
            this.label_Vout.Size = new System.Drawing.Size(66, 15);
            this.label_Vout.TabIndex = 14;
            this.label_Vout.Text = "Vout(Dn)";
            // 
            // comboBox_Gain
            // 
            this.comboBox_Gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gain.FormattingEnabled = true;
            this.comboBox_Gain.Items.AddRange(new object[] {
            "Gain=Gain",
            "Gain=Gain*2"});
            this.comboBox_Gain.Location = new System.Drawing.Point(125, 140);
            this.comboBox_Gain.Name = "comboBox_Gain";
            this.comboBox_Gain.Size = new System.Drawing.Size(113, 21);
            this.comboBox_Gain.TabIndex = 13;
            // 
            // label_Gain
            // 
            this.label_Gain.AutoSize = true;
            this.label_Gain.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Gain.Location = new System.Drawing.Point(31, 143);
            this.label_Gain.Name = "label_Gain";
            this.label_Gain.Size = new System.Drawing.Size(62, 15);
            this.label_Gain.TabIndex = 12;
            this.label_Gain.Text = "Gain_2X";
            // 
            // comboBox_VoutPort
            // 
            this.comboBox_VoutPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VoutPort.FormattingEnabled = true;
            this.comboBox_VoutPort.Items.AddRange(new object[] {
            "PortA",
            "PortB"});
            this.comboBox_VoutPort.Location = new System.Drawing.Point(125, 103);
            this.comboBox_VoutPort.Name = "comboBox_VoutPort";
            this.comboBox_VoutPort.Size = new System.Drawing.Size(113, 21);
            this.comboBox_VoutPort.TabIndex = 11;
            // 
            // label_VoutPort
            // 
            this.label_VoutPort.AutoSize = true;
            this.label_VoutPort.Font = new System.Drawing.Font("굴림", 11F);
            this.label_VoutPort.Location = new System.Drawing.Point(31, 106);
            this.label_VoutPort.Name = "label_VoutPort";
            this.label_VoutPort.Size = new System.Drawing.Size(71, 15);
            this.label_VoutPort.TabIndex = 10;
            this.label_VoutPort.Text = "Vout_Port";
            // 
            // comboBox_Enable
            // 
            this.comboBox_Enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Enable.FormattingEnabled = true;
            this.comboBox_Enable.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_Enable.Location = new System.Drawing.Point(125, 66);
            this.comboBox_Enable.Name = "comboBox_Enable";
            this.comboBox_Enable.Size = new System.Drawing.Size(113, 21);
            this.comboBox_Enable.TabIndex = 9;
            // 
            // label_Enable
            // 
            this.label_Enable.AutoSize = true;
            this.label_Enable.Font = new System.Drawing.Font("굴림", 11F);
            this.label_Enable.Location = new System.Drawing.Point(31, 69);
            this.label_Enable.Name = "label_Enable";
            this.label_Enable.Size = new System.Drawing.Size(51, 15);
            this.label_Enable.TabIndex = 8;
            this.label_Enable.Text = "Enable";
            // 
            // comboBox_Device
            // 
            this.comboBox_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Device.FormattingEnabled = true;
            this.comboBox_Device.Items.AddRange(new object[] {
            "DAC",
            "IQ_Filter"});
            this.comboBox_Device.Location = new System.Drawing.Point(125, 29);
            this.comboBox_Device.Name = "comboBox_Device";
            this.comboBox_Device.Size = new System.Drawing.Size(113, 21);
            this.comboBox_Device.TabIndex = 7;
            this.comboBox_Device.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Device_SelectedIndexChanged);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(35, 361);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(280, 51);
            this.button_Send.TabIndex = 7;
            this.button_Send.Text = "전송";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // textBox_MSG
            // 
            this.textBox_MSG.Location = new System.Drawing.Point(343, 98);
            this.textBox_MSG.Multiline = true;
            this.textBox_MSG.Name = "textBox_MSG";
            this.textBox_MSG.Size = new System.Drawing.Size(430, 313);
            this.textBox_MSG.TabIndex = 8;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("굴림", 9.5F);
            this.button_close.Location = new System.Drawing.Point(713, 42);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "연결 해제";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_MSG);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.comboBox_Serial);
            this.Controls.Add(this.Label_Serial);
            this.Controls.Add(this.Serial_Connect);
            this.Controls.Add(this.groupBox_Setting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Setting.ResumeLayout(false);
            this.groupBox_Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serial_Connect;
        private System.Windows.Forms.Label Label_Serial;
        private System.Windows.Forms.ComboBox comboBox_Serial;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Device;
        private System.Windows.Forms.GroupBox groupBox_Setting;
        private System.Windows.Forms.TextBox textBox_Vout;
        private System.Windows.Forms.Label label_Vout;
        private System.Windows.Forms.ComboBox comboBox_Gain;
        private System.Windows.Forms.Label label_Gain;
        private System.Windows.Forms.ComboBox comboBox_VoutPort;
        private System.Windows.Forms.Label label_VoutPort;
        private System.Windows.Forms.ComboBox comboBox_Enable;
        private System.Windows.Forms.Label label_Enable;
        private System.Windows.Forms.ComboBox comboBox_Device;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_MSG;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_close;
    }
}

