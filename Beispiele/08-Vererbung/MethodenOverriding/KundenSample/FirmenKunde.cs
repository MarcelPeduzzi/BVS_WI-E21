namespace KundenSample
{
    public class FirmenKunde : Kunde
    {
        private const decimal mwst = (decimal)0.19;  // Mehrwertsteuer

        public string Firma { get; set; }

        public FirmenKunde(string anrede, string name, string firma) : base(anrede, name)
        {
            Firma = firma;
        }

        public override string GetAdresse()
        {
            const char LF = (char)10; // Zeilenvorschung
            return (base.GetAdresse() + LF + Firma);
        }

        public override void AddGuthaben(decimal brutto)
        {
            decimal netto = brutto / (1 + mwst);
            base.AddGuthaben(netto);
        }

        public decimal GetMWSt()
        {
            return mwst;
        }
    }
}
