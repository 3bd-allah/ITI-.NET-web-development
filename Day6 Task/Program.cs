using System.Collections;
using System.Net.Http.Headers;
using System.Numerics;

namespace Day6_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student(100, "Abdullah", 23);

            int i = (int)student;
            Console.WriteLine(i); // 100 

            string str =(string)student;
            Console.WriteLine(str); // Abdullah

            Console.WriteLine(student); // [id]- name age



        }
    }
    struct Complex
    {
        private int _img;
        public int Real { get; set; }
        public int Img
        {
            set
            {
                if(value < 0) 
                    _img = 0;
                _img = value;
            }
            get
            {
                return _img;
            }
        }

        public Complex(int real =0, int img=0)
        {
            this.Real = real;
            this.Img = img;
        }

        public static bool operator > (Complex a, Complex b) => a.Real>b.Real && a.Img > b.Img;
        public static bool operator < (Complex a, Complex b) => a.Real < b.Real && a.Img < b.Img;
        public static bool operator == (Complex a, Complex b) => a.Real == b.Real && a.Img == b.Img;
        public static bool operator != (Complex a, Complex b) => a.Real != b.Real && a.Img != b.Img;
        public static Complex operator ++(Complex c)
        {
            return new Complex(c.Real++, c.Img++);
        }
        public static Complex operator -- (Complex c)
        {
            return new Complex(c.Real--, c.Img--);
        }
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id= 0, string name= "", int age= 18)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public static bool operator > (Student s1, Student s2)
        {
            return s1.Age > s2.Age;
        }

        public static bool operator < (Student s1, Student s2) => s1.Age < s2.Age;

        public static bool operator == (Student s1, Student s2) => s1.Age == s2.Age;
        public static bool operator != (Student s1, Student s2) => s1.Age != s2.Age;

        public static explicit operator int(Student s) => s.Id;
        public static explicit operator string(Student s)=> s.Name;
        public override string ToString()
        {
            return $"[{Id}- {Name} {Age} years old]";
        }
    }

}
