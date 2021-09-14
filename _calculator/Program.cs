using System;

namespace _calculator
{
    class Program
    {
        //This is the main method. when the program starts, this is the place where the code starts 
        static void Main(string[] args)
        {
            PrintMenu();
        }

        static void PrintMenu()
        {
            Console.WriteLine("-- Welcome to calculator --");
            Console.WriteLine("Press 1 to Add");
            Console.WriteLine("Press 2 to Substract");
            Console.WriteLine("Press 3 to Multiply");
            Console.WriteLine("Press 4 to Divide");
            Console.WriteLine("$- ");
            HandleInput();
        }

        static void HandleInput()
        {
            var input = Console.ReadLine();
            if (input.Length == 1)
            {
                //first we grab the Inputs from user
                (int a, int b) variables = GetVariables();

                float result = 0;

                //now we check what operation user selected. Is it Add / Substract etc
                switch (input)
                {
                    case "1":
                        result = Add(variables.a, variables.b); //after doing the calculation we want to store the result in a variable to be shown to the user later
                        break;
                    case "2":
                        result = Subtract(variables.a, variables.b);
                        break;
                    case "3":
                        result = Multiply(variables.a, variables.b);
                        break;
                    case "4":
                        result = Divide(variables.a, variables.b);
                        break;

                    default:
                        ReStart(); //incase the user inputs something other than 1 to
                        return;
                        break;
                }
                //When the operation is performed above, we simple call this method to print the result
                PrintResult(result);
            }
            else
            {
                ReStart();  // incase the user inputs some long number
            }
        }


        static (int a,int b) GetVariables()
        {
            //here we will get variables A and B to be performed calculations on
            Console.WriteLine("Please write input A:");
            string strA = Console.ReadLine();

            Console.WriteLine("Please write input B:");
            string strB = Console.ReadLine();

            //the input we got from user is in String datatype we need to convert it to Integer datatype
            int intA = Convert.ToInt32(strA);
            int intB = Convert.ToInt32(strB);

            //now we have the input in Integer form. Now we will return the input

            return (intA, intB);
        }

        //This method will print the result and display it to the user and then restart.
        static void PrintResult(float result)
        {
            Console.WriteLine("The result is: "+result);
            Console.ReadLine();
            ReStart();
        }

        static void ReStart()
        {
            Console.WriteLine("Lets go Again");
            PrintMenu();
        }

        //now lets implement the logic
        static float Add(int a, int b)
        {
            float answer = a + b;
            
            return answer;
        }

        static float Subtract(int a, int b)
        {
            float answer = a - b;

            return answer;
        }

        static float Multiply(int a, int b)
        {
            float answer = a * b;

            return answer;
        }

        static float Divide(int a, int b)
        {
            float answer = a / b;
            return answer;
        }
    }
}
