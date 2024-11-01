using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("08 de Feb", 30, 4.8));
        activities.Add(new Cycling("03 de Ene", 30, 20));
        activities.Add(new Swimming("4 de Jul", 30 , 30));

        foreach(var activity in activities)
        {
            activity.GetSummary();
        }
    }
}