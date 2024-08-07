using System.Globalization;
using System.Net.Cache;
using System.Transactions;

namespace Day4_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());

            var students = new Student[numOfStudents];

            for (int i = 0; i < numOfStudents; i++)
            {
                students[i] = new Student();

                Console.Write($"\tEnter the id of student [ {i+1} ]: ");
                students[i].Id =int.Parse( Console.ReadLine());

                Console.Write($"\tEnter the name of student [ {i+1} ]: ");
                students[i].Name = Console.ReadLine();

                Console.Write($"\tEnter the age of student: [ {i + 1} ]: ");
                students[i].Age = int.Parse(Console.ReadLine());

                Console.Write($"\tEnter the number of subjects for [ {students[i].Name} ] ==>  ");
                int numOfSubjects = int.Parse(Console.ReadLine());

                students[i].Subjects = new Subject[numOfSubjects];
                for (int j= 0; j < numOfStudents; j++)
                {
                    students[i].Subjects[j] = new Subject();
                    Console.Write($"\t\tEnter the id of subject [{j+1}]: ");
                    students[i].Subjects[j].Id = int.Parse( Console.ReadLine());

                    Console.Write($"\t\tEnter the name of subject [{j + 1}]: ");
                    students[i].Subjects[j].Name = Console.ReadLine();

                    Console.Write($"\t\tEnter the duration of subject [{j + 1}]: ");
                    students[i].Subjects[j].Duration= int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------");
                }
                Console.WriteLine("-----------------------------------------------------------");
            }
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine();

            foreach(Student student in students)
                Console.WriteLine(student);

            Console.ReadKey(true);
        }

    }

    class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Duration { get; set; }
        public Subject()
        {
            this.Id = 1;
            this.Duration = 12; 
        }
        public Subject(int id, string name, int duration)
        {
            this.Id = id;
            this.Name = name;
            this.Duration = duration;
        }
        public override string ToString()
        {
            return $"[{Id}] {Name} \t {Duration}";
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public Subject[]? Subjects { get; set; }

        public Student()
        {
            this.Id=1;
            this.Age = 18;
        }

        public Student(int id,string name)
            
        {
            this.Id = id;
            this.Name = name; 
        }
        public Student(int id, string name, int age, Subject[] subjects)
            :this(id, name)
        {
            this.Age = age;
            this.Subjects = subjects;
        }
        public override string ToString()
        {
            string txt = $"[{Id}] - {Name} - {Age}";
            foreach (var subject in Subjects)
                txt += $"\n\t ==>[{subject.Id}] {subject.Name}\t {subject.Duration}";
            return txt ;
        }
    }
}
