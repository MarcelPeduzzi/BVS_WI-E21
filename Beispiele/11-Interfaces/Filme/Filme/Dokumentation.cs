using System;

namespace Filme
{
	public class Dokumentation : Film
	{
		string Genre { get; }

		public Dokumentation(string titel, int laenge, string genre) : base(titel, laenge)
		{
			this.Genre = genre;
		}

		public override void Ausgabe()
		{
			base.Ausgabe();

			Console.WriteLine($", aus dem bereich {this.Genre}");
		}
	}

}

