using System;
using System.Collections.Generic;

namespace YouTube
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.FirstName = "Evelyn";
            //person.LastName = "Anyebe";

            /*Console.WriteLine("What do you think the name is?");
            string fullNameGuess = Console.ReadLine();

            Console.WriteLine("What do you think the name is again?");
            string fullNameGuess2 = Console.ReadLine();

            if (person.FullName==fullNameGuess)
            {
                Console.WriteLine("You got the name! You win");
            }else if(person.FullName == fullNameGuess2)
            {
                Console.WriteLine("You got the name! Half point");
            }
            else
            {
                Console.WriteLine("You are a dissapointment");
            }*/

            /*Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("WHat's the password?");
            string password= Console.ReadLine();

            if (age>12 && password == "password123")
            {
                Console.WriteLine("Welcome! you're atleast a teanager");
            }*/

            /*string name = "Caleb";
            switch (name)
            {
                case "Caleb":
                    Console.WriteLine("You are legit");
                    break;
                case "Claire":
                    Console.WriteLine("Get the heck away from freak bag");
                    return; //Ends the program because we are in main
                default:
                    Console.WriteLine("Who are you");
                    break;
            }

            Console.WriteLine("Welcome!"); */

            /* bool correct = true;
             int pointsEarned= correct ? 10 : 0;
             Console.WriteLine(pointsEarned);*/

            /*string name = "Claire";
            if (name == "Claire") Console.WriteLine("You are lame");*/

            /*int i = 0; //initialization
            while(i<10) //condition
            {
                Console.WriteLine(i);
                i++; //update
            }*/

            /*int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i<10);*/

            /*for(int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }*/
            Calculation calculation = new Calculation();
            Calculator calc = new Calculator();
            List<Calculation> calculations = new List<Calculation>();
            string toContinue = "y";
            Console.WriteLine("Simple Calculator" +
                "\n***************************" +
                "\nYou can perform +,-,*,^ on two numbers here." +
               "********************************");
            while (toContinue == "y")
            {
                Console.WriteLine("Enter First number: ");

                calculation.Num1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operator '+','-','*','^': ");
                calculation.CalculationOperator = Console.ReadLine();

                Console.WriteLine("Enter Second number: ");
                calculation.Num2 = Double.Parse(Console.ReadLine());


                calc.CurrentCalculation = calculation;
                calculations.Add(calc.CurrentCalculation);

                Console.WriteLine(calc.CurrentCalculation.getCalculation());

                Console.WriteLine("Enter N to stop or Y for another calculation: ");
                toContinue = Console.In.ReadLine().ToLower();
            }

            Console.WriteLine("\n \n Your calculation history is given below:");
            try
            {
                foreach (Calculation calculationObj in calculations)
                {
                    Console.WriteLine(calculationObj.getCalculation());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
           

        }
    }
}
