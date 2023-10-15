namespace Dice_Roller_Lab;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, whats your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome {name} !");

         
        
        

        
            
             
                Console.WriteLine($"{name}, how many sides on dices");
                int diceSides = int.Parse(Console.ReadLine());
        while(true)
        { 

                Console.WriteLine($"{name} press R to roll the dice. Or E to Exit");

                var userKey = Console.ReadKey().Key;
            var userexit = Console.ReadKey().Key;

            if (userKey == ConsoleKey.R)
            {




                int firstDice = RandoNumbers(1, diceSides);
                int secondDice = RandoNumbers(1, diceSides);


                int wins = SixSidedDiceOne(firstDice, secondDice);
                int wins2 = SixSidedDiceTwo(firstDice, secondDice);


                Console.WriteLine($"{firstDice},{secondDice}");












            }
            else if (userexit == ConsoleKey.E)
            {
                Console.WriteLine("Have a good day.");

                break; 
            }

            

             





            
            


            


        }
        
      

        
    }

    static int RandoNumbers(int x , int y)
    {

        Random random = new Random();

        int num = random.Next(x , y);

      

        return num;
    }

    
    
    static int SixSidedDiceOne(int x , int y )
    {
        if (x == 1 && y == 1)
        {
            Console.WriteLine("SNAKE EYES.");

        }
        else if (x == 1 && y == 2)
        {
            Console.WriteLine("ACE DEUCE.");
        }
        else if (x == 6 && y == 6)
        {
            Console.WriteLine("BOX CARS.");
        }
        else
        {
            Console.WriteLine(" No matching combos.");
        }
        return x;
        return y; 
        

    }

    static int SixSidedDiceTwo(int x, int y)
    {
        if (x + y == 11 || x + y == 7)
        {
            
            Console.WriteLine("WIN");
        }
        else if (x + y == 2 || x + y == 3 || x + y == 12)
        {
            Console.WriteLine("CRAPS");
        }
        else
        {
            Console.WriteLine("No matching combos:(");
        }
        return x;
        return y;
        


    }

}





