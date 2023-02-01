namespace Auto
{
    public class Auto
    {
        public int Ps { get; }
        public int Startnummer { get; }
        public int Geschwindigkeit { get; set; }

        public Auto(int ps, int sn, int ge)
        {
            this.Ps = ps;
            this.Startnummer = sn;
            this.Geschwindigkeit = ge;
        }
    }
}
