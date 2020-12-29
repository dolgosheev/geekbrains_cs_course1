using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HomeWork.Lesson8.Task1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Describe { get; set; }
        
        private DateTime birthDay;

        public DateTime BirthDay
        {
            get => birthDay;
            set
            {
                if (value > DateTime.Now) throw new ArgumentException("День рождения не может быть больше сегодняшнего дня");
                birthDay = value;
            }
        }

    }

    public class Employees
    {
        private List<Employee> list;
        private int index;


        public int CurrentIndex => index;

        public void Next()
        {
            if (list.Count > index + 1) index++;

        }

        public void Prev()
        {
            if (index > 0) index--;

        }

        public void Add(Employee employee)
        {
            list.Add(employee);
            index = list.Count - 1;
        }

        public void Remove()
        {
            list.RemoveAt(index);
            Prev();
        }

        public Employees()
        {
            list = new List<Employee>();
            index = -1;
        }

        public Employee CurrentEmployee
        {
            get
            {
                try
                {
                    return list[index];
                }
                catch
                {
                    return null;
                }
            }
        }

        public void Save(string fileName)
        {
            var xmlFormat = new XmlSerializer(typeof(List<Employee>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
            index = 0;
        }

        public void Load(string fileName)
        {
            var xmlFormat = new XmlSerializer(typeof(List<Employee>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Employee>)xmlFormat.Deserialize(fStream);
            fStream.Close();
            index = 0;
        }

    }
}