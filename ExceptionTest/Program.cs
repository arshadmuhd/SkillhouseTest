// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Something");
var Read = Console.ReadLine();
try
{
    
    int Num=Convert.ToInt32(Read);
    Console.WriteLine(Num);


}
catch(FormatException ex)
{
    Console.WriteLine(ex.Message);
  

}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}
finally
{
    Console.WriteLine("Thank You");
}