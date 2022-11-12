using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using _5_Exceptions;
using _6_Generics;
using Miniprojekt_1;
using _7_Delegates;
using Risk;
using _8_Collections;
using _9_Testing;
,
namespace OOP_Kursus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MiniProject();
            //KG5();
            //KG6();
            //_KG7();
            //PlayRisk();
            //KG8();
            Kg9();
        }

        private static void Kg9()
        {
        }

        private static void KG8()
        {
            //Ex1();
            Ex2();
            void Ex1()
            {
                PrintSequence(new Sequence(1, 2, 60));
                PrintSequence(new Sequence("f", 20));
            }
            void Ex2()
            {
                PrintSequence(new RandomNumbers(5));
                PrintSequence(new RandomNumbers(5, 10));
                PrintSequence(new RandomNumbers(5, 12,10));
            }
            void PrintSequence<T>(T s) where T : IEnumerable
            {
                foreach (int i in s)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }

        private static void PlayRisk()
        {
            (int, int) GetUserInput()
            {
                //Console.Write("Attacker Troops: ");
                //int att = int.Parse(Console.ReadLine());
                //Console.Write("Defender Troops: ");
                //int def = int.Parse(Console.ReadLine());
                //return (att, def);
                return (40, 20);
            }
            (int,int) troopsTuple = GetUserInput();
            Player attacker = new Attacker(troopsTuple.Item1);
            Player defender = new Defender(troopsTuple.Item2);

            RiskGame risk = new RiskGame();
            risk.Attack(attacker, defender);

        }

        private static void _KG7()
        {
            _E1();
            //_practise();
            void _E1()
            {
                KG7 kg7 = new KG7();
                List<string> Test=new List<string> { "this","is","a","test",";)"};
                string k = kg7.JoinThree("this","is","test",(string i,string j) => { return i + j; });
                Console.WriteLine(k);
                k = kg7.JoinAllStrings(Test, (string i, string j) => { return i + j; });
                Console.WriteLine(k);
                Console.WriteLine(kg7.JoinAllGeneric(new List<string> { "this", "is", "a", "test" },(a,b)=>a+b));
                Console.WriteLine(kg7.Exists((o) =>  o == 1, new int[] { 2, 3 }));
                Console.WriteLine(kg7.Twice((o) => o * 2, 1));
            }
            void _practise()
            {
                Practise p = new Practise();
                practise();
                void practise()
                {
                    {
                        int i;
                        int[] items = new int[5];
                        for (i = 0; i < items.Length; i++)
                        {
                            Console.Write("Enter an integer: ");
                            items[i] = int.Parse(Console.ReadLine());
                        }
                        BubbleSort(items, GreaterThan);
                        i = WriteItems(items);
                        BubbleSort(items, LessThan);
                        i = WriteItems(items);
                    }
                    bool GreaterThan(int first, int second)
                    {
                        return first > second;
                    }
                    bool LessThan(int first, int second)
                    {
                        return first < second;
                    }
                    void BubbleSort(
                    int[] items, Func<int, int, bool> compare)
                    {
                        int i;
                        int j;
                        int temp;
                        if (compare == null)
                        {
                            throw new ArgumentNullException(nameof(compare));
                        }
                        if (items == null)
                        {
                            return;
                        }
                        for (i = items.Length - 1; i >= 0; i--)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                if (compare(items[j - 1], items[j]))
                                {
                                    temp = items[j - 1];
                                    items[j - 1] = items[j];
                                    items[j] = temp;
                                }
                            }
                        }
                    }
                }
            }
        }

        private static int WriteItems(int[] items)
        {
            int i;
            for (i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
            }
            Console.WriteLine();
            return i;
        }

        public static void KG5()
        {
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            Ex7();
            void Ex7()
            {
                Car car = new Car();
                // correct turn on
                car.PressClutch();
                car.Ignition();
                car.ReleaseBreak();
                car.ReleaseClutch();
                try
                {
                    DoRandomMethods();
                }
                catch (ClutchNotPressedException)
                {
                    //Console.WriteLine("Remember to clutch before you ignite!");
                }
                catch (NotBreakedException)
                {
                    //Console.WriteLine("Only ignite when the break is pulled!");
                }
                finally
                {
                    Ex7();
                }
                void DoRandomMethods()
                {
                    Random random = new Random();
                    for (int i=0; i < 10; i++)
                    {
                        int rnd = random.Next(5);
                        switch(rnd)
                        {
                            case 0:
                                car.PressClutch(); 
                                break;
                            case 1:
                                car.Ignition(); 
                                break;
                            case 2:
                                car.PullBreak(); 
                                break;
                            case 3:
                                car.ReleaseBreak(); 
                                break;
                            case 4:
                                car.ReleaseClutch(); 
                                break;
                        }
                    }
                }

            }
            void Ex6()
            {
                PrinterFromHell pr = new PrinterFromHell(); 
                try 
                { 
                    pr.Print();
                }
                catch(PaperJamException)
                {
                    Console.WriteLine("Please open the printer, remove any paper that is stuck between the printing chamber and dejam the printer. Press any button on the main desk to continue.");
                }
                catch(OutOfPaperException)
                {
                    Console.WriteLine("The paper has run empty. Please open the paper casket and make sure that enough paper is inside the printer. If not, please take care of that.");
                }
                catch(OutOfTonerException)
                { 
                    Console.WriteLine("There is no ink left my man. Please go to our website via opening your browser and typing https://www.get-new-toner.com/yes-i-want-to-order/12/9876124424?order=true"); 
                }
                finally 
                {
                    Console.Write("Press enter if you're done");
                    Console.Read();
                    Console.Clear();
                    Ex6();
                }
            }
            void Ex5()
            {
                DigitBox digitBox = new DigitBox();
                while(true)
                {
                    Console.Write("1 to see a digit, 2 to set a digit: ");
                    try 
                    {
                        switch (int.Parse(Console.ReadLine()))
                        { 
                            case 1:
                                Console.Write("What digit do you want to see? Digit: ");
                                Console.WriteLine(digitBox.GetDigit(int.Parse(Console.ReadLine())));
                                break; 
                            case 2:
                                Console.Write("What digit do you want to set? Digit: ");
                                int i = (int.Parse(Console.ReadLine()));
                                Console.Write("What value do you want to set= Value: ");
                                int v = (int.Parse(Console.ReadLine()));
                                digitBox.SetDigit(i, v);
                                break; 
                        }
                    }
                    catch(FormatException) { Console.WriteLine("Digit has to an integer"); }
                    catch (IllegalDigitException) { Console.WriteLine("Digit has to be between -9 and 9"); }
                    catch (NoSuchDigitException) { Console.WriteLine("Only digits 0-3 exist"); }
                }
            }
            void Ex4()
            {
                GearBox gb = new GearBox();
                while (true)
                {
                    Console.WriteLine($"current gear: {gb.gear}");
                    Console.Write("Change gear: ");
                    string newGear = Console.ReadLine();
                    try
                    {
                        gb.changeGear(int.Parse(newGear));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("New gear has to be an integer");
                    }
                    catch(IllegalGearChangeException)
                    {
                        Console.WriteLine("Gear change has to be legal");
                    }
                    catch(ArgumentException)
                    {
                        Console.WriteLine("Gear has to be between -1 and 5");
                    }
                }
            }
            void Ex2()
        {
            FileSystemMenu Browse = new FileSystemMenu("exercise 2", new DirectoryInfo("C:\\Users\\User\\OneDrive - Aalborg Universitet\\Uni\\SW3\\OOP\\4 afleveringsopgave\\aflevering 1 fælles V2\\5 Exceptions\\ex 2 random dir"));
            Browse.ExpandMenuItem();
        }
            void Ex3()
            {
                try
                {
                    BancAccount acc = new BancAccount(-500);

                }
                catch (InsufficientFundsException)
                {
                    Console.WriteLine("Balance May not be negative");
                }
                try
                {
                    BancAccount acc1 = new BancAccount(500);
                    acc1.Withdraw(600);
                }
                catch (InsufficientFundsException)
                {
                    Console.WriteLine("Balance May not be negative");
                }
            }
        }
        public static void KG6()
        {
            //Ex1();
            E2();
            void E2()
            {
                int i = 2;
                double d = 3.1;
                Pair<int,double> p = new Pair<int, double>(i,d);
                B();
                void B()
                {
                    Console.WriteLine(p.Swap());
                }
            }
            void Ex1()
            {
                int[] a1 = { 1, 2, 3, 4, 5, 6 };
                int[] a2 = { 6, 5, 4, 3, 2, 1 };
                List<int> l1 = new List<int>() { 1, 2, 3, 8, 5, 3, 1 };
                Ex1a();
                Ex1b();
                C();
                void C()
                {
                    Console.Write("a1: ");
                    WriteArray(a1);
                    HandyMethods<int>.Shuffle(a1);
                    Console.Write("a1 shuffled: ");
                    WriteArray(a1);
                }
                void Ex1b()
                {
                    try
                    {

                    Console.Write("a1: ");
                    WriteArray(a1);
                    Console.Write("a2: ");
                    WriteArray(a2);
                    HandyMethods<int>.Copy(a1, a2);
                    Console.Write("a2 copied a1: ");
                    WriteArray(a2);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Error: Arrays have wrong length");
                    }
                }
                void WriteArray<T>(IList<T> a) 
                {
                    foreach(T i in a)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }

                void Ex1a()
                {
                    Console.Write("l1: ");
                    WriteArray(l1);
                    Console.WriteLine($"Max Element of l1: {HandyMethods<int>.Max(l1)}");
                    Console.WriteLine($"Min Element of l1: {HandyMethods<int>.Min(l1)}");
                }
            }

        }


        public static void MiniProject()
        {
            Menu menu = new Menu(" fancymenu ");
            menu.Add(
                new MenuItem(
                    " Punkt1 ",
                    " Indhold af punkt 1... det er indtil videre bare tekst "
            ));
            menu.Add(
                new MenuItem(
                    " Punkt2 ",
                    " Indhold af punkt 2... det er indtil videre også bare tekst "
            ));
            menu.Add(
                new MenuItem(
                    "Et lidt længere menupunkt ",
                    " Indhold af punkt 3... det er indtil videre også bare tekst "
            ));

            Menu menu2 = new Menu(" fancymenu 2 ");
            menu2.Add(
                new MenuItem(
                    " Punkt1.2 ",
                    " Indhold af punkt 1... det er indtil videre bare tekst "
            ));
            menu2.Add(
                new MenuItem(
                    " Punkt2.2 ",
                    " Indhold af punkt 2... det er indtil videre også bare tekst "
            ));
            menu2.Add(
                new MenuItem(
                    "Et lidt længere menupunkt.2 ",
                    " Indhold af punkt 3... det er indtil videre også bare tekst "
            ));
            menu.Add(menu2);
            menu.Add(new InfiniteMenu("Uendelig menu"));
            menu.Add(new FileSystemMenu("Browse my Drive", new DirectoryInfo("C:\\Users\\User\\OneDrive - Aalborg Universitet\\Uni")));
            menu.ExpandMenuItem();
        }

    }
}
