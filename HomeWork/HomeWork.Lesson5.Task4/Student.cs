namespace HomeWork.Lesson5.Task4
{
    internal class Student
    {
        internal string FirstName { get; }
        internal string LastName { get; }
        internal double Gpa { get; }

        public Student(string lname,string fname,double gpa)
        {
            FirstName = fname;
            LastName = lname;
            Gpa = gpa;
        }
    }
}