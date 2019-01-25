using System;

namespace P1 {
 class Program {
  static void Main(string[] args) {

   Console.WriteLine("Hi.. Welcome to Budget Calculator..!!");
   Console.WriteLine("Please enter Your details to proceed forward..");
   Console.WriteLine("Please Enter your name");
   string name = Console.ReadLine();
   Console.WriteLine("Plese Enter your age");
   double age = Convert.ToDouble(Console.ReadLine());
   if (age < 18)
   {
    Console.WriteLine($"Under 18 Can not use this App..");
    Console.WriteLine($"Sorry for Inconvinience");
   }

   while (age > 17) 
   {
    Console.WriteLine($"Hi {name} to ***CALCULATE BUDGET DIVISION*** press any key");
    Console.WriteLine("To ***QUIT*** press q");
    var quit = Console.ReadLine();
    if (quit == "q") 
    {
     Console.WriteLine("Thank you");
     break;
    }

    var income = 0.0m;
    Console.WriteLine("Enter you Income monthly/Yearly");
    income = Convert.ToDecimal(Console.ReadLine());
    var wants = 0.3;
    var needs = 0.5;
    var savings = 0.2;
    Console.WriteLine("For the given income ");
    Console.WriteLine($"Your Wants must be:{Convert.ToDecimal(wants) * income} ");
    Console.WriteLine($"Your Needs must be:{Convert.ToDecimal(needs) * income}");
    Console.WriteLine($"Your savings must be:{Convert.ToDecimal(savings) * income}");
    while(true) {
     Console.WriteLine("If you want to Divide ***NEEDS*** press any key or Q to quit");
     var qt = Console.ReadLine();
    if (qt == "Q") 
    {
     break;
    }
    Console.WriteLine("To Divide the Needs based on " + "\n" + "1.Groceries" + "\n" +
      "2.Housing" + "\n" + "3.Utilities" + "\n" + "4.Health Insurance " + "\n" + "5. Car Expences"+"\n");
     int i = Convert.ToInt32(Console.ReadLine());
      switch (i) {
      case 1:
       Console.WriteLine($"You should spend on Groceries :{(Convert.ToDecimal(needs) * income)*0.3m}");
       break;
      case 2:
       Console.WriteLine($"You should Housing :{(Convert.ToDecimal(needs) * income)*0.25m}");
       break;
      case 3:
       Console.WriteLine($"You should Utilities :{(Convert.ToDecimal(needs) * income)*0.15m}");
       break;
      case 4:
       Console.WriteLine($"You should Health Insurance  :{(Convert.ToDecimal(needs) * income)*0.2m}");
       break;
      case 5:
       Console.WriteLine($"You should Car Expences :{(Convert.ToDecimal(needs) * income)*0.1m}");
       break;
      default:
       Console.WriteLine($"Plan Accordingly");
       break;
     }
    }
   }
  }
 }
}