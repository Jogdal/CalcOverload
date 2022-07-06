using System;




namespace CalculatorApp
{
    public class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("This is a calculator wich ables you to make calculations of two or more numbers ");
            Console.WriteLine();
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine();
            return;
        }

        public static double OperandAddition(double numberOne, double numberTwo)
        { return numberOne + numberTwo; }

        public static double OperandAddition(double[] numbers)
        {
            double summa = 0;
            foreach (double number in numbers)
            {
                summa = summa + number; 
            }
            return summa; 
        }


        public static double OperandSubtraction(double numberOne, double numberTwo)
        { return numberOne - numberTwo; }

        public static double OperandSubtraction(double[] numbers)
        {
            double summa = 0;
            double firstNumber = numbers[0] + numbers[0];
            summa = firstNumber;
            foreach (double number in numbers)
            {
                Console.WriteLine(number);
                summa = summa - number;
            }
            Console.WriteLine("Summa subtraction : " + summa);
            return summa;
        }



        public static double OperandMultiplication(double numberOne, double numberTwo)
        { return numberOne * numberTwo; }

        public static double OperandDivision(double numberOne, double numberTwo)
        {
            if (numberOne == 0)
            {
                return 0;
            }
            if (numberTwo == 0)
            {
                // Skall returnera infinity värde
                Console.WriteLine("Division med 0 ger ett oändligt stort tal!");
                Console.WriteLine("Press <Enter> to continue !");
                Console.ReadLine();
                return 999999;
            }
            return numberOne / numberTwo;
        }


        static void Main(string[] args)
        {

            double[] numbers;

            ConsoleKeyInfo cki;
            // Console.TreatControlCAsInput = true;    // Prevent example from ending if CTRL+C is pressed.

            do
            {
                Console.WriteLine("Guten Morgen Eurex Traders!");
                Console.WriteLine();
                PrintMenu();
                Console.WriteLine("Enter numbers separated by commasign:");

                double result = 0;
                double numberOne = 0;
                double numberTwo = 0;
                string enteredNumbers = Console.ReadLine();
                string[] numbersList = enteredNumbers.Split(",");
                double[] doubleNumbers = new double[numbersList.Length];
                int nrInputs = 0;
                int i = 0;

                foreach (string number in numbersList)
                {
                    nrInputs++;
                    doubleNumbers[i] = Convert.ToDouble(number);
                    i++;
                }

                if (nrInputs == 2)
                {
                    numberOne = doubleNumbers[0];
                    numberTwo = doubleNumbers[1];
                    OperandAddition(numberOne, numberTwo);
                } 
                else
                {
                    result = OperandAddition(doubleNumbers);
                }
                
                Console.Write("Enter operand :");
                int userOperand = Convert.ToInt32(Console.ReadLine());
                
                switch (userOperand)
                {
                    case 1: { if (nrInputs == 2)
                            {
                                result = OperandAddition(numberOne, numberTwo); break;
                                Console.WriteLine("Enkel addition method used!");
                            }
                            else
                            {
                                result = OperandAddition(doubleNumbers);
                                break;
                            }
                        }


                    case 2: { if (nrInputs == 2)
                              {
                                 result = OperandSubtraction(numberOne, numberTwo);
                                Console.WriteLine("Enkel subtraction used!");
                                break;
                            }
                            else
                              {
                                 result = OperandSubtraction(doubleNumbers);
                                 Console.WriteLine("Resltat flera subtractioner : " + result);
                                break;
                              }
                            }

                    case 3: { result = OperandMultiplication(numberOne, numberTwo); break; }
                    case 4: { result = OperandDivision(numberOne, numberTwo); break; }
                }

                Console.WriteLine();
                Console.WriteLine("The result is " + result);
                Console.WriteLine();
                Console.WriteLine("Press any key to make a new calculation - Press C to quit");
                cki = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("You pressed " + cki.Key.ToString());
            } while (cki.Key != ConsoleKey.C);
        }
    }
}
