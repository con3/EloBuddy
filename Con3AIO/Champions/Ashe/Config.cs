using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Con3AIO.Champions.Ashe
{
    public static class Config
    {
        private const string MenuName = "Con3Ashe";
        private static readonly Menu Menu;

        static Config()
        {
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("Con3Ashe in Beta!");
            Menu.AddLabel("This addon is under tests, please be patient and");
            Menu.AddLabel("report any issues to Con3. (con3@outlook.com)");
        }

        public static void Initialize() { }

        public static class Modes
        {
            private static readonly Menu Menu;

            static Modes()
            {
                Menu = Config.Menu.AddSubMenu("Modes");
                Combo.Initialize();
                Menu.AddSeparator();
                Harass.Initialize();
                Menu.AddSeparator();
                LaneClear.Initialize();
                Menu.AddSeparator();
            }

            public static void Initialize() { }

            public static class Combo
            {
                private static readonly CheckBox _useQ;
                private static readonly Slider _manaQ;
                private static readonly CheckBox _useW;
                private static readonly Slider _manaW;
                private static readonly CheckBox _useR;
                private static readonly Slider _manaR;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }

                public static int ManaQ
                {
                    get { return _manaQ.CurrentValue; }
                }

                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }

                public static int ManaW
                {
                    get { return _manaW.CurrentValue; }
                }

                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }

                public static int ManaR
                {
                    get { return _manaR.CurrentValue; }
                }

                static Combo()
                {
                    Menu.AddGroupLabel("Combo");
                    _useQ = Menu.Add("comboUseQ", new CheckBox("Use Q", true));
                    _manaQ = Menu.Add("comboManaQ", new Slider("Mana to Use Q (%): ", 40, 0, 100));
                    _useW = Menu.Add("comboUseW", new CheckBox("Use W", true));
                    _manaQ = Menu.Add("comboManaW", new Slider("Mana to Use W (%): ", 40, 0, 100));
                    _useR = Menu.Add("comboUseR", new CheckBox("Use R", true));
                    _manaQ = Menu.Add("comboManaR", new Slider("Mana to Use R (%): ", 40, 0, 100));
                }

                public static void Initialize() { }
            }

            public static class Harass
            {
                private static readonly CheckBox _useQ;
                private static readonly Slider _manaQ;
                private static readonly CheckBox _useW;
                private static readonly Slider _manaW;
                private static readonly CheckBox _useR;
                private static readonly Slider _manaR;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }

                public static int ManaQ
                {
                    get { return _manaQ.CurrentValue; }
                }

                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }

                public static int ManaW
                {
                    get { return _manaW.CurrentValue; }
                }

                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }

                public static int ManaR
                {
                    get { return _manaR.CurrentValue; }
                }

                static Harass()
                {
                    Menu.AddGroupLabel("Harass");
                    _useQ = Menu.Add("harassUseQ", new CheckBox("Use Q", true));
                    _manaQ = Menu.Add("harassManaQ", new Slider("Mana to Use Q (%): ", 40, 0, 100));
                    _useW = Menu.Add("harassUseW", new CheckBox("Use W", true));
                    _manaQ = Menu.Add("harassManaW", new Slider("Mana to Use W (%): ", 40, 0, 100));
                    _useR = Menu.Add("harassUseR", new CheckBox("Use R", false));
                    _manaQ = Menu.Add("harassManaR", new Slider("Mana to Use R (%): ", 40, 0, 100));
                }

                public static void Initialize() { }
            }

            public static class LaneClear
            {
                private static readonly CheckBox _useQ;
                private static readonly Slider _manaQ;
                private static readonly CheckBox _useW;
                private static readonly Slider _manaW;
                private static readonly CheckBox _useR;
                private static readonly Slider _manaR;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }

                public static int ManaQ
                {
                    get { return _manaQ.CurrentValue; }
                }

                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }

                public static int ManaW
                {
                    get { return _manaW.CurrentValue; }
                }

                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }

                public static int ManaR
                {
                    get { return _manaR.CurrentValue; }
                }

                static LaneClear()
                {
                    Menu.AddGroupLabel("Lane Clear");
                    _useQ = Menu.Add("laneClearUseQ", new CheckBox("Use Q", false));
                    _manaQ = Menu.Add("laneClearManaQ", new Slider("Mana to Use Q (%): ", 40, 0, 100));
                    _useW = Menu.Add("laneClearUseW", new CheckBox("Use W", true));
                    _manaQ = Menu.Add("laneClearManaW", new Slider("Mana to Use W (%): ", 40, 0, 100));
                    _useR = Menu.Add("laneClearUseR", new CheckBox("Use R", false));
                    _manaQ = Menu.Add("laneClearManaR", new Slider("Mana to Use R (%): ", 40, 0, 100));
                }

                public static void Initialize() { }
            }
        }
    }
}
