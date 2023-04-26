/* The PromptGenerator class generates a random prompt from a list of prompts and provides methods to
load, save, and add new prompts to the list. */
public class PromptGenerator
{
    private List<string> _prompts { get; set; }
    public PromptGenerator()
    {
        _prompts = new();
        LoadPrompts();
    }
    public PromptGenerator(string filename = "Prompts.txt")
    {
        _prompts = new();
        LoadPrompts(filename);
    }

/// <summary>
/// This C# function returns a random prompt from a list of prompts.
/// </summary>
/// <returns>
/// The method `GetRandomPrompt()` returns a randomly selected prompt from a list of prompts.
/// </returns>
    public string GetRandomPrompt()
    {
        Random rnd = new();
        int promptIndex = rnd.Next(0,_prompts.Count);
        return _prompts[promptIndex];
    }

/// <summary>
/// This function loads prompts from a file using a DataAccess class.
/// </summary>
/// <param name="filename">The filename parameter is a string that specifies the name of the file to be
/// loaded. If no filename is provided, the default value "Prompts.txt" will be used.</param>
    private void LoadPrompts(string filename = "Prompts.txt")
    {
        _prompts = DataAccess.ReadPromptFile(filename);
    }

/// <summary>
/// This function saves prompts to a file using a DataAccess class.
/// </summary>
/// <param name="filename">The name of the file where the prompts will be saved. If no value is
/// provided, the default filename "Prompts.txt" will be used.</param>
    private void SavePrompts(string filename = "Prompts.txt")
    {
        DataAccess.WritePromptFile(filename, _prompts);
    }

/// <summary>
/// This function adds a new prompt to a list and saves the updated list.
/// </summary>
/// <param name="prompt">The parameter "prompt" is a string that represents a new prompt that needs to
/// be added to a list of prompts. The method adds this new prompt to the list and then saves the
/// updated list of prompts.</param>
    public void AddNewPrompt(string prompt)
    {
        _prompts.Add(prompt);
        SavePrompts();
    }

}