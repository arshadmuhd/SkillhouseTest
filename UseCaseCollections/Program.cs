using System.Collections.Generic;

int[] number = new int[5] { 1, 2, 3, 4, 5 };
for (int i =0; i < number.Length; i++)
{
    Console.WriteLine(number[i]);
}

number[2] = 30;
Console.WriteLine("AfterModifying arr[2] value= "+number[2]);

int[,] array1 = new int[3, 3];
array1[0,0] = 10;
array1[0, 1] =20;
array1[0, 2] = 30;
array1[1, 0] = 40;
array1[1, 1] = 50;
array1[1, 2] = 70;
array1[2, 0] = 80;
array1[2, 1] = 90;
array1[2, 2] = 100;
Console.WriteLine("2D array");

for (int col=0; col<3; col++)
{
    for (int row = 0; row < 3; row++)
    {
        Console.WriteLine(array1[col,row]);
    }
}

List<int> listItem = new List<int>() {1,2,3,4,6};
Console.WriteLine("List:");
foreach (int item in listItem)
{
    
    Console.WriteLine(item);
    
}

HashSet<int> set = new HashSet<int>() { 10,10, 20, 30, 40, 50 };
Console.WriteLine("Hashset:");
foreach (int item in set)
{
   
    Console.WriteLine(item);
}

SortedSet<int> SortsetItem = new SortedSet<int>();
SortsetItem.Add(60);
SortsetItem.Add(50);
SortsetItem.Add(40);
SortsetItem.Add(30);
SortsetItem.Add(20);
Console.WriteLine("SortedSet:");

foreach (int item in SortsetItem)
{
    
    Console.WriteLine(item);
}




Dictionary<string, int> dictionaryItem = new Dictionary<string, int>();
dictionaryItem.Add("one", 1);
dictionaryItem.Add("two", 2);
dictionaryItem.Add("three",3);
dictionaryItem.Add("four", 4);
dictionaryItem.Add("five", 5);
Console.WriteLine("dictionaryItem:");

foreach (var item in dictionaryItem)
{

    Console.WriteLine(item.Key+ " "+item.Value);
}




