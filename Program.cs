namespace Assignment2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Brennan", "Fischer", "A");
            Console.WriteLine("Student ID: " + student1.StudentId);
            Console.WriteLine("Student First Name: " + student1.StudentFName);
            Console.WriteLine("Student Last Name: " + student1.StudentLName);
            Console.WriteLine("Student Grade: " + student1.Grade);
        }
    }

    public class Student
    {
        private int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }
        private string _studentFName;
        public string StudentFName
        {
            get { return _studentFName; }
            set { _studentFName = value; }
        }
        private string _studentLName;
        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }
        }
        private string _grade;
        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public Student(int studentId, string _studentFName, string _studentLName, string _grade)
        {
            StudentId = studentId;
            StudentFName = _studentFName;
            StudentLName = _studentLName;
            Grade = _grade;
        }
    }


}
