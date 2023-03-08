

using session14;

Utility ut1= new Utility();
List<int> listItems = new List<int>();
listItems.Add(12);
listItems.Add(10);
listItems.Add(25);
ut1.DisplayList<int>(listItems);
Console.WriteLine();

List<double> listItems1 = new List<double>();
listItems1.Add(12.2);
listItems1.Add(10.36);
listItems1.Add(25.25);
ut1.DisplayList<double>(listItems1);

