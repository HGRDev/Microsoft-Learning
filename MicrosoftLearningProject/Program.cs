using System;


//CODE PROJECT: 3
//string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
//int periodLocation = 0;

//for (int i = 0; i < myStrings.Length; i++)
//{
    

//    if (myStrings[i].IndexOf(".") != -1)
//    {
//        while (myStrings[i].Length > 0)
//        {
//            myStrings[i] = myStrings[i].TrimStart();
//            periodLocation = myStrings[i].IndexOf(".");

//            if (myStrings[i].IndexOf(".") == -1 )
//            {
//                Console.WriteLine(myStrings[i]);
//                myStrings[i] = myStrings[i].Remove(0);
//            }
//            else
//            {
//                Console.WriteLine(myStrings[i].Substring(0, periodLocation));
//                myStrings[i] = myStrings[i].Remove(0, periodLocation + 1);
//            }   
//        }
//    }
//    else
//    {
//        Console.WriteLine(myStrings[i]);
//    }
//}


//CODE PROJECT: 2
//string? userInput;
//Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

//userInput = Console.ReadLine();

//while (!userInput.Trim().ToLower().Equals("administrator")
//    && !userInput.Trim().ToLower().Equals("manager")
//    && !userInput.Trim().ToLower().Equals("user"))
//{

//    Console.WriteLine(@$"The role name that you entered, '{userInput}' is not valid. Enter your role name (Administrator, Manager, or User)");
//    userInput = Console.ReadLine();
//}


//Console.WriteLine($"Your input value ({userInput.Trim()}) has been accepted.");




//CODE PROJECT: 1
//int parsedUserInput = 0;
//string? userInput;
//Console.WriteLine("Give a number between 5 and 10: ");
//do
//{

//    userInput = Console.ReadLine();


//    if (int.TryParse(userInput, out parsedUserInput))
//    {
//        if (parsedUserInput < 5 || parsedUserInput > 10)
//        {
//            Console.WriteLine($"You entered {parsedUserInput}. Please enter a number between 5 and 10.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Sorry, you entered an invalid number, please try again");
//        userInput = Console.ReadLine();

//        while (!int.TryParse(userInput, out parsedUserInput))
//        {
//            Console.WriteLine("Sorry, you entered an invalid number, please try again");
//            userInput = Console.ReadLine();
//        }
//        Console.WriteLine($"You entered {parsedUserInput}. Please enter a number between 5 and 10.");
//    }

//} while (parsedUserInput < 5 || parsedUserInput > 10);

//Console.WriteLine($"Your input value was ({parsedUserInput}) has been accepted.");






Console.ReadLine();
//Monster Game:
//Here are the rules for the battle game that you need to implement in your code project:

//You must use either the do-while statement or the while statement as an outer game loop.
//The hero and the monster will start with 10 health points.
//All attacks will be a value between 1 and 10.
//The hero will attack first.
//Print the amount of health the monster lost and their remaining health.
//If the monster's health is greater than 0, it can attack the hero.
//Print the amount of health the hero lost and their remaining health.
//Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
//Print the winner.

//int monsterHealth = 10;
//int heroHealth = 10;

//Random healthDecrease = new Random();

//do
//{
//	int roll = healthDecrease.Next(1, 11);
//    monsterHealth -= roll;
//    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

//    if (monsterHealth < 0) continue;

//    roll = healthDecrease.Next(1, 11);
//    heroHealth -= roll;
//    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");


//} while (monsterHealth > 0 && heroHealth > 0);

//Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");




