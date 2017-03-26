using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userEmail;
            int userAge;   
                                       
                Console.Write("Geben sie ihren Namen:");
                userName = Console.ReadLine();
                Console.WriteLine("Hallo " + userName);

                    if (Regex.IsMatch(userName, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Richtig");
                    }

                    else

                    {
                        Console.WriteLine("Falsch");
                    }

                Console.Write("Bitte geben sie ihr alter ein: ");
                userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sie sind " + userAge +  " Jahre alt ");
                Console.WriteLine("Bitte geben sie hier ihre E-mail adresse ein: ");
                userEmail = Console.ReadLine();
                Console.WriteLine("Ihre e-mail adresse lautet: " + userEmail);


                Console.ReadLine();


              
            
        }
    }

}

    

