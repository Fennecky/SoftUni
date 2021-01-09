using System;

namespace Student_Class
{
    class Program
    {
        class Student
        {
            public string name;
            public int age;
            public int id;

            public Student(string name, int age, int id)
            {
                this.name = name;
                this.age = age;
                this.id = id;
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("Esther", 2500, 444888);

            Console.WriteLine(s.name);
            Console.WriteLine(s.age);
            Console.WriteLine(s.id);
        }
    }
}
