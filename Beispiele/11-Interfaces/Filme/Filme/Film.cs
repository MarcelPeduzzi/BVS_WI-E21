using System;

namespace Filme
{
	public class Film : IFilm, IComparable<Film>
	{
		string Titel { get; }
		int Laenge { get; }

		protected Film(string titel, int laenge)
		{
			this.Titel = titel; this.Laenge = laenge;
		}

		public virtual void Ausgabe()
		{
			Console.Write($"{Titel}, Dauer {Laenge} Minuten");
		}

		public int CompareTo(Film film)
		{
			return this.Titel.CompareTo(film.Titel);
		}
	}

}

