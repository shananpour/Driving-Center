using driving_center;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_Center
{
    class Student
    {
        public string FirstName;
        public string LastName;
        private int nationalCode;
        public string BirthDate;

         public int NationalCode
        {
            get { return nationalCode; }
            set { nationalCode = value; }
        }
        public int registreation(int studentcounter, string[,] studentarray)
        {
            Console.WriteLine("Enter name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter national code");
            string nationalCode = Console.ReadLine();
            Console.WriteLine("Enter birth date");
            string birthDate = Console.ReadLine();

            studentarray[studentcounter, 0] = firstName;
            studentarray[studentcounter, 1] = lastName;
            studentarray[studentcounter, 2] = nationalCode;
            studentarray[studentcounter, 3] = birthDate;
            studentcounter++;
             return studentcounter;
            //   Program.students.Add(firstName);

        }

        public void list(int studentcounter, string[,] studentarray)
        {

            for (int i = 0; i <= studentcounter; i++)
            {
                for (int j = 0; j < studentarray.GetLength(1); j++)
                {
                    Console.Write(studentarray[i, j] + "  ");
                }
                Console.WriteLine(" ");
            }
        }
        private  int search(string snationalcode,int studentcounter, string[,] studentarray)
        {
            int numberofsatr = -1;
            for (int i = 0; i <= studentcounter; i++)
            {
                for (int j = 0; j < studentarray.GetLength(1); j++)
                {
                    if (studentarray[i, j] == snationalcode)
                    {
                        numberofsatr = i;
                        j = studentarray.GetLength(1) + 1;
                        i = studentcounter + 1;

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
        public void Edite(string snationalcode,int studentcounter, string[,] studentarray)
        { 
            int i = search(snationalcode, studentcounter, studentarray);
            if (i != -1)
            {
                Console.Write("Enter FirstName  ");
                studentarray[i, 0] = Console.ReadLine();
                Console.Write("Enter LasttName  ");
                studentarray[i, 1] = Console.ReadLine();
                Console.Write("Enter birthday Date  ");
                studentarray[i, 3] = Console.ReadLine();
            }
        }
        public int Delete(string snationalcode, int studentcounter,string[,] studentarray)
        {
            int i = search(snationalcode, studentcounter, studentarray);
            if(i != -1)
            {
                for(int j=0;j< 4; j++)
                studentarray[i, j] = null;
               
                for(int c = i; c < studentcounter; c++)
                {
                    for (int j = 0; j < 4; j++)
                        studentarray[c, j] = studentarray[c + 1, j];
                }
                studentcounter--;
            }
            return studentcounter;
        }

    }
}
