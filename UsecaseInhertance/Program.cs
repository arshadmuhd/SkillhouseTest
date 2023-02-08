using UsecaseInhertance;


Department dep1 = new Department()
{
    Name= "CSE",
    Location="Mangalore"
};

ContactInformation contct1 = new ContactInformation()
{
    Address="Mangalore",
    EmailAddress="aarya@gmail,com",
    PhoneNumber=1234567890
};

Project pr1 = new Project()
{
    Name="Hospital Management",
    Date= DateTime.Now
};

Project pr2 = new Project()
{
    Name = "flight Management",
    Date = DateTime.Now
};


Lecturer lec1 = new Lecturer()
{
    name="Aarya",
    age= 29,
    gender="Female",
    deprt=dep1,
    salary=25000

};


Student s1 = new Student()
{
    name="Arshad",
    age= 22,
    gender="male",
    RollNo=33,
    TotalMarks=198,
    SemesterName="third semester",
    projectInfo=pr1


};

Student s2 = new Student()
{
    name = "Ajmal",
    age = 23,
    gender = "male",
    RollNo = 30,
    TotalMarks = 158,
    SemesterName = "third semester",
    projectInfo = pr2


};

lec1.Walk();
lec1.Work();
lec1.GetSalary();

s1.Walk();
s1.Work();
s1.PayFees();


s2.Walk();
s2.Work();
s2.PayFees();