using System;
using System.Globalization;
using System.IO;

namespace _5_Exceptions
{

    public class PrinterFromHell
    {
        public void Print()
        {
            Random random = new Random();
            switch(random.Next(3))
            {
                case 0: throw new OutOfPaperException();
                case 1: throw new OutOfTonerException();
                case 2: throw new PaperJamException();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Ex1()
        {
            Console.WriteLine($" You wrote {ReadInteger()}");
        }

        private static int ReadInteger()
        {
            Console.WriteLine("Please enter an integer: ");
            string i = Console.ReadLine();
            try
            {
                return Convert.ToInt32(i);
            }
            catch (FormatException)
            {
                Console.WriteLine($"This was a character, only numbers from {int.MinValue} to {int.MaxValue} are integers. Please Try again.");
                return ReadInteger();
            }
            catch (OverflowException)
            {
                try
                {
                    long longInt = Convert.ToInt64(i);
                    if (longInt < 0)
                    { Console.WriteLine($"Number too small! Please enter at least {int.MinValue}"); }
                    else
                    {
                        Console.WriteLine($"Number too large! Please enter less than {int.MaxValue}");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Number too large or too small! Only numbers from {int.MinValue} to {int.MaxValue} are valid integers");
                }
                return ReadInteger();
            }
        }

        private static void Foo()
        {
        }

        private static void Notes()
        {
            try { Foo(); }
            catch
                (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try {/* exceptions kan ske*/}
            catch (NotImplementedException A)
            {
                /*Håndterer Exception A*/
                Console.WriteLine(A.Message);
                Console.WriteLine(A.Source); // Navn på program eller objekt der forårsagede exception.
                Console.WriteLine(A.TargetSite); // Detaljer om metode der forårsagede exception.
                Console.WriteLine(A.StackTrace); //. Call stak der førte til exception. ( Godt til testing / debugging)
                Console.WriteLine(A.InnerException); /*Når en exception kastes som resultat af en anden
                    exception, kan den oprindelige exception gemmes I denne property.
                    InnerException indeholder selv alle ovenstående properties.*/
            }
            catch (Exception B)
            { /*Håndterer Exception A*/
            }
            finally { /*Bliver altid udført - også ved uhåndterede exceptions */}
            // mere kode - bliver ikke udført hvis en exception ikke catches

            // videresend exception
            try { }
            catch (Exception ex)
            {
                // log
                throw; // samme exception genkastes
                //throw ex; // dårlig praktik, giver nyt stack trace
            }
        }
    }
}
