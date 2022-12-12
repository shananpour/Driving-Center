using driving_center;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Driving_Center
{
    public class DrivingTerm
    {
        public string startDate;
        public string endDate;
        public string termCode { get; set; }
        public string studentCode;
        public string instructorCode;


        public void Registreation()
        {
            Console.WriteLine("Enter Start Date");
            startDate = Console.ReadLine();
            Console.WriteLine("Enter End Date");
            endDate = Console.ReadLine();
            Console.WriteLine("Enter Term Code");
            termCode = Console.ReadLine();
            Console.WriteLine("Enter Student Code");
            studentCode = Console.ReadLine();
            Console.WriteLine("Enter Instructor Code");
            instructorCode = Console.ReadLine();
            Program.termList.Add(new DrivingTerm { startDate = startDate, endDate = endDate, termCode = termCode, studentCode = studentCode, instructorCode = instructorCode });
        }

        public void List()
        {
            for (int j = 0; j < Program.termList.Count; j++)
            {

                Console.Write(Program.termList[j].startDate + "  ");
                Console.Write(Program.termList[j].endDate + "  ");
                Console.Write(Program.termList[j].termCode + "  ");
                Console.Write(Program.termList[j].studentCode + "  ");
                Console.WriteLine(Program.termList[j].instructorCode);

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
        public void Edite()
        {
            Console.WriteLine("Please Enter Term Code");
            termCode = Console.ReadLine();

            bool thereIsNational = Program.termList.Exists(x => x.termCode == termCode);

            if (thereIsNational == true)
            {
                var studentElement = from s in Program.termList
                                     where s.termCode == termCode
                                     select s;

                Console.WriteLine("Enter  Start Date");
                startDate = Console.ReadLine();
                Console.WriteLine("Enter End Date");
                endDate = Console.ReadLine();
                Console.WriteLine("Enter Student Code ");
                studentCode = Console.ReadLine();
                Console.WriteLine("Enter Instructor Code ");
                instructorCode = Console.ReadLine();

                foreach (var stu in studentElement)
                {
                    stu.startDate = startDate;
                    stu.endDate = endDate;
                    stu.studentCode = studentCode;
                    stu.instructorCode = instructorCode;
                }
            }


        }

        public void Delete()
        {
            Console.WriteLine("Please Entern Term Codete  ");
            termCode = Console.ReadLine();

            var stuntElement = from s in Program.termList
                               where s.termCode == termCode
                               select s;
            int find = 0;
            for (int counter = 0; counter < Program.termList.Count; counter++)
            {
                if (Program.termList[counter].termCode == termCode)
                {
                    Program.termList.RemoveAt(counter);
                    find = 1;
                }
            }
            if (find == 0)
                Console.WriteLine("there is no Machine whith this Nmber Plate ");
            else
                Console.WriteLine(" Driving Term Details Deleted");

        }
    }
}
