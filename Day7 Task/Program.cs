namespace Day7_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<Student, List<Subject>> dictionary = new();

            dictionary.Add(new Student(2030005, "Abdullah Nabil", 23),

                new List<Subject>
                {
                    new Subject(12, "C#", 13),
                    new Subject(100, "SQL", 20),
                    new Subject(31, "MVC", 30)
                }
            );

            dictionary.Add(new Student(123, "Ahmed Nabil", 30),

                new List<Subject>
                {
                    new Subject(23, "Java", 24), 
                    new Subject(43, "Spring Security", 40),
                    new Subject(42, "AWS", 40)
                }
            );

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key);
                foreach(var item2 in item.Value)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("-------------------------");
            }

        }
    }
    class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        public Subject(int id = 1, string name="", int duration= 12)
        {
            this.Id = id;
            this.Name = name;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return $"[{Id}]- {Name} \t ({Duration} hours)";
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id = 0, string name = "", int age = 18)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"[{Id}]- {Name} \t\t{Age} years old";
        }
    }
}
