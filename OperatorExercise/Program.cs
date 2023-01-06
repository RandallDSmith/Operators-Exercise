using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }
            else
            {
                return;
            }

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            AreaOfCircle(radius);
            Console.WriteLine(AreaOfCircle(radius));

        }
            public static double AreaOfCircle(double radius)
            {
                
                var area = Math.PI * Math.Pow(radius, 2);
                return area;
            }
        

    }
}
