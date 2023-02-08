using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase3
{
	internal class Book
	{
		public string BookTitle { get; set; }
		public string BookAuthor { get; set; }
		public int ISBN { get; set; }
		public string Genre { get; set; }
		public int PublishYear { get; set; }
		public PublisherInformation PubInfo { get; set; }
		public Publisher Pub { get; set; }

		public void DisplayBookInformation()
		{
			Console.WriteLine("Book Title =" + BookTitle);
			Console.WriteLine("Book Author =" + BookAuthor);
			Console.WriteLine("ISBN =" + ISBN);
			Console.WriteLine("Genre =" + Genre);
			Console.WriteLine("Publish Year=" + PublishYear);
			Console.WriteLine("Publisher Name=" + PubInfo.PublisherName);
			Console.WriteLine("Contact=" + PubInfo.ContactPerson);
			Console.WriteLine("Phone Number=" + PubInfo.PhoneNumber);
			Console.WriteLine("Publisher location =" + Pub.Location);

		}
	}
}
