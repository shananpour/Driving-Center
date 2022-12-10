using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_Center
{
    internal class DrivingTerm
    {
        public string startdate;
        public string enddate;
        private int termcode;
        public int stucode;
        public int instructorcode;

        public int Termcode
        {
            get { return termcode; }
            set { termcode = value; }
        }
        public int registreation(int termcounter, string[,] termarray)
        {
            Console.WriteLine("Enter startdate");
            termarray[termcounter, 0] = Console.ReadLine();
            Console.WriteLine("Enter enddate");
            termarray[termcounter, 1] = Console.ReadLine();
            Console.WriteLine("Enter termcode");
            termarray[termcounter, 2] = Console.ReadLine();
            Console.WriteLine("Enter stucode");
            termarray[termcounter, 3] = Console.ReadLine();
            Console.WriteLine("Enter instructorcode");
            termarray[termcounter, 4] = Console.ReadLine();
            termcounter++;
            return termcounter;

        }

        public void list(int termcounter, string[,] termarray)
        {

            for (int i = 0; i <= termcounter; i++)
            {
                for (int j = 0; j < termarray.GetLength(1); j++)
                {
                    Console.Write(termarray[i, j] + "  ");
                }
                Console.WriteLine(" ");
            }
        }
        private int search(string termcode, int termcounter, string[,] termarray)
        {
            int numberofsatr = -1;
            for (int i = 0; i <= termcounter; i++)
            {
                for (int j = 0; j < termarray.GetLength(1); j++)
                {
                    if (termarray[i, j] == termcode)
                    {
                        numberofsatr = i;
                        j = termarray.GetLength(1) + 1;
                        i = termcounter + 1;

                    }

                }

            }
            if (numberofsatr == -1)
            {
                Console.WriteLine("there is no Driving Term whith this  code");
                numberofsatr = -1;
            }
            return numberofsatr;
        }
        public void Edite(string termcode, int termcounter, string[,] termarray)
        {
            int i = search(termcode, termcounter, termarray);
            if (i != -1)
            {
                Console.Write("Enter FirstName");
                termarray[i, 0] = Console.ReadLine();
                Console.Write("Enter LasttName");
                termarray[i, 1] = Console.ReadLine();
                Console.Write("Enter birthday Date");
                termarray[i, 3] = Console.ReadLine();
            }
        }
        public int Delete(string termcode, int termcounter, string[,] termarray)
        {
            int i = search(termcode, termcounter, termarray);
            if (i != -1)
            {
                for (int j = 0; j < 5; j++)
                    termarray[i, j] = null;

                for (int c = i; c < termcounter; c++)
                {
                    for (int j = 0; j < 5; j++)
                        termarray[c, j] = termarray[c + 1, j];
                }
                termcounter--;
            }
            return termcounter;
        }

    }


}
