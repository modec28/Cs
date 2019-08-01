using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_Baseband_IQ_EVM
{
    public partial class Form1 : Form
    {
        //Global Variable//
        bool Device_is_DAC = true;
        string Corner_Frequency;
        SerialPort port = new SerialPort();
        ///////////////////

        public Form1()
        {
            InitializeComponent();
            string[] PortNames = SerialPort.GetPortNames();//포트 검색
            foreach (string portnum in PortNames)
            {
                comboBox_Serial.Items.Add(portnum);
            }
        }
        private void Serial_Connect_Click(object sender, EventArgs e)
        {
            if(port.IsOpen==false)
            {
                port.PortName = comboBox_Serial.SelectedItem.ToString();
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Parity = Parity.None;
                port.Open();
                textBox_MSG.Text += "연결되었습니다.\r\n";
            }
            else
            {
                textBox_MSG.Text += "?? 언제 연결하셨나요? 연결되어있네요 연결을 해제하겠습니다.\r\n";
                port.Close();
            }
            
        }

        private void ComboBox_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Device.Text == "IQ_Filter")
                Device_IQ();
            else
                Device_DAC();

        }
        private void Device_IQ()
        {
            Device_is_DAC = false;
            label_VoutPort.Text = "Frequency";
            label_Gain.Visible = false;
            label_Vout.Visible = false;
            comboBox_Gain.Visible = false;
            textBox_Vout.Visible = false;
            comboBox_VoutPort.Items.Clear();
            comboBox_VoutPort.Items.AddRange(new string[] { "36Mhz", "72Mhz", "144Mhz", "288Mhz", "432Mhz", "576Mhz", "720Mhz", "Bypass" });
        }
        private void Device_DAC()
        {
            Device_is_DAC = true;
            label_VoutPort.Text = "Vout_Port";
            label_Gain.Visible = true;
            label_Vout.Visible = true;
            comboBox_Gain.Visible = true;
            textBox_Vout.Visible = true;
            comboBox_VoutPort.Items.Clear();
            comboBox_VoutPort.Items.AddRange(new string[] { "PortA", "PortB" });
        }
        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (Device_is_DAC)
            {
                string Which_Port = (comboBox_VoutPort.SelectedItem.ToString() == "PortA") ? "0" : "1";
                string is_Gain_Double = (comboBox_Gain.SelectedItem.ToString() == "Gain=Gain") ? "1" : "0";
                string is_enable = (comboBox_Enable.SelectedItem.ToString() == "Enable") ? "1" : "0";
                string Dn = Convert.ToString(Convert.ToInt32(textBox_Vout.Text),2); //입력된 Dn값을 2진수로 변환
                //DAC의 Dn은 총 12비트이므로, 0을 채워 12비트의 2진수로 만들어줘야한다.
                string zero = string.Concat(Enumerable.Repeat("0", 12 - Dn.Length));
                
                string data = Which_Port + "1" + is_Gain_Double + is_enable + zero + Dn;//문자열 합성하여 2진수로 변환준비
                string str_hex_data = Convert.ToString(Convert.ToInt32(data, 2), 16);//2진수에서 10진수로 바꾼뒤 16진수의 문자열로 바꾼다.
                //MCU에서 16진수의 Byte를 받게 코딩되어있기 때문에 Byte로 바꿔준다.
                port.Write(Convert_Str_Hex_to_Byte(str_hex_data),0,Convert_Str_Hex_to_Byte(str_hex_data).Length);
            }
            else
            {
                string is_enable = (comboBox_Enable.SelectedItem.ToString() == "Enable") ? "1" : "0";
                switch(comboBox_VoutPort.SelectedItem.ToString())
                {
                    case "36Mhz":
                        Corner_Frequency = "000";
                        break;
                    case "72Mhz":
                        Corner_Frequency = "001";
                        break;
                    case "144Mhz":
                        Corner_Frequency = "010";
                        break;
                    case "288Mhz":
                        Corner_Frequency = "011";
                        break;
                    case "432Mhz":
                        Corner_Frequency = "100";
                        break;
                    case "576Mhz":
                        Corner_Frequency = "101";
                        break;
                    case "720Mhz":
                        Corner_Frequency = "110";
                        break;
                    case "Bypass":
                        Corner_Frequency = "111";
                        break;
                    default:
                        textBox_MSG.Text += "지금 뭐 누르신거에요? 연결을 해제합니다.\r\n";
                        port.Close();
                        break;
                }
                string data = "00010000"+ is_enable + "0000" + Corner_Frequency;//2진수
                string str_hex_data = Convert.ToString(Convert.ToInt32(data, 2), 16);
                port.Write(Convert_Str_Hex_to_Byte(str_hex_data), 0, Convert_Str_Hex_to_Byte(str_hex_data).Length);
            }
        }
        private byte[] Convert_Str_Hex_to_Byte(string strhex)//(string) Hex를 (byte) Hex로
        {
            int index_len = strhex.Length;
            byte[] bytes = new byte[index_len / 2];
            for(int i=0; i <index_len; i+=2)
            {
                bytes[i / 2] = Convert.ToByte(strhex.Substring(i, 2), 16);
            }
            return bytes;
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            textBox_MSG.Text += "연결을 해제합니다.\r\n";
            port.Close();
        }
    }
}
