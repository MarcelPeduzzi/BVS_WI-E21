namespace KundenSample
{
    public class Kunde
    {
        public string Anrede { get; set; }
        public string Nachname { get; set; }
        public bool StammKunde { get; set; }
        public decimal Guthaben { get; protected set; }

        public Kunde(string anrede, string nachname)
        {
            Anrede = anrede;
            Nachname = nachname;
        }

        public virtual string GetAdresse()
        {
            return $"{Anrede} {Nachname}";
        }

        public virtual void AddGuthaben(decimal betrag)
        {
            Guthaben += betrag;
        }
    }
}
