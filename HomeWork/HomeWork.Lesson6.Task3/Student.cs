namespace HomeWork.Lesson6.Task3
{
    internal class Student
    {
        internal string LastName { get; private set; }
        internal string FirstName { get; private set; }
        internal string Univercity { get; private set; }
        internal string Faculty { get; private set; }
        internal int Course { get; private set; }
        internal string Department { get; private set; }
        internal int Group { get; }
        internal string City { get; private set; }
        internal int Age { get; private set; }

        internal Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            LastName = lastName;
            FirstName = firstName;
            Univercity = univercity;
            Faculty = faculty;
            Department = department;
            Course = course;
            Age = age;
            Group = group;
            City = city;
        }


        public override string ToString()
        {
            return string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}{7,5}{8,10}", FirstName, LastName, Univercity, Faculty, Department, Age, Course, Group, City);
        }
    }
}