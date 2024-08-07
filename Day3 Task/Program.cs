using static System.Console;


namespace Day3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Write("Enter number of Complex Numbers: ");
            int numOfComplexnum = int.Parse(ReadLine());
            WriteLine("-------------------------------");

            ComplexNumber[] arr = new ComplexNumber[numOfComplexnum];

            for (int i = 0; i < numOfComplexnum; i++)
            {
                WriteLine($"Enter Data for ComplexNumber [{i+1}]");
                WriteLine($"Enter the real of num{i+1}");
                arr[i].Real = int.Parse(ReadLine());

                WriteLine($"Enter the Img of num{i + 1}");
                arr[i].Img= int.Parse(ReadLine());
                WriteLine("==============================");
            }

            foreach (var complex in arr)
                WriteLine(complex);

            ReadKey(true);
        }
    }

    struct ComplexNumber
    {
        private int _img;

        public int Real { get; set; }

        public int Img 
        {
            set
            {
                if (value >= 0)
                {
                    _img = value;
                }
                else
                {
                    _img = 0;
                }
            }
            get
            {
                return _img;
            }
        }
        public override string ToString()
        {
            return $"{Real}+{_img}i";
        }
    }
}
