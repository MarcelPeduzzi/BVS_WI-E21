namespace KundenSample
{
    public class PrivateKunde : Kunde // erbt von der Basisklasse
    {
        public string Wohnort { get; set; }

        public PrivateKunde(string anrede, string name, string wohnort) : base(anrede, name)
        {
            Wohnort = wohnort; // Klassenspezifische Ergänzung
        }

        public override string GetAdresse()
        {
            const char LF = (char)10; // Zeilenvorschung
            return (base.GetAdresse() + LF + Wohnort);
        }

        public override void AddGuthaben(decimal betrag)
        {
            decimal berechneterBetrag = betrag;

            if (StammKunde)
            {
                const decimal bonus = (decimal)0.05;
                berechneterBetrag += bonus * betrag;
            }

            base.AddGuthaben(berechneterBetrag);
        }
    }
}
