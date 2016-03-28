using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВидеоПрямойПотокСКамеры
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                axVLCPlugin21.playlist.add("rtsp://SuAP:17GhbtvGhbtv@192.168.102.99:554/live1.sdp");
                axVLCPlugin21.playlist.play(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("ой что то произошло :( перезапустите приложение  " + ex);
            }
        }
    }
}
