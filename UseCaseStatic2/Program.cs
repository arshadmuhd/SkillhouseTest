using UseCaseStatic2;

BeverageVendingMachine.CurrrentInventory = 100;

Person P1 = new Person()
{
    Name= "Arshad",
    Age= 25,
    Job="Engineer",
    BottlePurchase=1
};
P1.buy();



Person P2 = new Person()
{
    Name = "Ajmal",
    Age = 20,
    Job = "Doctor",
    RefillBottle = 50
};
P2.Refill();


