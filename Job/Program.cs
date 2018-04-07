using System;

namespace Job
{
    class Program
    {
        static int Ackermann(int m, int n)
        {
            int answer;

            if (m == 0)
            {
                answer = n + 1;
            }
            else if (n == 0)
            {
                answer = Ackermann(m - 1, 1);
            }
            else
            {
                answer = Ackermann(m - 1, Ackermann(m, m - 1));
            }
            return answer;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Ackermann {i}, {j}, {Ackermann(i, j)}");
                }
            }
        }
    }
}
