using System;
using System.Xml.Serialization;

namespace Taschenrechner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintMenu();
            int choice = 1000;
            do
            {
                choice = LetUserChoose();
                double numberOne = 0;
                double numberTwo = 0;
                double result = 0;
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        numberOne = Convert.ToInt32(Console.ReadLine());
                        numberTwo = Convert.ToInt32(Console.ReadLine());
                        result = Addition(numberOne, numberTwo);
                        Console.WriteLine("Ihr resultat: {0}", result);
                        break;
                    case 2:
                        numberOne = Convert.ToInt32(Console.ReadLine());
                        numberTwo = Convert.ToInt32(Console.ReadLine());
                        result = Subtraktion(numberOne, numberTwo);
                        Console.WriteLine("Ihr resultat: {0}", result);
                        break;
                    case 3:
                        numberOne = Convert.ToInt32(Console.ReadLine());
                        numberTwo = Convert.ToInt32(Console.ReadLine());
                        result = Multiplikation(numberOne, numberTwo);
                        Console.WriteLine("Ihr resultat: {0}", result);
                        break;
                    case 4:
                        numberOne = Convert.ToInt32(Console.ReadLine());
                        numberTwo = Convert.ToInt32(Console.ReadLine());
                        result = Division(numberOne, numberTwo);
                        Console.WriteLine("Ihr resultat: {0}", result);
                        break;
                }
            } while (choice != 0);
        }

        private static double Division(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }

        private static double Multiplikation(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }

        private static double Subtraktion(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }

        private static double Addition(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        private static int LetUserChoose()
        {
            int usersChoice = Convert.ToInt32(Console.ReadLine());
            return usersChoice;
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Folgende Operationen stehen zur Auswahl");
            Console.WriteLine("Geben Sie die Zahl 1 für Addition ein");
            Console.WriteLine("Geben Sie die Zahl 2 für Subtraktion ein");
            Console.WriteLine("Geben Sie die Zahl 3 für Multiplikation ein");
            Console.WriteLine("Geben Sie die Zahl 4 für Division ein");
            Console.WriteLine("Geben Sie die Zahl 0 ein, um die Applikation zu beenden");
        }
    }
}