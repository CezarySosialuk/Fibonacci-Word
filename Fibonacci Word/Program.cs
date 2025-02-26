namespace Fibonacci_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciWord(10));
        }

        static string FibonacciWord(int n)
        { 
            if (n < 2)
            {
                return "invalid";
            }

            string[] outarr = new string[n];

            outarr[0] = "a";
            outarr[1] = "b";

            for (int i=2; i<n; i++)
            {
                outarr[i] = outarr[i - 1] + outarr[i - 2];
            }

            string output = "";

            for (int i = 0; i < n; i++)
            {
                output+=outarr[i] + ", ";
            }

            return output;
        }

    }
}
