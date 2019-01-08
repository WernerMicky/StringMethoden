using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                 new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                 new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                 new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                 //new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                 //new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};
            string ein = string.Empty;
            string zwei = string.Empty;
            string drei = string.Empty;
            //ein = string.Join(" Mit ", studentList.Select(p => p.StudentName));
            //zwei = string.Join(" mit ", studentList.Select(p => p.StudentName).Take(2));

            //String.Take nimmt mir die ersten zwei 
            drei = string.Join(" mit ", studentList.Select(p => p.StudentName).Take(2));
            if (studentList.Count > 2)
                //String.Skip nimmt den wert ab der zweiten stelle
                drei += " und ";
            drei += string.Join(" und ", studentList.Select(p => p.StudentName).Skip(2));

            #region ausbaufähig
            StringBuilder c = new StringBuilder();

            c.AppendFormat(string.Join(" mit ", studentList.Select(p => p.StudentName).Take(2)));
            c.AppendFormat(string.Join(" und ", studentList.Select(p => p.StudentName).Skip(2)));
            string k = c.ToString();
            //Console.WriteLine("string" + k);
            #endregion
            Console.WriteLine(studentList.Count);

            Console.WriteLine(drei);

            Console.ReadKey();

        }
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }


  
    }
}
