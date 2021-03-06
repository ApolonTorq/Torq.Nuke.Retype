using Nuke.Common.Tooling;

namespace Torq.Nuke.Retype
{
    public partial class RetypeTasks
    {
        internal static string GetToolPath()
        {
            return ToolPathResolver.GetPackageExecutable("retypeapp", "retype.dll", RetypeVersion);
        }

        internal static string RetypeVersion = null;

        public static void UseRetypeVersion(string version)
        {
            RetypeVersion = version;
        }
    }
}