using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new();

        Video videio1 = new("Gifts of the Spirit for Hard Times | Henry B. Eyring | 2006", "BYU Speeches", 2071);
        videio1.AddComment(new Comment("lilacbunches", "This talk is so needed now in 2021 as it was back in 2006...truth is always the truth...thank you for your wonderful message President Eyring."));
        videio1.AddComment(new Comment("magic4026", "You can feel he’s speaking under the influence of the  holly spirit 😇 When I drive I live to listen the apostles and leader’s of our true church"));
        videio1.AddComment(new Comment("k4lifestyle", "I am a recovering heroine addict. I started at 21 and I am now 41. I have 23 months clean today. Jesus Christ is real. What he did and what happened to him is true. He changed me. He is who I follow and serve"));
        videio1.AddComment(new Comment("makamurphy", "Always always edified watching this video, whenever I need help to overcome such challenges, this talk pops up! Thank you President Eyring"));

        videos.Add(videio1);

        Video video2 = new("WEBHOOKS With .NET Minimal APIs", "Codewrinkles", 993);
        video2.AddComment(new Comment("Tamer_Ali", "Thanks a lot Mr.Dan for that awesome real world example. need more of these real world examples. happy week off and welcome back"));
        video2.AddComment(new Comment("ConradAkunga", "Fantastic!"));
        video2.AddComment(new Comment("vicky2118", "Thank you so much for this wonderful video"));
        video2.AddComment(new Comment("nove1398", "Great video, 👍🏼. What happens if you managed to miss a webhook message in your consumer?"));
        videos.Add(video2);

        Video video3 = new Video("Stream image in .NET Blazor Server", "Authorised Territory", 560);
        video3.AddComment(new Comment("PDLM1221", "Great tutorial"));
        video3.AddComment(new Comment("Hugleikr_", "Nice work keep it up"));
        video3.AddComment(new Comment("christopheryoder8292", "Thanks just what I was lookign for."));
        videos.Add(video3);

        Video video4 = new Video("ASP.NET Community Standup - Cloud-native development with .NET 8", "dotnet", 3691);
        video4.AddComment(new Comment("eojaya", "is it possible to see repo for the eshop"));
        video4.AddComment(new Comment("quachhengtony7651", "hello from beautiful Vietnam"));
        video4.AddComment(new Comment("earthaddict", "Hello from South Africa"));
        videos.Add(video4);

        Console.Clear();
        foreach (var video in videos)
        {
            System.Console.WriteLine(video.DisplayVideoInfo());
            System.Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            
            foreach (var comment in video.GetListOfComments())
            {
                System.Console.WriteLine(comment.DisplayComment());
            }
            System.Console.WriteLine();
        }

    }
}