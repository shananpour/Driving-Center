using driving_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_Center
{
    internal class Instructore
    {
        public string firstName;
        public string lastName;
        public int instructoreCode;
        public int nationalCode;
        public string document;

        public int registreation(int instructioncounter, string[,] instructorarray)

        {
            Console.WriteLine("Enter firstName");
            instructorarray[instructioncounter, 0] = Console.ReadLine();
            Console.WriteLine("Enter lastName");
            instructorarray[instructioncounter, 1] = Console.ReadLine();
            Console.WriteLine("Enter instructoreCode");
            instructorarray[instructioncounter, 2] = Console.ReadLine();
            Console.WriteLine("Enter nationalCode");
            instructorarray[instructioncounter, 3] = Console.ReadLine();
            Console.WriteLine("Enter document");
            instructorarray[instructioncounter, 4] = Console.ReadLine();
            instructioncounter++;
            // Program.students.Add()
            return instructioncounter;
         }
        public void list(int instructioncounter,string[,] instructorarray)
        {
           
            for (int i = 0; i <= instructioncounter; i++)
            {
                for (int j = 0; j < instructorarray.GetLength(1); j++)
                {
                    Console.Write(instructorarray[i, j] + "  ");
                }
                Console.WriteLine(" ");
            }
        }
        private int search(string snationalcode,int instructioncounter, string[,] instructorarray)
        {
            int numberofsatr = -1;
            for (int i = 0; i <= instructioncounter; i++)
            {
                for (int j = 0; j < instructorarray.GetLength(1); j++)
                {
                    if (instructorarray[i, j] == snationalcode)
                    {
                        numberofsatr = i;
                        j = instructorarray.GetLength(1) + 1;
                        i = instructioncounter + 1;

                    }

                }

            }
            if (numberofsatr == -1)
            {
                Console.WriteLine("there is no student whith this national Number");
                numberofsatr = -1;
            }
            return numberofsatr;
        }
        public void Edite(string snationalcode,int instructioncounter, string[,] instructorarray)
        {
            int i = search(snationalcode, instructioncounter, instructorarray);
            if (i != -1)
            {
                Console.Write("Enter FirstName  ");
                instructorarray[i, 0] = Console.ReadLine();
                Console.Write("Enter LasttName  ");
                instructorarray[i, 1] = Console.ReadLine();
                Console.Write("Enter instructoreCode  ");
                instructorarray[i, 2] = Console.ReadLine();
                Console.Write("Enter document  ");
                instructorarray[i, 4] = Console.ReadLine();
            }
        }
        public int Delete(string snationalcode, int instructioncounter,string[,] instructorarray)
        {
            int i = search(snationalcode, instructioncounter, instructorarray);
            if (i != -1)
            {
                for (int j = 0; j < 5; j++)
                    instructorarray[i, j] = null;

                for (int c = i; c < instructioncounter; c++)
                {
                    for (int j = 0; j < 5; j++)
                        instructorarray[c, j] = instructorarray[c + 1, j];
                }
                instructioncounter--;
            }
            return instructioncounter;
        }
    }
}
