namespace SSPT_Calculator.Models
{
    public class TestInfo
    {
        //Initial Test Info
        public int weight { get; set; } //usually 185 lbs
        public int pax { get; set; }
        public int paxWeight { get; set; } //total weight of passengers
        public int crew { get; set; }
        public int crewWeight { get; set; }
        public string routeCOI { get; set; } //oceans, coastwise, limited CW, lakes/bays/sounds, rivers
        public string routeStability { get; set; } //exposed, partially protected, protected

        //VCGR
        public int paxStand { get; set; }
        public int paxSit { get; set; }
        public int vcgr { get; set; }

        //Weight by deck variables
        public int decks { get; set; }
        public int paxUpper { get; set; }
        public int upCheck { get; set; }
        public int weightUpper { get; set; }
        public int weightMain { get; set; }

        //Vessel Dimension Values
        public int loa { get; set; }
        public int lr { get; set; }
        public int fb { get; set; }
        public int fs { get; set; }
        public int bf { get; set; }
        public int b { get; set; }
        public int bp { get; set; }
        public int f { get; set; }
        public int fg { get; set; }
        public int d { get; set; }

    }
}