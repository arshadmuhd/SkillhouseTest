using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase
{
	internal class Restaurant
	{
		public string Name { get; set; }	
		public string Location { get; set; }
		public Cuisine CuisineDetails { get; set; }
		public int AverageCost { get; set; }
		public int NoOfTables { get; set; }
		public ContactInformation Contact { get; set; }

		public void DisplayRestaurantInformation()
		{
			Console.WriteLine("Name:" + Name);
			Console.WriteLine("Location:" + Name);
			Console.WriteLine("Cuisine Type:" + CuisineDetails.Type);
			Console.WriteLine("Cuisine Description:" + CuisineDetails.Description);
			Console.WriteLine("Address:" + Contact.Address);
			Console.WriteLine("Email Address:" + Contact.EmailAddress);
			Console.WriteLine("Phone Number:" + Contact.PhoneNumber);
			Console.WriteLine("Average Cost:" + AverageCost);
			Console.WriteLine("No Of Tables:" + NoOfTables);
		}

	}
}
