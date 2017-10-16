using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gcloud_voice;

namespace test
{
    public partial class Form1 : Form
    {
        private const string appId = "";
        private const string appKey = "";
        private IGCloudVoice m_voiceengine;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_voiceengine = GCloudVoice.GetEngine();
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string strTime = System.Convert.ToInt64(ts.TotalSeconds).ToString();
            m_voiceengine.SetAppInfo(appId, appKey, strTime);
            int ccc = m_voiceengine.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_voiceengine.SetMode(GCloudVoiceMode.RealTime);
            int ret = m_voiceengine.JoinTeamRoom("100001", 15000);
            Console.WriteLine("Hello,world!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello,world!");
            int dd = m_voiceengine.OpenSpeaker();
            Console.WriteLine("Hello,world!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            m_voiceengine.OpenMic();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m_voiceengine.CloseMic();
        }
    }
}
