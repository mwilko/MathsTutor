using System;
namespace MathsTutor
{
	public class Menu : Input // derived class Menu inherits from base class Input
	{
        //instantiate object 'pack' 
        Pack pack = new Pack();

        public Menu()
		{
		}

		public void MainMenu()
		{
            Console.WriteLine("----- Welcome to the Maths Tutor! -----");

            MenuSelection();//run menu selection method
        }

        //method which outputs non-interactive instructions on how
        //the program works/what the user needs to do
        public void Instructions()
        {
            Console.WriteLine("------ INSTRUCTIONS -----");
            Console.WriteLine("The purpose of this program is to output an equation of numbers to you. " +
                "\nWith this equation, you should calculate the answer and then input what you think the equation is equal to \n" +
                "(please enter your answer as a decimal for more accurate readings). If your answer is correct, " +
                "a 'You Win!' message will display, \nif you are wrong 'You Lose!' message will display. You can choose weather " +
                "you want to repeat the process or exit the application. ");
            Console.WriteLine("\n");
        }

        public void MenuSelection()
		{
            bool isValid = false; //used to check if inputted data is valid
            bool continueSelection = true;//used as indication to continue or stop loop
            int choice = 0;
            //loop which continues until the user wants to quit the application
            do
            {
                //validation for file choice
                do
                {
                    Console.WriteLine("Would you like to [1] Deal [2] Instructions [3] Exit: ");
                    choice = GetInputAndTypeValidate(choice);
                    isValid = ValidateRange(choice, 1, 3);
                } while (!isValid);

                if (choice == 1)//deal cards
                {
                    continueSelection = true;
                    pack.ShuffleCardPack();
                    do
                    {
                        Console.WriteLine("Would you like to [1] Deal 3 Cards or [2] Deal 5 Cards: ");
                        choice = GetInputAndTypeValidate(choice);
                        isValid = ValidateRange(choice, 1, 2);
                    } while (!isValid);
                    if (choice == 1)
                    {
                        pack.DealCard3();
                        MenuSelection();
                    }
                    else if (choice == 2)
                    {
                        pack.DealCard5();
                        MenuSelection();
                    }
                    else
                    {
                        Console.WriteLine("Error: Could not call either of the dealCard methods (Menu.cs) ");
                    }
                }
                else if (choice == 2)//executes instructions method
                {
                    continueSelection = true;
                    Instructions();
                }
                else if (choice == 3)//exit program
                {
                    continueSelection = false;//ends loop continuation
                    pack.CloseTxtFile();//closes text file in pack class
                    ExitProgram();
                }

            } while (continueSelection == true);
        }

        public void ExitProgram()
        {
            Console.WriteLine("----- Thank you, Goodbye! -----");
            //line below quits the application
            Environment.Exit(0);
        }
	}
}

