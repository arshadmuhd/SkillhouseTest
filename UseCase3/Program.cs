// See https://aka.ms/new-console-template for more information


using UseCase3;

Publisher Pub1 = new Publisher()
{
	Name="Arshad",
	Location="Kasaragod"
};
Publisher Pub2 = new Publisher()
{
	Name = "Ajmal",
	Location = "Kannur"
};

PublisherInformation pubInfo1 = new PublisherInformation()
{
	PublisherName="Arshad",
	PhoneNumber=7894561230,
	ContactPerson="arshad@gmail.com"

};

PublisherInformation pubInfo2= new PublisherInformation()
{
	PublisherName = "Ajmal",
	PhoneNumber = 1234567890,
	ContactPerson = "ajmal@gmail.com"

};

Book B1 = new Book()
{
	BookTitle="Heaven",
	BookAuthor="Joseph",
	ISBN=2000,
	Genre="fairy tails",
	PublishYear=2012,
	PubInfo=pubInfo1,
	Pub=Pub1
};
Book B2= new Book()
{
	BookTitle = "Hell",
	BookAuthor = "Vijay",
	ISBN = 2089,
	Genre = "Horror",
	PublishYear = 2011,
	PubInfo = pubInfo2,
	Pub = Pub2
};

B1.DisplayBookInformation();
Console.WriteLine();
B2.DisplayBookInformation();