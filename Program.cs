//Peer Reviewed: Angelica Ayala 10/21/22
//Guessit workes efficiently
//Clean coding and easy to read

bool runAgain = true;
    while(runAgain == true)
    {
        string difficulty = "";
        Console.WriteLine("Random number guessing game");
        Console.WriteLine("Please choose a difficulty:");
        Console.WriteLine("Easy 1-10");
        Console.WriteLine("Medium 1-50");
        Console.WriteLine("Hard 1-100");
        difficulty = Console.ReadLine().ToUpper();
        while(difficulty != "EASY" && difficulty != "MEDIUM" && difficulty != "HARD")
        {
            Console.WriteLine("Invalid entry, please try again:");
            difficulty = Console.ReadLine().ToUpper();
        }


        if(difficulty == "EASY")
        {
            Easy();
        }
        else if(difficulty == "MEDIUM")
        {
            Medium();
        }
        else if (difficulty == "HARD")
        {
            Hard();
        }

        void Easy()
        {
            bool isNumber;
            int userGuess = 0;
            int guessCount = 0;

            Random numberGen = new Random();
            int number = numberGen.Next(1,10); 
            Console.WriteLine("The number has been generated please take a guess:");
            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out userGuess);
                if(isNumber == false)
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                else if(userGuess != number)
                {
                    if(userGuess > number)
                    {
                        Console.WriteLine("incorrect, try lower:");
                    }
                    else if(userGuess < number)
                    {
                        Console.WriteLine("incorrect, try higher:");
                    }
                    guessCount++;
                }
                else if (userGuess == number)
                {
                    Console.WriteLine($"Congratulations! The number was {number}");
                    Console.WriteLine($"You found the number in {guessCount} total guesses");  
                }
            }while(isNumber == false || userGuess != number);
        }

        void Medium()
        {
            bool isNumber;
            int userGuess = 0;
            int guessCount = 0;

            Random numberGen = new Random();
            int number = numberGen.Next(1,50); 
            Console.WriteLine("The number has been generated please take a guess:");
            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out userGuess);
                if(isNumber == false)
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                else if(userGuess != number)
                {
                    if(userGuess > number)
                    {
                        Console.WriteLine("incorrect, try lower:");
                    }
                    else if(userGuess < number)
                    {
                        Console.WriteLine("incorrect, try higher:");
                    }
                    guessCount++;
                }
                else if (userGuess == number)
                {
                    Console.WriteLine($"Congratulations! The number was {number}");
                    Console.WriteLine($"You found the number in {guessCount} total guesses");  
                }
            }while(isNumber == false || userGuess != number);
        }

        void Hard()
        {
            bool isNumber;
            int userGuess = 0;
            int guessCount = 0;

            Random numberGen = new Random();
            int number = numberGen.Next(1,100); 
            Console.WriteLine("The number has been generated please take a guess:");
             do
            {
                isNumber = int.TryParse(Console.ReadLine(), out userGuess);
                if(isNumber == false)
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                else if(userGuess != number)
                {
                    if(userGuess > number)
                    {
                        Console.WriteLine("incorrect, try lower:");
                    }
                    else if(userGuess < number)
                    {
                        Console.WriteLine("incorrect, try higher:");
                    }
                    guessCount++;
                }
                else if (userGuess == number)
                {
                    Console.WriteLine($"Congratulations! The number was {number}");
                    Console.WriteLine($"You found the number in {guessCount} total guesses");  
                }
            }while(isNumber == false || userGuess != number);
        }    



        string choice = "";
	    Console.WriteLine("Would you like to run again? (y/n)");
        while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
        {
            choice = Console.ReadLine().ToLower();
        }
        
        if(choice == "y" || choice == "yes")
        {
            runAgain = true;
        }
        else if(choice == "n" || choice == "no")
        {
            runAgain = false;
            Console.WriteLine("Now exiting");
        }
    }
