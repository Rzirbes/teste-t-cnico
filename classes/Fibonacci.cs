namespace MyCSharpProject.Classes
{
    public class Fibonacci
    {
        public static bool IsInFibonacciSequence(int number)
        {
            int a = 0;
            int b = 1;
            while (b < number)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            return number == b || number == 0;
        }
    }
}
