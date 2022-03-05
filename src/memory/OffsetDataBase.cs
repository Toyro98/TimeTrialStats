using System;
using System.Collections.Generic;

namespace TimeTrialStats
{
    public static class OffsetDataBase
    {
        private static List<Data> data = new List<Data>();

        public static void Add(Version version, StructureBase name, uint pointer, int[] offset)
        {
            data.Add(new Data(version, name, pointer, offset));
        }

        public static int[] GetOffsets(StructureBase structure)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Version == GameVersion.Current && data[i].Structure.Name == structure.GetType().Name)
                {
                    return data[i].Offsets;
                }
            }

            return null;
        }

        public static uint GetPointer(StructureBase structure)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Version == GameVersion.Current && data[i].Structure.Name == structure.GetType().Name)
                {
                    return data[i].Pointer;
                }
            }

            return 0;
        }

        private class Data
        {
            public Version Version;
            public Type Structure;
            public uint Pointer;
            public int[] Offsets;

            public Data(Version version, StructureBase name, uint pointer, int[] offsets)
            {
                Version = version;
                Structure = name.GetType();
                Pointer = pointer;
                Offsets = offsets;
            }
        }
    }
}