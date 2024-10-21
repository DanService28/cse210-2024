using System;

class Program
{
    
    static void Main(string[] args)
    {
        

        int userActivity = -1;
        
        while (userActivity != 4)
            {

            Console.Clear();
            //Display menu.
            Console.Write("Menu options: \n 1. Start breathing activity \n 2. Start reflecting activity" +
            "\n 3. Start listing activity \n 4. Quit \nSelect a choise from the menu: ");

            userActivity = int.Parse(Console.ReadLine()); 

            if(userActivity == 1)
            {   
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
            }

            else if(userActivity == 2)
            {   
                Console.Clear();
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
            }
            
            else if(userActivity == 3)
            {   
                Console.Clear();
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();
            }
            }

        Console.WriteLine("Good bye");

        
    }
}