namespace CSharpTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 employee Data
            //// employee Data
            Console.Write(" Enter Your Name : ");
            string Name = Console.ReadLine();

            Console.Write(" Enter Your SSN : ");
            int ssn = int.Parse(Console.ReadLine());

            double salary;
            do
            {
                Console.Write(" Enter Your Salary : ");
                salary = double.Parse(Console.ReadLine());
            } while (salary <= 40000);


            int age;
            do
            {
                Console.Write(" Enter Your age : ");
                age = int.Parse(Console.ReadLine());
            } while (age <= 20);

            Console.WriteLine("------------------------");
            Console.WriteLine($"your name {Name}- your ssn {ssn} - your salary {salary} - your salary {age}");



            #endregion

            #region Task2 positive or negative
            Console.Write(" plz enter number : ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($" Number {number} is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"Number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"Number {number} is zero.");
            }



            #endregion

            #region Tak3 even ,odd
            Console.Write(" plz enter num : ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
            #endregion

            #region check if a rectangle is a square.
            Console.Write("Enter the length of square : ");
            double length =double.Parse(Console.ReadLine());

            Console.Write("Enter the width of square : ");
            double width = double.Parse(Console.ReadLine());


            if (length==width)

            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("rectangle is a square");
                Console.WriteLine($"Area= {length}*{width}={length* width} cm");
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("rectangle is not a square");
            }
            #endregion

        }
    }
}
