namespace TimeTrialStats
{
    public abstract class StructureBase {}

    public class Structure 
    {
        public TdSPTimeTrialGame TimeTrial;

        public Structure()
        {
            TimeTrial = new TdSPTimeTrialGame();
        }
    }
}
