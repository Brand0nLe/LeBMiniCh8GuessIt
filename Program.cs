//Cuong Brandon Le
//10-19-22
//Mini Challenge 8 - Guess It


int easyLvl = 11;
int mediumLvl = 51;
int hardLvl = 101;
int winningNum = 0;
int gameMaxNum = 0;
int numGuess = 0;
int guessCount = 0;
bool validNum = true;
bool rightGuess = false;
string userInput;
string option;
string playAgain = "YES";

Console.Clear();

while (playAgain == "YES")
{
    Console.WriteLine("HERE ARE THE DIFFICULTY LEVELS");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Easy Mode: Guess from numbers 1 to 10.");
    Console.WriteLine("Medium Mode: Guess from numbers 1 to 50.");
    Console.WriteLine("Hard Mode: Guess from numbers 1 to 100.");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Please choose Easy, Medium, or Hard.");
    Console.WriteLine("----------------------------------------\n");
    option = Console.ReadLine().ToUpper();

    while (option != "EASY" && option != "MEDIUM" && option != "HARD")
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("You entered an invalid choice, try again.");
        Console.WriteLine("Please pick from Easy, Medium, or Hard.");
        Console.WriteLine("----------------------------------------");
        option = Console.ReadLine().ToUpper();
    }

    Console.WriteLine("You selected " + option);
    Random random = new Random();

    if(option =="EASY")
    {
        winningNum = random.Next(0, easyLvl);
        gameMaxNum = easyLvl - 1;

        while (rightGuess == false)
        {
            guessCount++;
            Console.WriteLine($"Enter a number from 1 to {gameMaxNum}");
            userInput = Console.ReadLine();
            validNum = Int32.TryParse(userInput, out numGuess);
            if (validNum == true)
            {
                if ((numGuess <= gameMaxNum) && (numGuess >= 1))
                {
                    validNum = true;
                    if (numGuess == winningNum)
                    {
                        Console.WriteLine($"Nice! You won! The winning number is {winningNum}");
                        Console.WriteLine($"It took you {guessCount} tries!");
                        rightGuess = true;
                    }
                    else if (numGuess > winningNum)
                    {
                        Console.WriteLine("Your number is too high, try again!");
                    }
                    else
                    {
                        Console.WriteLine("Your number is too low, try again!");
                    }
                }
                    else
                    {
                        Console.WriteLine("Please pick a valid number.");
                        validNum = false;    
                    }
                    }
                    else
                    {
                        Console.WriteLine("That doesn't look like a number. Please try again!");
                    }

                }
            }

        if (option == "MEDIUM")
        {
            winningNum = random.Next(0, mediumLvl);
            gameMaxNum = mediumLvl -1;

            while (rightGuess == false)
            {
                guessCount++;
                Console.WriteLine($"Enter a number from 1 to {gameMaxNum}");
                userInput = Console.ReadLine();
                validNum = Int32.TryParse(userInput, out numGuess);
                if (validNum == true)
                {
                    if ((numGuess <= gameMaxNum) && (numGuess >= 1))
                    {
                        validNum = true;
                        if (numGuess == winningNum)
                        {
                            Console.WriteLine($"Nice! You won! The winning number is {winningNum}");
                            Console.WriteLine($"It took you {guessCount} tries!");
                            rightGuess = true;

                        }

                        else if (numGuess > winningNum)
                        {
                            Console.WriteLine("Your number is too high, try again!");
                        }
                        else
                        {
                            Console.WriteLine("Your number is too low, try again!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please pick a valid number.");
                        validNum = false;
                    }
                }
                else
                {
                    Console.WriteLine("That doesn't look like a number. Please try again!");
                }
            }
        }


            if (option == "HARD")
            {
                winningNum = random.Next(0, hardLvl);
                gameMaxNum = hardLvl - 1;

                while (rightGuess == false)
                {
                    guessCount++;
                    Console.WriteLine($"Enter a number from 1 to {gameMaxNum}");
                    userInput = Console.ReadLine();
                    validNum = Int32.TryParse(userInput, out numGuess);
                    if (validNum == true)
                    {
                        if ((numGuess <= gameMaxNum) && (numGuess >= 1))
                        {
                            validNum = true;
                            if (numGuess == winningNum)
                            {
                                Console.WriteLine($"Nice! You won! The winning number is {winningNum}");
                                Console.WriteLine($"It took you {guessCount} tries!");
                                rightGuess = true;
                            }
                            else if (numGuess > winningNum)
                            {
                                Console.WriteLine("Your number is too high, try again!");
                            }
                            else
                            {
                                Console.WriteLine("Your number is too low, try again!");
                            }


                        }
                        else
                        {
                            Console.WriteLine("Please pick a valid number.");
                            validNum = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That doesn't look like a number. Please try again!");
                    }
                }
            }

    Console.WriteLine("Would you like to play again? (YES/NO)");
    playAgain = Console.ReadLine().ToUpper();
    if (playAgain == "YES")
    {
        rightGuess = false;
        guessCount = 0;
    }
    if (playAgain == "NO")
    {
        Console.WriteLine("That was fun! I'll see you next time!");
        rightGuess = true;
        guessCount = 0;
    }






}





