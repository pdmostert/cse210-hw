using System;
public class PromptActivity : Activity
{
   
    private List<string> _prompts;
    public List<string> Prompts
    {
        get { return _prompts; }
        set { _prompts = value; }
    }

    public PromptActivity()
    {
            _prompts = new();
    }

    protected string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}