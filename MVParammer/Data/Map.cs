namespace MVParammer.Data
{
    public class Map
    {
        public bool autoplayBgm { get; set; }
        public bool autoplayBgs { get; set; }
        public string battleback1Name { get; set; }
        public string battleback2Name { get; set; }
        public SoundSettings bgm { get; set; }
        public SoundSettings bgs { get; set; }
        public bool disableDashing { get; set; }
        public string displayName { get; set; }
        public int[] encounterList { get; set; }
        public int encounterStep { get; set; }
        public int height { get; set; }
        public string note { get; set; }
        public bool parallaxLoopX { get; set; }
        public bool parallaxLoopY { get; set; }
        public string parallaxName { get; set; }
        public bool parallaxShow { get; set; }
        public int parallaxSx { get; set; }
        public int parallaxSy { get; set; }
        public int scrollType { get; set; }
        public bool specifyBattleback { get; set; }
        public int tilesetId { get; set; }
        public int width { get; set; }
        public int[] data { get; set; }
        public Event[] events { get; set; }
    }
}
