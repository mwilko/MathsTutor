using System;
namespace MathsTutor
{
	public class Menu : Input
	{
		public Menu()
		{
		}

		public void MainMenu()
		{
            bool isValid = false;
            int choice = 0;

            Console.WriteLine("----- Welcome to the Maths Tutor! -----");

            //validation for dealing or exiting program
            do
            {
                Console.WriteLine("Would you like to [1] Deal Again or [2] Exit the Program: ");
                choice = GetInputAndTypeValidate(choice);
                isValid = ValidateRange(choice, 1, 2);
            } while (!isValid);

            if (choice == 1)
            {

            }
            else if (choice == 2)
            {

            }
            else
            {
                Console.WriteLine($"Error: '{choice}' is not accepted, please contact IT support: ");
            }
        }

		public void DealOrMenu()
		{
            bool isValid = false;
            int choice = 0;

            //validation for file choice
            do
            {
                Console.WriteLine("Would you like to [1] Deal Again or [2] Return to Menu: ");
                choice = GetInputAndTypeValidate(choice);
                isValid = ValidateRange(choice, 1, 2);
            } while (!isValid);
        }

        public void ExitProgram()
        {
            Console.WriteLine("----- Thank you, Goodbye! -----");
            //line below quits the application
            Environment.Exit(0);
        }
	}
}

