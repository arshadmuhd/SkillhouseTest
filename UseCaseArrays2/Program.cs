Console.WriteLine("Question 1");
int[] ItemArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
for(int i = 0; i < ItemArray.Length; i++)
{
    Console.WriteLine(ItemArray[i]);
}



//question 2
Console.WriteLine("Question 2");
Console.WriteLine("Enter the no.of elements to store");
int n = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[10];
Console.WriteLine("Enter {0} the Elements", n);
for(int i=0;i< n; i++)
{
    array1[i]= Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The values store into the array are:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(array1[i]);
}

Console.WriteLine("The values store into the array in reverse are :");
for (int i = n-1; i >= 0; i--)
{
    Console.WriteLine(array1[i]);

}



//ques3
Console.WriteLine("Question 3");

Console.WriteLine("Enter the no.of elements to store");
int number = Convert.ToInt32(Console.ReadLine());
int[] array2 = new int[10];
Console.WriteLine("Enter {0} the Elements", number);
for (int i = 0; i < number; i++)
{
    array2[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The values store into the array are:");
for (int i = 0; i < number; i++)
{
    Console.WriteLine(array2[i]);
}

int sum = 0;
for (int i = 0; i < number; i++)
{
    sum += array2[i];
    
}
Console.WriteLine("Sum of all elements stored in the array is :{0}",sum);
Console.WriteLine();


//question 4
Console.WriteLine("Question 4");
Console.WriteLine("Enter the no.of elements to store");
int num = Convert.ToInt32(Console.ReadLine());
int[] array3 = new int[10];
int[] array4 = new int[10];
Console.WriteLine("Enter {0} the Elements", num);
for (int i = 0; i < num; i++)
{
    array3[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The elements stored in the first array are :");
for (int i = 0; i < num; i++)
{
    Console.WriteLine(array3[i]);
}
Console.WriteLine("The elements stored in the second array are :");
for (int i = 0; i < num; i++)
{
    array4[i] = array3[i];
    Console.WriteLine(array4[i]);
}



