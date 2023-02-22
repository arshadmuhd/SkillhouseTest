using UseCase6;

HighSchoolStudent Hs1 = new HighSchoolStudent()
{
    Name = "Arshad",
    Age= 15,
    Address="kerala",
    SchoolId="Sh14",
    GradeLevel="A+",
    Gpa=9,
    ExtraCurricularActivities="Reading,drawing"


};

CollegeStudent ClgS1 = new CollegeStudent()
{
    Name = "Arfad",
    Age = 22,
    Address = "karnataka",
    SchoolId = "SS56",
    GradeLevel = "B+",
    Major="computer science",
    Minor="Science"
   


};


HighSchoolTeacher HStchr1 = new HighSchoolTeacher
{
    Name="Aarya",
    Address="mangalore",
    Age= 35,
    EmployeeId="Emp456",
    Department="CSE",
    SubjectTaught="Computer"
};

CollegeTeacher Colgtchr1 = new CollegeTeacher
{
    Name = "kavyaa",
    Address = "Bangalore",
    Age = 45,
    EmployeeId = "Emp123",
    Department = "ME",
    ResearchAreas="Mechanical",
    Publications="Electronics"
};


Hs1.RequestTranscript();
Hs1.EnrollInClasses();
Hs1.UpdateContactInformation();
Hs1.EnrollInClasses();
Hs1.ViewGrade();
Hs1.UpdateContactInformation();
Hs1.RecomendationLetter();
Console.WriteLine("\n");

ClgS1.RegisterForExam();
ClgS1.EnrollInClasses();
ClgS1.UpdateContactInformation();
ClgS1.EnrollInClasses();
ClgS1.ViewGrade();
ClgS1.UpdateContactInformation();
ClgS1.ApplyforGraduation();
Console.WriteLine("\n");



HStchr1.UpdateContactInformation();
HStchr1.ViewSchedule();
HStchr1.ScheduleParentTeacherConferences();
HStchr1.EnterGrades();
HStchr1.CreateLessonsPlans();
Console.WriteLine("\n");



Colgtchr1.UpdateContactInformation();
Colgtchr1.ViewSchedule();
Colgtchr1.ApplyforGrants();
Colgtchr1.EnterGrades();
Colgtchr1.ScheduleOfficeHours();
