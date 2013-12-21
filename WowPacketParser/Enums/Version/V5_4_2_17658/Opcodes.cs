using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_2_17658
{
    public static class Opcodes_5_4_2
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x133F},
            {Opcode.CMSG_AREATRIGGER, 0x024C},
            {Opcode.CMSG_AUTH_SESSION, 0x196E},
            {Opcode.CMSG_CHANNEL_LIST, 0x0847},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x01AD},
            {Opcode.CMSG_CAST_SPELL, 0x0A57},
            {Opcode.CMSG_CHAR_CREATE, 0x077B},
            {Opcode.CMSG_CHAR_DELETE, 0x067A},
            {Opcode.CMSG_CHAR_ENUM, 0x047C},
            {Opcode.CMSG_CREATURE_QUERY, 0x0C4A},
            {Opcode.CMSG_DB_QUERY_BULK, 0x0676},
            {Opcode.CMSG_DUNGEON_FINDER_GET_SYSTEM_INFO, 0x05DA},
            {Opcode.CMSG_GOSSIP_HELLO, 0x02EF},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x0ECA},
            {Opcode.CMSG_GUILD_QUERY, 0x055C},
            {Opcode.CMSG_INSPECT, 0x0206},
            {Opcode.CMSG_LEARN_TALENT, 0x026C},
            {Opcode.CMSG_LOAD_SCREEN, 0x0650},
            {Opcode.CMSG_LOG_DISCONNECT, 0x19EA},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x0EE9},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x0243},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x0866},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x03AB},
            {Opcode.CMSG_NAME_QUERY, 0x05F4},
            {Opcode.CMSG_PET_NAME_QUERY, 0x0249},
            {Opcode.CMSG_PING, 0x18E2},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0754},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x047F},
            {Opcode.CMSG_REALM_NAME_QUERY, 0x0472},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0E43},
            {Opcode.CMSG_REDIRECT_AUTH_PROOF, 0x1262},
            {Opcode.CMSG_RESET_FACTION_CHEAT, 0x126E},
            {Opcode.CMSG_QUERY_WORLD_COUNTDOWN_TIMER, 0x08DD},
            {Opcode.CMSG_QUEST_NPC_QUERY, 0x0AB1},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x0D52},
            {Opcode.CMSG_QUEST_QUERY, 0x066D},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x0D5E},
            {Opcode.CMSG_SET_SELECTION, 0x0AC5},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x06AB},
            {Opcode.CMSG_UI_TIME_REQUEST, 0x0574},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x0448},
            {Opcode.CMSG_WARDEN_DATA, 0x0573},
            {Opcode.CMSG_WHO, 0x0CFD},

            {Opcode.MSG_MULTIPLE_PACKETS1, 0x0E48},
            {Opcode.MSG_MULTIPLE_PACKETS2, 0x006C},
            {Opcode.MSG_MULTIPLE_PACKETS3, 0x08BC},
            {Opcode.MSG_MULTIPLE_PACKETS4, 0x0A12},

            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_ACCOUNT, 0x08F2},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_PLAYER, 0x0E29},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0899},
            {Opcode.SMSG_ACTION_BUTTONS, 0x0E2C},
            {Opcode.SMSG_ADDON_INFO, 0x0A9C},
            {Opcode.SMSG_ARENA_SEASON_WORLD_STATE, 0x0240},
            {Opcode.SMSG_ATTACKSTART, 0x11C2},
            {Opcode.SMSG_ATTACKSTOP, 0x0861},
            {Opcode.SMSG_AURA_UPDATE, 0x0400},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0C42},
            {Opcode.SMSG_AUTH_RESPONSE, 0x03A8},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x024B},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x02FE},
            {Opcode.SMSG_CHAR_ENUM, 0x08B9},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x0A4C},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x1C04},
            {Opcode.SMSG_CHANNEL_START, 0x0034},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x0E85},
            {Opcode.SMSG_CHAR_CREATE, 0x0FAD},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0C6D},
            {Opcode.SMSG_CANCEL_AUTO_REPEAT, 0x0A76},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x085A},
            {Opcode.SMSG_CRITERIA_UPDATE_ACCOUNT, 0x0A64},
            {Opcode.SMSG_CRITERIA_UPDATE_PLAYER, 0x0C0D},
            {Opcode.SMSG_DB_REPLY, 0x089A},
            {Opcode.SMSG_DESTROY_OBJECT, 0x0A75},
            {Opcode.SMSG_EMOTE, 0x0A15},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x0F08},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x0839},
            {Opcode.SMSG_FORCE_SEND_QUEUED_PACKETS, 0x0C40},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x0269},
            {Opcode.SMSG_INITIAL_SPELLS, 0x0623},
            {Opcode.SMSG_INIT_CURRENCY, 0x0AF3},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x006B},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x0E88},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x08F3},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x1736},
            {Opcode.SMSG_GOSSIP_POI, 0x1D8D},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_DATA, 0x0586},
            {Opcode.SMSG_GUILD_NEWS_TEXT, 0x050A},
            {Opcode.SMSG_GUILD_RANK, 0x05AA},
            {Opcode.SMSG_GUILD_ROSTER, 0x050E},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x0502},
            {Opcode.SMSG_HOTFIX_INFO, 0x0A4B},
            {Opcode.SMSG_LEARNED_SPELL, 0x0C6E},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x0DA0},
            {Opcode.SMSG_LIST_INVENTORY, 0x0ADC},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x0044},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0ABF},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x004A},
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x0F2C},
            {Opcode.SMSG_MESSAGECHAT, 0x0A5B},
            {Opcode.SMSG_MOTD, 0x08BB},
            {Opcode.SMSG_MONSTER_MOVE, 0x0256},
            {Opcode.SMSG_NEW_WORLD, 0x0E04},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x0877},
            {Opcode.SMSG_PAGE_TEXT_QUERY_RESPONSE, 0x0EA4},
            {Opcode.SMSG_PERIODICAURALOG, 0x0515},
            {Opcode.SMSG_PLAYER_MOVE, 0x0EC4},
            {Opcode.SMSG_PONG, 0x0C46},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x116B}, 
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x1A6B},
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x0867},
            {Opcode.SMSG_REMOVED_SPELL, 0x0008},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x0C1D},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x06A0},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x0AD1},
            {Opcode.SMSG_SET_PROFICIENCY, 0x03AA},
            {Opcode.SMSG_SEND_SERVER_LOCATION, 0x038B},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x134B},
            {Opcode.SMSG_SPELL_GO, 0x003E},
            {Opcode.SMSG_SPELL_START, 0x069C},
            {Opcode.SMSG_SPELLHEALLOG, 0x0518},
            {Opcode.SMSG_SPELLNONMELEEDAMAGELOG, 0x0596},
            {Opcode.SMSG_SUSPEND_COMMS, 0x0645},
            {Opcode.SMSG_TALENTS_INFO, 0x0A79},
            {Opcode.SMSG_TEXT_EMOTE, 0x0AD9},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x0F05},
            {Opcode.SMSG_TRAINER_LIST, 0x026D},
            {Opcode.SMSG_TRANSFER_PENDING, 0x0819},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x138D},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x0C96},
            {Opcode.SMSG_UI_TIME, 0x12C6},
            {Opcode.SMSG_UPDATE_OBJECT, 0x1C89},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x0CA1},
            {Opcode.SMSG_WARDEN_DATA, 0x083E},
            {Opcode.SMSG_WEATHER, 0x0267},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x0419},
        };
    }
}
