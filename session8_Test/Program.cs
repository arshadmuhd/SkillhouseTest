using session8_Test;

SoftwereEngineers sde1= new SoftwereEngineers();
SoftwereEngineers sde2 = new SoftwereEngineers();
SoftwereEngineers sde3 = new SoftwereEngineers();
sde1.getValues(1000, "ajmal", "faris", 23);
sde1.display();
sde2.getValues(1001, "kamalesh", "kumar", 26);
sde2.display();



Accountant ac1=new Accountant();
Accountant ac2 = new Accountant();
Accountant ac3 = new Accountant();

ac1.getValues(2000, "kader", "ksd", 13);
ac1.display();
ac2.getValues(2001, "vishnu", "mnglr", 43);
ac2.display();
ac3.getValues(2002, "veda", "kannur", 53);
ac3.display();
