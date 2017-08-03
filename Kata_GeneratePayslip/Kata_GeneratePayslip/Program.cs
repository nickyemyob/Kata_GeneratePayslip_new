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
            int superRate, annualSalary;

            string[] inputData = input.Split(',');
            firstName = inputData[0];
            lastName = inputData[1];
            annualSalary = Int32.Parse(inputData[2]);
            superRate = inputData[3];
            paymentPeriod = inputData[4];

            //pay period = per calendar month
            //gross income = annual salary / 12 months
            //income tax = based on the tax table provide below
            //net income = gross income - income tax
            //super = gross income x super rate




            //Output(name, pay period, gross income, income tax, net income, super)
            Console.WriteLine(input);
            //Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
