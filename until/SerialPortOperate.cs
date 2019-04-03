using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Timers;

namespace SmartLab.until
{
    class SerialPortOperate
    {
        private static SerialPort serialPort1; 
        public static byte[] RoomState = new byte[132];
        private System.Timers.Timer timer1 = new System.Timers.Timer();
        public SerialPortOperate()
        {
            RoomState[17] = 0;
            RoomState[18] = 0;
            RoomState[19] = 0;
            //指定COM口
            serialPort1 = new SerialPort("COM4");
            //指定波特率
            serialPort1.BaudRate = 9600;
            try
            {
                //打开COM口
                serialPort1.Open();
            }
            catch (Exception)
            {

                Console.WriteLine("打开COM口失败");
            }
            timer1.Enabled = true;
            timer1.Interval = 10000; //执行间隔时间,单位为毫秒; 这里实际间隔为10分钟  
            timer1.Start();
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(test);
            Receive();
            AA = new EnData(Trans);
        }
        private static void test(object source, ElapsedEventArgs e)
        {
                SendCom(0x01, 0x01, 0x10);
            Console.WriteLine("已发送");


        }

        private static byte SumCheck(byte[] bs,int length)
        {
            int num = 0;
            //所有字节累加
            for (int i = 0; i < length; i++)
            {
                num = (num + bs[i]) % 0xFFFF;
            }
            byte ret = (byte)(num & 0xff);//只要最后一个字节
           
            return ret;
        }
        private static void SendCom(byte device,byte start,byte num)//定时发送
        {
            byte[] SendBuf = new byte[5];
            SendBuf[0] = device;//设备编号
            SendBuf[1] = 0x03;//功能码
            SendBuf[2] = start;//开始地址
            SendBuf[3] = num;//个数
            SendBuf[4] = SumCheck(SendBuf,4);
            serialPort1.Write(SendBuf,0,SendBuf.Length);
        }


        public delegate void EnData(byte[] a);
        EnData AA;
        
        public void Trans(byte[] a)
        {   int num_ = a[2];
            int i,j;
      
            if (a[1]==3)
            {
               
                if (SumCheck(a,a.Length-1) == a[a.Length - 1])
                {
                    for(i=3,j=0;j<num_;j++,i++)
                    {
                        RoomState[i] = a[i];
                        Console.WriteLine(RoomState[i]);
                    }
                }  
                else
                {
                    Console.WriteLine("校验码错误");
                }

            }
            else if (a[1] == 7)
            {
                int certi = a.Length-1;
                if (SumCheck(a, a.Length - 1) == a[certi]) 
                {
                    Console.WriteLine("控制成功");
                    if(a[4] == 0x00)
                    {
                        
                        for (i=a[2],j=0;j<a[3];j++,i++)
                        {
                            Reset(19, i, false);

                        }
                    }
                    
                    else if (a[4] == 0x01)
                        for (i = a[2]+1, j = 0; j < a[3]; j++, i++)
                        {
                            Reset(19, i, true);
                        }
                    Console.WriteLine(RoomState[19]);

                }
                else
                    Console.WriteLine("控制失败");
            }
             

            
           
           
        }

        private void Receive()
        {
            serialPort1.DataReceived += serialPort1_Datareceived;
            serialPort1.ReceivedBytesThreshold = 4;//事件发生前内部输入缓冲区的字节数，每当缓冲区的字节达到此设定的值，就会触发对象的数据接收事件
        }
        void serialPort1_Datareceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int n = serialPort1.BytesToRead;
            byte[] buf = new byte[n];
            serialPort1.Read(buf, 0, n);
            AA(buf);
            //Console.WriteLine("shou");
            serialPort1.DiscardOutBuffer();
        }
        private void SendControl(byte stm, byte start,byte num,byte state)
        {
            byte[] data = new byte[6];
            data[0] = stm;//设备编号
            data[1] = 0x07;//功能码
            data[2] = start;//开始地址
            data[3] = num;//设备个数
            data[4] = state;//开或关
            data[5] = SumCheck(data, 5);
            serialPort1.Write(data, 0, data.Length);
            Console.WriteLine("已发送命令");
        }
        public void Control(byte stm, byte start, byte num, byte state)
        {
            SendControl(stm,start, num,state);
        }
        /// <param name="device"></param>
        /// <param name="index">要设置的位， 值从低到高为 1-8</param>
        /// <param name="flag">要设置的值 true / false</param>
        private void Reset(int device,int index,bool flag)
        {
            if(device == 17)//烟雾
            {
                int v = index < 2 ? index : (2 << (index - 2));
                RoomState[17] = flag ? (byte)(RoomState[17] | v) : (byte)(RoomState[17] & ~v);
            }
             else if (device == 18)//红外
            {
                int v = index < 2 ? index : (2 << (index - 2));
                RoomState[18] = flag ? (byte)(RoomState[18] | v) : (byte)(RoomState[17] & ~v);
            }
            else if (device == 19)//用电器
            {
                int v = index < 2 ? index : (2 << (index - 2));
                
                RoomState[19] = flag ? (byte)(RoomState[19] | v) : (byte)(RoomState[17] & ~v);
                
            }

        }
       
    }
}
