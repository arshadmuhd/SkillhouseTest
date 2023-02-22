using StaticUseCase;

BusStopATM.AtmBalance = 500000;


AtmRemainingBalance.Atmbalance = 495000;
AtmRemainingBalance.RemainingBalanceInAtm();

Person p1 = new Person()
{
    Name= "Arshad",
    Age= 30,
    Job="Engineer",
    DepositAmount= 5000,
};
p1.DisplayDepositAmount();


Person p2 = new Person()
{
    Name = "Arun",
    Age = 25,
    Job = "Chaiwala",
    WithdrawAmount = 50000,
};
p2.DisplayWithdrawAmount();