namespace TimeTrialStats
{
    public class Offset
    {
        private Structure structure = new Structure();

        public void Add()
        {
            OffsetDataBase.Add(Version.Steam, structure.TimeTrial, 0x01BFBCA4, new int[] { 0x50, 0x1E0, 0x318 });
            OffsetDataBase.Add(Version.GoG, structure.TimeTrial, 0x01BFBCA4, new int[] { 0x50, 0x1E0, 0x318 });
            OffsetDataBase.Add(Version.Origin, structure.TimeTrial, 0x01C14D64, new int[] { 0x54, 0x1E0, 0x318 });
            OffsetDataBase.Add(Version.Reloaded, structure.TimeTrial, 0x01C14D5C, new int[] { 0x54, 0x1E0, 0x318 });
            OffsetDataBase.Add(Version.Dvd, structure.TimeTrial, 0x01C14D5C, new int[] { 0x54, 0x1E0, 0x318 });
        }
    }
}
