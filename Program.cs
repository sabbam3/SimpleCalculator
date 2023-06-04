using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                bool statusOfCycle = false;
                string num1, num2, mathOperator;
                double number1 = 0, number2 = 0;
                while (statusOfCycle == false) //Atrialebs ikamde sanam ricxvs ar chawer
                {
                    Console.Write("Enter First number: ");
                    num1 = Console.ReadLine();
                    number1 = ConvertNumberToDouble(num1);
                    statusOfCycle = ReturnTryParse(num1);
                }
                statusOfCycle = false;
                while (statusOfCycle == false)//Atrialebs ikamde sanam ricxvs ar chawer
                {
                    Console.Write("Enter Second number: ");
                    num2 = Console.ReadLine();
                    number2 = ConvertNumberToDouble(num2);
                    statusOfCycle = ReturnTryParse(num2);
                }
                statusOfCycle = false;
                while(statusOfCycle == false)//Atrialebs ikamde sanam swor matematikur operacias ar airchev
                {
                    Console.Write("Enter Math Operator: ");
                    mathOperator = Console.ReadLine();
                    Console.WriteLine(Calculate(number1, number2, mathOperator));
                    if (Calculate(number1, number2, mathOperator) == "That math operator does not exist")
                    {
                        statusOfCycle = false;
                    }
                    else
                    {
                        statusOfCycle = true;
                    }
                }
            }
        }
        static string Calculate(double num1, double num2, string mathOperator) //Asrulebs matematikur operaciebs
        {
            if (mathOperator == "+") { return Convert.ToString(num1 + num2); }
            else if (mathOperator == "-") { return Convert.ToString(num1 - num2); }
            else if (mathOperator == "*") { return Convert.ToString(num1 * num2); }
            else if (mathOperator == "/" && num2 != 0) { return Convert.ToString(num1 / num2); }
            else if (mathOperator == "/" && num2 == 0) { return "Cant Devide by 0"; }
            else return "That math operator does not exist";
        }
        static double ConvertNumberToDouble(string toBeConvertedNumber)//Amowmebs da abrunebs konvertirebul ricxvs  
        {
            double convertDouble;
            if (double.TryParse(toBeConvertedNumber, out convertDouble) != false)
            {
                return convertDouble;
            }
            else 
            {
                Console.WriteLine($"{toBeConvertedNumber} is not a number");  
                return 0;
            } 
        }
        static bool ReturnTryParse(string toBeCheckedNumber)//Abrunebs konvertaciis shedegs
        {
           double checkDouble;
           return double.TryParse(toBeCheckedNumber, out checkDouble); 
        }
    }

}
