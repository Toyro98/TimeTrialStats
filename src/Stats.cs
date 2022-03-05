namespace TimeTrialStats
{
    public class Stats
    {
        public int StretchId { get; set; }
        public float Time { get; set; }
        public float AvgSpeed { get; set; }
        public float Distance { get; set; }

        public int Runs { get; set; }
        public int CheckpointsPassed { get; set; }
        public int TimerCheckpointsPassed { get; set; }
        public int TotalCheckpoints { get; set; }

        public Stats()
        {
            StretchId = 0;
            Time = 0f;
            AvgSpeed = 0f;
            Distance = 0f;

            Runs = 0;
            CheckpointsPassed = 0;
            TimerCheckpointsPassed = 0;
            TotalCheckpoints = 0;
        }

        public Stats(float time, float distance, int passedCheckpoints, int passedTimerCheckpoints, int runs)
        {
            Time = time;
            Distance = distance;
            CheckpointsPassed = passedCheckpoints;
            TimerCheckpointsPassed = passedTimerCheckpoints;
            Runs = runs;
        }

        public Stats(float time, float avgSpeed, float distance)
        {
            Time = time;
            AvgSpeed = avgSpeed;
            Distance = distance;
        }

        public Stats(int stretchId, float time, float avgSpeed, float distance)
        {
            StretchId = stretchId;
            Time = time;
            AvgSpeed = avgSpeed;
            Distance = distance;
        }

        public Stats(int stretchId, float time, float avgSpeed, float distance, int runs)
        {
            StretchId = stretchId;
            Time = time;
            AvgSpeed = avgSpeed;
            Distance = distance;
            Runs = runs;
        }

        public Stats(int stretchId, float time, float distance, int passedCheckpoints, int passedTimerCheckpoints, int runs)
        {
            StretchId = stretchId;
            Time = time;
            Distance = distance;
            CheckpointsPassed = passedCheckpoints;
            TimerCheckpointsPassed = passedTimerCheckpoints;
            Runs = runs;
        }

        public Stats(int stretchId, float time, float avgSpeed, float distance, int passedCheckpoints, int passedTimerCheckpoints, int totalCheckpoints)
        {
            StretchId = stretchId;
            Time = time;
            AvgSpeed = avgSpeed;
            Distance = distance;

            CheckpointsPassed = passedCheckpoints;
            TimerCheckpointsPassed = passedTimerCheckpoints;
            TotalCheckpoints = totalCheckpoints;
        }
    }
}
