using driving_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Driving_Center
{
    public class Instructore
    {
        public string firstName;
        public string lastName;
        public string nationalCode;
        public string instructoreCode;
        public string document;

        public void Registreation()

        {
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter nationalCode");
            string nationalCode = Console.ReadLine();

            Console.WriteLine("Enter instructoreCode");
            string instructoreCode = Console.ReadLine();

            Console.WriteLine("Enter document");
            string document = Console.ReadLine();

            Program.instructoreList.Add(new Instructore { firstName = firstName, lastName = lastName, nationalCode = nationalCode, instructoreCode = instructoreCode, document = document });
        }
        public void List()
        {

            for (int j = 0; j < Program.instructoreList.Count; j++)
            {

                Console.Write(Program.instructoreList[j].firstName + "  ");
                Console.Write(Program.instructoreList[j].lastName + "  ");
                Console.Write(Program.instructoreList[j].nationalCode + "  ");
                Console.Write(Program.instructoreList[j].instructoreCode + "  ");
                Console.WriteLine(Program.instructoreList[j].document);

            }
        }
        private int search(string snationalcode, int instructioncounter, string[,] instructorarray)
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
        public void Edite()
        {
            Console.WriteLine("Please Enter National Code");
            nationalCode = Console.ReadLine();

            bool thereIsNational = Program.instructoreList.Exists(x => x.nationalCode == nationalCode);

            if (thereIsNational == true)
            {
                var studentElement = from s in Program.instructoreList
                                     where s.nationalCode == nationalCode
                                     select s;

                Console.WriteLine("Enter  FirstName");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter instructoreCode ");
                instructoreCode = Console.ReadLine();
                Console.WriteLine("Enter document ");
                document = Console.ReadLine();

                foreach (var stu in studentElement)
                {
                    stu.firstName = firstName;
                    stu.lastName = lastName;
                    stu.instructoreCode = instructoreCode;
                    stu.document = document;
                }
            }
            else
            {
                Console.WriteLine("There Is No Instructore With This National Code");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Please Enter National Code  ");
            nationalCode = Console.ReadLine();

            var stuntElement = from s in Program.instructoreList
                               where s.nationalCode == nationalCode
                               select s;
            int find = 0;
            for (int counter = 0; counter < Program.instructoreList.Count; counter++)
            {
                if (Program.instructoreList[counter].nationalCode == nationalCode)
                {
                    Program.instructoreList.RemoveAt(counter);
                    find =1   ;
                }
            }
            if (find == 0)
                Console.WriteLine("there is no Instructore whith this national Number");
            else

                Console.WriteLine(" Instructore Details Deleted");
        }
    }
}
