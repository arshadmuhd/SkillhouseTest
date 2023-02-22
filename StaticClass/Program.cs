using StaticClass;

Person P1 = new Person()
{
    Name= "Foo",
    Age= 20,
    
};
Person.Weather = "hot";
string ans=Person.WeatherInfo();
Console.WriteLine(ans);
