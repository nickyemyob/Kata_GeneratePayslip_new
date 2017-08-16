using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_GeneratePayslip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input format (first name, last name, annual salary, super rate (%), payment start date)
            string input = "David,Rudd,60050,9%,01 March – 31 March";

            string firstName, lastName, paymentPeriod, output;
            double superRate, annualSalary;

            string[] inputData = input.Split(',');
            firstName = inputData[0];
            lastName = inputData[1];
            annualSalary = double.Parse(inputData[2]);
            superRate = double.Parse(inputData[3]);


            //pay period = per calendar month
            paymentPeriod = inputData[4];
            //gross income = annual salary / 12 months
            double grossIncome = annualSalary / 12;
            //income tax = based on the tax table provide below ( this will be a function)

            //net income = gross income - income tax
            
            //super = gross income x super rate
            double super = grossIncome * superRate;





            string name = firstName + " " + lastName;


            //Output(name, pay period, gross income, income tax, net income, super)
            Console.WriteLine(input);
            //Console.WriteLine(output);

            Console.ReadKey();
        }

        static void payslipGen(double annualSalary, int superRate)
        {
            
        }

        static string Output(string name, string payPeriod, double grossIncome, double incomeTax, double netIncome, double super)
        {
            return "hello world";
        }
    }
}
