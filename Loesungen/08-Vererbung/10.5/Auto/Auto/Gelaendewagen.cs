namespace Auto
{
    public class Gelaendewagen : Auto
    {
        public bool Allradantrieb { get; }

        public Gelaendewagen(int ps, int sn, int ge, bool aa) : base(ps, sn, ge)
        {
            this.Allradantrieb = aa;
        }
    }
}
