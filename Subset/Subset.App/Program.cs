using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset.App
{
    public class Program
    {   
        /// <summary>
        /// Input: take a list of positive integers S (note it is a list, not a set, 
        ///             i.e. duplicates are allowed) and an integer p > 0.
        /// Output: a list of integers that is a subset of S whose elements 
        ///             sum to p.Return null if no such subset can be identified.
        /// Example: S = { 3, 10, 5, 17, 8, 7, 4, 4}, p = 21. The result could be {3, 10, 8}. 
        ///                 There might be many answers, you just need to return one. 
        ///                 {4, 4, 10, 3} is allowed, because 4 is duplicated in the input, 
        ///                 {8, 8, 5} is not allowed because 8 was not duplicated in the input.
        /// </summary>
        
        /* As the list size increases, the time of checking roughly increase exponentially (or factorially)
         *      which means 
         */
        static void Main(string[] args)
        {
            List<int> Set = new List<int> { 3, 10, 5, 17, 8, 7, 4, 4, 1, 16, 21, 19, 23 };
            int p = 23;

            // Step 1: base case: p is in the list
            if (S.Contains(p))
                Console.WriteLine("{", p, "}");

            // Step 2: filter out the ones that are MORE than the sum required
            List<int> ValidItems = Set.Where(a => a <= p).ToList();

            BruteForce(p, ValidItems);
            FindASet(p, ValidItems);

            while (Console.ReadKey().Key != ConsoleKey.Enter)
                { Console.WriteLine("Press <Enter> to quit"); }
        }
        // Depth First use a Stack

        static void BruteForce(int P, List<int> FilteredSet)
        {
            // Step 3: brute force check: check all possibilities start from 2-member sets
            foreach (int member in FilteredSet)
            {
                if (FilteredSet.Contains(P - member))                       // 2 members
                    Console.WriteLine("{{0},{1}}", member, P - member);
                foreach (int X in FilteredSet)                              // 3 members
                    if (FilteredSet.Contains(P - member - X))
                        Console.WriteLine("{{0},{1},{2}}", member, X , P - member - X);
                
                /* This can continue forever. While no improvement in run time. WCS requires exponential time
                 * Hence, random approach should be considered. */
            }
        }

        static void FindASet(int P, List<int> FilteredSet)
        {
            int Start = FilteredSet.Max();
            int FirstRemainder = P - Start;
            if (FirstRemainder <= Start)

                Console.WriteLine(FilteredSet);

            // Step 3: 
            for (int i = 2; ; ++i)
            {
                int DivideByTwo = (int)Math.Truncate((decimal)P / 2);

                // .Any() is it true for at least one;  .All() is it true for all
                // predicate
                FilteredSet.Contains(P - DivideByTwo ^ P - DivideByTwo + 1 ^ P - DivideByTwo - 1);
            }
        }


    }
}
