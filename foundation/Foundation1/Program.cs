using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(" How to cook an Encebollado", "Jason Espinaca", 236);
        Comments comment1 = new Comments("Daniel", "It looks very tasty");
        Comments comment2 = new Comments("Javier", "I don't like encebollado");
        Comments comment3 = new Comments("Gabo", "Thank you, I really needed this video");
        
        video1.AddComment(comment1, comment2, comment3);
        

        Video video2 = new Video(" 10 secrets of Bob Sponja", "Carlos Marte", 766);
        Comments comment4 = new Comments("John", "haha interesting");
        Comments comment5 = new Comments("David", "I won't never see bob sponja as the same");
        Comments comment6 = new Comments("Erick", "It's uncredible");
        Comments comment7 = new Comments("Jason", "I knew the 2 first");
        
        video2.AddComment(comment4, comment5, comment6, comment7);

        Video video3 = new Video(" Become in a PRO in FC24","CR7", 516);
        Comments comment8 = new Comments("Messi", "Good job");
        Comments comment9 = new Comments("Enner", "I never win a match");
        Comments comment10 = new Comments("Musiala", "I'm expecting the second part");
        Comments comment11 = new Comments("Chicho", "Greetings from Ecuador");
        
        video3.AddComment(comment8, comment9, comment10, comment11);

        List<Video> videos = [video1, video2, video3];

        foreach (var video in videos)
        {
            video.DisplayVideoRecords();
        }

        
    }
}