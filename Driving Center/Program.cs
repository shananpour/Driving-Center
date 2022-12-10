using Driving_Center;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace driving_center
{
    public class Program

    {
        //  public static ArrayList machinearray = new ArrayList();
        static int Machineitem(int ismainmenu, int machinecounter, string[,] machinearray)
        {
            // machinecounter = machinearray.Count;
            Machine machine = new Machine();

            Instructore instructor = new Instructore();
            bool secondmenucontinue = true;
            string backcontrol = "1";
            int numberchoosemenu2;
            while (secondmenucontinue)
            {
                if (backcontrol == "1")
                {
                    Console.Clear();
                }

                numberchoosemenu2 = Menu("Machine", ismainmenu);

                switch (numberchoosemenu2)
                {
                    case 1:
                        machinecounter = machine.registreation(machinecounter, machinearray);
                        break;

                    case 2:
                        machine.list(machinearray, machinecounter);

                        break;
                    case 3:
                        Console.WriteLine("Enter numberPlate");
                        string numberPlate = Console.ReadLine();
                        machine.Edite(numberPlate, machinearray, machinecounter);
                        break;
                    case 4:
                        Console.WriteLine("Enter numberPlate");
                        numberPlate = Console.ReadLine();
                        machinecounter = machine.Delete(numberPlate, machinearray, machinecounter);

                        break;
                    case 5:
                        ismainmenu = 1;
                        secondmenucontinue = false;
                        break;

                }
                if (ismainmenu == 0)
                {
                    do
                    {
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                        backcontrol = Console.ReadLine();

                    } while (backcontrol != "1");
                }

            }

            return machinecounter;
        }
        static int instructoritem(int ismainmenu, int instructioncounter, string[,] instructorarray)
        {
            Instructore instructor = new Instructore();
            bool secondmenucontinue = true;
            string backcontrol = "1";
            int numberchoosemenu2;
            int machinecounter = 0;
            while (secondmenucontinue)
            {
                if (backcontrol == "1")
                {
                    Console.Clear();
                }

                numberchoosemenu2 = Menu("Instructor", ismainmenu);

                switch (numberchoosemenu2)
                {
                    case 1:
                        instructioncounter = instructor.registreation(instructioncounter, instructorarray);
                        break;

                    case 2:
                        instructor.list(instructioncounter, instructorarray);
                        break;
                    case 3:
                        Console.WriteLine("Enter nationalcode");
                        string nationalcode = Console.ReadLine();
                        instructor.Edite(nationalcode, instructioncounter, instructorarray);
                        break;
                    case 4:
                        Console.WriteLine("Enter nationalcode");
                        nationalcode = Console.ReadLine();
                        instructioncounter = instructor.Delete(nationalcode, instructioncounter, instructorarray);

                        break;
                    case 5:
                        ismainmenu = 1;
                        secondmenucontinue = false;
                        break;

                }
                if (ismainmenu == 0)
                {
                    do
                    {
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                        backcontrol = Console.ReadLine();

                    } while (backcontrol != "1");
                }
            }
            return instructioncounter;
        }
        static int Studentitem(int ismainmenu, int studentcounter, string[,] studentarray)
        {
            Student student = new Student();
            bool secondmenucontinue = true;
            string backcontrol = "1";
            int numberchoosemenu2;
            while (secondmenucontinue)
            {
                if (backcontrol == "1")
                {
                    Console.Clear();
                }

                numberchoosemenu2 = Menu("student", ismainmenu);

                switch (numberchoosemenu2)
                {
                    case 1:
                        studentcounter = student.registreation(studentcounter, studentarray);
                        break;

                    case 2:
                        student.list(studentcounter, studentarray);
                        break;
                    case 3:
                        Console.WriteLine("please enter nationalcode  ");
                        string nationalcode = Console.ReadLine();
                        student.Edite(nationalcode, studentcounter, studentarray);
                        break;
                    case 4:
                        Console.WriteLine("please enter nationalcode  ");
                        nationalcode = Console.ReadLine();
                        studentcounter = student.Delete(nationalcode, studentcounter, studentarray);
                        break;
                    case 5:
                        ismainmenu = 1;
                        secondmenucontinue = false;
                        break;

                }
                if (ismainmenu == 0)
                {
                    do
                    {
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                        backcontrol = Console.ReadLine();

                    } while (backcontrol != "1");
                }
            }
            return studentcounter;

        }
        static int termitem(int ismainmenu,int termcounter,string[,] termarray) {
            DrivingTerm drivingTerm=new DrivingTerm();
            bool secondmenucontinue = true;
            string backcontrol = "1";
            int numberchoosemenu2;
            while (secondmenucontinue)
            {
                if (backcontrol == "1")
                {
                    Console.Clear();
                }

                numberchoosemenu2 = Menu("Driving Term", ismainmenu);

                switch (numberchoosemenu2)
                {
                    case 1:
                        termcounter = drivingTerm.registreation(termcounter, termarray);
                        break;

                    case 2:
                        drivingTerm.list(termcounter, termarray);
                        break;
                    case 3:
                        Console.WriteLine("please enter termlcode  ");
                        string termlcode = Console.ReadLine();
                        drivingTerm.Edite(termlcode, termcounter, termarray);
                        break;
                    case 4:
                        Console.WriteLine("please enter termcode  ");
                        termlcode = Console.ReadLine();
                        termcounter = drivingTerm.Delete(termlcode, termcounter, termarray);
                        break;
                    case 5:
                        ismainmenu = 1;
                        secondmenucontinue = false;
                        break;

                }
                if (ismainmenu == 0)
                {
                    do
                    {
                        Console.WriteLine("Enter NUMBER 1 TO BACK");
                        backcontrol = Console.ReadLine();

                    } while (backcontrol != "1");
                }
            }
            return termcounter;
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
                    Console.WriteLine("Please Just Insert A Number ");

                }
            } while (menucontineu);
            return number;
        }
        static void Main(string[] arg)
        {

            string[,] machinearray = new string[20, 5];
            string[,] instructorarray = new string[20, 5];
            string[,] studentarray = new string[20, 4];
            string[,] termarray=new string[20, 5];
          
            int machinecounter = 0;
            int studentcounter = 0;
            int instructioncounter = 0;
            int termcounter = 0;
            // int machinecounter = machinearray.Count;
            int ismainmenu = 1;
            int backcontrol = 1;
          
            bool secondmenucontinue = true;
            bool firstdmenucontinue = true;
            
            while (firstdmenucontinue)
            {
                int numberchoosemenu = Menu("", 1);
                ismainmenu = 0;
                int numberchoosemenu2;
                switch (numberchoosemenu)
                {
                    case 1:
                        machinecounter = Machineitem(ismainmenu, machinecounter, machinearray);
                        break;
                    case 2:
                        instructioncounter = instructoritem(ismainmenu, instructioncounter, instructorarray);

                        break;
                    case 3:
                        studentcounter = Studentitem(ismainmenu, studentcounter, studentarray);
                        break;
                    case 4:
                        termcounter = termitem(ismainmenu, termcounter, termarray);
                        break;
                    case 5:
                        //Console.Clear();
                        System.Environment.Exit(0);
                       // firstdmenucontinue = false;
                        break;
                }

            }
        }
    }
}