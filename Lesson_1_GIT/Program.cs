namespace Lesson_1_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0; 
            for (int i = 1; i <=100; i++)
            {
                Sum+= i;
            }
            Console.WriteLine($"Sum of all natural numbers from 1 to 100 {Sum}");
        }
    }
}