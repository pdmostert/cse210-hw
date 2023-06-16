using System;
using System.Collections.Generic;

// For extra credid, I used Json to store my data. I also included a refactored menu class and making use of a gameFile class to store the points and all goals.
// I added a new derived class for BadHabbitGoal and it works in a negative manner. 
// I am also made it so that you can display the amount of points that you have  collected from eternal and bad goals. 



class Program
{
    static void Main(string[] args)
    {
        int baseMenuChoice = 0;
        GameFile gameFile = new GameFile();


        //Prepare Menu
        List<string> baseMenuOptions = Menu.GetBaseMenu();
        //Process Menu Choice
        List<string> goalChoiceMenuOptions = Menu.GetGoalMenu();

        while (baseMenuChoice != 6)
        {
            Console.Clear();
            Console.WriteLine($"You have {gameFile.Points} points");
            Console.WriteLine();

            Menu.ShowMenu(baseMenuOptions);
            baseMenuChoice = Menu.GetSelectedMenuOption(1, baseMenuOptions.Count);

            switch (baseMenuChoice)
            {
                case 1:
                    //Create New Goal

                    Menu.ShowMenu(goalChoiceMenuOptions, "The types of goals are: ", "Which type of goal would you like to create? ");
                    int goalChoice = Menu.GetSelectedMenuOption(1, goalChoiceMenuOptions.Count);

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of your goal? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points of your goal? ");
                    string basePointsString = Console.ReadLine();
                    int basePoints = int.Parse(basePointsString);

                    switch (goalChoice)
                    {
                        case 1:
                            //Simple Goal
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, basePoints);
                            gameFile.AddGoal(simpleGoal);
                            break;
                        case 2:
                            //Eternal Goal
                            EternalGoal eternalGoal = new EternalGoal(name, description, basePoints, 0);
                            gameFile.AddGoal(eternalGoal);
                            break;
                        case 3:
                            //Checklist Goal
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            string completeCount = Console.ReadLine();
                            Console.Write("What is the bonus amount of points for this goal? ");
                            string bonusPoints = Console.ReadLine();
                            CheckListGoal checkListGoal = new CheckListGoal(name, description, basePoints, int.Parse(bonusPoints), int.Parse(completeCount), 0);
                            gameFile.AddGoal(checkListGoal);
                            break;
                        case 4:
                            //Bad Habbit Goal
                            if(basePoints >=0){
                                
                                basePoints = basePoints * (-1);
                            }
                            BadHabbitGoal badHabbitGoal = new(name, description, basePoints);
                            gameFile.AddGoal(badHabbitGoal);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    //List Goals
                    Console.WriteLine("The goals are:");
                    foreach (var item in gameFile.Goals)
                    {
                        Console.WriteLine($"{gameFile.Goals.IndexOf(item) + 1}. {item.DisplayGoal()}");
                    }
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 3:
                    //Save Goals
                    Console.Write("What would you like to name your save file? (Default: goals.json)");
                    string saveFileName = Console.ReadLine();
                    if (saveFileName == "")
                    {
                        DataAccess.SaveGameFile(gameFile);

                    }
                    else
                    {
                        DataAccess.SaveGameFile(gameFile, saveFileName);
                    }
                    break;
                case 4:
                    //Load Goals
                    Console.WriteLine("What is the name of the file you would like to load? (Default: goals.json)");
                    string loadFileName = Console.ReadLine();
                    if (loadFileName == "")
                    {
                        gameFile = DataAccess.LoadGameFile();
                    }
                    else
                    {
                        gameFile = DataAccess.LoadGameFile(loadFileName);
                    }
                    break;
                case 5:
                    //Record Event
                    if (gameFile.Goals.Any() == false)
                    {
                        Console.WriteLine("You have no goals loaded yet. Please add a goal first. ");
                        Console.WriteLine();
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    }

                    Console.WriteLine("Record Event");

                    List<string> recordEventMenuOptions = new List<string>();
                    foreach (var item in gameFile.Goals)
                    {
                        recordEventMenuOptions.Add(item.Name);
                    }
                    Menu.ShowMenu(recordEventMenuOptions, "Which goal would you like to record an event for? ", "Please select a goal: ");
                    int recordEventChoice = Menu.GetSelectedMenuOption(1, recordEventMenuOptions.Count);
                    var reward = gameFile.Goals[recordEventChoice - 1].RecordEvent();
                    gameFile.Points += reward;
                    Console.WriteLine($"You have earned {reward} points");
                    Console.WriteLine();
                    Console.Write("Press any key to continue");
                    Console.ReadKey();

                    break;
                case 6:
                    //Quit
                    Console.WriteLine();
                    Console.WriteLine("Good Bye");
                    break;
                default:

                    break;
            }


        }
    }

}