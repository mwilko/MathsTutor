using System;

namespace MathsTutor
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }

        static void RunProgram()
        {
            //test object and method call to verify if the maths of the function is correct
            //(uncomment code below to test if maths/methods is/are correct)
            //Test test = new Test();
            //test.TestPackShuffle();
            //test.MathsTest3Cards();
            //test.MathsTest5Cards();

            //tutorial object and method call to run the main program loop
            //swapped Menu class to Tutorial class then deleted Menu class to better match the criteria
            Tutorial tutorial = new Tutorial();
            tutorial.MainMenu();
            tutorial.MenuSelection();
        }
    }
}

