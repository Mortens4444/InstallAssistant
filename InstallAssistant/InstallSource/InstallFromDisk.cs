namespace InstallAssistant.InstallSource
{
    class InstallFromDisk : Installer
    {
        private readonly string installerPath;

        public InstallFromDisk(string installerName, string semicolonSeparatedGroups, string installerPath)
            : base(installerName, semicolonSeparatedGroups) => this.installerPath = installerPath;

        public override void Start()
        {
            Start(installerPath);
        }
    }
}
