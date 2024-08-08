using System.ComponentModel;
using System.Threading.Channels;

namespace Day5_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person(1,"Ali", 23);
            Teacher teacher = new Teacher(1, "Tasnem", 27, "C#", 20);
            Student student = new Student(1, "Abdullah", 27, "01017689277");

            Test t = new Test();
            t.Display(person);
            Console.WriteLine("------------------");
            t.Display(teacher);
            Console.WriteLine("------------------");
            t.Display(student);

        }
    }

   class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age{ get; set; }

        
        public Person(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public virtual void Show()
        {
            Console.WriteLine("Hello from person");
            Console.WriteLine($"[{Id}]-{Name}-{Age}");
        }
    }

    class Teacher : Person
    {
        public string SubjectName { get; set; }
        public int NumOfHours { get; set; }

        public Teacher(int id, string name, int age, string subjectName, int numOfHours)
            :base(id, name, age) 
        {
            this.SubjectName = subjectName;
            this.NumOfHours = numOfHours;
        }

        public override void Show()
        {
            Console.WriteLine("Hello from Teacher");
            Console.WriteLine($"[{Id}]-{Name}-{Age}-\t{SubjectName}  [{NumOfHours}]");
        }
    }

    class Student : Person
    {
        public string ParentPhone { get; set; }

        public Student(int id, string name, int age, string parentPhone)
            : base(id, name, age)
        {
            this.ParentPhone = parentPhone;
        }

        public override void Show()
        {
            Console.WriteLine($"Hello form Student");
            Console.WriteLine($"[{Id}]-{Name}-{Age}-\t[{ParentPhone}] ");
        }
    }

    class Test
    {
        public void Display(Person p)
        {
            p.Show();
        }
    }
}
