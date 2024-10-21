using System;

class Program
{
    
    static void Main(string[] args)
    {
        

        int userActivity = -1;
        
        while (userActivity != 5)
            {
            //Display menu.
            Console.Write("Menu options: \n 1. Start breathing activity \n 2. Start reflecting activity" +
            "\n 3. Start listing activity \n 4. Quit \nSelect a choise from the menu: ");

            userActivity = int.Parse(Console.ReadLine()); 

            if(userActivity == 1)
            {   
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
            }

            if(userActivity == 2)
            {   
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
            }
            
             if(userActivity == 3)
            {   
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();
            }
            }

        
    }
}