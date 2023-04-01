using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Bus
{

    public partial class FindBus : Form
    {
        SerialPort sp = new SerialPort();
        Random rnd = new Random();
        string q;
        
        public FindBus()
        {
            InitializeComponent();
            bus1.ReadOnly = true; //좌석
            bus2.ReadOnly = true; //버스 번호
            bus3.ReadOnly = true; //버스 현재 위치
            bus4.ReadOnly = true; //도착 시간
            timer1.Start();
            timer1.Interval = 1000;
            
            
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) //데이터 수신
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }
        private void MySerialReceived(object s, EventArgs e)
        {
            string ReceiveData = sp.ReadExisting();
            bus1.Text += string.Format("{0}",ReceiveData);
        }
        private void Form1_Load(object sender, EventArgs e) //폼이 로드 되면 실행 하는 것
        {
            
           
        }


        private void button_ch(object sender, EventArgs e)//확인
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] msg = new byte[1500];
            msg = enc.GetBytes(bus1.Text);
            if (!sp.IsOpen)//시리얼 포트가 열려있지 않으면
            {
                sp.PortName = "COM4";
                sp.BaudRate = 115200;
                sp.DataBits = 8;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                sp.Handshake = Handshake.None;
                //sp.Encoding = Encoding.UTF8;
                sp.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                sp.Open();
            }
            else
            {
               MessageBox.Show("다시 하시오");
            }
            if (listBox1.SelectedItem != null)
            {
                int a = rnd.Next(0,60);
                int b = rnd.Next(0,15);
                
                if(b > 0)
                {
                    bus1.Text =  b.ToString() + " 자리 남았습니다.";
                    
                }
                else
                {
                    bus1.Text = "만석 입니다.";
                }
                   

                bus2.Text = listBox1.SelectedItem.ToString();
                bus3.Text = "이미지 자리";
                if(a > 0)
                {
                    bus4.Text = a.ToString() + "분";
                }
                else
                {
                    bus4.Text = "잠시후 도착";
                }
               
            }
        }

        private void button_ca(object sender, EventArgs e) //취소
        {
            bus1.Text = "";
            bus2.Text = "";
            bus3.Text = "";
            bus4.Text = "";
            if(sp.IsOpen == true)
            {
                sp.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //현재 시간
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

     
    }
}







/* 시리얼 포트 설명 (송,수신)
 https://junseo-studybook.tistory.com/6

시리얼 포트 자세한 설명
https://archive.ph/cVnNl

1. 시리얼 포트로 정보 받아서 버스 좌석, 도착 시간 출력
2. 잠시후 도착 <- 빨간색 글씨
3. 잠시후 도착 이거만 폰트 바꾸기
 */