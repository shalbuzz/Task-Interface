using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Interface
{
    public class Group
    {
        private int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit { get;  set; }
                
            
         
        private Student[] students;  
        private int count = 0;

        public Group(string groupNo, int studentLimit)
        {
            if (!CheckGroupNo(groupNo))
            {
                Console.WriteLine("Invalid group number format.");
                return; 
            }
            if (studentLimit < 5 && studentLimit > 18)
            {
                Console.WriteLine("Student limit must be between 5 and 18.");
                return;
            }

            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students = new Student[StudentLimit];





        }
        public bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrEmpty(groupNo) || groupNo.Length != 5)
            {
                return false; 
            }

            return char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) &&
                   char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]);
        }



        public void AddStudent(Student student)
        {
            if (count < StudentLimit)
            {
                students[count++] = student;  
               
                Console.WriteLine($"Student {student.Fullname} has add a group.");
            }
            else
            {
                Console.WriteLine("Limit of students!!!");
            }
        }



        public Student GetStudent(int id)
        {

            foreach (var student in students)
            {
                if (student != null && student.Id == id)
                {
                    return student;
                }
            }
            return null;

        }

        public void ShowAllStudents()
        {
            Console.WriteLine("All students in the group:");
            foreach (var student in students)
            {
                if (student != null)
                {
                    student.StudentIhfo();
                }
            }
        }

        public Student[] GetAllStudents()
        {
            return students;
        }
    }

}
