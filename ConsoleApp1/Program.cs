using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class People
    {
        public string name { get; set; }
        public int age { get; set; }
        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Hello()
        {
            Console.WriteLine($"Здравствуйте, {name}");
        }
    }
    public class Student : People
    {
        public int id { get; set; }
        public Student(string name, int age, int id) : base(name, age)
        {
            this.id = id;
        }
        public void Students()
        {
            Console.WriteLine($"Ваш id {id}");
        }
    }
    public class Teacher : People
    {
        public int id { get; set; }
        public string subject { get; set; }
        public Teacher(string name, int age, int id, string subject) : base(name,age) 
        {
            this.id = id;
            this.subject = subject;
        }
        public void Teachers()
        {
            Console.WriteLine($"Ваш id {id}");
            Console.WriteLine($"Ваш предмет {subject}");
        }
    }
    public class Subject : Teacher
    {
        public string Name_Subject { get; set; }
        public Subject(string Name_Subject, string name, int age, int id, string subject) : base(name, age, id, subject)
        {
            this.Name_Subject = Name_Subject;
        }
        public void Teachers_Subject()
        {
            Console.WriteLine($"{Name_Subject} ведет {name}, {age} лет, {id}");
        }
    }

}
