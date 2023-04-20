using System;
using System.IO;
namespace MathsTutor
{
	public class Pack : IPack //class Pack inherits from interface IPack
	{
        //list and objects initialised
        public static List<Card> SuitCardPack;
        public static List<Card> ValueCardPack;
        public static bool shufflingBool = false;

        //instantiate objects
        public Input input = new Input();
        public StreamWriter writer = new StreamWriter("statistics.txt");
        protected Random random = new Random();

        public int[] suits = { 1, 2, 3, 4 };
        public int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        public Pack()
        {
            bool suitBool = true;
            //initialise the card pack here
            SuitCardPack = new List<Card>();
            ValueCardPack = new List<Card>();

            foreach (int suit in suits)
            {
                SuitCardPack.Add(new Card(suit, suitBool));

            }
            foreach (int value in values)
            {
                ValueCardPack.Add(new Card(value));
            }
        }

        public bool ShuffleCardPack()
        {
            //fisher-yates shuffling algorithm 
            int n = SuitCardPack.Count;
            shufflingBool = true;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card card = SuitCardPack[k];
                SuitCardPack[k] = SuitCardPack[n];
                SuitCardPack[n] = card;
            }


            //fisher-yates shuffling algorithm 
            n = ValueCardPack.Count;
            shufflingBool = true;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card card = ValueCardPack[k];
                ValueCardPack[k] = ValueCardPack[n];
                ValueCardPack[n] = card;
            }
            //OutputPack();
            return true;
        }

        //method which takes an equation and returns the answer as a float.
        //(Included because values are card objects and cannot be
        //converted to integer values and operators without lots of code)
        public static double GetAnswer(string equation)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("equation", string.Empty.GetType(), equation);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["equation"]);
        }

        public static double GetAnswerBODMAS(string equation)
        {
            // Remove any white space from the equation
            equation = equation.Replace(" ", "");

            // Define the order of operations (BODMAS)
            string[] operations = new string[] { "^", "/", "*", "+", "-" };

            // Split the equation into separate terms based on the order of operations
            string[] terms = equation.Split(operations, StringSplitOptions.RemoveEmptyEntries);

            // Create a list to hold the operators
            List<string> operators = new List<string>();

            // Loop through the equation and add the operators to the list
            foreach (char c in equation)
            {
                if (operations.Contains(c.ToString()))
                {
                    operators.Add(c.ToString());
                }
            }

            // Calculate the terms based on the order of operations
            for (int i = 0; i < operations.Length; i++)
            {
                // Loop through the operators and calculate the terms based on the current operation
                for (int j = 0; j < operators.Count; j++)
                {
                    if (operators[j] == operations[i])
                    {
                        double leftTerm = Convert.ToDouble(terms[j]);
                        double rightTerm = Convert.ToDouble(terms[j + 1]);
                        double result = 0;

                        switch (operators[j])
                        {
                            case "^":
                                result = Math.Pow(leftTerm, rightTerm);
                                break;
                            case "/":
                                result = leftTerm / rightTerm;
                                break;
                            case "*":
                                result = leftTerm * rightTerm;
                                break;
                            case "+":
                                result = leftTerm + rightTerm;
                                break;
                            case "-":
                                result = leftTerm - rightTerm;
                                break;
                        }

                        // Replace the terms with the calculated result and remove the operator
                        terms[j] = result.ToString();
                        terms[j + 1] = "";
                        operators.RemoveAt(j);
                    }
                }
            }

            // Return the final calculated result
            return Convert.ToDouble(terms[0]);
        }



        public void DealCard3()
        {
            //Deals 3 cards
            //card object is set to null as if all bool variables are false
            //the card object would have no value for the method to return
            Card cardValue1 = null;
            Card cardSuit = null;
            Card cardValue2 = null;
            bool isValid = false;
            string equation = "";
            double answer = 0.0;
            double userAnswer = 0.0;

            Random random = new Random();
            int indexSuit = random.Next(SuitCardPack.Count);
            int indexValue = random.Next(SuitCardPack.Count);
            //loop to deal card out of fisher-yates shuffled card pack
            if (shufflingBool == true)
            {
                if (ValueCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardValue1 = ValueCardPack[0];
                //ValueCardPack.RemoveAt(indexValue);

                if (SuitCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardSuit = SuitCardPack[0];
                //SuitCardPack.RemoveAt(indexValue);

                if (ValueCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardValue2 = ValueCardPack[1];
                //ValueCardPack.RemoveAt(indexValue);
            }
            else
            {
                //exception handling
                //error message to catch any errors which may occur
                Console.WriteLine("Error: Unexpected error, contact IT support: ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Please Calculate the answer to this equation: ");

            equation = $"{cardValue1}{cardSuit}{cardValue2}";

            //calculates answer (bodmas method not used because there is only 2 nums and one operator)
            answer = Math.Round(GetAnswer(equation), 1);
            Console.WriteLine(answer);

            Console.WriteLine($"{equation} \n");

            do
            {
                Console.WriteLine("Enter your answer (decimal values are accepted, " +
                    "answers are rounded to 1 decimal point): ");
                userAnswer = input.GetInputAndTypeValidate(userAnswer);
                isValid = input.ValidateRange(userAnswer, -1000.0, 9999.9);
            } while (!isValid);

            //object instance, created to write the statistics to a file 'statistics.txt'
            writer.WriteLine($"Equation: {equation}");
            writer.WriteLine($"Answer: {answer}");
            writer.WriteLine($"Users Answer: {userAnswer}");
            writer.WriteLine("");//wrote to format the statistics better if more than one set is wrote to the file

            if (userAnswer == answer)
            {
                Console.WriteLine("You Won!");
            }
        }

        public void DealCard5()//INCLUDE : use BODMAS to claculate answer
        {
            //Deals 5 cards
            //card object is set to null as if all bool variables are false
            //the card object would have no value for the method to return
            Card cardValue1 = null;
            Card cardSuit1 = null;
            Card cardValue2 = null;
            Card cardSuit2 = null;
            Card cardValue3 = null;
            bool isValid = false;
            string equation = "";
            double answer = 0.0;
            double userAnswer = 0.0;

            Random random = new Random();
            int indexSuit = random.Next(SuitCardPack.Count);
            int indexValue = random.Next(SuitCardPack.Count);
            //loop to deal card out of fisher-yates shuffled card pack
            if (shufflingBool == true)
            {
                //condition which deals cards to form an equation
                if (ValueCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardValue1 = ValueCardPack[0];
                //ValueCardPack.RemoveAt(indexValue);

                if (SuitCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardSuit1 = SuitCardPack[0];
                //SuitCardPack.RemoveAt(indexValue);

                if (ValueCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardValue2 = ValueCardPack[1];
                //ValueCardPack.RemoveAt(indexValue);

                if (SuitCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardSuit2 = SuitCardPack[1];
                //SuitCardPack.RemoveAt(indexValue);

                if (ValueCardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                cardValue3 = ValueCardPack[2];
                //ValueCardPack.RemoveAt(indexValue);
            }
            else
            {
                //error message to catch any errors which may occur
                Console.WriteLine("Error: Unexpected error, contact IT support: ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Please Calculate the answer to this equation: \n" +
                $"(Use BODMAS to calculate your answer) ");

            equation = $"{cardValue1}{cardSuit1}{cardValue2}{cardSuit2}{cardValue3}";

            //calculates answer according to BODMAS
            answer = Math.Round(GetAnswerBODMAS(equation), 1);
            Console.WriteLine(answer);


            Console.WriteLine($"{equation} \n");

            //input type and range validation 
            do
            {
                Console.WriteLine("Enter your answer (decimal answers are accepted and answers are rounded to 1 decimal place): ");
                userAnswer = input.GetInputAndTypeValidate(userAnswer);
                isValid = input.ValidateRange(userAnswer, -1000.0, 9999.9);
            } while (!isValid);

            //object created to write the statistics to a file 'statistics.txt'
            writer.WriteLine($"Equation: {equation}");
            writer.WriteLine($"Answer: {answer}");
            writer.WriteLine($"Users Answer: {userAnswer}");
            writer.WriteLine("");//wrote to format the statistics better if more than one set is wrote to the file

            //condition to check weather the user is right or wrong
            if (userAnswer == answer)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }

        }

        public void CloseTxtFile()
        {
            writer.Close();
        }

        //created for testing purposes
        public void OutputPack()
        {
            //displays card pack for fisher-yates shuffle
            Console.WriteLine("--------- <Pack> ---------");
            foreach (var card in SuitCardPack)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("---- NEXT PACK ----");
            foreach (var card in ValueCardPack)
            {
                Console.WriteLine(card);
            }
        }

    }
}

