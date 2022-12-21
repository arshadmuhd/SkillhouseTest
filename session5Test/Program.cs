// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter either True or false");
bool  ans=Convert.ToBoolean(Console.ReadLine());

while (ans == true) 
{
    Console.WriteLine("Sorry, you have chosen to move on");
    Console.WriteLine("enter either True or false");
    ans = Convert.ToBoolean(Console.ReadLine());
}

Console.WriteLine("Thank you.You have ended the loop");
