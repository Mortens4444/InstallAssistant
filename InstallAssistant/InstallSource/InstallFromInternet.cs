using System.Net;

namespace InstallAssistant.InstallSource
{
    class InstallFromInternet : Installer
    {
        private readonly string link;

        public InstallFromInternet(string installerName, string semicolonSeparatedGroups, string link)
            : base(installerName, semicolonSeparatedGroups) => this.link = link;

        public override void Start()
        {
            var installerPath = CreateTempFilename(link);
            DownloadFrom(link, installerPath);
            Start(installerPath);
        }

        private void DownloadFrom(string link, string filename)
        {
            var webClient = new WebClient();
            webClient.DownloadFile(link, filename);
        }
    }
}
