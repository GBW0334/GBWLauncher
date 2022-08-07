using Gameloop.Vdf.Linq;
using Gameloop.Vdf;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Gameloop.Vdf.JsonConverter;
using System.Diagnostics;

namespace GBWLauncher
{
    public partial class MainPage : Form
    {
        string playerinfo = string.Empty;
        string steamPath = "";
        string gamesteampath = "";
        string gamefolder = "";
        string filename = "gmcl_gbw_win32.dll";

        public MainPage(string playerinfo)
        {
            this.playerinfo = playerinfo;
            InitializeComponent();
    
            steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", "") as string;

            if (steamPath == null)
            {
                DialogResult d;
                d = MessageBox.Show("У вас не установлен Steam (Если это не так сообщите создателю)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (d == DialogResult.OK)
                {
                    Close();
                }
            }

            VToken volvo = VdfConvert.Deserialize(File.ReadAllText(steamPath + @"/steamapps/libraryfolders.vdf"));

            JArray array = JArray.Parse("[" + volvo.ToJson().First + "]");
            
            int sum = -1;
            foreach (var child in array[0])
            {
                sum += 1;
                if (array[0][sum.ToString()]["apps"]["4000"] != null)
                {
                    gamesteampath = array[0][sum.ToString()]["path"].ToString();
                    break;
                }
            }
            if (gamesteampath == "")
            {
                DialogResult d;
                d = MessageBox.Show("Лаунчер не нашел путь к игре ( Если у вас скачена игра сообщите создателю )", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (d == DialogResult.OK)
                {
                    Close();
                }
            }
            gamefolder = gamesteampath + @"\steamapps\common\garrysmod";

            if (!File.Exists(gamefolder + @"\hl2.exe"))
            {
                DialogResult d;
                d = MessageBox.Show("Лаунчер нашел путь к игре но не нашел игру ( Если у вас скачена игра сообщите создателю )", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (d == DialogResult.OK)
                {
                    Close();
                }
            }
            //this.label1.Text = File.Exists(gamefolder + @"\hl2.exe") ? "Файл игры найден." : "Файл игры не был найден";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (playerinfo == "q")
            {
                Panel form = new TransparentPanel("Похоже что сервер выключен");
                form.Dock = DockStyle.Top;
                this.justPanel1.Controls.Add(form);
                this.justPanel1.Tag = form;
                form.Show();
            }
            else if (playerinfo != "[]")
            {
                JArray array = JArray.Parse(playerinfo);
                var money = "▲" + Convert.ToDecimal(array[0]["money"]).ToString("N0");
                var lvl = "Уровень " + array[0]["level"];
                var karma = "Карма " + array[0]["karma"];
                var xp = "";
                if ((int)array[0]["xp"] != 10000)
                {
                    xp = "XP " + array[0]["xp"] + "/" + ((int)array[0]["xp"] + 1) * 250;
                }
                else
                {
                    xp = "XP MAX";
                }
                //Form form = new HaveInfo(playerinfo);
                Panel form = new TransparentPanelPlayer("Ваша информация", money, lvl, xp, karma);
                form.Dock = DockStyle.Fill;
                this.justPanel1.Controls.Add(form);
                this.justPanel1.Tag = form;
                form.Show();
            }
            else
            {
                Panel form = new TransparentPanel("Ого вы у нас впервые\nПриятной игры!");
                form.Dock = DockStyle.Top;
                this.justPanel1.Controls.Add(form);
                this.justPanel1.Tag = form;
                form.Show();
            }
        }

        private void roundedUserControl1_Click(object sender, EventArgs e)
        {
            string uriName = "http://62.122.213.32:3000";
            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!result)
            {
                MessageBox.Show("Сервер в данный момент выключен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string exelocation = Directory.GetCurrentDirectory() + @"\";
                string binlocariongaf = gamefolder + @"\garrysmod\lua\bin";
                string binlocarion = gamefolder + @"\garrysmod\lua\bin\";
                if (!Directory.Exists(binlocariongaf))
                {
                    Directory.CreateDirectory(binlocariongaf);
                }
                if (File.Exists(binlocarion + filename))
                {
                    File.Delete(binlocarion + filename);
                }
                if (File.Exists(exelocation + filename))
                {
                    File.Delete(exelocation + filename);
                }

                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/GBW0334/GBW-Server/blob/main/gmcl_gbw_win32.dll?raw=true", filename);

                    File.Move(exelocation + filename, binlocarion + filename);
                    Process[] workers = Process.GetProcessesByName("hl2");
                    foreach (Process worker in workers)
                    {
                        worker.Kill();
                        worker.WaitForExit();
                        worker.Dispose();
                    }
                    Process.Start("steam://connect/62.122.213.32:27015");
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить файл для запуска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void roundedUserControl2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/5FZUXnmfKw");
        }

        private void roundedUserControl3_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/gbw0334");
        }
    }
}
