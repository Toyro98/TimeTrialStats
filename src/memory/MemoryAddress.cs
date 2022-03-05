using System.Linq;

namespace TimeTrialStats
{
    public class MemoryAddress
    {
        public uint target;
        public uint baseAddress;
        public uint pointer;
        public int[] offsets;

        public MemoryAddress(StructureBase structure, int offset)
        {
            pointer = OffsetDataBase.GetPointer(structure);
            int[] offsetsBase = OffsetDataBase.GetOffsets(structure);
            offsets = offsetsBase.Concat(new int[] { offset }).ToArray();
        }

        public void Update(MemoryHelper memoryHelper)
        {
            baseAddress = memoryHelper.GetBaseAddress(pointer);
            target = MemoryUtils.OffsetCalculator(memoryHelper, baseAddress, offsets);
        }
    }
}
