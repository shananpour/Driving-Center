using Driving_Center;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace driving_center
{
    public class Program

    {
        public static List<Student> studentList = new List<Student>();
        public static List<Instructore> instructoreList = new List<Instructore>();
        public static List<Machine> machineList = new List<Machine>();
        public static List<DrivingTerm> termList = new List<DrivingTerm>();
        static void MachineItem(int isMainMenu)
        {
            Machine machine = new Machine();


            bool secondmMenuContinue = true;
            string backControl = "1";
            int numberChooseMenu;
            while (secondmMenuContinue)
            {
                if (backControl == "1")
                {
                    Console.Clear();
                }

                numberChooseMenu = Menu("Machine", isMainMenu);

                switch (numberChooseMenu)
                {
                    case 1:
                        machine.Registreation();
                        break;

                    case 2:
                        machine.List();
                        break;
                    case 3:
                        machine.Edite();
                        break;
                    case 4:
                        machine.Delete();
                        break;
                    case 5:
                        isMainMenu = 1;
                        secondmMenuContinue = false;
                        break;

                }
                if (isMainMenu == 0)
                {
                    do
                    {
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                        backControl = Console.ReadLine();

                    } while (backControl != "1");
                }

            }

        }
        static void InstructorItem(int isMainMenu)
        {
            Instructore instructor = new Instructore();
            bool secondMenuContinue = true;
            string backControl = "1";
            int numberChooseMenu;
            //  int machinecounter = 0;
            while (secondMenuContinue)
            {
                if (backControl == "1")
                {
                    Console.Clear();
                }

                numberChooseMenu = Menu("Instructor", isMainMenu);

                switch (numberChooseMenu)
                {
                    case 1:
                        instructor.Registreation();
                        break;
                    case 2:
                        instructor.List();
                        break;
                    case 3:
                        instructor.Edite();
                        break;
                    case 4:
                        instructor.Delete();
                        break;
                    case 5:
                        isMainMenu = 1;
                        secondMenuContinue = false;
                        break;

                }
                if (isMainMenu == 0)
                {
                    do
                    {
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                        backControl = Console.ReadLine();

                    } while (backControl != "1");
                }
            }

        }
        static void StudentItem(int isMainMenu)
        {
            Student student = new Student();
            bool secondMenuContinue = true;
            string backControl = "1";
            int numberChooseMenu2;
            while (secondMenuContinue)
            {
                if (backControl == "1")
                {
                    Console.Clear();
                }

                numberChooseMenu2 = Menu("student", isMainMenu);

                switch (numberChooseMenu2)
                {
                    case 1:
                        student.Registreation();
                        break;
                    case 2:
                        student.List();
                        break;
                    case 3:
                        student.Edite();
                        break;
                    case 4:
                        student.Delete();
                        break;
                    case 5:
                        isMainMenu = 1;
                        secondMenuContinue = false;
                        break;
                }
                if (isMainMenu == 0)
                {
                    Console.WriteLine("Enter NUMBER 1 TO BACK");
                    do
                    {
                        backControl = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                    } while (backControl != "1");
                }
            }

        }
        static void TermItem(int ismainmenu)
        {
            DrivingTerm drivingTerm = new DrivingTerm();
            bool secondMenuContinue = true;
            string backControl = "1";
            int numberChooseMenu;
            while (secondMenuContinue)
            {
                if (backControl == "1")
                {
                    Console.Clear();
                }

                numberChooseMenu = Menu("Driving Term", ismainmenu);

                switch (numberChooseMenu)
                {
                    case 1:
                        drivingTerm.Registreation();
                        break;
                    case 2:
                        drivingTerm.List();
                        break;
                    case 3:
                        drivingTerm.Edite();
                        break;
                    case 4:
                        drivingTerm.Delete();
                        break;
                    case 5:
                        ismainmenu = 1;
                        secondMenuContinue = false;
                        break;

                }
                if (ismainmenu == 0)
                {
                    do
                    {
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                        backControl = Console.ReadLine();

                    } while (backControl != "1");
                }
            }
        }
        static int Menu(string input, int ismainmenu)
        {
            int number = 0;
            bool menucontineu = true;
            do
            {
                if (ismainmenu == 1)
                {
                    Console.WriteLine("1. Machine");
                    Console.WriteLine("2.Instructor");
                    Console.WriteLine("3.Student");
                    Console.WriteLine("4.Driving Term");
                    Console.WriteLine("5.End");
                    Console.Write("Entere the number  ");
                }
                else
                {

                    Console.WriteLine("1. " + input + " registration");
                    Console.WriteLine("2. " + input + " Lists");
                    Console.WriteLine("3. Edite " + input);
                    Console.WriteLine("4. Delete " + input);
                    Console.WriteLine("5. Back To Main Manu");
                }

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if ((number > 5) || (number < 1))
                    {
                        Console.WriteLine("Enter a number betwen 1 to 5");

                    }
                    else
                    {
                        menucontineu = false;

                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message +" Please Just Insert A Number ");

                }
            } while (menucontineu);
            return number;
        }
        static void Main(string[] arg)
        {
            int isMainMenu = 1;
            int backControl = 1;

            bool secondMenuContinue = true;
            bool firstdMenuContinue = true;

            while (firstdMenuContinue)
            {
                int numberChooseMenu = Menu("", 1);
                isMainMenu = 0;
                int numberChooseMenu2;
                switch (numberChooseMenu)
                {
                    case 1:
                        MachineItem(isMainMenu);
                        break;
                    case 2:
                        InstructorItem(isMainMenu);
                        break;
                    case 3:
                        StudentItem(isMainMenu);
                        break;
                    case 4:
                        TermItem(isMainMenu);
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
