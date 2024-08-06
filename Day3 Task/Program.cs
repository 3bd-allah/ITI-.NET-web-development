
namespace Day3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number of Complex Numbers: ");
            int numOfComplexnum = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            ComplexNumber[] arr = new ComplexNumber[numOfComplexnum];

            for (int i = 0; i < numOfComplexnum; i++)
            {
                Console.WriteLine($"Enter Data for ComplexNumber [{i+1}]");
                Console.WriteLine($"Enter the real of num{i+1}");
                arr[i].Real = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the Img of num{i + 1}");
                arr[i].Img= int.Parse(Console.ReadLine());
                Console.WriteLine("==============================");
            }

            foreach (var complex in arr)
                Console.WriteLine(complex);

            Console.ReadKey(true);
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
