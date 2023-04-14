using System;
namespace MathsTutor
{
	public class Menu : Input
	{
        Pack pack = new Pack();

        public Menu()
		{
		}

		public void MainMenu()
		{
            Console.WriteLine("----- Welcome to the Maths Tutor! -----");

            DealOrMenu();
        }

		public void DealOrMenu()
		{
            bool isValid = false;
            bool dealCards = true;
            int choice = 0;
            //loop which continues until the user wants to quit the application
            do
            {
                //validation for file choice
                do
                {
                    Console.WriteLine("Would you like to [1] Deal or [2] Exit: ");
                    choice = GetInputAndTypeValidate(choice);
                    isValid = ValidateRange(choice, 1, 2);
                } while (!isValid);

                if (choice == 1)//deal cards
                {
                    dealCards = true;
                    pack.shuffleCardPack();
                    do
                    {
                        Console.WriteLine("Would you like to [1] Deal 3 Cards or [2] Deal 5 Cards: ");
                        choice = GetInputAndTypeValidate(choice);
                        isValid = ValidateRange(choice, 1, 2);
                    } while (!isValid);
                    if (choice == 1)
                    {
                        pack.dealCard3();
                        DealOrMenu();
                    }
                    else if (choice == 2)
                    {
                        pack.dealCard5();
                        DealOrMenu();
                    }
                    else
                    {
                        Console.WriteLine("Error: Could not call either of the dealCard methods (Menu.cs) ");
                    }
                }
                if (choice == 2)//exit program
                {
                    dealCards = false;
                    ExitProgram();
                }
            } while (dealCards == true);
        }

        public void ExitProgram()
        {
            Console.WriteLine("----- Thank you, Goodbye! -----");
            //line below quits the application
            Environment.Exit(0);
        }
	}
}

