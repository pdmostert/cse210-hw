using System;
public class PromptActivity : Activity
{
    public PromptActivity()
    {
            _prompts = new();
    }
   
    private List<string> _prompts;
    protected List<string> Prompts
    {
        get { return _prompts; }
        set { _prompts = value; }
    }


    protected string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}