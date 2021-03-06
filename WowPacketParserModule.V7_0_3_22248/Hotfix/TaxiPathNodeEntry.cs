using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V7_0_3_22248.Hotfix
{
    [HotfixStructure(DB2Hash.TaxiPathNode)]
    public class TaxiPathNodeEntry
    {
        [HotfixArray(3)]
        public float[] Loc { get; set; }
        public uint Delay { get; set; }
        public ushort PathID { get; set; }
        public ushort MapID { get; set; }
        public ushort ArrivalEventID { get; set; }
        public ushort DepartureEventID { get; set; }
        public byte NodeIndex { get; set; }
        public byte Flags { get; set; }
        public uint ID { get; set; }
    }
}