using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        private static Tuple<int, int, int> GetTuple(int a, int b, int c)
        {
            int min, mid, max;

            if (a <= b && a <= c)
            {
                min = a;
            }
            else if (b <= a && b <= c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (b >= a && b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            mid = a + b + c - min - max;

            return Tuple.Create(min, mid, max);
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> response = new List<IList<int>>();
            Dictionary<int, HashSet<Tuple<short, short>>> pairs =
                new Dictionary<int, HashSet<Tuple<short, short>>>();

            for (short i = 0; i < nums.Length - 1; ++i)
            {
                for (short j = (short)(i + 1); j < nums.Length; ++j)
                {
                    var currentSum = nums[i] + nums[j];
                    var tuple = new Tuple<short, short>(i, j);
                    if (!pairs.ContainsKey(currentSum))
                    {
                        pairs.Add(currentSum, new HashSet<Tuple<short,short>> { tuple });
                    }
                    else
                    {
                        pairs[currentSum].Add(tuple);
                    }
                }
            }
            HashSet<Tuple<int, int, int>> tempResponse = new HashSet<Tuple<int, int, int>>();
            for (int i = 0; i < nums.Length; ++i)
            {
                if (pairs.ContainsKey(-nums[i]))
                {
                    var resultPairs = pairs[-nums[i]]
                        .Where(x =>
                            x.Item1 != i &&
                            x.Item2 != i);
                    if (resultPairs.Any())
                    {
                        foreach (var pair in resultPairs)
                        {
                            var tuple = GetTuple(pair.Item1, pair.Item2, i);
                            tempResponse.Add(tuple);
                        }
                    }
                }
            }
            var itemsTuple = new HashSet<Tuple<int, int, int>>();
            foreach (var pair in tempResponse)
            {
                itemsTuple.Add(GetTuple(nums[pair.Item1], nums[pair.Item2], nums[pair.Item3]));
            }

            foreach (var tuple in itemsTuple)
            {
                response.Add(new List<int> { tuple.Item1, tuple.Item2, tuple.Item3 });
            }

            return response;
        }
    }
}
