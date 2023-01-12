using session10;
Employee emp1=new Employee();

emp1.EmployeeID = 100;
emp1.EmployeeName = "abcd";
emp1.EmployeeAge = 21;
emp1.salary = 45000;
emp1.Work=new Work();

emp1.Work.WorkItem = "Hi I am working";
emp1.display();
Console.WriteLine(emp1.Work.WorkItem);
