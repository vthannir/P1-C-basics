using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
           // var name = string.Empty;
           // double age = 0;

            

            Console.WriteLine("Hi.. Welcome to Budget Calculator..!!");
            Console.WriteLine("Please enter Your details to procees forward..");
            Console.WriteLine("Please Enter your name");
            

            string name = Console.ReadLine();
            Console.WriteLine("Plese Enter your age");
             double age = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Welcome {name} and your age is {age}");
            if(age<18){
                Console.WriteLine($"Under 18 Can not use this App..");
                Console.WriteLine($"Sorry for Inconvinience");

            }
            
            while (age > 17)
            {
               // Console.WriteLine("Welcome... "/n" List of games "/n" 1.Guess the total of given numbers" );
             Console.WriteLine("Any key to Continue, to quit press q");
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

               




        
                     }
            
        }}
    }

