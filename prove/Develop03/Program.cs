using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nefi", 3 , 7);

        Scripture scripture = new Scripture(reference, "Y acontecio que yo Nefi le dije a mi padre: Iré y Haré lo que el Señor" +
        "ha mandado por que sé que el nunca da mandamientos a los hijos de los hombres sin prepararles la vía, para que" +
        "cumplan lo que les ha mandado.");

        string userPrompt = string.Empty;
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        

        while (userPrompt != "quit"  || scripture.IsCompletelyHidden()) 
        {
            
            
            Console.WriteLine("Press enter to hide words or type 'quit' to end the program");
            userPrompt = Console.ReadLine();
            
            if (userPrompt != "quit")
            {
                scripture.HideRandomWord(); 
                Console.Clear(); 
                Console.WriteLine(scripture.GetDisplayText()); 
            }
        }
    }
}