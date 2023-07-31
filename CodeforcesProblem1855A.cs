// Codeforcess Problem Link : https://codeforces.com/problemset/problem/1855/A
// Status: Accepted
/*
Sample Input:- 
-------------
5
2
2 1
3
1 2 3
5
1 2 5 4 3
4
1 2 4 3
10
10 2 1 3 6 5 4 7 9 8

Sample Output:-
--------------
0
2
2
1
1
*/

namespace Problem1855A
{
    internal class Problem1855AClass
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            while (testCases > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] p = new int[n];
                string[] tokens = Console.ReadLine().Split();
                for(int i = 0; i < tokens.Length; i++)
                    p[i] = Convert.ToInt32(tokens[i]);
              
                int unhappyCount = 0;

                for(int i = 0; i < p.Length; i++)
                {
                    if (p[i] == (i + 1))
                    {
                        unhappyCount++;
                    }
                }

                if (unhappyCount == 0)
                    Console.WriteLine("0");
                else
                    Console.WriteLine("{0}",(int)Math.Ceiling((double) unhappyCount / 2));

                --testCases;
            }

        }
    }
}
