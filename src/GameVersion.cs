using System.Diagnostics;
using System.Linq;

namespace TimeTrialStats
{
    public class GameVersion
    {
        public static Version Current { get; private set; }
        public static string MemorySize { get; private set; }

        public void DetectGameVersion()
        {
            Process process = Process.GetProcessesByName("MirrorsEdge").FirstOrDefault();

            if (process == null)
            {
                return;
            }

            switch (process.MainModule.ModuleMemorySize)
            {
                case 32976896:
                    Current = Version.Steam;
                    break;

                case 42889216:
                    Current = Version.Origin;
                    break;

                case 32632832:
                    Current = Version.Steam;
                    break;

                case 60298504:
                    Current = Version.Reloaded;
                    break;

                case 43794432:
                    Current = Version.OriginDLC;
                    break;

                case 42717184:
                    Current = Version.OriginJP;
                    break;

                case 42876928:
                    Current = Version.Reloaded;
                    break;

                default:
                    Current = Version.Unknown;
                    break;
            }

            MemorySize = process.MainModule.ModuleMemorySize.ToString();
        }
    }
    
    public enum Version
    {
        Unknown,
        Steam,
        GoG,
        Origin,
        Reloaded,
        OriginDLC,
        OriginJP,
        Dvd

        // GoG = Steam
        // Dvd = Reloaded
    }
}
