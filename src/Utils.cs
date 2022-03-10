using System;
using System.Diagnostics;
using System.Linq;

namespace TimeTrialStats
{
    public class Utils
    {
        private static Process process;

        public static bool IsMirrorsEdgeRunning()
        {
            process = Process.GetProcessesByName("MirrorsEdge").FirstOrDefault();
            return process != null;
        }

        public static string GetTimeTrialNameById(int stretchId)
        {
            switch (stretchId)
            {
                // Normal Time Trials
                case 1: return "Heat";
                case 2: return "Cranes Two";
                case 3: return "Cranes One";
                case 4: return "Edge";
                case 6: return "Chase";
                case 7: return "Stormdrains One";
                case 8: return "Stormdrains Two";
                case 9: return "Stormdrains Three";
                case 10: return "Atrium One";
                case 11: return "Atrium Two";
                case 12: return "Convoy One";
                case 13: return "Convoy Two";
                case 14: return "New Eden";
                case 15: return "Playground One";
                case 16: return "Playground Two";
                case 17: return "Factory";
                case 18: return "Shard One";
                case 19: return "Shard Two";
                case 20: return "Burfield";
                case 21: return "Playground Three";
                case 22: return "Flight";
                case 23: return "Arland";
                case 24: return "Office";

                // Pure Time Trials
                case 26: return "Actino";
                case 27: return "Flow";
                case 28: return "Razzmatazz";
                case 29: return "Velocity";
                case 31: return "Chroma";
                case 32: return "Reflex";
                case 34: return "Kinetic";
                case 35: return "Reflex Redux";
                case 36: return "Actino Rise";

                // In Main Menu
                default: return "n/a";
            }
        }

        public static string FormatTime(float time)
        {
            if (float.IsNaN(time))
            {
                return "00:00.000";
            }

            TimeSpan timer = TimeSpan.FromSeconds(time);

            if (time < 3600)
            {
                return string.Format("{0:00}:{1:00}.{2:000}", timer.Minutes, timer.Seconds, timer.Milliseconds);
            }

            return string.Format("{0:0}:{1:00}:{2:00}.{3:000}", timer.Hours, timer.Minutes, timer.Seconds, timer.Milliseconds);
        }
    }
}
