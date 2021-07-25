using SRTPluginBase;
using System;

namespace SRTPluginUIRER2DirectXOverlay
{
    internal class PluginInfo : IPluginInfo
    {
        public string Name => "DirectX Overlay UI (Resident Evil: Revelations 2 (2015))";

        public string Description => "A DirectX-based Overlay User Interface for displaying Resident Evil: Revelations 2 (2015) game memory values.";

        public string Author => "VideoGameRoulette";

        public Uri MoreInfoURL => new Uri("https://github.com/SpeedrunTooling/SRTPluginUIRER2DirectXOverlay");

        public int VersionMajor => assemblyFileVersion.ProductMajorPart;

        public int VersionMinor => assemblyFileVersion.ProductMinorPart;

        public int VersionBuild => assemblyFileVersion.ProductBuildPart;

        public int VersionRevision => assemblyFileVersion.ProductPrivatePart;

        private System.Diagnostics.FileVersionInfo assemblyFileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}
