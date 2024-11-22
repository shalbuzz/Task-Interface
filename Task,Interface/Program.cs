namespace Task_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a fullName:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            User user = new User(fullName,email, password);
           

            
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Create new group");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                user.ShowInfo();
            }
            else if (choice == "2")
            {
                
                Console.WriteLine("Enter group number (e.g., AB123):");
                string groupNo = Console.ReadLine();
                Console.WriteLine("Enter student limit for the group (between 5 and 18):");
                int studentLimit = Convert.ToInt32(Console.ReadLine());

                
                Group group = new Group(groupNo, studentLimit);

                
                bool groupMenuRunning = true;
                while (groupMenuRunning)
                {
                    Console.WriteLine("1. Show all students");
                    Console.WriteLine("2. Get student by id");
                    Console.WriteLine("3. Add student");
                    Console.WriteLine("0. Quit");

                    string groupChoice = Console.ReadLine();

                    if (groupChoice == "1")
                    {
                        group.ShowAllStudents();
                    }
                    else if (groupChoice == "2")
                    {
                        Console.WriteLine("Enter student ID:");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        var student = group.GetStudent(studentId);
                        if (student != null)
                        {
                            student.StudentIhfo();
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                    }
                    else if (groupChoice == "3")
                    {
                        Console.WriteLine("Enter student's full name:");
                        string studentFullname = Console.ReadLine();
                        Console.WriteLine("Enter student's points:");
                        int studentPoint = Convert.ToInt32(Console.ReadLine());

                        Student student = new Student(studentFullname, studentPoint);
                        group.AddStudent(student);
                        Console.WriteLine("Student added.");
                    }
                    else if (groupChoice == "0")
                    {
                        groupMenuRunning = false;
                        Console.WriteLine("Exiting group menu.");
                    }
                }
            }
        }
    }


}






