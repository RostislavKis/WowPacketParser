﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V6_0_2_19033.Parsers
{
    public static class ArchaelogyHandler
    {
        [Parser(Opcode.SMSG_RESEARCH_SETUP_HISTORY)]
        public static void HandleResearchSetupHistory(Packet packet)
        {
            var count = packet.ReadInt32("ResearchHistoryCount");

            for (int i = 0; i < count; ++i)
            {
                packet.ReadInt32("ProjectID", i);
                packet.ReadTime("FirstCompleted", i);
                packet.ReadInt32("CompletionCount", i);
            }
        }

        [Parser(Opcode.SMSG_ARCHAEOLOGY_SURVERY_CAST)]
        public static void HandleArchaelogySurveryCast(Packet packet)
        {
            packet.ReadUInt32("TotalFinds");
            packet.ReadUInt32("NumFindsCompleted");
            packet.ReadInt32("ResearchBranchID");
            packet.ReadBit("SuccessfulFind");
        }
    }
}
