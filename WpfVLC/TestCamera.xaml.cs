using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfVLC
{
    /// <summary>
    /// TestCamera.xaml 的交互逻辑
    /// </summary>
    public partial class TestCamera : Window
    {
        public TestCamera()
        {
            InitializeComponent();
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                var videoDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoDevice.VideoResolution = videoDevice.VideoCapabilities[0];  //设置分辨率
                player.VideoSource = videoDevice; //设置源
                player.Start(); //启动
            }
        }
    }
}
