using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeinsurancequotes
{
    class Program
    {

        public static void Main(string[] args)
        {
            int DOB = 0; // Change to actual DOB 
            string Gender = null;
            string Finalquote = null;
            double Basequote = 0;
            string RHI = null; //Regional health index
            bool Child = false;
            bool Smoker = false;

            Console.Write("Please enter your Date Of Birth:");

            DOB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"DOB is :{DOB}"); //debug
            Console.Write("Please enter your Gender:");
            string input = Console.ReadLine();
            switch (input.ToLower()) //add error correction
            {
                case "M":
                case "m":
                case "Male":
                case "male":
                    Gender = "Male";
                    break;

                case "F":
                case "f":
                case "Female":
                case "female":
                    Gender = "Female";
                    break;


            }
            // Console.WriteLine($"DOB = {DOB}"); //debug
            Console.WriteLine($"Gender selected:{Gender}"); //debug

            if (DOB <= 18 && Gender == "Male")
            {
                Basequote = 150;
            }
            if (DOB <= 18 && Gender == "Female")
            {
                Basequote = 100;
            }
            if (DOB >= 19 && DOB <= 24 && Gender == "Male")
            {
                Basequote = 180;
            }
            if (DOB >= 19 && DOB <= 24 && Gender == "Female")
            {
                Basequote = 165;
            }
            if (DOB >= 25 && DOB <= 34 && Gender == "Male")
            {
                Basequote = 200;
            }
            if (DOB >= 25 && DOB <= 34 && Gender == "Female")
            {
                Basequote = 180;
            }
            if (DOB >= 35 && DOB <= 44 && Gender == "Male")
            {
                Basequote = 250;
            }
            if (DOB >= 35 && DOB <= 44 && Gender == "Female")
            {
                Basequote = 225;
            }
            if (DOB >= 45 && DOB <= 59 && Gender == "Male")
            {
                Basequote = 320;
            }
            if (DOB >= 45 && DOB <= 59 && DOB <= 59 && Gender == "Female")
            {
                Basequote = 315;
            }
            if (DOB >= 60 && Gender == "Male")
            {
                Basequote = 500;
            }
            if (DOB >= 60 && Gender == "Female")
            {
                Basequote = 500;
            }

            Console.WriteLine($"Intial Base price is:{Basequote}"); //debug

            Console.Write("Please enter your location:");
            string input2 = Console.ReadLine();
            switch (input2.ToLower()) //add error corrections
            {
                case "ENG":
                case "Eng":
                case "eng":
                case "England":
                case "england":
                case "ENGLAND":
                    RHI = "England";
                    Basequote = Basequote + 0;
                    break;

                case "WALES":
                case "Wales":
                case "wales":
                    RHI = "Wales";
                    Basequote = Basequote - 100;
                    break;

                case "Scot":
                case "scot":
                case "SCOT":
                case "SCOTLAND":
                case "Scotland":
                    RHI = "Scotland";
                    Basequote = Basequote + 200;
                    break;

                case "IRE":
                case "Ire":
                case "IRELAND":
                case "Ireland":
                case "ireland":
                    RHI = "Ireland";
                    Basequote = Basequote + 50;
                    break;

                case "North Ire": //Not working? 
                case "NORTH IRE":
                case "NORTHERN IRELAND":
                case "Northern Ireland":
                case "northern ireland":
                    RHI = "Northern Ireland";
                    Basequote = Basequote + 75;
                    break;

                case "OTHER":
                case "Other":
                case "other":
                    RHI = "Other";
                    Basequote = Basequote + 100;
                    break;

            }
            Console.WriteLine($"Location selected:{RHI}"); //debug



            Console.WriteLine($"Base price with location is:{Basequote}"); //debug

            Console.Write("Do you have children Yes) or No)?:");
            string input3 = Console.ReadLine();
            switch (input3.ToLower()) //add error correction
            {
                case "Yes":
                case "yes":
                case "y":
                case "Y":
                case "true":
                case "True":
                case "T":
                case "t":
                    Child = true;
                    Basequote = Basequote * 1.5; //50% premium increase
                    break;

                case "No":
                case "no":
                case "n":
                case "N":
                case "false":
                case "False":
                case "F":
                case "f":
                    Child = false;
                    break;
            }
            Console.WriteLine($"Children?:{Child}"); //debug
            Console.WriteLine($"Base price with children is:{Basequote}"); //debug

            Console.Write("Do you Smoke Yes) or No)?:");

            string input4 = Console.ReadLine();
            switch (input4.ToLower()) //add error correction
            {
                case "Yes":
                case "yes":
                case "y":
                case "Y":
                case "true":
                case "True":
                case "T":
                case "t":
                    Smoker = true;
                    Basequote = Basequote * 3; //300% Premium increase
                    break;

                case "No":
                case "no":
                case "n":
                case "N":
                case "false":
                case "False":
                case "F":
                case "f":
                    Smoker = false;
                    break;

            }
            Console.WriteLine($"Smoker?:{Smoker}"); //debug
            Console.WriteLine($"Base price with smoking is:{Basequote}"); //debug

            Console.Write("How much do you exercise per week in hours:");
            string input5 = Console.ReadLine();
            switch (input5.ToLower()) //add error correction
            {
                case "0":
                    Basequote = Basequote * 1.2; //20% premium increase
                    break;

                case "1":
                case "2":
                    Console.WriteLine("Basequote unchanged");
                    break;

                case "3":
                case "4":
                case "5":
                    Basequote = Basequote * 0.7; //30% premium reduction
                    break;

                case "6":
                case "7":
                case "8":
                    Basequote = Basequote * 0.5; //50% premium reduction
                    break;

                case "9":
                case "10":
                case "11":
                case "12":
                    Basequote = Basequote * 1.5; //50% premium increase
                    break;

            }
            if (Basequote < 50) //If end quote is not a value 50 or greater round up to 50
            {
                Basequote = 50;
            }
            Finalquote = Convert.ToString(Basequote);
            Finalquote = Finalquote.Insert(0, "£"); //insert Pound sterling sign to beginning of quote
            Console.WriteLine($"Final Quote is:{Finalquote}"); //Displays final quote to customer
        }
    }
}

