using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;



namespace SmartLab.APP.User
{


    public partial class User1 : Form
    {
        #region 属性
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        public int selectedDeviceIndex = 0;
        #endregion

        public User1()
        {
            InitializeComponent();

        }

        public void connVideo()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            selectedDeviceIndex = 0;
            videoSource = new VideoCaptureDevice(videoDevices[selectedDeviceIndex].MonikerString);//连接摄像头。
            videoSource.VideoResolution = videoSource.VideoCapabilities[selectedDeviceIndex];
            videoSourcePlayer1.VideoSource = videoSource;
            // set NewFrame event handler
            videoSourcePlayer1.Start();
        }
        private void Exit()
        {
            //关摄像头并刷新,同时关窗体
            if (videoSourcePlayer1 != null && videoSourcePlayer1.IsRunning)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
            }
        }

        private void User1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("E:/de/SmartLab/SmartLab/APP/Font/RuiZiBiGeQingChunTiJian2-0-1.ttf");
            Font f = new Font(font.Families[0], 12);

            var r = font.Families[0].IsStyleAvailable(FontStyle.Regular);
            var b = font.Families[0].IsStyleAvailable(FontStyle.Bold);
            //定义成新的字体对象
            FontFamily myFontFamily = new FontFamily(font.Families[0].Name, font);
            Font myFont = new Font(myFontFamily, 64);

            label1.Font = myFont;
            label2.Font = myFont;
            QueryTimetable.Font = myFont;

            panel1.BackColor = Color.FromArgb(20,67, 139, 241);

            connVideo();
        }

        private void QueryTimetable_Click(object sender, EventArgs e)
        {
            Exit();
            Appointment_schedule appointmentSchedule = new Appointment_schedule(this);
            appointmentSchedule.Show();
            this.Hide();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
