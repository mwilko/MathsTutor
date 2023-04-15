using System;
namespace MathsTutor
{
    //used to test the program
	public class Tutorial
	{
		public Tutorial()
		{
		}

        public void MathsTutorApp()
        {
            //instantiate object 'menu' 
            Menu menu = new Menu();
            menu.MainMenu();
            menu.MenuSelection();
        }
    }
}

