﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO.Helpers
{
    public class GameHelper : WinApiHelper
    {
        static readonly int DefaultStart = 0x401000;
        static readonly int DefaultLength = 0x5B2000;
        public List<Models.AddressItem> Addresses = new List<Models.AddressItem>()
        {
            #region [Pointer]
            new Models.AddressItem(){ Active = true, Name = "KO_PTR_CHR",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "CC8BC18B0D" },
            new Models.AddressItem(){ Active = true, Name = "KO_PTR_DLG",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B1DXXXXXXXX906AXXFFD7A1" },
            new Models.AddressItem(){ Active = true, Name = "KO_PTR_PKT",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "68XXXXXXXXFF15XXXXXXXX3B2D" },
            new Models.AddressItem(){ Active = true, Name = "KO_SND_FNC",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "68XXXXXXXXFF15XXXXXXXX3B2D", CallOffset = 0x6D },
            new Models.AddressItem(){ Active = true, Name = "KO_FMBS",             Start = 0x4E1000,       Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "CCCCCCCCCC83ECXX5356578D71", CallOffset = 0x8 },
            new Models.AddressItem(){ Active = true, Name = "KO_FPBS",             Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "83EC085356578D71XX8D44241850", CallOffset = 0xE },
            new Models.AddressItem(){ Active = true, Name = "KO_FNC_ISEN",         Start = 0x500000,       Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "8B4424045051E8XXXXXXXXC2", CallOffset = 0xC },
            new Models.AddressItem(){ Active = true, Name = "KO_CHR_SERV",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8BB424XXXXXXXX33DB895C24XX8B0D" },
            new Models.AddressItem(){ Active = true, Name = "KO_OTO_LOGIN_PTR",    Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0DXXXXXXXX6A00E8XXXXXXXXC3CCCC8B0D" },
            new Models.AddressItem(){ Active = true, Name = "KO_OTO_LOGIN_01",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "75XX837C24XXXX0F85XXXXXXXXXXXXXXXXXXXX85C974" },
            new Models.AddressItem(){ Active = true, Name = "KO_OTO_LOGIN_02",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "83ECXX538BD983BBXXXXXXXXXX0F84XXXXXXXX8B83", CallOffset = 0x15 },
            new Models.AddressItem(){ Active = true, Name = "KO_OTO_LOGIN_03",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "558BE983BDXXXXXXXXXX0F84", CallOffset = 0xC },
            new Models.AddressItem(){ Active = true, Name = "KO_OTO_LOGIN_04",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "837C24XXXX53568BF1", CallOffset = 0x9 },
            new Models.AddressItem(){ Active = true, Name = "KO_OTO_BTN_PTR",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "6AXX8D5424XX5268XXXXXXXX894C24XXE8XXXXXXXXA1" },
            new Models.AddressItem(){ Active = true, Name = "KO_BTN_LEFT",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "E8XXXXXXXX81C4XXXXXXXXC2XXXX6AXX68XXXXXXXX64A1000000005083EC20A1XXXXXXXX33C4", CallOffset = 0x18 },
            new Models.AddressItem(){ Active = true, Name = "KO_BTN_RIGHT",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "E8XXXXXXXX83C4XXC3CCCCCCCCCCCCCCCCCCCCCC6AXX68XXXXXXXX64A1XXXXXXXX5083EC", CallOffset = 0x10 },
            new Models.AddressItem(){ Active = true, Name = "KO_FLDB",             Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "5356578BF98B0D" },
            new Models.AddressItem(){ Active = true, Name = "KO_FNCZ",             Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "83ECXXA1XXXXXXXX5657", CallOffset = 0xA },
            new Models.AddressItem(){ Active = true, Name = "KO_FNCB",             Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "C3CCCCCCCCCC83ECXXA1XXXXXXXX5657", CallOffset = 0xA },
            new Models.AddressItem(){ Active = true, Name = "KO_ITOB",             Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "0F84XXXXXXXX8BBC24XXXXXXXX8B0D" },
            new Models.AddressItem(){ Active = true, Name = "KO_ITEB",             Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "0F84XXXXXXXX8BBC24XXXXXXXX8B0D", PointerOffset = 0x8 },
            new Models.AddressItem(){ Active = true, Name = "KO_RECV_PTR",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Generate },
            new Models.AddressItem(){ Active = true, Name = "KO_RECV_FNC",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Generate },
            new Models.AddressItem(){ Active = true, Name = "KO_ITEMFIND",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Generate,   Hex = "83EC085356578D711C8D442418508D4C2410518BCEE8XXXXXXXX8B7C240C8B5E188B3685FF", CallOffset = 0x25 },
            new Models.AddressItem(){ Active = true, Name = "KO_ITEMDESCALL",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "83ECXXA1XXXXXXXX33C4894424XX568BF180BEXXXXXXXXXX0F84", CallOffset = 0x1A },
            new Models.AddressItem(){ Active = true, Name = "KO_ITEMDES",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "3DXXXXXXXX0F85XXXXXXXX833D" },
            new Models.AddressItem(){ Active = true, Name = "KO_ITEMDES2",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0DXXXXXXXXE8XXXXXXXX5FC605" },
            new Models.AddressItem(){ Active = true, Name = "KO_FAKE_ITEM",        Start = 0x500000,       Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "6AXX68XXXXXXXX64A1XXXXXXXX5051555657", CallOffset = 0x12 },
            new Models.AddressItem(){ Active = true, Name = "KO_SUB_ADDR0",        Start = 0x8C0000,       Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "558BEC83E4XX6AXX68XXXXXXXX64A1XXXXXXXX50", CallOffset = 0x14 },
            new Models.AddressItem(){ Active = true, Name = "KO_SUB_ADDR1",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "558BEC83E4XX81EC", CallOffset = 0x8 },
            new Models.AddressItem(){ Active = true, Name = "KO_PTR_NRML",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0D{0}8B81XXXXXXXX8B0D", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_SMMB",             Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B15{0}8B0D", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_SMMB_FNC",         Start = 0x500000,       Length = DefaultLength, Type = Enums.AddressType.Generate,   Hex = "83ECXX5356578D71XX8D4424XX508D4C24XX518BCEE8XXXXXXXX8B7C24XX8B5EXX8B3685FF", CallOffset = 0x25 },
            new Models.AddressItem(){ Active = true, Name = "KO_ROTA_START",       Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "83ECXX56578BF9E8XXXXXXXX8B35{0}85F6", BasePointer = "KO_PTR_DLG", CallOffset = 0x14 },
            new Models.AddressItem(){ Active = true, Name = "KO_ROTA_STOP",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "83EC08535556578BF98BAFXXXXXXXX39AFXXXXXXXX8DB7", CallOffset = 0x17 },
            new Models.AddressItem(){ Active = true, Name = "KO_DEATH_EFFECT",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.CallAdd,    Hex = "7AXX8B138B42XX6AXX6AXX565656", CallOffset = 0xE  },
            #endregion
            #region [Offset]
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_CLASS",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B15{0}8982", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_NT",           Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0D{0}8BB1", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MOVE",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8890XXXXXXXXA1{0}8890", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MOVEType",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "D998XXXXXXXX8B0D{0}83B9", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_GoX",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "5BA1{0}D986", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_GoZ",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "5BA1{0}D986", BasePointer = "KO_PTR_CHR", PointerOffset = 0x4 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_GoY",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "5BA1{0}D986", BasePointer = "KO_PTR_CHR", PointerOffset = 0x8 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_X",            Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83ECXXA1{0}8B90", BasePointer = "KO_PTR_CHR", PointerOffset = -0x4 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_Z",            Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83ECXXA1{0}8B90", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_Y",            Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83ECXXA1{0}8B90", BasePointer = "KO_PTR_CHR", PointerOffset = 0x4 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_ID",           Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}83C4XX05", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_WH",           Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0D{0}83B9", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MCOR",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0D{0}E8XXXXXXXX8BCE89BE", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_PtBase",       Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}3998", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_PtCount",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "751FA1{0}83B8", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_Pt",           Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "751BA1{0}83B8", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MAXEXP",       Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B90XXXXXXXX6AXXXX8B90", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_EXP",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B90XXXXXXXX6AXXXX8B90", BasePointer = "KO_PTR_CHR", PointerOffset = 0x8 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MOB",          Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "0F8AXXXXXXXX8B0D{0}0FB791", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_ZONE",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "751EA1{0}8B88", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_NAMELEN",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}85C074XX83B8XXXXXXXXXX8B88", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_NAME",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}85C074XX83B8XXXXXXXXXX8B88XXXXXXXX72XX8B80", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_GOLD",         Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}83B8XXXXXXXXXX7DXX81B8", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MAXMP",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "5250E8XXXXXXXXA1{0}8B88", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MP",           Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "5250E8XXXXXXXXA1{0}8B88XXXXXXXX8B90", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MAXHP",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "74XXE8XXXXXXXXA1{0}8B88", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_HP",           Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "74XXE8XXXXXXXXA1{0}8B88XXXXXXXX8B90", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_LEVEL",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "B8XXXXXXXX8B15{0}8B8A", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_POINTStat",    Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "E8XXXXXXXX0FBFD0A1{0}8990", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_StatSTR",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}55578990", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_StatHP",       Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}55578990", BasePointer = "KO_PTR_CHR", PointerOffset = 0x8 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_StatDEX",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}55578990", BasePointer = "KO_PTR_CHR", PointerOffset = 0x10 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_StatINT",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}55578990", BasePointer = "KO_PTR_CHR", PointerOffset = 0x18 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_StatMP",       Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}55578990", BasePointer = "KO_PTR_CHR", PointerOffset = 0x20 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_ATTACK",       Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}55578990", BasePointer = "KO_PTR_CHR", PointerOffset = 0x28 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_DEFENCE",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}55578990", BasePointer = "KO_PTR_CHR", PointerOffset = 0x30 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_NP",           Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B90XXXXXXXX8B80", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MAXWEIGHT",    Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0D{0}55578981", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_WEIGHT",       Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "8B0D{0}55578981", BasePointer = "KO_PTR_CHR", PointerOffset = 0x8 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SBARBase",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "E8XXXXXXXXA1{0}83B8", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_BSkPoint",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B88XXXXXXXX6AXXE8XXXXXXXX8B8E", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SPoint1",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B88XXXXXXXX6AXXE8XXXXXXXX8B8E", BasePointer = "KO_PTR_DLG", PointerOffset = 0x10 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SPoint2",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B88XXXXXXXX6AXXE8XXXXXXXX8B8E", BasePointer = "KO_PTR_DLG", PointerOffset = 0x14 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SPoint3",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B88XXXXXXXX6AXXE8XXXXXXXX8B8E", BasePointer = "KO_PTR_DLG", PointerOffset = 0x18 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SPoint4",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}8B88XXXXXXXX6AXXE8XXXXXXXX8B8E", BasePointer = "KO_PTR_DLG", PointerOffset = 0x1C },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_ITEMB",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "E8XXXXXXXX8BF0A1{0}8B88", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_ITEMS",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "0F85XXXXXXXXA1{0}3998", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_BANKB",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "56E8XXXXXXXX8B85XXXXXXXXC78485" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_BANKCONT",     Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83ECXX578BF980BF" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SKILLBASE",    Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}0F85XXXXXXXX83B8XXXXXXXXXX0F84XXXXXXXX8B88", BasePointer = "KO_PTR_DLG" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SKILLID",      Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83ECXX53558BE98B85XXXXXXXX8B8D" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_SWIFT",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "A1{0}C605XXXXXXXXXXD998", BasePointer = "KO_PTR_CHR" },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MCORX",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83C4XX89AC24XXXXXXXX89BC24", PointerOffset = -0x4 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MCORY",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83C4XX89AC24XXXXXXXX89BC24", PointerOffset = 0x4 },
            new Models.AddressItem(){ Active = true, Name = "KO_OFF_MCORZ",        Start = DefaultStart,   Length = DefaultLength, Type = Enums.AddressType.Pointer,    Hex = "83C4XX89AC24XXXXXXXX89BC24" },

            #endregion
        };

        public IntPtr Handle { get; set; }
        public string Title { get; set; }
        public Enums.PlatformType Platform { get; set; }
        public GameHelper(string _title, Enums.PlatformType _platform)
        {
            Title = _title;
            Platform = _platform;

            GetWindowThreadProcessId(FindWindow(null, Title), out int pid);
            Handle = OpenProcess(ProcessAccessFlags.All, false, pid);
        }

        private string Hex(int value)
        {
            return value.ToString("x2").ToUpper();
        }
        static public string TranslateHex(string val)
        {
            return val?.Length != 6 ? "" : $"{val.Substring(4, 2)}{val.Substring(2, 2)}{val.Substring(0, 2)}00";
        }
        private int GetAddress(int _address)
        {
            UInt32 ret;
            try
            {
                ReadProcessMemory(Handle, (IntPtr)_address, out ret, (UInt32)4, new IntPtr());
            }
            catch (Exception)
            {
                ret = 0;
            }
            return (int)ret;
        }
        private List<string> GetHexArrayToString(string text)
        {
            if (text.Length % 2 != 0)
                return null;
            var lst = new List<string>();
            for (int i = 0; i < text.Length / 2; i++)
            {
                var val = text.Substring(i * 2, 2);
                lst.Add(val.ToUpper());
            }
            return lst;
        }
        private byte[] GetByteArrayToString(string text)
        {
            var tmpbyte = new byte[text.Length / 2];
            var count = 0;
            for (int i = 0; i < text.Length; i += 2)
            {
                var val = byte.MinValue;
                try { val = byte.Parse(text.Substring(i, 2), System.Globalization.NumberStyles.HexNumber); } catch (Exception) { }
                tmpbyte[count] = val;
                count++;
            }
            return tmpbyte;
        }
        private List<string> GetAddressHexArray(int address, int length)
        {
            var buffer = new byte[length];
            ReadProcessMemory(Handle, new IntPtr(address), buffer, (UInt32)length, out IntPtr ptrBytesRead);
            return buffer.Select(x => x.ToString("x2").ToUpper()).ToList();
        }
        private byte[] GetAddressByteArray(int address, int length)
        {
            var buffer = new byte[length];
            ReadProcessMemory(Handle, new IntPtr(address), buffer, (UInt32)length, out IntPtr ptrBytesRead);
            return buffer;
        }
        private int FindAddress(string hexAddress, int start, int length)
        {
            if (string.IsNullOrEmpty(hexAddress) || start <= 0 || length <= 0)
                return 0;

            var hexAddresses = GetByteArrayToString(hexAddress);
            for (int k = start; k < (start + length); k += 0x1000)
            {
                var addresses = GetAddressByteArray(k, 0x1000);
                for (int i = 0; i < addresses.Length; i++)
                {
                    if (addresses[i] == hexAddresses[0])
                    {
                        var matchAddress = true;
                        for (int j = 0; j < hexAddresses.Length; j++)
                        {
                            var key = hexAddress.Substring(j * 2, 2);
                            if (key != "XX" && (i + j >= addresses.Length || addresses[i + j] != hexAddresses[j]))
                            {
                                matchAddress = false;
                                break;
                            }
                        }
                        if (matchAddress)
                            return k + i;
                    }
                }
            }
            return 0;
        }
        private int FindAddressByHex(string hexAddress, int start, int length)
        {
            var hexAddresses = GetHexArrayToString(hexAddress).ToList();
            for (int k = start; k < (start + length); k += 0x1000)
            {
                var addresses = GetAddressHexArray(k, 0x1000).ToList();
                for (int i = 0; i < addresses.Count; i++)
                {
                    if (addresses[i] == hexAddresses[0])
                    {
                        var matchAddress = true;
                        for (int j = 0; j < hexAddresses.Count; j++)
                        {
                            var key = hexAddresses[j];
                            if (key != "XX" && (i + j >= addresses.Count || addresses[i + j] != key))
                            {
                                matchAddress = false;
                                break;
                            }
                        }
                        if (matchAddress)
                            return k + i;
                    }
                }
            }
            return 0;
        }
        
        public List<Models.AddressItem> SearchAddresses()
        {
            foreach (var address in Addresses)
            {
                Application.DoEvents();
                if (address.Active)
                {
                    // Address Type
                    switch (address.Type)
                    {
                        case Enums.AddressType.Pointer:
                        case Enums.AddressType.CallAdd:
                            switch (address.Name)
                            {
                                case "KO_FPBS":
                                    var fmbsResult = Addresses.Where(x => x.Name == "KO_FMBS").SingleOrDefault();
                                    address.Start = fmbsResult != null ? fmbsResult.Value : 0;
                                    break;
                                case "KO_OTO_LOGIN_01":
                                    address.CallOffset = Platform == Enums.PlatformType.USKO ? 0x22 : 0x20;
                                    break;
                                case "KO_OFF_MCORX":
                                case "KO_OFF_MCORY":
                                case "KO_OFF_MCORZ":
                                    var offMCorResult = Addresses.Where(x => x.Name == "KO_OFF_MCOR").SingleOrDefault();
                                    address.Start = offMCorResult != null ? offMCorResult.Value : 0; 
                                    break;
                            }

                            var basePointer = !string.IsNullOrEmpty(address.BasePointer) ? TranslateHex(Addresses.Where(x => x.Name == address.BasePointer).SingleOrDefault()?.Pointer) : "";
                            address.Hex = string.Format(address.Hex, basePointer);
                            address.Value = FindAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                            address.Call = Hex(address.Value - address.CallOffset);
                            address.Pointer = address.Type == Enums.AddressType.Pointer ? Hex(GetAddress(address.Value) + address.PointerOffset) : address.Call;
                            break;
                        case Enums.AddressType.Generate:
                            // DLG
                            var dlgResult = Addresses.Where(x => x.Name == "KO_PTR_DLG").SingleOrDefault();
                            switch (address.Name)
                            {
                                case "KO_RECV_PTR":
                                    address.Value = FindAddress(dlgResult.Hex, dlgResult.Start, dlgResult.Length) + dlgResult.Hex.Length / 2;
                                    address.Value = GetAddress(GetAddress(GetAddress(address.Value) - 0x14)) + 0x8;
                                    address.Call = Hex(address.Value);
                                    address.Pointer = Hex(address.Value);
                                    break;
                                case "KO_RECV_FNC":
                                    address.Value = FindAddress(dlgResult.Hex, dlgResult.Start, dlgResult.Length) + dlgResult.Hex.Length / 2;
                                    address.Value = GetAddress(GetAddress(GetAddress(address.Value) - 0x14)) + 0x8;
                                    address.Call = Hex(address.Value);
                                    address.Pointer = Hex(GetAddress(address.Value));
                                    break;
                                case "KO_ITEMFIND":
                                    // 10 tane aynı fonksiyon var.
                                    for (int i = 0; i < 9; i++)
                                    {
                                        address.Value = FindAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                                        address.Call = Hex(address.Value - address.CallOffset);
                                        address.Pointer = address.Call;
                                        address.Start = address.Value;
                                    }
                                    break;
                                case "KO_SMMB_FNC":
                                    // 7 tane aynı fonksiyon var.
                                    for (int i = 0; i < 7; i++)
                                    {
                                        address.Value = FindAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                                        address.Call = Hex(address.Value - address.CallOffset);
                                        address.Pointer = address.Call;
                                        address.Start = address.Value;
                                    }
                                    break;
                                default: break;
                            }
                            break;
                    }
                }
            }
            return Addresses;
        }
    }
}
