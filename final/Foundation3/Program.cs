using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();

        Lecture lecture = new("Joseph Smith Lecture 1", "The First Vision and Its Aftermath", DateOnly.Parse("2023/05/01"), TimeOnly.Parse("09:00"),new Address("10 Garcia Street", "East London", "Eastern Cape", "South Africa"), "Truman G. Madsen", 25);
        Outdoor outdoor = new("East London Music Festival","East London annual music festival",DateOnly.Parse("2023/05/01"), TimeOnly.Parse("09:30"),new Address("BRU Stadium", "East London", "Eastern Cape", "South Africa"),"Sunny and Hot 26\u00B0C");
        Reception reception = new("Mostert Wedding","Wedding reception for Robert and Marlene Mostert",DateOnly.Parse("2023/05/01"), TimeOnly.Parse("15:00"),new Address("Cambridge Community Hall", "East London", "Eastern Cape", "South Africa"),"peter@events.co.za");



        events.Add(lecture);
        events.Add(outdoor);
        events.Add(reception);

        foreach (var item in events)
        {
            System.Console.WriteLine("Short Description:");
            System.Console.WriteLine(item.GenerateShortDescription());
            System.Console.WriteLine();
            System.Console.WriteLine("Standard Description:");
            System.Console.WriteLine(item.GenerateStandardDescription());
            System.Console.WriteLine();
            System.Console.WriteLine("Full Description:");
            System.Console.WriteLine(item.GenerateFullDescription());
            System.Console.WriteLine();

        }







    }
}