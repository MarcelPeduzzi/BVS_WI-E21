namespace Filme;

public class Kurzfilm: Film
{
    private bool IstFarbig { get; }
    
    public Kurzfilm(string titel, int laenge, bool istFarbig) : base(titel, laenge)
    {
        this.IstFarbig = istFarbig;
    }

    public override void Ausgabe()
    {
        base.Ausgabe();
        
        Console.WriteLine($", ist farbig: {IstFarbig}");
    }
}