using System.Collections;
using System.Collections.Generic;

namespace cs_system_interfaces
{
	//public enum Genre
	//{ 
	//	Comedy, Horror, Adventure, Drama
	//}

	//public class Director : ICloneable
	//{
	//	public string FirstName { get; set; }
	//	public string LastName { get; set; }

	//	public object Clone()
	//	{
	//		var copy = (Director)this.MemberwiseClone();
	//		copy.FirstName = (string)this.FirstName.Clone();
	//		copy.LastName = (string)this.LastName.Clone();

	//		return copy;
	//	}

	//	public override string ToString()
	//	{
	//		return
	//			$"\nFirst name: {FirstName}" +
	//			$"\nLast name: {LastName}";
	//	}
	//}

	//public class Movie : ICloneable, IComparable<Movie>
	//{
	//	public string Title { get; set; }
	//	public string Description { get; set; }
	//	public Director Director { get; set; }
	//	public string Country { get; set; }
	//	public Genre Genre { get; set; }
	//	public int Year { get; set; }
	//	public short Rating { get; set; }

	//	public override string ToString()
	//	{
	//		return
	//			$"\tTitle: {Title}\n" +
	//			$"Description: {Description}\n" +
	//			$"Director: {Director.FirstName} {Director.LastName}\n" +
	//			$"Country: {Country}\n" +
	//			$"Genre: {Genre}\n" +
	//			$"Year: {Year}\n" +
	//			$"Rating: {Rating}\n";
	//	}

	//	public object Clone()
	//	{
	//		var copy = (Movie)this.MemberwiseClone();
	//		copy.Title = (string)this.Title.Clone();
	//		copy.Description = (string)this.Description.Clone();
	//		copy.Director = (Director)this.Director.Clone();
	//		copy.Country = (string)this.Country.Clone();

	//		return copy;
	//	}

	//	public int CompareTo(Movie? obj)
	//	{
	//		return this.Rating.CompareTo(obj.Rating);
	//	}
	//}

	//public class Cinema : IEnumerable
	//{
	//	private List<Movie> Movies { get; set; }
	//	private string Address { get; set; }

	//	public Cinema()
	//	{
	//		Address = "Maidan Nezalezhnosti 2, Rivne";
	//		Movies = new List<Movie>()
	//		{
	//			new Movie()
	//			{
	//				Title = "Black Adam",
	//				//Description = "Nearly 5,000 years after he was bestowed with the almighty powers of the Egyptian gods--and imprisoned just as quickly--Black Adam is freed from his earthly tomb, ready to unleash his unique form of justice on the modern world.",
	//				Director = new Director()
	//				{
	//					FirstName = "Jaume",
	//					LastName = "Collet-Serra"
	//				},
	//				Country = "USA",
	//				Genre = Genre.Adventure,
	//				Year = 2022,
	//				Rating = (short)7.1
	//			},
	//			new Movie()
	//			{
	//				Title = "Game of Thrones",
	//				//Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
	//				Director = new Director()
	//				{ 
	//					FirstName = "David",
	//					LastName = "Benioff"
	//				},
	//				Country = "USA, United Kingdom",
	//				Genre = Genre.Drama,
	//				Year = 2011,
	//				Rating = (short)9.2
	//			},
	//			new Movie()
	//			{ 
	//				Title = "Ford v Ferrari",
	//				//Description = "American car designer Carroll Shelby and driver Ken Miles battle corporate interference and the laws of physics to build a revolutionary race car for Ford in order to defeat Ferrari at the 24 Hours of Le Mans in 1966.",
	//				Director = new Director()
	//				{ 
	//					FirstName = "James",
	//					LastName = "Mangold"
	//				},
	//				Country = "USA",
	//				Genre = Genre.Adventure,
	//				Year = 2019,
	//				Rating = (short)9.1
	//			}
	//		};
	//	}

	//	public void SortByRating()
	//	{
	//		this.Movies.Sort();
	//	}
	//	public void ShowMovies()
	//	{
	//		foreach (var i in Movies)
	//		{
	//			Console.WriteLine(i);
	//		}
	//	}

	//	public override string ToString()
	//	{
	//		return 
	//			$"Address: {Address}" +
	//			$"Count of movies: {Movies.Count}";
	//	}

	//	public IEnumerator GetEnumerator()
	//	{
	//		return this.Movies.GetEnumerator();
	//	}
	//}


	public class Card
	{
		public string Suit { get; set; }
		public string Value { get; set; }

		public override string ToString()
		{
			return $"{Suit} - {Value}";
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			//Cinema cinema = new Cinema();
			//cinema.SortByRating();
			//cinema.ShowMovies();

			List<Card> cards = new List<Card>()
			{
				new Card()
				{
					Suit = "Diamonds",
					Value = "10"
				},
				new Card()
				{ 
					Suit = "Hearts",
					Value = "Jack"
				}
			};
			foreach (var c in cards) Console.WriteLine(c);
		}
	}
}