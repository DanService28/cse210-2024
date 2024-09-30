using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        
        int userPrompt = -1;

        //Open a While loop to repeat the menu as much as the user need it.
        while (userPrompt != 5)
        {  

            //Display the main menu and repeat until the user choise option #5 
            Console.WriteLine("Please select one of the following choises: \n1. Write.\n2. Display."  +
            "\n3. Save.\n4. Load.\n5. Quit. \nWhat would you like to do? ");

            userPrompt = int.Parse(Console.ReadLine());

            if (userPrompt ==  1)
            {
                Entry newEntry = new Entry();

                //Used theCurrentTime method to get the current time    
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToString("dd/MM/yyyy HH:mm");
                
                //Use the GetRamdonPrompt to iterate with the prompt attribute and display it to the user
                PromptGenerator prompt = new PromptGenerator();
                newEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);

                //Ask for a answer
                newEntry._entryText = Console.ReadLine();


                theJournal._entries.Add(newEntry);    
            }


            if (userPrompt ==  2)
            {   
                //Display the list with all the entris.
                theJournal.DisplayAll();
            }

            if (userPrompt ==  3)
            {
                Console.WriteLine("What is the filename?");
                string userFile = Console.ReadLine();

                theJournal.SaveToFile(userFile);
            }
        }    
    }    
         
}