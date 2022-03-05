using DiscordRPC;

namespace TimeTrialStats
{
    public class Discord
    {
        private DiscordRpcClient Client { get; set; }
        public string mapName;

        public Discord()
        {
            Client = new DiscordRpcClient("946792102061293598");
            Client.Initialize();
        }

        public void Update(int runsCompleted)
        {
            Client.SetPresence(new RichPresence()
            {
                Details = "Map: " + mapName,
                State = "Runs Finished: " + runsCompleted,
                Assets = new Assets()
                {
                    LargeImageKey = "logo"
                }
            });
        }

        public void Cleanup()
        {
            Client.Dispose();
        }

        public void Clear()
        {
            Client.ClearPresence();
        }
    }
}
