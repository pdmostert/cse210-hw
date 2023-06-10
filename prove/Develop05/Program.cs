using System;
using System.Collections.Generic;

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
                    string basePoints = Console.ReadLine();

                    switch (goalChoice)
                    {
                        case 1:
                            //Simple Goal
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, int.Parse(basePoints));
                            gameFile.AddGoal(simpleGoal);
                            break;
                        case 2:
                            //Eternal Goal
                            EternalGoal eternalGoal = new EternalGoal(name, description, int.Parse(basePoints), 0);
                            gameFile.AddGoal(eternalGoal);
                            break;
                        case 3:
                            //Checklist Goal
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            string completeCount = Console.ReadLine();
                            Console.Write("What is the bonus amount of points for this goal? ");
                            string bonusPoints = Console.ReadLine();
                            CheckListGoal checkListGoal = new CheckListGoal(name, description, int.Parse(basePoints), int.Parse(bonusPoints), int.Parse(completeCount), 0);
                            gameFile.AddGoal(checkListGoal);
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
                        Console.WriteLine($"{gameFile.Goals.IndexOf(item)}. {item.DisplayGoal()}");
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 3:
                    //Save Goals
                    Console.Write("What would you like to name your save file? (Default: goals.json)");
                    string saveFileName = Console.ReadLine();
                    if (saveFileName == "")
                    {
                        DataAccess.SaveGoal(gameFile);

                    }
                    else
                    {
                        DataAccess.SaveGoal(gameFile, saveFileName);
                    }
                    break;
                case 4:
                    //Load Goals
                    Console.WriteLine("What is the name of the file you would like to load? (Default: goals.json)");
                    string loadFileName = Console.ReadLine();
                    if (loadFileName == "")
                    {
                        gameFile = DataAccess.LoadGoal();
                    }
                    else
                    {
                        gameFile = DataAccess.LoadGoal(loadFileName);
                    }
                    break;
                case 5:
                    //Record Event
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
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    break;
                case 6:
                    //Quit
                    Console.WriteLine("Good Bye");
                    break;
                default:

                    break;
            }


        }
    }

}