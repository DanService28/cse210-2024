using System;

class Program
{
    static void Main(string[] args)
    {
        //int A >= 90;
        //int B >= 80;
        //int C >= 70;
        //int D >= 60;
        //int F <= 60;

        Console.Write("How much is your grade percentage?: ");
        string userGradeSt = Console.ReadLine();
        int userGrade = int.Parse(userGradeSt);

        string letter = "";

        if (userGrade >= 90 && userGrade <= 100)
           {
                letter = "A";
           }
        else if (userGrade >= 80 && userGrade <= 90)
            {
                letter = "B";
            }
            
        else if (userGrade >= 70 && userGrade <= 80 )
            {
                letter = "C";
            }
        else if (userGrade >= 60 && userGrade <= 70 )
            {
                letter = "D";
            }   
        else 
            {
                letter = "F";
            }
        Console.WriteLine($"Your final grade is {letter}");
    }
}