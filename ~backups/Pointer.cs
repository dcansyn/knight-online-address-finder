/*
2345-F2A39C
210208-E84C1C
2108-10131C0

KO_PTR_DLG=10DAF98
KO_PTR_CHR=10DAECC


Finder
4DEDD1 - 43BDFB
427294 - FFFDDA18
4DEDD1 - 4350EB
427254 - FFFDDD38
42AF3F - FFFF9CAD









*/

new Address(false, "KO_PTR_CHR",       "007516A1" ),
new Address(false, "KO_PTR_DLG",       "0075268B0D" ),
new Address(false, "KO_PTR_PKT",       "EA833D" ),
new Address(false, "KO_PTR_SND",       "6AFF68QQ64A10000000050", callOffset = 14,type:AddressType.Generate ),
new Address(false, "KO_FMBS",          start: 0x4E1000,       type:  AddressType.CallAdd,    Hex = "CCCCCCCCCC83ECXX5356578D71", callOffset = 0x8 ),
new Address(false, "KO_FPBS",          type:AddressType.CallAdd,    Hex = "83EC085356578D71XX8D44241850", callOffset = 0xE ),
new Address(false, "KO_FNC_ISEN",      start: 0x500000,       type:  AddressType.CallAdd,    Hex = "8B4424045051E8QQC2", callOffset = 0xC ),
new Address(false, "KO_PTR_SERVER",    "8BB424QQ33DB895C24XX8B0D" ),
new Address(false, "KO_OTO_LOGIN_PTR", "8B0DQQ6A00E8QQC3CCCC8B0D" ),
new Address(false, "KO_OTO_LOGIN_01",  type:AddressType.CallAdd,    Hex = "75XX837C24XXXX0F85QQQQXXXX85C974" ),
new Address(false, "KO_OTO_LOGIN_02",  type:AddressType.CallAdd,    Hex = "83ECXX53558BE933DB399D", callOffset = 0xB ),
new Address(false, "KO_OTO_LOGIN_03",  type:AddressType.CallAdd,    Hex = "CCCC558BE983BDQQXX0F84", callOffset = 0xC ),
new Address(false, "KO_OTO_LOGIN_04",  type:AddressType.CallAdd,    Hex = "0F8DQQ53555633DB33ED8DB7", callOffset = 0x1A  ),
new Address(false, "KO_OTO_BTN_PTR",   "6AXX8D5424XX5268QQ894C24XXE8QQA1" ),
new Address(false, "KO_BTN_LEFT",      type:AddressType.CallAdd,    Hex = "8B8EQQ89BEQQ8B018B50XX53FFD2", callOffset = 0x73  ),
new Address(false, "KO_BTN_RIGHT",     type:AddressType.CallAdd,    Hex = "E8QQ83C4XXC3CCCCCCCCCCCCCCCCCCCCCC6AXX68QQ64A1QQ5083EC", callOffset = 0x10 ),
new Address(false, "KO_BTN_LOGIN",     type:AddressType.CallAdd,    Hex = "566AXX8BF1E8QQA1", callOffset = 0xB ),
new Address(false, "KO_FLDB",          "8B8BQQ6A0089B9QQ8B0D" ),
new Address(false, "KO_FNCZ",          type:AddressType.CallAdd,    Hex = "83ECXXA1QQ5657", callOffset = 0xA ),
new Address(false, "KO_FNCB",          type:AddressType.CallAdd,    Hex = "C3CCCCCCCCCC83ECXXA1QQ5657", callOffset = 0xA ),
new Address(false, "KO_ITOB",          "0F84QQ8BBC24QQ8B0D" ),
new Address(false, "KO_ITEB",          "0F84QQ8BBC24QQ8B0D", Offset = 0x8 ),
new Address(false, "KO_ITEMFIND",      type:AddressType.Generate,   Hex = "83EC085356578D71XX8D442418508D4C2410518BCEE8QQ8B7C240C", callOffset = 0x25 ),
new Address(false, "KO_ITEMDESCALL",   type:AddressType.CallAdd,    Hex = "83ECXXA1QQ33C4894424XX568BF180BEQQXX0F84", callOffset = 0x1A ),
new Address(false, "KO_ITEMDES",       "3DQQ0F85QQ833D" ),
new Address(false, "KO_ITEMDES2",      "C605" ),
new Address(false, "KO_FAKE_ITEM",     start: 0x500000,       type:  AddressType.CallAdd,    Hex = "6AXX68QQ64A1QQ5051555657", callOffset = 0x12 ),
new Address(false, "KO_SUB_ADDR0",     start: 0x8C0000,       type:  AddressType.CallAdd,    Hex = "558BEC83E4XX6AXX68QQ64A1QQ50", callOffset = 0x14 ),
new Address(false, "KO_SUB_ADDR1",     start: 0x500000,       type:  AddressType.CallAdd,    Hex = "558BEC83E4XX81EC", callOffset = 0x8 ),
new Address(false, "KO_PTR_NRML",      "8B0D{0}8B81QQ8B0D", Base = "KO_PTR_CHR" ),
new Address(false, "KO_SMMB",          "8B15{0}8B0D", Base = "KO_PTR_CHR" ),
new Address(false, "KO_SMMB_FNC",      start: 0x500000,       type:  AddressType.Generate,   Hex = "83ECXX5356578D71XX8D4424XX508D4C24XX518BCE", callOffset = 0x25 ),
new Address(false, "KO_ROTA_START",    type:AddressType.CallAdd,    Hex = "83ECXX56578BF9E8QQ8B35{0}85F6", Base = "KO_PTR_DLG", callOffset = 0x14 ),
new Address(false, "KO_ROTA_STOP",     type:AddressType.CallAdd,    Hex = "83ECXX535556578BF98BXXQQ39XXQQ8DB7QQ7605", callOffset = 0x1D ),
new Address(false, "KO_DEATH_EFFECT",  type:AddressType.CallAdd,    Hex = "7AXX8B138B42186AFF6AFF", callOffset = 0xB ),
new Address(false, "KO_OFF_CLASS",     "8B15{0}8982", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_NT",        "8B0D{0}8BB1", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MOVE",      "8890QQA1{0}8890", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MOVEType",  "7AXX8B0D{0}8B81", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_GoX",       "5BA1{0}D986", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_GoZ",       "5BA1{0}D986", Base = "KO_PTR_CHR", Offset = 0x4 ),
new Address(false, "KO_OFF_GoY",       "5BA1{0}D986", Base = "KO_PTR_CHR", Offset = 0x8 ),
new Address(false, "KO_OFF_X",         "83ECXXA1{0}8B90", Base = "KO_PTR_CHR", Offset = -0x4 ),
new Address(false, "KO_OFF_Z",         "83ECXXA1{0}8B90", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_Y",         "83ECXXA1{0}8B90", Base = "KO_PTR_CHR", Offset = 0x4 ),
new Address(false, "KO_OFF_ID",        "A1{0}8B80", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_WH",        "8B0D{0}83B9", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MCOR",      "A1{0}C780QQQQ8B8424", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_PtBase",    "A1{0}3998", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_PtCount",   "751FA1{0}83B8", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_Pt",        "751BA1{0}83B8", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_MAXEXP",    "A1{0}8B90QQ6AXXXX8B90", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_EXP",       "A1{0}8B90QQ6AXXXX8B90", Base = "KO_PTR_CHR", Offset = 0x8 ),
new Address(false, "KO_OFF_MOB",       "0F8AQQ8B0D{0}0FB791", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_ZONE",      "751EA1{0}8B88", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_NAMELEN",   "A1{0}85C074XX83B8QQXX8B88", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_NAME",      "A1{0}85C074XX83B8QQXX8B88QQ72XX8B80", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_GOLD",      "A1{0}8B96QQ8B88", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MAXMP",     "5250E8QQA1{0}8B88", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MP",        "5250E8QQA1{0}8B88QQ8B90", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MAXHP",     "74XXE8QQA1{0}8B88", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_HP",        "74XXE8QQA1{0}8B88QQ8B90", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_LEVEL",     "B8QQ8B15{0}8B8A", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_POINTStat", "E8QQ0FBFD0A1{0}8990", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_StatSTR",   "A1{0}55578990", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_StatHP",    "A1{0}55578990", Base = "KO_PTR_CHR", Offset = 0x8 ),
new Address(false, "KO_OFF_StatDEX",   "A1{0}55578990", Base = "KO_PTR_CHR", Offset = 0x10 ),
new Address(false, "KO_OFF_StatINT",   "A1{0}55578990", Base = "KO_PTR_CHR", Offset = 0x18 ),
new Address(false, "KO_OFF_StatMP",    "A1{0}55578990", Base = "KO_PTR_CHR", Offset = 0x20 ),
new Address(false, "KO_OFF_ATTACK",    "A1{0}55578990", Base = "KO_PTR_CHR", Offset = 0x28 ),
new Address(false, "KO_OFF_DEFENCE",   "A1{0}55578990", Base = "KO_PTR_CHR", Offset = 0x30 ),
new Address(false, "KO_OFF_NP",        "A1{0}8B90QQ8B80", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MAXWEIGHT", "8B0D{0}55578981", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_WEIGHT",    "8B0D{0}55578981", Base = "KO_PTR_CHR", Offset = 0x8 ),
new Address(false, "KO_OFF_SBARBase",  "E8QQA1{0}83B8", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_BSkPoint",  "A1{0}8B88QQ6AXXE8QQ8B8E", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_SPoint1",   "A1{0}8B88QQ6AXXE8QQ8B8E", Base = "KO_PTR_DLG", Offset = 0x10 ),
new Address(false, "KO_OFF_SPoint2",   "A1{0}8B88QQ6AXXE8QQ8B8E", Base = "KO_PTR_DLG", Offset = 0x14 ),
new Address(false, "KO_OFF_SPoint3",   "A1{0}8B88QQ6AXXE8QQ8B8E", Base = "KO_PTR_DLG", Offset = 0x18 ),
new Address(false, "KO_OFF_SPoint4",   "A1{0}8B88QQ6AXXE8QQ8B8E", Base = "KO_PTR_DLG", Offset = 0x1C ),
new Address(false, "KO_OFF_ITEMB",     "E8QQ8BF0A1{0}8B88", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_ITEMS",     "0F85QQA1{0}3998", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_BANKB",     "A1AC24F20001A8QQC68424", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_BANKCONT",  "83ECXX578BF980BF" ),
new Address(false, "KO_OFF_SKILLBASE", "A1{0}0F85QQ83B8QQXX0F84QQ8B88", Base = "KO_PTR_DLG" ),
new Address(false, "KO_OFF_SKILLID",   "83ECXX53558BE98B85QQ8B8D" ),
new Address(false, "KO_OFF_SWIFT",     "8B35{0}8B96QQ2B96", Base = "KO_PTR_CHR" ),
new Address(false, "KO_OFF_MCORX",     "83C4XX89AC24QQ89BC24", Offset = -0x4 ),
new Address(false, "KO_OFF_MCORY",     "83C4XX89AC24QQ89BC24", Offset = 0x4 ),
new Address(false, "KO_OFF_MCORZ",     "83C4XX89AC24QQ89BC24"),
