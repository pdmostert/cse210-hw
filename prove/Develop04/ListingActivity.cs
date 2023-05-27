public class ListingActivity : PromptActivity
{

    public ListingActivity()
    {
        ActivityName = "Listing";
        ActivityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Prompts = GeneratePromptList();
    }

    public void DisplayPrompt()
    {
        // show random prompt
        Console.WriteLine(GetRandomPromt());
        //show count down

        //get list of string for duration

        //display list of items


    }

    private List<string> GeneratePromptList()
    {
        List<string> prompts = new();
        prompts.Add("Who are people that you appreciate? ");
        prompts.Add("What are personal strengths of yours? ");
        prompts.Add("Who are people that you have helped this week? ");
        prompts.Add("When have you felt the Holy Ghost this month? ");
        prompts.Add("Who are some of your personal heroes? ");
        return prompts;
    }


}