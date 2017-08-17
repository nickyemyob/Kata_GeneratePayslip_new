﻿using System;
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
            //superRate = double.Parse(inputData[3]);


            //pay period = per calendar month
            paymentPeriod = inputData[4];
            //gross income = annual salary / 12 months
            double grossIncome = annualSalary / 12;
            //income tax = based on the tax table provide below ( this will be a function)

            //net income = gross income - income tax
            
            //super = gross income x super rate
            //double super = grossIncome * superRate;

            string name = firstName + " " + lastName;


            //Output(name, pay period, gross income, income tax, net income, super)
            Console.WriteLine(input);
            //Console.WriteLine(output);
            Console.WriteLine(IncomeTax(18202).ToString());

            Console.ReadKey();
        }

        static double IncomeTax(double annualSalary)
        {
            double taxableIncome;
            if (18200 < annualSalary && annualSalary <= 37000)
            {
                taxableIncome = (annualSalary - 18200) * 0.19;
            }
            else if (37000 < annualSalary && annualSalary <= 80000)
            {
                taxableIncome = 3572 + (annualSalary - 37000) * 0.325;
            }
            else if(80000 < annualSalary && annualSalary <= 180000)
            {
                taxableIncome = 17547 + (annualSalary - 80000) * 0.37;
            }
            else if(annualSalary > 180000)
            {
                taxableIncome = 54547 + (annualSalary - 180000) * 0.45;
            }
            else
            {
                taxableIncome = 0;
            }

            return taxableIncome;

        }

        static string Output(string name, string payPeriod, double grossIncome, double incomeTax, double netIncome, double super)
        {
            return "hello world";
        }
    }
}
