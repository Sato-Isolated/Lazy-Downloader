using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lazy_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var path = Environment.CurrentDirectory;
            var dl = new WebClient();
            if (checkBox1.Checked) dl.DownloadFile("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86", "DiscordSetup.exe");
            if (checkBox2.Checked) dl.DownloadFile("https://get.videolan.org/vlc/3.0.16/win64/vlc-3.0.16-win64.exe", "vlc-3.0.16-win64.exe");
            if (checkBox3.Checked) dl.DownloadFile("https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-602fr.exe", "winrar-x64-602fr.exe");
            if (checkBox4.Checked) dl.DownloadFile("https://notepad-plus-plus.org/repository/7.x/7.0/npp.7.Installer.x64.exe", "npp.7.Installer.x64.exe");
            if (checkBox5.Checked) dl.DownloadFile("https://download.visualstudio.microsoft.com/download/pr/9dc321fd-8a9b-47ef-98a9-af0515e08d6f/533c91be0b61f481cb93758a3c6af09cef719cedbaa6e9916232918649fd4a35/vs_Community.exe", "vs_Community.exe");
            if (checkBox6.Checked) dl.DownloadFile("https://telegram.org/dl/desktop/win64", "TelegramSetup.exe");
            if (checkBox7.Checked) dl.DownloadFile("https://laptop-updates.brave.com/latest/winx64", "BraveSetup.exe");
            if (checkBox8.Checked) dl.DownloadFile("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BE060CBB4-0849-8C90-D483-C40EF182C24A%7D%26lang%3Dfr%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe", "ChromeSetup.exe");
            if (checkBox9.Checked) dl.DownloadFile("https://net.geo.opera.com/opera_gx/stable/windows?utm_tryagain=yes&utm_source=google_via_opera_com&utm_medium=ose&utm_campaign=(none)_via_opera_com_https&http_referrer=https%3A%2F%2Fwww.google.com%2F&utm_site=opera_com&&utm_lastpage=opera.com/computer/thanks&dl_token=27647740", "OperaGxSetup.exe");
            if (checkBox10.Checked) dl.DownloadFile("https://cdn.stubdownloader.services.mozilla.com/builds/firefox-stub/fr/win/0eec0eb5d30526efbad3e6b369b201812546d07980318d7feef46149be820284/Firefox%20Installer.exe", "FirefoxSetup.exe");
            if (checkBox11.Checked) dl.DownloadFile("https://dotsrc.dl.osdn.net/osdn/bulk-crap-uninstaller/75105/BCUninstaller_5.0_setup.exe", "BCUninstaller_5.0_setup.exe");
            if (checkBox12.Checked) dl.DownloadFile("https://download.ccleaner.com/ccsetup582.exe", "ccsetup582.exe");
            if (checkBox13.Checked) dl.DownloadFile("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe", "SteamSetup.exe");
            if (checkBox14.Checked) dl.DownloadFile("https://www.dm.origin.com/download", "OriginSetup.exe");
            if (checkBox15.Checked) dl.DownloadFile("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi", "EpicGamesLauncherInstaller.msi");
            if (checkBox16.Checked) dl.DownloadFile("https://eu.battle.net/download/getInstaller?os=win&installer=Battle.net-Setup.exe&id=undefined", "Battle.net-Setup.exe");
            if (checkBox17.Checked) dl.DownloadFile("https://ubistatic3-a.akamaihd.net/orbit/launcher_installer/UbisoftConnectInstaller.exe", "UbisoftConnectInstaller.exe");
            if (checkBox18.Checked) dl.DownloadFile("https://github.com/sandboxie-plus/Sandboxie/releases/download/0.8.6/Sandboxie-Plus-x64-v0.8.6.exe", "Sandboxie-Plus-x64-v0.8.6.exe");
            if (checkBox19.Checked) dl.DownloadFile("https://sourceforge.net/projects/qbittorrent/files/qbittorrent-win32/qbittorrent-4.3.6/qbittorrent_4.3.6_x64_setup.exe/download", "qbittorrent_4.3.6_x64_setup.exe");
            if (checkBox20.Checked) dl.DownloadFile("https://sourceforge.net/projects/processhacker/files/processhacker2/processhacker-2.39-setup.exe/download", "processhacker-2.39-setup.exe");

            if (File.Exists(path + "\\DiscordSetup.exe"))
                Process.Start(path + "\\DiscordSetup.exe");

            if (File.Exists(path + "\\vlc-3.0.16-win64.exe"))
                Process.Start(path + "\\vlc-3.0.16-win64.exe");

            if (File.Exists(path + "\\winrar-x64-602fr.exe"))
                Process.Start(path + "\\winrar-x64-602fr.exe");

            if (File.Exists(path + "\\npp.7.Installer.x64.exe"))
                Process.Start(path + "\\npp.7.Installer.x64.exe");

            if (File.Exists(path + "\\vs_Community.exe"))
                Process.Start(path + "\\vs_Community.exe");

            if (File.Exists(path + "\\TelegramSetup.exe"))
                Process.Start(path + "\\TelegramSetup.exe");

            if (File.Exists(path + "\\BraveSetup.exe"))
                Process.Start(path + "\\BraveSetup.exe");

            if (File.Exists(path + "\\ChromeSetup.exe"))
                Process.Start(path + "\\ChromeSetup.exe");

            if (File.Exists(path + "\\OperaGxSetup.exe"))
                Process.Start(path + "\\OperaGxSetup.exe");

            if (File.Exists(path + "\\FirefoxSetup.exe"))
                Process.Start(path + "\\FirefoxSetup.exe");

            if (File.Exists(path + "\\BCUninstaller_5.0_setup.exe"))
                Process.Start(path + "\\BCUninstaller_5.0_setup.exe");

            if (File.Exists(path + "\\ccsetup582.exe"))
                Process.Start(path + "\\ccsetup582.exe");

            if (File.Exists(path + "\\SteamSetup.exe"))
                Process.Start(path + "\\SteamSetup.exe");

            if (File.Exists(path + "\\OriginSetup.exe"))
                Process.Start(path + "\\OriginSetup.exe");

            if (File.Exists(path + "\\EpicGamesLauncherInstaller.msi"))
                Process.Start(path + "\\EpicGamesLauncherInstaller.msi");

            if (File.Exists(path + "\\Battle.net-Setup.exe"))
                Process.Start(path + "\\Battle.net-Setup.exe");

            if (File.Exists(path + "\\UbisoftConnectInstaller.exe"))
                Process.Start(path + "\\UbisoftConnectInstaller.exe");

            if (File.Exists(path + "\\Sandboxie-Plus-x64-v0.8.6.exe"))
                Process.Start(path + "\\Sandboxie-Plus-x64-v0.8.6.exe");

            if (File.Exists(path + "\\qbittorrent_4.3.6_x64_setup.exe"))
                Process.Start(path + "\\qbittorrent_4.3.6_x64_setup.exe");

            if (File.Exists(path + "\\processhacker-2.39-setup.exe"))
                Process.Start(path + "\\processhacker-2.39-setup.exe");

        }
    }
}
