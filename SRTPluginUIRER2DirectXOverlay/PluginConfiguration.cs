namespace SRTPluginUIRER2DirectXOverlay
{
    public class PluginConfiguration
    {
        //public bool Debug { get; set; }
        //public bool NoInventory { get; set; }
        public bool ShowHPBars { get; set; }
        public bool ShowIGT { get; set; }
        public bool ShowBP { get; set; }
        //public bool ShowDifficultyAdjustment { get; set; }
        public float ScalingFactor { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public float EnemyHPPositionX { get; set; }
        public float EnemyHPPositionY { get; set; }

        //public float InventoryPositionX { get; set; }
        //public float InventoryPositionY { get; set; }
        public string BPString { get; set; }
        public string IGTString { get; set; }
        public string StringFontName { get; set; }
        //public string RankString { get; set; }
        //public string ScoreString { get; set; }
        public string PlayerString { get; set; }
        public string EnemyString { get; set; }

        public PluginConfiguration()
        {
            //Debug = false;
            //NoInventory = true;
            ShowHPBars = true;
            ShowIGT = true;
            ShowBP = true;
            //ShowDifficultyAdjustment = true;
            ScalingFactor = 1f;
            PositionX = 5f;
            PositionY = 10f;
            EnemyHPPositionX = -1;
            EnemyHPPositionY = -1;
            //InventoryPositionX = -1;
            //InventoryPositionY = -1;
            IGTString = "IGT:";
            BPString = "BP:";
            StringFontName = "Courier New";
            //RankString = "DA RANK:";
            //ScoreString = "DA SCORE:";
            PlayerString = "Player HP";
            EnemyString = "ENEMY HP";
        }
    }
}
