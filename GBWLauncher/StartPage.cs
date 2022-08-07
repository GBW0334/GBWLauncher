using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GBWLauncher.SteamGet;

namespace GBWLauncher
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();

        }
        private async Task LoadPlayerInfoAsync(ulong steamid)
        {
            JArray version = new JArray();
            try
            {
                
                string url = "http://62.122.213.32:3000/version";
                string s = "";
                using (WebClient client = new WebClient())
                {
                    s = client.DownloadString(url);
                    version = JArray.Parse("[" + s + "]");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось получить информацию о свежей версии лаунчера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (version.Count > 0)
            {
                if (version[0]["verapp"].ToString() != Properties.Resources.ver)
                {
                    DialogResult d;
                    d = MessageBox.Show("Вышла новая версия лаунчера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (d == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
            try
            {
                string s = "";
                Uri url = new Uri("http://62.122.213.32:3000/data?steamid_like=" + steamid);

                using (WebClient client = new WebClient())
                {
                    s = await client.DownloadStringTaskAsync(url);
                }
                Thread.Sleep(500);
                Hide();
                Form f1 = new MainPage(s);
                f1.ShowDialog();
                Close();
            }
            catch
            {
                Thread.Sleep(500);
                Hide();
                Form f1 = new MainPage("q");
                f1.ShowDialog();
                Close();
            }
        }

        private void Loading()
        {
            var temp = Process.GetProcessesByName("steam");
            Process steamd;

            steamd = null;

            if (temp.Length == 1)
                steamd = temp[0];
            else
            {
                temp = Process.GetProcessesByName("steam.exe");

                if (temp.Length == 1)
                    steamd = temp[0];
            }
            if (steamd != null)
            {
                using (var steam = new SteamBridge())
                {
                    var _ = LoadPlayerInfoAsync(steam.GetSteamId());
                }
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Вам необходимо запустить Steam", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (d == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void StartWindow_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            Loading();
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Layout(object sender, LayoutEventArgs e)
        {
            
        }
    }
}
