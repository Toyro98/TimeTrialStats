using System.Collections.Generic;
using System.Linq;

namespace TimeTrialStats
{
    public class Memory
    {
        public Memory()
        {
            Structure structure = new Structure();

            stretchAddress = new MemoryAddress(structure.TimeTrial, structure.TimeTrial.ActiveTimeTrialStretch);
            checkpointAddress = new MemoryAddress(structure.TimeTrial, structure.TimeTrial.TotalCheckPoints);
            timeAddress = new MemoryAddress(structure.TimeTrial, structure.TimeTrial.FinalTime);
            distanceAddress = new MemoryAddress(structure.TimeTrial, structure.TimeTrial.Distance);
        }

        bool updatedStats;
        byte[] checkpoint;
        int oldCheckpointPassed;
        int oldTimerCheckpointPassed;

        public static List<Stats> sessionStats = new List<Stats>();
        public static List<Stats> averageStats = new List<Stats>();
        public static List<Stats> totalStats = new List<Stats>();

        public int StretchId { get; set; }
        public float Time { get; set; }
        public float AvgSpeed { get; set; }
        public float Distance { get; set; }
        public int TotalCheckpoints { get; set; }
        public int CheckpointPassed { get; set; }
        public int TimerCheckpointPassed { get; set; }

        MemoryHelper memoryHelper = new MemoryHelper();

        MemoryAddress stretchAddress;
        MemoryAddress checkpointAddress;
        MemoryAddress timeAddress;
        MemoryAddress distanceAddress;

        public void Startup()
        {
            UpdateMemory();
            ReadMemory();

            if (CheckpointPassed == TotalCheckpoints && StretchId != 0 && Time != 0f)
            {
                sessionStats.Add(new Stats(StretchId, Time, AvgSpeed, Distance));
                averageStats.Add(new Stats(StretchId, Time, AvgSpeed, Distance, 1));
                totalStats.Add(new Stats(StretchId, 0f, 0f, CheckpointPassed, TimerCheckpointPassed, 0));
            }
        }

        public void UpdateMemory()
        {
            // Update each address so we have the correct address when changing levels etc
            stretchAddress.Update(memoryHelper);
            checkpointAddress.Update(memoryHelper);
            timeAddress.Update(memoryHelper);
            distanceAddress.Update(memoryHelper);
        }

        public void ReadMemory()
        {
            // We always read what the stretch id is
            StretchId = memoryHelper.ReadMemory<byte>(stretchAddress);

            // Don't read memory if the stretch id is 0
            if (StretchId != 0)
            {
                // Read checkpoint values
                checkpoint = memoryHelper.ReadMemoryBytes(checkpointAddress, 12);
                TotalCheckpoints = checkpoint[0];
                CheckpointPassed = checkpoint[4];
                TimerCheckpointPassed = checkpoint[8];

                // Only read time and distance once we actually finish a time trial
                if (CheckpointPassed == TotalCheckpoints)
                {
                    Time = memoryHelper.ReadMemory<float>(timeAddress);
                    Distance = memoryHelper.ReadMemory<float>(distanceAddress);

                    // If the program is running and you launch a time trial. All values are 0 except a few of them
                    if (Time == 0f && Distance == 0f)
                    {
                        // Instead of having it display "Avg Speed: NaN", we set it to 0
                        AvgSpeed = 0f;
                    }
                    else
                    {
                        // Multiply by 3.6f to get it to km/h. I'm happy it's not something stupid like 5.867847687f / 43 * 76.432f
                        AvgSpeed = Distance / Time * 3.6f;
                    }
                }
                else
                {
                    Time = 0f;
                    Distance = 0f;
                    AvgSpeed = 0f;
                }
            }
            else
            {
                Time = 0f;
                Distance = 0f;
                AvgSpeed = 0f;
                TotalCheckpoints = 0;
                CheckpointPassed = 0;
                TimerCheckpointPassed = 0;
            }
        }

        public void CheckMemory()
        {
            // Check if we have finished the time trial
            // updatedStats are there so we don't add values again
            if (Time != 0f && CheckpointPassed == TotalCheckpoints && TotalCheckpoints != 0 && updatedStats == false)
            {
                // Add values to the current stats list
                sessionStats.Add(new Stats(StretchId, Time, AvgSpeed, Distance));

                // Add to total stats and average stats too their list
                for (int i = 0; i < totalStats.Count(); i++)
                {
                    if (StretchId == totalStats[i].StretchId)
                    {
                        averageStats[i].Time += Time;
                        averageStats[i].Distance += Distance;
                        averageStats[i].AvgSpeed += AvgSpeed;
                        averageStats[i].Runs += 1;

                        totalStats[i].Time += Time;
                        totalStats[i].Distance += Distance;
                        totalStats[i].Runs += 1;
                        break;
                    }
                }

                updatedStats = true;
            }

            // Sets updatedStats to false once we start a time trial
            if (Time == 0f && CheckpointPassed != TotalCheckpoints && updatedStats == true)
            {
                updatedStats = false;
            }

            // Update if we passed a checkpoint
            if (CheckpointPassed - oldCheckpointPassed == 1)
            {
                for (int i = 0; i < totalStats.Count(); i++)
                {
                    if (StretchId == totalStats[i].StretchId)
                    {
                        sessionStats[i].CheckpointsPassed += 1;
                        totalStats[i].CheckpointsPassed += 1;

                        break;
                    }
                }
            }

            // Update if we passed a timed checkpoint
            if (TimerCheckpointPassed - oldTimerCheckpointPassed == 1)
            {
                for (int i = 0; i < totalStats.Count(); i++)
                {
                    if (StretchId == totalStats[i].StretchId)
                    {
                        sessionStats[i].TimerCheckpointsPassed += 1;
                        totalStats[i].TimerCheckpointsPassed += 1;
                        break;
                    }
                }
            }

            // Save current checkpoint to previous variables
            oldCheckpointPassed = CheckpointPassed;
            oldTimerCheckpointPassed = TimerCheckpointPassed;
        }

        public bool StatsExistsForStretchId()
        {
            if (StretchId == 0)
            {
                return false;
            }

            for (int i = 0; i < sessionStats.Count(); i++)
            {
                if (sessionStats[i].StretchId == StretchId)
                {
                    return true;
                }
            }

            // Add data to the different list stats
            sessionStats.Add(new Stats(StretchId, Time, AvgSpeed, Distance, CheckpointPassed, TimerCheckpointPassed, TotalCheckpoints));
            averageStats.Add(new Stats(StretchId, 0f, 0f, 0f));
            totalStats.Add(new Stats(StretchId, 0f, 0f, 0, 0, 0));

            return false;
        }

        public Stats GetCurrentStats()
        {
            return new Stats(StretchId, Time, AvgSpeed, Distance, CheckpointPassed, TimerCheckpointPassed, TotalCheckpoints);
        }

        public Stats GetBestStats()
        {
            float time = 69420f;
            float avgSpeed = 0f;
            float distance = 0f;

            for (int i = 0; i < sessionStats.Count(); i++)
            {
                if (sessionStats[i].StretchId == StretchId && sessionStats[i].Time != 0f)
                {
                    if (sessionStats[i].Time < time)
                    {
                        time = sessionStats[i].Time;
                        avgSpeed = sessionStats[i].AvgSpeed;
                        distance = sessionStats[i].Distance;
                    }
                }
            }

            if (time != 69420f)
            {
                return new Stats(time, avgSpeed, distance);
            }

            return new Stats(0f, 0f, 0f);
        }

        public Stats GetAverageStats()
        {
            int runs = 0;
            float time = 0;
            float avgSpeed = 0;
            float distance = 0;

            for (int i = 0; i < averageStats.Count(); i++)
            {
                if (averageStats[i].StretchId == StretchId)
                {
                    time = averageStats[i].Time;
                    avgSpeed = averageStats[i].AvgSpeed;
                    distance = averageStats[i].Distance;
                    runs = averageStats[i].Runs;
                    break;
                }
            }

            time /= runs;
            avgSpeed /= runs;
            distance /= runs;

            return new Stats(StretchId, time, avgSpeed, distance);
        }

        public Stats GetTotalStats()
        {
            float time = 0;
            float distance = 0;
            int passedCheckpoints = 0;
            int passedTimerCheckpoints = 0;
            int runs = 0;

            for (int i = 0; i < totalStats.Count(); i++)
            {
                if (totalStats[i].StretchId == StretchId)
                {
                    time = totalStats[i].Time;
                    distance = totalStats[i].Distance;
                    passedCheckpoints = totalStats[i].CheckpointsPassed;
                    passedTimerCheckpoints = totalStats[i].TimerCheckpointsPassed;
                    runs = totalStats[i].Runs;
                    break;
                }
            }

            return new Stats(time, distance, passedCheckpoints, passedTimerCheckpoints, runs);
        }
    }
}
