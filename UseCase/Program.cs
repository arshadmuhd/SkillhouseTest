// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using UseCase;

ContactInformation contact1 = new ContactInformation
{
	Address = "Mangalore,karnataka,India",
    EmailAddress = "Koylarestuarent@gmail.com",
	PhoneNumber=9876543210

};
ContactInformation contact2 = new ContactInformation
{
	Address = "Bangalore,karnataka,India",
	EmailAddress = "Kochinerestuarent@gmail.com",
	PhoneNumber = 4561237890

};

Cuisine CuisineDetails1 = new Cuisine
{
	Type="A/c FastFood",
	Description="Mangalore best fastfood restuarent"

};

Cuisine CuisineDetails2 = new Cuisine
{
	Type = "Non A/c FastFood & Veg",
	Description = "Bangalore famous Veg and fastfood restuarent"

};

Restaurant R1 = new Restaurant
{
	Name="Koyla Restuarent",
	Location="Mangalore",
	CuisineDetails=CuisineDetails1,
	Contact=contact1,
	AverageCost=5000,
	NoOfTables=20
};

Restaurant R2 = new Restaurant
{
	Name = "Kochine Restuarent",
	Location = "Bangalore",
	CuisineDetails = CuisineDetails2,
	Contact = contact2,
	AverageCost = 1000,
	NoOfTables = 10
};

R1.DisplayRestaurantInformation();
Console.WriteLine();
R2.DisplayRestaurantInformation();





