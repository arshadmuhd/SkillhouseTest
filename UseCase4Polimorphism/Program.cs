

using UseCase4;

Store Sm1 = new Store()
{
    Name="Koyla",
    Location="Mangalore"
};

ContactInformation ManagerContact1 = new ContactInformation()
{
    Address="Mangalore,Karnataka",
    EmailAddress="Arshad@gmail.com",
    PhoneNumber=1234568980
};

ContactInformation SecurityContact1  = new ContactInformation()
{
    Address = "Bangalore,Karnataka",
    EmailAddress = "Kavya@gmail.com",
    PhoneNumber = 7894561230
};

ContactInformation SecurityContact2 = new ContactInformation()
{
    Address = "mysore,Karnataka",
    EmailAddress = "Ajmal@gmail.com",
    PhoneNumber = 4561230789
};

Manager M1 = new Manager()
{
    Name="Arshad",
    Age=23,
    Gender="Male",
    Salary=24000,
    StoreInfo=Sm1,
    Contact= ManagerContact1

};

ShiftTime Sh1 = new ShiftTime()
{
    StartDate ="12-12-2009",
    EndDate="3-4-2010"
};

ShiftTime Sh2 = new ShiftTime()
{
    StartDate = "1-4-2019",
    EndDate = "4-8-2021"
};

SecurityPerson sec1 = new SecurityPerson()
{
    Name = "Kavya",
    Age = 25,
    Gender = "FeMale",
    Shift = Sh1,
    Contact = SecurityContact1
};

SecurityPerson sec2 = new SecurityPerson()
{
    Name = "Ajmal",
    Age = 25,
    Gender = "Male",
    Shift=Sh2,
    Contact = SecurityContact2
};

M1.Walk();
M1.Work();
M1.Supervise();
Console.WriteLine("\n");


sec1.Walk();
sec1.Work();
sec1.OpenDoor();
Console.WriteLine("\n");

sec2.Walk();
sec2.Work();
sec2.OpenDoor();
Console.WriteLine("\n");
